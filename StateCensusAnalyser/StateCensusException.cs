//</auto-generated/>
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// --------------------------------------------------------------------------------------------------------------------
namespace StateCensusAnalyser
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Create a StateException Class
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class StateCensusException : Exception
    {
        /// <summary>
        /// The message
        /// </summary>
        public string Message;
        /// <summary>
        /// Initializes a new instance of the <see cref="StateCensusException"/> class.
        /// create a constructore of  StateCensusException class
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public StateCensusException(string msg)
        {
            this.Message = msg;
        }
        /// <summary>
        /// Gets the get message.
        /// </summary>
        /// <value>
        /// The get message.
        /// </value>
        public string GetMessage { get => Message; }

        //public string GetMessage
        //{
        //     get{
        //        return message;
        //        }
        //}
    }
}
