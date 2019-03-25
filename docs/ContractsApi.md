# IO.Swagger.Api.ContractsApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ContractsAdvancedSearch**](ContractsApi.md#contractsadvancedsearch) | **POST** /api/contracts/search | Advanced search for Contract.
[**ContractsCreateContract**](ContractsApi.md#contractscreatecontract) | **POST** /api/contracts | Creates a new contract.
[**ContractsCreateContractAccount**](ContractsApi.md#contractscreatecontractaccount) | **POST** /api/contracts/{contractNumber}/accounts/{accountNumber} | Creates a contract account
[**ContractsCreateContractDocument**](ContractsApi.md#contractscreatecontractdocument) | **POST** /api/contracts/{contractNumber}/documents | Creates the contract document.
[**ContractsCreateContractLineItem**](ContractsApi.md#contractscreatecontractlineitem) | **POST** /api/contracts/{contractNumber}/accounts/{accountNumber}/itemscovered | Creates a contract line item detail
[**ContractsDeleteContractAccount**](ContractsApi.md#contractsdeletecontractaccount) | **DELETE** /api/contracts/{contractNumber}/accounts/{accountNumber} | Deletes a contract account
[**ContractsDeleteContractLineItem**](ContractsApi.md#contractsdeletecontractlineitem) | **DELETE** /api/contracts/{contractNumber}/itemscovered/{contractDetailNumber} | Deletes a contract line item
[**ContractsGetContractAccounts**](ContractsApi.md#contractsgetcontractaccounts) | **GET** /api/contracts/{contractNumber}/accounts | Gets the contract accounts
[**ContractsGetContractDetails**](ContractsApi.md#contractsgetcontractdetails) | **GET** /api/contracts/{contractNumber}/details | Gets the contract detail.
[**ContractsGetContractDocument**](ContractsApi.md#contractsgetcontractdocument) | **GET** /api/contracts/{contractNumber}/documents/{documentID} | Gets the contract document with the file bytes.
[**ContractsGetContractDocuments**](ContractsApi.md#contractsgetcontractdocuments) | **GET** /api/contracts/{contractNumber}/documents | Gets the contract documents
[**ContractsGetContractItemsCovered**](ContractsApi.md#contractsgetcontractitemscovered) | **GET** /api/contracts/{contractNumber}/itemscovered | Gets the contract items covered.
[**ContractsGetContractItemsCoveredByAccountNumber**](ContractsApi.md#contractsgetcontractitemscoveredbyaccountnumber) | **GET** /api/contracts/{contractNumber}/accounts/{accountNumber}/itemscovered | Gets the contract items covered by account number
[**ContractsGetContractMeterGroupById**](ContractsApi.md#contractsgetcontractmetergroupbyid) | **GET** /api/contracts/{contractNumber}/metergroups/{meterGroupId} | Gets the contract meters groups by meter group ID.
[**ContractsGetContractMeterGroups**](ContractsApi.md#contractsgetcontractmetergroups) | **GET** /api/contracts/{contractNumber}/metergroups | Gets the contract meters groups.
[**ContractsGetContractMeters**](ContractsApi.md#contractsgetcontractmeters) | **GET** /api/contracts/{contractNumber}/itemscovered/{detailId}/meters | Gets the contract meters for the contract detail line item.
[**ContractsGetContractPartsAndLabor**](ContractsApi.md#contractsgetcontractpartsandlabor) | **GET** /api/contracts/{contractNumber}/partsandlabor | Gets the contract parts and labor.
[**ContractsGetContractPartsAndLaborByAccountNumber**](ContractsApi.md#contractsgetcontractpartsandlaborbyaccountnumber) | **GET** /api/contracts/{contractNumber}/accounts/{accountNumber}/partsandlabor | Gets the contract parts and labor by account number
[**ContractsGetContractServiceOrderHistory**](ContractsApi.md#contractsgetcontractserviceorderhistory) | **GET** /api/contracts/{contractNumber}/serviceorders | Gets the contract service order history
[**ContractsGetContractServiceOrderHistoryByAccountNumber**](ContractsApi.md#contractsgetcontractserviceorderhistorybyaccountnumber) | **GET** /api/contracts/{contractNumber}/accounts/{accountNumber}/serviceorders | Gets the contract service order history by account number
[**ContractsGetContractSummary**](ContractsApi.md#contractsgetcontractsummary) | **GET** /api/contracts/{contractNumber} | Gets the contract summary.
[**ContractsGetContractTimeLogs**](ContractsApi.md#contractsgetcontracttimelogs) | **GET** /api/contracts/{contractNumber}/timelogs | Gets the contract time log.
[**ContractsGetContractTimeLogsByAccountNumber**](ContractsApi.md#contractsgetcontracttimelogsbyaccountnumber) | **GET** /api/contracts/{contractNumber}/accounts/{accountNumber}/timelogs | Gets the contract time log by account number
[**ContractsGetCustomFields**](ContractsApi.md#contractsgetcustomfields) | **GET** /api/contracts/{contractNumber}/customfields | Gets the custom fields for a contract.
[**ContractsGetFile**](ContractsApi.md#contractsgetfile) | **GET** /api/contracts/{contractNumber}/documents/{documentID}/file | Gets the contract document file.
[**ContractsSearchByAccountNumber**](ContractsApi.md#contractssearchbyaccountnumber) | **POST** /api/contracts/search/accountnumber | Search Contract by Account Number .
[**ContractsSearchByAgreementNumber**](ContractsApi.md#contractssearchbyagreementnumber) | **POST** /api/contracts/search/agreementnumber | Search Contract by Agreement Number .
[**ContractsSearchByBasis**](ContractsApi.md#contractssearchbybasis) | **POST** /api/contracts/search/basis | Search Contract by Basis .
[**ContractsSearchByContractNumber**](ContractsApi.md#contractssearchbycontractnumber) | **POST** /api/contracts/search/contractnumber | Search Contract by Contract number.
[**ContractsSearchByContractType**](ContractsApi.md#contractssearchbycontracttype) | **POST** /api/contracts/search/contracttype | Search Contract by Contract type.
[**ContractsSearchByCustomField**](ContractsApi.md#contractssearchbycustomfield) | **POST** /api/contracts/search/customfield | Search Contract by Custom field .
[**ContractsSearchByEndDate**](ContractsApi.md#contractssearchbyenddate) | **POST** /api/contracts/search/enddate | Search Contract by End Date .
[**ContractsSearchByReference**](ContractsApi.md#contractssearchbyreference) | **POST** /api/contracts/search/reference | Search Contract by Reference .
[**ContractsSearchByStartDate**](ContractsApi.md#contractssearchbystartdate) | **POST** /api/contracts/search/startdate | Search Contract by Start Date .
[**ContractsSearchByStatus**](ContractsApi.md#contractssearchbystatus) | **POST** /api/contracts/search/status | Search Contract by Status .
[**ContractsSetContractDocumentFile**](ContractsApi.md#contractssetcontractdocumentfile) | **PUT** /api/contracts/{contractNumber}/documents/{documentID}/overwrite | Overwrites the contract document physical file, does not rename the file.
[**ContractsSetContractDocumentFileName**](ContractsApi.md#contractssetcontractdocumentfilename) | **PUT** /api/contracts/{contractNumber}/documents/{documentID}/rename | Sets the documents file name and renames the associated file.
[**ContractsUpdateContract**](ContractsApi.md#contractsupdatecontract) | **PUT** /api/contracts/{contractNumber} | Updates a contract.
[**ContractsUpdateContractDocumentProperties**](ContractsApi.md#contractsupdatecontractdocumentproperties) | **PUT** /api/contracts/{contractNumber}/documents/{documentID} | Updates the contract document information. Does not allow the file name property to be changed.
[**ContractsUpdateContractLineItem**](ContractsApi.md#contractsupdatecontractlineitem) | **PUT** /api/contracts/{contractNumber}/itemscovered/{contractDetailNumber} | Updates a contract line item detail
[**ContractsUpdateCustomFields**](ContractsApi.md#contractsupdatecustomfields) | **PUT** /api/contracts/{contractNumber}/customfields | Updates the custom fields for a contract.
[**ContractsUpdateMeterReadings**](ContractsApi.md#contractsupdatemeterreadings) | **PUT** /api/contracts/meters/readings | Update a contract meter for a DeviceID
[**ContractsUpdateMeterReadings_0**](ContractsApi.md#contractsupdatemeterreadings_0) | **POST** /api/contracts/meters/readings | Update a contract meter for a DeviceID


<a name="contractsadvancedsearch"></a>
# **ContractsAdvancedSearch**
> TsiWebSearchContractResponse ContractsAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for Contract.

Valid SearchType = ContractNumber, ContractType, Reference, StartDate, EndDate, AccountNumber, Status, Basis, AgreementNumber, CustomField (requires CategoryName and CustomFieldName)  <p>Valid MatchType = StartsWith (default), EndsWith, Contains, GreaterThan, GreaterThanEqual, Equal, LessThan, LessThanEqual</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for Contract.
                TsiWebSearchContractResponse result = apiInstance.ContractsAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsAdvancedSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebAdvancedSearchRequest**](TsiWebAdvancedSearchRequest.md)| An AdvancedSearchRequest | 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractscreatecontract"></a>
# **ContractsCreateContract**
> TsiWebContractResponse ContractsCreateContract (TsiWebCreateContractModel model)

Creates a new contract.

BillingCycle : \"DoNotBill\", \"Weekly\", \"Monthly\",\"Quarterly\", \"SemiAnnually\", \"Annually\", \"InFull\".<br /><p>If the billing cycle DoNotBill is specified any requested value for the BillTo address will be ignored. The primary billing address for the account or the account address will be used instead.</p><br /><br /><p>  BillingStyle : \"TotalOnly\", \"ShowLineItems\".  </p><p>  PricingMethod : \"Fixed\", \"Calculated\".  </p><p>  BasisType : \"Hourly\", \"Incidents\", \"Prepaid\", \"HourlyUsage\", \"TimePeriod\", \"Units\".  </p><p>  LaborBillingType : \"FixedHourlyRate\", \"Discount\".  </p><p>  BillingOption : \"InvoiceCustomer\", \"ApplyToContract\", \"ApplyToContractAndBillcustomer\", \"DoNotInvoice\".  </p><p>  PeriodUsageCycle : \"ContractTerm\", \"Month\", \"Quarter\", \"SemiAnnual\", \"Annual\".  </p><p>  RoundingFactor : \"DoNotRound\", \"FifteenMinutes\", \"HalfHour\".  </p><p>  BillingAddress : \"AccountDefaultAddress\", \"PrimaryAddress\", \"AlternateAddress\",\"ManualEntry\".  </p><p>  AllowContractWithNoPrice : If true allows the contract to be created with a price of $0.00.  </p><p>  UseAsDefaultAccountContract : If true sets the new contract as the default for the bill to account and any accounts included in CustomersOnContract.  </p><p>  CustomersOnContract : An array of account numbers to include on the contract.  </p><p>  Basis - The following properties are read only HourrRemaining, MinutesRemaining, AmountRemaining, UnitsRemaining, UnitsUsed, PeriodClicksUsed, ToDateTotalHours, ToDateTotalDollars, CurrentDollars and OverUnderIndicator  </p><p>  Valid properties for each basis type  </p><p>  Units and Incidents: MaxUnits, ChargePerUnit and WarningPercent.  </p><p>  Prepaid: PrePaidAmount and WarningPercent.  </p><p>  Metered: MaxMeter, OverageChargePerClick, CurrentMeter, StartingMeter and WarningClicks.  </p><p>  Hourly usage: PeriodBaseHours, PeriodUsageCycle and RoundingFactor.  </p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsCreateContractExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var model = new TsiWebCreateContractModel(); // TsiWebCreateContractModel | The model.

            try
            {
                // Creates a new contract.
                TsiWebContractResponse result = apiInstance.ContractsCreateContract(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsCreateContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCreateContractModel**](TsiWebCreateContractModel.md)| The model. | 

### Return type

[**TsiWebContractResponse**](TsiWebContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractscreatecontractaccount"></a>
# **ContractsCreateContractAccount**
> TsiWebContractResponse ContractsCreateContractAccount (int? contractNumber, int? accountNumber)

Creates a contract account

Metered, Metered Usage and Multiple Meter contracts are not currently supported.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsCreateContractAccountExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.
            var accountNumber = 56;  // int? | The account identifier number.

            try
            {
                // Creates a contract account
                TsiWebContractResponse result = apiInstance.ContractsCreateContractAccount(contractNumber, accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsCreateContractAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 
 **accountNumber** | **int?**| The account identifier number. | 

### Return type

[**TsiWebContractResponse**](TsiWebContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractscreatecontractdocument"></a>
# **ContractsCreateContractDocument**
> TsiWebDocumentResponse ContractsCreateContractDocument (int? contractNumber)

Creates the contract document.

Requires a multipart/form request containing the physical file and the xml / json Document

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsCreateContractDocumentExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract number.

            try
            {
                // Creates the contract document.
                TsiWebDocumentResponse result = apiInstance.ContractsCreateContractDocument(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsCreateContractDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract number. | 

### Return type

[**TsiWebDocumentResponse**](TsiWebDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractscreatecontractlineitem"></a>
# **ContractsCreateContractLineItem**
> TsiWebContractDetailResponse ContractsCreateContractLineItem (int? contractNumber, int? accountNumber, TsiWebCreateContractLineItemModel model)

Creates a contract line item detail

ContractItemType: Manual, CustomerAsset, PriceBookItem. Default value is Manual, if no values is passed in.  When adding a Price Book item to the contract you must specify either the PriceBookNumber or the ItemID. If you use the PriceBookNumber you may specify an override for the ItemID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsCreateContractLineItemExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.
            var accountNumber = 56;  // int? | The account identifier number.
            var model = new TsiWebCreateContractLineItemModel(); // TsiWebCreateContractLineItemModel | CreateContractLineItemModel.

            try
            {
                // Creates a contract line item detail
                TsiWebContractDetailResponse result = apiInstance.ContractsCreateContractLineItem(contractNumber, accountNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsCreateContractLineItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 
 **accountNumber** | **int?**| The account identifier number. | 
 **model** | [**TsiWebCreateContractLineItemModel**](TsiWebCreateContractLineItemModel.md)| CreateContractLineItemModel. | 

### Return type

[**TsiWebContractDetailResponse**](TsiWebContractDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsdeletecontractaccount"></a>
# **ContractsDeleteContractAccount**
> TsiWebResponse ContractsDeleteContractAccount (int? contractNumber, int? accountNumber, bool? allowDeleteIfInvoiced = null)

Deletes a contract account

If allowDeleteIfInvoiced is set to true, the contract account(if it's not the 'bill-to' account) will be deleted even if the contract is billed.          The default value is false, if no value is sent with the request.  Metered, Metered Usage and Multiple Meter contracts are not currently supported.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsDeleteContractAccountExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | 
            var accountNumber = 56;  // int? | 
            var allowDeleteIfInvoiced = true;  // bool? |  (optional) 

            try
            {
                // Deletes a contract account
                TsiWebResponse result = apiInstance.ContractsDeleteContractAccount(contractNumber, accountNumber, allowDeleteIfInvoiced);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsDeleteContractAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**|  | 
 **accountNumber** | **int?**|  | 
 **allowDeleteIfInvoiced** | **bool?**|  | [optional] 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsdeletecontractlineitem"></a>
# **ContractsDeleteContractLineItem**
> TsiWebContractDetailResponse ContractsDeleteContractLineItem (int? contractNumber, int? contractDetailNumber)

Deletes a contract line item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsDeleteContractLineItemExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | 
            var contractDetailNumber = 56;  // int? | 

            try
            {
                // Deletes a contract line item
                TsiWebContractDetailResponse result = apiInstance.ContractsDeleteContractLineItem(contractNumber, contractDetailNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsDeleteContractLineItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**|  | 
 **contractDetailNumber** | **int?**|  | 

### Return type

[**TsiWebContractDetailResponse**](TsiWebContractDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractaccounts"></a>
# **ContractsGetContractAccounts**
> List<TsiWebContractAccount> ContractsGetContractAccounts (int? contractNumber)

Gets the contract accounts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractAccountsExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.

            try
            {
                // Gets the contract accounts
                List&lt;TsiWebContractAccount&gt; result = apiInstance.ContractsGetContractAccounts(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 

### Return type

[**List<TsiWebContractAccount>**](TsiWebContractAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractdetails"></a>
# **ContractsGetContractDetails**
> TsiWebContractDetail ContractsGetContractDetails (int? contractNumber)

Gets the contract detail.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractDetailsExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.

            try
            {
                // Gets the contract detail.
                TsiWebContractDetail result = apiInstance.ContractsGetContractDetails(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 

### Return type

[**TsiWebContractDetail**](TsiWebContractDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractdocument"></a>
# **ContractsGetContractDocument**
> TsiWebDocumentSummary ContractsGetContractDocument (int? contractNumber, int? documentID)

Gets the contract document with the file bytes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractDocumentExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Gets the contract document with the file bytes.
                TsiWebDocumentSummary result = apiInstance.ContractsGetContractDocument(contractNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

[**TsiWebDocumentSummary**](TsiWebDocumentSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractdocuments"></a>
# **ContractsGetContractDocuments**
> List<TsiWebDocumentSummary> ContractsGetContractDocuments (int? contractNumber)

Gets the contract documents

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractDocumentsExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.

            try
            {
                // Gets the contract documents
                List&lt;TsiWebDocumentSummary&gt; result = apiInstance.ContractsGetContractDocuments(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 

### Return type

[**List<TsiWebDocumentSummary>**](TsiWebDocumentSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractitemscovered"></a>
# **ContractsGetContractItemsCovered**
> List<TsiWebItemCovered> ContractsGetContractItemsCovered (int? contractNumber)

Gets the contract items covered.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractItemsCoveredExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.

            try
            {
                // Gets the contract items covered.
                List&lt;TsiWebItemCovered&gt; result = apiInstance.ContractsGetContractItemsCovered(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractItemsCovered: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 

### Return type

[**List<TsiWebItemCovered>**](TsiWebItemCovered.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractitemscoveredbyaccountnumber"></a>
# **ContractsGetContractItemsCoveredByAccountNumber**
> List<TsiWebItemCovered> ContractsGetContractItemsCoveredByAccountNumber (int? contractNumber, int? accountNumber)

Gets the contract items covered by account number

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractItemsCoveredByAccountNumberExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.
            var accountNumber = 56;  // int? | The account identifier number.

            try
            {
                // Gets the contract items covered by account number
                List&lt;TsiWebItemCovered&gt; result = apiInstance.ContractsGetContractItemsCoveredByAccountNumber(contractNumber, accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractItemsCoveredByAccountNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 
 **accountNumber** | **int?**| The account identifier number. | 

### Return type

[**List<TsiWebItemCovered>**](TsiWebItemCovered.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractmetergroupbyid"></a>
# **ContractsGetContractMeterGroupById**
> TsiWebContractMeterGroup ContractsGetContractMeterGroupById (int? contractNumber, int? meterGroupId)

Gets the contract meters groups by meter group ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractMeterGroupByIdExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.
            var meterGroupId = 56;  // int? | The contract meter group identifier.

            try
            {
                // Gets the contract meters groups by meter group ID.
                TsiWebContractMeterGroup result = apiInstance.ContractsGetContractMeterGroupById(contractNumber, meterGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractMeterGroupById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 
 **meterGroupId** | **int?**| The contract meter group identifier. | 

### Return type

[**TsiWebContractMeterGroup**](TsiWebContractMeterGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractmetergroups"></a>
# **ContractsGetContractMeterGroups**
> List<TsiWebContractMeterGroup> ContractsGetContractMeterGroups (int? contractNumber)

Gets the contract meters groups.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractMeterGroupsExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.

            try
            {
                // Gets the contract meters groups.
                List&lt;TsiWebContractMeterGroup&gt; result = apiInstance.ContractsGetContractMeterGroups(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractMeterGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 

### Return type

[**List<TsiWebContractMeterGroup>**](TsiWebContractMeterGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractmeters"></a>
# **ContractsGetContractMeters**
> List<TsiWebContractMeter> ContractsGetContractMeters (int? contractNumber, int? detailId)

Gets the contract meters for the contract detail line item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractMetersExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.
            var detailId = 56;  // int? | The contract identifier number.

            try
            {
                // Gets the contract meters for the contract detail line item.
                List&lt;TsiWebContractMeter&gt; result = apiInstance.ContractsGetContractMeters(contractNumber, detailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractMeters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 
 **detailId** | **int?**| The contract identifier number. | 

### Return type

[**List<TsiWebContractMeter>**](TsiWebContractMeter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractpartsandlabor"></a>
# **ContractsGetContractPartsAndLabor**
> List<TsiWebPartAndLabor> ContractsGetContractPartsAndLabor (int? contractNumber)

Gets the contract parts and labor.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractPartsAndLaborExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.

            try
            {
                // Gets the contract parts and labor.
                List&lt;TsiWebPartAndLabor&gt; result = apiInstance.ContractsGetContractPartsAndLabor(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractPartsAndLabor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 

### Return type

[**List<TsiWebPartAndLabor>**](TsiWebPartAndLabor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractpartsandlaborbyaccountnumber"></a>
# **ContractsGetContractPartsAndLaborByAccountNumber**
> List<TsiWebPartAndLabor> ContractsGetContractPartsAndLaborByAccountNumber (int? contractNumber, int? accountNumber)

Gets the contract parts and labor by account number

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractPartsAndLaborByAccountNumberExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.
            var accountNumber = 56;  // int? | The account identifier number.

            try
            {
                // Gets the contract parts and labor by account number
                List&lt;TsiWebPartAndLabor&gt; result = apiInstance.ContractsGetContractPartsAndLaborByAccountNumber(contractNumber, accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractPartsAndLaborByAccountNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 
 **accountNumber** | **int?**| The account identifier number. | 

### Return type

[**List<TsiWebPartAndLabor>**](TsiWebPartAndLabor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractserviceorderhistory"></a>
# **ContractsGetContractServiceOrderHistory**
> List<TsiWebContractServiceOrder> ContractsGetContractServiceOrderHistory (int? contractNumber)

Gets the contract service order history

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractServiceOrderHistoryExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.

            try
            {
                // Gets the contract service order history
                List&lt;TsiWebContractServiceOrder&gt; result = apiInstance.ContractsGetContractServiceOrderHistory(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractServiceOrderHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 

### Return type

[**List<TsiWebContractServiceOrder>**](TsiWebContractServiceOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractserviceorderhistorybyaccountnumber"></a>
# **ContractsGetContractServiceOrderHistoryByAccountNumber**
> List<TsiWebServiceOrderSummary> ContractsGetContractServiceOrderHistoryByAccountNumber (int? contractNumber, int? accountNumber)

Gets the contract service order history by account number

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractServiceOrderHistoryByAccountNumberExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.
            var accountNumber = 56;  // int? | The account identifier number.

            try
            {
                // Gets the contract service order history by account number
                List&lt;TsiWebServiceOrderSummary&gt; result = apiInstance.ContractsGetContractServiceOrderHistoryByAccountNumber(contractNumber, accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractServiceOrderHistoryByAccountNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 
 **accountNumber** | **int?**| The account identifier number. | 

### Return type

[**List<TsiWebServiceOrderSummary>**](TsiWebServiceOrderSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontractsummary"></a>
# **ContractsGetContractSummary**
> TsiWebContractSummary ContractsGetContractSummary (int? contractNumber)

Gets the contract summary.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractSummaryExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.

            try
            {
                // Gets the contract summary.
                TsiWebContractSummary result = apiInstance.ContractsGetContractSummary(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 

### Return type

[**TsiWebContractSummary**](TsiWebContractSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontracttimelogs"></a>
# **ContractsGetContractTimeLogs**
> List<TsiWebTimeLog> ContractsGetContractTimeLogs (int? contractNumber)

Gets the contract time log.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractTimeLogsExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.

            try
            {
                // Gets the contract time log.
                List&lt;TsiWebTimeLog&gt; result = apiInstance.ContractsGetContractTimeLogs(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractTimeLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 

### Return type

[**List<TsiWebTimeLog>**](TsiWebTimeLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcontracttimelogsbyaccountnumber"></a>
# **ContractsGetContractTimeLogsByAccountNumber**
> List<TsiWebTimeLog> ContractsGetContractTimeLogsByAccountNumber (int? contractNumber, int? accountNumber)

Gets the contract time log by account number

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetContractTimeLogsByAccountNumberExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.
            var accountNumber = 56;  // int? | The account identifier number.

            try
            {
                // Gets the contract time log by account number
                List&lt;TsiWebTimeLog&gt; result = apiInstance.ContractsGetContractTimeLogsByAccountNumber(contractNumber, accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetContractTimeLogsByAccountNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 
 **accountNumber** | **int?**| The account identifier number. | 

### Return type

[**List<TsiWebTimeLog>**](TsiWebTimeLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetcustomfields"></a>
# **ContractsGetCustomFields**
> List<TsiWebCustomField> ContractsGetCustomFields (int? contractNumber)

Gets the custom fields for a contract.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract number.

            try
            {
                // Gets the custom fields for a contract.
                List&lt;TsiWebCustomField&gt; result = apiInstance.ContractsGetCustomFields(contractNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract number. | 

### Return type

[**List<TsiWebCustomField>**](TsiWebCustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsgetfile"></a>
# **ContractsGetFile**
> Object ContractsGetFile (int? contractNumber, int? documentID)

Gets the contract document file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsGetFileExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Gets the contract document file.
                Object result = apiInstance.ContractsGetFile(contractNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsGetFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssearchbyaccountnumber"></a>
# **ContractsSearchByAccountNumber**
> TsiWebSearchContractResponse ContractsSearchByAccountNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Contract by Account Number .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSearchByAccountNumberExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Contract by Account Number .
                TsiWebSearchContractResponse result = apiInstance.ContractsSearchByAccountNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSearchByAccountNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssearchbyagreementnumber"></a>
# **ContractsSearchByAgreementNumber**
> TsiWebSearchContractResponse ContractsSearchByAgreementNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Contract by Agreement Number .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSearchByAgreementNumberExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Contract by Agreement Number .
                TsiWebSearchContractResponse result = apiInstance.ContractsSearchByAgreementNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSearchByAgreementNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssearchbybasis"></a>
# **ContractsSearchByBasis**
> TsiWebSearchContractResponse ContractsSearchByBasis (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Contract by Basis .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSearchByBasisExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Contract by Basis .
                TsiWebSearchContractResponse result = apiInstance.ContractsSearchByBasis(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSearchByBasis: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssearchbycontractnumber"></a>
# **ContractsSearchByContractNumber**
> TsiWebSearchContractResponse ContractsSearchByContractNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Contract by Contract number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSearchByContractNumberExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Contract by Contract number.
                TsiWebSearchContractResponse result = apiInstance.ContractsSearchByContractNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSearchByContractNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssearchbycontracttype"></a>
# **ContractsSearchByContractType**
> TsiWebSearchContractResponse ContractsSearchByContractType (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Contract by Contract type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSearchByContractTypeExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Contract by Contract type.
                TsiWebSearchContractResponse result = apiInstance.ContractsSearchByContractType(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSearchByContractType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssearchbycustomfield"></a>
# **ContractsSearchByCustomField**
> TsiWebSearchContractResponse ContractsSearchByCustomField (TsiWebCustomFieldSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Contract by Custom field .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSearchByCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var model = new TsiWebCustomFieldSearchModel(); // TsiWebCustomFieldSearchModel | A {Tsi.Web.CustomFieldSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Contract by Custom field .
                TsiWebSearchContractResponse result = apiInstance.ContractsSearchByCustomField(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSearchByCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCustomFieldSearchModel**](TsiWebCustomFieldSearchModel.md)| A {Tsi.Web.CustomFieldSearchModel} | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssearchbyenddate"></a>
# **ContractsSearchByEndDate**
> TsiWebSearchContractResponse ContractsSearchByEndDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Contract by End Date .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSearchByEndDateExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | A {Tsi.Web.DateTimeSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Contract by End Date .
                TsiWebSearchContractResponse result = apiInstance.ContractsSearchByEndDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSearchByEndDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebDateTimeSearchModel**](TsiWebDateTimeSearchModel.md)| A {Tsi.Web.DateTimeSearchModel} | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssearchbyreference"></a>
# **ContractsSearchByReference**
> TsiWebSearchContractResponse ContractsSearchByReference (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Contract by Reference .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSearchByReferenceExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Contract by Reference .
                TsiWebSearchContractResponse result = apiInstance.ContractsSearchByReference(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSearchByReference: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssearchbystartdate"></a>
# **ContractsSearchByStartDate**
> TsiWebSearchContractResponse ContractsSearchByStartDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Contract by Start Date .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSearchByStartDateExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | A {Tsi.Web.DateTimeSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Contract by Start Date .
                TsiWebSearchContractResponse result = apiInstance.ContractsSearchByStartDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSearchByStartDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebDateTimeSearchModel**](TsiWebDateTimeSearchModel.md)| A {Tsi.Web.DateTimeSearchModel} | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssearchbystatus"></a>
# **ContractsSearchByStatus**
> TsiWebSearchContractResponse ContractsSearchByStatus (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Contract by Status .

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSearchByStatusExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Contract by Status .
                TsiWebSearchContractResponse result = apiInstance.ContractsSearchByStatus(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSearchByStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchContractResponse**](TsiWebSearchContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssetcontractdocumentfile"></a>
# **ContractsSetContractDocumentFile**
> TsiWebResponse ContractsSetContractDocumentFile (int? contractNumber, int? documentID)

Overwrites the contract document physical file, does not rename the file.

Requires a multipart/form request containing the physical file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSetContractDocumentFileExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Overwrites the contract document physical file, does not rename the file.
                TsiWebResponse result = apiInstance.ContractsSetContractDocumentFile(contractNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSetContractDocumentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractssetcontractdocumentfilename"></a>
# **ContractsSetContractDocumentFileName**
> TsiWebDocumentResponse ContractsSetContractDocumentFileName (int? contractNumber, int? documentID, string fileName)

Sets the documents file name and renames the associated file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsSetContractDocumentFileNameExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract number.
            var documentID = 56;  // int? | The document identifier.
            var fileName = fileName_example;  // string | Name of the file.

            try
            {
                // Sets the documents file name and renames the associated file.
                TsiWebDocumentResponse result = apiInstance.ContractsSetContractDocumentFileName(contractNumber, documentID, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsSetContractDocumentFileName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract number. | 
 **documentID** | **int?**| The document identifier. | 
 **fileName** | **string**| Name of the file. | 

### Return type

[**TsiWebDocumentResponse**](TsiWebDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsupdatecontract"></a>
# **ContractsUpdateContract**
> TsiWebContractResponse ContractsUpdateContract (int? contractNumber, TsiWebUpdateContractModel model)

Updates a contract.

BillingCycle : \"DoNotBill\", \"Weekly\", \"Monthly\",\"Quarterly\", \"SemiAnnually\", \"Annually\", \"InFull\".<br /><p>If the billing cycle DoNotBill is specified any requested value for the BillTo address will be ignored. The existing values for the bill to address will be maintained.</p><br /><br /><p>  BillingStyle : \"TotalOnly\", \"ShowLineItems\".  </p><p>  PricingMethod : \"Fixed\", \"Calculated\".  </p><p>  BasisType : \"Hourly\", \"Incidents\", \"Prepaid\", \"HourlyUsage\", \"TimePeriod\", \"Units\".  </p><p>  LaborBillingType : \"FixedHourlyRate\", \"Discount\".  </p><p>  BillingOption : \"InvoiceCustomer\", \"ApplyToContract\", \"ApplyToContractAndBillcustomer\", \"DoNotInvoice\".  </p><p>  PeriodUsageCycle : \"ContractTerm\", \"Month\", \"Quarter\", \"SemiAnnual\", \"Annual\".  </p><p>  RoundingFactor : \"DoNotRound\", \"FifteenMinutes\", \"HalfHour\".  </p><p>  BillingAddress : \"AccountDefaultAddress\", \"PrimaryAddress\", \"AlternateAddress\",\"ManualEntry\".  </p><p>Basis - The following properties are read only HourrRemaining, MinutesRemaining, AmountRemaining, UnitsRemaining, UnitsUsed, PeriodClicksUsed, ToDateTotalHours, ToDateTotalDollars, CurrentDollars and OverUnderIndicator</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsUpdateContractExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The account number.
            var model = new TsiWebUpdateContractModel(); // TsiWebUpdateContractModel | Update Contract Request.

            try
            {
                // Updates a contract.
                TsiWebContractResponse result = apiInstance.ContractsUpdateContract(contractNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsUpdateContract: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The account number. | 
 **model** | [**TsiWebUpdateContractModel**](TsiWebUpdateContractModel.md)| Update Contract Request. | 

### Return type

[**TsiWebContractResponse**](TsiWebContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsupdatecontractdocumentproperties"></a>
# **ContractsUpdateContractDocumentProperties**
> TsiWebDocumentResponse ContractsUpdateContractDocumentProperties (int? contractNumber, int? documentID, TsiWebAreasWebApiUpdateDocumentModel request)

Updates the contract document information. Does not allow the file name property to be changed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsUpdateContractDocumentPropertiesExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract number.
            var documentID = 56;  // int? | The document identifier.
            var request = new TsiWebAreasWebApiUpdateDocumentModel(); // TsiWebAreasWebApiUpdateDocumentModel | The update document request.

            try
            {
                // Updates the contract document information. Does not allow the file name property to be changed.
                TsiWebDocumentResponse result = apiInstance.ContractsUpdateContractDocumentProperties(contractNumber, documentID, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsUpdateContractDocumentProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract number. | 
 **documentID** | **int?**| The document identifier. | 
 **request** | [**TsiWebAreasWebApiUpdateDocumentModel**](TsiWebAreasWebApiUpdateDocumentModel.md)| The update document request. | 

### Return type

[**TsiWebDocumentResponse**](TsiWebDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsupdatecontractlineitem"></a>
# **ContractsUpdateContractLineItem**
> TsiWebContractDetailResponse ContractsUpdateContractLineItem (int? contractNumber, int? contractDetailNumber, TsiWebUpdateContractLineItemModel model)

Updates a contract line item detail

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsUpdateContractLineItemExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract identifier number.
            var contractDetailNumber = 56;  // int? | The contract line item detail identifier.
            var model = new TsiWebUpdateContractLineItemModel(); // TsiWebUpdateContractLineItemModel | UpdateContractLineItemModel.

            try
            {
                // Updates a contract line item detail
                TsiWebContractDetailResponse result = apiInstance.ContractsUpdateContractLineItem(contractNumber, contractDetailNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsUpdateContractLineItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract identifier number. | 
 **contractDetailNumber** | **int?**| The contract line item detail identifier. | 
 **model** | [**TsiWebUpdateContractLineItemModel**](TsiWebUpdateContractLineItemModel.md)| UpdateContractLineItemModel. | 

### Return type

[**TsiWebContractDetailResponse**](TsiWebContractDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsupdatecustomfields"></a>
# **ContractsUpdateCustomFields**
> TsiWebCustomFieldsResponse ContractsUpdateCustomFields (int? contractNumber, List<TsiWebCustomField> customFields)

Updates the custom fields for a contract.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsUpdateCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var contractNumber = 56;  // int? | The contract number.
            var customFields = new List<TsiWebCustomField>(); // List<TsiWebCustomField> | The custom fields.

            try
            {
                // Updates the custom fields for a contract.
                TsiWebCustomFieldsResponse result = apiInstance.ContractsUpdateCustomFields(contractNumber, customFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsUpdateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractNumber** | **int?**| The contract number. | 
 **customFields** | [**List&lt;TsiWebCustomField&gt;**](TsiWebCustomField.md)| The custom fields. | 

### Return type

[**TsiWebCustomFieldsResponse**](TsiWebCustomFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsupdatemeterreadings"></a>
# **ContractsUpdateMeterReadings**
> TsiWebResponse ContractsUpdateMeterReadings (TsiWebMeterModel model)

Update a contract meter for a DeviceID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsUpdateMeterReadingsExample
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var model = new TsiWebMeterModel(); // TsiWebMeterModel | ContractMeterModel.

            try
            {
                // Update a contract meter for a DeviceID
                TsiWebResponse result = apiInstance.ContractsUpdateMeterReadings(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsUpdateMeterReadings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebMeterModel**](TsiWebMeterModel.md)| ContractMeterModel. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractsupdatemeterreadings_0"></a>
# **ContractsUpdateMeterReadings_0**
> TsiWebResponse ContractsUpdateMeterReadings_0 (TsiWebMeterModel model)

Update a contract meter for a DeviceID

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ContractsUpdateMeterReadings_0Example
    {
        public void main()
        {
            var apiInstance = new ContractsApi();
            var model = new TsiWebMeterModel(); // TsiWebMeterModel | ContractMeterModel.

            try
            {
                // Update a contract meter for a DeviceID
                TsiWebResponse result = apiInstance.ContractsUpdateMeterReadings_0(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContractsApi.ContractsUpdateMeterReadings_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebMeterModel**](TsiWebMeterModel.md)| ContractMeterModel. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

