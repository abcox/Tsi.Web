# IO.Swagger.Api.AgreementsApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AgreementsAdvancedSearch**](AgreementsApi.md#agreementsadvancedsearch) | **POST** /api/agreements/search | Advanced search for Agreement.
[**AgreementsGetAgreementAdditionalChargeByDetailId**](AgreementsApi.md#agreementsgetagreementadditionalchargebydetailid) | **GET** /api/agreements/{agreementNumber}/additionalcharges/{detailId} | Gets the agreement additional charges by id
[**AgreementsGetAgreementAdditionalCharges**](AgreementsApi.md#agreementsgetagreementadditionalcharges) | **GET** /api/agreements/{agreementNumber}/additionalcharges | Gets the agreement additional charges.
[**AgreementsGetAgreementBillToInformation**](AgreementsApi.md#agreementsgetagreementbilltoinformation) | **GET** /api/agreements/{agreementNumber}/billto | Gets the agreement bill to information.
[**AgreementsGetAgreementCustomerAssets**](AgreementsApi.md#agreementsgetagreementcustomerassets) | **GET** /api/agreements/{agreementNumber}/account/{accountNumber}/customerassets | Gets the account customer assets.
[**AgreementsGetAgreementCustomerAssetsByAssetID**](AgreementsApi.md#agreementsgetagreementcustomerassetsbyassetid) | **GET** /api/agreements/{agreementNumber}/account/{accountNumber}/customerassets/{customerassetNumber} | Gets the agreement customer assets by customer asset number.
[**AgreementsGetAgreementCustomerAssetsByProviderAssetID**](AgreementsApi.md#agreementsgetagreementcustomerassetsbyproviderassetid) | **GET** /api/agreements/{agreementNumber}/account/{accountNumber}/customerassets/provider/{providerAssetNumber} | Gets the agreement customer assets by provider asset number.
[**AgreementsGetAgreementDetails**](AgreementsApi.md#agreementsgetagreementdetails) | **GET** /api/agreements/{agreementNumber}/details | Gets the agreement detail.
[**AgreementsGetAgreementSummary**](AgreementsApi.md#agreementsgetagreementsummary) | **GET** /api/agreements/{agreementNumber} | Gets the agreement summary.
[**AgreementsGetAgreementsForAccounts**](AgreementsApi.md#agreementsgetagreementsforaccounts) | **GET** /api/agreements/account/{accountNumber} | Gets the account agreements.
[**AgreementsGetAgreementsForAccounts_0**](AgreementsApi.md#agreementsgetagreementsforaccounts_0) | **GET** /api/agreements/account/{accountNumber}/{activeOnly} | Gets the account agreements.
[**AgreementsGetCoveredAssetTypeByAssetTypeId**](AgreementsApi.md#agreementsgetcoveredassettypebyassettypeid) | **GET** /api/agreements/{agreementNumber}/coveredassets/{coveredAssetNumber} | Gets the agreement covered asset type by asset type id.
[**AgreementsGetCoveredAssetTypes**](AgreementsApi.md#agreementsgetcoveredassettypes) | **GET** /api/agreements/{agreementNumber}/coveredassets | Gets the agreement covered asset types.
[**AgreementsSearchByAgreementNumber**](AgreementsApi.md#agreementssearchbyagreementnumber) | **POST** /api/agreements/search/agreementnumber | Search agreement by agreement number.
[**AgreementsSearchByAgreementType**](AgreementsApi.md#agreementssearchbyagreementtype) | **POST** /api/agreements/search/agreementtype | Search agreement by AgreementType.
[**AgreementsSearchByContractNumber**](AgreementsApi.md#agreementssearchbycontractnumber) | **POST** /api/agreements/search/contractnumber | Search agreement by ContractNumber.
[**AgreementsSearchByEndDate**](AgreementsApi.md#agreementssearchbyenddate) | **POST** /api/agreements/search/enddate | Search agreement by Agreement End Date.
[**AgreementsSearchByExternalProduct**](AgreementsApi.md#agreementssearchbyexternalproduct) | **POST** /api/agreements/search/externalproduct | Search agreement by ExternalProduct.
[**AgreementsSearchByStartDate**](AgreementsApi.md#agreementssearchbystartdate) | **POST** /api/agreements/search/startdate | Search agreement by Agreement Start Date.


<a name="agreementsadvancedsearch"></a>
# **AgreementsAdvancedSearch**
> TsiWebSearchAgreementResponse AgreementsAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for Agreement.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for Agreement.
                TsiWebSearchAgreementResponse result = apiInstance.AgreementsAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsAdvancedSearch: " + e.Message );
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

[**TsiWebSearchAgreementResponse**](TsiWebSearchAgreementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetagreementadditionalchargebydetailid"></a>
# **AgreementsGetAgreementAdditionalChargeByDetailId**
> TsiWebAgreementAdditionalCharge AgreementsGetAgreementAdditionalChargeByDetailId (int? agreementNumber, int? detailId)

Gets the agreement additional charges by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetAgreementAdditionalChargeByDetailIdExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var agreementNumber = 56;  // int? | The agreement identifier number
            var detailId = 56;  // int? | The additional charge identifier number

            try
            {
                // Gets the agreement additional charges by id
                TsiWebAgreementAdditionalCharge result = apiInstance.AgreementsGetAgreementAdditionalChargeByDetailId(agreementNumber, detailId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetAgreementAdditionalChargeByDetailId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreementNumber** | **int?**| The agreement identifier number | 
 **detailId** | **int?**| The additional charge identifier number | 

### Return type

[**TsiWebAgreementAdditionalCharge**](TsiWebAgreementAdditionalCharge.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetagreementadditionalcharges"></a>
# **AgreementsGetAgreementAdditionalCharges**
> List<TsiWebAgreementAdditionalCharge> AgreementsGetAgreementAdditionalCharges (int? agreementNumber)

Gets the agreement additional charges.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetAgreementAdditionalChargesExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var agreementNumber = 56;  // int? | The agreement identifier number

            try
            {
                // Gets the agreement additional charges.
                List&lt;TsiWebAgreementAdditionalCharge&gt; result = apiInstance.AgreementsGetAgreementAdditionalCharges(agreementNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetAgreementAdditionalCharges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreementNumber** | **int?**| The agreement identifier number | 

### Return type

[**List<TsiWebAgreementAdditionalCharge>**](TsiWebAgreementAdditionalCharge.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetagreementbilltoinformation"></a>
# **AgreementsGetAgreementBillToInformation**
> TsiWebAgreementBillTo AgreementsGetAgreementBillToInformation (int? agreementNumber)

Gets the agreement bill to information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetAgreementBillToInformationExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var agreementNumber = 56;  // int? | The agreement identifier number

            try
            {
                // Gets the agreement bill to information.
                TsiWebAgreementBillTo result = apiInstance.AgreementsGetAgreementBillToInformation(agreementNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetAgreementBillToInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreementNumber** | **int?**| The agreement identifier number | 

### Return type

[**TsiWebAgreementBillTo**](TsiWebAgreementBillTo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetagreementcustomerassets"></a>
# **AgreementsGetAgreementCustomerAssets**
> List<TsiWebAgreementCustomerAsset> AgreementsGetAgreementCustomerAssets (int? agreementNumber, int? accountNumber)

Gets the account customer assets.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetAgreementCustomerAssetsExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var agreementNumber = 56;  // int? | The agreement identifier number
            var accountNumber = 56;  // int? | The agreement identifier number

            try
            {
                // Gets the account customer assets.
                List&lt;TsiWebAgreementCustomerAsset&gt; result = apiInstance.AgreementsGetAgreementCustomerAssets(agreementNumber, accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetAgreementCustomerAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreementNumber** | **int?**| The agreement identifier number | 
 **accountNumber** | **int?**| The agreement identifier number | 

### Return type

[**List<TsiWebAgreementCustomerAsset>**](TsiWebAgreementCustomerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetagreementcustomerassetsbyassetid"></a>
# **AgreementsGetAgreementCustomerAssetsByAssetID**
> TsiWebAgreementCustomerAsset AgreementsGetAgreementCustomerAssetsByAssetID (int? agreementNumber, int? accountNumber, int? customerassetNumber)

Gets the agreement customer assets by customer asset number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetAgreementCustomerAssetsByAssetIDExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var agreementNumber = 56;  // int? | The agreement identifier number
            var accountNumber = 56;  // int? | The agreement identifier number
            var customerassetNumber = 56;  // int? | The customer asset identifier number

            try
            {
                // Gets the agreement customer assets by customer asset number.
                TsiWebAgreementCustomerAsset result = apiInstance.AgreementsGetAgreementCustomerAssetsByAssetID(agreementNumber, accountNumber, customerassetNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetAgreementCustomerAssetsByAssetID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreementNumber** | **int?**| The agreement identifier number | 
 **accountNumber** | **int?**| The agreement identifier number | 
 **customerassetNumber** | **int?**| The customer asset identifier number | 

### Return type

[**TsiWebAgreementCustomerAsset**](TsiWebAgreementCustomerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetagreementcustomerassetsbyproviderassetid"></a>
# **AgreementsGetAgreementCustomerAssetsByProviderAssetID**
> TsiWebAgreementCustomerAsset AgreementsGetAgreementCustomerAssetsByProviderAssetID (int? agreementNumber, int? accountNumber, int? providerAssetNumber)

Gets the agreement customer assets by provider asset number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetAgreementCustomerAssetsByProviderAssetIDExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var agreementNumber = 56;  // int? | The agreement identifier number
            var accountNumber = 56;  // int? | The agreement identifier number
            var providerAssetNumber = 56;  // int? | The customer provider asset identifier number

            try
            {
                // Gets the agreement customer assets by provider asset number.
                TsiWebAgreementCustomerAsset result = apiInstance.AgreementsGetAgreementCustomerAssetsByProviderAssetID(agreementNumber, accountNumber, providerAssetNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetAgreementCustomerAssetsByProviderAssetID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreementNumber** | **int?**| The agreement identifier number | 
 **accountNumber** | **int?**| The agreement identifier number | 
 **providerAssetNumber** | **int?**| The customer provider asset identifier number | 

### Return type

[**TsiWebAgreementCustomerAsset**](TsiWebAgreementCustomerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetagreementdetails"></a>
# **AgreementsGetAgreementDetails**
> TsiWebAgreementDetail AgreementsGetAgreementDetails (int? agreementNumber)

Gets the agreement detail.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetAgreementDetailsExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var agreementNumber = 56;  // int? | The agreement identifier number

            try
            {
                // Gets the agreement detail.
                TsiWebAgreementDetail result = apiInstance.AgreementsGetAgreementDetails(agreementNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetAgreementDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreementNumber** | **int?**| The agreement identifier number | 

### Return type

[**TsiWebAgreementDetail**](TsiWebAgreementDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetagreementsummary"></a>
# **AgreementsGetAgreementSummary**
> TsiWebAgreementSummary AgreementsGetAgreementSummary (int? agreementNumber)

Gets the agreement summary.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetAgreementSummaryExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var agreementNumber = 56;  // int? | The agreement identifier number.

            try
            {
                // Gets the agreement summary.
                TsiWebAgreementSummary result = apiInstance.AgreementsGetAgreementSummary(agreementNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetAgreementSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreementNumber** | **int?**| The agreement identifier number. | 

### Return type

[**TsiWebAgreementSummary**](TsiWebAgreementSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetagreementsforaccounts"></a>
# **AgreementsGetAgreementsForAccounts**
> TsiWebSearchAgreementResponse AgreementsGetAgreementsForAccounts (int? accountNumber, bool? activeOnly = null)

Gets the account agreements.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetAgreementsForAccountsExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var accountNumber = 56;  // int? | The account identifier number
            var activeOnly = true;  // bool? | if set to true returns only the active agreements. (optional) 

            try
            {
                // Gets the account agreements.
                TsiWebSearchAgreementResponse result = apiInstance.AgreementsGetAgreementsForAccounts(accountNumber, activeOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetAgreementsForAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account identifier number | 
 **activeOnly** | **bool?**| if set to true returns only the active agreements. | [optional] 

### Return type

[**TsiWebSearchAgreementResponse**](TsiWebSearchAgreementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetagreementsforaccounts_0"></a>
# **AgreementsGetAgreementsForAccounts_0**
> TsiWebSearchAgreementResponse AgreementsGetAgreementsForAccounts_0 (int? accountNumber, bool? activeOnly)

Gets the account agreements.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetAgreementsForAccounts_0Example
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var accountNumber = 56;  // int? | The account identifier number
            var activeOnly = true;  // bool? | if set to true returns only the active agreements.

            try
            {
                // Gets the account agreements.
                TsiWebSearchAgreementResponse result = apiInstance.AgreementsGetAgreementsForAccounts_0(accountNumber, activeOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetAgreementsForAccounts_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account identifier number | 
 **activeOnly** | **bool?**| if set to true returns only the active agreements. | 

### Return type

[**TsiWebSearchAgreementResponse**](TsiWebSearchAgreementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetcoveredassettypebyassettypeid"></a>
# **AgreementsGetCoveredAssetTypeByAssetTypeId**
> TsiWebAgreementCoveredAssetType AgreementsGetCoveredAssetTypeByAssetTypeId (int? agreementNumber, int? coveredAssetNumber)

Gets the agreement covered asset type by asset type id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetCoveredAssetTypeByAssetTypeIdExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var agreementNumber = 56;  // int? | The agreement identifier number
            var coveredAssetNumber = 56;  // int? | The covered asset type identifier number

            try
            {
                // Gets the agreement covered asset type by asset type id.
                TsiWebAgreementCoveredAssetType result = apiInstance.AgreementsGetCoveredAssetTypeByAssetTypeId(agreementNumber, coveredAssetNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetCoveredAssetTypeByAssetTypeId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreementNumber** | **int?**| The agreement identifier number | 
 **coveredAssetNumber** | **int?**| The covered asset type identifier number | 

### Return type

[**TsiWebAgreementCoveredAssetType**](TsiWebAgreementCoveredAssetType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementsgetcoveredassettypes"></a>
# **AgreementsGetCoveredAssetTypes**
> List<TsiWebAgreementCoveredAssetType> AgreementsGetCoveredAssetTypes (int? agreementNumber)

Gets the agreement covered asset types.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsGetCoveredAssetTypesExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var agreementNumber = 56;  // int? | The agreement identifier number

            try
            {
                // Gets the agreement covered asset types.
                List&lt;TsiWebAgreementCoveredAssetType&gt; result = apiInstance.AgreementsGetCoveredAssetTypes(agreementNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsGetCoveredAssetTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **agreementNumber** | **int?**| The agreement identifier number | 

### Return type

[**List<TsiWebAgreementCoveredAssetType>**](TsiWebAgreementCoveredAssetType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementssearchbyagreementnumber"></a>
# **AgreementsSearchByAgreementNumber**
> TsiWebSearchAgreementResponse AgreementsSearchByAgreementNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search agreement by agreement number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsSearchByAgreementNumberExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search agreement by agreement number.
                TsiWebSearchAgreementResponse result = apiInstance.AgreementsSearchByAgreementNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsSearchByAgreementNumber: " + e.Message );
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

[**TsiWebSearchAgreementResponse**](TsiWebSearchAgreementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementssearchbyagreementtype"></a>
# **AgreementsSearchByAgreementType**
> TsiWebSearchAgreementResponse AgreementsSearchByAgreementType (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search agreement by AgreementType.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsSearchByAgreementTypeExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search agreement by AgreementType.
                TsiWebSearchAgreementResponse result = apiInstance.AgreementsSearchByAgreementType(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsSearchByAgreementType: " + e.Message );
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

[**TsiWebSearchAgreementResponse**](TsiWebSearchAgreementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementssearchbycontractnumber"></a>
# **AgreementsSearchByContractNumber**
> TsiWebSearchAgreementResponse AgreementsSearchByContractNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search agreement by ContractNumber.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsSearchByContractNumberExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search agreement by ContractNumber.
                TsiWebSearchAgreementResponse result = apiInstance.AgreementsSearchByContractNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsSearchByContractNumber: " + e.Message );
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

[**TsiWebSearchAgreementResponse**](TsiWebSearchAgreementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementssearchbyenddate"></a>
# **AgreementsSearchByEndDate**
> TsiWebSearchAgreementResponse AgreementsSearchByEndDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search agreement by Agreement End Date.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsSearchByEndDateExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | A {Tsi.Web.DateTimeSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search agreement by Agreement End Date.
                TsiWebSearchAgreementResponse result = apiInstance.AgreementsSearchByEndDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsSearchByEndDate: " + e.Message );
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

[**TsiWebSearchAgreementResponse**](TsiWebSearchAgreementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementssearchbyexternalproduct"></a>
# **AgreementsSearchByExternalProduct**
> TsiWebSearchAgreementResponse AgreementsSearchByExternalProduct (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search agreement by ExternalProduct.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsSearchByExternalProductExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search agreement by ExternalProduct.
                TsiWebSearchAgreementResponse result = apiInstance.AgreementsSearchByExternalProduct(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsSearchByExternalProduct: " + e.Message );
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

[**TsiWebSearchAgreementResponse**](TsiWebSearchAgreementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agreementssearchbystartdate"></a>
# **AgreementsSearchByStartDate**
> TsiWebSearchAgreementResponse AgreementsSearchByStartDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search agreement by Agreement Start Date.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AgreementsSearchByStartDateExample
    {
        public void main()
        {
            var apiInstance = new AgreementsApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | A {Tsi.Web.DateTimeSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search agreement by Agreement Start Date.
                TsiWebSearchAgreementResponse result = apiInstance.AgreementsSearchByStartDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AgreementsApi.AgreementsSearchByStartDate: " + e.Message );
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

[**TsiWebSearchAgreementResponse**](TsiWebSearchAgreementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

