# IO.Swagger.Api.TimeSlipApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimeSlipAdvancedSearch**](TimeSlipApi.md#timeslipadvancedsearch) | **POST** /api/timeslips/search | Advanced search for TimeSlip.
[**TimeSlipCreateTimeSlip**](TimeSlipApi.md#timeslipcreatetimeslip) | **POST** /api/timeslips | Creates a time slip.
[**TimeSlipGetTimeSlip**](TimeSlipApi.md#timeslipgettimeslip) | **GET** /api/timeslips/{timeSlipNumber} | Gets the time slip by time slip number.
[**TimeSlipSearchByEndDate**](TimeSlipApi.md#timeslipsearchbyenddate) | **POST** /api/timeslips/search/enddate | Search time slip by time slip End Date.
[**TimeSlipSearchByLogReason**](TimeSlipApi.md#timeslipsearchbylogreason) | **POST** /api/timeslips/search/logreason | Search time slip by time slip log reason.
[**TimeSlipSearchByStartDate**](TimeSlipApi.md#timeslipsearchbystartdate) | **POST** /api/timeslips/search/startdate | Search time slip by time slip Start Date.
[**TimeSlipSearchByTechAssigned**](TimeSlipApi.md#timeslipsearchbytechassigned) | **POST** /api/timeslips/search/techassigned | Search time slip by time slip tech assigned.
[**TimeSlipSearchByTimeSlipNumber**](TimeSlipApi.md#timeslipsearchbytimeslipnumber) | **POST** /api/timeslips/search/timeslipnumber | Search time slip by time slip number.
[**TimeSlipUpdateTimeSlip**](TimeSlipApi.md#timeslipupdatetimeslip) | **PUT** /api/timeslips/{timeSlipNumber} | Updates a time slip.


<a name="timeslipadvancedsearch"></a>
# **TimeSlipAdvancedSearch**
> TsiWebSearchTimeSlipResponse TimeSlipAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for TimeSlip.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeSlipAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new TimeSlipApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for TimeSlip.
                TsiWebSearchTimeSlipResponse result = apiInstance.TimeSlipAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSlipApi.TimeSlipAdvancedSearch: " + e.Message );
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

[**TsiWebSearchTimeSlipResponse**](TsiWebSearchTimeSlipResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeslipcreatetimeslip"></a>
# **TimeSlipCreateTimeSlip**
> TsiWebTimeSlipResponse TimeSlipCreateTimeSlip (TsiWebCreateTimeSlipModel model)

Creates a time slip.

Billing options for time slips are Business and personal only.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeSlipCreateTimeSlipExample
    {
        public void main()
        {
            var apiInstance = new TimeSlipApi();
            var model = new TsiWebCreateTimeSlipModel(); // TsiWebCreateTimeSlipModel | The time slip model.

            try
            {
                // Creates a time slip.
                TsiWebTimeSlipResponse result = apiInstance.TimeSlipCreateTimeSlip(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSlipApi.TimeSlipCreateTimeSlip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCreateTimeSlipModel**](TsiWebCreateTimeSlipModel.md)| The time slip model. | 

### Return type

[**TsiWebTimeSlipResponse**](TsiWebTimeSlipResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeslipgettimeslip"></a>
# **TimeSlipGetTimeSlip**
> TsiWebTimeSlipSummary TimeSlipGetTimeSlip (int? timeSlipNumber)

Gets the time slip by time slip number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeSlipGetTimeSlipExample
    {
        public void main()
        {
            var apiInstance = new TimeSlipApi();
            var timeSlipNumber = 56;  // int? | The time slip identifier.

            try
            {
                // Gets the time slip by time slip number.
                TsiWebTimeSlipSummary result = apiInstance.TimeSlipGetTimeSlip(timeSlipNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSlipApi.TimeSlipGetTimeSlip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeSlipNumber** | **int?**| The time slip identifier. | 

### Return type

[**TsiWebTimeSlipSummary**](TsiWebTimeSlipSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeslipsearchbyenddate"></a>
# **TimeSlipSearchByEndDate**
> TsiWebSearchTimeSlipResponse TimeSlipSearchByEndDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search time slip by time slip End Date.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeSlipSearchByEndDateExample
    {
        public void main()
        {
            var apiInstance = new TimeSlipApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | A {Tsi.Web.DateTimeSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search time slip by time slip End Date.
                TsiWebSearchTimeSlipResponse result = apiInstance.TimeSlipSearchByEndDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSlipApi.TimeSlipSearchByEndDate: " + e.Message );
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

[**TsiWebSearchTimeSlipResponse**](TsiWebSearchTimeSlipResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeslipsearchbylogreason"></a>
# **TimeSlipSearchByLogReason**
> TsiWebSearchTimeSlipResponse TimeSlipSearchByLogReason (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search time slip by time slip log reason.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeSlipSearchByLogReasonExample
    {
        public void main()
        {
            var apiInstance = new TimeSlipApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search time slip by time slip log reason.
                TsiWebSearchTimeSlipResponse result = apiInstance.TimeSlipSearchByLogReason(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSlipApi.TimeSlipSearchByLogReason: " + e.Message );
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

[**TsiWebSearchTimeSlipResponse**](TsiWebSearchTimeSlipResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeslipsearchbystartdate"></a>
# **TimeSlipSearchByStartDate**
> TsiWebSearchTimeSlipResponse TimeSlipSearchByStartDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search time slip by time slip Start Date.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeSlipSearchByStartDateExample
    {
        public void main()
        {
            var apiInstance = new TimeSlipApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | A {Tsi.Web.DateTimeSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search time slip by time slip Start Date.
                TsiWebSearchTimeSlipResponse result = apiInstance.TimeSlipSearchByStartDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSlipApi.TimeSlipSearchByStartDate: " + e.Message );
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

[**TsiWebSearchTimeSlipResponse**](TsiWebSearchTimeSlipResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeslipsearchbytechassigned"></a>
# **TimeSlipSearchByTechAssigned**
> TsiWebSearchTimeSlipResponse TimeSlipSearchByTechAssigned (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search time slip by time slip tech assigned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeSlipSearchByTechAssignedExample
    {
        public void main()
        {
            var apiInstance = new TimeSlipApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search time slip by time slip tech assigned.
                TsiWebSearchTimeSlipResponse result = apiInstance.TimeSlipSearchByTechAssigned(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSlipApi.TimeSlipSearchByTechAssigned: " + e.Message );
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

[**TsiWebSearchTimeSlipResponse**](TsiWebSearchTimeSlipResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeslipsearchbytimeslipnumber"></a>
# **TimeSlipSearchByTimeSlipNumber**
> TsiWebSearchTimeSlipResponse TimeSlipSearchByTimeSlipNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search time slip by time slip number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeSlipSearchByTimeSlipNumberExample
    {
        public void main()
        {
            var apiInstance = new TimeSlipApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search time slip by time slip number.
                TsiWebSearchTimeSlipResponse result = apiInstance.TimeSlipSearchByTimeSlipNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSlipApi.TimeSlipSearchByTimeSlipNumber: " + e.Message );
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

[**TsiWebSearchTimeSlipResponse**](TsiWebSearchTimeSlipResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timeslipupdatetimeslip"></a>
# **TimeSlipUpdateTimeSlip**
> TsiWebTimeSlipResponse TimeSlipUpdateTimeSlip (int? timeSlipNumber, TsiWebUpdateTimeSlipModel model)

Updates a time slip.

Billing options for time slips are Business and personal only.   <p>Valid values for acceptance statuses are \"None\", Accepted\", \"Questioned\" And \"Resubmitted\"</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TimeSlipUpdateTimeSlipExample
    {
        public void main()
        {
            var apiInstance = new TimeSlipApi();
            var timeSlipNumber = 56;  // int? | 
            var model = new TsiWebUpdateTimeSlipModel(); // TsiWebUpdateTimeSlipModel | The time slip model.

            try
            {
                // Updates a time slip.
                TsiWebTimeSlipResponse result = apiInstance.TimeSlipUpdateTimeSlip(timeSlipNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeSlipApi.TimeSlipUpdateTimeSlip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timeSlipNumber** | **int?**|  | 
 **model** | [**TsiWebUpdateTimeSlipModel**](TsiWebUpdateTimeSlipModel.md)| The time slip model. | 

### Return type

[**TsiWebTimeSlipResponse**](TsiWebTimeSlipResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

