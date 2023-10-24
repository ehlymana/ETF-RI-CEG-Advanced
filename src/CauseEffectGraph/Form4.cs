using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CauseEffectGraph
{
    public partial class Form4 : Form
    {
        #region Attributes

        Table table;

        #endregion

        #region Constructor

        public Form4(Table t)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            table = t;
            List<List<double>> results = new List<List<double>>();

            // calculate metrics for the forward-propagation algorithm
            results.Add(CalculateMetrics(table.FeasibleTestCases, table.NoOfCauses, table.NoOfEffects));

            // calculate metrics for the basic minimization algorithm
            table.GetMinimumTestCasesUnoptimized();
            results.Add(CalculateMetrics(table.MinimumCases, table.NoOfCauses, table.NoOfEffects));

            // calculate metrics for the optimized minimization algorithm
            table.GetMinimumTestCasesOptimized();
            results.Add(CalculateMetrics(table.MinimumCases, table.NoOfCauses, table.NoOfEffects));

            List<string> algorithmNames = new List<string>()
            { "Forward-propagation approach", "Basic minimization", "Optimized minimization" };

            // show all results on screen
            for (int i = 0; i < results.Count; i++)
            {
                dataGridView1.Rows.Add(new string[] { algorithmNames[i], Math.Round(results[i][0], 2).ToString(), Math.Round(results[i][1], 2).ToString() });
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculate EC and TEC values for the given set of test cases
        /// </summary>
        /// <param name="tests"></param>
        /// <param name="noOfCauses"></param>
        /// <param name="noOfEffects"></param>
        /// <returns></returns>
        List<double> CalculateMetrics(List<List<string>> tests, int noOfCauses, int noOfEffects)
        {
            bool[] activations = new bool[noOfEffects];

            foreach(List<string> test in tests)
            {
                for (int i = noOfCauses; i < noOfCauses + noOfEffects; i++)
                {
                    if (test[i] == "1")
                        activations[i - noOfCauses] = true;
                }
            }

            double EC = (double)activations.Count(a => a == true) / noOfEffects * 100,
                   TEC = (double)activations.Count(a => a == true) / tests.Count;

            return new List<double>() { EC, TEC };
        }

        #endregion
    }
}
