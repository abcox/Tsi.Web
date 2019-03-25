# IO.Swagger.Api.ProjectsApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsGetPhaseCompletedTasks**](ProjectsApi.md#projectsgetphasecompletedtasks) | **GET** /api/projects/phases/{PhaseNumber}/tasks/completed | Gets the phase completed tasks.
[**ProjectsGetPhaseIncompleteTasks**](ProjectsApi.md#projectsgetphaseincompletetasks) | **GET** /api/projects/phases/{PhaseNumber}/tasks | Gets the phase incomplete tasks.
[**ProjectsGetPhaseTasks**](ProjectsApi.md#projectsgetphasetasks) | **GET** /api/projects/phases/{PhaseNumber}/tasks/all | Gets the phase tasks. Includes both completed and incomplete tasks.
[**ProjectsGetProjectCompletedTasks**](ProjectsApi.md#projectsgetprojectcompletedtasks) | **GET** /api/projects/{ProjectNumber}/tasks/completed | Gets the Project completed tasks.
[**ProjectsGetProjectIncompleteTasks**](ProjectsApi.md#projectsgetprojectincompletetasks) | **GET** /api/projects/{ProjectNumber}/tasks | Gets the Project incomplete tasks.
[**ProjectsGetProjectTasks**](ProjectsApi.md#projectsgetprojecttasks) | **GET** /api/projects/{ProjectNumber}/tasks/all | Gets the Project tasks. Includes both completed and incomplete tasks.


<a name="projectsgetphasecompletedtasks"></a>
# **ProjectsGetPhaseCompletedTasks**
> TsiWebTasksResponse ProjectsGetPhaseCompletedTasks (int? phaseNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the phase completed tasks.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProjectsGetPhaseCompletedTasksExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var phaseNumber = 56;  // int? | The phase number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the phase completed tasks.
                TsiWebTasksResponse result = apiInstance.ProjectsGetPhaseCompletedTasks(phaseNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetPhaseCompletedTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phaseNumber** | **int?**| The phase number. | 
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

<a name="projectsgetphaseincompletetasks"></a>
# **ProjectsGetPhaseIncompleteTasks**
> TsiWebTasksResponse ProjectsGetPhaseIncompleteTasks (int? phaseNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the phase incomplete tasks.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProjectsGetPhaseIncompleteTasksExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var phaseNumber = 56;  // int? | The phase number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the phase incomplete tasks.
                TsiWebTasksResponse result = apiInstance.ProjectsGetPhaseIncompleteTasks(phaseNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetPhaseIncompleteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phaseNumber** | **int?**| The phase number. | 
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

<a name="projectsgetphasetasks"></a>
# **ProjectsGetPhaseTasks**
> TsiWebTasksResponse ProjectsGetPhaseTasks (int? phaseNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the phase tasks. Includes both completed and incomplete tasks.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ProjectsGetPhaseTasksExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var phaseNumber = 56;  // int? | The phase number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the phase tasks. Includes both completed and incomplete tasks.
                TsiWebTasksResponse result = apiInstance.ProjectsGetPhaseTasks(phaseNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetPhaseTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **phaseNumber** | **int?**| The phase number. | 
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

<a name="projectsgetprojectcompletedtasks"></a>
# **ProjectsGetProjectCompletedTasks**
> TsiWebTasksResponse ProjectsGetProjectCompletedTasks (int? projectNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Project completed tasks.

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
    public class ProjectsGetProjectCompletedTasksExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectNumber = 56;  // int? | The Project number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Project completed tasks.
                TsiWebTasksResponse result = apiInstance.ProjectsGetProjectCompletedTasks(projectNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetProjectCompletedTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectNumber** | **int?**| The Project number. | 
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

<a name="projectsgetprojectincompletetasks"></a>
# **ProjectsGetProjectIncompleteTasks**
> TsiWebTasksResponse ProjectsGetProjectIncompleteTasks (int? projectNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Project incomplete tasks.

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
    public class ProjectsGetProjectIncompleteTasksExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectNumber = 56;  // int? | The Project number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Project incomplete tasks.
                TsiWebTasksResponse result = apiInstance.ProjectsGetProjectIncompleteTasks(projectNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetProjectIncompleteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectNumber** | **int?**| The Project number. | 
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

<a name="projectsgetprojecttasks"></a>
# **ProjectsGetProjectTasks**
> TsiWebTasksResponse ProjectsGetProjectTasks (int? projectNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Project tasks. Includes both completed and incomplete tasks.

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
    public class ProjectsGetProjectTasksExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectNumber = 56;  // int? | The Project number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Project tasks. Includes both completed and incomplete tasks.
                TsiWebTasksResponse result = apiInstance.ProjectsGetProjectTasks(projectNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetProjectTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectNumber** | **int?**| The Project number. | 
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

