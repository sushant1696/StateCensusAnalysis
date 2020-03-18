using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StateCensusAnalyser
{
    public class MergeCSVFile
    {
        List<string> list = new List<string>();
        string StateCode_path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusAnalyser\Files\StateCode.csv";
        string StateCensus_path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusAnalyser\Files\StateCensusData.csv";
        string header  = "SrNo,State Name,TIN,StateCode,Population,AreaInSqKm,DensityPerSqKm";
        int count;
        public void merge()
        {
            list.Add(header);
            
            string[] StateCode = File.ReadAllLines(StateCode_path);
            string[] CensusCode = File.ReadAllLines(StateCensus_path);
            for(int i = 1;i< StateCode.Length;i++)
            {
                count = 0;
                string[] StateCodeLine = StateCode[i].Split(',');
                for(int j = 1; j < CensusCode.Length; j++)
                {
                    string[] CensusCodeLine = CensusCode[j].Split(',');
                    mergefile(StateCode[i], CensusCode[j], StateCodeLine, CensusCodeLine);
                }
                if (count == 0)
                {
                    // It adds new State that is not common
                    // in both csv file;
                    string sa = String.Concat(StateCode[i]+",0,0,0,0");
                    list.Add(sa);

                }
            }
            File.WriteAllLines(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusAnalyser\Files\MergeOfTwoFile.csv", list);
            Console.WriteLine();
        }
        public void mergefile(string _code,string _census,string[] StateCodeLine, string[] CensusCodeLine)
        {
            if(StateCodeLine[1]== CensusCodeLine[0])
            {
                int a = _census.IndexOf(",");
                string sf = _census.Substring(a);
                string s = String.Concat(_code, sf);
                list.Add(s);
                count = 1;
            }
            
        }
    }
}
