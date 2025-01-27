﻿
// This file was auto-generated by ML.NET Model Builder. 

using MLModel1_ConsoleApp1;
using System.IO;

// Create single instance of sample data from first line of dataset for model input
var imageBytes = File.ReadAllBytes(@"C:\Users\Coy\source\repos\Card Playing Robot Cell - 22\Card Playing Robot Cell\ML Card Images\Blue 0\imgDiscardPile20230930.212601261.png");
MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
{
    ImageSource = imageBytes,
};

// Make a single prediction on the sample data and print results.
var predictionResult = MLModel1.Predict(sampleData);
Console.WriteLine($"\n\nPredicted Label value: {predictionResult.PredictedLabel} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
