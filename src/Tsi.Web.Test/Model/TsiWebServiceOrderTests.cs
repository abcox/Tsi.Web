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
    ///  Class for testing TsiWebServiceOrder
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestClass]
    public class TsiWebServiceOrderTests
    {
        // TODO uncomment below to declare an instance variable for TsiWebServiceOrder
        private TsiWebServiceOrder instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // TODO uncomment below to create an instance of TsiWebServiceOrder
            instance = new TsiWebServiceOrder(takenBy: 10177);
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TsiWebServiceOrder
        /// </summary>
        [TestMethod]
        public void TsiWebServiceOrderInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TsiWebServiceOrder
            Assert.IsInstanceOfType(instance, typeof(TsiWebServiceOrder)); // "variable 'instance' is a TsiWebServiceOrder");
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
        /// Test the property 'AlternatePhoneNumber'
        /// </summary>
        [TestMethod]
        public void AlternatePhoneNumberTest()
        {
            // TODO unit test for the property 'AlternatePhoneNumber'
        }

        /// <summary>
        /// Test the property 'AlternatePhoneLocation'
        /// </summary>
        [TestMethod]
        public void AlternatePhoneLocationTest()
        {
            // TODO unit test for the property 'AlternatePhoneLocation'
        }

        /// <summary>
        /// Test the property 'ContactNumber'
        /// </summary>
        [TestMethod]
        public void ContactNumberTest()
        {
            // TODO unit test for the property 'ContactNumber'
        }
        /// <summary>
        /// Test the property 'AlternateContactEmailAddress'
        /// </summary>
        [TestMethod]
        public void AlternateContactEmailAddressTest()
        {
            // TODO unit test for the property 'AlternateContactEmailAddress'
        }

        /// <summary>
        /// Test the property 'AlternateContactPhoneNumber'
        /// </summary>
        [TestMethod]
        public void AlternateContactPhoneNumberTest()
        {
            // TODO unit test for the property 'AlternateContactPhoneNumber'
        }

        /// <summary>
        /// Test the property 'AlternateContactPhoneLocation'
        /// </summary>
        [TestMethod]
        public void AlternateContactPhoneLocationTest()
        {
            // TODO unit test for the property 'AlternateContactPhoneLocation'
        }

        /// <summary>
        /// Test the property 'InvoiceNumber'
        /// </summary>
        [TestMethod]
        public void InvoiceNumberTest()
        {
            // TODO unit test for the property 'InvoiceNumber'
        }

        /// <summary>
        /// Test the property 'InvoicedStatus'
        /// </summary>
        [TestMethod]
        public void InvoicedStatusTest()
        {
            // TODO unit test for the property 'InvoicedStatus'
        }

        /// <summary>
        /// Test the property 'InvoiceDate'
        /// </summary>
        [TestMethod]
        public void InvoiceDateTest()
        {
            // TODO unit test for the property 'InvoiceDate'
        }

        /// <summary>
        /// Test the property 'TechnicianAssigned'
        /// </summary>
        [TestMethod]
        public void TechnicianAssignedTest()
        {
            // TODO unit test for the property 'TechnicianAssigned'
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
        /// Test the property 'CustomerPurchaseOrder'
        /// </summary>
        [TestMethod]
        public void CustomerPurchaseOrderTest()
        {
            // TODO unit test for the property 'CustomerPurchaseOrder'
        }

        /// <summary>
        /// Test the property 'PurchaseOrderNumber'
        /// </summary>
        [TestMethod]
        public void PurchaseOrderNumberTest()
        {
            // TODO unit test for the property 'PurchaseOrderNumber'
        }

        /// <summary>
        /// Test the property 'ExternalAccountId'
        /// </summary>
        [TestMethod]
        public void ExternalAccountIdTest()
        {
            // TODO unit test for the property 'ExternalAccountId'
        }

        /// <summary>
        /// Test the property 'ManagedServiceProviderAlertId'
        /// </summary>
        [TestMethod]
        public void ManagedServiceProviderAlertIdTest()
        {
            // TODO unit test for the property 'ManagedServiceProviderAlertId'
        }

        /// <summary>
        /// Test the property 'Age'
        /// </summary>
        [TestMethod]
        public void AgeTest()
        {
            // TODO unit test for the property 'Age'
        }

        /// <summary>
        /// Test the property 'PrintedFlag'
        /// </summary>
        [TestMethod]
        public void PrintedFlagTest()
        {
            // TODO unit test for the property 'PrintedFlag'
        }

        /// <summary>
        /// Test the property 'ServiceLevelAgreementDeadLine'
        /// </summary>
        [TestMethod]
        public void ServiceLevelAgreementDeadLineTest()
        {
            // TODO unit test for the property 'ServiceLevelAgreementDeadLine'
        }

        /// <summary>
        /// Test the property 'ServiceLevelAgreementWarning'
        /// </summary>
        [TestMethod]
        public void ServiceLevelAgreementWarningTest()
        {
            // TODO unit test for the property 'ServiceLevelAgreementWarning'
        }

        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [TestMethod]
        public void PriorityTest()
        {
            // TODO unit test for the property 'Priority'
        }

        /// <summary>
        /// Test the property 'ServiceOrderType'
        /// </summary>
        [TestMethod]
        public void ServiceOrderTypeTest()
        {
            // TODO unit test for the property 'ServiceOrderType'
        }

        /// <summary>
        /// Test the property 'DateTimeReceived'
        /// </summary>
        [TestMethod]
        public void DateTimeReceivedTest()
        {
            // TODO unit test for the property 'DateTimeReceived'
        }

        /// <summary>
        /// Test the property 'TakenBy'
        /// </summary>
        [TestMethod]
        public void TakenByTest()
        {
            // TODO unit test for the property 'TakenBy'
        }

        /// <summary>
        /// Test the property 'DateTimeRequested'
        /// </summary>
        [TestMethod]
        public void DateTimeRequestedTest()
        {
            // TODO unit test for the property 'DateTimeRequested'
        }

        /// <summary>
        /// Test the property 'DateRequested'
        /// </summary>
        [TestMethod]
        public void DateRequestedTest()
        {
            // TODO unit test for the property 'DateRequested'
        }
        /// <summary>
        /// Test the property 'TimeRequested'
        /// </summary>
        [TestMethod]
        public void TimeRequestedTest()
        {
            // TODO unit test for the property 'TimeRequested'
        }
        /// <summary>
        /// Test the property 'RequestedBy'
        /// </summary>
        [TestMethod]
        public void RequestedByTest()
        {
            // TODO unit test for the property 'RequestedBy'
        }
        /// <summary>
        /// Test the property 'DateTimeOpened'
        /// </summary>
        [TestMethod]
        public void DateTimeOpenedTest()
        {
            // TODO unit test for the property 'DateTimeOpened'
        }
        /// <summary>
        /// Test the property 'DateTimeClosed'
        /// </summary>
        [TestMethod]
        public void DateTimeClosedTest()
        {
            // TODO unit test for the property 'DateTimeClosed'
        }
        /// <summary>
        /// Test the property 'VerifiedDate'
        /// </summary>
        [TestMethod]
        public void VerifiedDateTest()
        {
            // TODO unit test for the property 'VerifiedDate'
        }
        /// <summary>
        /// Test the property 'VerifiedBy'
        /// </summary>
        [TestMethod]
        public void VerifiedByTest()
        {
            // TODO unit test for the property 'VerifiedBy'
        }
        /// <summary>
        /// Test the property 'ServiceZone'
        /// </summary>
        [TestMethod]
        public void ServiceZoneTest()
        {
            // TODO unit test for the property 'ServiceZone'
        }
        /// <summary>
        /// Test the property 'System'
        /// </summary>
        [TestMethod]
        public void SystemTest()
        {
            // TODO unit test for the property 'System'
        }
        /// <summary>
        /// Test the property 'Reference'
        /// </summary>
        [TestMethod]
        public void ReferenceTest()
        {
            // TODO unit test for the property 'Reference'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [TestMethod]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'BillParent'
        /// </summary>
        [TestMethod]
        public void BillParentTest()
        {
            // TODO unit test for the property 'BillParent'
        }
        /// <summary>
        /// Test the property 'BillTo'
        /// </summary>
        [TestMethod]
        public void BillToTest()
        {
            // TODO unit test for the property 'BillTo'
        }
        /// <summary>
        /// Test the property 'ShipTo'
        /// </summary>
        [TestMethod]
        public void ShipToTest()
        {
            // TODO unit test for the property 'ShipTo'
        }
        /// <summary>
        /// Test the property 'ResolvedOnPhone'
        /// </summary>
        [TestMethod]
        public void ResolvedOnPhoneTest()
        {
            // TODO unit test for the property 'ResolvedOnPhone'
        }
        /// <summary>
        /// Test the property 'CallBackCount'
        /// </summary>
        [TestMethod]
        public void CallBackCountTest()
        {
            // TODO unit test for the property 'CallBackCount'
        }
        /// <summary>
        /// Test the property 'BriefDescription'
        /// </summary>
        [TestMethod]
        public void BriefDescriptionTest()
        {
            // TODO unit test for the property 'BriefDescription'
        }
        /// <summary>
        /// Test the property 'WorkRequested'
        /// </summary>
        [TestMethod]
        public void WorkRequestedTest()
        {
            // TODO unit test for the property 'WorkRequested'
        }
        /// <summary>
        /// Test the property 'WorkPerformed'
        /// </summary>
        [TestMethod]
        public void WorkPerformedTest()
        {
            // TODO unit test for the property 'WorkPerformed'
        }
        /// <summary>
        /// Test the property 'InternalComments'
        /// </summary>
        [TestMethod]
        public void InternalCommentsTest()
        {
            // TODO unit test for the property 'InternalComments'
        }
        /// <summary>
        /// Test the property 'ProductType'
        /// </summary>
        [TestMethod]
        public void ProductTypeTest()
        {
            // TODO unit test for the property 'ProductType'
        }
        /// <summary>
        /// Test the property 'ProjectNumber'
        /// </summary>
        [TestMethod]
        public void ProjectNumberTest()
        {
            // TODO unit test for the property 'ProjectNumber'
        }
        /// <summary>
        /// Test the property 'ProjectPhaseNumber'
        /// </summary>
        [TestMethod]
        public void ProjectPhaseNumberTest()
        {
            // TODO unit test for the property 'ProjectPhaseNumber'
        }
        /// <summary>
        /// Test the property 'ProjectSubPhaseNumber'
        /// </summary>
        [TestMethod]
        public void ProjectSubPhaseNumberTest()
        {
            // TODO unit test for the property 'ProjectSubPhaseNumber'
        }
        /// <summary>
        /// Test the property 'DirectionsToLocation'
        /// </summary>
        [TestMethod]
        public void DirectionsToLocationTest()
        {
            // TODO unit test for the property 'DirectionsToLocation'
        }
        /// <summary>
        /// Test the property 'StatusChangeIndicator'
        /// </summary>
        [TestMethod]
        public void StatusChangeIndicatorTest()
        {
            // TODO unit test for the property 'StatusChangeIndicator'
        }
        /// <summary>
        /// Test the property 'StatusChangeDate'
        /// </summary>
        [TestMethod]
        public void StatusChangeDateTest()
        {
            // TODO unit test for the property 'StatusChangeDate'
        }
        /// <summary>
        /// Test the property 'CanDiscountedItemsGetHeaderDiscount'
        /// </summary>
        [TestMethod]
        public void CanDiscountedItemsGetHeaderDiscountTest()
        {
            // TODO unit test for the property 'CanDiscountedItemsGetHeaderDiscount'
        }
        /// <summary>
        /// Test the property 'EstimatedHours'
        /// </summary>
        [TestMethod]
        public void EstimatedHoursTest()
        {
            // TODO unit test for the property 'EstimatedHours'
        }
        /// <summary>
        /// Test the property 'EstimatedMinutes'
        /// </summary>
        [TestMethod]
        public void EstimatedMinutesTest()
        {
            // TODO unit test for the property 'EstimatedMinutes'
        }
        /// <summary>
        /// Test the property 'TagNumber'
        /// </summary>
        [TestMethod]
        public void TagNumberTest()
        {
            // TODO unit test for the property 'TagNumber'
        }
        /// <summary>
        /// Test the property 'LoanAgreement'
        /// </summary>
        [TestMethod]
        public void LoanAgreementTest()
        {
            // TODO unit test for the property 'LoanAgreement'
        }
        /// <summary>
        /// Test the property 'DebitCreditMemo'
        /// </summary>
        [TestMethod]
        public void DebitCreditMemoTest()
        {
            // TODO unit test for the property 'DebitCreditMemo'
        }
        /// <summary>
        /// Test the property 'DispatchBoardNumber'
        /// </summary>
        [TestMethod]
        public void DispatchBoardNumberTest()
        {
            // TODO unit test for the property 'DispatchBoardNumber'
        }
        /// <summary>
        /// Test the property 'Severity'
        /// </summary>
        [TestMethod]
        public void SeverityTest()
        {
            // TODO unit test for the property 'Severity'
        }
        /// <summary>
        /// Test the property 'PayMethodId'
        /// </summary>
        [TestMethod]
        public void PayMethodIdTest()
        {
            // TODO unit test for the property 'PayMethodId'
        }
        /// <summary>
        /// Test the property 'PaymentMethod'
        /// </summary>
        [TestMethod]
        public void PaymentMethodTest()
        {
            // TODO unit test for the property 'PaymentMethod'
        }
        /// <summary>
        /// Test the property 'InvoiceTerms'
        /// </summary>
        [TestMethod]
        public void InvoiceTermsTest()
        {
            // TODO unit test for the property 'InvoiceTerms'
        }
        /// <summary>
        /// Test the property 'ARCustomerNumber'
        /// </summary>
        [TestMethod]
        public void ARCustomerNumberTest()
        {
            // TODO unit test for the property 'ARCustomerNumber'
        }
        /// <summary>
        /// Test the property 'ReadyToInvoice'
        /// </summary>
        [TestMethod]
        public void ReadyToInvoiceTest()
        {
            // TODO unit test for the property 'ReadyToInvoice'
        }
        /// <summary>
        /// Test the property 'RepToCredit'
        /// </summary>
        [TestMethod]
        public void RepToCreditTest()
        {
            // TODO unit test for the property 'RepToCredit'
        }
        /// <summary>
        /// Test the property 'ShippingMethod'
        /// </summary>
        [TestMethod]
        public void ShippingMethodTest()
        {
            // TODO unit test for the property 'ShippingMethod'
        }
        /// <summary>
        /// Test the property 'GSTaxable'
        /// </summary>
        [TestMethod]
        public void GSTaxableTest()
        {
            // TODO unit test for the property 'GSTaxable'
        }
        /// <summary>
        /// Test the property 'GSTIsTaxable'
        /// </summary>
        [TestMethod]
        public void GSTIsTaxableTest()
        {
            // TODO unit test for the property 'GSTIsTaxable'
        }
        /// <summary>
        /// Test the property 'GSTaxComputeBeforeTradeIn'
        /// </summary>
        [TestMethod]
        public void GSTaxComputeBeforeTradeInTest()
        {
            // TODO unit test for the property 'GSTaxComputeBeforeTradeIn'
        }
        /// <summary>
        /// Test the property 'GSTaxRate'
        /// </summary>
        [TestMethod]
        public void GSTaxRateTest()
        {
            // TODO unit test for the property 'GSTaxRate'
        }
        /// <summary>
        /// Test the property 'TaxComputedBeforeTradeIn'
        /// </summary>
        [TestMethod]
        public void TaxComputedBeforeTradeInTest()
        {
            // TODO unit test for the property 'TaxComputedBeforeTradeIn'
        }
        /// <summary>
        /// Test the property 'FreightTaxable'
        /// </summary>
        [TestMethod]
        public void FreightTaxableTest()
        {
            // TODO unit test for the property 'FreightTaxable'
        }
        /// <summary>
        /// Test the property 'FreightTerms'
        /// </summary>
        [TestMethod]
        public void FreightTermsTest()
        {
            // TODO unit test for the property 'FreightTerms'
        }
        /// <summary>
        /// Test the property 'Taxable'
        /// </summary>
        [TestMethod]
        public void TaxableTest()
        {
            // TODO unit test for the property 'Taxable'
        }
        /// <summary>
        /// Test the property 'DiscountPercent'
        /// </summary>
        [TestMethod]
        public void DiscountPercentTest()
        {
            // TODO unit test for the property 'DiscountPercent'
        }
        /// <summary>
        /// Test the property 'DiscountAmount'
        /// </summary>
        [TestMethod]
        public void DiscountAmountTest()
        {
            // TODO unit test for the property 'DiscountAmount'
        }
        /// <summary>
        /// Test the property 'DiscountSellForPrice'
        /// </summary>
        [TestMethod]
        public void DiscountSellForPriceTest()
        {
            // TODO unit test for the property 'DiscountSellForPrice'
        }
        /// <summary>
        /// Test the property 'DiscountMarginPercent'
        /// </summary>
        [TestMethod]
        public void DiscountMarginPercentTest()
        {
            // TODO unit test for the property 'DiscountMarginPercent'
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
        /// Test the property 'SalesTaxRate'
        /// </summary>
        [TestMethod]
        public void SalesTaxRateTest()
        {
            // TODO unit test for the property 'SalesTaxRate'
        }
        /// <summary>
        /// Test the property 'TradeIn'
        /// </summary>
        [TestMethod]
        public void TradeInTest()
        {
            // TODO unit test for the property 'TradeIn'
        }
        /// <summary>
        /// Test the property 'Deposit'
        /// </summary>
        [TestMethod]
        public void DepositTest()
        {
            // TODO unit test for the property 'Deposit'
        }
        /// <summary>
        /// Test the property 'TotalSellingPrice'
        /// </summary>
        [TestMethod]
        public void TotalSellingPriceTest()
        {
            // TODO unit test for the property 'TotalSellingPrice'
        }
        /// <summary>
        /// Test the property 'TotalDollarsDiscounted'
        /// </summary>
        [TestMethod]
        public void TotalDollarsDiscountedTest()
        {
            // TODO unit test for the property 'TotalDollarsDiscounted'
        }
        /// <summary>
        /// Test the property 'TotalPercentDiscounted'
        /// </summary>
        [TestMethod]
        public void TotalPercentDiscountedTest()
        {
            // TODO unit test for the property 'TotalPercentDiscounted'
        }
        /// <summary>
        /// Test the property 'GSTax'
        /// </summary>
        [TestMethod]
        public void GSTaxTest()
        {
            // TODO unit test for the property 'GSTax'
        }
        /// <summary>
        /// Test the property 'GSTaxableAmount'
        /// </summary>
        [TestMethod]
        public void GSTaxableAmountTest()
        {
            // TODO unit test for the property 'GSTaxableAmount'
        }
        /// <summary>
        /// Test the property 'SalesTax'
        /// </summary>
        [TestMethod]
        public void SalesTaxTest()
        {
            // TODO unit test for the property 'SalesTax'
        }
        /// <summary>
        /// Test the property 'TaxableAmount'
        /// </summary>
        [TestMethod]
        public void TaxableAmountTest()
        {
            // TODO unit test for the property 'TaxableAmount'
        }
        /// <summary>
        /// Test the property 'ProviderTax'
        /// </summary>
        [TestMethod]
        public void ProviderTaxTest()
        {
            // TODO unit test for the property 'ProviderTax'
        }
        /// <summary>
        /// Test the property 'ProviderTaxRate'
        /// </summary>
        [TestMethod]
        public void ProviderTaxRateTest()
        {
            // TODO unit test for the property 'ProviderTaxRate'
        }
        /// <summary>
        /// Test the property 'ProviderTaxableAmount'
        /// </summary>
        [TestMethod]
        public void ProviderTaxableAmountTest()
        {
            // TODO unit test for the property 'ProviderTaxableAmount'
        }
        /// <summary>
        /// Test the property 'Freight'
        /// </summary>
        [TestMethod]
        public void FreightTest()
        {
            // TODO unit test for the property 'Freight'
        }
        /// <summary>
        /// Test the property 'TotalDue'
        /// </summary>
        [TestMethod]
        public void TotalDueTest()
        {
            // TODO unit test for the property 'TotalDue'
        }
        /// <summary>
        /// Test the property 'BidPrice'
        /// </summary>
        [TestMethod]
        public void BidPriceTest()
        {
            // TODO unit test for the property 'BidPrice'
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
        /// Test the property 'VoidBy'
        /// </summary>
        [TestMethod]
        public void VoidByTest()
        {
            // TODO unit test for the property 'VoidBy'
        }
        /// <summary>
        /// Test the property 'VoidDate'
        /// </summary>
        [TestMethod]
        public void VoidDateTest()
        {
            // TODO unit test for the property 'VoidDate'
        }
        /// <summary>
        /// Test the property 'VoidReason'
        /// </summary>
        [TestMethod]
        public void VoidReasonTest()
        {
            // TODO unit test for the property 'VoidReason'
        }
        /// <summary>
        /// Test the property 'SalesAgreementNumber'
        /// </summary>
        [TestMethod]
        public void SalesAgreementNumberTest()
        {
            // TODO unit test for the property 'SalesAgreementNumber'
        }
        /// <summary>
        /// Test the property 'DispatchReference'
        /// </summary>
        [TestMethod]
        public void DispatchReferenceTest()
        {
            // TODO unit test for the property 'DispatchReference'
        }
        /// <summary>
        /// Test the property 'IBMNumber'
        /// </summary>
        [TestMethod]
        public void IBMNumberTest()
        {
            // TODO unit test for the property 'IBMNumber'
        }
        /// <summary>
        /// Test the property 'OtherReferenceNum'
        /// </summary>
        [TestMethod]
        public void OtherReferenceNumTest()
        {
            // TODO unit test for the property 'OtherReferenceNum'
        }
        /// <summary>
        /// Test the property 'ARReference'
        /// </summary>
        [TestMethod]
        public void ARReferenceTest()
        {
            // TODO unit test for the property 'ARReference'
        }
        /// <summary>
        /// Test the property 'CustomerReference'
        /// </summary>
        [TestMethod]
        public void CustomerReferenceTest()
        {
            // TODO unit test for the property 'CustomerReference'
        }
        /// <summary>
        /// Test the property 'GLReference'
        /// </summary>
        [TestMethod]
        public void GLReferenceTest()
        {
            // TODO unit test for the property 'GLReference'
        }
        /// <summary>
        /// Test the property 'Miscellaneous'
        /// </summary>
        [TestMethod]
        public void MiscellaneousTest()
        {
            // TODO unit test for the property 'Miscellaneous'
        }
        /// <summary>
        /// Test the property 'Comment'
        /// </summary>
        [TestMethod]
        public void CommentTest()
        {
            // TODO unit test for the property 'Comment'
        }
        /// <summary>
        /// Test the property 'ExternalInvoice'
        /// </summary>
        [TestMethod]
        public void ExternalInvoiceTest()
        {
            // TODO unit test for the property 'ExternalInvoice'
        }
        /// <summary>
        /// Test the property 'WarrantyType'
        /// </summary>
        [TestMethod]
        public void WarrantyTypeTest()
        {
            // TODO unit test for the property 'WarrantyType'
        }
        /// <summary>
        /// Test the property 'ManagedServiceProviderAlertUrl'
        /// </summary>
        [TestMethod]
        public void ManagedServiceProviderAlertUrlTest()
        {
            // TODO unit test for the property 'ManagedServiceProviderAlertUrl'
        }
        /// <summary>
        /// Test the property 'DefaultBin'
        /// </summary>
        [TestMethod]
        public void DefaultBinTest()
        {
            // TODO unit test for the property 'DefaultBin'
        }
        /// <summary>
        /// Test the property 'PostedStatus'
        /// </summary>
        [TestMethod]
        public void PostedStatusTest()
        {
            // TODO unit test for the property 'PostedStatus'
        }
        /// <summary>
        /// Test the property 'ProgressiveInvoiceTotalComment'
        /// </summary>
        [TestMethod]
        public void ProgressiveInvoiceTotalCommentTest()
        {
            // TODO unit test for the property 'ProgressiveInvoiceTotalComment'
        }
        /// <summary>
        /// Test the property 'ServiceCategory'
        /// </summary>
        [TestMethod]
        public void ServiceCategoryTest()
        {
            // TODO unit test for the property 'ServiceCategory'
        }
        /// <summary>
        /// Test the property 'StagingLocation'
        /// </summary>
        [TestMethod]
        public void StagingLocationTest()
        {
            // TODO unit test for the property 'StagingLocation'
        }
        /// <summary>
        /// Test the property 'PriorityColor'
        /// </summary>
        [TestMethod]
        public void PriorityColorTest()
        {
            // TODO unit test for the property 'PriorityColor'
        }
        /// <summary>
        /// Test the property 'SeverityRank'
        /// </summary>
        [TestMethod]
        public void SeverityRankTest()
        {
            // TODO unit test for the property 'SeverityRank'
        }
        /// <summary>
        /// Test the property 'ActualHoursLogged'
        /// </summary>
        [TestMethod]
        public void ActualHoursLoggedTest()
        {
            // TODO unit test for the property 'ActualHoursLogged'
        }
        /// <summary>
        /// Test the property 'ActualMinutesLogged'
        /// </summary>
        [TestMethod]
        public void ActualMinutesLoggedTest()
        {
            // TODO unit test for the property 'ActualMinutesLogged'
        }
        /// <summary>
        /// Test the property 'MeterReading'
        /// </summary>
        [TestMethod]
        public void MeterReadingTest()
        {
            // TODO unit test for the property 'MeterReading'
        }
        /// <summary>
        /// Test the property 'OriginalServiceOrderNumber'
        /// </summary>
        [TestMethod]
        public void OriginalServiceOrderNumberTest()
        {
            // TODO unit test for the property 'OriginalServiceOrderNumber'
        }
        /// <summary>
        /// Test the property 'PriceLevel'
        /// </summary>
        [TestMethod]
        public void PriceLevelTest()
        {
            // TODO unit test for the property 'PriceLevel'
        }
        /// <summary>
        /// Test the property 'PriorityRank'
        /// </summary>
        [TestMethod]
        public void PriorityRankTest()
        {
            // TODO unit test for the property 'PriorityRank'
        }
        /// <summary>
        /// Test the property 'QuoteNumber'
        /// </summary>
        [TestMethod]
        public void QuoteNumberTest()
        {
            // TODO unit test for the property 'QuoteNumber'
        }
        /// <summary>
        /// Test the property 'ReceivedDateAge'
        /// </summary>
        [TestMethod]
        public void ReceivedDateAgeTest()
        {
            // TODO unit test for the property 'ReceivedDateAge'
        }
        /// <summary>
        /// Test the property 'TotalHours'
        /// </summary>
        [TestMethod]
        public void TotalHoursTest()
        {
            // TODO unit test for the property 'TotalHours'
        }
        /// <summary>
        /// Test the property 'TotalMinutes'
        /// </summary>
        [TestMethod]
        public void TotalMinutesTest()
        {
            // TODO unit test for the property 'TotalMinutes'
        }
        /// <summary>
        /// Test the property 'ARDate'
        /// </summary>
        [TestMethod]
        public void ARDateTest()
        {
            // TODO unit test for the property 'ARDate'
        }
        /// <summary>
        /// Test the property 'BMFLastProcessed'
        /// </summary>
        [TestMethod]
        public void BMFLastProcessedTest()
        {
            // TODO unit test for the property 'BMFLastProcessed'
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
        /// Test the property 'DateToInstall'
        /// </summary>
        [TestMethod]
        public void DateToInstallTest()
        {
            // TODO unit test for the property 'DateToInstall'
        }
        /// <summary>
        /// Test the property 'GLDate'
        /// </summary>
        [TestMethod]
        public void GLDateTest()
        {
            // TODO unit test for the property 'GLDate'
        }
        /// <summary>
        /// Test the property 'NextDate'
        /// </summary>
        [TestMethod]
        public void NextDateTest()
        {
            // TODO unit test for the property 'NextDate'
        }
        /// <summary>
        /// Test the property 'CreditsWereInvoiced'
        /// </summary>
        [TestMethod]
        public void CreditsWereInvoicedTest()
        {
            // TODO unit test for the property 'CreditsWereInvoiced'
        }
        /// <summary>
        /// Test the property 'EmailConnectorUpdate'
        /// </summary>
        [TestMethod]
        public void EmailConnectorUpdateTest()
        {
            // TODO unit test for the property 'EmailConnectorUpdate'
        }
        /// <summary>
        /// Test the property 'InThresholdEscalationNoticeSent'
        /// </summary>
        [TestMethod]
        public void InThresholdEscalationNoticeSentTest()
        {
            // TODO unit test for the property 'InThresholdEscalationNoticeSent'
        }
        /// <summary>
        /// Test the property 'NeedToTestEscalation'
        /// </summary>
        [TestMethod]
        public void NeedToTestEscalationTest()
        {
            // TODO unit test for the property 'NeedToTestEscalation'
        }
        /// <summary>
        /// Test the property 'PastTargetEscalationNoticeSent'
        /// </summary>
        [TestMethod]
        public void PastTargetEscalationNoticeSentTest()
        {
            // TODO unit test for the property 'PastTargetEscalationNoticeSent'
        }
        /// <summary>
        /// Test the property 'TaxLabor'
        /// </summary>
        [TestMethod]
        public void TaxLaborTest()
        {
            // TODO unit test for the property 'TaxLabor'
        }
        /// <summary>
        /// Test the property 'CreditBalance'
        /// </summary>
        [TestMethod]
        public void CreditBalanceTest()
        {
            // TODO unit test for the property 'CreditBalance'
        }
        /// <summary>
        /// Test the property 'TotalLaborCost'
        /// </summary>
        [TestMethod]
        public void TotalLaborCostTest()
        {
            // TODO unit test for the property 'TotalLaborCost'
        }
        /// <summary>
        /// Test the property 'TotalLaborSellPrice'
        /// </summary>
        [TestMethod]
        public void TotalLaborSellPriceTest()
        {
            // TODO unit test for the property 'TotalLaborSellPrice'
        }
        /// <summary>
        /// Test the property 'TotalOtherCost'
        /// </summary>
        [TestMethod]
        public void TotalOtherCostTest()
        {
            // TODO unit test for the property 'TotalOtherCost'
        }
        /// <summary>
        /// Test the property 'TotalOtherSellPrice'
        /// </summary>
        [TestMethod]
        public void TotalOtherSellPriceTest()
        {
            // TODO unit test for the property 'TotalOtherSellPrice'
        }
        /// <summary>
        /// Test the property 'UnappliedBOTradein'
        /// </summary>
        [TestMethod]
        public void UnappliedBOTradeinTest()
        {
            // TODO unit test for the property 'UnappliedBOTradein'
        }
        /// <summary>
        /// Test the property 'UnappliedGSTradein'
        /// </summary>
        [TestMethod]
        public void UnappliedGSTradeinTest()
        {
            // TODO unit test for the property 'UnappliedGSTradein'
        }
        /// <summary>
        /// Test the property 'UnappliedTradeIn'
        /// </summary>
        [TestMethod]
        public void UnappliedTradeInTest()
        {
            // TODO unit test for the property 'UnappliedTradeIn'
        }
        /// <summary>
        /// Test the property 'LaborHours'
        /// </summary>
        [TestMethod]
        public void LaborHoursTest()
        {
            // TODO unit test for the property 'LaborHours'
        }
        /// <summary>
        /// Test the property 'SavingsPercent'
        /// </summary>
        [TestMethod]
        public void SavingsPercentTest()
        {
            // TODO unit test for the property 'SavingsPercent'
        }
        /// <summary>
        /// Test the property 'OrderSource'
        /// </summary>
        [TestMethod]
        public void OrderSourceTest()
        {
            // TODO unit test for the property 'OrderSource'
        }
        /// <summary>
        /// Test the property 'DisplayOnCustomerPortal'
        /// </summary>
        [TestMethod]
        public void DisplayOnCustomerPortalTest()
        {
            // TODO unit test for the property 'DisplayOnCustomerPortal'
        }

    }

}
