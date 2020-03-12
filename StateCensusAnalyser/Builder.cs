// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace StateCensusAnalyser
{
    public delegate int Builtdelegate(IBuilder builder, string path, char delimiter = ',', string header = "");
    public class Builder
    {
       static int results;
        public static int BuildMethod(IBuilder builder,string path, char delimiter=',',string header = "")
        {
            try
            {
                results = builder.ReadCsvFile(path, delimiter, header);
            }
            catch (StateCensusException e)
            {
                throw e;
            }
            return results;
        }
    }
}
