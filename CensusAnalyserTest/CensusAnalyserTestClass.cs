using CensusAnalyserProgram.POCO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using static CensusAnalyserProgram.CensusAnalyser;
namespace CensusAnalyserTestDemo
{
    class CensusAnalyserTest
    {
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        static string indianStateCensusFilePath = @"G:\Capgemini\CensusAnalyser\CensusAnalyserTest\Utility\IndiaStateCensusData.csv";
        static string indianStateCodeFilePath = @"G:\Capgemini\CensusAnalyser\IndianStatesCensusAnalyser\CensusAnalyserTest\Utility\IndiaStateCode.csv";
        CensusAnalyserProgram.CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        Dictionary<string, CensusDTO> stateRecord;
        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyserProgram.CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
            stateRecord = new Dictionary<string, CensusDTO>();
        }
        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            stateRecord = censusAnalyser.LoadCensusData(Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
            Assert.AreEqual(29, totalRecord.Count);
            Assert.AreEqual(37, stateRecord.Count);
        }
    }
}
