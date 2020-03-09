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
        private static string path2 = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCode.csv";
        /// <summary>
        /// Checks to ensure the number of record matches.
        /// Test case_1.1 check the number of record match or not
        /// </summary>
        [Test]
        public void CheckTo_ensure_the_Number_of_Record_matches()
        {
            int count1 = StateCensusAnalysis.ReadCsvFile(path);
            int count2 = CSVStateCensus.CheckedRecordMatch(path);
            Assert.AreEqual(count1, count2);
        }
        /// <summary>
        /// Whens the CSV file incurrect return custom exception.
        /// UseCase 1.2 when csv file incurrect return custom exception
        /// </summary>
       [Test]
        public void When_csv_file_incurrect_return_custom_Exception()
        {
            var ex = Assert.Throws<StateCensusException>(() => StateCensusAnalysis.ReadCsvFile(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusDatasss.csv"));
            Assert.AreEqual("file path is incorrect", ex.GetMessage);
        }
        /// <summary>
        /// Files the path currect but type is incurrect.
        /// usecse 1.3 file path is currect but extension of file is incurrect  
        /// </summary>
        [Test]
        public void FilePathCurrectButTypeIsIncurrect()
        {
            var ex = Assert.Throws<StateCensusException>(() => StateCensusAnalysis.ReadCsvFile(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensus.text"));
            Assert.AreEqual("Type of file is incorrect", ex.GetMessage);
        }
        /// <summary>
        /// Files the path currect butdelimiter incurect.
        /// TestCase 1.4 incurrect delemiter return a custom exception 
        /// </summary>
        [Test]
        public void FilePathCurrectButdelimiterIncurect()
        {
            var del = Assert.Throws<StateCensusException>(() => StateCensusAnalysis.ReadCsvFile(path, '.'));
            Assert.AreEqual("given delimiter incorrect", del.GetMessage);
        }
        /// <summary>
        /// Files the path currect but header incorrect.
        /// test case 1.5 where path is correct but header is incorrect
        /// </summary>
        [Test]
        public void FilePathCurrectBut_header_incorrect()
        {
            var del = Assert.Throws<StateCensusException>(() => StateCensusAnalysis.ReadCsvFile(path, '.', "State,Population,AreaInSqKm,DensityPerSqKmss"));
            Assert.AreEqual("given_header_incorrect", del.GetMessage);
        }
        /// <summary>
        /// Checks to ensure the number of record matches.
        /// Repeat usecase 2.1
        /// </summary>
        [Test]
        public void CheckTo_ensure_the_Number_of_Record_matches_of_StateCode()
        {
            int count3 = CSVStates.CSVStateCodeMethod(path2);
            int count4 = StateCensusAnalysis.ReadStateCode(path2);
            Assert.AreEqual(count3, count4);
        }

        /// <summary>
        /// Test case_2.1 Whens the  state code csv file is incurrect return custom exception.
        /// </summary>
        [Test]
        public void When_csv_file_state_code_is_incurrect_return_custom_Exception()
        {
            var ex = Assert.Throws<StateCensusException>(() => StateCensusAnalysis.ReadStateCode(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCodehhhhhh.csv"));
            Assert.AreEqual("Incurrect File", ex.GetMessage);
        }
        /// <summary>
        /// Test Case 2.3 File path currect but type is incurrect.
        /// </summary>
        [Test]
        public void StateCode_FilePath_Currect_But_Type_Is_Incurrect()
        {
            var ex = Assert.Throws<StateCensusException>(() => StateCensusAnalysis.ReadStateCode(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensus.text"));
            Assert.AreEqual("type incorrect", ex.GetMessage);
        }


    }
}