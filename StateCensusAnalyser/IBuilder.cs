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
    /// Create a interface
    /// </summary>
   public interface IBuilder
    {
       
        int ReadCsvFile(string path, char delimiter, string header );
    }
}
