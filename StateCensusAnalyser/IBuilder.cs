using System;
using System.Collections.Generic;
using System.Text;

namespace StateCensusAnalyser
{
   public interface IBuilder
    {
       
        int ReadCsvFile(string path, char delimiter, string header );
    }
}
