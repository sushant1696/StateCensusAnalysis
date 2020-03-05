using NUnit.Framework;
using StateCensusAnalyser;

namespace StateCensusAnalyserTest
{
    public class CensusTestCase
    {
        private static string path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.csv";
        [Test]
        public void CheckTo_ensure_the_Number_of_Record_matches()
        {
            int count1 = StateCensusAnalysis.ReadCsvFile(path);
            int count2 = CheckRecord.CheckedRecordMatch(path);
            Assert.AreEqual(count1, count2);
        }
    }
}