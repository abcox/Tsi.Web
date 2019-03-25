# IO.Swagger.Api.TasksApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TasksAdvancedSearch**](TasksApi.md#tasksadvancedsearch) | **POST** /api/tasks/search | Advanced search for Task.
[**TasksCreateTask**](TasksApi.md#taskscreatetask) | **POST** /api/tasks | Creates a task.
[**TasksCreateTaskCheckListItem**](TasksApi.md#taskscreatetaskchecklistitem) | **POST** /api/tasks/{taskNumber}/checklist | Creates a task checklist item.
[**TasksGetCustomFields**](TasksApi.md#tasksgetcustomfields) | **GET** /api/tasks/{taskNumber}/customfields | Gets the custom fields for a task.
[**TasksGetTaskCheckList**](TasksApi.md#tasksgettaskchecklist) | **GET** /api/tasks/{taskNumber}/tasklist | Gets the task check list by task number.
[**TasksGetTaskDetails**](TasksApi.md#tasksgettaskdetails) | **GET** /api/tasks/{taskNumber}/details | Gets the task details by task number.
[**TasksGetTaskSummary**](TasksApi.md#tasksgettasksummary) | **GET** /api/tasks/{taskNumber} | Gets the task summary by task number.
[**TasksSearchByAccountName**](TasksApi.md#taskssearchbyaccountname) | **POST** /api/tasks/search/accountname | Search task by account name.
[**TasksSearchByCustomField**](TasksApi.md#taskssearchbycustomfield) | **POST** /api/tasks/search/customfield | Search task by Custom field .
[**TasksSearchByEndDate**](TasksApi.md#taskssearchbyenddate) | **POST** /api/tasks/search/enddate | Search task by Task End Date.
[**TasksSearchByScheduledByRep**](TasksApi.md#taskssearchbyscheduledbyrep) | **POST** /api/tasks/search/scheduledbyrep | Search task by task scheduled by rep.
[**TasksSearchByScheduledForRep**](TasksApi.md#taskssearchbyscheduledforrep) | **POST** /api/tasks/search/scheduledforrep | Search task by task scheduled by rep.
[**TasksSearchByStartDate**](TasksApi.md#taskssearchbystartdate) | **POST** /api/tasks/search/startdate | Search task by Task Start Date.
[**TasksSearchByTaskAction**](TasksApi.md#taskssearchbytaskaction) | **POST** /api/tasks/search/taskaction | Search task by task action.
[**TasksSearchByTaskNumber**](TasksApi.md#taskssearchbytasknumber) | **POST** /api/tasks/search/tasknumber | Search task by task number.
[**TasksSearchByTaskType**](TasksApi.md#taskssearchbytasktype) | **POST** /api/tasks/search/tasktype | Search task by task type.
[**TasksUpdateTask**](TasksApi.md#tasksupdatetask) | **PUT** /api/tasks/{taskNumber} | Updates the task.
[**TasksUpdateTaskCheckListItem**](TasksApi.md#tasksupdatetaskchecklistitem) | **PUT** /api/tasks/{taskNumber}/checklist | Updates the task checklist.


<a name="tasksadvancedsearch"></a>
# **TasksAdvancedSearch**
> TsiWebSearchTaskResponse TasksAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for Task.

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
    public class TasksAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for Task.
                TsiWebSearchTaskResponse result = apiInstance.TasksAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksAdvancedSearch: " + e.Message );
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

[**TsiWebSearchTaskResponse**](TsiWebSearchTaskResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskscreatetask"></a>
# **TasksCreateTask**
> TsiWebTasksResponse TasksCreateTask (TsiWebCreateTaskModel model)

Creates a task.

The Type field accepts values \"Phone Call\", \"Appointment\", or \"To-do\". All the values are case sensitive.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TasksCreateTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var model = new TsiWebCreateTaskModel(); // TsiWebCreateTaskModel | The task.

            try
            {
                // Creates a task.
                TsiWebTasksResponse result = apiInstance.TasksCreateTask(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksCreateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCreateTaskModel**](TsiWebCreateTaskModel.md)| The task. | 

### Return type

[**TsiWebTasksResponse**](TsiWebTasksResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskscreatetaskchecklistitem"></a>
# **TasksCreateTaskCheckListItem**
> TsiWebTaskCheckListResponse TasksCreateTaskCheckListItem (int? taskNumber, TsiWebCreateTaskCheckListModel model)

Creates a task checklist item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TasksCreateTaskCheckListItemExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskNumber = 56;  // int? | The task number.
            var model = new TsiWebCreateTaskCheckListModel(); // TsiWebCreateTaskCheckListModel | The task.

            try
            {
                // Creates a task checklist item.
                TsiWebTaskCheckListResponse result = apiInstance.TasksCreateTaskCheckListItem(taskNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksCreateTaskCheckListItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskNumber** | **int?**| The task number. | 
 **model** | [**TsiWebCreateTaskCheckListModel**](TsiWebCreateTaskCheckListModel.md)| The task. | 

### Return type

[**TsiWebTaskCheckListResponse**](TsiWebTaskCheckListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksgetcustomfields"></a>
# **TasksGetCustomFields**
> List<TsiWebCustomField> TasksGetCustomFields (int? taskNumber)

Gets the custom fields for a task.

If you are retrieving a private task and if you are not the owner, an empty response is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TasksGetCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskNumber = 56;  // int? | The task number.

            try
            {
                // Gets the custom fields for a task.
                List&lt;TsiWebCustomField&gt; result = apiInstance.TasksGetCustomFields(taskNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksGetCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskNumber** | **int?**| The task number. | 

### Return type

[**List<TsiWebCustomField>**](TsiWebCustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksgettaskchecklist"></a>
# **TasksGetTaskCheckList**
> List<TsiWebTaskChecklistItem> TasksGetTaskCheckList (int? taskNumber)

Gets the task check list by task number.

If you are retrieving a private task and if you are not the owner, an empty response is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TasksGetTaskCheckListExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskNumber = 56;  // int? | The account number.

            try
            {
                // Gets the task check list by task number.
                List&lt;TsiWebTaskChecklistItem&gt; result = apiInstance.TasksGetTaskCheckList(taskNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksGetTaskCheckList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebTaskChecklistItem>**](TsiWebTaskChecklistItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksgettaskdetails"></a>
# **TasksGetTaskDetails**
> TsiWebTaskDetail TasksGetTaskDetails (int? taskNumber)

Gets the task details by task number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TasksGetTaskDetailsExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskNumber = 56;  // int? | The account number.

            try
            {
                // Gets the task details by task number.
                TsiWebTaskDetail result = apiInstance.TasksGetTaskDetails(taskNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksGetTaskDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskNumber** | **int?**| The account number. | 

### Return type

[**TsiWebTaskDetail**](TsiWebTaskDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksgettasksummary"></a>
# **TasksGetTaskSummary**
> TsiWebTaskSummary TasksGetTaskSummary (int? taskNumber)

Gets the task summary by task number.

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
    public class TasksGetTaskSummaryExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskNumber = 56;  // int? | The account number.

            try
            {
                // Gets the task summary by task number.
                TsiWebTaskSummary result = apiInstance.TasksGetTaskSummary(taskNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksGetTaskSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskNumber** | **int?**| The account number. | 

### Return type

[**TsiWebTaskSummary**](TsiWebTaskSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskssearchbyaccountname"></a>
# **TasksSearchByAccountName**
> TsiWebSearchTaskResponse TasksSearchByAccountName (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search task by account name.

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
    public class TasksSearchByAccountNameExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search task by account name.
                TsiWebSearchTaskResponse result = apiInstance.TasksSearchByAccountName(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksSearchByAccountName: " + e.Message );
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

[**TsiWebSearchTaskResponse**](TsiWebSearchTaskResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskssearchbycustomfield"></a>
# **TasksSearchByCustomField**
> TsiWebSearchContractResponse TasksSearchByCustomField (TsiWebCustomFieldSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search task by Custom field .

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
    public class TasksSearchByCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var model = new TsiWebCustomFieldSearchModel(); // TsiWebCustomFieldSearchModel | A {Tsi.Web.CustomFieldSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search task by Custom field .
                TsiWebSearchContractResponse result = apiInstance.TasksSearchByCustomField(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksSearchByCustomField: " + e.Message );
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

<a name="taskssearchbyenddate"></a>
# **TasksSearchByEndDate**
> TsiWebSearchTaskResponse TasksSearchByEndDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search task by Task End Date.

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
    public class TasksSearchByEndDateExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | A {Tsi.Web.DateTimeSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search task by Task End Date.
                TsiWebSearchTaskResponse result = apiInstance.TasksSearchByEndDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksSearchByEndDate: " + e.Message );
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

[**TsiWebSearchTaskResponse**](TsiWebSearchTaskResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskssearchbyscheduledbyrep"></a>
# **TasksSearchByScheduledByRep**
> TsiWebSearchTaskResponse TasksSearchByScheduledByRep (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search task by task scheduled by rep.

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
    public class TasksSearchByScheduledByRepExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search task by task scheduled by rep.
                TsiWebSearchTaskResponse result = apiInstance.TasksSearchByScheduledByRep(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksSearchByScheduledByRep: " + e.Message );
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

[**TsiWebSearchTaskResponse**](TsiWebSearchTaskResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskssearchbyscheduledforrep"></a>
# **TasksSearchByScheduledForRep**
> TsiWebSearchTaskResponse TasksSearchByScheduledForRep (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search task by task scheduled by rep.

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
    public class TasksSearchByScheduledForRepExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search task by task scheduled by rep.
                TsiWebSearchTaskResponse result = apiInstance.TasksSearchByScheduledForRep(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksSearchByScheduledForRep: " + e.Message );
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

[**TsiWebSearchTaskResponse**](TsiWebSearchTaskResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskssearchbystartdate"></a>
# **TasksSearchByStartDate**
> TsiWebSearchTaskResponse TasksSearchByStartDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search task by Task Start Date.

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
    public class TasksSearchByStartDateExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | A {Tsi.Web.DateTimeSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search task by Task Start Date.
                TsiWebSearchTaskResponse result = apiInstance.TasksSearchByStartDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksSearchByStartDate: " + e.Message );
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

[**TsiWebSearchTaskResponse**](TsiWebSearchTaskResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskssearchbytaskaction"></a>
# **TasksSearchByTaskAction**
> TsiWebSearchTaskResponse TasksSearchByTaskAction (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search task by task action.

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
    public class TasksSearchByTaskActionExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search task by task action.
                TsiWebSearchTaskResponse result = apiInstance.TasksSearchByTaskAction(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksSearchByTaskAction: " + e.Message );
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

[**TsiWebSearchTaskResponse**](TsiWebSearchTaskResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskssearchbytasknumber"></a>
# **TasksSearchByTaskNumber**
> TsiWebSearchTaskResponse TasksSearchByTaskNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search task by task number.

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
    public class TasksSearchByTaskNumberExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search task by task number.
                TsiWebSearchTaskResponse result = apiInstance.TasksSearchByTaskNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksSearchByTaskNumber: " + e.Message );
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

[**TsiWebSearchTaskResponse**](TsiWebSearchTaskResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="taskssearchbytasktype"></a>
# **TasksSearchByTaskType**
> TsiWebSearchTaskResponse TasksSearchByTaskType (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search task by task type.

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
    public class TasksSearchByTaskTypeExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search task by task type.
                TsiWebSearchTaskResponse result = apiInstance.TasksSearchByTaskType(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksSearchByTaskType: " + e.Message );
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

[**TsiWebSearchTaskResponse**](TsiWebSearchTaskResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksupdatetask"></a>
# **TasksUpdateTask**
> TsiWebTaskResponse TasksUpdateTask (int? taskNumber, TsiWebUpdateTaskModel model)

Updates the task.

The Type field accepts values \"Phone Call\", \"Appointment\", or \"To-do\". All the values are case sensitive.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TasksUpdateTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskNumber = 56;  // int? | The task number.
            var model = new TsiWebUpdateTaskModel(); // TsiWebUpdateTaskModel | The task.

            try
            {
                // Updates the task.
                TsiWebTaskResponse result = apiInstance.TasksUpdateTask(taskNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksUpdateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskNumber** | **int?**| The task number. | 
 **model** | [**TsiWebUpdateTaskModel**](TsiWebUpdateTaskModel.md)| The task. | 

### Return type

[**TsiWebTaskResponse**](TsiWebTaskResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksupdatetaskchecklistitem"></a>
# **TasksUpdateTaskCheckListItem**
> TsiWebTaskCheckListResponse TasksUpdateTaskCheckListItem (int? taskNumber, TsiWebUpdateTaskCheckListModel model)

Updates the task checklist.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TasksUpdateTaskCheckListItemExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskNumber = 56;  // int? | The task number.
            var model = new TsiWebUpdateTaskCheckListModel(); // TsiWebUpdateTaskCheckListModel | The task.

            try
            {
                // Updates the task checklist.
                TsiWebTaskCheckListResponse result = apiInstance.TasksUpdateTaskCheckListItem(taskNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksUpdateTaskCheckListItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskNumber** | **int?**| The task number. | 
 **model** | [**TsiWebUpdateTaskCheckListModel**](TsiWebUpdateTaskCheckListModel.md)| The task. | 

### Return type

[**TsiWebTaskCheckListResponse**](TsiWebTaskCheckListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

