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
    /// Create a delegate 
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="path"></param>
    /// <param name="delimiter"></param>
    /// <param name="header"></param>
    /// <returns></returns>
    public delegate int Builtdelegate(IBuilder builder, string path, char delimiter = ',', string header = "");
    public class Builder
    {
        static int results;
        /// <summary>
        /// Create a method of to calling the implementing classes method
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="path"></param>
        /// <param name="delimiter"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        public static int BuildMethod(IBuilder builder, string path, char delimiter = ',', string header = "")
        {
            try
            {
                ///invoke the ReadCsvFile method throw the builder object and store in results
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
