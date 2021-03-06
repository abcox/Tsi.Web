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
    ///  Class for testing TsiWebAgreement
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestClass]
    public class TsiWebAgreementTests
    {
        // TODO uncomment below to declare an instance variable for TsiWebAgreement
        //private TsiWebAgreement instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // TODO uncomment below to create an instance of TsiWebAgreement
            //instance = new TsiWebAgreement();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TsiWebAgreement
        /// </summary>
        [TestMethod]
        public void TsiWebAgreementInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TsiWebAgreement
            //Assert.IsInstanceOfType<TsiWebAgreement> (instance, "variable 'instance' is a TsiWebAgreement");
        }


        /// <summary>
        /// Test the property 'AccountNumber'
        /// </summary>
        [TestMethod]
        public void AccountNumberTest()
        {
            // TODO unit test for the property 'AccountNumber'
        }
        /// <summary>
        /// Test the property 'ExternalProduct'
        /// </summary>
        [TestMethod]
        public void ExternalProductTest()
        {
            // TODO unit test for the property 'ExternalProduct'
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
        /// Test the property 'EndDate'
        /// </summary>
        [TestMethod]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [TestMethod]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'SalesTaxCode'
        /// </summary>
        [TestMethod]
        public void SalesTaxCodeTest()
        {
            // TODO unit test for the property 'SalesTaxCode'
        }
        /// <summary>
        /// Test the property 'ContractNumber'
        /// </summary>
        [TestMethod]
        public void ContractNumberTest()
        {
            // TODO unit test for the property 'ContractNumber'
        }
        /// <summary>
        /// Test the property 'LastBilledDate'
        /// </summary>
        [TestMethod]
        public void LastBilledDateTest()
        {
            // TODO unit test for the property 'LastBilledDate'
        }
        /// <summary>
        /// Test the property 'LastPolledDate'
        /// </summary>
        [TestMethod]
        public void LastPolledDateTest()
        {
            // TODO unit test for the property 'LastPolledDate'
        }
        /// <summary>
        /// Test the property 'InvoiceComments'
        /// </summary>
        [TestMethod]
        public void InvoiceCommentsTest()
        {
            // TODO unit test for the property 'InvoiceComments'
        }
        /// <summary>
        /// Test the property 'InvoiceDetailFormat'
        /// </summary>
        [TestMethod]
        public void InvoiceDetailFormatTest()
        {
            // TODO unit test for the property 'InvoiceDetailFormat'
        }
        /// <summary>
        /// Test the property 'MakeAllItemsTaxExempt'
        /// </summary>
        [TestMethod]
        public void MakeAllItemsTaxExemptTest()
        {
            // TODO unit test for the property 'MakeAllItemsTaxExempt'
        }
        /// <summary>
        /// Test the property 'ConsolidatedInvoice'
        /// </summary>
        [TestMethod]
        public void ConsolidatedInvoiceTest()
        {
            // TODO unit test for the property 'ConsolidatedInvoice'
        }
        /// <summary>
        /// Test the property 'EmailInvoiceFlag'
        /// </summary>
        [TestMethod]
        public void EmailInvoiceFlagTest()
        {
            // TODO unit test for the property 'EmailInvoiceFlag'
        }
        /// <summary>
        /// Test the property 'AutomatedBilling'
        /// </summary>
        [TestMethod]
        public void AutomatedBillingTest()
        {
            // TODO unit test for the property 'AutomatedBilling'
        }
        /// <summary>
        /// Test the property 'BillingPeriod'
        /// </summary>
        [TestMethod]
        public void BillingPeriodTest()
        {
            // TODO unit test for the property 'BillingPeriod'
        }
        /// <summary>
        /// Test the property 'BillingPeriodDescription'
        /// </summary>
        [TestMethod]
        public void BillingPeriodDescriptionTest()
        {
            // TODO unit test for the property 'BillingPeriodDescription'
        }
        /// <summary>
        /// Test the property 'NextBillingPeriod'
        /// </summary>
        [TestMethod]
        public void NextBillingPeriodTest()
        {
            // TODO unit test for the property 'NextBillingPeriod'
        }
        /// <summary>
        /// Test the property 'DayToBill'
        /// </summary>
        [TestMethod]
        public void DayToBillTest()
        {
            // TODO unit test for the property 'DayToBill'
        }
        /// <summary>
        /// Test the property 'DayToProcessPayment'
        /// </summary>
        [TestMethod]
        public void DayToProcessPaymentTest()
        {
            // TODO unit test for the property 'DayToProcessPayment'
        }
        /// <summary>
        /// Test the property 'PayMethod'
        /// </summary>
        [TestMethod]
        public void PayMethodTest()
        {
            // TODO unit test for the property 'PayMethod'
        }
        /// <summary>
        /// Test the property 'PayMethodName'
        /// </summary>
        [TestMethod]
        public void PayMethodNameTest()
        {
            // TODO unit test for the property 'PayMethodName'
        }
        /// <summary>
        /// Test the property 'MonthlyTotal'
        /// </summary>
        [TestMethod]
        public void MonthlyTotalTest()
        {
            // TODO unit test for the property 'MonthlyTotal'
        }
        /// <summary>
        /// Test the property 'BilledPeriodTotal'
        /// </summary>
        [TestMethod]
        public void BilledPeriodTotalTest()
        {
            // TODO unit test for the property 'BilledPeriodTotal'
        }
        /// <summary>
        /// Test the property 'SummarizedInvoiceFormat'
        /// </summary>
        [TestMethod]
        public void SummarizedInvoiceFormatTest()
        {
            // TODO unit test for the property 'SummarizedInvoiceFormat'
        }
        /// <summary>
        /// Test the property 'DetailedInvoiceFormat'
        /// </summary>
        [TestMethod]
        public void DetailedInvoiceFormatTest()
        {
            // TODO unit test for the property 'DetailedInvoiceFormat'
        }
        /// <summary>
        /// Test the property 'TotalPrice'
        /// </summary>
        [TestMethod]
        public void TotalPriceTest()
        {
            // TODO unit test for the property 'TotalPrice'
        }
        /// <summary>
        /// Test the property 'TotalCost'
        /// </summary>
        [TestMethod]
        public void TotalCostTest()
        {
            // TODO unit test for the property 'TotalCost'
        }
        /// <summary>
        /// Test the property 'DateCreated'
        /// </summary>
        [TestMethod]
        public void DateCreatedTest()
        {
            // TODO unit test for the property 'DateCreated'
        }
        /// <summary>
        /// Test the property 'AgreementBillTo'
        /// </summary>
        [TestMethod]
        public void AgreementBillToTest()
        {
            // TODO unit test for the property 'AgreementBillTo'
        }

    }

}
