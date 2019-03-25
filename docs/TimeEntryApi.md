# IO.Swagger.Api.TimeEntryApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimeEntryAdvancedSearch**](TimeEntryApi.md#timeentryadvancedsearch) | **POST** /api/timeentries/search | Advanced search for time entry.
[**TimeEntryGetTimeEntriesByTechAssigned**](TimeEntryApi.md#timeentrygettimeentriesbytechassigned) | **GET** /api/timeentries/techassigned/{techAssigned} | Gets the time entries by tech assigned.
[**TimeEntrySearchByEndDate**](TimeEntryApi.md#timeentrysearchbyenddate) | **POST** /api/timeentries/search/enddate | Search time entry by end date time.
[**TimeEntrySearchByStartDate**](TimeEntryApi.md#timeentrysearchbystartdate) | **POST** /api/timeentries/search/startdate | Search time entry by start date time.
[**TimeEntrySearchByTimeEntryLogReason**](TimeEntryApi.md#timeentrysearchbytimeentrylogreason) | **POST** /api/timeentries/search/logreason | Search time entry by log reason.
[**TimeEntrySearchByTimeEntryTEchAssigned**](TimeEntryApi.md#timeentrysearchbytimeentrytechassigned) | **POST** /api/timeentries/search/techassigned | Search time entry by tech assigned.


<a name="timeentryadvancedsearch"></a>
# **TimeEntryAdvancedSearch**
> TsiWebSearchTimeEntryResponse TimeEntryAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for time entry.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeEntryAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new TimeEntryApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for time entry.
                TsiWebSearchTimeEntryResponse result = apiInstance.TimeEntryAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntryApi.TimeEntryAdvancedSearch: " + e.Message );
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

[**TsiWebSearchTimeEntryResponse**](TsiWebSearchTimeEntryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeentrygettimeentriesbytechassigned"></a>
# **TimeEntryGetTimeEntriesByTechAssigned**
> TsiWebTimeEntryResponse TimeEntryGetTimeEntriesByTechAssigned (int? techAssigned, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the time entries by tech assigned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeEntryGetTimeEntriesByTechAssignedExample
    {
        public void main()
        {
            var apiInstance = new TimeEntryApi();
            var techAssigned = 56;  // int? | The tech assigned number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the time entries by tech assigned.
                TsiWebTimeEntryResponse result = apiInstance.TimeEntryGetTimeEntriesByTechAssigned(techAssigned, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntryApi.TimeEntryGetTimeEntriesByTechAssigned: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **techAssigned** | **int?**| The tech assigned number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebTimeEntryResponse**](TsiWebTimeEntryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeentrysearchbyenddate"></a>
# **TimeEntrySearchByEndDate**
> TsiWebSearchTimeEntryResponse TimeEntrySearchByEndDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search time entry by end date time.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeEntrySearchByEndDateExample
    {
        public void main()
        {
            var apiInstance = new TimeEntryApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | A {Tsi.Web.DateTimeSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search time entry by end date time.
                TsiWebSearchTimeEntryResponse result = apiInstance.TimeEntrySearchByEndDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntryApi.TimeEntrySearchByEndDate: " + e.Message );
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

[**TsiWebSearchTimeEntryResponse**](TsiWebSearchTimeEntryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeentrysearchbystartdate"></a>
# **TimeEntrySearchByStartDate**
> TsiWebSearchTimeEntryResponse TimeEntrySearchByStartDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search time entry by start date time.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeEntrySearchByStartDateExample
    {
        public void main()
        {
            var apiInstance = new TimeEntryApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | A {Tsi.Web.DateTimeSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search time entry by start date time.
                TsiWebSearchTimeEntryResponse result = apiInstance.TimeEntrySearchByStartDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntryApi.TimeEntrySearchByStartDate: " + e.Message );
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

[**TsiWebSearchTimeEntryResponse**](TsiWebSearchTimeEntryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeentrysearchbytimeentrylogreason"></a>
# **TimeEntrySearchByTimeEntryLogReason**
> TsiWebSearchTimeEntryResponse TimeEntrySearchByTimeEntryLogReason (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search time entry by log reason.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeEntrySearchByTimeEntryLogReasonExample
    {
        public void main()
        {
            var apiInstance = new TimeEntryApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search time entry by log reason.
                TsiWebSearchTimeEntryResponse result = apiInstance.TimeEntrySearchByTimeEntryLogReason(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntryApi.TimeEntrySearchByTimeEntryLogReason: " + e.Message );
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

[**TsiWebSearchTimeEntryResponse**](TsiWebSearchTimeEntryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeentrysearchbytimeentrytechassigned"></a>
# **TimeEntrySearchByTimeEntryTEchAssigned**
> TsiWebSearchTimeEntryResponse TimeEntrySearchByTimeEntryTEchAssigned (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search time entry by tech assigned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeEntrySearchByTimeEntryTEchAssignedExample
    {
        public void main()
        {
            var apiInstance = new TimeEntryApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search time entry by tech assigned.
                TsiWebSearchTimeEntryResponse result = apiInstance.TimeEntrySearchByTimeEntryTEchAssigned(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeEntryApi.TimeEntrySearchByTimeEntryTEchAssigned: " + e.Message );
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

[**TsiWebSearchTimeEntryResponse**](TsiWebSearchTimeEntryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

