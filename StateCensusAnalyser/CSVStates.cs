using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    public class CSVStates
    {
        public static int CSVStateCodeMethod(string path2)
        {
            string[] data = File.ReadAllLines(path2);
            return data.Length;
        }
    }
}
