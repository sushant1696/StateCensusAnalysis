// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// ---------------------------------------------------------------------------------------------------------------
using ChoETL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text;
using static StateCensusAnalyser.CSVStateCensus;
using static StateCensusAnalyser.StateCensusAnalysis;

namespace StateCensusAnalyser
{
    class Program
    {
        private static string path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.csv";
        private static string path2 = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCode.csv";
        private static string csvpath = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCode.csv";
        private static string pathjson = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusAnalyser\CensusAnalyserJsonFile.json";
        public string pathCSVjson = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusAnalyser\CSVjsonFile.json";
        static void Main(string[] args)
        {
            /*Console.WriteLine("This is CSVStates class methods delegate process.......");
            / Create a object of delegate
             DCsvState delegateobj = new DCsvState(new CSVStates().ReadCsvFile);
            delegateobj(path2, ',', "SrNo,State,Name,TIN,StateCode");

            Console.WriteLine("This is CSVStatesCensus class methods delegate process.......");
            /Create a object of delegate
            DelReadCsvFile delegateobjj = new DelReadCsvFile(new CSVStateCensus().ReadCsvFile);
            delegateobjj(path, ',', "State,Population,AreaInSqKm,DensityPerSqKm");

            Console.WriteLine("This is StateCensusAnalysis class methods delegate process.......");
            /Create a object of delegateOf_CSVStateCodeMethod
            delegateOf_CSVStateCodeMethod delobj = new delegateOf_CSVStateCodeMethod(new StateCensusAnalysis().CSVStateCodeMethod);
            delobj(path);*/
            Console.WriteLine("count the no of line in the csv file");
            Console.WriteLine(new CSVStateCensus().ReadCsvFile(path, ',', "State,Population,AreaInSqKm,DensityPerSqKm"));
            Console.WriteLine(new CSVStates().ReadCsvFile(path2, ',', "SrNo,State,Name,TIN,StateCode"));

            //Console.WriteLine("This code for sorting the State census Analyser data in json file............");
            //JArray ja = StateCensusAnalysis.CensusAnalyserSort(pathjson);
            //var s = JsonConvert.SerializeObject(ja, Formatting.Indented);
            //File.WriteAllText(pathjson, s);

            Console.WriteLine("This code for Convert the csv to json of CSVStateCode......  ");
            CSVStates cs = new CSVStates();
            cs.CSVJsonReadWrite();
            //Console.WriteLine("csv state code sort...................");
            //CSVStates.CSVStateCodeSort(@"C: \Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusAnalyser\CSVjson.json");

            Console.WriteLine("This code for sorting the csvstate in json file............");
            string csvjsonpath = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusAnalyser\CSVjson.json";
            JArray ja = CSVStates.CSVStateCodeSort(csvjsonpath);
            var s = JsonConvert.SerializeObject(ja, Formatting.Indented);
            File.WriteAllText(csvjsonpath, s);
        }

    }

}
