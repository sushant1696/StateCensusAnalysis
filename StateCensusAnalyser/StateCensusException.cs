using System;
using System.Collections.Generic;
using System.Text;

namespace StateCensusAnalyser
{
    /// <summary>
    /// Create a StateException Class
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class StateCensusException : Exception
    {
        public string message;
        /// <summary>
        /// Initializes a new instance of the <see cref="StateCensusException"/> class.
        /// create a constructore of  StateCensusException class
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public StateCensusException(string msg)
        {
            this.message = msg;
        }
        /// <summary>
        /// Gets the get message.
        /// </summary>
        /// <value>
        /// The get message.
        /// </value>
        public string GetMessage { get => message; }

        //public string GetMessage
        //{
        //     get{
        //        return message;
        //        }
        //}
        
    }
}
