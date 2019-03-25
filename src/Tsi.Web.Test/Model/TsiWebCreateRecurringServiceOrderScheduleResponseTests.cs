/* 
 * Tigerpaw API Method Reference
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 18.2.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Tsi.Web.Api;
using Tsi.Web.Model;
using Tsi.Web.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Tsi.Web.Test
{
    /// <summary>
    ///  Class for testing TsiWebCreateRecurringServiceOrderScheduleResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestClass]
    public class TsiWebCreateRecurringServiceOrderScheduleResponseTests
    {
        // TODO uncomment below to declare an instance variable for TsiWebCreateRecurringServiceOrderScheduleResponse
        //private TsiWebCreateRecurringServiceOrderScheduleResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // TODO uncomment below to create an instance of TsiWebCreateRecurringServiceOrderScheduleResponse
            //instance = new TsiWebCreateRecurringServiceOrderScheduleResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TsiWebCreateRecurringServiceOrderScheduleResponse
        /// </summary>
        [TestMethod]
        public void TsiWebCreateRecurringServiceOrderScheduleResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TsiWebCreateRecurringServiceOrderScheduleResponse
            //Assert.IsInstanceOfType<TsiWebCreateRecurringServiceOrderScheduleResponse> (instance, "variable 'instance' is a TsiWebCreateRecurringServiceOrderScheduleResponse");
        }


        /// <summary>
        /// Test the property 'NumberOfRecurringOrderSchedulesCreated'
        /// </summary>
        [TestMethod]
        public void NumberOfRecurringOrderSchedulesCreatedTest()
        {
            // TODO unit test for the property 'NumberOfRecurringOrderSchedulesCreated'
        }
        /// <summary>
        /// Test the property 'RecurringScheduleName'
        /// </summary>
        [TestMethod]
        public void RecurringScheduleNameTest()
        {
            // TODO unit test for the property 'RecurringScheduleName'
        }
        /// <summary>
        /// Test the property 'TemplateId'
        /// </summary>
        [TestMethod]
        public void TemplateIdTest()
        {
            // TODO unit test for the property 'TemplateId'
        }
        /// <summary>
        /// Test the property 'TemplateName'
        /// </summary>
        [TestMethod]
        public void TemplateNameTest()
        {
            // TODO unit test for the property 'TemplateName'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [TestMethod]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'TakenByRepNumber'
        /// </summary>
        [TestMethod]
        public void TakenByRepNumberTest()
        {
            // TODO unit test for the property 'TakenByRepNumber'
        }
        /// <summary>
        /// Test the property 'CreateAheadDays'
        /// </summary>
        [TestMethod]
        public void CreateAheadDaysTest()
        {
            // TODO unit test for the property 'CreateAheadDays'
        }
        /// <summary>
        /// Test the property 'ServiceOrderReceivedTime'
        /// </summary>
        [TestMethod]
        public void ServiceOrderReceivedTimeTest()
        {
            // TODO unit test for the property 'ServiceOrderReceivedTime'
        }
        /// <summary>
        /// Test the property 'EndByDate'
        /// </summary>
        [TestMethod]
        public void EndByDateTest()
        {
            // TODO unit test for the property 'EndByDate'
        }
        /// <summary>
        /// Test the property 'NumberOfOccurences'
        /// </summary>
        [TestMethod]
        public void NumberOfOccurencesTest()
        {
            // TODO unit test for the property 'NumberOfOccurences'
        }
        /// <summary>
        /// Test the property 'Frequency'
        /// </summary>
        [TestMethod]
        public void FrequencyTest()
        {
            // TODO unit test for the property 'Frequency'
        }
        /// <summary>
        /// Test the property 'DailyInterval'
        /// </summary>
        [TestMethod]
        public void DailyIntervalTest()
        {
            // TODO unit test for the property 'DailyInterval'
        }
        /// <summary>
        /// Test the property 'ScheduleEveryWeekday'
        /// </summary>
        [TestMethod]
        public void ScheduleEveryWeekdayTest()
        {
            // TODO unit test for the property 'ScheduleEveryWeekday'
        }
        /// <summary>
        /// Test the property 'WeeklyInterval'
        /// </summary>
        [TestMethod]
        public void WeeklyIntervalTest()
        {
            // TODO unit test for the property 'WeeklyInterval'
        }
        /// <summary>
        /// Test the property 'WeeklyOnSunday'
        /// </summary>
        [TestMethod]
        public void WeeklyOnSundayTest()
        {
            // TODO unit test for the property 'WeeklyOnSunday'
        }
        /// <summary>
        /// Test the property 'WeeklyOnMonday'
        /// </summary>
        [TestMethod]
        public void WeeklyOnMondayTest()
        {
            // TODO unit test for the property 'WeeklyOnMonday'
        }
        /// <summary>
        /// Test the property 'WeeklyOnTuesday'
        /// </summary>
        [TestMethod]
        public void WeeklyOnTuesdayTest()
        {
            // TODO unit test for the property 'WeeklyOnTuesday'
        }
        /// <summary>
        /// Test the property 'WeeklyOnWednesday'
        /// </summary>
        [TestMethod]
        public void WeeklyOnWednesdayTest()
        {
            // TODO unit test for the property 'WeeklyOnWednesday'
        }
        /// <summary>
        /// Test the property 'WeeklyOnThursday'
        /// </summary>
        [TestMethod]
        public void WeeklyOnThursdayTest()
        {
            // TODO unit test for the property 'WeeklyOnThursday'
        }
        /// <summary>
        /// Test the property 'WeeklyOnFriday'
        /// </summary>
        [TestMethod]
        public void WeeklyOnFridayTest()
        {
            // TODO unit test for the property 'WeeklyOnFriday'
        }
        /// <summary>
        /// Test the property 'WeeklyOnSaturday'
        /// </summary>
        [TestMethod]
        public void WeeklyOnSaturdayTest()
        {
            // TODO unit test for the property 'WeeklyOnSaturday'
        }
        /// <summary>
        /// Test the property 'MonthlyInterval'
        /// </summary>
        [TestMethod]
        public void MonthlyIntervalTest()
        {
            // TODO unit test for the property 'MonthlyInterval'
        }
        /// <summary>
        /// Test the property 'DayOfMonth'
        /// </summary>
        [TestMethod]
        public void DayOfMonthTest()
        {
            // TODO unit test for the property 'DayOfMonth'
        }
        /// <summary>
        /// Test the property 'WeekOfMonth'
        /// </summary>
        [TestMethod]
        public void WeekOfMonthTest()
        {
            // TODO unit test for the property 'WeekOfMonth'
        }
        /// <summary>
        /// Test the property 'DayOfWeek'
        /// </summary>
        [TestMethod]
        public void DayOfWeekTest()
        {
            // TODO unit test for the property 'DayOfWeek'
        }
        /// <summary>
        /// Test the property 'YearlyInterval'
        /// </summary>
        [TestMethod]
        public void YearlyIntervalTest()
        {
            // TODO unit test for the property 'YearlyInterval'
        }
        /// <summary>
        /// Test the property 'MonthOfYear'
        /// </summary>
        [TestMethod]
        public void MonthOfYearTest()
        {
            // TODO unit test for the property 'MonthOfYear'
        }
        /// <summary>
        /// Test the property 'Success'
        /// </summary>
        [TestMethod]
        public void SuccessTest()
        {
            // TODO unit test for the property 'Success'
        }
        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [TestMethod]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }

    }

}
