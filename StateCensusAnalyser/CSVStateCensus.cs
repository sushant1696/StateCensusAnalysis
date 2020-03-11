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
    /// <summary>
    /// Creat a class CSVStateCensus
    /// </summary>
    public class CSVStateCensus
    {
        /// <summary>
        /// Reads the CSV file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="header">The header.</param>
        /// <returns></returns>
        /// <exception cref="StateCensusException">
        /// given_header_incorrect
        /// or
        /// given delimiter incorrect
        /// or
        /// Type of file is incorrect
        /// or
        /// file path is incorrect
        /// </exception>
        public delegate int DelReadCsvFile(string path, char delimiter = ',', string header = "State,Population,AreaInSqKm,DensityPerSqKm");
        public static int ReadCsvFile(string path, char delimiter = ',', string header = "State,Population,AreaInSqKm,DensityPerSqKm")
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

    }
}
    

