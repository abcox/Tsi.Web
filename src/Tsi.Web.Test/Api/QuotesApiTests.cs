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
    ///  Class for testing QuotesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class QuotesApiTests
    {
        private QuotesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            instance = new QuotesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QuotesApi
        /// </summary>
        [TestMethod]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' QuotesApi
            //Assert.IsInstanceOfType(typeof(QuotesApi), instance, "instance is a QuotesApi");
        }

        
        /// <summary>
        /// Test QuotesAddQuoteToExistingServiceOrder
        /// </summary>
        [TestMethod]
        public void QuotesAddQuoteToExistingServiceOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? serviceOrderNumber = null;
            //TsiWebAddQuoteToExistingServiceOrderModel model = null;
            //var response = instance.QuotesAddQuoteToExistingServiceOrder(quoteNumber, serviceOrderNumber, model);
            //Assert.IsInstanceOf<TsiWebQuoteToServiceOrderResponse> (response, "response is TsiWebQuoteToServiceOrderResponse");
        }
        
        /// <summary>
        /// Test QuotesAddQuoteToNewServiceOrder
        /// </summary>
        [TestMethod]
        public void QuotesAddQuoteToNewServiceOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //TsiWebAddQuoteToNewServiceOrderModel model = null;
            //var response = instance.QuotesAddQuoteToNewServiceOrder(quoteNumber, model);
            //Assert.IsInstanceOf<TsiWebQuoteToServiceOrderResponse> (response, "response is TsiWebQuoteToServiceOrderResponse");
        }
        
        /// <summary>
        /// Test QuotesAdvancedSearch
        /// </summary>
        [TestMethod]
        public void QuotesAdvancedSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TsiWebAdvancedSearchRequest request = null;
            //var response = instance.QuotesAdvancedSearch(request);
            //Assert.IsInstanceOf<TsiWebSearchQuotesResponse> (response, "response is TsiWebSearchQuotesResponse");
        }
        
        /// <summary>
        /// Test QuotesConvertQuoteToWorkOrder
        /// </summary>
        [TestMethod]
        public void QuotesConvertQuoteToWorkOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //var response = instance.QuotesConvertQuoteToWorkOrder(quoteNumber);
            //Assert.IsInstanceOf<TsiWebWorkOrderResponse> (response, "response is TsiWebWorkOrderResponse");
        }
        
        /// <summary>
        /// Test QuotesCreateQuote
        /// </summary>
        [TestMethod]
        public void QuotesCreateQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TsiWebCreateQuoteModel request = null;
            //var response = instance.QuotesCreateQuote(request);
            //Assert.IsInstanceOf<TsiWebQuoteResponse> (response, "response is TsiWebQuoteResponse");
        }
        
        /// <summary>
        /// Test QuotesCreateQuoteDetailComment
        /// </summary>
        [TestMethod]
        public void QuotesCreateQuoteDetailCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //TsiWebCreateQuoteDetailCommentModel model = null;
            //var response = instance.QuotesCreateQuoteDetailComment(quoteNumber, model);
            //Assert.IsInstanceOf<TsiWebQuoteDetailResponse> (response, "response is TsiWebQuoteDetailResponse");
        }
        
        /// <summary>
        /// Test QuotesCreateQuoteDetailItem
        /// </summary>
        [TestMethod]
        public void QuotesCreateQuoteDetailItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //TsiWebCreateQuoteDetailItemModel model = null;
            //var response = instance.QuotesCreateQuoteDetailItem(quoteNumber, model);
            //Assert.IsInstanceOf<TsiWebQuoteDetailResponse> (response, "response is TsiWebQuoteDetailResponse");
        }
        
        /// <summary>
        /// Test QuotesCreateQuoteDetailNonStock
        /// </summary>
        [TestMethod]
        public void QuotesCreateQuoteDetailNonStockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //TsiWebCreateQuoteDetailNonStockModel model = null;
            //var response = instance.QuotesCreateQuoteDetailNonStock(quoteNumber, model);
            //Assert.IsInstanceOf<TsiWebQuoteDetailResponse> (response, "response is TsiWebQuoteDetailResponse");
        }
        
        /// <summary>
        /// Test QuotesCreateQuoteDetailSubtotal
        /// </summary>
        [TestMethod]
        public void QuotesCreateQuoteDetailSubtotalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //TsiWebCreateQuoteDetailSubTotalModel model = null;
            //var response = instance.QuotesCreateQuoteDetailSubtotal(quoteNumber, model);
            //Assert.IsInstanceOf<TsiWebQuoteDetailResponse> (response, "response is TsiWebQuoteDetailResponse");
        }
        
        /// <summary>
        /// Test QuotesCreateQuoteDocument
        /// </summary>
        [TestMethod]
        public void QuotesCreateQuoteDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //var response = instance.QuotesCreateQuoteDocument(quoteNumber);
            //Assert.IsInstanceOf<TsiWebDocumentResponse> (response, "response is TsiWebDocumentResponse");
        }
        
        /// <summary>
        /// Test QuotesCreateQuoteNote
        /// </summary>
        [TestMethod]
        public void QuotesCreateQuoteNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //TsiWebQuoteNoteModel note = null;
            //var response = instance.QuotesCreateQuoteNote(quoteNumber, note);
            //Assert.IsInstanceOf<TsiWebQuoteNoteResponse> (response, "response is TsiWebQuoteNoteResponse");
        }
        
        /// <summary>
        /// Test QuotesDeleteQuoteDetail
        /// </summary>
        [TestMethod]
        public void QuotesDeleteQuoteDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? quoteDetailNumber = null;
            //var response = instance.QuotesDeleteQuoteDetail(quoteNumber, quoteDetailNumber);
            //Assert.IsInstanceOf<TsiWebQuoteDetailResponse> (response, "response is TsiWebQuoteDetailResponse");
        }
        
        /// <summary>
        /// Test QuotesGetAccountQuotes
        /// </summary>
        [TestMethod]
        public void QuotesGetAccountQuotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountNumber = null;
            //bool? openOnly = null;
            //var response = instance.QuotesGetAccountQuotes(accountNumber, openOnly);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test QuotesGetAccountQuotes_0
        /// </summary>
        [TestMethod]
        public void QuotesGetAccountQuotes_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? accountNumber = null;
            //bool? openOnly = null;
            //var response = instance.QuotesGetAccountQuotes_0(accountNumber, openOnly);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test QuotesGetCustomFields
        /// </summary>
        [TestMethod]
        public void QuotesGetCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //var response = instance.QuotesGetCustomFields(quoteNumber);
            //Assert.IsInstanceOf<List<TsiWebCustomField>> (response, "response is List<TsiWebCustomField>");
        }
        
        /// <summary>
        /// Test QuotesGetFile
        /// </summary>
        [TestMethod]
        public void QuotesGetFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? documentID = null;
            //var response = instance.QuotesGetFile(quoteNumber, documentID);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test QuotesGetOpportunityQuotes
        /// </summary>
        [TestMethod]
        public void QuotesGetOpportunityQuotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //bool? openOnly = null;
            //var response = instance.QuotesGetOpportunityQuotes(opportunityNumber, openOnly);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test QuotesGetOpportunityQuotes_0
        /// </summary>
        [TestMethod]
        public void QuotesGetOpportunityQuotes_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? opportunityNumber = null;
            //bool? openOnly = null;
            //var response = instance.QuotesGetOpportunityQuotes_0(opportunityNumber, openOnly);
            //Assert.IsInstanceOf<TsiWebSearchContactResponse> (response, "response is TsiWebSearchContactResponse");
        }
        
        /// <summary>
        /// Test QuotesGetQuoteCompletedTasks
        /// </summary>
        [TestMethod]
        public void QuotesGetQuoteCompletedTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesGetQuoteCompletedTasks(quoteNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebTasksResponse> (response, "response is TsiWebTasksResponse");
        }
        
        /// <summary>
        /// Test QuotesGetQuoteDetail
        /// </summary>
        [TestMethod]
        public void QuotesGetQuoteDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //var response = instance.QuotesGetQuoteDetail(quoteNumber);
            //Assert.IsInstanceOf<TsiWebQuoteDetail> (response, "response is TsiWebQuoteDetail");
        }
        
        /// <summary>
        /// Test QuotesGetQuoteDocument
        /// </summary>
        [TestMethod]
        public void QuotesGetQuoteDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? documentID = null;
            //var response = instance.QuotesGetQuoteDocument(quoteNumber, documentID);
            //Assert.IsInstanceOf<TsiWebDocumentSummary> (response, "response is TsiWebDocumentSummary");
        }
        
        /// <summary>
        /// Test QuotesGetQuoteDocuments
        /// </summary>
        [TestMethod]
        public void QuotesGetQuoteDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesGetQuoteDocuments(quoteNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebDocumentsResponse> (response, "response is TsiWebDocumentsResponse");
        }
        
        /// <summary>
        /// Test QuotesGetQuoteIncompleteTasks
        /// </summary>
        [TestMethod]
        public void QuotesGetQuoteIncompleteTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesGetQuoteIncompleteTasks(quoteNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebTasksResponse> (response, "response is TsiWebTasksResponse");
        }
        
        /// <summary>
        /// Test QuotesGetQuoteNotes
        /// </summary>
        [TestMethod]
        public void QuotesGetQuoteNotesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesGetQuoteNotes(quoteNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebQuoteNotesResponse> (response, "response is TsiWebQuoteNotesResponse");
        }
        
        /// <summary>
        /// Test QuotesGetQuoteRelatedDocuments
        /// </summary>
        [TestMethod]
        public void QuotesGetQuoteRelatedDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //var response = instance.QuotesGetQuoteRelatedDocuments(quoteNumber);
            //Assert.IsInstanceOf<TsiWebQuoteRelatedDocuments> (response, "response is TsiWebQuoteRelatedDocuments");
        }
        
        /// <summary>
        /// Test QuotesGetQuoteSummary
        /// </summary>
        [TestMethod]
        public void QuotesGetQuoteSummaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //var response = instance.QuotesGetQuoteSummary(quoteNumber);
            //Assert.IsInstanceOf<TsiWebQuoteSummary> (response, "response is TsiWebQuoteSummary");
        }
        
        /// <summary>
        /// Test QuotesGetQuoteTasks
        /// </summary>
        [TestMethod]
        public void QuotesGetQuoteTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesGetQuoteTasks(quoteNumber, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebTasksResponse> (response, "response is TsiWebTasksResponse");
        }
        
        /// <summary>
        /// Test QuotesSearchByCustomField
        /// </summary>
        [TestMethod]
        public void QuotesSearchByCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TsiWebCustomFieldSearchModel model = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesSearchByCustomField(model, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchQuotesResponse> (response, "response is TsiWebSearchQuotesResponse");
        }
        
        /// <summary>
        /// Test QuotesSearchByCustomerPurchaseOrder
        /// </summary>
        [TestMethod]
        public void QuotesSearchByCustomerPurchaseOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesSearchByCustomerPurchaseOrder(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchQuotesResponse> (response, "response is TsiWebSearchQuotesResponse");
        }
        
        /// <summary>
        /// Test QuotesSearchByItemDescription
        /// </summary>
        [TestMethod]
        public void QuotesSearchByItemDescriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesSearchByItemDescription(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchQuotesResponse> (response, "response is TsiWebSearchQuotesResponse");
        }
        
        /// <summary>
        /// Test QuotesSearchByItemId
        /// </summary>
        [TestMethod]
        public void QuotesSearchByItemIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesSearchByItemId(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchQuotesResponse> (response, "response is TsiWebSearchQuotesResponse");
        }
        
        /// <summary>
        /// Test QuotesSearchByJob
        /// </summary>
        [TestMethod]
        public void QuotesSearchByJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesSearchByJob(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchQuotesResponse> (response, "response is TsiWebSearchQuotesResponse");
        }
        
        /// <summary>
        /// Test QuotesSearchByQuoteNumber
        /// </summary>
        [TestMethod]
        public void QuotesSearchByQuoteNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string criteria = null;
            //int? pageRequestPageSize = null;
            //int? pageRequestStartRow = null;
            //var response = instance.QuotesSearchByQuoteNumber(criteria, pageRequestPageSize, pageRequestStartRow);
            //Assert.IsInstanceOf<TsiWebSearchQuotesResponse> (response, "response is TsiWebSearchQuotesResponse");
        }
        
        /// <summary>
        /// Test QuotesSetQuoteDocumentFile
        /// </summary>
        [TestMethod]
        public void QuotesSetQuoteDocumentFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? documentID = null;
            //var response = instance.QuotesSetQuoteDocumentFile(quoteNumber, documentID);
            //Assert.IsInstanceOf<TsiWebResponse> (response, "response is TsiWebResponse");
        }
        
        /// <summary>
        /// Test QuotesSetQuoteDocumentFileName
        /// </summary>
        [TestMethod]
        public void QuotesSetQuoteDocumentFileNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? documentID = null;
            //string fileName = null;
            //var response = instance.QuotesSetQuoteDocumentFileName(quoteNumber, documentID, fileName);
            //Assert.IsInstanceOf<TsiWebDocumentResponse> (response, "response is TsiWebDocumentResponse");
        }
        
        /// <summary>
        /// Test QuotesUpdateCustomFields
        /// </summary>
        [TestMethod]
        public void QuotesUpdateCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //List<TsiWebCustomField> customFields = null;
            //var response = instance.QuotesUpdateCustomFields(quoteNumber, customFields);
            //Assert.IsInstanceOf<TsiWebCustomFieldsResponse> (response, "response is TsiWebCustomFieldsResponse");
        }
        
        /// <summary>
        /// Test QuotesUpdateQuote
        /// </summary>
        [TestMethod]
        public void QuotesUpdateQuoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //TsiWebUpdateQuoteModel model = null;
            //var response = instance.QuotesUpdateQuote(quoteNumber, model);
            //Assert.IsInstanceOf<TsiWebQuoteResponse> (response, "response is TsiWebQuoteResponse");
        }
        
        /// <summary>
        /// Test QuotesUpdateQuoteDetailComment
        /// </summary>
        [TestMethod]
        public void QuotesUpdateQuoteDetailCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? quoteDetailNumber = null;
            //TsiWebQuoteDetailCommentModel model = null;
            //var response = instance.QuotesUpdateQuoteDetailComment(quoteNumber, quoteDetailNumber, model);
            //Assert.IsInstanceOf<TsiWebQuoteDetailResponse> (response, "response is TsiWebQuoteDetailResponse");
        }
        
        /// <summary>
        /// Test QuotesUpdateQuoteDetailInstallLocation
        /// </summary>
        [TestMethod]
        public void QuotesUpdateQuoteDetailInstallLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? quoteDetailNumber = null;
            //string installLocation = null;
            //var response = instance.QuotesUpdateQuoteDetailInstallLocation(quoteNumber, quoteDetailNumber, installLocation);
            //Assert.IsInstanceOf<TsiWebQuoteDetailResponse> (response, "response is TsiWebQuoteDetailResponse");
        }
        
        /// <summary>
        /// Test QuotesUpdateQuoteDetailItem
        /// </summary>
        [TestMethod]
        public void QuotesUpdateQuoteDetailItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? quoteDetailNumber = null;
            //TsiWebQuoteDetailItemModel model = null;
            //var response = instance.QuotesUpdateQuoteDetailItem(quoteNumber, quoteDetailNumber, model);
            //Assert.IsInstanceOf<TsiWebQuoteDetailResponse> (response, "response is TsiWebQuoteDetailResponse");
        }
        
        /// <summary>
        /// Test QuotesUpdateQuoteDetailSubtotal
        /// </summary>
        [TestMethod]
        public void QuotesUpdateQuoteDetailSubtotalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? quoteDetailNumber = null;
            //TsiWebQuoteDetailSubtotalModel model = null;
            //var response = instance.QuotesUpdateQuoteDetailSubtotal(quoteNumber, quoteDetailNumber, model);
            //Assert.IsInstanceOf<TsiWebQuoteDetailResponse> (response, "response is TsiWebQuoteDetailResponse");
        }
        
        /// <summary>
        /// Test QuotesUpdateQuoteDocumentProperties
        /// </summary>
        [TestMethod]
        public void QuotesUpdateQuoteDocumentPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? documentID = null;
            //TsiWebAreasWebApiUpdateDocumentModel request = null;
            //var response = instance.QuotesUpdateQuoteDocumentProperties(quoteNumber, documentID, request);
            //Assert.IsInstanceOf<TsiWebDocumentResponse> (response, "response is TsiWebDocumentResponse");
        }
        
        /// <summary>
        /// Test QuotesUpdateQuoteNote
        /// </summary>
        [TestMethod]
        public void QuotesUpdateQuoteNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? quoteNumber = null;
            //int? quoteNoteNumber = null;
            //TsiWebQuoteNoteModel note = null;
            //var response = instance.QuotesUpdateQuoteNote(quoteNumber, quoteNoteNumber, note);
            //Assert.IsInstanceOf<TsiWebQuoteNoteResponse> (response, "response is TsiWebQuoteNoteResponse");
        }
        
    }

}