# IO.Swagger.Api.RepsApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RepsGetRepCompletedTasks**](RepsApi.md#repsgetrepcompletedtasks) | **GET** /api/reps/{repNumber}/tasks/completed | Gets the Rep completed tasks.
[**RepsGetRepDetail**](RepsApi.md#repsgetrepdetail) | **GET** /api/reps/{repNumber}/details | Gets the Rep detail.
[**RepsGetRepIncompleteTasks**](RepsApi.md#repsgetrepincompletetasks) | **GET** /api/reps/{repNumber}/tasks | Gets the Rep incomplete tasks.
[**RepsGetRepSummary**](RepsApi.md#repsgetrepsummary) | **GET** /api/reps/{repNumber} | Gets the Rep summary.
[**RepsGetRepTasks**](RepsApi.md#repsgetreptasks) | **GET** /api/reps/{repNumber}/tasks/all | Gets the Rep tasks. Includes both completed and incomplete tasks.


<a name="repsgetrepcompletedtasks"></a>
# **RepsGetRepCompletedTasks**
> TsiWebTasksResponse RepsGetRepCompletedTasks (int? repNumber, bool? repModelScheduledFor = null, bool? repModelScheduledBy = null, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Rep completed tasks.

If you are retrieving a private task and if you are not the owner, only the following the fields are retrieved.  <p>  AccountNumber, AccountName, ScheduledForRepNumber, ScheduledForRepName, StartDate, StartTime, WholeStartDateTime, EndDate, EndTime, WholeEnddateTime, IsPrivate  </p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RepsGetRepCompletedTasksExample
    {
        public void main()
        {
            var apiInstance = new RepsApi();
            var repNumber = 56;  // int? | The Rep number.
            var repModelScheduledFor = true;  // bool? |  (optional) 
            var repModelScheduledBy = true;  // bool? |  (optional) 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Rep completed tasks.
                TsiWebTasksResponse result = apiInstance.RepsGetRepCompletedTasks(repNumber, repModelScheduledFor, repModelScheduledBy, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepsApi.RepsGetRepCompletedTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repNumber** | **int?**| The Rep number. | 
 **repModelScheduledFor** | **bool?**|  | [optional] 
 **repModelScheduledBy** | **bool?**|  | [optional] 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebTasksResponse**](TsiWebTasksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repsgetrepdetail"></a>
# **RepsGetRepDetail**
> TsiWebRepDetail RepsGetRepDetail (int? repNumber)

Gets the Rep detail.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RepsGetRepDetailExample
    {
        public void main()
        {
            var apiInstance = new RepsApi();
            var repNumber = 56;  // int? | The Rep number.

            try
            {
                // Gets the Rep detail.
                TsiWebRepDetail result = apiInstance.RepsGetRepDetail(repNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepsApi.RepsGetRepDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repNumber** | **int?**| The Rep number. | 

### Return type

[**TsiWebRepDetail**](TsiWebRepDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repsgetrepincompletetasks"></a>
# **RepsGetRepIncompleteTasks**
> TsiWebTasksResponse RepsGetRepIncompleteTasks (int? repNumber, bool? repModelScheduledFor = null, bool? repModelScheduledBy = null, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Rep incomplete tasks.

If you are retrieving a private task and if you are not the owner, only the following the fields are retrieved.  <p>  AccountNumber, AccountName, ScheduledForRepNumber, ScheduledForRepName, StartDate, StartTime, WholeStartDateTime, EndDate, EndTime, WholeEnddateTime, IsPrivate  </p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RepsGetRepIncompleteTasksExample
    {
        public void main()
        {
            var apiInstance = new RepsApi();
            var repNumber = 56;  // int? | The Rep number.
            var repModelScheduledFor = true;  // bool? |  (optional) 
            var repModelScheduledBy = true;  // bool? |  (optional) 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Rep incomplete tasks.
                TsiWebTasksResponse result = apiInstance.RepsGetRepIncompleteTasks(repNumber, repModelScheduledFor, repModelScheduledBy, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepsApi.RepsGetRepIncompleteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repNumber** | **int?**| The Rep number. | 
 **repModelScheduledFor** | **bool?**|  | [optional] 
 **repModelScheduledBy** | **bool?**|  | [optional] 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebTasksResponse**](TsiWebTasksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repsgetrepsummary"></a>
# **RepsGetRepSummary**
> TsiWebRepSummary RepsGetRepSummary (int? repNumber)

Gets the Rep summary.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RepsGetRepSummaryExample
    {
        public void main()
        {
            var apiInstance = new RepsApi();
            var repNumber = 56;  // int? | The Rep number.

            try
            {
                // Gets the Rep summary.
                TsiWebRepSummary result = apiInstance.RepsGetRepSummary(repNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepsApi.RepsGetRepSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repNumber** | **int?**| The Rep number. | 

### Return type

[**TsiWebRepSummary**](TsiWebRepSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="repsgetreptasks"></a>
# **RepsGetRepTasks**
> TsiWebTasksResponse RepsGetRepTasks (int? repNumber, bool? repModelScheduledFor = null, bool? repModelScheduledBy = null, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Rep tasks. Includes both completed and incomplete tasks.

If you are retrieving a private task and if you are not the owner, only the following the fields are retrieved.  <p>  AccountNumber, AccountName, ScheduledForRepNumber, ScheduledForRepName, StartDate, StartTime, WholeStartDateTime, EndDate, EndTime, WholeEnddateTime, IsPrivate  </p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RepsGetRepTasksExample
    {
        public void main()
        {
            var apiInstance = new RepsApi();
            var repNumber = 56;  // int? | The Rep number.
            var repModelScheduledFor = true;  // bool? |  (optional) 
            var repModelScheduledBy = true;  // bool? |  (optional) 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Rep tasks. Includes both completed and incomplete tasks.
                TsiWebTasksResponse result = apiInstance.RepsGetRepTasks(repNumber, repModelScheduledFor, repModelScheduledBy, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RepsApi.RepsGetRepTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repNumber** | **int?**| The Rep number. | 
 **repModelScheduledFor** | **bool?**|  | [optional] 
 **repModelScheduledBy** | **bool?**|  | [optional] 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebTasksResponse**](TsiWebTasksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

