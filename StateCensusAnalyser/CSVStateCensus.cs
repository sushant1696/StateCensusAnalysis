// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// ---------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
   public class CSVStateCensus
    {
        /// <summary>
        /// Checkeds the record match.
        /// calculate the length of cvs file data 
        /// </summary>
        /// <param name="path2">The path.</param>
        /// <returns></returns>
        public static int CheckedRecordMatch(string path)
        {
                string[] data = File.ReadAllLines(path);
                return data.Length;
            
        }
    }
}
    

