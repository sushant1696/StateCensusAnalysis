// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// --------------------------------------------------------------------------------------------------------------------
using ChoETL;
using java.util.logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    /// <summary>
    /// Create a StateCensusAnalysis class
    /// Read the csv file
    /// </summary>
    public class StateCensusAnalysis
    {
        /// <summary>
        /// Reads the CSV file.
        /// read the data from the csv file
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public delegate int delegateOf_CSVStateCodeMethod(string path);
        private static string path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.csv";
        public int CSVStateCodeMethod(string path)
        {
            string[] data = File.ReadAllLines(path);
            return data.Length;
        }
        /// <summary>
        /// Create a method to convert csv file to json file
        /// </summary>
        public void JsonReadWrite()
        {
            string csv = File.ReadAllText(path);
            StringBuilder sb = new StringBuilder();
            using (var p = ChoCSVReader.LoadText(csv)
                .WithFirstLineHeader())

            {
                using (var w = new ChoJSONWriter(sb))
                    w.Write(p);
            }
            File.WriteAllText(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusAnalyser\CensusAnalyserJsonFile.json", sb.ToString());
        }
        /// <summary>
        /// Sorted the json data state alphabatic order
        /// Using JArray with the help of bubble sort
        /// </summary>
        /// <param name="pathjson"></param>
        /// <returns></returns>
        public static JArray CensusAnalyserSort(string pathjson)
        {
            string json = File.ReadAllText(pathjson);
            JArray stateCensusArray = JArray.Parse(json);
            for(int i = 0; i < stateCensusArray.Count - 1; i++)
            {
                for(int j = 0; j < stateCensusArray.Count - i - 1; j++)
                {
                    if (stateCensusArray[j]["State"].ToString().CompareTo(stateCensusArray[j + 1]["State"].ToString()) > 0)
                    {
                        var temp = stateCensusArray[j + 1];
                        stateCensusArray[j + 1]= stateCensusArray[j];
                        stateCensusArray[j]=temp;
                    }
                }
                
            }

            return stateCensusArray;
        } 
       
    }
    
}
    
