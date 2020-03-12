// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    public delegate int DCsvState(string path, char delimiter = ',', string header = "SrNo,State,Name,TIN,StateCode");
    public class CSVStates: IBuilder
    {
        public int ReadCsvFile(string path, char delimiter = ',', string header = "SrNo,State,Name,TIN,StateCode")
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
                        if (str.Split(delimiter).Length != 5 && str.Split(delimiter).Length != 4)
                        {
                            throw new StateCensusException("given delimiter incorrect");
                        }
                    }
                    List<string> element = new List<string>();
                    foreach (var item in data)
                    {
                        element.Add(item);
                    }
                    return element.Count;
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
