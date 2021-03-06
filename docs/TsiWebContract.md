# IO.Swagger.Model.TsiWebContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Gets or sets the contract description | [optional] 
**ContractType** | **string** | Gets or sets the contract type | [optional] 
**Reference** | **string** | Gets or sets the contract reference | [optional] 
**DateWritten** | **DateTime?** | Gets or sets the contract DateWritten | [optional] 
**CreatedBy** | **int?** | Gets or sets the contract created by | [optional] 
**Status** | **string** | Gets or sets the contract status | [optional] 
**IsActive** | **bool?** |  | [optional] 
**ContractRemaining** | **string** |  | [optional] 
**IsFutureContract** | **bool?** |  | [optional] 
**HasContractRemaining** | **bool?** |  | [optional] 
**PaymentType** | **string** | Gets or sets the contract payment type | [optional] 
**CustomerPONumber** | **string** | Gets or sets the contract CustomerPONumber | [optional] 
**ContactName** | **string** | Gets or sets the contract contact name | [optional] 
**DefaultServiceOrderPriority** | **string** | Gets or sets the contract DefaultSOPriority | [optional] 
**AssignedTech** | **int?** | Gets or sets the contract AssignedTech | [optional] 
**StartDate** | **DateTime?** | Gets or sets the contract start date | [optional] 
**EndDate** | **DateTime?** | Gets or sets the contract EndDate | [optional] 
**DaysLeft** | **int?** | Gets or sets the contract DaysLeft | [optional] 
**LinkedAgreement** | **int?** | Gets or sets the contract LinkedAgreement | [optional] 
**LimitServiceOrdersToItemsCovered** | **bool?** | Gets or sets the contract LimitServiceOrdersToItemsCovered | [optional] 
**Price** | **double?** | Gets or sets the contract Price | [optional] 
**PricingMethod** | **string** | Gets or sets the PricingMethod | [optional] 
**BilledToDateAmount** | **double?** | Gets or sets the BilledToDateAmount | [optional] 
**RepToCredit** | **int?** | Gets or sets the RepToCredit | [optional] 
**RenewContractNumber** | **int?** | Gets or sets the RenewContractNumber | [optional] 
**SalesTaxCode** | **string** | Gets or sets the SalesTaxCode | [optional] 
**BillDayOfMonth** | **int?** | Gets or sets the BillDayOfMonth | [optional] 
**BillStartMonth** | **int?** | Gets or sets the BillStartMonth | [optional] 
**AutoInvoice** | **bool?** | Gets or sets the AutoInvoice | [optional] 
**DaysAheadToInvoice** | **int?** | Gets or sets the DaysAheadToInvoice | [optional] 
**EmailInvoice** | **bool?** | Gets or sets the EmailInvoice | [optional] 
**AllowInvoiceConsolidation** | **bool?** | Gets or sets the AllowInvoiceConsolidation | [optional] 
**PrintIncludesMemo** | **bool?** | Gets or sets the PrintIncludesMemo | [optional] 
**PrintSpecialInstructions** | **bool?** | Gets or sets the PrintSpecialInstructions | [optional] 
**InvoiceTerms** | **string** | Gets or sets the InvoiceTerms | [optional] 
**AutoPay** | **bool?** | Gets or sets the AutoPay | [optional] 
**DayOfMonthToPay** | **int?** | Gets or sets the DayOfMonthToPay | [optional] 
**PayMethod** | **int?** | Gets or sets the PayMethod | [optional] 
**PayMethodName** | **string** | Gets or sets the PayMethodName | [optional] 
**BillingCycle** | **string** | Gets or sets the BillingCycle | [optional] 
**BillingCycleDescription** | **string** | Gets or sets the BillingCycle Description | [optional] 
**BillingStyle** | **string** | Gets or sets the BillingStyle | [optional] 
**GLIncomeCode** | **string** | Gets or sets the GLIncomeCode | [optional] 
**PriceBillingText** | **string** | Gets or sets the PriceBillingText | [optional] 
**LastDayOfPeriod** | **int?** | Gets or sets the LastDayOfPeriod | [optional] 
**BaseUsageItemID** | **string** | Gets or sets the BaseUsageItemID | [optional] 
**BaseUsageDescription** | **string** | Gets or sets the BaseUsageDescription | [optional] 
**OverageItemID** | **string** | Gets or sets the OverageItemID | [optional] 
**OverageDescription** | **string** | Gets or sets the OverageDescription | [optional] 
**OverageRate** | **double?** |  | [optional] 
**OveragePriceLevel** | **int?** |  | [optional] 
**Includes** | **string** | Gets or sets the include comments | [optional] 
**SpecialInstructions** | **string** | Gets or sets the SpecialInstructions | [optional] 
**RenewalNotes** | **string** | Gets or sets the RenewalNotes | [optional] 
**GeneralNotes** | **string** | Gets or sets the GeneralNotes | [optional] 
**TripsIncluded** | **int?** | Gets or sets the Tripsincluded (MaxVisits) | [optional] 
**TripsRemaining** | **int?** | Gets or sets the trips remaining (callsLeft) | [optional] 
**AdditionalTripCharge** | **double?** | Gets or sets the additional trip charge (PerCallPrice) | [optional] 
**ResponseHours** | **int?** | Gets or sets the response hours (ResponseTime) | [optional] 
**BasisType** | **string** | Gets or sets the Basis | [optional] 
**Basis** | [**TsiWebBasis**](TsiWebBasis.md) | Gets or sets the Basis | [optional] 
**BillTo** | [**TsiWebContractBillToAddress**](TsiWebContractBillToAddress.md) | Gets or sets the Billto | [optional] 
**TemplateID** | **string** | Gets or sets the contract TemplateID | [optional] 
**DurationPeriod** | **string** | Gets or sets the Duration period of a template | [optional] 
**DurationQuantity** | **int?** | Gets or sets the Duration quantity of a template | [optional] 
**LastBillingDate** | **DateTime?** | Gets or sets the LastBillingDate | [optional] 
**BilledThruDate** | **DateTime?** |  | [optional] 
**BasePrice** | **double?** |  | [optional] 
**UseBasePrice** | **bool?** |  | [optional] 
**VendorContract** | **string** |  | [optional] 
**CreditUtilizationTime** | **bool?** |  | [optional] 
**UtilizeOverride** | **bool?** |  | [optional] 
**UseLaborOverride** | **bool?** |  | [optional] 
**BillingOverride** | **bool?** |  | [optional] 
**Billable** | **bool?** |  | [optional] 
**Chargeable** | **bool?** |  | [optional] 
**UseDailyProration** | **bool?** |  | [optional] 
**TimeLogRateDiscount** | **double?** |  | [optional] 
**FixedHourlyRate** | **double?** |  | [optional] 
**LaborBillingType** | **string** |  | [optional] 
**LaborBillingTypeDescription** | **string** |  | [optional] 
**BasisTypeDescription** | **string** |  | [optional] 
**BillingOption** | **string** |  | [optional] 
**DefaultLogReason** | **string** |  | [optional] 
**BillToAccountNumber** | **int?** |  | [optional] 
**BillToAddressType** | **string** |  | [optional] 
**AlternateBillToAddressID** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

