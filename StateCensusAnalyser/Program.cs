// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// ---------------------------------------------------------------------------------------------------------------
using System;
namespace StateCensusAnalyser
{
    class Program
    {
       
        private static string path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.csv";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Census Analyser");
            int v = StateCensusAnalysis.ReadCsvFile(path);
            Console.WriteLine(v);
            Console.WriteLine(CSVStateCensus.CheckedRecordMatch(path));
        }

    }
    
}
