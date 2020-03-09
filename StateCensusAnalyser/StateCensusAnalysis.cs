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
        public static int ReadCsvFile(string path,char delimiter=',',string header= "State,Population,AreaInSqKm,DensityPerSqKm")
        {
            try
            {
                if (Path.GetExtension(path) == ".csv")
                {
                    int count = 0;
                    string[] data = File.ReadAllLines(path);
                    if (!data[0].Equals(header))
                    {
                        throw new StateCensusException("given_header_incorrect");
                    }
                    foreach (string str in data)
                    {

                        if (str.Split(delimiter).Length != 4 && str.Split(delimiter).Length != 2)
                        {
                            throw new StateCensusException("given delimiter incorrect");
                        }
                    }
                    IEnumerable<string> element = data;
                    foreach (var item in element)
                    {
                        count++;
                    }
                    return count;
                }
                else
                    throw new StateCensusException("Type of file is incorrect");
            }
            catch (FileNotFoundException)
            {
                throw new StateCensusException("file path is incorrect");
            }
          
        }
        public static int ReadStateCode(string path2)
        {
            try
            {
                if (Path.GetExtension(path2) == ".csv")
                {
                    int count2 = 0;
                    string[] data = File.ReadAllLines(path2);
                    IEnumerable<string> element = data;
                    foreach (var items in element)
                    {
                        count2++;
                    }
                    return count2;
                }
                else
                    throw new StateCensusException("type incorrect");
            }
            catch (FileNotFoundException)
            {
                throw new StateCensusException("Incurrect File");
            }

        }
    }
    
}
    
