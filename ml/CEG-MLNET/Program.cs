using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using static Microsoft.ML.DataOperationsCatalog;

namespace CEG_MLNET
{
    internal class Program
    {
        static string _dataPath = Path.Combine(Environment.CurrentDirectory, "dataset_boolean.csv");

        static void Main(string[] args)
        {
            // import CEG data from CSV
            MLContext mlContext = new MLContext(seed: 0);
            IDataView dataView = mlContext.Data.LoadFromTextFile<CEGData>(_dataPath, hasHeader: true, separatorChar: ',');

            // split dataset to training and testing subsets
            TrainTestData splitDataView = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2);

            // create ML model
            var estimator = mlContext.BinaryClassification.Trainers.FastTree(labelColumnName: "Outcome", featureColumnName: "Features");

            // train ML model
            var trainedModel = estimator.Fit(splitDataView.TrainSet);

            // save pretrained ML model to file
            mlContext.Model.Save(trainedModel, dataView.Schema, "MLModel.zip");

            // test ML model
            IDataView testDataPredictions = trainedModel.Transform(splitDataView.TestSet);

            // get confusion matrix
            var trainedModelMetrics = mlContext.BinaryClassification.Evaluate(testDataPredictions, labelColumnName: "Outcome");

            Console.WriteLine("Model accuracy: " + trainedModelMetrics.Accuracy);
            Console.WriteLine("Model F1 score: " + trainedModelMetrics.F1Score);
            Console.WriteLine("Confusion matrix: " + trainedModelMetrics.ConfusionMatrix.GetFormattedConfusionTable());

            // test on only a single feasible and infeasible data sample
            CEGData testRowOK = new CEGData()
            {
                Features = new float[] { 1, 1, 2, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            CEGData testRowNOK = new CEGData()
            {
                Features = new float[] { 66, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            // create array containing both data rows
            CEGData[] rows = new CEGData[] { testRowOK, testRowNOK };

            // transform data for ML model input
            IDataView dataRows = mlContext.Data.LoadFromEnumerable(rows);

            // load pretrained model
            DataViewSchema modelSchema;
            ITransformer trainedModelFromFile = mlContext.Model.Load("MLModel.zip", out modelSchema);

            // test model on data
            IDataView transformedTestData = trainedModelFromFile.Transform(dataRows);
            
            // acquire results and display them
            List<FeasibilityPrediction> predictions = mlContext.Data.CreateEnumerable<FeasibilityPrediction>(transformedTestData, reuseRowObject: false).ToList();

            Console.WriteLine("Instance 1: TRUE LABEL IS FEASIBLE, PREDICTED LABEL IS " + (predictions[0].PredictedLabel ? "" : "IN") + "FEASIBLE");
            Console.WriteLine("Instance 2: TRUE LABEL IS INFEASIBLE, PREDICTED LABEL IS " + (predictions[1].PredictedLabel ? "" : "IN") + "FEASIBLE");
        }
    }
}
