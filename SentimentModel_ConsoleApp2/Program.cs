﻿
// This file was auto-generated by ML.NET Model Builder. 

using SentimentModel_ConsoleApp2;

// Create single instance of sample data from first line of dataset for model input
SentimentModel.ModelInput sampleData = new SentimentModel.ModelInput()
{
    QiShu = 23012F,
    AAA001 = 3F,
    AAA002 = 4F,
    AAA003 = 7F,
    AAA004 = 22F,
    AAA005 = 26F,
    AAA006 = 30F,
    Year = 2023F,
};

// Make a single prediction on the sample data and print results
var predictionResult = SentimentModel.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual AAE001 with predicted AAE001 from sample data...\n\n");


Console.WriteLine($"QiShu: {23012F}");
Console.WriteLine($"AAA001: {3F}");
Console.WriteLine($"AAA002: {4F}");
Console.WriteLine($"AAA003: {7F}");
Console.WriteLine($"AAA004: {22F}");
Console.WriteLine($"AAA005: {26F}");
Console.WriteLine($"AAA006: {30F}");
Console.WriteLine($"AAE001: {6F}");
Console.WriteLine($"Year: {2023F}");


Console.WriteLine($"\n\nPredicted AAE001: {predictionResult.Score}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

