// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
namespace StateCensusAnalyser
{
    public class StateCensusAnalysis
    {
        public static int ReadCsvFile(string path)
        { 
           int count = 0;
        string[] data = File.ReadAllLines(path);
        IEnumerable<string> element = data;
            foreach (var item in element)
            {
                count++;
            }
            return count;
        }
    }
    
}
    
