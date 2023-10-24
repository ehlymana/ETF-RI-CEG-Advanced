using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CauseEffectGraph
{
    public class Table
    {
        #region Attributes

        int noOfCauses = 0, noOfEffects = 0;

        List<List<string>> feasibleCombinations = new List<List<string>>(),
                           minimumCases = new List<List<string>>();

        List<string> headerColumn = new List<string>(),
                     headerRow = new List<string>();

        List<int> minimumCasesIndexes = new List<int>();

        double elapsed = 0;
        int minimizationAlgorithm = 1;

        #endregion

        #region Properties

        public int NoOfCauses { get => noOfCauses; set => noOfCauses = value; }
        public int NoOfEffects { get => noOfEffects; set => noOfEffects = value; }
        public List<List<string>> FeasibleTestCases { get => feasibleCombinations; set => feasibleCombinations = value; }
        public List<List<string>> MinimumCases { get => minimumCases; set => minimumCases = value; }
        public List<int> MinimumCasesIndexes { get => minimumCasesIndexes; set => minimumCasesIndexes = value; }
        public List<string> HeaderColumn { get => headerColumn; set => headerColumn = value; }
        public List<string> HeaderRow { get => headerRow; set => headerRow = value; }
        public double Elapsed { get => elapsed; set => elapsed = value; }

        #endregion

        #region Constructor

        public Table(ref List<Node> causes, ref List<Node> effects, ref List<Node> intermediates, ref List<Relation> logicalRelations, ref List<Relation> dependencyRelations)
        {
            noOfCauses = causes.Count;
            noOfEffects = effects.Count;

            // creating lists of test cases from provided graph info
            GenerateTestCases(ref causes, ref effects, ref intermediates, ref dependencyRelations, ref logicalRelations);

            // determining column and row headers

            // first, we need to sort the causes and effects ascending
            causes = causes.OrderBy(c => c.Index).ToList();
            effects = effects.OrderBy(e => e.Index).ToList();

            // header column contains the names of all nodes
            causes.ForEach(cause => headerColumn.Add("C" + cause.Index));
            effects.ForEach(effect => headerColumn.Add("E" + effect.Index)); ;

            // header row needs to be calculated for all test cases
            CreateHeader();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculate the next combination value
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <returns></returns>
        public string BinaryCounter(string currentNumber)
        {
            string[] digits = currentNumber.Select(c => c.ToString()).ToArray();
            int i = digits.Length - 1;
            bool ok = false;
            while (!ok)
            {
                if (i < 0)
                    return "";
                else if (digits[i] == "0")
                {
                    digits[i] = "1";
                    ok = true;
                    break;
                }
                else
                {
                    digits[i] = "0";
                    i--;
                }
            }
            return String.Join("", digits);
        }

        /// <summary>
        /// Helper function used to sort the combinations
        /// by using the total number of active effects
        /// (more active effects -> larger total sum)
        /// </summary>
        /// <param name="binaryNumber"></param>
        /// <returns></returns>
        int GiveSum(List<string> binaryNumber)
        {
            // only effects are important for calculating the sum
            List<string> effects = binaryNumber.GetRange(noOfCauses, noOfEffects);
            int numberOfActiveEffects = 0;

            // if an effect is active, increase the sum
            foreach (var effect in effects)
            {
                if (effect == "1")
                    numberOfActiveEffects++;
            }
            return numberOfActiveEffects;
        }

        /// <summary>
        /// Helper function for turning binary value into decimal value
        /// used for sorting the feasible test cases
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static int ReturnDecimalValue(List<string> testCase)
        {
            double decimalValue = 0;
            int startIndex = testCase.Count - 1;
            for (int i = 0; i < testCase.Count; i++)
            {
                if (testCase[startIndex] == "1")
                    decimalValue += Math.Pow(2, i);
                startIndex--;
            }

            return (int)decimalValue;
        }

        /// <summary>
        /// Helper function for naming the test cases (T1, T2,...)
        /// </summary>
        public void CreateHeader()
        {
            // refresh header
            headerRow.Clear();

            int caseNumber = 0;

            // header for allowed combinations only
            caseNumber = feasibleCombinations.Count;

            // creating the header in the form of T1, T2,...
            for (int i = 0; i < caseNumber; i++)
                headerRow.Add("T" + (i + 1));
        }

        /// <summary>
        /// Calculate both valid and minimum combinations
        /// If slow mode is activated, forbidden combinations are added to the list too
        /// Due to the exponential rise in test case number, fast mode uses valid combinations only
        /// </summary>
        /// <param name="causes"></param>
        /// <param name="effects"></param>
        /// <param name="dependencyRelations"></param>
        /// <param name="logicalRelations"></param>
        void GenerateTestCases(ref List<Node> causes, ref List<Node> effects, ref List<Node> intermediates, ref List<Relation> dependencyRelations, ref List<Relation> logicalRelations)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<string> names = new List<string>();

            // classify all combinations into lists of feasible and combinations
            ClassifyAllCombinations(ref causes, ref effects, ref intermediates, ref dependencyRelations, ref logicalRelations);

            // sort the combinations in an ascending order
            feasibleCombinations = feasibleCombinations.OrderBy(testCase => Table.ReturnDecimalValue(testCase)).ToList();

            // calculate the minimum test cases from feasible combinations
            GetMinimumTestCasesUnoptimized();

            sw.Stop();

            elapsed = sw.Elapsed.TotalMilliseconds;
        }

        /// <summary>	
        /// Calculate minimum test cases again by using the new algorithm type	
        /// 1: non-optimized minimization algorithm	
        /// 2: optimized minimization algorithm	
        /// </summary>	
        /// <param name="newMinimizationAlgorithm"></param>	
        public void ChangeMinimizationAlgorithm(int newMinimizationAlgorithm)
        {
            minimizationAlgorithm = newMinimizationAlgorithm;
            // calculate the minimum test cases by using the unoptimized algorithm	
            if (minimizationAlgorithm == 1)
                GetMinimumTestCasesUnoptimized();
            // calculate the minimum test cases by using the optimized algorithm	
            else
                GetMinimumTestCasesOptimized();
        }

        /// <summary>
        /// Helper method for determining whether each combination is forbidden or feasible
        /// </summary>
        /// <param name="causes"></param>
        /// <param name="effects"></param>
        /// <param name="intermediates"></param>
        /// <param name="dependencyRelations"></param>
        /// <param name="logicalRelations"></param>
        /// <returns></returns>
        public void ClassifyAllCombinations(ref List<Node> causes, ref List<Node> effects, ref List<Node> intermediates, ref List<Relation> dependencyRelations, ref List<Relation> logicalRelations)
        {
            bool forbidden = false;

            // initialize the first combination (0x0000)
            string combinationString = "";
            causes.ForEach(c => combinationString += "0");

            // every combination must be checked for all relations
            // if any of the relations return FALSE, automatically drop the combination
            while (combinationString != "")
            {
                forbidden = false;

                List<string> combination = combinationString.Select(c => c.ToString()).ToList();

                // check dependency relations first to rule out the combination if possible
                // dependency relations do not contain intermediate nodes and use just one type of nodes
                // so no calculation is necessary
                // MSK relations will be skipped because the combination does not contain effects for now
                var dependencyRelationsWithoutMSK = dependencyRelations.FindAll(r => r.Type != "MSK");
                foreach (var relation in dependencyRelationsWithoutMSK)
                {
                    List<string> causeValues = new List<string>();
                    // extract all cause values
                    foreach (var cause in relation.Causes)
                        causeValues.Add(combination.ElementAt(cause.Index - 1).ToString());

                    // check if the combination is forbidden
                    if (IsForbiddenCombination(relation.Type, causeValues, null))
                    {
                        forbidden = true;
                        break;
                    }
                }

                // if the combination is still fesible, calculate effect values
                if (!forbidden)
                {
                    // calculate the results of all logical relations next
                    // (due to the existance of intermediate nodes, multiple relation calculations
                    // might be necessary to get the effect values)

                    // initialize cause results
                    causes = causes.OrderBy(c => c.Index).ToList();
                    for (int i = 0; i < causes.Count; i++)
                        causes[i].Result = combination[i] == "1" ? true : false;

                    // initialize intermediate results
                    List<string> triggeredIntermediate = new List<string>();
                    for (int i = 0; i < intermediates.Count; i++)
                        triggeredIntermediate.Add("0");

                    // find all relations in form C => I
                    var relCI = logicalRelations.FindAll(r => r.Causes.Find(c => c.Type == "I") == null && r.Effects.Find(e => e.Type == "I") != null);
                    List<int> INumbers = new List<int>();
                    relCI.ForEach(r => INumbers.Add(r.Effects[0].Index));
                    relCI.ForEach(r => r.CalculateResult());

                    // update all intermediate values
                    foreach (var relation in relCI)
                        if (relation.Result)
                            intermediates[relation.Effects[0].Index - 1].Result = true;

                    // find all relations in form C, I => I or I => I where I has already been calculated
                    var relCII = logicalRelations.FindAll(r => r.Causes.Find(c => c.Type == "I" && INumbers.Contains(c.Index)) != null && r.Causes.Find(c => c.Type == "I" && !INumbers.Contains(c.Index)) == null && r.Effects.Find(e => e.Type == "I") != null);
                    relCII.ForEach(r => r.CalculateResult());

                    // update all intermediate values
                    foreach (var relation in relCI)
                        if (relation.Result)
                            intermediates[relation.Effects[0].Index - 1].Result = true;
                    foreach (var relation in relCII)
                        if (relation.Result)
                            intermediates[relation.Effects[0].Index - 1].Result = true;

                    // find all relations where I has not been calculated before
                    var relII = logicalRelations.FindAll(r => r.Causes.Find(c => c.Type == "I" && !INumbers.Contains(c.Index)) != null && r.Effects.Find(e => e.Type == "I") != null);
                    relII.ForEach(r => r.CalculateResult());

                    // update all intermediate values
                    foreach (var relation in relCI)
                        if (relation.Result)
                            intermediates[relation.Effects[0].Index - 1].Result = true;
                    foreach (var relation in relCII)
                        if (relation.Result)
                            intermediates[relation.Effects[0].Index - 1].Result = true;
                    foreach (var relation in relII)
                        if (relation.Result)
                            intermediates[relation.Effects[0].Index - 1].Result = true;

                    // find all relations with E as effect
                    var relE = logicalRelations.FindAll(r => r.Effects.Find(e => e.Type == "E") != null);
                    relE.ForEach(r => r.CalculateResult());

                    // check all logical relations to calculate the effects value
                    // relations where intermediate nodes are effects are excluded
                    var relationsWithoutIntermediates = logicalRelations.FindAll(r => r.Effects.Find(e => e.Type == "I") == null);

                    // at least one of the relations needs to amount to true effects, whereas for false effect no relation needs to amount to it
                    List<string> triggeredEffect = new List<string>();
                    for (int i = 0; i < noOfEffects; i++)
                        triggeredEffect.Add("0");

                    // capture trigger (1 for true == true, stays 0 if no relation is activated)
                    foreach (var relation in relationsWithoutIntermediates)
                    {         
                        if (relation.Result)
                            triggeredEffect[relation.Effects[0].Index - 1] = "1";
                    }

                    // add effect values to the combination
                    foreach (var effect in triggeredEffect)
                        combination.Add(effect);

                    // check if any MSK relations are violated
                    var dependencyRelationsMSK = dependencyRelations.FindAll(r => r.Type == "MSK");
                    foreach (var relation in dependencyRelationsMSK)
                    {
                        List<string> effectValues = new List<string>();

                        // extract all effect values
                        foreach (var effect in relation.Effects)
                            effectValues.Add(combination.ElementAt(noOfCauses - 1 + effect.Index).ToString());

                        // check if the combination is forbidden
                        if (IsForbiddenCombination(relation.Type, null, effectValues))
                        {
                            forbidden = true;
                            break;
                        }
                    }
                }

                // dropping the combination if it is forbidden for any of the reasons above

                // the combination was not dropped - add it to the list of valid combinations
                if (!forbidden)
                    feasibleCombinations.Add(combination.Select(c => c.ToString()).ToList());

                // calculate the next combination
                combinationString = BinaryCounter(combinationString);
            }
        }

        /// <summary>
        /// Helper method to determine whether the combination satisfies the result it should
        /// according to the type of dependency relation
        /// </summary>
        /// <param name="type"></param>
        /// <param name="causeValues"></param>
        /// <param name="effectValues"></param>
        /// <returns></returns>
        public bool IsForbiddenCombination(string type, List<string> causeValues, List<string> effectValues)
        {
            // EXC relation - maximum one 1 is allowed (CAUSES)
            if (type == "EXC" && causeValues.FindAll(x => x == "1").Count > 1)
                return true;

            // INC relation - minimum one 1 is allowed (CAUSES)
            else if (type == "INC" && !causeValues.Any(x => x == "1"))
                return true;

            // REQ relation - everything except true => false is allowed (CAUSES)
            else if (type == "REQ" && causeValues.ElementAt(0) == "1"
                && causeValues.ElementAt(1) == "0")
                return true;

            // MSK relation - everything except true => true is allowed (EFFECTS)
            else if (type == "MSK" && effectValues.ElementAt(0) == "1"
                && effectValues.ElementAt(1) == "1")
                return true;

            // EXC Δ INC relation - one and only one 1 is allowed (CAUSES)
            else if (type == "EXCINC" &&
                (!causeValues.Any(x => x == "1") ||
                    causeValues.FindAll(x => x == "1").Count > 1))
                return true;

            return false;
        }

        /// <summary>
        /// Helper method for determining which of the feasible test cases are minimal
        /// Version: unoptimized
        /// </summary>
        public void GetMinimumTestCasesUnoptimized()
        {
            minimumCases.Clear();
            minimumCasesIndexes.Clear();

            // first initialize the list of effect activations
            // it will be used to find the minimum test case list
            List<bool> activations = new List<bool>();
            for (int i = 0; i < noOfEffects; i++)
                activations.Add(false);

            // test cases with most effects active have the biggest priority 
            var feasibleCombinationsSorted = feasibleCombinations.OrderByDescending(x => GiveSum(x)).ToList();

            // move through the sorted test case list until all effects are activated
            foreach (var combination in feasibleCombinationsSorted)
            {
                // add all effect activations from the current combination
                List<string> combinationActivations = combination.GetRange(noOfCauses, noOfEffects);
                for (int i = 0; i < combinationActivations.Count; i++)
                {
                    if (combinationActivations[i] == "1" && !activations[i])
                        activations[i] = true;
                }

                // the combination will be added to the minimum test case list
                minimumCases.Add(combination);
                minimumCasesIndexes.Add(feasibleCombinations.IndexOf(combination));

                // finish when all effects are activated
                if (activations.All(x => x == true))
                    break;
            }
        }

        /// <summary>
        /// Helper method for determining which of the feasible test cases are minimal
        /// Version: optimized
        /// </summary>
        public void GetMinimumTestCasesOptimized()
        {
            minimumCases.Clear();
            minimumCasesIndexes.Clear();

            // first initialize the list of effect activations
            // it will be used to find the minimum test case list
            List<bool> activations = new List<bool>();
            for (int i = 0; i < noOfEffects; i++)
                activations.Add(false);

            // test cases with most effects active have the biggest priority 
            var feasibleCombinationsSorted = feasibleCombinations.OrderByDescending(x => GiveSum(x)).ToList();

            while (activations.Contains(false) && feasibleCombinationsSorted.Count > 0)
            {
                // add all effect activations from the current combination
                List<string> combinationActivations = feasibleCombinationsSorted[0].GetRange(noOfCauses, noOfEffects);
                for (int i = 0; i < combinationActivations.Count; i++)
                {
                    if (combinationActivations[i] == "1" && !activations[i])
                        activations[i] = true;
                }

                // add the test case into the minimum test case subset
                minimumCases.Add(feasibleCombinationsSorted[0]);
                minimumCasesIndexes.Add(feasibleCombinations.IndexOf(feasibleCombinationsSorted[0]));

                // delete the test case from remaining feasible test cases
                feasibleCombinationsSorted.Remove(feasibleCombinationsSorted[0]);

                // minimize the remaining feasible test cases by using activations
                feasibleCombinationsSorted = MinimizeByActivations(feasibleCombinationsSorted, activations);
            }
        }

        /// <summary>
        /// Perform test case suite prioritization by using test case strength
        /// </summary>
        /// <param name="testCases"></param>
        /// <param name="activations"></param>
        /// <returns></returns>
        List<List<string>> MinimizeByActivations(List<List<string>> testCases, List<bool> activations)
        {
            List<int> strengths = new List<int>();

            for (int i = 0; i < testCases.Count; i++)
            {
                // determine the strength of the current test case
                int strength = 0;

                List<string> testActivations = testCases[i].GetRange(noOfCauses, noOfEffects);
                for (int j = 0; j < testActivations.Count; j++)
                {
                    if (testActivations[j] == "1" && !activations[j])
                        strength++;
                }

                // if test is redundant, delete it
                if (strength == 0)
                {
                    testCases.RemoveAt(i);
                    i--;
                    continue;
                }
                else
                    strengths.Add(strength);
            }

            // prioritize remaining test cases by strength
            testCases = testCases.Zip(strengths, (test, strength) => new { test, strength, }).
                                  OrderBy(x => x.strength).Select(x => x.test).ToList();

            return testCases;
        }

        #endregion
    }
}
