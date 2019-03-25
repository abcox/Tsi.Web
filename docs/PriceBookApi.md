# IO.Swagger.Api.PriceBookApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PriceBookAdvancedSearch**](PriceBookApi.md#pricebookadvancedsearch) | **POST** /api/pricebook/items/search | Advanced search for Pricebook.
[**PriceBookCreatePriceBookItem**](PriceBookApi.md#pricebookcreatepricebookitem) | **POST** /api/pricebook/items | Creates a price book item.
[**PriceBookCreatePriceBookItemAssemblyDetail**](PriceBookApi.md#pricebookcreatepricebookitemassemblydetail) | **POST** /api/pricebook/items/{priceBookItemNumber}/assembly | Creates an assembly detail item on an existing assembly.
[**PriceBookCreatePriceBookItemAssemblyDetail_0**](PriceBookApi.md#pricebookcreatepricebookitemassemblydetail_0) | **POST** /api/pricebook/items/{priceBookItemNumber}/assembly/{recalculateClosedAssemblyCost} | Creates an assembly detail item on an existing assembly.
[**PriceBookCreatePriceBookItem_0**](PriceBookApi.md#pricebookcreatepricebookitem_0) | **POST** /api/pricebook/items/{calculateClosedAssemblyCost} | Creates a price book item.
[**PriceBookDeletePriceBookItemAssemblyDetail**](PriceBookApi.md#pricebookdeletepricebookitemassemblydetail) | **DELETE** /api/pricebook/items/{priceBookItemNumber}/assembly/details/{assemblyDetailNumber}/{recalculateClosedAssemblyCost} | Deletes an assembly detail item.
[**PriceBookGetCustomFields**](PriceBookApi.md#pricebookgetcustomfields) | **GET** /api/pricebook/items/{priceBookItemNumber}/customfields | Gets the custom fields for a quote.
[**PriceBookGetCustomFieldsByItemId**](PriceBookApi.md#pricebookgetcustomfieldsbyitemid) | **GET** /api/pricebook/items/customfields | Gets the custom fields by item id.
[**PriceBookGetLocations**](PriceBookApi.md#pricebookgetlocations) | **GET** /api/pricebook/items/location | Gets the location details of a price book item.
[**PriceBookGetLocationsByPriceBookNumber**](PriceBookApi.md#pricebookgetlocationsbypricebooknumber) | **GET** /api/pricebook/items/{priceBookItemNumber}/location | Gets the location details of a price book item.
[**PriceBookGetMovementLogs**](PriceBookApi.md#pricebookgetmovementlogs) | **GET** /api/pricebook/items/movementlog | Gets the movement logs for a price book item.
[**PriceBookGetMovementLogsByPriceBookNumber**](PriceBookApi.md#pricebookgetmovementlogsbypricebooknumber) | **GET** /api/pricebook/items/{priceBookItemNumber}/movementlog | Gets the movement logs for a price book item.
[**PriceBookGetPriceBookDetails**](PriceBookApi.md#pricebookgetpricebookdetails) | **GET** /api/pricebook/items/details | Gets the details of a price book item.
[**PriceBookGetPriceBookDetailsByPriceBookNumber**](PriceBookApi.md#pricebookgetpricebookdetailsbypricebooknumber) | **GET** /api/pricebook/items/{priceBookItemNumber}/details | Gets the details of a price book item.
[**PriceBookGetPriceBookSummary**](PriceBookApi.md#pricebookgetpricebooksummary) | **GET** /api/pricebook/items | Gets a summary of the price book item.
[**PriceBookGetPriceBookSummaryByPriceBookNumber**](PriceBookApi.md#pricebookgetpricebooksummarybypricebooknumber) | **GET** /api/pricebook/items/{priceBookItemNumber} | Gets a summary of the price book item.
[**PriceBookSearchByCategory**](PriceBookApi.md#pricebooksearchbycategory) | **POST** /api/pricebook/items/search/category | Search pricebook by category.
[**PriceBookSearchByCustomField**](PriceBookApi.md#pricebooksearchbycustomfield) | **POST** /api/pricebook/items/search/customfield | Search Pricebook using a custom category and field label.
[**PriceBookSearchByGlobalPricebook**](PriceBookApi.md#pricebooksearchbyglobalpricebook) | **POST** /api/pricebook/items/search/global | Search pricebook by any criteria.
[**PriceBookSearchByItemDescription**](PriceBookApi.md#pricebooksearchbyitemdescription) | **POST** /api/pricebook/items/search/itemdescription | Search pricebook by item description.
[**PriceBookSearchByItemId**](PriceBookApi.md#pricebooksearchbyitemid) | **POST** /api/pricebook/items/search/itemid/{activeOnly} | Search pricebook by itemID.
[**PriceBookSearchByItemType**](PriceBookApi.md#pricebooksearchbyitemtype) | **POST** /api/pricebook/items/search/type | Search pricebook by item type.
[**PriceBookSearchByMfgPartNumber**](PriceBookApi.md#pricebooksearchbymfgpartnumber) | **POST** /api/pricebook/items/search/mfgpartnumber | Search pricebook by mfg partnumber.
[**PriceBookSearchByOurPartNumber**](PriceBookApi.md#pricebooksearchbyourpartnumber) | **POST** /api/pricebook/items/search/ourpartnumber | Search pricebook by our partnumber.
[**PriceBookSearchByUpc**](PriceBookApi.md#pricebooksearchbyupc) | **POST** /api/pricebook/items/search/upc | Search pricebook by UPC.
[**PriceBookSearchByVendorPartNumber**](PriceBookApi.md#pricebooksearchbyvendorpartnumber) | **POST** /api/pricebook/items/search/vendorpartnumber | Search pricebook by Vendor part number.
[**PriceBookUpdateCustomFields**](PriceBookApi.md#pricebookupdatecustomfields) | **PUT** /api/pricebook/items/{priceBookItemNumber}/customfields | Updates the custom fields for a price book item.
[**PriceBookUpdatePriceBookItem**](PriceBookApi.md#pricebookupdatepricebookitem) | **PUT** /api/pricebook/items/{priceBookItemNumber} | Updates a price book item.
[**PriceBookUpdatePriceBookItemAssemblyDetailQuantity**](PriceBookApi.md#pricebookupdatepricebookitemassemblydetailquantity) | **PUT** /api/pricebook/items/{priceBookItemNumber}/assembly/details/{assemblyDetailNumber}/quantity/{quantity}/{recalculateClosedAssemblyCost} | Updates assembly detail quantity.
[**PriceBookUpdatePriceBookItem_0**](PriceBookApi.md#pricebookupdatepricebookitem_0) | **PUT** /api/pricebook/items/{priceBookItemNumber}/{recalculateClosedAssemblyCost} | Updates a price book item.


<a name="pricebookadvancedsearch"></a>
# **PriceBookAdvancedSearch**
> TsiWebSearchPriceBookResponse PriceBookAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for Pricebook.

<p>Valid SearchType = ItemId, ItemDescription, ItemType, MfgPartNumber, OurPartNumber, Upc, VendorPartNumber, AllItemIds, GlobalPricebook, ItemIdWithInactive, Category, CustomField (requires CategoryName and CustomFieldName)</p>  <p>Valid criteria for ItemType search is M, A, L, S, F. The search defaults to a match type of Equal and does not support wild card charaters.</p>  <p>Valid MatchType = StartsWith (default), EndsWith, Contains, GreaterThan, GreaterThanEqual, Equal, LessThan, LessThanEqual</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for Pricebook.
                TsiWebSearchPriceBookResponse result = apiInstance.PriceBookAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookAdvancedSearch: " + e.Message );
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

[**TsiWebSearchPriceBookResponse**](TsiWebSearchPriceBookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookcreatepricebookitem"></a>
# **PriceBookCreatePriceBookItem**
> TsiWebPriceBookItemResponse PriceBookCreatePriceBookItem (TsiWebCreatePriceBookItemModel priceBookItem, bool? calculateClosedAssemblyCost = null)

Creates a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookCreatePriceBookItemExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItem = new TsiWebCreatePriceBookItemModel(); // TsiWebCreatePriceBookItemModel | The price book item to add.
            var calculateClosedAssemblyCost = true;  // bool? | If set to true calculate the BaseCost of the closed assembly. (optional) 

            try
            {
                // Creates a price book item.
                TsiWebPriceBookItemResponse result = apiInstance.PriceBookCreatePriceBookItem(priceBookItem, calculateClosedAssemblyCost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookCreatePriceBookItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItem** | [**TsiWebCreatePriceBookItemModel**](TsiWebCreatePriceBookItemModel.md)| The price book item to add. | 
 **calculateClosedAssemblyCost** | **bool?**| If set to true calculate the BaseCost of the closed assembly. | [optional] 

### Return type

[**TsiWebPriceBookItemResponse**](TsiWebPriceBookItemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookcreatepricebookitemassemblydetail"></a>
# **PriceBookCreatePriceBookItemAssemblyDetail**
> TsiWebPriceBookItemResponse PriceBookCreatePriceBookItemAssemblyDetail (int? priceBookItemNumber, TsiWebAssemblyItem assemblyItem, bool? recalculateClosedAssemblyCost = null)

Creates an assembly detail item on an existing assembly.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookCreatePriceBookItemAssemblyDetailExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItemNumber = 56;  // int? | The price book number.
            var assemblyItem = new TsiWebAssemblyItem(); // TsiWebAssemblyItem | The assembly item to add.
            var recalculateClosedAssemblyCost = true;  // bool? | If set to true forces the cost to be recalcuated for the closed assembly. (optional) 

            try
            {
                // Creates an assembly detail item on an existing assembly.
                TsiWebPriceBookItemResponse result = apiInstance.PriceBookCreatePriceBookItemAssemblyDetail(priceBookItemNumber, assemblyItem, recalculateClosedAssemblyCost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookCreatePriceBookItemAssemblyDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItemNumber** | **int?**| The price book number. | 
 **assemblyItem** | [**TsiWebAssemblyItem**](TsiWebAssemblyItem.md)| The assembly item to add. | 
 **recalculateClosedAssemblyCost** | **bool?**| If set to true forces the cost to be recalcuated for the closed assembly. | [optional] 

### Return type

[**TsiWebPriceBookItemResponse**](TsiWebPriceBookItemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookcreatepricebookitemassemblydetail_0"></a>
# **PriceBookCreatePriceBookItemAssemblyDetail_0**
> TsiWebPriceBookItemResponse PriceBookCreatePriceBookItemAssemblyDetail_0 (int? priceBookItemNumber, TsiWebAssemblyItem assemblyItem, bool? recalculateClosedAssemblyCost)

Creates an assembly detail item on an existing assembly.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookCreatePriceBookItemAssemblyDetail_0Example
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItemNumber = 56;  // int? | The price book number.
            var assemblyItem = new TsiWebAssemblyItem(); // TsiWebAssemblyItem | The assembly item to add.
            var recalculateClosedAssemblyCost = true;  // bool? | If set to true forces the cost to be recalcuated for the closed assembly.

            try
            {
                // Creates an assembly detail item on an existing assembly.
                TsiWebPriceBookItemResponse result = apiInstance.PriceBookCreatePriceBookItemAssemblyDetail_0(priceBookItemNumber, assemblyItem, recalculateClosedAssemblyCost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookCreatePriceBookItemAssemblyDetail_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItemNumber** | **int?**| The price book number. | 
 **assemblyItem** | [**TsiWebAssemblyItem**](TsiWebAssemblyItem.md)| The assembly item to add. | 
 **recalculateClosedAssemblyCost** | **bool?**| If set to true forces the cost to be recalcuated for the closed assembly. | 

### Return type

[**TsiWebPriceBookItemResponse**](TsiWebPriceBookItemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookcreatepricebookitem_0"></a>
# **PriceBookCreatePriceBookItem_0**
> TsiWebPriceBookItemResponse PriceBookCreatePriceBookItem_0 (TsiWebCreatePriceBookItemModel priceBookItem, bool? calculateClosedAssemblyCost)

Creates a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookCreatePriceBookItem_0Example
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItem = new TsiWebCreatePriceBookItemModel(); // TsiWebCreatePriceBookItemModel | The price book item to add.
            var calculateClosedAssemblyCost = true;  // bool? | If set to true calculate the BaseCost of the closed assembly.

            try
            {
                // Creates a price book item.
                TsiWebPriceBookItemResponse result = apiInstance.PriceBookCreatePriceBookItem_0(priceBookItem, calculateClosedAssemblyCost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookCreatePriceBookItem_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItem** | [**TsiWebCreatePriceBookItemModel**](TsiWebCreatePriceBookItemModel.md)| The price book item to add. | 
 **calculateClosedAssemblyCost** | **bool?**| If set to true calculate the BaseCost of the closed assembly. | 

### Return type

[**TsiWebPriceBookItemResponse**](TsiWebPriceBookItemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookdeletepricebookitemassemblydetail"></a>
# **PriceBookDeletePriceBookItemAssemblyDetail**
> TsiWebPriceBookItemResponse PriceBookDeletePriceBookItemAssemblyDetail (int? priceBookItemNumber, int? assemblyDetailNumber, bool? recalculateClosedAssemblyCost)

Deletes an assembly detail item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookDeletePriceBookItemAssemblyDetailExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItemNumber = 56;  // int? | The price book number.
            var assemblyDetailNumber = 56;  // int? | The assembly detail number.
            var recalculateClosedAssemblyCost = true;  // bool? | If set to true forces the cost to be recalcuated for the closed assembly.

            try
            {
                // Deletes an assembly detail item.
                TsiWebPriceBookItemResponse result = apiInstance.PriceBookDeletePriceBookItemAssemblyDetail(priceBookItemNumber, assemblyDetailNumber, recalculateClosedAssemblyCost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookDeletePriceBookItemAssemblyDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItemNumber** | **int?**| The price book number. | 
 **assemblyDetailNumber** | **int?**| The assembly detail number. | 
 **recalculateClosedAssemblyCost** | **bool?**| If set to true forces the cost to be recalcuated for the closed assembly. | 

### Return type

[**TsiWebPriceBookItemResponse**](TsiWebPriceBookItemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookgetcustomfields"></a>
# **PriceBookGetCustomFields**
> List<TsiWebCustomField> PriceBookGetCustomFields (int? priceBooItemNumber, string priceBookItemNumber)

Gets the custom fields for a quote.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookGetCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBooItemNumber = 56;  // int? | The price book item number.
            var priceBookItemNumber = priceBookItemNumber_example;  // string | 

            try
            {
                // Gets the custom fields for a quote.
                List&lt;TsiWebCustomField&gt; result = apiInstance.PriceBookGetCustomFields(priceBooItemNumber, priceBookItemNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookGetCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBooItemNumber** | **int?**| The price book item number. | 
 **priceBookItemNumber** | **string**|  | 

### Return type

[**List<TsiWebCustomField>**](TsiWebCustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookgetcustomfieldsbyitemid"></a>
# **PriceBookGetCustomFieldsByItemId**
> List<TsiWebCustomField> PriceBookGetCustomFieldsByItemId (string itemId)

Gets the custom fields by item id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookGetCustomFieldsByItemIdExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var itemId = itemId_example;  // string | The item id.

            try
            {
                // Gets the custom fields by item id.
                List&lt;TsiWebCustomField&gt; result = apiInstance.PriceBookGetCustomFieldsByItemId(itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookGetCustomFieldsByItemId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **string**| The item id. | 

### Return type

[**List<TsiWebCustomField>**](TsiWebCustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookgetlocations"></a>
# **PriceBookGetLocations**
> List<TsiWebLocationDetail> PriceBookGetLocations (string itemId)

Gets the location details of a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookGetLocationsExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var itemId = itemId_example;  // string | The Item Id.

            try
            {
                // Gets the location details of a price book item.
                List&lt;TsiWebLocationDetail&gt; result = apiInstance.PriceBookGetLocations(itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookGetLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **string**| The Item Id. | 

### Return type

[**List<TsiWebLocationDetail>**](TsiWebLocationDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookgetlocationsbypricebooknumber"></a>
# **PriceBookGetLocationsByPriceBookNumber**
> List<TsiWebLocationDetail> PriceBookGetLocationsByPriceBookNumber (int? priceBookItemNumber)

Gets the location details of a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookGetLocationsByPriceBookNumberExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItemNumber = 56;  // int? | The price book item number.

            try
            {
                // Gets the location details of a price book item.
                List&lt;TsiWebLocationDetail&gt; result = apiInstance.PriceBookGetLocationsByPriceBookNumber(priceBookItemNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookGetLocationsByPriceBookNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItemNumber** | **int?**| The price book item number. | 

### Return type

[**List<TsiWebLocationDetail>**](TsiWebLocationDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookgetmovementlogs"></a>
# **PriceBookGetMovementLogs**
> List<TsiWebMovementLog> PriceBookGetMovementLogs (string itemId)

Gets the movement logs for a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookGetMovementLogsExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var itemId = itemId_example;  // string | The Item Id.

            try
            {
                // Gets the movement logs for a price book item.
                List&lt;TsiWebMovementLog&gt; result = apiInstance.PriceBookGetMovementLogs(itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookGetMovementLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **string**| The Item Id. | 

### Return type

[**List<TsiWebMovementLog>**](TsiWebMovementLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookgetmovementlogsbypricebooknumber"></a>
# **PriceBookGetMovementLogsByPriceBookNumber**
> List<TsiWebMovementLog> PriceBookGetMovementLogsByPriceBookNumber (int? priceBookItemNumber)

Gets the movement logs for a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookGetMovementLogsByPriceBookNumberExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItemNumber = 56;  // int? | The price book item number.

            try
            {
                // Gets the movement logs for a price book item.
                List&lt;TsiWebMovementLog&gt; result = apiInstance.PriceBookGetMovementLogsByPriceBookNumber(priceBookItemNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookGetMovementLogsByPriceBookNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItemNumber** | **int?**| The price book item number. | 

### Return type

[**List<TsiWebMovementLog>**](TsiWebMovementLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookgetpricebookdetails"></a>
# **PriceBookGetPriceBookDetails**
> TsiWebPriceBookItemDetail PriceBookGetPriceBookDetails (string itemId)

Gets the details of a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookGetPriceBookDetailsExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var itemId = itemId_example;  // string | The item identifier.

            try
            {
                // Gets the details of a price book item.
                TsiWebPriceBookItemDetail result = apiInstance.PriceBookGetPriceBookDetails(itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookGetPriceBookDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **string**| The item identifier. | 

### Return type

[**TsiWebPriceBookItemDetail**](TsiWebPriceBookItemDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookgetpricebookdetailsbypricebooknumber"></a>
# **PriceBookGetPriceBookDetailsByPriceBookNumber**
> TsiWebPriceBookItemDetail PriceBookGetPriceBookDetailsByPriceBookNumber (int? priceBookItemNumber)

Gets the details of a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookGetPriceBookDetailsByPriceBookNumberExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItemNumber = 56;  // int? | The price book item number.

            try
            {
                // Gets the details of a price book item.
                TsiWebPriceBookItemDetail result = apiInstance.PriceBookGetPriceBookDetailsByPriceBookNumber(priceBookItemNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookGetPriceBookDetailsByPriceBookNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItemNumber** | **int?**| The price book item number. | 

### Return type

[**TsiWebPriceBookItemDetail**](TsiWebPriceBookItemDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookgetpricebooksummary"></a>
# **PriceBookGetPriceBookSummary**
> TsiWebPriceBookItemSummary PriceBookGetPriceBookSummary (string itemId)

Gets a summary of the price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookGetPriceBookSummaryExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var itemId = itemId_example;  // string | The Item Id.

            try
            {
                // Gets a summary of the price book item.
                TsiWebPriceBookItemSummary result = apiInstance.PriceBookGetPriceBookSummary(itemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookGetPriceBookSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **itemId** | **string**| The Item Id. | 

### Return type

[**TsiWebPriceBookItemSummary**](TsiWebPriceBookItemSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookgetpricebooksummarybypricebooknumber"></a>
# **PriceBookGetPriceBookSummaryByPriceBookNumber**
> TsiWebPriceBookItemSummary PriceBookGetPriceBookSummaryByPriceBookNumber (int? priceBookItemNumber)

Gets a summary of the price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookGetPriceBookSummaryByPriceBookNumberExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItemNumber = 56;  // int? | The price book item number.

            try
            {
                // Gets a summary of the price book item.
                TsiWebPriceBookItemSummary result = apiInstance.PriceBookGetPriceBookSummaryByPriceBookNumber(priceBookItemNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookGetPriceBookSummaryByPriceBookNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItemNumber** | **int?**| The price book item number. | 

### Return type

[**TsiWebPriceBookItemSummary**](TsiWebPriceBookItemSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebooksearchbycategory"></a>
# **PriceBookSearchByCategory**
> TsiWebSearchPriceBookResponse PriceBookSearchByCategory (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search pricebook by category.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookSearchByCategoryExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search pricebook by category.
                TsiWebSearchPriceBookResponse result = apiInstance.PriceBookSearchByCategory(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookSearchByCategory: " + e.Message );
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

[**TsiWebSearchPriceBookResponse**](TsiWebSearchPriceBookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebooksearchbycustomfield"></a>
# **PriceBookSearchByCustomField**
> TsiWebSearchAccountResponse PriceBookSearchByCustomField (TsiWebCustomFieldSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Pricebook using a custom category and field label.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookSearchByCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var model = new TsiWebCustomFieldSearchModel(); // TsiWebCustomFieldSearchModel | A {Tsi.Web.CustomFieldSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Pricebook using a custom category and field label.
                TsiWebSearchAccountResponse result = apiInstance.PriceBookSearchByCustomField(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookSearchByCustomField: " + e.Message );
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

[**TsiWebSearchAccountResponse**](TsiWebSearchAccountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebooksearchbyglobalpricebook"></a>
# **PriceBookSearchByGlobalPricebook**
> TsiWebSearchPriceBookResponse PriceBookSearchByGlobalPricebook (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search pricebook by any criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookSearchByGlobalPricebookExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search pricebook by any criteria.
                TsiWebSearchPriceBookResponse result = apiInstance.PriceBookSearchByGlobalPricebook(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookSearchByGlobalPricebook: " + e.Message );
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

[**TsiWebSearchPriceBookResponse**](TsiWebSearchPriceBookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebooksearchbyitemdescription"></a>
# **PriceBookSearchByItemDescription**
> TsiWebSearchPriceBookResponse PriceBookSearchByItemDescription (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search pricebook by item description.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookSearchByItemDescriptionExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search pricebook by item description.
                TsiWebSearchPriceBookResponse result = apiInstance.PriceBookSearchByItemDescription(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookSearchByItemDescription: " + e.Message );
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

[**TsiWebSearchPriceBookResponse**](TsiWebSearchPriceBookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebooksearchbyitemid"></a>
# **PriceBookSearchByItemId**
> TsiWebSearchPriceBookResponse PriceBookSearchByItemId (string criteria, bool? activeOnly, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search pricebook by itemID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookSearchByItemIdExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var activeOnly = true;  // bool? | if set to true searches only the active item ids.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search pricebook by itemID.
                TsiWebSearchPriceBookResponse result = apiInstance.PriceBookSearchByItemId(criteria, activeOnly, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookSearchByItemId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A JSON or XML string containing the criteria. | 
 **activeOnly** | **bool?**| if set to true searches only the active item ids. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchPriceBookResponse**](TsiWebSearchPriceBookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebooksearchbyitemtype"></a>
# **PriceBookSearchByItemType**
> TsiWebSearchPriceBookResponse PriceBookSearchByItemType (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search pricebook by item type.

<p>Valid criteria for ItemType search is M, A, L, S, F. The search defaults to a match type of Equal and does not support wild card charaters.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookSearchByItemTypeExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search pricebook by item type.
                TsiWebSearchPriceBookResponse result = apiInstance.PriceBookSearchByItemType(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookSearchByItemType: " + e.Message );
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

[**TsiWebSearchPriceBookResponse**](TsiWebSearchPriceBookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebooksearchbymfgpartnumber"></a>
# **PriceBookSearchByMfgPartNumber**
> TsiWebSearchPriceBookResponse PriceBookSearchByMfgPartNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search pricebook by mfg partnumber.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookSearchByMfgPartNumberExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search pricebook by mfg partnumber.
                TsiWebSearchPriceBookResponse result = apiInstance.PriceBookSearchByMfgPartNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookSearchByMfgPartNumber: " + e.Message );
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

[**TsiWebSearchPriceBookResponse**](TsiWebSearchPriceBookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebooksearchbyourpartnumber"></a>
# **PriceBookSearchByOurPartNumber**
> TsiWebSearchPriceBookResponse PriceBookSearchByOurPartNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search pricebook by our partnumber.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookSearchByOurPartNumberExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search pricebook by our partnumber.
                TsiWebSearchPriceBookResponse result = apiInstance.PriceBookSearchByOurPartNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookSearchByOurPartNumber: " + e.Message );
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

[**TsiWebSearchPriceBookResponse**](TsiWebSearchPriceBookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebooksearchbyupc"></a>
# **PriceBookSearchByUpc**
> TsiWebSearchPriceBookResponse PriceBookSearchByUpc (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search pricebook by UPC.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookSearchByUpcExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search pricebook by UPC.
                TsiWebSearchPriceBookResponse result = apiInstance.PriceBookSearchByUpc(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookSearchByUpc: " + e.Message );
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

[**TsiWebSearchPriceBookResponse**](TsiWebSearchPriceBookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebooksearchbyvendorpartnumber"></a>
# **PriceBookSearchByVendorPartNumber**
> TsiWebSearchPriceBookResponse PriceBookSearchByVendorPartNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search pricebook by Vendor part number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookSearchByVendorPartNumberExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search pricebook by Vendor part number.
                TsiWebSearchPriceBookResponse result = apiInstance.PriceBookSearchByVendorPartNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookSearchByVendorPartNumber: " + e.Message );
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

[**TsiWebSearchPriceBookResponse**](TsiWebSearchPriceBookResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookupdatecustomfields"></a>
# **PriceBookUpdateCustomFields**
> TsiWebCustomFieldsResponse PriceBookUpdateCustomFields (int? priceBooItemNumber, List<TsiWebCustomField> customFields, string priceBookItemNumber)

Updates the custom fields for a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookUpdateCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBooItemNumber = 56;  // int? | The price boo item number.
            var customFields = new List<TsiWebCustomField>(); // List<TsiWebCustomField> | The custom fields.
            var priceBookItemNumber = priceBookItemNumber_example;  // string | 

            try
            {
                // Updates the custom fields for a price book item.
                TsiWebCustomFieldsResponse result = apiInstance.PriceBookUpdateCustomFields(priceBooItemNumber, customFields, priceBookItemNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookUpdateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBooItemNumber** | **int?**| The price boo item number. | 
 **customFields** | [**List&lt;TsiWebCustomField&gt;**](TsiWebCustomField.md)| The custom fields. | 
 **priceBookItemNumber** | **string**|  | 

### Return type

[**TsiWebCustomFieldsResponse**](TsiWebCustomFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookupdatepricebookitem"></a>
# **PriceBookUpdatePriceBookItem**
> TsiWebPriceBookItemResponse PriceBookUpdatePriceBookItem (int? priceBookItemNumber, TsiWebUpdatePriceBookItemModel priceBookItem, bool? recalculateClosedAssemblyCost = null)

Updates a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookUpdatePriceBookItemExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItemNumber = 56;  // int? | The price book number.
            var priceBookItem = new TsiWebUpdatePriceBookItemModel(); // TsiWebUpdatePriceBookItemModel | The updated price book item.
            var recalculateClosedAssemblyCost = true;  // bool? | If set to true forces the cost to be recalcuated for the closed assembly. (optional) 

            try
            {
                // Updates a price book item.
                TsiWebPriceBookItemResponse result = apiInstance.PriceBookUpdatePriceBookItem(priceBookItemNumber, priceBookItem, recalculateClosedAssemblyCost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookUpdatePriceBookItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItemNumber** | **int?**| The price book number. | 
 **priceBookItem** | [**TsiWebUpdatePriceBookItemModel**](TsiWebUpdatePriceBookItemModel.md)| The updated price book item. | 
 **recalculateClosedAssemblyCost** | **bool?**| If set to true forces the cost to be recalcuated for the closed assembly. | [optional] 

### Return type

[**TsiWebPriceBookItemResponse**](TsiWebPriceBookItemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookupdatepricebookitemassemblydetailquantity"></a>
# **PriceBookUpdatePriceBookItemAssemblyDetailQuantity**
> TsiWebPriceBookItemResponse PriceBookUpdatePriceBookItemAssemblyDetailQuantity (int? priceBookItemNumber, int? assemblyDetailNumber, double? quantity, bool? recalculateClosedAssemblyCost)

Updates assembly detail quantity.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookUpdatePriceBookItemAssemblyDetailQuantityExample
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItemNumber = 56;  // int? | The price book number.
            var assemblyDetailNumber = 56;  // int? | The assembly detail number.
            var quantity = 1.2;  // double? | The quantity.
            var recalculateClosedAssemblyCost = true;  // bool? | If set to true forces the cost to be recalcuated for the closed assembly.

            try
            {
                // Updates assembly detail quantity.
                TsiWebPriceBookItemResponse result = apiInstance.PriceBookUpdatePriceBookItemAssemblyDetailQuantity(priceBookItemNumber, assemblyDetailNumber, quantity, recalculateClosedAssemblyCost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookUpdatePriceBookItemAssemblyDetailQuantity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItemNumber** | **int?**| The price book number. | 
 **assemblyDetailNumber** | **int?**| The assembly detail number. | 
 **quantity** | **double?**| The quantity. | 
 **recalculateClosedAssemblyCost** | **bool?**| If set to true forces the cost to be recalcuated for the closed assembly. | 

### Return type

[**TsiWebPriceBookItemResponse**](TsiWebPriceBookItemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pricebookupdatepricebookitem_0"></a>
# **PriceBookUpdatePriceBookItem_0**
> TsiWebPriceBookItemResponse PriceBookUpdatePriceBookItem_0 (int? priceBookItemNumber, TsiWebUpdatePriceBookItemModel priceBookItem, bool? recalculateClosedAssemblyCost)

Updates a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PriceBookUpdatePriceBookItem_0Example
    {
        public void main()
        {
            var apiInstance = new PriceBookApi();
            var priceBookItemNumber = 56;  // int? | The price book number.
            var priceBookItem = new TsiWebUpdatePriceBookItemModel(); // TsiWebUpdatePriceBookItemModel | The updated price book item.
            var recalculateClosedAssemblyCost = true;  // bool? | If set to true forces the cost to be recalcuated for the closed assembly.

            try
            {
                // Updates a price book item.
                TsiWebPriceBookItemResponse result = apiInstance.PriceBookUpdatePriceBookItem_0(priceBookItemNumber, priceBookItem, recalculateClosedAssemblyCost);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceBookApi.PriceBookUpdatePriceBookItem_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceBookItemNumber** | **int?**| The price book number. | 
 **priceBookItem** | [**TsiWebUpdatePriceBookItemModel**](TsiWebUpdatePriceBookItemModel.md)| The updated price book item. | 
 **recalculateClosedAssemblyCost** | **bool?**| If set to true forces the cost to be recalcuated for the closed assembly. | 

### Return type

[**TsiWebPriceBookItemResponse**](TsiWebPriceBookItemResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

