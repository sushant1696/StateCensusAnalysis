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
    /// <summary>
    /// Create a factory class
    /// </summary>
   public class Factory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public static IBuilder IsFactory(string types)
        {
            if (types.Equals("CSVStates"))
                return new CSVStates();
            else if (types.Equals("CSVStateCensus"))
                return new CSVStateCensus();
            else
                return null;
        }
    }
}
