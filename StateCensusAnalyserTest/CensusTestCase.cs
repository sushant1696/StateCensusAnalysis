// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// ---------------------------------------------------------------------------------------------------------------
using NUnit.Framework;
using StateCensusAnalyser;

namespace StateCensusAnalyserTest
{
    public class CensusTestCase
    {
        /// <summary>
        /// check the number of record match or not
        /// </summary>
        private static string path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.csv";
        [Test]
        public void CheckTo_ensure_the_Number_of_Record_matches()
        {
            int count1 = StateCensusAnalysis.ReadCsvFile(path);
            int count2 = CheckRecord.CheckedRecordMatch(path);
            Assert.AreEqual(count1, count2);
        }
        
        /// UseCase 1.2 when csv file incurrect return custom exception
        [Test]
        public void When_csv_file_incurrect_return_custom_Exception()
        {
            var ex = Assert.Throws<StateCensusException>(() => StateCensusAnalysis.ReadCsvFile(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.csv"));
            Assert.AreEqual("file path is incurrect", ex.GetMessage);
        }
    }
}