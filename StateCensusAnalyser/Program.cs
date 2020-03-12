// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// ---------------------------------------------------------------------------------------------------------------
using System;
using static StateCensusAnalyser.CSVStateCensus;
using static StateCensusAnalyser.StateCensusAnalysis;

namespace StateCensusAnalyser
{
    class Program
    { 
        private static string path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.csv";
        private static string path2 = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCode.csv";
        static void Main(string[] args)
        {
            Console.WriteLine("This is CSVStates class methods delegate process.......");
            /// Create a object of delegate
             DCsvState delegateobj = new DCsvState(new CSVStates().ReadCsvFile);
            delegateobj(path2, ',', "SrNo,State,Name,TIN,StateCode");

            Console.WriteLine("This is CSVStatesCensus class methods delegate process.......");
            ///Create a object of delegate
            DelReadCsvFile delegateobjj = new DelReadCsvFile(new CSVStateCensus().ReadCsvFile);
            delegateobjj(path, ',', "State,Population,AreaInSqKm,DensityPerSqKm");

            Console.WriteLine("This is StateCensusAnalysis class methods delegate process.......");
            ///Create a object of delegateOf_CSVStateCodeMethod
            delegateOf_CSVStateCodeMethod delobj = new delegateOf_CSVStateCodeMethod(new StateCensusAnalysis().CSVStateCodeMethod);
            delobj(path);
        }

    }
    
}
