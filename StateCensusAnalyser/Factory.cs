using System;
using System.Collections.Generic;
using System.Text;

namespace StateCensusAnalyser
{
   public class Factory
    {
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
