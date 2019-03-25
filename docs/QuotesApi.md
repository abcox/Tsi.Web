# IO.Swagger.Api.QuotesApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QuotesAddQuoteToExistingServiceOrder**](QuotesApi.md#quotesaddquotetoexistingserviceorder) | **PUT** /api/quotes/{quoteNumber}/convert/serviceOrder/{serviceOrderNumber} | Adds a quote to an existing service order.
[**QuotesAddQuoteToNewServiceOrder**](QuotesApi.md#quotesaddquotetonewserviceorder) | **POST** /api/quotes/{quoteNumber}/convert/serviceOrder | Adds a quote to a new service order.
[**QuotesAdvancedSearch**](QuotesApi.md#quotesadvancedsearch) | **POST** /api/quotes/items/search | Advanced search for Quotes.
[**QuotesConvertQuoteToWorkOrder**](QuotesApi.md#quotesconvertquotetoworkorder) | **POST** /api/quotes/{quoteNumber}/convert/workOrder | Converts a quote into a work order.
[**QuotesCreateQuote**](QuotesApi.md#quotescreatequote) | **POST** /api/Quotes | Creates a quote.
[**QuotesCreateQuoteDetailComment**](QuotesApi.md#quotescreatequotedetailcomment) | **POST** /api/quotes/{quoteNumber}/details/comments | Creates the quote detail comment.
[**QuotesCreateQuoteDetailItem**](QuotesApi.md#quotescreatequotedetailitem) | **POST** /api/quotes/{quoteNumber}/details/items/stock | Creates the quote detail item from a price book item.
[**QuotesCreateQuoteDetailNonStock**](QuotesApi.md#quotescreatequotedetailnonstock) | **POST** /api/quotes/{quoteNumber}/details/items/nonstock | Creates the quote detail using a non stock item.
[**QuotesCreateQuoteDetailSubtotal**](QuotesApi.md#quotescreatequotedetailsubtotal) | **POST** /api/quotes/{quoteNumber}/details/subtotals | Creates the quote detail subtotal.
[**QuotesCreateQuoteDocument**](QuotesApi.md#quotescreatequotedocument) | **POST** /api/quotes/{quoteNumber}/documents | Creates the quote document.
[**QuotesCreateQuoteNote**](QuotesApi.md#quotescreatequotenote) | **POST** /api/quotes/{quoteNumber}/notes | Creates a quote note.
[**QuotesDeleteQuoteDetail**](QuotesApi.md#quotesdeletequotedetail) | **DELETE** /api/quotes/{quoteNumber}/details/{quoteDetailNumber} | Deletes the quote detail.
[**QuotesGetAccountQuotes**](QuotesApi.md#quotesgetaccountquotes) | **GET** /api/quotes/account/{accountNumber} | Gets the quotes for an account.
[**QuotesGetAccountQuotes_0**](QuotesApi.md#quotesgetaccountquotes_0) | **GET** /api/quotes/account/{accountNumber}/{openOnly} | Gets the quotes for an account.
[**QuotesGetCustomFields**](QuotesApi.md#quotesgetcustomfields) | **GET** /api/quotes/{quoteNumber}/customfields | Gets the custom fields for a quote.
[**QuotesGetFile**](QuotesApi.md#quotesgetfile) | **GET** /api/quotes/{quoteNumber}/documents/{documentID}/file | Gets the quote document file.
[**QuotesGetOpportunityQuotes**](QuotesApi.md#quotesgetopportunityquotes) | **GET** /api/quotes/opportunity/{opportunityNumber} | Gets the quotes for an opportunity.
[**QuotesGetOpportunityQuotes_0**](QuotesApi.md#quotesgetopportunityquotes_0) | **GET** /api/quotes/opportunity/{opportunityNumber}/{openOnly} | Gets the quotes for an opportunity.
[**QuotesGetQuoteCompletedTasks**](QuotesApi.md#quotesgetquotecompletedtasks) | **GET** /api/quotes/{QuoteNumber}/tasks/completed | Gets the quote completed tasks.
[**QuotesGetQuoteDetail**](QuotesApi.md#quotesgetquotedetail) | **GET** /api/quotes/{quoteNumber}/details | Gets the quote details.
[**QuotesGetQuoteDocument**](QuotesApi.md#quotesgetquotedocument) | **GET** /api/quotes/{quoteNumber}/documents/{documentID} | Gets a document for a quote.
[**QuotesGetQuoteDocuments**](QuotesApi.md#quotesgetquotedocuments) | **GET** /api/quotes/{quoteNumber}/documents | Gets the documents for a quote.
[**QuotesGetQuoteIncompleteTasks**](QuotesApi.md#quotesgetquoteincompletetasks) | **GET** /api/quotes/{QuoteNumber}/tasks | Gets the quote incomplete tasks.
[**QuotesGetQuoteNotes**](QuotesApi.md#quotesgetquotenotes) | **GET** /api/quotes/{quoteNumber}/notes | Gets the quote notes.
[**QuotesGetQuoteRelatedDocuments**](QuotesApi.md#quotesgetquoterelateddocuments) | **GET** /api/quotes/{quoteNumber}/relateddocuments | Gets the related documents for the quote.
[**QuotesGetQuoteSummary**](QuotesApi.md#quotesgetquotesummary) | **GET** /api/quotes/{quoteNumber} | Gets a summary of the quote.
[**QuotesGetQuoteTasks**](QuotesApi.md#quotesgetquotetasks) | **GET** /api/quotes/{QuoteNumber}/tasks/all | Gets the quote tasks. Includes both completed and incomplete tasks.
[**QuotesSearchByCustomField**](QuotesApi.md#quotessearchbycustomfield) | **POST** /api/quotes/search/customfield | Search Quotes using a custom category and field label.
[**QuotesSearchByCustomerPurchaseOrder**](QuotesApi.md#quotessearchbycustomerpurchaseorder) | **POST** /api/quotes/search/customerpo | Search Quotes by customer purchase order.
[**QuotesSearchByItemDescription**](QuotesApi.md#quotessearchbyitemdescription) | **POST** /api/quotes/search/itemdescription | Search Quotes by item description.
[**QuotesSearchByItemId**](QuotesApi.md#quotessearchbyitemid) | **POST** /api/quotes/search/itemid | Search Quotes by item id.
[**QuotesSearchByJob**](QuotesApi.md#quotessearchbyjob) | **POST** /api/quotes/search/job | Search Quotes by Job.
[**QuotesSearchByQuoteNumber**](QuotesApi.md#quotessearchbyquotenumber) | **POST** /api/quotes/search/quotenumber | Search Quotes by quote number.
[**QuotesSetQuoteDocumentFile**](QuotesApi.md#quotessetquotedocumentfile) | **PUT** /api/quotes/{quoteNumber}/documents/{documentID}/overwrite | Overwrites the quote document physical file, does not rename the file.
[**QuotesSetQuoteDocumentFileName**](QuotesApi.md#quotessetquotedocumentfilename) | **PUT** /api/quotes/{quoteNumber}/documents/{documentID}/rename | Sets the name of the quote document file.
[**QuotesUpdateCustomFields**](QuotesApi.md#quotesupdatecustomfields) | **PUT** /api/quotes/{quoteNumber}/customfields | Updates the custom fields for a quote.
[**QuotesUpdateQuote**](QuotesApi.md#quotesupdatequote) | **PUT** /api/quotes/{quoteNumber} | Updates the quote.
[**QuotesUpdateQuoteDetailComment**](QuotesApi.md#quotesupdatequotedetailcomment) | **PUT** /api/quotes/{quoteNumber}/details/comments/{quoteDetailNumber} | Updates the quote detail comment.
[**QuotesUpdateQuoteDetailInstallLocation**](QuotesApi.md#quotesupdatequotedetailinstalllocation) | **PUT** /api/quotes/{quoteNumber}/details/installlocation/{quoteDetailNumber} | Updates the quote detail install location.
[**QuotesUpdateQuoteDetailItem**](QuotesApi.md#quotesupdatequotedetailitem) | **PUT** /api/quotes/{quoteNumber}/details/items/{quoteDetailNumber} | Updates quote stock and non stock detail items.
[**QuotesUpdateQuoteDetailSubtotal**](QuotesApi.md#quotesupdatequotedetailsubtotal) | **PUT** /api/quotes/{quoteNumber}/details/subtotals/{quoteDetailNumber} | Updates the quote detail subtotal.
[**QuotesUpdateQuoteDocumentProperties**](QuotesApi.md#quotesupdatequotedocumentproperties) | **PUT** /api/quotes/{quoteNumber}/documents/{documentID} | Updates the quote document properties.
[**QuotesUpdateQuoteNote**](QuotesApi.md#quotesupdatequotenote) | **PUT** /api/quotes/{quoteNumber}/notes/{quoteNoteNumber} | Updates an existing quote note.


<a name="quotesaddquotetoexistingserviceorder"></a>
# **QuotesAddQuoteToExistingServiceOrder**
> TsiWebQuoteToServiceOrderResponse QuotesAddQuoteToExistingServiceOrder (int? quoteNumber, int? serviceOrderNumber, TsiWebAddQuoteToExistingServiceOrderModel model)

Adds a quote to an existing service order.

QuoteToSOtype value must be one of: \"AllItemsOnQuote\", \"AllItemsInPhase\", \"SpecificItemsOnQuote\", \"SpecificItemsInPhase\".<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesAddQuoteToExistingServiceOrderExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var serviceOrderNumber = 56;  // int? | The service order number.
            var model = new TsiWebAddQuoteToExistingServiceOrderModel(); // TsiWebAddQuoteToExistingServiceOrderModel | The model.

            try
            {
                // Adds a quote to an existing service order.
                TsiWebQuoteToServiceOrderResponse result = apiInstance.QuotesAddQuoteToExistingServiceOrder(quoteNumber, serviceOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesAddQuoteToExistingServiceOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **serviceOrderNumber** | **int?**| The service order number. | 
 **model** | [**TsiWebAddQuoteToExistingServiceOrderModel**](TsiWebAddQuoteToExistingServiceOrderModel.md)| The model. | 

### Return type

[**TsiWebQuoteToServiceOrderResponse**](TsiWebQuoteToServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesaddquotetonewserviceorder"></a>
# **QuotesAddQuoteToNewServiceOrder**
> TsiWebQuoteToServiceOrderResponse QuotesAddQuoteToNewServiceOrder (int? quoteNumber, TsiWebAddQuoteToNewServiceOrderModel model)

Adds a quote to a new service order.

The \"QuoteToSOtype\" value must be one of: \"AllItemsOnQuote\", \"AllItemsInPhase\", \"SpecificItemsOnQuote\", \"SpecificItemsInPhase\".<br /><p>The field NewServiceOrderPhaseNumber is used to indicate the name phase whihch you would like the Service Order to be on, if left empty the phase from the quote will be used.</p><p>The ProjectPhaseNumber is used to indicate the phase used for AllItemsInPhase or SpecificItemsInPhase.</p><p>DateTimeRequested is an optional SplitDateTime type. Json format is \"DateTimeRequested\":{\"Date\":\"2018-03-06T00:00:00\", \"Time\":\"1900-01-01T14:09:02\"}</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesAddQuoteToNewServiceOrderExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | 
            var model = new TsiWebAddQuoteToNewServiceOrderModel(); // TsiWebAddQuoteToNewServiceOrderModel | 

            try
            {
                // Adds a quote to a new service order.
                TsiWebQuoteToServiceOrderResponse result = apiInstance.QuotesAddQuoteToNewServiceOrder(quoteNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesAddQuoteToNewServiceOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**|  | 
 **model** | [**TsiWebAddQuoteToNewServiceOrderModel**](TsiWebAddQuoteToNewServiceOrderModel.md)|  | 

### Return type

[**TsiWebQuoteToServiceOrderResponse**](TsiWebQuoteToServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesadvancedsearch"></a>
# **QuotesAdvancedSearch**
> TsiWebSearchQuotesResponse QuotesAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for Quotes.

Valid SearchType = QuoteNumber, Job, ItemId, ItemDescription, CustomerPO, CustomField (requires CategoryName and CustomFieldName)  <p>Valid MatchType = StartsWith (default), EndsWith, Contains, GreaterThan, GreaterThanEqual, Equal, LessThan, LessThanEqual</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for Quotes.
                TsiWebSearchQuotesResponse result = apiInstance.QuotesAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesAdvancedSearch: " + e.Message );
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

[**TsiWebSearchQuotesResponse**](TsiWebSearchQuotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesconvertquotetoworkorder"></a>
# **QuotesConvertQuoteToWorkOrder**
> TsiWebWorkOrderResponse QuotesConvertQuoteToWorkOrder (int? quoteNumber)

Converts a quote into a work order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesConvertQuoteToWorkOrderExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | 

            try
            {
                // Converts a quote into a work order.
                TsiWebWorkOrderResponse result = apiInstance.QuotesConvertQuoteToWorkOrder(quoteNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesConvertQuoteToWorkOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**|  | 

### Return type

[**TsiWebWorkOrderResponse**](TsiWebWorkOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotescreatequote"></a>
# **QuotesCreateQuote**
> TsiWebQuoteResponse QuotesCreateQuote (TsiWebCreateQuoteModel request)

Creates a quote.

AccountNumber should be the account the quote is for.  <p>To duplicate a quote set the ExistingQuoteNumber.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesCreateQuoteExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var request = new TsiWebCreateQuoteModel(); // TsiWebCreateQuoteModel | The request used to create the quote.

            try
            {
                // Creates a quote.
                TsiWebQuoteResponse result = apiInstance.QuotesCreateQuote(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesCreateQuote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**TsiWebCreateQuoteModel**](TsiWebCreateQuoteModel.md)| The request used to create the quote. | 

### Return type

[**TsiWebQuoteResponse**](TsiWebQuoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotescreatequotedetailcomment"></a>
# **QuotesCreateQuoteDetailComment**
> TsiWebQuoteDetailResponse QuotesCreateQuoteDetailComment (int? quoteNumber, TsiWebCreateQuoteDetailCommentModel model)

Creates the quote detail comment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesCreateQuoteDetailCommentExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var model = new TsiWebCreateQuoteDetailCommentModel(); // TsiWebCreateQuoteDetailCommentModel | 

            try
            {
                // Creates the quote detail comment.
                TsiWebQuoteDetailResponse result = apiInstance.QuotesCreateQuoteDetailComment(quoteNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesCreateQuoteDetailComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **model** | [**TsiWebCreateQuoteDetailCommentModel**](TsiWebCreateQuoteDetailCommentModel.md)|  | 

### Return type

[**TsiWebQuoteDetailResponse**](TsiWebQuoteDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotescreatequotedetailitem"></a>
# **QuotesCreateQuoteDetailItem**
> TsiWebQuoteDetailResponse QuotesCreateQuoteDetailItem (int? quoteNumber, TsiWebCreateQuoteDetailItemModel model)

Creates the quote detail item from a price book item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesCreateQuoteDetailItemExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var model = new TsiWebCreateQuoteDetailItemModel(); // TsiWebCreateQuoteDetailItemModel | 

            try
            {
                // Creates the quote detail item from a price book item.
                TsiWebQuoteDetailResponse result = apiInstance.QuotesCreateQuoteDetailItem(quoteNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesCreateQuoteDetailItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **model** | [**TsiWebCreateQuoteDetailItemModel**](TsiWebCreateQuoteDetailItemModel.md)|  | 

### Return type

[**TsiWebQuoteDetailResponse**](TsiWebQuoteDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotescreatequotedetailnonstock"></a>
# **QuotesCreateQuoteDetailNonStock**
> TsiWebQuoteDetailResponse QuotesCreateQuoteDetailNonStock (int? quoteNumber, TsiWebCreateQuoteDetailNonStockModel model)

Creates the quote detail using a non stock item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesCreateQuoteDetailNonStockExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var model = new TsiWebCreateQuoteDetailNonStockModel(); // TsiWebCreateQuoteDetailNonStockModel | 

            try
            {
                // Creates the quote detail using a non stock item.
                TsiWebQuoteDetailResponse result = apiInstance.QuotesCreateQuoteDetailNonStock(quoteNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesCreateQuoteDetailNonStock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **model** | [**TsiWebCreateQuoteDetailNonStockModel**](TsiWebCreateQuoteDetailNonStockModel.md)|  | 

### Return type

[**TsiWebQuoteDetailResponse**](TsiWebQuoteDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotescreatequotedetailsubtotal"></a>
# **QuotesCreateQuoteDetailSubtotal**
> TsiWebQuoteDetailResponse QuotesCreateQuoteDetailSubtotal (int? quoteNumber, TsiWebCreateQuoteDetailSubTotalModel model)

Creates the quote detail subtotal.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesCreateQuoteDetailSubtotalExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var model = new TsiWebCreateQuoteDetailSubTotalModel(); // TsiWebCreateQuoteDetailSubTotalModel | 

            try
            {
                // Creates the quote detail subtotal.
                TsiWebQuoteDetailResponse result = apiInstance.QuotesCreateQuoteDetailSubtotal(quoteNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesCreateQuoteDetailSubtotal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **model** | [**TsiWebCreateQuoteDetailSubTotalModel**](TsiWebCreateQuoteDetailSubTotalModel.md)|  | 

### Return type

[**TsiWebQuoteDetailResponse**](TsiWebQuoteDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotescreatequotedocument"></a>
# **QuotesCreateQuoteDocument**
> TsiWebDocumentResponse QuotesCreateQuoteDocument (int? quoteNumber)

Creates the quote document.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesCreateQuoteDocumentExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.

            try
            {
                // Creates the quote document.
                TsiWebDocumentResponse result = apiInstance.QuotesCreateQuoteDocument(quoteNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesCreateQuoteDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 

### Return type

[**TsiWebDocumentResponse**](TsiWebDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotescreatequotenote"></a>
# **QuotesCreateQuoteNote**
> TsiWebQuoteNoteResponse QuotesCreateQuoteNote (int? quoteNumber, TsiWebQuoteNoteModel note)

Creates a quote note.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesCreateQuoteNoteExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var note = new TsiWebQuoteNoteModel(); // TsiWebQuoteNoteModel | The note.

            try
            {
                // Creates a quote note.
                TsiWebQuoteNoteResponse result = apiInstance.QuotesCreateQuoteNote(quoteNumber, note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesCreateQuoteNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **note** | [**TsiWebQuoteNoteModel**](TsiWebQuoteNoteModel.md)| The note. | 

### Return type

[**TsiWebQuoteNoteResponse**](TsiWebQuoteNoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesdeletequotedetail"></a>
# **QuotesDeleteQuoteDetail**
> TsiWebQuoteDetailResponse QuotesDeleteQuoteDetail (int? quoteNumber, int? quoteDetailNumber)

Deletes the quote detail.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesDeleteQuoteDetailExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var quoteDetailNumber = 56;  // int? | The quote detail number.

            try
            {
                // Deletes the quote detail.
                TsiWebQuoteDetailResponse result = apiInstance.QuotesDeleteQuoteDetail(quoteNumber, quoteDetailNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesDeleteQuoteDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **quoteDetailNumber** | **int?**| The quote detail number. | 

### Return type

[**TsiWebQuoteDetailResponse**](TsiWebQuoteDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetaccountquotes"></a>
# **QuotesGetAccountQuotes**
> TsiWebSearchContactResponse QuotesGetAccountQuotes (int? accountNumber, bool? openOnly = null)

Gets the quotes for an account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetAccountQuotesExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var accountNumber = 56;  // int? | The account number.
            var openOnly = true;  // bool? | If set to true returns only the open Quotes. (optional) 

            try
            {
                // Gets the quotes for an account.
                TsiWebSearchContactResponse result = apiInstance.QuotesGetAccountQuotes(accountNumber, openOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetAccountQuotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **openOnly** | **bool?**| If set to true returns only the open Quotes. | [optional] 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetaccountquotes_0"></a>
# **QuotesGetAccountQuotes_0**
> TsiWebSearchContactResponse QuotesGetAccountQuotes_0 (int? accountNumber, bool? openOnly)

Gets the quotes for an account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetAccountQuotes_0Example
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var accountNumber = 56;  // int? | The account number.
            var openOnly = true;  // bool? | If set to true returns only the open Quotes.

            try
            {
                // Gets the quotes for an account.
                TsiWebSearchContactResponse result = apiInstance.QuotesGetAccountQuotes_0(accountNumber, openOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetAccountQuotes_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **openOnly** | **bool?**| If set to true returns only the open Quotes. | 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetcustomfields"></a>
# **QuotesGetCustomFields**
> List<TsiWebCustomField> QuotesGetCustomFields (int? quoteNumber)

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
    public class QuotesGetCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.

            try
            {
                // Gets the custom fields for a quote.
                List&lt;TsiWebCustomField&gt; result = apiInstance.QuotesGetCustomFields(quoteNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 

### Return type

[**List<TsiWebCustomField>**](TsiWebCustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetfile"></a>
# **QuotesGetFile**
> Object QuotesGetFile (int? quoteNumber, int? documentID)

Gets the quote document file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetFileExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Gets the quote document file.
                Object result = apiInstance.QuotesGetFile(quoteNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetopportunityquotes"></a>
# **QuotesGetOpportunityQuotes**
> TsiWebSearchContactResponse QuotesGetOpportunityQuotes (int? opportunityNumber, bool? openOnly = null)

Gets the quotes for an opportunity.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetOpportunityQuotesExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var opportunityNumber = 56;  // int? | The opportunity number.
            var openOnly = true;  // bool? | If set to true returns only the open Quotes. (optional) 

            try
            {
                // Gets the quotes for an opportunity.
                TsiWebSearchContactResponse result = apiInstance.QuotesGetOpportunityQuotes(opportunityNumber, openOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetOpportunityQuotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 
 **openOnly** | **bool?**| If set to true returns only the open Quotes. | [optional] 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetopportunityquotes_0"></a>
# **QuotesGetOpportunityQuotes_0**
> TsiWebSearchContactResponse QuotesGetOpportunityQuotes_0 (int? opportunityNumber, bool? openOnly)

Gets the quotes for an opportunity.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetOpportunityQuotes_0Example
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var opportunityNumber = 56;  // int? | The opportunity number.
            var openOnly = true;  // bool? | If set to true returns only the open Quotes.

            try
            {
                // Gets the quotes for an opportunity.
                TsiWebSearchContactResponse result = apiInstance.QuotesGetOpportunityQuotes_0(opportunityNumber, openOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetOpportunityQuotes_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **opportunityNumber** | **int?**| The opportunity number. | 
 **openOnly** | **bool?**| If set to true returns only the open Quotes. | 

### Return type

[**TsiWebSearchContactResponse**](TsiWebSearchContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetquotecompletedtasks"></a>
# **QuotesGetQuoteCompletedTasks**
> TsiWebTasksResponse QuotesGetQuoteCompletedTasks (int? quoteNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the quote completed tasks.

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
    public class QuotesGetQuoteCompletedTasksExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the quote completed tasks.
                TsiWebTasksResponse result = apiInstance.QuotesGetQuoteCompletedTasks(quoteNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetQuoteCompletedTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
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

<a name="quotesgetquotedetail"></a>
# **QuotesGetQuoteDetail**
> TsiWebQuoteDetail QuotesGetQuoteDetail (int? quoteNumber)

Gets the quote details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetQuoteDetailExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.

            try
            {
                // Gets the quote details.
                TsiWebQuoteDetail result = apiInstance.QuotesGetQuoteDetail(quoteNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetQuoteDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 

### Return type

[**TsiWebQuoteDetail**](TsiWebQuoteDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetquotedocument"></a>
# **QuotesGetQuoteDocument**
> TsiWebDocumentSummary QuotesGetQuoteDocument (int? quoteNumber, int? documentID)

Gets a document for a quote.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetQuoteDocumentExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Gets a document for a quote.
                TsiWebDocumentSummary result = apiInstance.QuotesGetQuoteDocument(quoteNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetQuoteDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

[**TsiWebDocumentSummary**](TsiWebDocumentSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetquotedocuments"></a>
# **QuotesGetQuoteDocuments**
> TsiWebDocumentsResponse QuotesGetQuoteDocuments (int? quoteNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the documents for a quote.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetQuoteDocumentsExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the documents for a quote.
                TsiWebDocumentsResponse result = apiInstance.QuotesGetQuoteDocuments(quoteNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetQuoteDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
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

<a name="quotesgetquoteincompletetasks"></a>
# **QuotesGetQuoteIncompleteTasks**
> TsiWebTasksResponse QuotesGetQuoteIncompleteTasks (int? quoteNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the quote incomplete tasks.

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
    public class QuotesGetQuoteIncompleteTasksExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the quote incomplete tasks.
                TsiWebTasksResponse result = apiInstance.QuotesGetQuoteIncompleteTasks(quoteNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetQuoteIncompleteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
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

<a name="quotesgetquotenotes"></a>
# **QuotesGetQuoteNotes**
> TsiWebQuoteNotesResponse QuotesGetQuoteNotes (int? quoteNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the quote notes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetQuoteNotesExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the quote notes.
                TsiWebQuoteNotesResponse result = apiInstance.QuotesGetQuoteNotes(quoteNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetQuoteNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebQuoteNotesResponse**](TsiWebQuoteNotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetquoterelateddocuments"></a>
# **QuotesGetQuoteRelatedDocuments**
> TsiWebQuoteRelatedDocuments QuotesGetQuoteRelatedDocuments (int? quoteNumber)

Gets the related documents for the quote.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetQuoteRelatedDocumentsExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.

            try
            {
                // Gets the related documents for the quote.
                TsiWebQuoteRelatedDocuments result = apiInstance.QuotesGetQuoteRelatedDocuments(quoteNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetQuoteRelatedDocuments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 

### Return type

[**TsiWebQuoteRelatedDocuments**](TsiWebQuoteRelatedDocuments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetquotesummary"></a>
# **QuotesGetQuoteSummary**
> TsiWebQuoteSummary QuotesGetQuoteSummary (int? quoteNumber)

Gets a summary of the quote.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesGetQuoteSummaryExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.

            try
            {
                // Gets a summary of the quote.
                TsiWebQuoteSummary result = apiInstance.QuotesGetQuoteSummary(quoteNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetQuoteSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 

### Return type

[**TsiWebQuoteSummary**](TsiWebQuoteSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesgetquotetasks"></a>
# **QuotesGetQuoteTasks**
> TsiWebTasksResponse QuotesGetQuoteTasks (int? quoteNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the quote tasks. Includes both completed and incomplete tasks.

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
    public class QuotesGetQuoteTasksExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the quote tasks. Includes both completed and incomplete tasks.
                TsiWebTasksResponse result = apiInstance.QuotesGetQuoteTasks(quoteNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesGetQuoteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
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

<a name="quotessearchbycustomfield"></a>
# **QuotesSearchByCustomField**
> TsiWebSearchQuotesResponse QuotesSearchByCustomField (TsiWebCustomFieldSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Quotes using a custom category and field label.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesSearchByCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var model = new TsiWebCustomFieldSearchModel(); // TsiWebCustomFieldSearchModel | A {Tsi.Web.CustomFieldSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Quotes using a custom category and field label.
                TsiWebSearchQuotesResponse result = apiInstance.QuotesSearchByCustomField(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesSearchByCustomField: " + e.Message );
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

[**TsiWebSearchQuotesResponse**](TsiWebSearchQuotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotessearchbycustomerpurchaseorder"></a>
# **QuotesSearchByCustomerPurchaseOrder**
> TsiWebSearchQuotesResponse QuotesSearchByCustomerPurchaseOrder (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Quotes by customer purchase order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesSearchByCustomerPurchaseOrderExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var criteria = criteria_example;  // string | The criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Quotes by customer purchase order.
                TsiWebSearchQuotesResponse result = apiInstance.QuotesSearchByCustomerPurchaseOrder(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesSearchByCustomerPurchaseOrder: " + e.Message );
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

[**TsiWebSearchQuotesResponse**](TsiWebSearchQuotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotessearchbyitemdescription"></a>
# **QuotesSearchByItemDescription**
> TsiWebSearchQuotesResponse QuotesSearchByItemDescription (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Quotes by item description.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesSearchByItemDescriptionExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Quotes by item description.
                TsiWebSearchQuotesResponse result = apiInstance.QuotesSearchByItemDescription(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesSearchByItemDescription: " + e.Message );
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

[**TsiWebSearchQuotesResponse**](TsiWebSearchQuotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotessearchbyitemid"></a>
# **QuotesSearchByItemId**
> TsiWebSearchQuotesResponse QuotesSearchByItemId (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Quotes by item id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesSearchByItemIdExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var criteria = criteria_example;  // string | The criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Quotes by item id.
                TsiWebSearchQuotesResponse result = apiInstance.QuotesSearchByItemId(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesSearchByItemId: " + e.Message );
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

[**TsiWebSearchQuotesResponse**](TsiWebSearchQuotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotessearchbyjob"></a>
# **QuotesSearchByJob**
> TsiWebSearchQuotesResponse QuotesSearchByJob (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Quotes by Job.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesSearchByJobExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var criteria = criteria_example;  // string | The criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Quotes by Job.
                TsiWebSearchQuotesResponse result = apiInstance.QuotesSearchByJob(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesSearchByJob: " + e.Message );
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

[**TsiWebSearchQuotesResponse**](TsiWebSearchQuotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotessearchbyquotenumber"></a>
# **QuotesSearchByQuoteNumber**
> TsiWebSearchQuotesResponse QuotesSearchByQuoteNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Quotes by quote number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesSearchByQuoteNumberExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var criteria = criteria_example;  // string | The criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Quotes by quote number.
                TsiWebSearchQuotesResponse result = apiInstance.QuotesSearchByQuoteNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesSearchByQuoteNumber: " + e.Message );
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

[**TsiWebSearchQuotesResponse**](TsiWebSearchQuotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotessetquotedocumentfile"></a>
# **QuotesSetQuoteDocumentFile**
> TsiWebResponse QuotesSetQuoteDocumentFile (int? quoteNumber, int? documentID)

Overwrites the quote document physical file, does not rename the file.

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
    public class QuotesSetQuoteDocumentFileExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var documentID = 56;  // int? | The document identifier.

            try
            {
                // Overwrites the quote document physical file, does not rename the file.
                TsiWebResponse result = apiInstance.QuotesSetQuoteDocumentFile(quoteNumber, documentID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesSetQuoteDocumentFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **documentID** | **int?**| The document identifier. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotessetquotedocumentfilename"></a>
# **QuotesSetQuoteDocumentFileName**
> TsiWebDocumentResponse QuotesSetQuoteDocumentFileName (int? quoteNumber, int? documentID, string fileName)

Sets the name of the quote document file.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesSetQuoteDocumentFileNameExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var documentID = 56;  // int? | The document identifier.
            var fileName = fileName_example;  // string | Name of the file.

            try
            {
                // Sets the name of the quote document file.
                TsiWebDocumentResponse result = apiInstance.QuotesSetQuoteDocumentFileName(quoteNumber, documentID, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesSetQuoteDocumentFileName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
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

<a name="quotesupdatecustomfields"></a>
# **QuotesUpdateCustomFields**
> TsiWebCustomFieldsResponse QuotesUpdateCustomFields (int? quoteNumber, List<TsiWebCustomField> customFields)

Updates the custom fields for a quote.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesUpdateCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var customFields = new List<TsiWebCustomField>(); // List<TsiWebCustomField> | The custom fields.

            try
            {
                // Updates the custom fields for a quote.
                TsiWebCustomFieldsResponse result = apiInstance.QuotesUpdateCustomFields(quoteNumber, customFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesUpdateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **customFields** | [**List&lt;TsiWebCustomField&gt;**](TsiWebCustomField.md)| The custom fields. | 

### Return type

[**TsiWebCustomFieldsResponse**](TsiWebCustomFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesupdatequote"></a>
# **QuotesUpdateQuote**
> TsiWebQuoteResponse QuotesUpdateQuote (int? quoteNumber, TsiWebUpdateQuoteModel model)

Updates the quote.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesUpdateQuoteExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var model = new TsiWebUpdateQuoteModel(); // TsiWebUpdateQuoteModel | The quote.

            try
            {
                // Updates the quote.
                TsiWebQuoteResponse result = apiInstance.QuotesUpdateQuote(quoteNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesUpdateQuote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **model** | [**TsiWebUpdateQuoteModel**](TsiWebUpdateQuoteModel.md)| The quote. | 

### Return type

[**TsiWebQuoteResponse**](TsiWebQuoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesupdatequotedetailcomment"></a>
# **QuotesUpdateQuoteDetailComment**
> TsiWebQuoteDetailResponse QuotesUpdateQuoteDetailComment (int? quoteNumber, int? quoteDetailNumber, TsiWebQuoteDetailCommentModel model)

Updates the quote detail comment.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesUpdateQuoteDetailCommentExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var quoteDetailNumber = 56;  // int? | The quote detail number.
            var model = new TsiWebQuoteDetailCommentModel(); // TsiWebQuoteDetailCommentModel | 

            try
            {
                // Updates the quote detail comment.
                TsiWebQuoteDetailResponse result = apiInstance.QuotesUpdateQuoteDetailComment(quoteNumber, quoteDetailNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesUpdateQuoteDetailComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **quoteDetailNumber** | **int?**| The quote detail number. | 
 **model** | [**TsiWebQuoteDetailCommentModel**](TsiWebQuoteDetailCommentModel.md)|  | 

### Return type

[**TsiWebQuoteDetailResponse**](TsiWebQuoteDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesupdatequotedetailinstalllocation"></a>
# **QuotesUpdateQuoteDetailInstallLocation**
> TsiWebQuoteDetailResponse QuotesUpdateQuoteDetailInstallLocation (int? quoteNumber, int? quoteDetailNumber, string installLocation)

Updates the quote detail install location.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesUpdateQuoteDetailInstallLocationExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var quoteDetailNumber = 56;  // int? | The quote detail number.
            var installLocation = installLocation_example;  // string | The install location.

            try
            {
                // Updates the quote detail install location.
                TsiWebQuoteDetailResponse result = apiInstance.QuotesUpdateQuoteDetailInstallLocation(quoteNumber, quoteDetailNumber, installLocation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesUpdateQuoteDetailInstallLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **quoteDetailNumber** | **int?**| The quote detail number. | 
 **installLocation** | **string**| The install location. | 

### Return type

[**TsiWebQuoteDetailResponse**](TsiWebQuoteDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesupdatequotedetailitem"></a>
# **QuotesUpdateQuoteDetailItem**
> TsiWebQuoteDetailResponse QuotesUpdateQuoteDetailItem (int? quoteNumber, int? quoteDetailNumber, TsiWebQuoteDetailItemModel model)

Updates quote stock and non stock detail items.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesUpdateQuoteDetailItemExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var quoteDetailNumber = 56;  // int? | The quote stock or non stock detail number.
            var model = new TsiWebQuoteDetailItemModel(); // TsiWebQuoteDetailItemModel | 

            try
            {
                // Updates quote stock and non stock detail items.
                TsiWebQuoteDetailResponse result = apiInstance.QuotesUpdateQuoteDetailItem(quoteNumber, quoteDetailNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesUpdateQuoteDetailItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **quoteDetailNumber** | **int?**| The quote stock or non stock detail number. | 
 **model** | [**TsiWebQuoteDetailItemModel**](TsiWebQuoteDetailItemModel.md)|  | 

### Return type

[**TsiWebQuoteDetailResponse**](TsiWebQuoteDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesupdatequotedetailsubtotal"></a>
# **QuotesUpdateQuoteDetailSubtotal**
> TsiWebQuoteDetailResponse QuotesUpdateQuoteDetailSubtotal (int? quoteNumber, int? quoteDetailNumber, TsiWebQuoteDetailSubtotalModel model)

Updates the quote detail subtotal.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesUpdateQuoteDetailSubtotalExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var quoteDetailNumber = 56;  // int? | The quote detail number.
            var model = new TsiWebQuoteDetailSubtotalModel(); // TsiWebQuoteDetailSubtotalModel | 

            try
            {
                // Updates the quote detail subtotal.
                TsiWebQuoteDetailResponse result = apiInstance.QuotesUpdateQuoteDetailSubtotal(quoteNumber, quoteDetailNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesUpdateQuoteDetailSubtotal: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **quoteDetailNumber** | **int?**| The quote detail number. | 
 **model** | [**TsiWebQuoteDetailSubtotalModel**](TsiWebQuoteDetailSubtotalModel.md)|  | 

### Return type

[**TsiWebQuoteDetailResponse**](TsiWebQuoteDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="quotesupdatequotedocumentproperties"></a>
# **QuotesUpdateQuoteDocumentProperties**
> TsiWebDocumentResponse QuotesUpdateQuoteDocumentProperties (int? quoteNumber, int? documentID, TsiWebAreasWebApiUpdateDocumentModel request)

Updates the quote document properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesUpdateQuoteDocumentPropertiesExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var documentID = 56;  // int? | The document identifier.
            var request = new TsiWebAreasWebApiUpdateDocumentModel(); // TsiWebAreasWebApiUpdateDocumentModel | The request.

            try
            {
                // Updates the quote document properties.
                TsiWebDocumentResponse result = apiInstance.QuotesUpdateQuoteDocumentProperties(quoteNumber, documentID, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesUpdateQuoteDocumentProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
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

<a name="quotesupdatequotenote"></a>
# **QuotesUpdateQuoteNote**
> TsiWebQuoteNoteResponse QuotesUpdateQuoteNote (int? quoteNumber, int? quoteNoteNumber, TsiWebQuoteNoteModel note)

Updates an existing quote note.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class QuotesUpdateQuoteNoteExample
    {
        public void main()
        {
            var apiInstance = new QuotesApi();
            var quoteNumber = 56;  // int? | The quote number.
            var quoteNoteNumber = 56;  // int? | The quote note number.
            var note = new TsiWebQuoteNoteModel(); // TsiWebQuoteNoteModel | The note.

            try
            {
                // Updates an existing quote note.
                TsiWebQuoteNoteResponse result = apiInstance.QuotesUpdateQuoteNote(quoteNumber, quoteNoteNumber, note);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuotesApi.QuotesUpdateQuoteNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**| The quote number. | 
 **quoteNoteNumber** | **int?**| The quote note number. | 
 **note** | [**TsiWebQuoteNoteModel**](TsiWebQuoteNoteModel.md)| The note. | 

### Return type

[**TsiWebQuoteNoteResponse**](TsiWebQuoteNoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

