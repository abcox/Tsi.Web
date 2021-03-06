/* 
 * Tigerpaw API Method Reference
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 18.2.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tsi.Web.Client;
using Tsi.Web.Api;
using Tsi.Web.Model;

namespace Tsi.Web.Test
{
    /// <summary>
    ///  Class for testing OpportunityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class OpportunityApiTests
    {
        private OpportunityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            instance = new OpportunityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OpportunityApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OpportunityApi
            //Assert.IsInstanceOfType(typeof(OpportunityApi), instance, "instance is a OpportunityApi");
        }

        
        /// <summary>
        /// Test OpportunityAdvancedSearch
        /// </summary>
        [TestMethod]
        public void OpportunityAdvancedSearchTest()
        {
            TsiWebAdvancedSearchRequest request = new TsiWebAdvancedSearchRequest
            {
                Criteria = new List<TsiWebSearchCriteria>
                {
                    new TsiWebSearchCriteria
                    {
                        Criteria = " ", // Configuration.TestAccountName.ToString(),
                        SearchType = TsiWebSearchCriteria.Opportunity.SearchType.AccountName.ToString(),
                        MatchType =  TsiWebSearchCriteria.Opportunity.MatchType.Contains.ToString(),
                    },
                },
            };
            var response = instance.OpportunityAdvancedSearch(request);
            Assert.IsInstanceOfType(response, typeof(TsiWebSearchOpportunityResponse), "response is TsiWebSearchOpportunityResponse");
            Assert.IsTrue(response.Opportunities.Count > 0);
        }
        
        /// <summary>
        /// Test OpportunityCreateOpportunity
        /// </summary>
        [TestMethod]
        public void OpportunityCreateOpportunityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            TsiWebOpportunity opportunity = new TsiWebOpportunity
            (
                accountNumber: Configuration.TestAccountNumber,
                name: $"Test name {Guid.NewGuid()}",
                status: "Open",
                notes: "Test notes",
                nextStep: "Test nextStep",
                competition: "Test competition"
            );
            var response = instance.OpportunityCreateOpportunity(opportunity);
            Assert.IsInstanceOfType(response, typeof(TsiWebOpportunityResponse), "response is TsiWebOpportunityResponse");
        }
        
        /// <summary>
        /// Test OpportunityCreateOpportunityDocument
        /// </summary>
        [TestMethod]
        public void OpportunityCreateOpportunityDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //var response = instance.OpportunityCreateOpportunityDocument(opportunityNumber);
            //Assert.IsInstanceOf<TsiWebDocumentResponse> (response, "response is TsiWebDocumentResponse");
        }
        
        /// <summary>
        /// Test OpportunityGetAccountOpportunities
        /// </summary>
        [TestMethod]
        public void OpportunityGetAccountOpportunitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountNumber = null;
            //var response = instance.OpportunityGetAccountOpportunities(accountNumber);
            //Assert.IsInstanceOf<TsiWebSearchOpportunityResponse> (response, "response is TsiWebSearchOpportunityResponse");
        }
        
        /// <summary>
        /// Test OpportunityGetContactOpportunities
        /// </summary>
        [TestMethod]
        public void OpportunityGetContactOpportunitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? contactNumber = null;
            //var response = instance.OpportunityGetContactOpportunities(contactNumber);
            //Assert.IsInstanceOf<TsiWebSearchOpportunityResponse> (response, "response is TsiWebSearchOpportunityResponse");
        }
        
        /// <summary>
        /// Test OpportunityGetCustomFields
        /// </summary>
        [TestMethod]
        public void OpportunityGetCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //var response = instance.OpportunityGetCustomFields(opportunityNumber);
            //Assert.IsInstanceOf<List<TsiWebCustomField>> (response, "response is List<TsiWebCustomField>");
        }
        
        /// <summary>
        /// Test OpportunityGetFile
        /// </summary>
        [TestMethod]
        public void OpportunityGetFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //int? documentID = null;
            //var response = instance.OpportunityGetFile(opportunityNumber, documentID);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test OpportunityGetOpportunityCompletedTasks
        /// </summary>
        [TestMethod]
        public void OpportunityGetOpportunityCompletedTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.OpportunityGetOpportunityCompletedTasks(opportunityNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebTasksResponse> (response, "response is TsiWebTasksResponse");
        }
        
        /// <summary>
        /// Test OpportunityGetOpportunityDetail
        /// </summary>
        [TestMethod]
        public void OpportunityGetOpportunityDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //var response = instance.OpportunityGetOpportunityDetail(opportunityNumber);
            //Assert.IsInstanceOf<TsiWebOpportunityDetail> (response, "response is TsiWebOpportunityDetail");
        }
        
        /// <summary>
        /// Test OpportunityGetOpportunityDocument
        /// </summary>
        [TestMethod]
        public void OpportunityGetOpportunityDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //int? documentID = null;
            //var response = instance.OpportunityGetOpportunityDocument(opportunityNumber, documentID);
            //Assert.IsInstanceOf<TsiWebDocumentSummary> (response, "response is TsiWebDocumentSummary");
        }
        
        /// <summary>
        /// Test OpportunityGetOpportunityDocuments
        /// </summary>
        [TestMethod]
        public void OpportunityGetOpportunityDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.OpportunityGetOpportunityDocuments(opportunityNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebDocumentsResponse> (response, "response is TsiWebDocumentsResponse");
        }
        
        /// <summary>
        /// Test OpportunityGetOpportunityIncompleteTasks
        /// </summary>
        [TestMethod]
        public void OpportunityGetOpportunityIncompleteTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.OpportunityGetOpportunityIncompleteTasks(opportunityNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebTasksResponse> (response, "response is TsiWebTasksResponse");
        }
        
        /// <summary>
        /// Test OpportunityGetOpportunitySummary
        /// </summary>
        [TestMethod]
        public void OpportunityGetOpportunitySummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //var response = instance.OpportunityGetOpportunitySummary(opportunityNumber);
            //Assert.IsInstanceOf<TsiWebOpportunitySummary> (response, "response is TsiWebOpportunitySummary");
        }
        
        /// <summary>
        /// Test OpportunityGetOpportunityTasks
        /// </summary>
        [TestMethod]
        public void OpportunityGetOpportunityTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.OpportunityGetOpportunityTasks(opportunityNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebTasksResponse> (response, "response is TsiWebTasksResponse");
        }
        
        /// <summary>
        /// Test OpportunityGetOwnerOpportunities
        /// </summary>
        [TestMethod]
        public void OpportunityGetOwnerOpportunitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? repNumber = null;
            //var response = instance.OpportunityGetOwnerOpportunities(repNumber);
            //Assert.IsInstanceOf<TsiWebSearchOpportunityResponse> (response, "response is TsiWebSearchOpportunityResponse");
        }
        
        /// <summary>
        /// Test OpportunitySearchByAccountName
        /// </summary>
        [TestMethod]
        public void OpportunitySearchByAccountNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.OpportunitySearchByAccountName(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchOpportunityResponse> (response, "response is TsiWebSearchOpportunityResponse");
        }
        
        /// <summary>
        /// Test OpportunitySearchByContactName
        /// </summary>
        [TestMethod]
        public void OpportunitySearchByContactNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.OpportunitySearchByContactName(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchOpportunityResponse> (response, "response is TsiWebSearchOpportunityResponse");
        }
        
        /// <summary>
        /// Test OpportunitySearchByCustomField
        /// </summary>
        [TestMethod]
        public void OpportunitySearchByCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TsiWebCustomFieldSearchModel searchModel = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.OpportunitySearchByCustomField(searchModel, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchOpportunityResponse> (response, "response is TsiWebSearchOpportunityResponse");
        }
        
        /// <summary>
        /// Test OpportunitySearchByName
        /// </summary>
        [TestMethod]
        public void OpportunitySearchByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.OpportunitySearchByName(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchOpportunityResponse> (response, "response is TsiWebSearchOpportunityResponse");
        }
        
        /// <summary>
        /// Test OpportunitySearchByNumber
        /// </summary>
        [TestMethod]
        public void OpportunitySearchByNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.OpportunitySearchByNumber(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchOpportunityResponse> (response, "response is TsiWebSearchOpportunityResponse");
        }
        
        /// <summary>
        /// Test OpportunitySetOpportunityDocumentFile
        /// </summary>
        [TestMethod]
        public void OpportunitySetOpportunityDocumentFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //int? documentID = null;
            //var response = instance.OpportunitySetOpportunityDocumentFile(opportunityNumber, documentID);
            //Assert.IsInstanceOf<TsiWebResponse> (response, "response is TsiWebResponse");
        }
        
        /// <summary>
        /// Test OpportunitySetOpportunityDocumentFileName
        /// </summary>
        [TestMethod]
        public void OpportunitySetOpportunityDocumentFileNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //int? documentID = null;
            //string fileName = null;
            //var response = instance.OpportunitySetOpportunityDocumentFileName(opportunityNumber, documentID, fileName);
            //Assert.IsInstanceOf<TsiWebDocumentResponse> (response, "response is TsiWebDocumentResponse");
        }
        
        /// <summary>
        /// Test OpportunityUpdateCustomFields
        /// </summary>
        [TestMethod]
        public void OpportunityUpdateCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //List<TsiWebCustomField> customFields = null;
            //var response = instance.OpportunityUpdateCustomFields(opportunityNumber, customFields);
            //Assert.IsInstanceOf<TsiWebCustomFieldsResponse> (response, "response is TsiWebCustomFieldsResponse");
        }
        
        /// <summary>
        /// Test OpportunityUpdateOpportunity
        /// </summary>
        [TestMethod]
        public void OpportunityUpdateOpportunityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //TsiWebOpportunity opportunity = null;
            //var response = instance.OpportunityUpdateOpportunity(opportunityNumber, opportunity);
            //Assert.IsInstanceOf<TsiWebOpportunityResponse> (response, "response is TsiWebOpportunityResponse");
        }
        
        /// <summary>
        /// Test OpportunityUpdateOpportunityDocumentProperties
        /// </summary>
        [TestMethod]
        public void OpportunityUpdateOpportunityDocumentPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //int? documentID = null;
            //TsiWebAreasWebApiUpdateDocumentModel request = null;
            //var response = instance.OpportunityUpdateOpportunityDocumentProperties(opportunityNumber, documentID, request);
            //Assert.IsInstanceOf<TsiWebDocumentResponse> (response, "response is TsiWebDocumentResponse");
        }
        
    }

}
