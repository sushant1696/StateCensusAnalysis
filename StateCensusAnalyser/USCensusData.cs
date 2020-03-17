using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    public class USCensusData
    {
        public static void DisplayUSCensusData()
        {
            Chilkat.Csv csv = new Chilkat.Csv();

            //  Prior to loading the CSV file, indicate that the 1st row
            //  should be treated as column names:
            csv.HasColumnNames = true;

            //  Load the CSV records from the file:
            bool success;
            success = csv.LoadFile(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\USCensusData.csv");
            if (success != true)
            {
                Console.WriteLine(csv.LastErrorText);
                return;
            }

            //  Display the contents of the 3rd column (i.e. the country names)
            int row;
            int Columns;
            int n = csv.NumColumns;
            for (row = 0; row <= n - 1; row++)
            {
                for (Columns = 0; Columns < n - 1; Columns++)
                {
                    string ss = (csv.GetCell(row, Columns));
                    Console.WriteLine(ss);
                }
                Console.WriteLine("...........................");
                

            }

        }
        public static int LoadUSCensusData()
        {
            string[] data = File.ReadAllLines(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\USCensusData.csv");
            return data.Length;

        }
    }

}
