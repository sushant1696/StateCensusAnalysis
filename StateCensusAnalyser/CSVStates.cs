// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// --------------------------------------------------------------------------------------------------------------------
using ChoETL;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StateCensusAnalyser
{
    public delegate int DCsvState(string path, char delimiter = ',', string header = "SrNo,StateName,TIN,StateCode");

    public class CSVStates : IBuilder
    {
        public static string csvpath = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCode.csv";
        public int ReadCsvFile(string path, char delimiter, string header)
        {
            try
            {
                if (Path.GetExtension(path) == ".csv")
                {

                    string[] data = File.ReadAllLines(path);
                   
                    if (!data[0].Equals(header))
                    {
                        throw new StateCensusException("given_header_incorrect");
                    }
                    foreach (string str in data)
                    {
                        if (str.Split(delimiter).Length != 5 && str.Split(delimiter).Length != 4 && str.Split(delimiter).Length != 2)
                        {
                            throw new StateCensusException("given delimiter incorrect");
                        }
                    }
                    var lines = File.ReadLines(path);
                    var dictionary = lines.Select(line => line.Split(',')).ToDictionary(data => data[0], data => data[1]);

                    return dictionary.Count();
                    
                }
                
                else
                    throw new StateCensusException("Type of file is incorrect");
            }
            
            catch (FileNotFoundException)
            {
                throw new StateCensusException("file path is incorrect");
            }
           
        }
       
        /// <summary>
        /// Read CSVState code and write the CSVState code into json file 
        /// </summary>
        public void CSVJsonReadWrite()
        {

            string csv = File.ReadAllText(csvpath);
            StringBuilder sb = new StringBuilder();
            using (var p = ChoCSVReader.LoadText(csv)
                .WithFirstLineHeader())

            {
                using (var w = new ChoJSONWriter(sb))
                    w.Write(p);
            }
            File.WriteAllText(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusAnalyser\json1.json", sb.ToString());
            Console.WriteLine(sb.ToString());
        }
        /// <summary>
        /// Sorted the json file in order to state code 
        /// </summary>
        /// <param name="csvjsonpath"></param>
        /// <returns></returns>
        public static JArray CSVStateCodeSort(string csvjsonpath)
        {
            string json = File.ReadAllText(csvjsonpath);
            JArray CSVArray = JArray.Parse(json);
            for (int i = 0; i < CSVArray.Count - 1; i++)
            {
                for (int j = 0; j < CSVArray.Count - i - 1; j++)
                {
                    if (CSVArray[j]["StateCode"].ToString().CompareTo(CSVArray[j + 1]["StateCode"].ToString()) > 0)
                    {
                        var temp = CSVArray[j + 1];
                        CSVArray[j + 1] = CSVArray[j];
                        CSVArray[j] = temp;
                    }
                }
            }
            return CSVArray;
        }
        /// <summary>
        ///CSVstate code first state test 
        /// </summary>
        /// <param name="csvjsonpath"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string FirstStateCheck(string csvjsonpath, string key)
        {
            ///json file data store into a string variable
            string jsons = File.ReadAllText(csvjsonpath);
            ///string data store into a jason Array variable 
            JArray jarr = JArray.Parse(jsons);
            /// fisrt line key(state) store into string array
            string fstate = jarr[0][key].ToString();
            return fstate;
        }
        public static string LastStateCheck(string csvjsonpath, string key)
        {
            ///json file data store into a string variable
            string jsons = File.ReadAllText(csvjsonpath);
            ///string data store into a jason Array variable 
            JArray jarr = JArray.Parse(jsons);
            /// fisrt line key(state) store into string array
            string lstate = jarr[36][key].ToString();
            return lstate;
        }

    }
}
