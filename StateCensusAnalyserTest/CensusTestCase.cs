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
        private static string path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.csv";
        /// <summary>
        /// Checks to ensure the number of record matches.
        /// Test case_1.1 check the number of record match or not
        /// </summary>
        [Test]
        public void CheckTo_ensure_the_Number_of_Record_matches()
        {
            int count1 = StateCensusAnalysis.ReadCsvFile(path);
            int count2 = CheckRecord.CheckedRecordMatch(path);
            Assert.AreEqual(count1, count2);
        }
        /// <summary>
        /// Whens the CSV file incurrect return custom exception.
        /// UseCase 1.2 when csv file incurrect return custom exception
        /// </summary>
        [Test]
        public void When_csv_file_incurrect_return_custom_Exception()
        {
            var ex = Assert.Throws<StateCensusException>(() => StateCensusAnalysis.ReadCsvFile(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensus.csv"));
            Assert.AreEqual("file path is incurrect", ex.GetMessage);
        }
        /// <summary>
        /// Files the path currect but type is incurrect.
        /// usecse 1.3 file path is currect but extension of file is incurrect  
        /// </summary>
        [Test]
        public void FilePathCurrectButTypeIsIncurrect()
        {
            var ex = Assert.Throws<StateCensusException>(() => StateCensusAnalysis.ReadCsvFile(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensus.text"));
            Assert.AreEqual("Type of file is incurrect", ex.GetMessage);
        }
        /// <summary>
        /// Files the path currect butdelimiter incurect.
        /// TestCase 1.4 incurrect delemiter return a custom exception 
        /// </summary>
        [Test]
        public void FilePathCurrectButdelimiterIncurect()
        {
            var del = Assert.Throws<StateCensusException>(() => StateCensusAnalysis.ReadCsvFile(path,'.'));
            Assert.AreEqual("given delimiter incurrect", del.GetMessage);
        }
    }
}