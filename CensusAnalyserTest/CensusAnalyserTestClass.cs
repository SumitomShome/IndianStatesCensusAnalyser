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
        static string indianStateCensusFilePath = @"G:\Capgemini\CensusAnalyser\CensusAnalyserTest\Utility\IndiaStateCensusData.csv";
        CensusAnalyserProgram.CensusAnalyser censusAnalyser;
        Dictionary<string, CensusDTO> totalRecord;
        //Dictionary<string, CensusDTO> stateRecord;
        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyserProgram.CensusAnalyser();
            totalRecord = new Dictionary<string, CensusDTO>();
        }
        [Test]
        public void GivenIndianCensusDataFile_WhenReaded_ShouldReturnCensusDataCount()
        {
            totalRecord = censusAnalyser.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecord.Count);
        }
    }
}
