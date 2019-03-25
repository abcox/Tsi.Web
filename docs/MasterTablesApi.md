# IO.Swagger.Api.MasterTablesApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MasterTablesCreateAccountCustomFieldCategory**](MasterTablesApi.md#mastertablescreateaccountcustomfieldcategory) | **POST** /api/mastertables/customfields/categories/accounts | Creates the account custom field category.
[**MasterTablesCreateBooleanCustomFieldDefinition**](MasterTablesApi.md#mastertablescreatebooleancustomfielddefinition) | **POST** /api/mastertables/customfields/definitions/truefalse | Creates the true / false custom field definition.
[**MasterTablesCreateContactCustomFieldCategory**](MasterTablesApi.md#mastertablescreatecontactcustomfieldcategory) | **POST** /api/mastertables/customfields/categories/contacts | Creates the contact custom field category.
[**MasterTablesCreateContractMeter**](MasterTablesApi.md#mastertablescreatecontractmeter) | **POST** /api/mastertables/contracts/meters | Creates the ContractMeter.
[**MasterTablesCreateContractMeterGroup**](MasterTablesApi.md#mastertablescreatecontractmetergroup) | **POST** /api/mastertables/contracts/metergroups | Creates the Contract Meter group.
[**MasterTablesCreateCurrencyCustomFieldDefinition**](MasterTablesApi.md#mastertablescreatecurrencycustomfielddefinition) | **POST** /api/mastertables/customfields/definitions/currency | Creates the currency custom field definition.
[**MasterTablesCreateDateCustomFieldDefinition**](MasterTablesApi.md#mastertablescreatedatecustomfielddefinition) | **POST** /api/mastertables/customfields/definitions/date | Creates the date custom field definition.
[**MasterTablesCreateDropDownCustomFieldDefinition**](MasterTablesApi.md#mastertablescreatedropdowncustomfielddefinition) | **POST** /api/mastertables/customfields/definitions/dropdown | Creates the drop down custom field definition.
[**MasterTablesCreateExpensePaymentType**](MasterTablesApi.md#mastertablescreateexpensepaymenttype) | **POST** /api/mastertables/expensepaymenttypes | Creates an expense payment type.
[**MasterTablesCreateExpenseType**](MasterTablesApi.md#mastertablescreateexpensetype) | **POST** /api/mastertables/expensetypes | Create an expense type.
[**MasterTablesCreateJournalAction**](MasterTablesApi.md#mastertablescreatejournalaction) | **POST** /api/mastertables/journal/actions | Creates the journal action.
[**MasterTablesCreateJournalTopic**](MasterTablesApi.md#mastertablescreatejournaltopic) | **POST** /api/mastertables/journal/topics | Creates the journal topic.
[**MasterTablesCreateNumberCustomFieldDefinition**](MasterTablesApi.md#mastertablescreatenumbercustomfielddefinition) | **POST** /api/mastertables/customfields/definitions/number | Creates the number custom field definition.
[**MasterTablesCreateOpportunityCustomFieldCategory**](MasterTablesApi.md#mastertablescreateopportunitycustomfieldcategory) | **POST** /api/mastertables/customfields/categories/opportunities | Creates the opportunity custom field category.
[**MasterTablesCreateResolution**](MasterTablesApi.md#mastertablescreateresolution) | **POST** /api/mastertables/resolutions | Creates the Resolution.
[**MasterTablesCreateServiceOrderProfile**](MasterTablesApi.md#mastertablescreateserviceorderprofile) | **POST** /api/mastertables/serviceOrderProfiles | Creates the Service Order Profile.
[**MasterTablesCreateSymptom**](MasterTablesApi.md#mastertablescreatesymptom) | **POST** /api/mastertables/symptoms | Creates the Symptom.
[**MasterTablesCreateTextCustomFieldDefinition**](MasterTablesApi.md#mastertablescreatetextcustomfielddefinition) | **POST** /api/mastertables/customfields/definitions/text | Creates the custom field.
[**MasterTablesCreateTimeCustomFieldDefinition**](MasterTablesApi.md#mastertablescreatetimecustomfielddefinition) | **POST** /api/mastertables/customfields/definitions/time | Creates the time custom field definition.
[**MasterTablesCreateTimeEntryReason**](MasterTablesApi.md#mastertablescreatetimeentryreason) | **POST** /api/mastertables/timeentryreasons | Creates a master table time entry reason.  &lt;remarks&gt;&lt;p&gt;         The AppliedTo Type field accepts values \&quot;TimeLogs\&quot;, \&quot;TimeSlips\&quot;, or \&quot;Both\&quot;. All the values are case sensitive.         The BillingOption Type field accepts value \&quot;ApplyToContract\&quot;, \&quot;ApplyToContractAndBillcustomer\&quot;, \&quot;DoNotInvoice\&quot;,\&quot;InvoiceCustomer\&quot;, \&quot;Business\&quot;, \&quot;Personal\&quot;      &lt;/p&gt;&lt;p&gt;         Value for RGBColor field in the request should be an RGB value of type integer. For example RGB value for white is (256*256*256*) &#x3D; 16777215      &lt;/p&gt;&lt;p&gt;        Valid values for rate basis field are \&quot;Regular\&quot;, \&quot;Overtime\&quot;, \&quot;Premium\&quot; and \&quot;Flat Fee\&quot;      &lt;/p&gt;&lt;/remarks&gt;
[**MasterTablesGetAccountCustomFields**](MasterTablesApi.md#mastertablesgetaccountcustomfields) | **GET** /api/mastertables/customfields/accounts | Gets the account custom fields.
[**MasterTablesGetAccountCustomFields_0**](MasterTablesApi.md#mastertablesgetaccountcustomfields_0) | **GET** /api/mastertables/customfields/accounts/{excludeSystemEntries} | Gets the account custom fields.
[**MasterTablesGetAccountGroups**](MasterTablesApi.md#mastertablesgetaccountgroups) | **GET** /api/mastertables/accounts/groups | Gets the account groups.
[**MasterTablesGetAccountProfiles**](MasterTablesApi.md#mastertablesgetaccountprofiles) | **GET** /api/mastertables/accounts/profiles | Gets the account profiles.
[**MasterTablesGetAccountSources**](MasterTablesApi.md#mastertablesgetaccountsources) | **GET** /api/mastertables/accounts/sources | Gets the account sources.
[**MasterTablesGetAccountSources_0**](MasterTablesApi.md#mastertablesgetaccountsources_0) | **GET** /api/mastertables/accounts/sources/{excludeSystemEntries} | Gets the account sources.
[**MasterTablesGetAccountStatuses**](MasterTablesApi.md#mastertablesgetaccountstatuses) | **GET** /api/mastertables/accounts/statuses | Gets a list of the defined account statuses.
[**MasterTablesGetAccountStatuses_0**](MasterTablesApi.md#mastertablesgetaccountstatuses_0) | **GET** /api/mastertables/account/statuses/{excludeSystemEntries} | Gets a list of the defined account statuses.
[**MasterTablesGetAccountTypes**](MasterTablesApi.md#mastertablesgetaccounttypes) | **GET** /api/mastertables/accounts/types | Gets a list of the defined account types.
[**MasterTablesGetAccountTypes_0**](MasterTablesApi.md#mastertablesgetaccounttypes_0) | **GET** /api/mastertables/accounts/types/{excludeSystemEntries} | Gets a list of the defined account types.
[**MasterTablesGetAssetTypes**](MasterTablesApi.md#mastertablesgetassettypes) | **GET** /api/mastertables/assettypes | Gets the asset types.
[**MasterTablesGetBOTaxCodes**](MasterTablesApi.md#mastertablesgetbotaxcodes) | **GET** /api/mastertables/botaxcodes | Gets the bo tax codes.
[**MasterTablesGetBOTaxTypes**](MasterTablesApi.md#mastertablesgetbotaxtypes) | **GET** /api/mastertables/botaxtypes | Gets the bo tax types.
[**MasterTablesGetContactCustomFields**](MasterTablesApi.md#mastertablesgetcontactcustomfields) | **GET** /api/mastertables/customfields/contacts | Gets the contact custom fields.
[**MasterTablesGetContactCustomFields_0**](MasterTablesApi.md#mastertablesgetcontactcustomfields_0) | **GET** /api/mastertables/customfields/contacts/{excludeSystemEntries} | Gets the contact custom fields.
[**MasterTablesGetContactGroups**](MasterTablesApi.md#mastertablesgetcontactgroups) | **GET** /api/mastertables/contact/groups | Gets the account groups.
[**MasterTablesGetContactProfiles**](MasterTablesApi.md#mastertablesgetcontactprofiles) | **GET** /api/mastertables/contact/profiles | Gets the contact profiles.
[**MasterTablesGetContractMeterGroups**](MasterTablesApi.md#mastertablesgetcontractmetergroups) | **GET** /api/mastertables/contracts/metergroups | Gets a list of the defined contract meter groups.
[**MasterTablesGetContractMeters**](MasterTablesApi.md#mastertablesgetcontractmeters) | **GET** /api/mastertables/contracts/meters | Gets a list of the defined contract meters.
[**MasterTablesGetCountries**](MasterTablesApi.md#mastertablesgetcountries) | **GET** /api/mastertables/countries | Gets a list of the defined countries.
[**MasterTablesGetCountries_0**](MasterTablesApi.md#mastertablesgetcountries_0) | **GET** /api/mastertables/countries/{excludeSystemEntries} | Gets a list of the defined countries.
[**MasterTablesGetDepartments**](MasterTablesApi.md#mastertablesgetdepartments) | **GET** /api/mastertables/departments | Gets the departments.
[**MasterTablesGetDispatchBoards**](MasterTablesApi.md#mastertablesgetdispatchboards) | **GET** /api/mastertables/dispatchboards | Gets the dispatch boards.
[**MasterTablesGetDocumentTopics**](MasterTablesApi.md#mastertablesgetdocumenttopics) | **GET** /api/mastertables/documenttopics | Gets the document topics.
[**MasterTablesGetExpensePaymentTypes**](MasterTablesApi.md#mastertablesgetexpensepaymenttypes) | **GET** /api/mastertables/expensepaymenttypes | Gets the expense payment types.
[**MasterTablesGetExpenseTypes**](MasterTablesApi.md#mastertablesgetexpensetypes) | **GET** /api/mastertables/expensetypes | Gets the expense types.
[**MasterTablesGetExternalProducts**](MasterTablesApi.md#mastertablesgetexternalproducts) | **GET** /api/mastertables/externalproducts | Gets the external products.
[**MasterTablesGetExternalProducts_0**](MasterTablesApi.md#mastertablesgetexternalproducts_0) | **GET** /api/mastertables/externalproducts/{excludeSystemEntries} | Gets the external products.
[**MasterTablesGetFreightTerms**](MasterTablesApi.md#mastertablesgetfreightterms) | **GET** /api/mastertables/freightterms | Returns the freight terms from the master tables.
[**MasterTablesGetInventoryLocations**](MasterTablesApi.md#mastertablesgetinventorylocations) | **GET** /api/mastertables/inventorylocations | Returns the inventory locations.
[**MasterTablesGetInventoryLocations_0**](MasterTablesApi.md#mastertablesgetinventorylocations_0) | **GET** /api/mastertables/inventorylocations/{excludeSystemEntries} | Returns the inventory locations.
[**MasterTablesGetInvoiceTerms**](MasterTablesApi.md#mastertablesgetinvoiceterms) | **GET** /api/mastertables/invoiceterms | Gets the invoice terms.
[**MasterTablesGetJournalActions**](MasterTablesApi.md#mastertablesgetjournalactions) | **GET** /api/mastertables/journal/actions | Gets the journal actions.
[**MasterTablesGetJournalActions_0**](MasterTablesApi.md#mastertablesgetjournalactions_0) | **GET** /api/mastertables/journal/actions/{excludeSystemEntries} | Gets the journal actions.
[**MasterTablesGetJournalTopics**](MasterTablesApi.md#mastertablesgetjournaltopics) | **GET** /api/mastertables/journal/topics | Gets the journal topics.
[**MasterTablesGetJournalTopics_0**](MasterTablesApi.md#mastertablesgetjournaltopics_0) | **GET** /api/mastertables/journal/topics/{excludeSystemEntries} | Gets the journal topics.
[**MasterTablesGetNamePrefixes**](MasterTablesApi.md#mastertablesgetnameprefixes) | **GET** /api/mastertables/nameprefixes | Gets the name prefixes.
[**MasterTablesGetNextActionTypes**](MasterTablesApi.md#mastertablesgetnextactiontypes) | **GET** /api/mastertables/nextActionTypes | Returns the defined Asset Next Action Tupes.
[**MasterTablesGetOpportunityCloseReasons**](MasterTablesApi.md#mastertablesgetopportunityclosereasons) | **GET** /api/mastertables/opportunities/closereasons | Gets the opportunity close reasons.
[**MasterTablesGetOpportunityCustomFields**](MasterTablesApi.md#mastertablesgetopportunitycustomfields) | **GET** /api/mastertables/customfields/opportunities | Gets the opportunity custom fields.
[**MasterTablesGetOpportunityCustomFields_0**](MasterTablesApi.md#mastertablesgetopportunitycustomfields_0) | **GET** /api/mastertables/customfields/opportunities/{excludeSystemEntries} | Gets the opportunity custom fields.
[**MasterTablesGetOpportunityHowDidYouHearAboutUs**](MasterTablesApi.md#mastertablesgetopportunityhowdidyouhearaboutus) | **GET** /api/mastertables/opportunities/howdidyouhearaboutus | Gets the opportunity how did you hear about us entries.
[**MasterTablesGetOpportunityHowDidYouHearAboutUs_0**](MasterTablesApi.md#mastertablesgetopportunityhowdidyouhearaboutus_0) | **GET** /api/mastertables/opportunities/howdidyouhearaboutus/{excludeSystemEntries} | Gets the opportunity how did you hear about us entries.
[**MasterTablesGetOpportunityNames**](MasterTablesApi.md#mastertablesgetopportunitynames) | **GET** /api/mastertables/opportunities/names | Gets the opportunity names.
[**MasterTablesGetOpportunityStages**](MasterTablesApi.md#mastertablesgetopportunitystages) | **GET** /api/mastertables/opportunities/stages | Gets the opportunity stages.
[**MasterTablesGetOpportunityStatuses**](MasterTablesApi.md#mastertablesgetopportunitystatuses) | **GET** /api/mastertables/opportunities/statuses | Gets the opportunity statuses.
[**MasterTablesGetOpportunityStatuses_0**](MasterTablesApi.md#mastertablesgetopportunitystatuses_0) | **GET** /api/mastertables/opportunities/statuses/{excludeSystemEntries} | Gets the opportunity statuses.
[**MasterTablesGetOpportunityTypes**](MasterTablesApi.md#mastertablesgetopportunitytypes) | **GET** /api/mastertables/opportunities/types | Gets the opportunity types.
[**MasterTablesGetOpportunityTypes_0**](MasterTablesApi.md#mastertablesgetopportunitytypes_0) | **GET** /api/mastertables/opportunities/types/{excludeSystemEntries} | Gets the opportunity types.
[**MasterTablesGetPasswordCategories**](MasterTablesApi.md#mastertablesgetpasswordcategories) | **GET** /api/mastertables/accounts/passwordcategories | Gets the password categories.
[**MasterTablesGetPasswordCategories_0**](MasterTablesApi.md#mastertablesgetpasswordcategories_0) | **GET** /api/mastertables/accounts/passwordcategories/{excludeSystemEntries} | Gets the password categories.
[**MasterTablesGetPaymentMethods**](MasterTablesApi.md#mastertablesgetpaymentmethods) | **GET** /api/mastertables/paymentmethods | Gets the payment methods.
[**MasterTablesGetPhoneLocations**](MasterTablesApi.md#mastertablesgetphonelocations) | **GET** /api/mastertables/phonelocations | Gets the phone locations.
[**MasterTablesGetPhoneLocations_0**](MasterTablesApi.md#mastertablesgetphonelocations_0) | **GET** /api/mastertables/phonelocations/{excludeSystemEntries} | Gets the phone locations.
[**MasterTablesGetPriceLevels**](MasterTablesApi.md#mastertablesgetpricelevels) | **GET** /api/mastertables/pricelevels | Gets the price levels.
[**MasterTablesGetPurchaseOrderDescriptions**](MasterTablesApi.md#mastertablesgetpurchaseorderdescriptions) | **GET** /api/mastertables/purchaseorderdescriptions | Returns the purchase order descriptions from the master tables.
[**MasterTablesGetReps**](MasterTablesApi.md#mastertablesgetreps) | **GET** /api/mastertables/reps | Gets a list of Reps.
[**MasterTablesGetReps_0**](MasterTablesApi.md#mastertablesgetreps_0) | **GET** /api/mastertables/reps/{activeOnly} | Gets a list of Reps.
[**MasterTablesGetResolutions**](MasterTablesApi.md#mastertablesgetresolutions) | **GET** /api/mastertables/resolutions | Gets a list of the defined resolutions.
[**MasterTablesGetSICCodes**](MasterTablesApi.md#mastertablesgetsiccodes) | **GET** /api/mastertables/siccodes | Gets a list of the defined SIC codes.
[**MasterTablesGetSalesTaxCodes**](MasterTablesApi.md#mastertablesgetsalestaxcodes) | **GET** /api/mastertables/salestaxcodes | Gets the sales tax codes.
[**MasterTablesGetServiceOrderBriefDescriptions**](MasterTablesApi.md#mastertablesgetserviceorderbriefdescriptions) | **GET** /api/mastertables/serviceOrders/descriptions | Returns the defined service order brief descriptions.
[**MasterTablesGetServiceOrderComments**](MasterTablesApi.md#mastertablesgetserviceordercomments) | **GET** /api/mastertables/serviceOrders/comments | Returns the defined service order comments.
[**MasterTablesGetServiceOrderDetailComments**](MasterTablesApi.md#mastertablesgetserviceorderdetailcomments) | **GET** /api/mastertables/serviceOrders/detailComments | Returns the defined service order detail comments.
[**MasterTablesGetServiceOrderNoteTopics**](MasterTablesApi.md#mastertablesgetserviceordernotetopics) | **GET** /api/mastertables/serviceOrder/noteTopics | Gets the service order note topics.
[**MasterTablesGetServiceOrderNoteTopics_0**](MasterTablesApi.md#mastertablesgetserviceordernotetopics_0) | **GET** /api/mastertables/serviceOrder/noteTopics/{excludeSystemEntries} | Gets the service order note topics.
[**MasterTablesGetServiceOrderPriorities**](MasterTablesApi.md#mastertablesgetserviceorderpriorities) | **GET** /api/mastertables/priorities | Gets a list of defined service order priorities.
[**MasterTablesGetServiceOrderProfiles**](MasterTablesApi.md#mastertablesgetserviceorderprofiles) | **GET** /api/mastertables/serviceOrderProfiles | Gets a list of the defined service order profiles.
[**MasterTablesGetServiceOrderSeverities**](MasterTablesApi.md#mastertablesgetserviceorderseverities) | **GET** /api/mastertables/severities | Gets a list of defined service order severities.
[**MasterTablesGetServiceOrderStatuses**](MasterTablesApi.md#mastertablesgetserviceorderstatuses) | **GET** /api/mastertables/serviceorders/statuses | Gets a list of defined service order statuses.
[**MasterTablesGetServiceOrderStatuses_0**](MasterTablesApi.md#mastertablesgetserviceorderstatuses_0) | **GET** /api/mastertables/serviceorders/statuses/{excludeSystemEntries} | Gets a list of defined service order statuses.
[**MasterTablesGetServiceOrderTemplates**](MasterTablesApi.md#mastertablesgetserviceordertemplates) | **GET** /api/mastertables/serviceorders/templates | 
[**MasterTablesGetServiceOrderTypes**](MasterTablesApi.md#mastertablesgetserviceordertypes) | **GET** /api/mastertables/serviceOrders/types | Gets a list of defined service order types.
[**MasterTablesGetServiceOrderTypes_0**](MasterTablesApi.md#mastertablesgetserviceordertypes_0) | **GET** /api/mastertables/serviceOrders/types/{excludeSystemEntries} | Gets a list of defined service order types.
[**MasterTablesGetServiceZones**](MasterTablesApi.md#mastertablesgetservicezones) | **GET** /api/mastertables/servicezones | Gets a list of the defined service zones.
[**MasterTablesGetShippers**](MasterTablesApi.md#mastertablesgetshippers) | **GET** /api/mastertables/shippers | Returns shippers stored in the master tables.
[**MasterTablesGetShippingMethods**](MasterTablesApi.md#mastertablesgetshippingmethods) | **GET** /api/mastertables/shippingmethods | Gets the shipping methods.
[**MasterTablesGetStates**](MasterTablesApi.md#mastertablesgetstates) | **GET** /api/mastertables/states | Gets a list of the defined states.
[**MasterTablesGetStates_0**](MasterTablesApi.md#mastertablesgetstates_0) | **GET** /api/mastertables/states/{excludeSystemEntries} | Gets a list of the defined states.
[**MasterTablesGetSubContractors**](MasterTablesApi.md#mastertablesgetsubcontractors) | **GET** /api/mastertables/subcontractors | Gets the sub contractors.
[**MasterTablesGetSupportedSystems**](MasterTablesApi.md#mastertablesgetsupportedsystems) | **GET** /api/mastertables/systems | Gets the systems.
[**MasterTablesGetSymptoms**](MasterTablesApi.md#mastertablesgetsymptoms) | **GET** /api/mastertables/symptoms | Gets a list of the defined symptoms.
[**MasterTablesGetSystemTypes**](MasterTablesApi.md#mastertablesgetsystemtypes) | **GET** /api/mastertables/systemtypes | Gets the system types.
[**MasterTablesGetTaskActionPlans**](MasterTablesApi.md#mastertablesgettaskactionplans) | **GET** /api/mastertables/tasks/actionplans | Gets a list of the task action plans.
[**MasterTablesGetTaskActions**](MasterTablesApi.md#mastertablesgettaskactions) | **GET** /api/mastertables/tasks/actions | Gets a list of the task action.
[**MasterTablesGetTaskCheckListTemplates**](MasterTablesApi.md#mastertablesgettaskchecklisttemplates) | **GET** /api/mastertables/tasks/checklisttemplates | Gets a list of the task checklist tempaltes.
[**MasterTablesGetTaskLibraries**](MasterTablesApi.md#mastertablesgettasklibraries) | **GET** /api/mastertables/tasks/libraries | Gets a list of the tasklibrary.
[**MasterTablesGetTaskResources**](MasterTablesApi.md#mastertablesgettaskresources) | **GET** /api/mastertables/tasks/resources | Gets a list of the task resources.
[**MasterTablesGetTimeEntryReasons**](MasterTablesApi.md#mastertablesgettimeentryreasons) | **GET** /api/mastertables/timeentryreasons | Gets the time entry reasons.
[**MasterTablesGetTitles**](MasterTablesApi.md#mastertablesgettitles) | **GET** /api/mastertables/titles | Gets the titles.
[**MasterTablesUpdateAccountCustomFieldCategory**](MasterTablesApi.md#mastertablesupdateaccountcustomfieldcategory) | **PUT** /api/mastertables/customfields/categories/accounts | Updates the account custom field category.
[**MasterTablesUpdateContactCustomFieldCategory**](MasterTablesApi.md#mastertablesupdatecontactcustomfieldcategory) | **PUT** /api/mastertables/customfields/categories/contacts | Updates the contact custom field category.
[**MasterTablesUpdateContractMeter**](MasterTablesApi.md#mastertablesupdatecontractmeter) | **PUT** /api/mastertables/contracts/meters | Updates the the ContractMeter.
[**MasterTablesUpdateContractMeterGroup**](MasterTablesApi.md#mastertablesupdatecontractmetergroup) | **PUT** /api/mastertables/contracts/metergroups | Updates the the Contract Meter group.
[**MasterTablesUpdateCustomFieldDefinition**](MasterTablesApi.md#mastertablesupdatecustomfielddefinition) | **PUT** /api/mastertables/customfields/definitions/{customFieldID} | Updates the custom field.
[**MasterTablesUpdateExpensePaymentType**](MasterTablesApi.md#mastertablesupdateexpensepaymenttype) | **PUT** /api/mastertables/expensepaymenttypes | Updates an expense payment type.
[**MasterTablesUpdateExpenseType**](MasterTablesApi.md#mastertablesupdateexpensetype) | **PUT** /api/mastertables/expenseTypes | Updates an expense type.
[**MasterTablesUpdateJournalAction**](MasterTablesApi.md#mastertablesupdatejournalaction) | **PUT** /api/mastertables/journal/actions | Updates the journal action.
[**MasterTablesUpdateJournalTopic**](MasterTablesApi.md#mastertablesupdatejournaltopic) | **PUT** /api/mastertables/journal/topics | Updates the journal topic.
[**MasterTablesUpdateOpportunityCustomFieldCategory**](MasterTablesApi.md#mastertablesupdateopportunitycustomfieldcategory) | **PUT** /api/mastertables/customfields/categories/opportunities | Updates the opportunity custom field category.
[**MasterTablesUpdateResolution**](MasterTablesApi.md#mastertablesupdateresolution) | **PUT** /api/mastertables/resolutions | Updates the the Resolution.
[**MasterTablesUpdateServiceOrderProfile**](MasterTablesApi.md#mastertablesupdateserviceorderprofile) | **PUT** /api/mastertables/serviceOrderProfiles | Updates the the Service Order Profile.
[**MasterTablesUpdateSymptom**](MasterTablesApi.md#mastertablesupdatesymptom) | **PUT** /api/mastertables/symptoms | Updates the the Symptom.
[**MasterTablesUpdateTimeEntryReason**](MasterTablesApi.md#mastertablesupdatetimeentryreason) | **PUT** /api/mastertables/timeentryreasons | Updates a master table time entry reason.  &lt;remarks&gt;&lt;p&gt;         The AppliedTo Type field accepts values \&quot;TimeLogs\&quot;, \&quot;TimeSlips\&quot;, or \&quot;Both\&quot;. All the values are case sensitive.         The BillingOption Type field accepts value \&quot;ApplyToContract\&quot;, \&quot;ApplyToContractAndBillcustomer\&quot;, \&quot;DoNotInvoice\&quot;,\&quot;InvoiceCustomer\&quot;, \&quot;Business\&quot;, \&quot;Personal\&quot;      &lt;/p&gt;&lt;p&gt;         Value for RGBColor field in the request should be an RGB value of type integer. For example RGB value for white is (256*256*256*) &#x3D; 16777215      &lt;/p&gt;&lt;p&gt;        Valid values for rate basis field are \&quot;Regular\&quot;, \&quot;Overtime\&quot;, \&quot;Premium\&quot; and \&quot;Flat Fee\&quot;      &lt;/p&gt;&lt;/remarks&gt;


<a name="mastertablescreateaccountcustomfieldcategory"></a>
# **MasterTablesCreateAccountCustomFieldCategory**
> TsiWebCustomFieldCategoryResponse MasterTablesCreateAccountCustomFieldCategory (TsiWebCustomFieldCategoryRequest request)

Creates the account custom field category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateAccountCustomFieldCategoryExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var request = new TsiWebCustomFieldCategoryRequest(); // TsiWebCustomFieldCategoryRequest | The request.

            try
            {
                // Creates the account custom field category.
                TsiWebCustomFieldCategoryResponse result = apiInstance.MasterTablesCreateAccountCustomFieldCategory(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateAccountCustomFieldCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebCustomFieldCategoryRequest**](TsiWebCustomFieldCategoryRequest.md)| The request. | 

### Return type

[**TsiWebCustomFieldCategoryResponse**](TsiWebCustomFieldCategoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatebooleancustomfielddefinition"></a>
# **MasterTablesCreateBooleanCustomFieldDefinition**
> TsiWebCustomFieldDefinitionResponse MasterTablesCreateBooleanCustomFieldDefinition (TsiWebCustomFieldDefinitionModel model)

Creates the true / false custom field definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateBooleanCustomFieldDefinitionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebCustomFieldDefinitionModel(); // TsiWebCustomFieldDefinitionModel | The model.

            try
            {
                // Creates the true / false custom field definition.
                TsiWebCustomFieldDefinitionResponse result = apiInstance.MasterTablesCreateBooleanCustomFieldDefinition(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateBooleanCustomFieldDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCustomFieldDefinitionModel**](TsiWebCustomFieldDefinitionModel.md)| The model. | 

### Return type

[**TsiWebCustomFieldDefinitionResponse**](TsiWebCustomFieldDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatecontactcustomfieldcategory"></a>
# **MasterTablesCreateContactCustomFieldCategory**
> TsiWebCustomFieldCategoryResponse MasterTablesCreateContactCustomFieldCategory (TsiWebCustomFieldCategoryRequest request)

Creates the contact custom field category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateContactCustomFieldCategoryExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var request = new TsiWebCustomFieldCategoryRequest(); // TsiWebCustomFieldCategoryRequest | The request.

            try
            {
                // Creates the contact custom field category.
                TsiWebCustomFieldCategoryResponse result = apiInstance.MasterTablesCreateContactCustomFieldCategory(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateContactCustomFieldCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebCustomFieldCategoryRequest**](TsiWebCustomFieldCategoryRequest.md)| The request. | 

### Return type

[**TsiWebCustomFieldCategoryResponse**](TsiWebCustomFieldCategoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatecontractmeter"></a>
# **MasterTablesCreateContractMeter**
> TsiWebMasterTableResponse MasterTablesCreateContractMeter (string meter)

Creates the ContractMeter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateContractMeterExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var meter = meter_example;  // string | The contract meter.

            try
            {
                // Creates the ContractMeter.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesCreateContractMeter(meter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateContractMeter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **meter** | **string**| The contract meter. | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatecontractmetergroup"></a>
# **MasterTablesCreateContractMeterGroup**
> TsiWebMasterTableResponse MasterTablesCreateContractMeterGroup (string meterGroup)

Creates the Contract Meter group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateContractMeterGroupExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var meterGroup = meterGroup_example;  // string | The contract meter group.

            try
            {
                // Creates the Contract Meter group.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesCreateContractMeterGroup(meterGroup);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateContractMeterGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **meterGroup** | **string**| The contract meter group. | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatecurrencycustomfielddefinition"></a>
# **MasterTablesCreateCurrencyCustomFieldDefinition**
> TsiWebCustomFieldDefinitionResponse MasterTablesCreateCurrencyCustomFieldDefinition (TsiWebCustomFieldDefinitionModel model)

Creates the currency custom field definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateCurrencyCustomFieldDefinitionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebCustomFieldDefinitionModel(); // TsiWebCustomFieldDefinitionModel | The custom field definition.

            try
            {
                // Creates the currency custom field definition.
                TsiWebCustomFieldDefinitionResponse result = apiInstance.MasterTablesCreateCurrencyCustomFieldDefinition(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateCurrencyCustomFieldDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCustomFieldDefinitionModel**](TsiWebCustomFieldDefinitionModel.md)| The custom field definition. | 

### Return type

[**TsiWebCustomFieldDefinitionResponse**](TsiWebCustomFieldDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatedatecustomfielddefinition"></a>
# **MasterTablesCreateDateCustomFieldDefinition**
> TsiWebCustomFieldDefinitionResponse MasterTablesCreateDateCustomFieldDefinition (TsiWebCustomFieldDefinitionModel model)

Creates the date custom field definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateDateCustomFieldDefinitionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebCustomFieldDefinitionModel(); // TsiWebCustomFieldDefinitionModel | The custom field definition.

            try
            {
                // Creates the date custom field definition.
                TsiWebCustomFieldDefinitionResponse result = apiInstance.MasterTablesCreateDateCustomFieldDefinition(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateDateCustomFieldDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCustomFieldDefinitionModel**](TsiWebCustomFieldDefinitionModel.md)| The custom field definition. | 

### Return type

[**TsiWebCustomFieldDefinitionResponse**](TsiWebCustomFieldDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatedropdowncustomfielddefinition"></a>
# **MasterTablesCreateDropDownCustomFieldDefinition**
> TsiWebCustomFieldDefinitionResponse MasterTablesCreateDropDownCustomFieldDefinition (TsiWebCustomFieldDefinitionModel model)

Creates the drop down custom field definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateDropDownCustomFieldDefinitionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebCustomFieldDefinitionModel(); // TsiWebCustomFieldDefinitionModel | The custom field definition.

            try
            {
                // Creates the drop down custom field definition.
                TsiWebCustomFieldDefinitionResponse result = apiInstance.MasterTablesCreateDropDownCustomFieldDefinition(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateDropDownCustomFieldDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCustomFieldDefinitionModel**](TsiWebCustomFieldDefinitionModel.md)| The custom field definition. | 

### Return type

[**TsiWebCustomFieldDefinitionResponse**](TsiWebCustomFieldDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreateexpensepaymenttype"></a>
# **MasterTablesCreateExpensePaymentType**
> TsiWebExpensePaymentTypesResponse MasterTablesCreateExpensePaymentType (TsiWebExpensePaymentTypeModel expensePaymentType)

Creates an expense payment type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateExpensePaymentTypeExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var expensePaymentType = new TsiWebExpensePaymentTypeModel(); // TsiWebExpensePaymentTypeModel | 

            try
            {
                // Creates an expense payment type.
                TsiWebExpensePaymentTypesResponse result = apiInstance.MasterTablesCreateExpensePaymentType(expensePaymentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateExpensePaymentType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expensePaymentType** | [**TsiWebExpensePaymentTypeModel**](TsiWebExpensePaymentTypeModel.md)|  | 

### Return type

[**TsiWebExpensePaymentTypesResponse**](TsiWebExpensePaymentTypesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreateexpensetype"></a>
# **MasterTablesCreateExpenseType**
> TsiWebExpenseTypesResponse MasterTablesCreateExpenseType (TsiWebExpenseTypeModel expenseType)

Create an expense type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateExpenseTypeExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var expenseType = new TsiWebExpenseTypeModel(); // TsiWebExpenseTypeModel | 

            try
            {
                // Create an expense type.
                TsiWebExpenseTypesResponse result = apiInstance.MasterTablesCreateExpenseType(expenseType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateExpenseType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **expenseType** | [**TsiWebExpenseTypeModel**](TsiWebExpenseTypeModel.md)|  | 

### Return type

[**TsiWebExpenseTypesResponse**](TsiWebExpenseTypesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatejournalaction"></a>
# **MasterTablesCreateJournalAction**
> TsiWebJournalActionsResponse MasterTablesCreateJournalAction (TsiWebJournalAction action)

Creates the journal action.

If Weight is excluded from the POST values it will be defaulted to 0.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateJournalActionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var action = new TsiWebJournalAction(); // TsiWebJournalAction | The journal action to create.

            try
            {
                // Creates the journal action.
                TsiWebJournalActionsResponse result = apiInstance.MasterTablesCreateJournalAction(action);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateJournalAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **action** | [**TsiWebJournalAction**](TsiWebJournalAction.md)| The journal action to create. | 

### Return type

[**TsiWebJournalActionsResponse**](TsiWebJournalActionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatejournaltopic"></a>
# **MasterTablesCreateJournalTopic**
> TsiWebMasterTableResponse MasterTablesCreateJournalTopic (string journalTopic)

Creates the journal topic.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateJournalTopicExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var journalTopic = journalTopic_example;  // string | The journal topic.

            try
            {
                // Creates the journal topic.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesCreateJournalTopic(journalTopic);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateJournalTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **journalTopic** | **string**| The journal topic. | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatenumbercustomfielddefinition"></a>
# **MasterTablesCreateNumberCustomFieldDefinition**
> TsiWebCustomFieldDefinitionResponse MasterTablesCreateNumberCustomFieldDefinition (TsiWebCustomFieldDefinitionModel model)

Creates the number custom field definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateNumberCustomFieldDefinitionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebCustomFieldDefinitionModel(); // TsiWebCustomFieldDefinitionModel | The custom field definition.

            try
            {
                // Creates the number custom field definition.
                TsiWebCustomFieldDefinitionResponse result = apiInstance.MasterTablesCreateNumberCustomFieldDefinition(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateNumberCustomFieldDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCustomFieldDefinitionModel**](TsiWebCustomFieldDefinitionModel.md)| The custom field definition. | 

### Return type

[**TsiWebCustomFieldDefinitionResponse**](TsiWebCustomFieldDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreateopportunitycustomfieldcategory"></a>
# **MasterTablesCreateOpportunityCustomFieldCategory**
> TsiWebCustomFieldCategoryResponse MasterTablesCreateOpportunityCustomFieldCategory (TsiWebCustomFieldCategoryRequest request)

Creates the opportunity custom field category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateOpportunityCustomFieldCategoryExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var request = new TsiWebCustomFieldCategoryRequest(); // TsiWebCustomFieldCategoryRequest | The request.

            try
            {
                // Creates the opportunity custom field category.
                TsiWebCustomFieldCategoryResponse result = apiInstance.MasterTablesCreateOpportunityCustomFieldCategory(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateOpportunityCustomFieldCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebCustomFieldCategoryRequest**](TsiWebCustomFieldCategoryRequest.md)| The request. | 

### Return type

[**TsiWebCustomFieldCategoryResponse**](TsiWebCustomFieldCategoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreateresolution"></a>
# **MasterTablesCreateResolution**
> TsiWebMasterTableResponse MasterTablesCreateResolution (string resolution)

Creates the Resolution.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateResolutionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var resolution = resolution_example;  // string | The contract resolution.

            try
            {
                // Creates the Resolution.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesCreateResolution(resolution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateResolution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resolution** | **string**| The contract resolution. | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreateserviceorderprofile"></a>
# **MasterTablesCreateServiceOrderProfile**
> TsiWebMasterTableResponse MasterTablesCreateServiceOrderProfile (string profile)

Creates the Service Order Profile.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateServiceOrderProfileExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var profile = profile_example;  // string | The contract meter.

            try
            {
                // Creates the Service Order Profile.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesCreateServiceOrderProfile(profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateServiceOrderProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **profile** | **string**| The contract meter. | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatesymptom"></a>
# **MasterTablesCreateSymptom**
> TsiWebMasterTableResponse MasterTablesCreateSymptom (string symptom)

Creates the Symptom.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateSymptomExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var symptom = symptom_example;  // string | The Symptom.

            try
            {
                // Creates the Symptom.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesCreateSymptom(symptom);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateSymptom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symptom** | **string**| The Symptom. | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatetextcustomfielddefinition"></a>
# **MasterTablesCreateTextCustomFieldDefinition**
> TsiWebCustomFieldDefinitionResponse MasterTablesCreateTextCustomFieldDefinition (TsiWebCustomFieldDefinitionModel model)

Creates the custom field.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateTextCustomFieldDefinitionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebCustomFieldDefinitionModel(); // TsiWebCustomFieldDefinitionModel | The custom field definition.

            try
            {
                // Creates the custom field.
                TsiWebCustomFieldDefinitionResponse result = apiInstance.MasterTablesCreateTextCustomFieldDefinition(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateTextCustomFieldDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCustomFieldDefinitionModel**](TsiWebCustomFieldDefinitionModel.md)| The custom field definition. | 

### Return type

[**TsiWebCustomFieldDefinitionResponse**](TsiWebCustomFieldDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatetimecustomfielddefinition"></a>
# **MasterTablesCreateTimeCustomFieldDefinition**
> TsiWebCustomFieldDefinitionResponse MasterTablesCreateTimeCustomFieldDefinition (TsiWebCustomFieldDefinitionModel model)

Creates the time custom field definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateTimeCustomFieldDefinitionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebCustomFieldDefinitionModel(); // TsiWebCustomFieldDefinitionModel | The custom field definition.

            try
            {
                // Creates the time custom field definition.
                TsiWebCustomFieldDefinitionResponse result = apiInstance.MasterTablesCreateTimeCustomFieldDefinition(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateTimeCustomFieldDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCustomFieldDefinitionModel**](TsiWebCustomFieldDefinitionModel.md)| The custom field definition. | 

### Return type

[**TsiWebCustomFieldDefinitionResponse**](TsiWebCustomFieldDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablescreatetimeentryreason"></a>
# **MasterTablesCreateTimeEntryReason**
> TsiWebTimeEntryReasonResponse MasterTablesCreateTimeEntryReason (TsiWebCreateTimeEntryReasonRequest reason)

Creates a master table time entry reason.  <remarks><p>         The AppliedTo Type field accepts values \"TimeLogs\", \"TimeSlips\", or \"Both\". All the values are case sensitive.         The BillingOption Type field accepts value \"ApplyToContract\", \"ApplyToContractAndBillcustomer\", \"DoNotInvoice\",\"InvoiceCustomer\", \"Business\", \"Personal\"      </p><p>         Value for RGBColor field in the request should be an RGB value of type integer. For example RGB value for white is (256*256*256*) = 16777215      </p><p>        Valid values for rate basis field are \"Regular\", \"Overtime\", \"Premium\" and \"Flat Fee\"      </p></remarks>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesCreateTimeEntryReasonExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var reason = new TsiWebCreateTimeEntryReasonRequest(); // TsiWebCreateTimeEntryReasonRequest | 

            try
            {
                // Creates a master table time entry reason.  <remarks><p>         The AppliedTo Type field accepts values \"TimeLogs\", \"TimeSlips\", or \"Both\". All the values are case sensitive.         The BillingOption Type field accepts value \"ApplyToContract\", \"ApplyToContractAndBillcustomer\", \"DoNotInvoice\",\"InvoiceCustomer\", \"Business\", \"Personal\"      </p><p>         Value for RGBColor field in the request should be an RGB value of type integer. For example RGB value for white is (256*256*256*) = 16777215      </p><p>        Valid values for rate basis field are \"Regular\", \"Overtime\", \"Premium\" and \"Flat Fee\"      </p></remarks>
                TsiWebTimeEntryReasonResponse result = apiInstance.MasterTablesCreateTimeEntryReason(reason);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesCreateTimeEntryReason: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reason** | [**TsiWebCreateTimeEntryReasonRequest**](TsiWebCreateTimeEntryReasonRequest.md)|  | 

### Return type

[**TsiWebTimeEntryReasonResponse**](TsiWebTimeEntryReasonResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetaccountcustomfields"></a>
# **MasterTablesGetAccountCustomFields**
> List<TsiWebCustomFieldCategory> MasterTablesGetAccountCustomFields (bool? excludeSystemEntries = null)

Gets the account custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAccountCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the account custom fields.
                List&lt;TsiWebCustomFieldCategory&gt; result = apiInstance.MasterTablesGetAccountCustomFields(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAccountCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebCustomFieldCategory>**](TsiWebCustomFieldCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetaccountcustomfields_0"></a>
# **MasterTablesGetAccountCustomFields_0**
> List<TsiWebCustomFieldCategory> MasterTablesGetAccountCustomFields_0 (bool? excludeSystemEntries)

Gets the account custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAccountCustomFields_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the account custom fields.
                List&lt;TsiWebCustomFieldCategory&gt; result = apiInstance.MasterTablesGetAccountCustomFields_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAccountCustomFields_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebCustomFieldCategory>**](TsiWebCustomFieldCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetaccountgroups"></a>
# **MasterTablesGetAccountGroups**
> List<TsiWebMarketingGroup> MasterTablesGetAccountGroups ()

Gets the account groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAccountGroupsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the account groups.
                List&lt;TsiWebMarketingGroup&gt; result = apiInstance.MasterTablesGetAccountGroups();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAccountGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebMarketingGroup>**](TsiWebMarketingGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetaccountprofiles"></a>
# **MasterTablesGetAccountProfiles**
> List<TsiWebAccountProfile> MasterTablesGetAccountProfiles ()

Gets the account profiles.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAccountProfilesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the account profiles.
                List&lt;TsiWebAccountProfile&gt; result = apiInstance.MasterTablesGetAccountProfiles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAccountProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebAccountProfile>**](TsiWebAccountProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetaccountsources"></a>
# **MasterTablesGetAccountSources**
> List<TsiWebAccountSource> MasterTablesGetAccountSources (bool? excludeSystemEntries = null)

Gets the account sources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAccountSourcesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the account sources.
                List&lt;TsiWebAccountSource&gt; result = apiInstance.MasterTablesGetAccountSources(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAccountSources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebAccountSource>**](TsiWebAccountSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetaccountsources_0"></a>
# **MasterTablesGetAccountSources_0**
> List<TsiWebAccountSource> MasterTablesGetAccountSources_0 (bool? excludeSystemEntries)

Gets the account sources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAccountSources_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the account sources.
                List&lt;TsiWebAccountSource&gt; result = apiInstance.MasterTablesGetAccountSources_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAccountSources_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebAccountSource>**](TsiWebAccountSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetaccountstatuses"></a>
# **MasterTablesGetAccountStatuses**
> List<TsiWebAccountStatus> MasterTablesGetAccountStatuses (bool? excludeSystemEntries = null)

Gets a list of the defined account statuses.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAccountStatusesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets a list of the defined account statuses.
                List&lt;TsiWebAccountStatus&gt; result = apiInstance.MasterTablesGetAccountStatuses(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAccountStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebAccountStatus>**](TsiWebAccountStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetaccountstatuses_0"></a>
# **MasterTablesGetAccountStatuses_0**
> List<TsiWebAccountStatus> MasterTablesGetAccountStatuses_0 (bool? excludeSystemEntries)

Gets a list of the defined account statuses.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAccountStatuses_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets a list of the defined account statuses.
                List&lt;TsiWebAccountStatus&gt; result = apiInstance.MasterTablesGetAccountStatuses_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAccountStatuses_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebAccountStatus>**](TsiWebAccountStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetaccounttypes"></a>
# **MasterTablesGetAccountTypes**
> List<TsiWebAccountType> MasterTablesGetAccountTypes (bool? excludeSystemEntries = null)

Gets a list of the defined account types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAccountTypesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets a list of the defined account types.
                List&lt;TsiWebAccountType&gt; result = apiInstance.MasterTablesGetAccountTypes(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAccountTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebAccountType>**](TsiWebAccountType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetaccounttypes_0"></a>
# **MasterTablesGetAccountTypes_0**
> List<TsiWebAccountType> MasterTablesGetAccountTypes_0 (bool? excludeSystemEntries)

Gets a list of the defined account types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAccountTypes_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets a list of the defined account types.
                List&lt;TsiWebAccountType&gt; result = apiInstance.MasterTablesGetAccountTypes_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAccountTypes_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebAccountType>**](TsiWebAccountType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetassettypes"></a>
# **MasterTablesGetAssetTypes**
> List<TsiWebAssetType> MasterTablesGetAssetTypes ()

Gets the asset types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetAssetTypesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the asset types.
                List&lt;TsiWebAssetType&gt; result = apiInstance.MasterTablesGetAssetTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetAssetTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebAssetType>**](TsiWebAssetType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetbotaxcodes"></a>
# **MasterTablesGetBOTaxCodes**
> List<TsiWebBOTaxCode> MasterTablesGetBOTaxCodes ()

Gets the bo tax codes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetBOTaxCodesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the bo tax codes.
                List&lt;TsiWebBOTaxCode&gt; result = apiInstance.MasterTablesGetBOTaxCodes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetBOTaxCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebBOTaxCode>**](TsiWebBOTaxCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetbotaxtypes"></a>
# **MasterTablesGetBOTaxTypes**
> List<TsiWebBOTaxType> MasterTablesGetBOTaxTypes ()

Gets the bo tax types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetBOTaxTypesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the bo tax types.
                List&lt;TsiWebBOTaxType&gt; result = apiInstance.MasterTablesGetBOTaxTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetBOTaxTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebBOTaxType>**](TsiWebBOTaxType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetcontactcustomfields"></a>
# **MasterTablesGetContactCustomFields**
> List<TsiWebCustomFieldCategory> MasterTablesGetContactCustomFields (bool? excludeSystemEntries = null)

Gets the contact custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetContactCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the contact custom fields.
                List&lt;TsiWebCustomFieldCategory&gt; result = apiInstance.MasterTablesGetContactCustomFields(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetContactCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebCustomFieldCategory>**](TsiWebCustomFieldCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetcontactcustomfields_0"></a>
# **MasterTablesGetContactCustomFields_0**
> List<TsiWebCustomFieldCategory> MasterTablesGetContactCustomFields_0 (bool? excludeSystemEntries)

Gets the contact custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetContactCustomFields_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the contact custom fields.
                List&lt;TsiWebCustomFieldCategory&gt; result = apiInstance.MasterTablesGetContactCustomFields_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetContactCustomFields_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebCustomFieldCategory>**](TsiWebCustomFieldCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetcontactgroups"></a>
# **MasterTablesGetContactGroups**
> List<TsiWebMarketingGroup> MasterTablesGetContactGroups ()

Gets the account groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetContactGroupsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the account groups.
                List&lt;TsiWebMarketingGroup&gt; result = apiInstance.MasterTablesGetContactGroups();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetContactGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebMarketingGroup>**](TsiWebMarketingGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetcontactprofiles"></a>
# **MasterTablesGetContactProfiles**
> List<TsiWebContactProfile> MasterTablesGetContactProfiles ()

Gets the contact profiles.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetContactProfilesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the contact profiles.
                List&lt;TsiWebContactProfile&gt; result = apiInstance.MasterTablesGetContactProfiles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetContactProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebContactProfile>**](TsiWebContactProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetcontractmetergroups"></a>
# **MasterTablesGetContractMeterGroups**
> List<TsiWebMeterGroup> MasterTablesGetContractMeterGroups ()

Gets a list of the defined contract meter groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetContractMeterGroupsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the defined contract meter groups.
                List&lt;TsiWebMeterGroup&gt; result = apiInstance.MasterTablesGetContractMeterGroups();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetContractMeterGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebMeterGroup>**](TsiWebMeterGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetcontractmeters"></a>
# **MasterTablesGetContractMeters**
> List<TsiWebMeter> MasterTablesGetContractMeters ()

Gets a list of the defined contract meters.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetContractMetersExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the defined contract meters.
                List&lt;TsiWebMeter&gt; result = apiInstance.MasterTablesGetContractMeters();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetContractMeters: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebMeter>**](TsiWebMeter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetcountries"></a>
# **MasterTablesGetCountries**
> List<TsiWebCountry> MasterTablesGetCountries (bool? excludeSystemEntries = null)

Gets a list of the defined countries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetCountriesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets a list of the defined countries.
                List&lt;TsiWebCountry&gt; result = apiInstance.MasterTablesGetCountries(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetCountries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebCountry>**](TsiWebCountry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetcountries_0"></a>
# **MasterTablesGetCountries_0**
> List<TsiWebCountry> MasterTablesGetCountries_0 (bool? excludeSystemEntries)

Gets a list of the defined countries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetCountries_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets a list of the defined countries.
                List&lt;TsiWebCountry&gt; result = apiInstance.MasterTablesGetCountries_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetCountries_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebCountry>**](TsiWebCountry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetdepartments"></a>
# **MasterTablesGetDepartments**
> List<TsiWebDepartment> MasterTablesGetDepartments ()

Gets the departments.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetDepartmentsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the departments.
                List&lt;TsiWebDepartment&gt; result = apiInstance.MasterTablesGetDepartments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetDepartments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebDepartment>**](TsiWebDepartment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetdispatchboards"></a>
# **MasterTablesGetDispatchBoards**
> List<TsiWebDispatchBoard> MasterTablesGetDispatchBoards ()

Gets the dispatch boards.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetDispatchBoardsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the dispatch boards.
                List&lt;TsiWebDispatchBoard&gt; result = apiInstance.MasterTablesGetDispatchBoards();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetDispatchBoards: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebDispatchBoard>**](TsiWebDispatchBoard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetdocumenttopics"></a>
# **MasterTablesGetDocumentTopics**
> List<TsiWebDocumentTopic> MasterTablesGetDocumentTopics ()

Gets the document topics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetDocumentTopicsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the document topics.
                List&lt;TsiWebDocumentTopic&gt; result = apiInstance.MasterTablesGetDocumentTopics();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetDocumentTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebDocumentTopic>**](TsiWebDocumentTopic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetexpensepaymenttypes"></a>
# **MasterTablesGetExpensePaymentTypes**
> List<TsiWebExpensePaymentType> MasterTablesGetExpensePaymentTypes ()

Gets the expense payment types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetExpensePaymentTypesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the expense payment types.
                List&lt;TsiWebExpensePaymentType&gt; result = apiInstance.MasterTablesGetExpensePaymentTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetExpensePaymentTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebExpensePaymentType>**](TsiWebExpensePaymentType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetexpensetypes"></a>
# **MasterTablesGetExpenseTypes**
> List<TsiWebExpenseType> MasterTablesGetExpenseTypes ()

Gets the expense types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetExpenseTypesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the expense types.
                List&lt;TsiWebExpenseType&gt; result = apiInstance.MasterTablesGetExpenseTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetExpenseTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebExpenseType>**](TsiWebExpenseType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetexternalproducts"></a>
# **MasterTablesGetExternalProducts**
> List<TsiWebExternalProduct> MasterTablesGetExternalProducts (bool? excludeSystemEntries = null)

Gets the external products.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetExternalProductsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the external products.
                List&lt;TsiWebExternalProduct&gt; result = apiInstance.MasterTablesGetExternalProducts(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetExternalProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebExternalProduct>**](TsiWebExternalProduct.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetexternalproducts_0"></a>
# **MasterTablesGetExternalProducts_0**
> List<TsiWebExternalProduct> MasterTablesGetExternalProducts_0 (bool? excludeSystemEntries)

Gets the external products.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetExternalProducts_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the external products.
                List&lt;TsiWebExternalProduct&gt; result = apiInstance.MasterTablesGetExternalProducts_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetExternalProducts_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebExternalProduct>**](TsiWebExternalProduct.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetfreightterms"></a>
# **MasterTablesGetFreightTerms**
> List<TsiWebFreightTerm> MasterTablesGetFreightTerms ()

Returns the freight terms from the master tables.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetFreightTermsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Returns the freight terms from the master tables.
                List&lt;TsiWebFreightTerm&gt; result = apiInstance.MasterTablesGetFreightTerms();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetFreightTerms: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebFreightTerm>**](TsiWebFreightTerm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetinventorylocations"></a>
# **MasterTablesGetInventoryLocations**
> List<TsiWebInventoryLocation> MasterTablesGetInventoryLocations (bool? excludeSystemEntries = null)

Returns the inventory locations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetInventoryLocationsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? |  (optional) 

            try
            {
                // Returns the inventory locations.
                List&lt;TsiWebInventoryLocation&gt; result = apiInstance.MasterTablesGetInventoryLocations(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetInventoryLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**|  | [optional] 

### Return type

[**List<TsiWebInventoryLocation>**](TsiWebInventoryLocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetinventorylocations_0"></a>
# **MasterTablesGetInventoryLocations_0**
> List<TsiWebInventoryLocation> MasterTablesGetInventoryLocations_0 (bool? excludeSystemEntries)

Returns the inventory locations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetInventoryLocations_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | 

            try
            {
                // Returns the inventory locations.
                List&lt;TsiWebInventoryLocation&gt; result = apiInstance.MasterTablesGetInventoryLocations_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetInventoryLocations_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**|  | 

### Return type

[**List<TsiWebInventoryLocation>**](TsiWebInventoryLocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetinvoiceterms"></a>
# **MasterTablesGetInvoiceTerms**
> List<TsiWebInvoiceTerm> MasterTablesGetInvoiceTerms ()

Gets the invoice terms.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetInvoiceTermsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the invoice terms.
                List&lt;TsiWebInvoiceTerm&gt; result = apiInstance.MasterTablesGetInvoiceTerms();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetInvoiceTerms: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebInvoiceTerm>**](TsiWebInvoiceTerm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetjournalactions"></a>
# **MasterTablesGetJournalActions**
> List<TsiWebJournalAction> MasterTablesGetJournalActions (bool? excludeSystemEntries = null)

Gets the journal actions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetJournalActionsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the journal actions.
                List&lt;TsiWebJournalAction&gt; result = apiInstance.MasterTablesGetJournalActions(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetJournalActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebJournalAction>**](TsiWebJournalAction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetjournalactions_0"></a>
# **MasterTablesGetJournalActions_0**
> List<TsiWebJournalAction> MasterTablesGetJournalActions_0 (bool? excludeSystemEntries)

Gets the journal actions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetJournalActions_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the journal actions.
                List&lt;TsiWebJournalAction&gt; result = apiInstance.MasterTablesGetJournalActions_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetJournalActions_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebJournalAction>**](TsiWebJournalAction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetjournaltopics"></a>
# **MasterTablesGetJournalTopics**
> List<TsiWebJournalTopic> MasterTablesGetJournalTopics (bool? excludeSystemEntries = null)

Gets the journal topics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetJournalTopicsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the journal topics.
                List&lt;TsiWebJournalTopic&gt; result = apiInstance.MasterTablesGetJournalTopics(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetJournalTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebJournalTopic>**](TsiWebJournalTopic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetjournaltopics_0"></a>
# **MasterTablesGetJournalTopics_0**
> List<TsiWebJournalTopic> MasterTablesGetJournalTopics_0 (bool? excludeSystemEntries)

Gets the journal topics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetJournalTopics_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the journal topics.
                List&lt;TsiWebJournalTopic&gt; result = apiInstance.MasterTablesGetJournalTopics_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetJournalTopics_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebJournalTopic>**](TsiWebJournalTopic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetnameprefixes"></a>
# **MasterTablesGetNamePrefixes**
> List<TsiWebPrefix> MasterTablesGetNamePrefixes ()

Gets the name prefixes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetNamePrefixesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the name prefixes.
                List&lt;TsiWebPrefix&gt; result = apiInstance.MasterTablesGetNamePrefixes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetNamePrefixes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebPrefix>**](TsiWebPrefix.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetnextactiontypes"></a>
# **MasterTablesGetNextActionTypes**
> List<TsiWebNextActionType> MasterTablesGetNextActionTypes ()

Returns the defined Asset Next Action Tupes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetNextActionTypesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Returns the defined Asset Next Action Tupes.
                List&lt;TsiWebNextActionType&gt; result = apiInstance.MasterTablesGetNextActionTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetNextActionTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebNextActionType>**](TsiWebNextActionType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunityclosereasons"></a>
# **MasterTablesGetOpportunityCloseReasons**
> List<TsiWebCloseReason> MasterTablesGetOpportunityCloseReasons ()

Gets the opportunity close reasons.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityCloseReasonsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the opportunity close reasons.
                List&lt;TsiWebCloseReason&gt; result = apiInstance.MasterTablesGetOpportunityCloseReasons();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityCloseReasons: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebCloseReason>**](TsiWebCloseReason.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunitycustomfields"></a>
# **MasterTablesGetOpportunityCustomFields**
> List<TsiWebCustomFieldCategory> MasterTablesGetOpportunityCustomFields (bool? excludeSystemEntries = null)

Gets the opportunity custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the opportunity custom fields.
                List&lt;TsiWebCustomFieldCategory&gt; result = apiInstance.MasterTablesGetOpportunityCustomFields(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebCustomFieldCategory>**](TsiWebCustomFieldCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunitycustomfields_0"></a>
# **MasterTablesGetOpportunityCustomFields_0**
> List<TsiWebCustomFieldCategory> MasterTablesGetOpportunityCustomFields_0 (bool? excludeSystemEntries)

Gets the opportunity custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityCustomFields_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the opportunity custom fields.
                List&lt;TsiWebCustomFieldCategory&gt; result = apiInstance.MasterTablesGetOpportunityCustomFields_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityCustomFields_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebCustomFieldCategory>**](TsiWebCustomFieldCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunityhowdidyouhearaboutus"></a>
# **MasterTablesGetOpportunityHowDidYouHearAboutUs**
> List<TsiWebHowDidYouHearAboutUs> MasterTablesGetOpportunityHowDidYouHearAboutUs (bool? excludeSystemEntries = null)

Gets the opportunity how did you hear about us entries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityHowDidYouHearAboutUsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the opportunity how did you hear about us entries.
                List&lt;TsiWebHowDidYouHearAboutUs&gt; result = apiInstance.MasterTablesGetOpportunityHowDidYouHearAboutUs(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityHowDidYouHearAboutUs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebHowDidYouHearAboutUs>**](TsiWebHowDidYouHearAboutUs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunityhowdidyouhearaboutus_0"></a>
# **MasterTablesGetOpportunityHowDidYouHearAboutUs_0**
> List<TsiWebHowDidYouHearAboutUs> MasterTablesGetOpportunityHowDidYouHearAboutUs_0 (bool? excludeSystemEntries)

Gets the opportunity how did you hear about us entries.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityHowDidYouHearAboutUs_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the opportunity how did you hear about us entries.
                List&lt;TsiWebHowDidYouHearAboutUs&gt; result = apiInstance.MasterTablesGetOpportunityHowDidYouHearAboutUs_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityHowDidYouHearAboutUs_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebHowDidYouHearAboutUs>**](TsiWebHowDidYouHearAboutUs.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunitynames"></a>
# **MasterTablesGetOpportunityNames**
> List<TsiWebOpportunityName> MasterTablesGetOpportunityNames ()

Gets the opportunity names.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityNamesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the opportunity names.
                List&lt;TsiWebOpportunityName&gt; result = apiInstance.MasterTablesGetOpportunityNames();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityNames: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebOpportunityName>**](TsiWebOpportunityName.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunitystages"></a>
# **MasterTablesGetOpportunityStages**
> List<TsiWebOpportunityStage> MasterTablesGetOpportunityStages ()

Gets the opportunity stages.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityStagesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the opportunity stages.
                List&lt;TsiWebOpportunityStage&gt; result = apiInstance.MasterTablesGetOpportunityStages();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityStages: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebOpportunityStage>**](TsiWebOpportunityStage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunitystatuses"></a>
# **MasterTablesGetOpportunityStatuses**
> List<TsiWebOpportunityStatus> MasterTablesGetOpportunityStatuses (bool? excludeSystemEntries = null)

Gets the opportunity statuses.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityStatusesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the opportunity statuses.
                List&lt;TsiWebOpportunityStatus&gt; result = apiInstance.MasterTablesGetOpportunityStatuses(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebOpportunityStatus>**](TsiWebOpportunityStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunitystatuses_0"></a>
# **MasterTablesGetOpportunityStatuses_0**
> List<TsiWebOpportunityStatus> MasterTablesGetOpportunityStatuses_0 (bool? excludeSystemEntries)

Gets the opportunity statuses.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityStatuses_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the opportunity statuses.
                List&lt;TsiWebOpportunityStatus&gt; result = apiInstance.MasterTablesGetOpportunityStatuses_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityStatuses_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebOpportunityStatus>**](TsiWebOpportunityStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunitytypes"></a>
# **MasterTablesGetOpportunityTypes**
> List<TsiWebOpportunityType> MasterTablesGetOpportunityTypes (bool? excludeSystemEntries = null)

Gets the opportunity types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityTypesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the opportunity types.
                List&lt;TsiWebOpportunityType&gt; result = apiInstance.MasterTablesGetOpportunityTypes(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebOpportunityType>**](TsiWebOpportunityType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetopportunitytypes_0"></a>
# **MasterTablesGetOpportunityTypes_0**
> List<TsiWebOpportunityType> MasterTablesGetOpportunityTypes_0 (bool? excludeSystemEntries)

Gets the opportunity types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetOpportunityTypes_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the opportunity types.
                List&lt;TsiWebOpportunityType&gt; result = apiInstance.MasterTablesGetOpportunityTypes_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetOpportunityTypes_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebOpportunityType>**](TsiWebOpportunityType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetpasswordcategories"></a>
# **MasterTablesGetPasswordCategories**
> List<TsiWebPasswordCategory> MasterTablesGetPasswordCategories (bool? excludeSystemEntries = null)

Gets the password categories.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetPasswordCategoriesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the password categories.
                List&lt;TsiWebPasswordCategory&gt; result = apiInstance.MasterTablesGetPasswordCategories(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetPasswordCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebPasswordCategory>**](TsiWebPasswordCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetpasswordcategories_0"></a>
# **MasterTablesGetPasswordCategories_0**
> List<TsiWebPasswordCategory> MasterTablesGetPasswordCategories_0 (bool? excludeSystemEntries)

Gets the password categories.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetPasswordCategories_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the password categories.
                List&lt;TsiWebPasswordCategory&gt; result = apiInstance.MasterTablesGetPasswordCategories_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetPasswordCategories_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebPasswordCategory>**](TsiWebPasswordCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetpaymentmethods"></a>
# **MasterTablesGetPaymentMethods**
> List<TsiWebPaymentMethod> MasterTablesGetPaymentMethods ()

Gets the payment methods.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetPaymentMethodsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the payment methods.
                List&lt;TsiWebPaymentMethod&gt; result = apiInstance.MasterTablesGetPaymentMethods();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetPaymentMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebPaymentMethod>**](TsiWebPaymentMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetphonelocations"></a>
# **MasterTablesGetPhoneLocations**
> List<TsiWebPhoneLocation> MasterTablesGetPhoneLocations (bool? excludeSystemEntries = null)

Gets the phone locations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetPhoneLocationsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the phone locations.
                List&lt;TsiWebPhoneLocation&gt; result = apiInstance.MasterTablesGetPhoneLocations(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetPhoneLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebPhoneLocation>**](TsiWebPhoneLocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetphonelocations_0"></a>
# **MasterTablesGetPhoneLocations_0**
> List<TsiWebPhoneLocation> MasterTablesGetPhoneLocations_0 (bool? excludeSystemEntries)

Gets the phone locations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetPhoneLocations_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the phone locations.
                List&lt;TsiWebPhoneLocation&gt; result = apiInstance.MasterTablesGetPhoneLocations_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetPhoneLocations_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebPhoneLocation>**](TsiWebPhoneLocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetpricelevels"></a>
# **MasterTablesGetPriceLevels**
> List<TsiWebPriceLevel> MasterTablesGetPriceLevels ()

Gets the price levels.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetPriceLevelsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the price levels.
                List&lt;TsiWebPriceLevel&gt; result = apiInstance.MasterTablesGetPriceLevels();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetPriceLevels: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebPriceLevel>**](TsiWebPriceLevel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetpurchaseorderdescriptions"></a>
# **MasterTablesGetPurchaseOrderDescriptions**
> List<TsiWebPurchaseOrderDescription> MasterTablesGetPurchaseOrderDescriptions ()

Returns the purchase order descriptions from the master tables.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetPurchaseOrderDescriptionsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Returns the purchase order descriptions from the master tables.
                List&lt;TsiWebPurchaseOrderDescription&gt; result = apiInstance.MasterTablesGetPurchaseOrderDescriptions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetPurchaseOrderDescriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebPurchaseOrderDescription>**](TsiWebPurchaseOrderDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetreps"></a>
# **MasterTablesGetReps**
> List<TsiWebRepSummary> MasterTablesGetReps (bool? activeOnly = null)

Gets a list of Reps.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetRepsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var activeOnly = true;  // bool? | If true excludes inactive reps. (optional) 

            try
            {
                // Gets a list of Reps.
                List&lt;TsiWebRepSummary&gt; result = apiInstance.MasterTablesGetReps(activeOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetReps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activeOnly** | **bool?**| If true excludes inactive reps. | [optional] 

### Return type

[**List<TsiWebRepSummary>**](TsiWebRepSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetreps_0"></a>
# **MasterTablesGetReps_0**
> List<TsiWebRepSummary> MasterTablesGetReps_0 (bool? activeOnly)

Gets a list of Reps.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetReps_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var activeOnly = true;  // bool? | If true excludes inactive reps.

            try
            {
                // Gets a list of Reps.
                List&lt;TsiWebRepSummary&gt; result = apiInstance.MasterTablesGetReps_0(activeOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetReps_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activeOnly** | **bool?**| If true excludes inactive reps. | 

### Return type

[**List<TsiWebRepSummary>**](TsiWebRepSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetresolutions"></a>
# **MasterTablesGetResolutions**
> List<TsiWebResolution> MasterTablesGetResolutions ()

Gets a list of the defined resolutions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetResolutionsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the defined resolutions.
                List&lt;TsiWebResolution&gt; result = apiInstance.MasterTablesGetResolutions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetResolutions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebResolution>**](TsiWebResolution.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetsiccodes"></a>
# **MasterTablesGetSICCodes**
> List<TsiWebSICCode> MasterTablesGetSICCodes ()

Gets a list of the defined SIC codes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetSICCodesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the defined SIC codes.
                List&lt;TsiWebSICCode&gt; result = apiInstance.MasterTablesGetSICCodes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetSICCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebSICCode>**](TsiWebSICCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetsalestaxcodes"></a>
# **MasterTablesGetSalesTaxCodes**
> List<TsiWebSalesTaxCode> MasterTablesGetSalesTaxCodes ()

Gets the sales tax codes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetSalesTaxCodesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the sales tax codes.
                List&lt;TsiWebSalesTaxCode&gt; result = apiInstance.MasterTablesGetSalesTaxCodes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetSalesTaxCodes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebSalesTaxCode>**](TsiWebSalesTaxCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceorderbriefdescriptions"></a>
# **MasterTablesGetServiceOrderBriefDescriptions**
> List<TsiWebServiceOrderBriefDescription> MasterTablesGetServiceOrderBriefDescriptions ()

Returns the defined service order brief descriptions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderBriefDescriptionsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Returns the defined service order brief descriptions.
                List&lt;TsiWebServiceOrderBriefDescription&gt; result = apiInstance.MasterTablesGetServiceOrderBriefDescriptions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderBriefDescriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebServiceOrderBriefDescription>**](TsiWebServiceOrderBriefDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceordercomments"></a>
# **MasterTablesGetServiceOrderComments**
> List<TsiWebServiceOrderComment> MasterTablesGetServiceOrderComments ()

Returns the defined service order comments.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderCommentsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Returns the defined service order comments.
                List&lt;TsiWebServiceOrderComment&gt; result = apiInstance.MasterTablesGetServiceOrderComments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderComments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebServiceOrderComment>**](TsiWebServiceOrderComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceorderdetailcomments"></a>
# **MasterTablesGetServiceOrderDetailComments**
> List<TsiWebServiceOrderDetailComment> MasterTablesGetServiceOrderDetailComments ()

Returns the defined service order detail comments.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderDetailCommentsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Returns the defined service order detail comments.
                List&lt;TsiWebServiceOrderDetailComment&gt; result = apiInstance.MasterTablesGetServiceOrderDetailComments();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderDetailComments: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebServiceOrderDetailComment>**](TsiWebServiceOrderDetailComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceordernotetopics"></a>
# **MasterTablesGetServiceOrderNoteTopics**
> List<TsiWebServiceOrderNoteTopic> MasterTablesGetServiceOrderNoteTopics (bool? excludeSystemEntries = null)

Gets the service order note topics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderNoteTopicsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets the service order note topics.
                List&lt;TsiWebServiceOrderNoteTopic&gt; result = apiInstance.MasterTablesGetServiceOrderNoteTopics(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderNoteTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebServiceOrderNoteTopic>**](TsiWebServiceOrderNoteTopic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceordernotetopics_0"></a>
# **MasterTablesGetServiceOrderNoteTopics_0**
> List<TsiWebServiceOrderNoteTopic> MasterTablesGetServiceOrderNoteTopics_0 (bool? excludeSystemEntries)

Gets the service order note topics.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderNoteTopics_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets the service order note topics.
                List&lt;TsiWebServiceOrderNoteTopic&gt; result = apiInstance.MasterTablesGetServiceOrderNoteTopics_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderNoteTopics_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebServiceOrderNoteTopic>**](TsiWebServiceOrderNoteTopic.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceorderpriorities"></a>
# **MasterTablesGetServiceOrderPriorities**
> List<TsiWebServiceOrderPriority> MasterTablesGetServiceOrderPriorities ()

Gets a list of defined service order priorities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderPrioritiesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of defined service order priorities.
                List&lt;TsiWebServiceOrderPriority&gt; result = apiInstance.MasterTablesGetServiceOrderPriorities();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderPriorities: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebServiceOrderPriority>**](TsiWebServiceOrderPriority.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceorderprofiles"></a>
# **MasterTablesGetServiceOrderProfiles**
> List<TsiWebServiceOrderProfile> MasterTablesGetServiceOrderProfiles ()

Gets a list of the defined service order profiles.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderProfilesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the defined service order profiles.
                List&lt;TsiWebServiceOrderProfile&gt; result = apiInstance.MasterTablesGetServiceOrderProfiles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebServiceOrderProfile>**](TsiWebServiceOrderProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceorderseverities"></a>
# **MasterTablesGetServiceOrderSeverities**
> List<TsiWebServiceOrderSeverity> MasterTablesGetServiceOrderSeverities ()

Gets a list of defined service order severities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderSeveritiesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of defined service order severities.
                List&lt;TsiWebServiceOrderSeverity&gt; result = apiInstance.MasterTablesGetServiceOrderSeverities();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderSeverities: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebServiceOrderSeverity>**](TsiWebServiceOrderSeverity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceorderstatuses"></a>
# **MasterTablesGetServiceOrderStatuses**
> TsiWebServiceOrderStatus MasterTablesGetServiceOrderStatuses (bool? excludeSystemEntries = null)

Gets a list of defined service order statuses.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderStatusesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? |  (optional) 

            try
            {
                // Gets a list of defined service order statuses.
                TsiWebServiceOrderStatus result = apiInstance.MasterTablesGetServiceOrderStatuses(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**|  | [optional] 

### Return type

[**TsiWebServiceOrderStatus**](TsiWebServiceOrderStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceorderstatuses_0"></a>
# **MasterTablesGetServiceOrderStatuses_0**
> TsiWebServiceOrderStatus MasterTablesGetServiceOrderStatuses_0 (bool? excludeSystemEntries)

Gets a list of defined service order statuses.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderStatuses_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | 

            try
            {
                // Gets a list of defined service order statuses.
                TsiWebServiceOrderStatus result = apiInstance.MasterTablesGetServiceOrderStatuses_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderStatuses_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**|  | 

### Return type

[**TsiWebServiceOrderStatus**](TsiWebServiceOrderStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceordertemplates"></a>
# **MasterTablesGetServiceOrderTemplates**
> List<TsiWebServiceOrderTemplate> MasterTablesGetServiceOrderTemplates ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderTemplatesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                List&lt;TsiWebServiceOrderTemplate&gt; result = apiInstance.MasterTablesGetServiceOrderTemplates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebServiceOrderTemplate>**](TsiWebServiceOrderTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceordertypes"></a>
# **MasterTablesGetServiceOrderTypes**
> List<TsiWebServiceOrderType> MasterTablesGetServiceOrderTypes (bool? excludeSystemEntries = null)

Gets a list of defined service order types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderTypesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? |  (optional) 

            try
            {
                // Gets a list of defined service order types.
                List&lt;TsiWebServiceOrderType&gt; result = apiInstance.MasterTablesGetServiceOrderTypes(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**|  | [optional] 

### Return type

[**List<TsiWebServiceOrderType>**](TsiWebServiceOrderType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetserviceordertypes_0"></a>
# **MasterTablesGetServiceOrderTypes_0**
> List<TsiWebServiceOrderType> MasterTablesGetServiceOrderTypes_0 (bool? excludeSystemEntries)

Gets a list of defined service order types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceOrderTypes_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | 

            try
            {
                // Gets a list of defined service order types.
                List&lt;TsiWebServiceOrderType&gt; result = apiInstance.MasterTablesGetServiceOrderTypes_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceOrderTypes_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**|  | 

### Return type

[**List<TsiWebServiceOrderType>**](TsiWebServiceOrderType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetservicezones"></a>
# **MasterTablesGetServiceZones**
> List<TsiWebServiceZone> MasterTablesGetServiceZones ()

Gets a list of the defined service zones.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetServiceZonesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the defined service zones.
                List&lt;TsiWebServiceZone&gt; result = apiInstance.MasterTablesGetServiceZones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetServiceZones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebServiceZone>**](TsiWebServiceZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetshippers"></a>
# **MasterTablesGetShippers**
> List<TsiWebShipper> MasterTablesGetShippers ()

Returns shippers stored in the master tables.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetShippersExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Returns shippers stored in the master tables.
                List&lt;TsiWebShipper&gt; result = apiInstance.MasterTablesGetShippers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetShippers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebShipper>**](TsiWebShipper.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetshippingmethods"></a>
# **MasterTablesGetShippingMethods**
> List<TsiWebShippingMethod> MasterTablesGetShippingMethods ()

Gets the shipping methods.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetShippingMethodsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the shipping methods.
                List&lt;TsiWebShippingMethod&gt; result = apiInstance.MasterTablesGetShippingMethods();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetShippingMethods: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebShippingMethod>**](TsiWebShippingMethod.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetstates"></a>
# **MasterTablesGetStates**
> List<TsiWebState> MasterTablesGetStates (bool? excludeSystemEntries = null)

Gets a list of the defined states.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetStatesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries. (optional) 

            try
            {
                // Gets a list of the defined states.
                List&lt;TsiWebState&gt; result = apiInstance.MasterTablesGetStates(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetStates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | [optional] 

### Return type

[**List<TsiWebState>**](TsiWebState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetstates_0"></a>
# **MasterTablesGetStates_0**
> List<TsiWebState> MasterTablesGetStates_0 (bool? excludeSystemEntries)

Gets a list of the defined states.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetStates_0Example
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var excludeSystemEntries = true;  // bool? | If true excludes master table system entries.

            try
            {
                // Gets a list of the defined states.
                List&lt;TsiWebState&gt; result = apiInstance.MasterTablesGetStates_0(excludeSystemEntries);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetStates_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeSystemEntries** | **bool?**| If true excludes master table system entries. | 

### Return type

[**List<TsiWebState>**](TsiWebState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetsubcontractors"></a>
# **MasterTablesGetSubContractors**
> List<TsiWebSubContractor> MasterTablesGetSubContractors ()

Gets the sub contractors.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetSubContractorsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the sub contractors.
                List&lt;TsiWebSubContractor&gt; result = apiInstance.MasterTablesGetSubContractors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetSubContractors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebSubContractor>**](TsiWebSubContractor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetsupportedsystems"></a>
# **MasterTablesGetSupportedSystems**
> List<TsiWebSupportedSystem> MasterTablesGetSupportedSystems ()

Gets the systems.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetSupportedSystemsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the systems.
                List&lt;TsiWebSupportedSystem&gt; result = apiInstance.MasterTablesGetSupportedSystems();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetSupportedSystems: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebSupportedSystem>**](TsiWebSupportedSystem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetsymptoms"></a>
# **MasterTablesGetSymptoms**
> List<TsiWebSymptom> MasterTablesGetSymptoms ()

Gets a list of the defined symptoms.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetSymptomsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the defined symptoms.
                List&lt;TsiWebSymptom&gt; result = apiInstance.MasterTablesGetSymptoms();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetSymptoms: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebSymptom>**](TsiWebSymptom.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgetsystemtypes"></a>
# **MasterTablesGetSystemTypes**
> List<TsiWebSystemType> MasterTablesGetSystemTypes ()

Gets the system types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetSystemTypesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the system types.
                List&lt;TsiWebSystemType&gt; result = apiInstance.MasterTablesGetSystemTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetSystemTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebSystemType>**](TsiWebSystemType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgettaskactionplans"></a>
# **MasterTablesGetTaskActionPlans**
> List<TsiWebTaskActionPlan> MasterTablesGetTaskActionPlans ()

Gets a list of the task action plans.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetTaskActionPlansExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the task action plans.
                List&lt;TsiWebTaskActionPlan&gt; result = apiInstance.MasterTablesGetTaskActionPlans();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetTaskActionPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebTaskActionPlan>**](TsiWebTaskActionPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgettaskactions"></a>
# **MasterTablesGetTaskActions**
> List<TsiWebTaskAction> MasterTablesGetTaskActions ()

Gets a list of the task action.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetTaskActionsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the task action.
                List&lt;TsiWebTaskAction&gt; result = apiInstance.MasterTablesGetTaskActions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetTaskActions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebTaskAction>**](TsiWebTaskAction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgettaskchecklisttemplates"></a>
# **MasterTablesGetTaskCheckListTemplates**
> List<TsiWebTaskCheckListTemplate> MasterTablesGetTaskCheckListTemplates ()

Gets a list of the task checklist tempaltes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetTaskCheckListTemplatesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the task checklist tempaltes.
                List&lt;TsiWebTaskCheckListTemplate&gt; result = apiInstance.MasterTablesGetTaskCheckListTemplates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetTaskCheckListTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebTaskCheckListTemplate>**](TsiWebTaskCheckListTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgettasklibraries"></a>
# **MasterTablesGetTaskLibraries**
> List<TsiWebTaskLibrary> MasterTablesGetTaskLibraries ()

Gets a list of the tasklibrary.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetTaskLibrariesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the tasklibrary.
                List&lt;TsiWebTaskLibrary&gt; result = apiInstance.MasterTablesGetTaskLibraries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetTaskLibraries: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebTaskLibrary>**](TsiWebTaskLibrary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgettaskresources"></a>
# **MasterTablesGetTaskResources**
> List<TsiWebTaskResource> MasterTablesGetTaskResources ()

Gets a list of the task resources.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetTaskResourcesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets a list of the task resources.
                List&lt;TsiWebTaskResource&gt; result = apiInstance.MasterTablesGetTaskResources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetTaskResources: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebTaskResource>**](TsiWebTaskResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgettimeentryreasons"></a>
# **MasterTablesGetTimeEntryReasons**
> List<TsiWebTimeEntryReason> MasterTablesGetTimeEntryReasons ()

Gets the time entry reasons.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetTimeEntryReasonsExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the time entry reasons.
                List&lt;TsiWebTimeEntryReason&gt; result = apiInstance.MasterTablesGetTimeEntryReasons();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetTimeEntryReasons: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebTimeEntryReason>**](TsiWebTimeEntryReason.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesgettitles"></a>
# **MasterTablesGetTitles**
> List<TsiWebTitle> MasterTablesGetTitles ()

Gets the titles.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesGetTitlesExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();

            try
            {
                // Gets the titles.
                List&lt;TsiWebTitle&gt; result = apiInstance.MasterTablesGetTitles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesGetTitles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TsiWebTitle>**](TsiWebTitle.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdateaccountcustomfieldcategory"></a>
# **MasterTablesUpdateAccountCustomFieldCategory**
> TsiWebCustomFieldCategoryResponse MasterTablesUpdateAccountCustomFieldCategory (TsiWebCustomFieldCategoryRequest request)

Updates the account custom field category.

To update the category name PreviousCategoryName is required and should equal the existing category name.               When updating a category name make sure to specify the AvailableInGui as true if the category should be available in the desktop.              The existing field definitions will be updated to reflect the name change.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateAccountCustomFieldCategoryExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var request = new TsiWebCustomFieldCategoryRequest(); // TsiWebCustomFieldCategoryRequest | The request.

            try
            {
                // Updates the account custom field category.
                TsiWebCustomFieldCategoryResponse result = apiInstance.MasterTablesUpdateAccountCustomFieldCategory(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateAccountCustomFieldCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebCustomFieldCategoryRequest**](TsiWebCustomFieldCategoryRequest.md)| The request. | 

### Return type

[**TsiWebCustomFieldCategoryResponse**](TsiWebCustomFieldCategoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdatecontactcustomfieldcategory"></a>
# **MasterTablesUpdateContactCustomFieldCategory**
> TsiWebCustomFieldCategoryResponse MasterTablesUpdateContactCustomFieldCategory (TsiWebCustomFieldCategoryRequest request)

Updates the contact custom field category.

To update the category name PreviousCategoryName is required and should equal the existing category name.               When updating a category name make sure to specify the AvailableInGui as true if the category should be available in the desktop.              The existing field definitions will be updated to reflect the name change.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateContactCustomFieldCategoryExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var request = new TsiWebCustomFieldCategoryRequest(); // TsiWebCustomFieldCategoryRequest | 

            try
            {
                // Updates the contact custom field category.
                TsiWebCustomFieldCategoryResponse result = apiInstance.MasterTablesUpdateContactCustomFieldCategory(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateContactCustomFieldCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebCustomFieldCategoryRequest**](TsiWebCustomFieldCategoryRequest.md)|  | 

### Return type

[**TsiWebCustomFieldCategoryResponse**](TsiWebCustomFieldCategoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdatecontractmeter"></a>
# **MasterTablesUpdateContractMeter**
> TsiWebMasterTableResponse MasterTablesUpdateContractMeter (TsiWebUpdateEntryModel model)

Updates the the ContractMeter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateContractMeterExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebUpdateEntryModel(); // TsiWebUpdateEntryModel | 

            try
            {
                // Updates the the ContractMeter.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesUpdateContractMeter(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateContractMeter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebUpdateEntryModel**](TsiWebUpdateEntryModel.md)|  | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdatecontractmetergroup"></a>
# **MasterTablesUpdateContractMeterGroup**
> TsiWebMasterTableResponse MasterTablesUpdateContractMeterGroup (TsiWebUpdateEntryModel model)

Updates the the Contract Meter group.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateContractMeterGroupExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebUpdateEntryModel(); // TsiWebUpdateEntryModel | 

            try
            {
                // Updates the the Contract Meter group.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesUpdateContractMeterGroup(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateContractMeterGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebUpdateEntryModel**](TsiWebUpdateEntryModel.md)|  | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdatecustomfielddefinition"></a>
# **MasterTablesUpdateCustomFieldDefinition**
> TsiWebCustomFieldDefinitionResponse MasterTablesUpdateCustomFieldDefinition (int? customFieldID, TsiWebCustomFieldDefinitionModel model)

Updates the custom field.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateCustomFieldDefinitionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var customFieldID = 56;  // int? | The custom field identifier.
            var model = new TsiWebCustomFieldDefinitionModel(); // TsiWebCustomFieldDefinitionModel | The custom field defintion.

            try
            {
                // Updates the custom field.
                TsiWebCustomFieldDefinitionResponse result = apiInstance.MasterTablesUpdateCustomFieldDefinition(customFieldID, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateCustomFieldDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customFieldID** | **int?**| The custom field identifier. | 
 **model** | [**TsiWebCustomFieldDefinitionModel**](TsiWebCustomFieldDefinitionModel.md)| The custom field defintion. | 

### Return type

[**TsiWebCustomFieldDefinitionResponse**](TsiWebCustomFieldDefinitionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdateexpensepaymenttype"></a>
# **MasterTablesUpdateExpensePaymentType**
> TsiWebExpensePaymentTypesResponse MasterTablesUpdateExpensePaymentType (TsiWebUpdateExpensePaymentTypeRequest request)

Updates an expense payment type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateExpensePaymentTypeExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var request = new TsiWebUpdateExpensePaymentTypeRequest(); // TsiWebUpdateExpensePaymentTypeRequest | 

            try
            {
                // Updates an expense payment type.
                TsiWebExpensePaymentTypesResponse result = apiInstance.MasterTablesUpdateExpensePaymentType(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateExpensePaymentType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebUpdateExpensePaymentTypeRequest**](TsiWebUpdateExpensePaymentTypeRequest.md)|  | 

### Return type

[**TsiWebExpensePaymentTypesResponse**](TsiWebExpensePaymentTypesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdateexpensetype"></a>
# **MasterTablesUpdateExpenseType**
> TsiWebExpenseTypesResponse MasterTablesUpdateExpenseType (TsiWebUpdateExpenseTypeRequest request)

Updates an expense type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateExpenseTypeExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var request = new TsiWebUpdateExpenseTypeRequest(); // TsiWebUpdateExpenseTypeRequest | 

            try
            {
                // Updates an expense type.
                TsiWebExpenseTypesResponse result = apiInstance.MasterTablesUpdateExpenseType(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateExpenseType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebUpdateExpenseTypeRequest**](TsiWebUpdateExpenseTypeRequest.md)|  | 

### Return type

[**TsiWebExpenseTypesResponse**](TsiWebExpenseTypesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdatejournalaction"></a>
# **MasterTablesUpdateJournalAction**
> TsiWebJournalActionsResponse MasterTablesUpdateJournalAction (TsiWebUpdateJournalActionRequest request)

Updates the journal action.

ExistingAction is required and is used identify the Journal Action to update.  Action is the value to change the existing Journal Action to.   If Action is excluded from the PUT the Journal Action value will not change.  If Weight is excluded from the PUT it will be defaulted to 0 overwriting the existing value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateJournalActionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var request = new TsiWebUpdateJournalActionRequest(); // TsiWebUpdateJournalActionRequest | A request used to update the existing journal action.

            try
            {
                // Updates the journal action.
                TsiWebJournalActionsResponse result = apiInstance.MasterTablesUpdateJournalAction(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateJournalAction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebUpdateJournalActionRequest**](TsiWebUpdateJournalActionRequest.md)| A request used to update the existing journal action. | 

### Return type

[**TsiWebJournalActionsResponse**](TsiWebJournalActionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdatejournaltopic"></a>
# **MasterTablesUpdateJournalTopic**
> TsiWebMasterTableResponse MasterTablesUpdateJournalTopic (TsiWebUpdateEntryModel model)

Updates the journal topic.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateJournalTopicExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebUpdateEntryModel(); // TsiWebUpdateEntryModel | 

            try
            {
                // Updates the journal topic.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesUpdateJournalTopic(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateJournalTopic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebUpdateEntryModel**](TsiWebUpdateEntryModel.md)|  | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdateopportunitycustomfieldcategory"></a>
# **MasterTablesUpdateOpportunityCustomFieldCategory**
> TsiWebCustomFieldCategoryResponse MasterTablesUpdateOpportunityCustomFieldCategory (TsiWebCustomFieldCategoryRequest request)

Updates the opportunity custom field category.

To update the category name PreviousCategoryName is required and should equal the existing category name.               When updating a category name make sure to specify the AvailableInGui as true if the category should be available in the desktop.              The existing field definitions will be updated to reflect the name change.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateOpportunityCustomFieldCategoryExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var request = new TsiWebCustomFieldCategoryRequest(); // TsiWebCustomFieldCategoryRequest | The request.

            try
            {
                // Updates the opportunity custom field category.
                TsiWebCustomFieldCategoryResponse result = apiInstance.MasterTablesUpdateOpportunityCustomFieldCategory(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateOpportunityCustomFieldCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebCustomFieldCategoryRequest**](TsiWebCustomFieldCategoryRequest.md)| The request. | 

### Return type

[**TsiWebCustomFieldCategoryResponse**](TsiWebCustomFieldCategoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdateresolution"></a>
# **MasterTablesUpdateResolution**
> TsiWebMasterTableResponse MasterTablesUpdateResolution (TsiWebUpdateEntryModel model)

Updates the the Resolution.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateResolutionExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebUpdateEntryModel(); // TsiWebUpdateEntryModel | 

            try
            {
                // Updates the the Resolution.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesUpdateResolution(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateResolution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebUpdateEntryModel**](TsiWebUpdateEntryModel.md)|  | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdateserviceorderprofile"></a>
# **MasterTablesUpdateServiceOrderProfile**
> TsiWebMasterTableResponse MasterTablesUpdateServiceOrderProfile (TsiWebUpdateEntryModel model)

Updates the the Service Order Profile.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateServiceOrderProfileExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebUpdateEntryModel(); // TsiWebUpdateEntryModel | 

            try
            {
                // Updates the the Service Order Profile.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesUpdateServiceOrderProfile(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateServiceOrderProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebUpdateEntryModel**](TsiWebUpdateEntryModel.md)|  | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdatesymptom"></a>
# **MasterTablesUpdateSymptom**
> TsiWebMasterTableResponse MasterTablesUpdateSymptom (TsiWebUpdateEntryModel model)

Updates the the Symptom.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateSymptomExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var model = new TsiWebUpdateEntryModel(); // TsiWebUpdateEntryModel | 

            try
            {
                // Updates the the Symptom.
                TsiWebMasterTableResponse result = apiInstance.MasterTablesUpdateSymptom(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateSymptom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebUpdateEntryModel**](TsiWebUpdateEntryModel.md)|  | 

### Return type

[**TsiWebMasterTableResponse**](TsiWebMasterTableResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mastertablesupdatetimeentryreason"></a>
# **MasterTablesUpdateTimeEntryReason**
> TsiWebTimeEntryReasonResponse MasterTablesUpdateTimeEntryReason (TsiWebUpdateTimeEntryReasonRequest reason)

Updates a master table time entry reason.  <remarks><p>         The AppliedTo Type field accepts values \"TimeLogs\", \"TimeSlips\", or \"Both\". All the values are case sensitive.         The BillingOption Type field accepts value \"ApplyToContract\", \"ApplyToContractAndBillcustomer\", \"DoNotInvoice\",\"InvoiceCustomer\", \"Business\", \"Personal\"      </p><p>         Value for RGBColor field in the request should be an RGB value of type integer. For example RGB value for white is (256*256*256*) = 16777215      </p><p>        Valid values for rate basis field are \"Regular\", \"Overtime\", \"Premium\" and \"Flat Fee\"      </p></remarks>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MasterTablesUpdateTimeEntryReasonExample
    {
        public void main()
        {
            var apiInstance = new MasterTablesApi();
            var reason = new TsiWebUpdateTimeEntryReasonRequest(); // TsiWebUpdateTimeEntryReasonRequest | 

            try
            {
                // Updates a master table time entry reason.  <remarks><p>         The AppliedTo Type field accepts values \"TimeLogs\", \"TimeSlips\", or \"Both\". All the values are case sensitive.         The BillingOption Type field accepts value \"ApplyToContract\", \"ApplyToContractAndBillcustomer\", \"DoNotInvoice\",\"InvoiceCustomer\", \"Business\", \"Personal\"      </p><p>         Value for RGBColor field in the request should be an RGB value of type integer. For example RGB value for white is (256*256*256*) = 16777215      </p><p>        Valid values for rate basis field are \"Regular\", \"Overtime\", \"Premium\" and \"Flat Fee\"      </p></remarks>
                TsiWebTimeEntryReasonResponse result = apiInstance.MasterTablesUpdateTimeEntryReason(reason);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MasterTablesApi.MasterTablesUpdateTimeEntryReason: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reason** | [**TsiWebUpdateTimeEntryReasonRequest**](TsiWebUpdateTimeEntryReasonRequest.md)|  | 

### Return type

[**TsiWebTimeEntryReasonResponse**](TsiWebTimeEntryReasonResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

