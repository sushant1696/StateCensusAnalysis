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
    /// <summary>
    /// creat a class CensusTestCase
    /// </summary>
    public class CensusTestCase
    {
        private static string path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.csv";
        private static string path2 = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCode.csv";
        /// <summary>
        /// Test case 1.1 Giventhes the states census cs vfile when analyse sould check to ensurethe number of recordmatches.
        /// </summary>
        [Test]
        public void GiventheStatesCensusCSVfile_whenAnalyse_SouldCheckToEnsuretheNumberOfRecordmatches()
        {
            int expect = StateCensusAnalysis.CSVStateCodeMethod(path);
            int  result= CSVStateCensus.ReadCsvFile(path);
            Assert.AreEqual(expect,result);
        }
        /// <summary>
        /// Test case 1.2 Givens the incorrectfile when analyse should throw censusu analyser exception.
        /// </summary>
        [Test]
        public void GivenIncorrectfile_WhenAnalyse_ShouldThrowCensusuAnalyserException()
        {
            var ex = Assert.Throws<StateCensusException>(() => CSVStateCensus.ReadCsvFile(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusDatasss.csv"));
            Assert.AreEqual("file path is incorrect", ex.GetMessage);
        }
        /// <summary>
        /// Test Case 1.3 Givens the state census CSV file correct but type incorrect when analyse sould returns custom exception.
        /// </summary>
        [Test]
        public void GivenTheStateCensusCSVFileCorrectButTypeIncorrect_WhenAnalyse_SouldReturnsCustomException()
        {
            var ex = Assert.Throws<StateCensusException>(() => CSVStateCensus.ReadCsvFile(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensus.text"));
            Assert.AreEqual("Type of file is incorrect", ex.GetMessage);
        }
        /// <summary>
        /// Test Case 1.4 Givens the state census CSV file correct but delimiter incorrect when analyse sould returnscustom exception.
        /// </summary>
        [Test]
        public void GivenTheStateCensusCSVFileCorrectButDelimiterIncorrect_WhenAnalyse_SouldReturnscustomException()
        {
            var del = Assert.Throws<StateCensusException>(() => CSVStateCensus.ReadCsvFile(path, '.'));
            Assert.AreEqual("given delimiter incorrect", del.GetMessage);
        }
        /// <summary>
        /// Test Case 1.5 Givens the incorrect header when analyse should throw census analyser exception.
        /// </summary>
       [Test]
        public void GivenIncorrectHeader_WhenAnalyse_ShouldThrowCensusAnalyserException()
        {
            var del = Assert.Throws<StateCensusException>(() => CSVStateCensus.ReadCsvFile(path, '.', "State,Population,AreaInSqKm,DensityPerSqKmss"));
            Assert.AreEqual("given_header_incorrect", del.GetMessage);
        }
        /// <summary>
        /// Test case 2.1 Giventhes the states code cs vfile when analyse sould check to ensurethe number of recordmatches.
        /// </summary>
        [Test]
        public void GiventheStatesCodeCSVfile_whenAnalyse_SouldCheckToEnsuretheNumberOfRecordmatches()
        {
            int expect = StateCensusAnalysis.CSVStateCodeMethod(path2);
            int result = CSVStates.ReadCsvFile(path2);
            Assert.AreEqual(expect,result);
        }
        /// <summary>
        /// Test case 2.2 Givens the incorrectfile when analyse should throw censusu analyser exception.
        /// </summary>
        [Test]
        public void GivenTheIncorrectfile_WhenAnalyse_ShouldThrowCensusuAnalyserException()
        {
            var ex = Assert.Throws<StateCensusException>(() => CSVStates.ReadCsvFile(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCodehhhhhh.csv"));
            Assert.AreEqual("file path is incorrect", ex.GetMessage);
        }
        /// <summary>
        /// TestCase 2.3 Givens the state census CSV file correct but type incorrect when analyse sould throw custom exception.
        /// </summary>
        [Test]
        public void GivenStateCensusCSVFileCorrectButTypeIncorrect_WhenAnalyse_SouldReturnsCustomException()
        {
            var ex = Assert.Throws<StateCensusException>(() => CSVStates.ReadCsvFile(@"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensus.text"));
            Assert.AreEqual("Type of file is incorrect", ex.GetMessage);
        }
        /// <summary>
        /// Test Case 2.4 Givens the state census CSV file correct but delimiter incorrect when analyse sould returnscustom exception.
        /// </summary>
        [Test]
        public void GivenStateCensusCSVFileCorrectButDelimiterIncorrect_WhenAnalyse_SouldReturnscustomException()
        {
            var dell = Assert.Throws<StateCensusException>(() => CSVStates.ReadCsvFile(path2, '.'));
            Assert.AreEqual("given delimiter incorrect", dell.GetMessage);
        }
        /// <summary>
        /// test case 2.5 Givens the incorrect header when analyse should throw census analyser exception.
        /// </summary>
        [Test]
        public void GivenTheIncorrectHeader_WhenAnalyse_ShouldThrowCensusAnalyserException()
        {
            var del = Assert.Throws<StateCensusException>(() => CSVStates.ReadCsvFile(path2, '.', "SrNo,State,Name,TIN,StateCodeIncorrectHeader"));
            Assert.AreEqual("given_header_incorrect", del.GetMessage);
        }

    }
}