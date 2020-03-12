// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StateCensusAnalyserProblem.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Sushanta Das"/>
// ---------------------------------------------------------------------------------------------------------------
using NUnit.Framework;
using StateCensusAnalyser;
using static StateCensusAnalyser.CSVStateCensus;
using static StateCensusAnalyser.StateCensusAnalysis;

namespace StateCensusAnalyserTest
{
    /// <summary>
    /// Creat a class CensusTestCase
    /// </summary>
    public class CensusTestCase
    {
        delegateOf_CSVStateCodeMethod delobj = new delegateOf_CSVStateCodeMethod(new StateCensusAnalysis().CSVStateCodeMethod);
        DCsvState delegateobj = new DCsvState(new CSVStates().ReadCsvFile);
        DelReadCsvFile delegateobjj = new DelReadCsvFile(new CSVStateCensus().ReadCsvFile);
        private static string path = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.csv";
       public static string wrongpath = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusDatawewe.csv";
        private static string wrongfiletype = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCensusData.txte";
        private static string path2 = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCode.csv";
        private static string wrongpath2 = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCodesdds.csv";
        private static string wrongfiletype2 = @"C:\Users\Bridgelabz\Documents\StateCensusAnalyserProject\StateCode.textsd";
        Builtdelegate build_delegate = new Builtdelegate(Builder.BuildMethod);
        /// <summary>
        /// Test case 1.1 Giventhes the states census cs vfile when analyse sould check to ensurethe number of recordmatches.
        /// </summary>
        [Test]
        public void GiventheStatesCensusCSVfile_whenAnalyse_SouldCheckToEnsuretheNumberOfRecordmatches()
        {
            var a=Factory.IsFactory("CSVStateCensus");
            var z= build_delegate(a,path,',', "State,Population,AreaInSqKm,DensityPerSqKm");
           // int expect = delobj(path);
            //int  result= delegateobjj(path);
            Assert.AreEqual(30,z);
        }
        /// <summary>
        /// Test case 1.2 Givens the incorrectfile when analyse should throw censusu analyser exception.
        /// </summary>
        [Test]
        public void GivenIncorrectfile_WhenAnalyse_ShouldThrowCensusuAnalyserException()
        {
            var obj = Factory.IsFactory("CSVStateCensus");
            var ex = Assert.Throws<StateCensusException>(() => build_delegate(obj, wrongpath,',', "State,Population,AreaInSqKm,DensityPerSqKm"));
            Assert.AreEqual("file path is incorrect", ex.GetMessage);
        }
        /// <summary>
        /// Test Case 1.3 Givens the state census CSV file correct but type incorrect when analyse sould returns custom exception.
        /// </summary>
        [Test]
        public void GivenTheStateCensusCSVFileCorrectButTypeIncorrect_WhenAnalyse_SouldReturnsCustomException()
        {
            var obj1 = Factory.IsFactory("CSVStateCensus");
            var ex = Assert.Throws<StateCensusException>(() => build_delegate(obj1,wrongfiletype,',', "State,Population,AreaInSqKm,DensityPerSqKm"));
            Assert.AreEqual("Type of file is incorrect", ex.GetMessage);
        }
        /// <summary>
        /// Test Case 1.4 Givens the state census CSV file correct but delimiter incorrect when analyse sould returnscustom exception.
        /// </summary>
        [Test]
        public void GivenTheStateCensusCSVFileCorrectButDelimiterIncorrect_WhenAnalyse_SouldReturnscustomException()
        {
            var obj1 = Factory.IsFactory("CSVStateCensus");
            var del = Assert.Throws<StateCensusException>(() => build_delegate(obj1, path, '.', "State,Population,AreaInSqKm,DensityPerSqKm"));
            Assert.AreEqual("given delimiter incorrect", del.GetMessage);
        }
        /// <summary>
        /// Test Case 1.5 Givens the incorrect header when analyse should throw census analyser exception.
        /// </summary>
       [Test]
        public void GivenIncorrectHeader_WhenAnalyse_ShouldThrowCensusAnalyserException()
        {
            var obj1 = Factory.IsFactory("CSVStateCensus");
            var del = Assert.Throws<StateCensusException>(() => build_delegate(obj1, path, '.', "asaState,Population,AreaInSqKm,DensityPerSqKm"));
            Assert.AreEqual("given_header_incorrect", del.GetMessage);
        }
        /// <summary>
        /// Test case 2.1 Giventhes the states code cs vfile when analyse sould check to ensurethe number of recordmatches.
        /// </summary>
        [Test]
        public void GiventheStatesCodeCSVfile_whenAnalyse_SouldCheckToEnsuretheNumberOfRecordmatches()
        {
            //int expect = new StateCensusAnalysis().CSVStateCodeMethod(path2);
            //int result = delegateobj(path2);
            var obj = Factory.IsFactory("CSVStates");
            var z = build_delegate(obj, path2, ',', "SrNo,State,Name,TIN,StateCode");
            Assert.AreEqual(38,z);
        }
        /// <summary>
        /// Test case 2.2 Givens the incorrectfile when analyse should throw censusu analyser exception.
        /// </summary>
        [Test]
        public void GivenTheIncorrectfile_WhenAnalyse_ShouldThrowCensusuAnalyserException()
        {
            var obj = Factory.IsFactory("CSVStates");
            var ex = Assert.Throws<StateCensusException>(() => build_delegate(obj, wrongpath2, ',', "SrNo,State,Name,TIN,StateCode"));
            Assert.AreEqual("file path is incorrect", ex.GetMessage);
        }
        /// <summary>
        /// TestCase 2.3 Givens the state census CSV file correct but type incorrect when analyse sould throw custom exception.
        /// </summary>
        [Test]
        public void GivenStateCensusCSVFileCorrectButTypeIncorrect_WhenAnalyse_SouldReturnsCustomException()
        {
            var obj1 = Factory.IsFactory("CSVStateCensus");
            var ex = Assert.Throws<StateCensusException>(() => build_delegate(obj1, wrongfiletype2, ',', "SrNo,State,Name,TIN,StateCode"));
            Assert.AreEqual("Type of file is incorrect", ex.GetMessage);
        }
        /// <summary>
        /// Test Case 2.4 Givens the state census CSV file correct but delimiter incorrect when analyse sould returnscustom exception.
        /// </summary>
        [Test]
        public void GivenStateCensusCSVFileCorrectButDelimiterIncorrect_WhenAnalyse_SouldReturnscustomException()
        {
            var obj1 = Factory.IsFactory("CSVStateCensus");
            var del = Assert.Throws<StateCensusException>(() => build_delegate(obj1, path2, '.', "SrNo,State,Name,TIN,StateCode"));
            Assert.AreEqual("given delimiter incorrect", del.GetMessage);
        }
        /// <summary>
        /// test case 2.5 Givens the incorrect header when analyse should throw census analyser exception.
        /// </summary>
        [Test]
        public void GivenTheIncorrectHeader_WhenAnalyse_ShouldThrowCensusAnalyserException()
        {
            var obj1 = Factory.IsFactory("CSVStateCensus");
            var del = Assert.Throws<StateCensusException>(() => build_delegate(obj1, path2, '.', "asaState,Population,AreaInSqKm,DensityPerSqKm"));
            Assert.AreEqual("given_header_incorrect", del.GetMessage);
        }

    }
}