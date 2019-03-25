# IO.Swagger.Api.OpportunityApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OpportunityAdvancedSearch**](OpportunityApi.md#opportunityadvancedsearch) | **POST** /api/opportunities/search | Advanced search for opportunities.
[**OpportunityCreateOpportunity**](OpportunityApi.md#opportunitycreateopportunity) | **POST** /api/opportunities | Creates the opportunity.
[**OpportunityCreateOpportunityDocument**](OpportunityApi.md#opportunitycreateopportunitydocument) | **POST** /api/opportunities/{opportunityNumber}/documents | Creates the opportunity document.
[**OpportunityGetAccountOpportunities**](OpportunityApi.md#opportunitygetaccountopportunities) | **GET** /api/opportunities/account/{accountNumber} | Gets a list of opportunities by account number.
[**OpportunityGetContactOpportunities**](OpportunityApi.md#opportunitygetcontactopportunities) | **GET** /api/opportunities/contact/{contactNumber} | Gets a list of opportunities by contact number.
[**OpportunityGetCustomFields**](OpportunityApi.md#opportunitygetcustomfields) | **GET** /api/opportunities/{opportunityNumber}/customfields | Gets the custom fields for the opportunity.
[**OpportunityGetFile**](OpportunityApi.md#opportunitygetfile) | **GET** /api/opportunities/{opportunityNumber}/documents/{documentID}/file | Gets the opportunity document file.
[**OpportunityGetOpportunityCompletedTasks**](OpportunityApi.md#opportunitygetopportunitycompletedtasks) | **GET** /api/opportunities/{OpportunityNumber}/tasks/completed | Gets the Opportunity completed tasks.
[**OpportunityGetOpportunityDetail**](OpportunityApi.md#opportunitygetopportunitydetail) | **GET** /api/opportunities/{opportunityNumber}/details | Gets the opportunity detail.
[**OpportunityGetOpportunityDocument**](OpportunityApi.md#opportunitygetopportunitydocument) | **GET** /api/opportunities/{opportunityNumber}/documents/{documentID} | Gets the account document with the file bytes.
[**OpportunityGetOpportunityDocuments**](OpportunityApi.md#opportunitygetopportunitydocuments) | **GET** /api/opportunities/{opportunityNumber}/documents | Gets the opportunity documents.
[**OpportunityGetOpportunityIncompleteTasks**](OpportunityApi.md#opportunitygetopportunityincompletetasks) | **GET** /api/opportunities/{OpportunityNumber}/tasks | Gets the Opportunity incomplete tasks.
[**OpportunityGetOpportunitySummary**](OpportunityApi.md#opportunitygetopportunitysummary) | **GET** /api/opportunities/{opportunityNumber} | Gets the opportunity summary.
[**OpportunityGetOpportunityTasks**](OpportunityApi.md#opportunitygetopportunitytasks) | **GET** /api/opportunities/{OpportunityNumber}/tasks/all | Gets the Opportunity tasks. Includes both completed and incomplete tasks.
[**OpportunityGetOwnerOpportunities**](OpportunityApi.md#opportunitygetowneropportunities) | **GET** /api/opportunities/owner/{repNumber} | Gets a list of opportunities by owner (Rep).
[**OpportunitySearchByAccountName**](OpportunityApi.md#opportunitysearchbyaccountname) | **POST** /api/opportunities/search/account | Searches opportunities by account name.
[**OpportunitySearchByContactName**](OpportunityApi.md#opportunitysearchbycontactname) | **POST** /api/opportunities/search/contact | Searches opportunities by contact name.
[**OpportunitySearchByCustomField**](OpportunityApi.md#opportunitysearchbycustomfield) | **POST** /api/opportunities/search/customfield | Search Opportunities using a custom category and field label.
[**OpportunitySearchByName**](OpportunityApi.md#opportunitysearchbyname) | **POST** /api/opportunities/search/name | Searches opportunities by opportuniyt name.
[**OpportunitySearchByNumber**](OpportunityApi.md#opportunitysearchbynumber) | **POST** /api/opportunities/search/number | Searches opportunities by opportunity number.
[**OpportunitySetOpportunityDocumentFile**](OpportunityApi.md#opportunitysetopportunitydocumentfile) | **PUT** /api/opportunities/{opportunityNumber}/documents/{documentID}/overwrite | Overwrites the opportuntiy document physical file, does not rename the file.
[**OpportunitySetOpportunityDocumentFileName**](OpportunityApi.md#opportunitysetopportunitydocumentfilename) | **PUT** /api/opportunities/{opportunityNumber}/documents/{documentID}/rename | Sets the documents file name and renames the associated file.
[**OpportunityUpdateCustomFields**](OpportunityApi.md#opportunityupdatecustomfields) | **PUT** /api/opportunities/{opportunityNumber}/customfields | Updates the opportunity custom fields.
[**OpportunityUpdateOpportunity**](OpportunityApi.md#opportunityupdateopportunity) | **PUT** /api/opportunities/{opportunityNumber} | Updates the opportunity.
[**OpportunityUpdateOpportunityDocumentProperties**](OpportunityApi.md#opportunityupdateopportunitydocumentproperties) | **PUT** /api/opportunities/{opportunityNumber}/documents/{documentID} | Updates the account document information. Does not allow the file name property to be changed.


<a name="opportunityadvancedsearch"></a>
# **OpportunityAdvancedSearch**
> TsiWebSearchOpportunityResponse OpportunityAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for opportunities.

<p>Valid SearchType = Name, Number, AccountName, ContactName, CustomField (requires CategoryName and CustomFieldName)</p>  <p>Valid MatchType = StartsWith (default), EndsWith, Contains, GreaterThan, GreaterThanEqual, Equal, LessThan, LessThanEqual</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for opportunities.
                TsiWebSearchOpportunityResponse result = apiInstance.OpportunityAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityAdvancedSearch: " + e.Message );
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

[**TsiWebSearchOpportunityResponse**](TsiWebSearchOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitycreateopportunity"></a>
# **OpportunityCreateOpportunity**
> TsiWebOpportunityResponse OpportunityCreateOpportunity (TsiWebOpportunity opportunity)

Creates the opportunity.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityCreateOpportunityExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunity = new TsiWebOpportunity(); // TsiWebOpportunity | The opportunity.

            try
            {
                // Creates the opportunity.
                TsiWebOpportunityResponse result = apiInstance.OpportunityCreateOpportunity(opportunity);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityCreateOpportunity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunity** | [**TsiWebOpportunity**](TsiWebOpportunity.md)| The opportunity. | 

### Return type

[**TsiWebOpportunityResponse**](TsiWebOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitycreateopportunitydocument"></a>
# **OpportunityCreateOpportunityDocument**
> TsiWebDocumentResponse OpportunityCreateOpportunityDocument (int? opportunityNumber)

Creates the opportunity document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityCreateOpportunityDocumentExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity number.

            try
            {
                // Creates the opportunity document.
                TsiWebDocumentResponse result = apiInstance.OpportunityCreateOpportunityDocument(opportunityNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityCreateOpportunityDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 

### Return type

[**TsiWebDocumentResponse**](TsiWebDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitygetaccountopportunities"></a>
# **OpportunityGetAccountOpportunities**
> TsiWebSearchOpportunityResponse OpportunityGetAccountOpportunities (int? accountNumber)

Gets a list of opportunities by account number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityGetAccountOpportunitiesExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var accountNumber = 56;  // int? | The account number.

            try
            {
                // Gets a list of opportunities by account number.
                TsiWebSearchOpportunityResponse result = apiInstance.OpportunityGetAccountOpportunities(accountNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetAccountOpportunities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 

### Return type

[**TsiWebSearchOpportunityResponse**](TsiWebSearchOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitygetcontactopportunities"></a>
# **OpportunityGetContactOpportunities**
> TsiWebSearchOpportunityResponse OpportunityGetContactOpportunities (int? contactNumber)

Gets a list of opportunities by contact number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityGetContactOpportunitiesExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var contactNumber = 56;  // int? | The contact number.

            try
            {
                // Gets a list of opportunities by contact number.
                TsiWebSearchOpportunityResponse result = apiInstance.OpportunityGetContactOpportunities(contactNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetContactOpportunities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contactNumber** | **int?**| The contact number. | 

### Return type

[**TsiWebSearchOpportunityResponse**](TsiWebSearchOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitygetcustomfields"></a>
# **OpportunityGetCustomFields**
> List<TsiWebCustomField> OpportunityGetCustomFields (int? opportunityNumber)

Gets the custom fields for the opportunity.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityGetCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity number.

            try
            {
                // Gets the custom fields for the opportunity.
                List&lt;TsiWebCustomField&gt; result = apiInstance.OpportunityGetCustomFields(opportunityNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 

### Return type

[**List<TsiWebCustomField>**](TsiWebCustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitygetfile"></a>
# **OpportunityGetFile**
> Object OpportunityGetFile (int? opportunityNumber, int? documentID)

Gets the opportunity document file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityGetFileExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Gets the opportunity document file.
                Object result = apiInstance.OpportunityGetFile(opportunityNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitygetopportunitycompletedtasks"></a>
# **OpportunityGetOpportunityCompletedTasks**
> TsiWebTasksResponse OpportunityGetOpportunityCompletedTasks (int? opportunityNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Opportunity completed tasks.

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
    public class OpportunityGetOpportunityCompletedTasksExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The Opportunity number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Opportunity completed tasks.
                TsiWebTasksResponse result = apiInstance.OpportunityGetOpportunityCompletedTasks(opportunityNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetOpportunityCompletedTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The Opportunity number. | 
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

<a name="opportunitygetopportunitydetail"></a>
# **OpportunityGetOpportunityDetail**
> TsiWebOpportunityDetail OpportunityGetOpportunityDetail (int? opportunityNumber)

Gets the opportunity detail.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityGetOpportunityDetailExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity identifier number.

            try
            {
                // Gets the opportunity detail.
                TsiWebOpportunityDetail result = apiInstance.OpportunityGetOpportunityDetail(opportunityNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetOpportunityDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity identifier number. | 

### Return type

[**TsiWebOpportunityDetail**](TsiWebOpportunityDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitygetopportunitydocument"></a>
# **OpportunityGetOpportunityDocument**
> TsiWebDocumentSummary OpportunityGetOpportunityDocument (int? opportunityNumber, int? documentID)

Gets the account document with the file bytes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityGetOpportunityDocumentExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Gets the account document with the file bytes.
                TsiWebDocumentSummary result = apiInstance.OpportunityGetOpportunityDocument(opportunityNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetOpportunityDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

[**TsiWebDocumentSummary**](TsiWebDocumentSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitygetopportunitydocuments"></a>
# **OpportunityGetOpportunityDocuments**
> TsiWebDocumentsResponse OpportunityGetOpportunityDocuments (int? opportunityNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the opportunity documents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityGetOpportunityDocumentsExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the opportunity documents.
                TsiWebDocumentsResponse result = apiInstance.OpportunityGetOpportunityDocuments(opportunityNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetOpportunityDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebDocumentsResponse**](TsiWebDocumentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitygetopportunityincompletetasks"></a>
# **OpportunityGetOpportunityIncompleteTasks**
> TsiWebTasksResponse OpportunityGetOpportunityIncompleteTasks (int? opportunityNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Opportunity incomplete tasks.

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
    public class OpportunityGetOpportunityIncompleteTasksExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The Opportunity number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Opportunity incomplete tasks.
                TsiWebTasksResponse result = apiInstance.OpportunityGetOpportunityIncompleteTasks(opportunityNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetOpportunityIncompleteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The Opportunity number. | 
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

<a name="opportunitygetopportunitysummary"></a>
# **OpportunityGetOpportunitySummary**
> TsiWebOpportunitySummary OpportunityGetOpportunitySummary (int? opportunityNumber)

Gets the opportunity summary.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityGetOpportunitySummaryExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity identifier number.

            try
            {
                // Gets the opportunity summary.
                TsiWebOpportunitySummary result = apiInstance.OpportunityGetOpportunitySummary(opportunityNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetOpportunitySummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity identifier number. | 

### Return type

[**TsiWebOpportunitySummary**](TsiWebOpportunitySummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitygetopportunitytasks"></a>
# **OpportunityGetOpportunityTasks**
> TsiWebTasksResponse OpportunityGetOpportunityTasks (int? opportunityNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the Opportunity tasks. Includes both completed and incomplete tasks.

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
    public class OpportunityGetOpportunityTasksExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The Opportunity number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the Opportunity tasks. Includes both completed and incomplete tasks.
                TsiWebTasksResponse result = apiInstance.OpportunityGetOpportunityTasks(opportunityNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetOpportunityTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The Opportunity number. | 
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

<a name="opportunitygetowneropportunities"></a>
# **OpportunityGetOwnerOpportunities**
> TsiWebSearchOpportunityResponse OpportunityGetOwnerOpportunities (int? repNumber)

Gets a list of opportunities by owner (Rep).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityGetOwnerOpportunitiesExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var repNumber = 56;  // int? | The owner rep number.

            try
            {
                // Gets a list of opportunities by owner (Rep).
                TsiWebSearchOpportunityResponse result = apiInstance.OpportunityGetOwnerOpportunities(repNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityGetOwnerOpportunities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repNumber** | **int?**| The owner rep number. | 

### Return type

[**TsiWebSearchOpportunityResponse**](TsiWebSearchOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitysearchbyaccountname"></a>
# **OpportunitySearchByAccountName**
> TsiWebSearchOpportunityResponse OpportunitySearchByAccountName (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches opportunities by account name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunitySearchByAccountNameExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var criteria = criteria_example;  // string | The criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches opportunities by account name.
                TsiWebSearchOpportunityResponse result = apiInstance.OpportunitySearchByAccountName(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunitySearchByAccountName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| The criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchOpportunityResponse**](TsiWebSearchOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitysearchbycontactname"></a>
# **OpportunitySearchByContactName**
> TsiWebSearchOpportunityResponse OpportunitySearchByContactName (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches opportunities by contact name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunitySearchByContactNameExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var criteria = criteria_example;  // string | The criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches opportunities by contact name.
                TsiWebSearchOpportunityResponse result = apiInstance.OpportunitySearchByContactName(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunitySearchByContactName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| The criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchOpportunityResponse**](TsiWebSearchOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitysearchbycustomfield"></a>
# **OpportunitySearchByCustomField**
> TsiWebSearchOpportunityResponse OpportunitySearchByCustomField (TsiWebCustomFieldSearchModel searchModel, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Opportunities using a custom category and field label.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunitySearchByCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var searchModel = new TsiWebCustomFieldSearchModel(); // TsiWebCustomFieldSearchModel | A JSON or XML request containing the category, field and criteria to search for.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Opportunities using a custom category and field label.
                TsiWebSearchOpportunityResponse result = apiInstance.OpportunitySearchByCustomField(searchModel, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunitySearchByCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchModel** | [**TsiWebCustomFieldSearchModel**](TsiWebCustomFieldSearchModel.md)| A JSON or XML request containing the category, field and criteria to search for. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchOpportunityResponse**](TsiWebSearchOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitysearchbyname"></a>
# **OpportunitySearchByName**
> TsiWebSearchOpportunityResponse OpportunitySearchByName (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches opportunities by opportuniyt name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunitySearchByNameExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var criteria = criteria_example;  // string | The criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches opportunities by opportuniyt name.
                TsiWebSearchOpportunityResponse result = apiInstance.OpportunitySearchByName(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunitySearchByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| The criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchOpportunityResponse**](TsiWebSearchOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitysearchbynumber"></a>
# **OpportunitySearchByNumber**
> TsiWebSearchOpportunityResponse OpportunitySearchByNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Searches opportunities by opportunity number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunitySearchByNumberExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var criteria = criteria_example;  // string | The criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Searches opportunities by opportunity number.
                TsiWebSearchOpportunityResponse result = apiInstance.OpportunitySearchByNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunitySearchByNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| The criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchOpportunityResponse**](TsiWebSearchOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitysetopportunitydocumentfile"></a>
# **OpportunitySetOpportunityDocumentFile**
> TsiWebResponse OpportunitySetOpportunityDocumentFile (int? opportunityNumber, int? documentID)

Overwrites the opportuntiy document physical file, does not rename the file.

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
    public class OpportunitySetOpportunityDocumentFileExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Overwrites the opportuntiy document physical file, does not rename the file.
                TsiWebResponse result = apiInstance.OpportunitySetOpportunityDocumentFile(opportunityNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunitySetOpportunityDocumentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunitysetopportunitydocumentfilename"></a>
# **OpportunitySetOpportunityDocumentFileName**
> TsiWebDocumentResponse OpportunitySetOpportunityDocumentFileName (int? opportunityNumber, int? documentID, string fileName)

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
    public class OpportunitySetOpportunityDocumentFileNameExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity number.
            var documentID = 56;  // int? | The document identifier.
            var fileName = fileName_example;  // string | Name of the file.

            try
            {
                // Sets the documents file name and renames the associated file.
                TsiWebDocumentResponse result = apiInstance.OpportunitySetOpportunityDocumentFileName(opportunityNumber, documentID, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunitySetOpportunityDocumentFileName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 
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

<a name="opportunityupdatecustomfields"></a>
# **OpportunityUpdateCustomFields**
> TsiWebCustomFieldsResponse OpportunityUpdateCustomFields (int? opportunityNumber, List<TsiWebCustomField> customFields)

Updates the opportunity custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityUpdateCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity number.
            var customFields = new List<TsiWebCustomField>(); // List<TsiWebCustomField> | The custom fields.

            try
            {
                // Updates the opportunity custom fields.
                TsiWebCustomFieldsResponse result = apiInstance.OpportunityUpdateCustomFields(opportunityNumber, customFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityUpdateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 
 **customFields** | [**List&lt;TsiWebCustomField&gt;**](TsiWebCustomField.md)| The custom fields. | 

### Return type

[**TsiWebCustomFieldsResponse**](TsiWebCustomFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunityupdateopportunity"></a>
# **OpportunityUpdateOpportunity**
> TsiWebOpportunityResponse OpportunityUpdateOpportunity (int? opportunityNumber, TsiWebOpportunity opportunity)

Updates the opportunity.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityUpdateOpportunityExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity number.
            var opportunity = new TsiWebOpportunity(); // TsiWebOpportunity | The opportunity.

            try
            {
                // Updates the opportunity.
                TsiWebOpportunityResponse result = apiInstance.OpportunityUpdateOpportunity(opportunityNumber, opportunity);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityUpdateOpportunity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 
 **opportunity** | [**TsiWebOpportunity**](TsiWebOpportunity.md)| The opportunity. | 

### Return type

[**TsiWebOpportunityResponse**](TsiWebOpportunityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="opportunityupdateopportunitydocumentproperties"></a>
# **OpportunityUpdateOpportunityDocumentProperties**
> TsiWebDocumentResponse OpportunityUpdateOpportunityDocumentProperties (int? opportunityNumber, int? documentID, TsiWebAreasWebApiUpdateDocumentModel request)

Updates the account document information. Does not allow the file name property to be changed.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class OpportunityUpdateOpportunityDocumentPropertiesExample
    {
        public void main()
        {
            var apiInstance = new OpportunityApi();
            var opportunityNumber = 56;  // int? | The opportunity number.
            var documentID = 56;  // int? | The document identifier.
            var request = new TsiWebAreasWebApiUpdateDocumentModel(); // TsiWebAreasWebApiUpdateDocumentModel | The request.

            try
            {
                // Updates the account document information. Does not allow the file name property to be changed.
                TsiWebDocumentResponse result = apiInstance.OpportunityUpdateOpportunityDocumentProperties(opportunityNumber, documentID, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OpportunityApi.OpportunityUpdateOpportunityDocumentProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 
 **documentID** | **int?**| The document identifier. | 
 **request** | [**TsiWebAreasWebApiUpdateDocumentModel**](TsiWebAreasWebApiUpdateDocumentModel.md)| The request. | 

### Return type

[**TsiWebDocumentResponse**](TsiWebDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

