# IO.Swagger.Api.ServiceOrdersApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServiceOrdersAdvancedSearch**](ServiceOrdersApi.md#serviceordersadvancedsearch) | **POST** /api/serviceorders/search | Advanced search for service orders.
[**ServiceOrdersConvertTimeLogsToLaborItem**](ServiceOrdersApi.md#serviceordersconverttimelogstolaboritem) | **POST** /api/serviceorders/{serviceOrderNumber}/timelogs/laboritem | Converts selected time logs to a new labor item on the service order.
[**ServiceOrdersCreateExpense**](ServiceOrdersApi.md#serviceorderscreateexpense) | **POST** /api/serviceorders/{serviceOrderNumber}/expenses | Creates an expense.
[**ServiceOrdersCreateManagedPrintServiceOrder**](ServiceOrdersApi.md#serviceorderscreatemanagedprintserviceorder) | **POST** /api/serviceorders/managed/print | Creates a managed print service order based on a device id.
[**ServiceOrdersCreateRecurringServiceOrderSchedule**](ServiceOrdersApi.md#serviceorderscreaterecurringserviceorderschedule) | **POST** /api/serviceorders/recurringSchedule | Creates recurring service orders schedules.
[**ServiceOrdersCreateServiceOrder**](ServiceOrdersApi.md#serviceorderscreateserviceorder) | **POST** /api/ServiceOrders | Creates a service order.
[**ServiceOrdersCreateServiceOrderItemServiced**](ServiceOrdersApi.md#serviceorderscreateserviceorderitemserviced) | **POST** /api/serviceorders/{serviceOrderNumber}/itemsserviced | Creates an item serviced.
[**ServiceOrdersCreateServiceOrderNonStockPartsUsed**](ServiceOrdersApi.md#serviceorderscreateserviceordernonstockpartsused) | **POST** /api/serviceorders/{serviceOrderNumber}/parts/nonstock | Creates a non stock item for a service order.
[**ServiceOrdersCreateServiceOrderNote**](ServiceOrdersApi.md#serviceorderscreateserviceordernote) | **POST** /api/serviceorders/{serviceOrderNumber}/notes | Creates a service order note.
[**ServiceOrdersCreateServiceOrderPartsUsed**](ServiceOrdersApi.md#serviceorderscreateserviceorderpartsused) | **POST** /api/serviceorders/{serviceOrderNumber}/parts | Creates the service order parts used item.
[**ServiceOrdersCreateServiceOrderPartsUsedComment**](ServiceOrdersApi.md#serviceorderscreateserviceorderpartsusedcomment) | **POST** /api/serviceorders/{serviceOrderNumber}/parts/comments | Creates a line item comment for the service order,
[**ServiceOrdersCreateServiceOrderResolution**](ServiceOrdersApi.md#serviceorderscreateserviceorderresolution) | **POST** /api/serviceorders/{serviceOrderNumber}/resolutions | Creates a resolution on a service order.
[**ServiceOrdersCreateServiceOrderSymptom**](ServiceOrdersApi.md#serviceorderscreateserviceordersymptom) | **POST** /api/serviceorders/{serviceOrderNumber}/symptoms | Creates a symptom on a service order.
[**ServiceOrdersCreateServiceOrderTimeLog**](ServiceOrdersApi.md#serviceorderscreateserviceordertimelog) | **POST** /api/serviceorders/{serviceOrderNumber}/timelogs | Creates a service order time log.
[**ServiceOrdersDeleteServiceOrderPartsUsed**](ServiceOrdersApi.md#serviceordersdeleteserviceorderpartsused) | **DELETE** /api/serviceorders/{serviceOrderNumber}/parts/{partsUsedNumber} | Deletes a part used on a service order.
[**ServiceOrdersDeleteServiceOrderProfile**](ServiceOrdersApi.md#serviceordersdeleteserviceorderprofile) | **DELETE** /api/serviceorders/{serviceOrderNumber}/profiles | Deletes a profile from the service order.
[**ServiceOrdersDeleteServiceOrderResolution**](ServiceOrdersApi.md#serviceordersdeleteserviceorderresolution) | **DELETE** /api/serviceorders/{serviceOrderNumber}/resolutions/{resolutionIndex} | Deletes a resolution on a service order, acceptable index values are 1-5.
[**ServiceOrdersDeleteServiceOrderSymptom**](ServiceOrdersApi.md#serviceordersdeleteserviceordersymptom) | **DELETE** /api/serviceorders/{serviceOrderNumber}/symptoms/{symptomIndex} | Deletes a symptom on a service order, acceptable index values are 1-5.
[**ServiceOrdersExpenseAdvancedSearch**](ServiceOrdersApi.md#serviceordersexpenseadvancedsearch) | **POST** /api/serviceorders/expenses/search | Advanced search for service orders.
[**ServiceOrdersGetAccountRecurringServiceOrderSchedules**](ServiceOrdersApi.md#serviceordersgetaccountrecurringserviceorderschedules) | **GET** /api/serviceorders/recurringSchedule/account/{accountNumber}/{excludeCompleted} | Gets the recurring service order schedules for an account.
[**ServiceOrdersGetAccountServiceOrders**](ServiceOrdersApi.md#serviceordersgetaccountserviceorders) | **GET** /api/serviceorders/account/{accountNumber} | Gets the account service orders.
[**ServiceOrdersGetAccountServiceOrders_0**](ServiceOrdersApi.md#serviceordersgetaccountserviceorders_0) | **GET** /api/serviceorders/account/{accountNumber}/{excludeVoided} | Gets the account service orders.
[**ServiceOrdersGetCustomFields**](ServiceOrdersApi.md#serviceordersgetcustomfields) | **GET** /api/serviceorders/{serviceOrderNumber}/customfields | Gets the custom fields for the account.
[**ServiceOrdersGetRecurringServiceOrderSchedule**](ServiceOrdersApi.md#serviceordersgetrecurringserviceorderschedule) | **GET** /api/serviceorders/recurringSchedule/{recurringServiceOrderScheduleId} | Gets a single recurring service order schedule.
[**ServiceOrdersGetServiceOrderAssignedTechs**](ServiceOrdersApi.md#serviceordersgetserviceorderassignedtechs) | **GET** /api/serviceorders/{serviceOrderNumber}/assignedtechs | Gets the service order assigned technicians.
[**ServiceOrdersGetServiceOrderByExternalTicket**](ServiceOrdersApi.md#serviceordersgetserviceorderbyexternalticket) | **GET** /api/serviceorders/externalticket | Gets the service order details by external ticket identifier.
[**ServiceOrdersGetServiceOrderCompletedTasks**](ServiceOrdersApi.md#serviceordersgetserviceordercompletedtasks) | **GET** /api/serviceorders/{serviceOrderNumber}/tasks/completed | Gets the service order completed tasks.
[**ServiceOrdersGetServiceOrderDetail**](ServiceOrdersApi.md#serviceordersgetserviceorderdetail) | **GET** /api/serviceorders/{serviceOrderNumber}/details | Gets the service order details.
[**ServiceOrdersGetServiceOrderExpense**](ServiceOrdersApi.md#serviceordersgetserviceorderexpense) | **GET** /api/serviceorders/{serviceOrderNumber}/expenses/{serviceOrderExpenseNumber} | Gets a single service orde expense
[**ServiceOrdersGetServiceOrderExpenses**](ServiceOrdersApi.md#serviceordersgetserviceorderexpenses) | **GET** /api/serviceorders/{serviceOrderNumber}/expenses | Gets the service order expenses.
[**ServiceOrdersGetServiceOrderIncompleteTasks**](ServiceOrdersApi.md#serviceordersgetserviceorderincompletetasks) | **GET** /api/serviceorders/{serviceOrderNumber}/tasks | Gets the service order incomplete tasks.
[**ServiceOrdersGetServiceOrderItemServiced**](ServiceOrdersApi.md#serviceordersgetserviceorderitemserviced) | **GET** /api/serviceorders/{serviceOrderNumber}/itemsserviced/{itemServicedNumber} | 
[**ServiceOrdersGetServiceOrderItemsServiced**](ServiceOrdersApi.md#serviceordersgetserviceorderitemsserviced) | **GET** /api/serviceorders/{serviceOrderNumber}/itemsserviced | Gets the service order items serviced.
[**ServiceOrdersGetServiceOrderNotes**](ServiceOrdersApi.md#serviceordersgetserviceordernotes) | **GET** /api/serviceorders/{serviceOrderNumber}/notes | Gets the service order notes.
[**ServiceOrdersGetServiceOrderParts**](ServiceOrdersApi.md#serviceordersgetserviceorderparts) | **GET** /api/serviceorders/{serviceOrderNumber}/parts | Gets the service order parts used.
[**ServiceOrdersGetServiceOrderProfiles**](ServiceOrdersApi.md#serviceordersgetserviceorderprofiles) | **GET** /api/serviceorders/{serviceOrderNumber}/profiles | Gets the Service order profiles.
[**ServiceOrdersGetServiceOrderQuotes**](ServiceOrdersApi.md#serviceordersgetserviceorderquotes) | **GET** /api/serviceorders/{serviceOrderNumber}/quotes | Gets the service order quotes.
[**ServiceOrdersGetServiceOrderSubContractors**](ServiceOrdersApi.md#serviceordersgetserviceordersubcontractors) | **GET** /api/serviceorders/{serviceOrderNumber}/subContractors | Gets the service order subcontractors.
[**ServiceOrdersGetServiceOrderSummary**](ServiceOrdersApi.md#serviceordersgetserviceordersummary) | **GET** /api/serviceorders/{serviceOrderNumber} | Gets the service order summary.
[**ServiceOrdersGetServiceOrderTasks**](ServiceOrdersApi.md#serviceordersgetserviceordertasks) | **GET** /api/serviceorders/{serviceOrderNumber}/tasks/all | Gets the service order tasks. Includes both completed and incomplete tasks.
[**ServiceOrdersGetServiceOrderTimeLogs**](ServiceOrdersApi.md#serviceordersgetserviceordertimelogs) | **GET** /api/serviceorders/{serviceOrderNumber}/timelogs | Gets the service order time logs.
[**ServiceOrdersGetServiceOrderTimeLogsByLogNumber**](ServiceOrdersApi.md#serviceordersgetserviceordertimelogsbylognumber) | **GET** /api/serviceorders/{serviceOrderNumber}/timelogs/{timeLogNumber} | Gets the service order time logs based on the log ID.
[**ServiceOrdersSearchByAgreementNumber**](ServiceOrdersApi.md#serviceorderssearchbyagreementnumber) | **POST** /api/serviceorders/search/agreementnumber | Search service orders using an agreement number.
[**ServiceOrdersSearchByCustomField**](ServiceOrdersApi.md#serviceorderssearchbycustomfield) | **POST** /api/serviceorders/search/customfield | Search Service Orders using a custom category and field label.
[**ServiceOrdersSearchByCustomerPurchaseOrder**](ServiceOrdersApi.md#serviceorderssearchbycustomerpurchaseorder) | **POST** /api/serviceorders/search/customerpurchaseorder | Search service orders using customer purchase order.
[**ServiceOrdersSearchByExternalProduct**](ServiceOrdersApi.md#serviceorderssearchbyexternalproduct) | **POST** /api/serviceorders/search/externalproduct | Search service orders using an external product name.
[**ServiceOrdersSearchByInvoiceNumber**](ServiceOrdersApi.md#serviceorderssearchbyinvoicenumber) | **POST** /api/serviceorders/search/invoicenumber | Search service orders using invoice number.
[**ServiceOrdersSearchByItemServiced**](ServiceOrdersApi.md#serviceorderssearchbyitemserviced) | **POST** /api/serviceorders/search/itemid | Search service orders using items serviced.
[**ServiceOrdersSearchByReference**](ServiceOrdersApi.md#serviceorderssearchbyreference) | **POST** /api/serviceorders/search/reference | Search service orders using reference value.
[**ServiceOrdersSearchByServiceOrderNumber**](ServiceOrdersApi.md#serviceorderssearchbyserviceordernumber) | **POST** /api/serviceorders/search/serviceordernumber | Search service orders using service order number.
[**ServiceOrdersSearchExpenseByAcceptanceStatus**](ServiceOrdersApi.md#serviceorderssearchexpensebyacceptancestatus) | **POST** /api/serviceorders/expenses/search/acceptancestatus | Search expenses using an acceptanc estatus.
[**ServiceOrdersSearchExpenseByExpenseDate**](ServiceOrdersApi.md#serviceorderssearchexpensebyexpensedate) | **POST** /api/serviceorders/expenses/search/expensedate | Search expenses using an expense date.
[**ServiceOrdersSearchExpenseByExpenseType**](ServiceOrdersApi.md#serviceorderssearchexpensebyexpensetype) | **POST** /api/serviceorders/expenses/search/expensetype | Search expenses using an expense type.
[**ServiceOrdersSearchExpenseByTechnician**](ServiceOrdersApi.md#serviceorderssearchexpensebytechnician) | **POST** /api/serviceorders/expenses/search/technician | Search expenses using a technician name.
[**ServiceOrdersSetServiceOrderProfile**](ServiceOrdersApi.md#serviceorderssetserviceorderprofile) | **POST** /api/serviceorders/{serviceOrderNumber}/profiles | Assigns a profile to a service order.
[**ServiceOrdersTimeLogAdvancedSearch**](ServiceOrdersApi.md#serviceorderstimelogadvancedsearch) | **POST** /api/serviceorders/timelogs/search | Advanced search for service orders time logs.
[**ServiceOrdersUpdateCustomFields**](ServiceOrdersApi.md#serviceordersupdatecustomfields) | **PUT** /api/serviceorders/{serviceOrderNumber}/customfields | Updates account custom fields.
[**ServiceOrdersUpdateExpense**](ServiceOrdersApi.md#serviceordersupdateexpense) | **PUT** /api/serviceorders/{serviceOrderNumber}/expenses/{expenseNumber} | Updates an expense.
[**ServiceOrdersUpdateManagedServiceOrder**](ServiceOrdersApi.md#serviceordersupdatemanagedserviceorder) | **PUT** /api/serviceorders/managed | 
[**ServiceOrdersUpdateServiceOrder**](ServiceOrdersApi.md#serviceordersupdateserviceorder) | **PUT** /api/serviceorders/{serviceOrderNumber} | Updates the service order.
[**ServiceOrdersUpdateServiceOrderItemServiced**](ServiceOrdersApi.md#serviceordersupdateserviceorderitemserviced) | **PUT** /api/serviceorders/{serviceOrderNumber}/ItemsServiced/{itemServicedNumber} | Updates the item serviced
[**ServiceOrdersUpdateServiceOrderNonStockPartsUsed**](ServiceOrdersApi.md#serviceordersupdateserviceordernonstockpartsused) | **PUT** /api/serviceorders/{serviceOrderNumber}/parts/nonstock/{partNumber} | Updates a non-stock part.
[**ServiceOrdersUpdateServiceOrderNote**](ServiceOrdersApi.md#serviceordersupdateserviceordernote) | **PUT** /api/serviceorders/{serviceOrderNumber}/notes/{serviceOrderNoteNumber} | Updates a service order note.
[**ServiceOrdersUpdateServiceOrderPartsUsed**](ServiceOrdersApi.md#serviceordersupdateserviceorderpartsused) | **PUT** /api/serviceorders/{serviceOrderNumber}/parts/{partNumber} | Updates a part on a service order.
[**ServiceOrdersUpdateServiceOrderPartsUsedAssemblyDetail**](ServiceOrdersApi.md#serviceordersupdateserviceorderpartsusedassemblydetail) | **PUT** /api/serviceorders/{serviceOrderNumber}/parts/{partsUsedNumber}/assembly/{partUsedAssemblyDetailNumber} | Updates the assembly detail for a service order part
[**ServiceOrdersUpdateServiceOrderPartsUsedComment**](ServiceOrdersApi.md#serviceordersupdateserviceorderpartsusedcomment) | **PUT** /api/serviceorders/{serviceOrderNumber}/parts/comments/{partNumber} | Updates a line item comment for the service order.
[**ServiceOrdersUpdateServiceOrderResolution**](ServiceOrdersApi.md#serviceordersupdateserviceorderresolution) | **PUT** /api/serviceorders/{serviceOrderNumber}/resolutions/{resolutionIndex} | Updates a resolution on a service order, acceptable values are 1-5
[**ServiceOrdersUpdateServiceOrderSymptom**](ServiceOrdersApi.md#serviceordersupdateserviceordersymptom) | **PUT** /api/serviceorders/{serviceOrderNumber}/symptoms/{symptomIndex} | Updates a symptom on a service order, acceptable values are 1-5
[**ServiceOrdersUpdateServiceOrderTimeLog**](ServiceOrdersApi.md#serviceordersupdateserviceordertimelog) | **PUT** /api/serviceorders/{serviceOrderNumber}/timelogs/{timeLogNumber} | Updates a service order time log.


<a name="serviceordersadvancedsearch"></a>
# **ServiceOrdersAdvancedSearch**
> TsiWebSearchServiceOrderResponse ServiceOrdersAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for service orders.

When searching by External Ticket only one External Product may be specified and you must use the entire product name in the Criteria.  <p>Valid SearchType = ServiceOrderNumber, Reference, InvoiceNumber, ItemID, AgreementNumber, CustomerPurchaseOrder, ExternalProduct, ExternalTicket, AccountNumber, Status, Type, Profile,Resolution,Symptom, or CustomField (requires CategoryName and CustomFieldName)</p><p>Valid MatchType = StartsWith (default), EndsWith, Contains, GreaterThan, GreaterThanEqual, Equal, LessThan, LessThanEqual</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for service orders.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersAdvancedSearch: " + e.Message );
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

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersconverttimelogstolaboritem"></a>
# **ServiceOrdersConvertTimeLogsToLaborItem**
> TsiWebResponse ServiceOrdersConvertTimeLogsToLaborItem (int? serviceOrderNumber, TsiWebConvertTimeLogsToLaborItemModel model)

Converts selected time logs to a new labor item on the service order.

Valid labor item types are - \"Default\", \"Selected\"  <p>Supply an array of time logs ids to convert to a labor item on the service order. [1,2,3]</p><p>CanConvertNonBillableTimeLogs - allows non billable time logs to be converted with the billable time logs</p><p>CanCombineLogsWithDifferentLaborRatesOrRateBasis - allows time logs with a different labor rate or basis to be combined using the default labor rate for the account.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersConvertTimeLogsToLaborItemExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var model = new TsiWebConvertTimeLogsToLaborItemModel(); // TsiWebConvertTimeLogsToLaborItemModel | The convert time logs to labor item model.

            try
            {
                // Converts selected time logs to a new labor item on the service order.
                TsiWebResponse result = apiInstance.ServiceOrdersConvertTimeLogsToLaborItem(serviceOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersConvertTimeLogsToLaborItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **model** | [**TsiWebConvertTimeLogsToLaborItemModel**](TsiWebConvertTimeLogsToLaborItemModel.md)| The convert time logs to labor item model. | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreateexpense"></a>
# **ServiceOrdersCreateExpense**
> TsiWebServiceOrderExpensesResponse ServiceOrdersCreateExpense (int? serviceOrderNumber, TsiWebExpenseModel model)

Creates an expense.

The DistanceType field accepts values \"DoNotChangeDistance\", \"SetByEndOdometer\", or \"SetByDistance\".

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateExpenseExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var model = new TsiWebExpenseModel(); // TsiWebExpenseModel | 

            try
            {
                // Creates an expense.
                TsiWebServiceOrderExpensesResponse result = apiInstance.ServiceOrdersCreateExpense(serviceOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateExpense: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **model** | [**TsiWebExpenseModel**](TsiWebExpenseModel.md)|  | 

### Return type

[**TsiWebServiceOrderExpensesResponse**](TsiWebServiceOrderExpensesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreatemanagedprintserviceorder"></a>
# **ServiceOrdersCreateManagedPrintServiceOrder**
> TsiWebServiceOrderResponse ServiceOrdersCreateManagedPrintServiceOrder (TsiWebCreateManagedPrintServiceOrderModel model)

Creates a managed print service order based on a device id.

Used by managed print providers to create a service order for a metered device

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateManagedPrintServiceOrderExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var model = new TsiWebCreateManagedPrintServiceOrderModel(); // TsiWebCreateManagedPrintServiceOrderModel | The model.

            try
            {
                // Creates a managed print service order based on a device id.
                TsiWebServiceOrderResponse result = apiInstance.ServiceOrdersCreateManagedPrintServiceOrder(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateManagedPrintServiceOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCreateManagedPrintServiceOrderModel**](TsiWebCreateManagedPrintServiceOrderModel.md)| The model. | 

### Return type

[**TsiWebServiceOrderResponse**](TsiWebServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreaterecurringserviceorderschedule"></a>
# **ServiceOrdersCreateRecurringServiceOrderSchedule**
> TsiWebCreateRecurringServiceOrderScheduleResponse ServiceOrdersCreateRecurringServiceOrderSchedule (TsiWebCreateRecurringServiceOrderScheduleModel model)

Creates recurring service orders schedules.

The Frequency value must be one of: \"Daily\", \"Weekly\", \"Monthly\", \"Yearly\".If no Frequency is submitted the default value is \"Daily\".  <p>The EndType value must be one of: \"None\", \"EndByDate\", \"NumberOfOccurences\". If no EndType is submitted, the default value is \"None\".</p><p>The DayOfMonthType must be one of: \"SpecifiedDay\", \"LastDayOfTheMonth\", \"FloatingDate\".</p><p>The DayOfTheWeek must be one of: \"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\",\"Saturday\",\"Sunday\",\"None\".</p><p>The WeekOfTheMonth value must be one of: \"First\",\"Second\",\"Third\",\"Fourth\",\"Last\".</p><p>The TakenByRepType value must be one of: \"SpecifiedRep\", \"CurrentUser\",\"AccountDefaultTech\", \"AccountPrimaryRep\".</p><p>For XML requests, the ServiceOrderRecievedTime accepts values in form  HH/MM/SS.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateRecurringServiceOrderScheduleExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var model = new TsiWebCreateRecurringServiceOrderScheduleModel(); // TsiWebCreateRecurringServiceOrderScheduleModel | 

            try
            {
                // Creates recurring service orders schedules.
                TsiWebCreateRecurringServiceOrderScheduleResponse result = apiInstance.ServiceOrdersCreateRecurringServiceOrderSchedule(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateRecurringServiceOrderSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCreateRecurringServiceOrderScheduleModel**](TsiWebCreateRecurringServiceOrderScheduleModel.md)|  | 

### Return type

[**TsiWebCreateRecurringServiceOrderScheduleResponse**](TsiWebCreateRecurringServiceOrderScheduleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreateserviceorder"></a>
# **ServiceOrdersCreateServiceOrder**
> TsiWebServiceOrderResponse ServiceOrdersCreateServiceOrder (TsiWebCreateServiceOrderModel model)

Creates a service order.

DateTimeRequested is an optional SplitDateTime type. Json format is \"DateTimeRequested\":{\"Date\":\"2018-03-06T00:00:00\", \"Time\":\"1900-01-01T14:09:02\"}

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateServiceOrderExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var model = new TsiWebCreateServiceOrderModel(); // TsiWebCreateServiceOrderModel | The create service order model.

            try
            {
                // Creates a service order.
                TsiWebServiceOrderResponse result = apiInstance.ServiceOrdersCreateServiceOrder(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateServiceOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCreateServiceOrderModel**](TsiWebCreateServiceOrderModel.md)| The create service order model. | 

### Return type

[**TsiWebServiceOrderResponse**](TsiWebServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreateserviceorderitemserviced"></a>
# **ServiceOrdersCreateServiceOrderItemServiced**
> TsiWebServiceOrderItemServicedResponse ServiceOrdersCreateServiceOrderItemServiced (int? serviceOrderNumber, TsiWebCreateServiceOrderItemServicedModel model)

Creates an item serviced.

The UpdateContractMetersType must be one of: \"DoNotUpdate\", \"UpdateByReading\", or \"UpdateByClicksUsed\".<br /><p>The CreateServiceOrderItemServicedType must be one of: \"NewItem\", \"FromPriceBookItem\", \"FromCustomerInventoryItem\", \"FromMSPAsset\", or \"FromContractItem\".</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateServiceOrderItemServicedExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var model = new TsiWebCreateServiceOrderItemServicedModel(); // TsiWebCreateServiceOrderItemServicedModel | 

            try
            {
                // Creates an item serviced.
                TsiWebServiceOrderItemServicedResponse result = apiInstance.ServiceOrdersCreateServiceOrderItemServiced(serviceOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateServiceOrderItemServiced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **model** | [**TsiWebCreateServiceOrderItemServicedModel**](TsiWebCreateServiceOrderItemServicedModel.md)|  | 

### Return type

[**TsiWebServiceOrderItemServicedResponse**](TsiWebServiceOrderItemServicedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreateserviceordernonstockpartsused"></a>
# **ServiceOrdersCreateServiceOrderNonStockPartsUsed**
> TsiWebServiceOrderPartsUsedResponse ServiceOrdersCreateServiceOrderNonStockPartsUsed (int? serviceOrderNumber, TsiWebCreateServiceOrderNonStockModel model)

Creates a non stock item for a service order.

The Type field accepts values \"Labor\", \"Material\", or \"Special\".

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateServiceOrderNonStockPartsUsedExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var model = new TsiWebCreateServiceOrderNonStockModel(); // TsiWebCreateServiceOrderNonStockModel | 

            try
            {
                // Creates a non stock item for a service order.
                TsiWebServiceOrderPartsUsedResponse result = apiInstance.ServiceOrdersCreateServiceOrderNonStockPartsUsed(serviceOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateServiceOrderNonStockPartsUsed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **model** | [**TsiWebCreateServiceOrderNonStockModel**](TsiWebCreateServiceOrderNonStockModel.md)|  | 

### Return type

[**TsiWebServiceOrderPartsUsedResponse**](TsiWebServiceOrderPartsUsedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreateserviceordernote"></a>
# **ServiceOrdersCreateServiceOrderNote**
> TsiWebServiceOrderNoteResponse ServiceOrdersCreateServiceOrderNote (int? serviceOrderNumber, TsiWebServiceOrderNoteModel model)

Creates a service order note.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateServiceOrderNoteExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var model = new TsiWebServiceOrderNoteModel(); // TsiWebServiceOrderNoteModel | 

            try
            {
                // Creates a service order note.
                TsiWebServiceOrderNoteResponse result = apiInstance.ServiceOrdersCreateServiceOrderNote(serviceOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateServiceOrderNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **model** | [**TsiWebServiceOrderNoteModel**](TsiWebServiceOrderNoteModel.md)|  | 

### Return type

[**TsiWebServiceOrderNoteResponse**](TsiWebServiceOrderNoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreateserviceorderpartsused"></a>
# **ServiceOrdersCreateServiceOrderPartsUsed**
> TsiWebServiceOrderPartsUsedResponse ServiceOrdersCreateServiceOrderPartsUsed (int? serviceOrderNumber, TsiWebCreateServiceOrderPartsUsedModel model)

Creates the service order parts used item.

The Price Book Item is selected by either the PriceBookItemNumber or the ItemId. If both are given PriceBookItemNumber will be used. <br /><p>The UseBookPricesAndDiscounts field is required; if it is true then Price Levels will be used, if it is false then Sell Price will be used.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateServiceOrderPartsUsedExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var model = new TsiWebCreateServiceOrderPartsUsedModel(); // TsiWebCreateServiceOrderPartsUsedModel | 

            try
            {
                // Creates the service order parts used item.
                TsiWebServiceOrderPartsUsedResponse result = apiInstance.ServiceOrdersCreateServiceOrderPartsUsed(serviceOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateServiceOrderPartsUsed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **model** | [**TsiWebCreateServiceOrderPartsUsedModel**](TsiWebCreateServiceOrderPartsUsedModel.md)|  | 

### Return type

[**TsiWebServiceOrderPartsUsedResponse**](TsiWebServiceOrderPartsUsedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreateserviceorderpartsusedcomment"></a>
# **ServiceOrdersCreateServiceOrderPartsUsedComment**
> TsiWebServiceOrderPartUsedResponse ServiceOrdersCreateServiceOrderPartsUsedComment (int? serviceOrderNumber, TsiWebServiceOrderPartsUsedCommentModel model)

Creates a line item comment for the service order,

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateServiceOrderPartsUsedCommentExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var model = new TsiWebServiceOrderPartsUsedCommentModel(); // TsiWebServiceOrderPartsUsedCommentModel | 

            try
            {
                // Creates a line item comment for the service order,
                TsiWebServiceOrderPartUsedResponse result = apiInstance.ServiceOrdersCreateServiceOrderPartsUsedComment(serviceOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateServiceOrderPartsUsedComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **model** | [**TsiWebServiceOrderPartsUsedCommentModel**](TsiWebServiceOrderPartsUsedCommentModel.md)|  | 

### Return type

[**TsiWebServiceOrderPartUsedResponse**](TsiWebServiceOrderPartUsedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreateserviceorderresolution"></a>
# **ServiceOrdersCreateServiceOrderResolution**
> TsiWebServiceOrderResolutionResponse ServiceOrdersCreateServiceOrderResolution (int? serviceOrderNumber, string resolution)

Creates a resolution on a service order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateServiceOrderResolutionExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var resolution = resolution_example;  // string | 

            try
            {
                // Creates a resolution on a service order.
                TsiWebServiceOrderResolutionResponse result = apiInstance.ServiceOrdersCreateServiceOrderResolution(serviceOrderNumber, resolution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateServiceOrderResolution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **resolution** | **string**|  | 

### Return type

[**TsiWebServiceOrderResolutionResponse**](TsiWebServiceOrderResolutionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreateserviceordersymptom"></a>
# **ServiceOrdersCreateServiceOrderSymptom**
> TsiWebServiceOrderSymptomResponse ServiceOrdersCreateServiceOrderSymptom (int? serviceOrderNumber, string symptom)

Creates a symptom on a service order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateServiceOrderSymptomExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var symptom = symptom_example;  // string | 

            try
            {
                // Creates a symptom on a service order.
                TsiWebServiceOrderSymptomResponse result = apiInstance.ServiceOrdersCreateServiceOrderSymptom(serviceOrderNumber, symptom);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateServiceOrderSymptom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **symptom** | **string**|  | 

### Return type

[**TsiWebServiceOrderSymptomResponse**](TsiWebServiceOrderSymptomResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderscreateserviceordertimelog"></a>
# **ServiceOrdersCreateServiceOrderTimeLog**
> TsiWebServiceOrderTimeLogResponse ServiceOrdersCreateServiceOrderTimeLog (int? serviceOrderNumber, TsiWebCreateServiceOrderTimeLogModel model)

Creates a service order time log.

Valid billing option types are - \"InvoiceCustomer\", \"ApplyToContract\", \"ApplyToContractAndBillcustomer\", \"DoNotInvoice\",   <P>  Valid rate basis values are - \"Regular\", \"Overtime\", \"Premium\", \"Standard\", \"AccountDefault\", \"PriceBook\", \"FlatFee\", \"Manual\".The default value will be regular.  </P><P>  Valid copy indicator type values are - \"DoNotCopy,\"CopyWhenSaving,\"CopyWhenClosingLog\".  </P><P>  Valid time to invoice type values are - \"BillableHoursMinutes\", \"UtilizedTime\", \"RoundedMinimumUtilizedtime\", \"ActualTime\", \"RoundedMinimumActualTime\". The default value for this would be BillableHoursMinutes  </P>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersCreateServiceOrderTimeLogExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | Service order number
            var model = new TsiWebCreateServiceOrderTimeLogModel(); // TsiWebCreateServiceOrderTimeLogModel | The create service order time log model.

            try
            {
                // Creates a service order time log.
                TsiWebServiceOrderTimeLogResponse result = apiInstance.ServiceOrdersCreateServiceOrderTimeLog(serviceOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersCreateServiceOrderTimeLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| Service order number | 
 **model** | [**TsiWebCreateServiceOrderTimeLogModel**](TsiWebCreateServiceOrderTimeLogModel.md)| The create service order time log model. | 

### Return type

[**TsiWebServiceOrderTimeLogResponse**](TsiWebServiceOrderTimeLogResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersdeleteserviceorderpartsused"></a>
# **ServiceOrdersDeleteServiceOrderPartsUsed**
> TsiWebServiceOrderPartsUsedResponse ServiceOrdersDeleteServiceOrderPartsUsed (int? serviceOrderNumber, int? partsUsedNumber, TsiWebDeleteServiceOrderPartsUsedModel model)

Deletes a part used on a service order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersDeleteServiceOrderPartsUsedExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var partsUsedNumber = 56;  // int? | 
            var model = new TsiWebDeleteServiceOrderPartsUsedModel(); // TsiWebDeleteServiceOrderPartsUsedModel | 

            try
            {
                // Deletes a part used on a service order.
                TsiWebServiceOrderPartsUsedResponse result = apiInstance.ServiceOrdersDeleteServiceOrderPartsUsed(serviceOrderNumber, partsUsedNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersDeleteServiceOrderPartsUsed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **partsUsedNumber** | **int?**|  | 
 **model** | [**TsiWebDeleteServiceOrderPartsUsedModel**](TsiWebDeleteServiceOrderPartsUsedModel.md)|  | 

### Return type

[**TsiWebServiceOrderPartsUsedResponse**](TsiWebServiceOrderPartsUsedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersdeleteserviceorderprofile"></a>
# **ServiceOrdersDeleteServiceOrderProfile**
> TsiWebResponse ServiceOrdersDeleteServiceOrderProfile (int? serviceOrderNumber, string id)

Deletes a profile from the service order.

The profile must be url encoded

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersDeleteServiceOrderProfileExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var id = id_example;  // string | The profile to remove. (Must be url encoded)

            try
            {
                // Deletes a profile from the service order.
                TsiWebResponse result = apiInstance.ServiceOrdersDeleteServiceOrderProfile(serviceOrderNumber, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersDeleteServiceOrderProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **id** | **string**| The profile to remove. (Must be url encoded) | 

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersdeleteserviceorderresolution"></a>
# **ServiceOrdersDeleteServiceOrderResolution**
> TsiWebServiceOrderResolutionResponse ServiceOrdersDeleteServiceOrderResolution (int? serviceOrderNumber, int? resolutionIndex)

Deletes a resolution on a service order, acceptable index values are 1-5.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersDeleteServiceOrderResolutionExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var resolutionIndex = 56;  // int? | 

            try
            {
                // Deletes a resolution on a service order, acceptable index values are 1-5.
                TsiWebServiceOrderResolutionResponse result = apiInstance.ServiceOrdersDeleteServiceOrderResolution(serviceOrderNumber, resolutionIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersDeleteServiceOrderResolution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **resolutionIndex** | **int?**|  | 

### Return type

[**TsiWebServiceOrderResolutionResponse**](TsiWebServiceOrderResolutionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersdeleteserviceordersymptom"></a>
# **ServiceOrdersDeleteServiceOrderSymptom**
> TsiWebServiceOrderSymptomResponse ServiceOrdersDeleteServiceOrderSymptom (int? serviceOrderNumber, int? symptomIndex)

Deletes a symptom on a service order, acceptable index values are 1-5.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersDeleteServiceOrderSymptomExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var symptomIndex = 56;  // int? | 

            try
            {
                // Deletes a symptom on a service order, acceptable index values are 1-5.
                TsiWebServiceOrderSymptomResponse result = apiInstance.ServiceOrdersDeleteServiceOrderSymptom(serviceOrderNumber, symptomIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersDeleteServiceOrderSymptom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **symptomIndex** | **int?**|  | 

### Return type

[**TsiWebServiceOrderSymptomResponse**](TsiWebServiceOrderSymptomResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersexpenseadvancedsearch"></a>
# **ServiceOrdersExpenseAdvancedSearch**
> TsiWebServiceOrderExpenseSearchResponse ServiceOrdersExpenseAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for service orders.

Valid SearchType = Technician, ExpenseType, ExpensePaymentType, Reimbursable, FromExpenseDate, ToExpenseDate, AcceptanceStatus.  <p>Valid MatchTypes for ExpenseType, ExpensePaymentType, Reimbursable, and AcceptanceStatus = Equal. </p><p>Valid MatchTypes for FromExpenseDate, ToExpenseDate = GreaterThan, GreaterThanEqual, Equal, LessThan, LessThanEqual. </p><p>Valid MatchTypes for Technician is StartsWith, EndsWith, Contains,</p><p>Valid Criteria for AcceptanceStatus = Open, Accepted, Questioned, Resubmitted.</p><p>Valid Criteria for Reimbursable = true or false.</p><p>Will return expenses only on service orders the rep has access to.</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersExpenseAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for service orders.
                TsiWebServiceOrderExpenseSearchResponse result = apiInstance.ServiceOrdersExpenseAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersExpenseAdvancedSearch: " + e.Message );
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

[**TsiWebServiceOrderExpenseSearchResponse**](TsiWebServiceOrderExpenseSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetaccountrecurringserviceorderschedules"></a>
# **ServiceOrdersGetAccountRecurringServiceOrderSchedules**
> TsiWebRecurringServiceOrderSchedulesResponse ServiceOrdersGetAccountRecurringServiceOrderSchedules (int? accountNumber, bool? excludeCompleted, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the recurring service order schedules for an account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetAccountRecurringServiceOrderSchedulesExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var accountNumber = 56;  // int? | The account number.
            var excludeCompleted = true;  // bool? | Optional, return completed recurring service orders schedules.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the recurring service order schedules for an account.
                TsiWebRecurringServiceOrderSchedulesResponse result = apiInstance.ServiceOrdersGetAccountRecurringServiceOrderSchedules(accountNumber, excludeCompleted, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetAccountRecurringServiceOrderSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **excludeCompleted** | **bool?**| Optional, return completed recurring service orders schedules. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebRecurringServiceOrderSchedulesResponse**](TsiWebRecurringServiceOrderSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetaccountserviceorders"></a>
# **ServiceOrdersGetAccountServiceOrders**
> TsiWebSearchServiceOrderResponse ServiceOrdersGetAccountServiceOrders (int? accountNumber, bool? excludeVoided = null, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account service orders.

Voided Service Orders are excluded by default.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetAccountServiceOrdersExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var accountNumber = 56;  // int? | The account number.
            var excludeVoided = true;  // bool? | Optional, return voided service orders (optional) 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account service orders.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersGetAccountServiceOrders(accountNumber, excludeVoided, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetAccountServiceOrders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **excludeVoided** | **bool?**| Optional, return voided service orders | [optional] 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetaccountserviceorders_0"></a>
# **ServiceOrdersGetAccountServiceOrders_0**
> TsiWebSearchServiceOrderResponse ServiceOrdersGetAccountServiceOrders_0 (int? accountNumber, bool? excludeVoided, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the account service orders.

Voided Service Orders are excluded by default.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetAccountServiceOrders_0Example
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var accountNumber = 56;  // int? | The account number.
            var excludeVoided = true;  // bool? | Optional, return voided service orders
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the account service orders.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersGetAccountServiceOrders_0(accountNumber, excludeVoided, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetAccountServiceOrders_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountNumber** | **int?**| The account number. | 
 **excludeVoided** | **bool?**| Optional, return voided service orders | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetcustomfields"></a>
# **ServiceOrdersGetCustomFields**
> List<TsiWebCustomField> ServiceOrdersGetCustomFields (int? serviceOrderNumber)

Gets the custom fields for the account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The account number.

            try
            {
                // Gets the custom fields for the account.
                List&lt;TsiWebCustomField&gt; result = apiInstance.ServiceOrdersGetCustomFields(serviceOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The account number. | 

### Return type

[**List<TsiWebCustomField>**](TsiWebCustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetrecurringserviceorderschedule"></a>
# **ServiceOrdersGetRecurringServiceOrderSchedule**
> TsiWebRecurringServiceOrderSchedule ServiceOrdersGetRecurringServiceOrderSchedule (int? recurringServiceOrderScheduleId)

Gets a single recurring service order schedule.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetRecurringServiceOrderScheduleExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var recurringServiceOrderScheduleId = 56;  // int? | 

            try
            {
                // Gets a single recurring service order schedule.
                TsiWebRecurringServiceOrderSchedule result = apiInstance.ServiceOrdersGetRecurringServiceOrderSchedule(recurringServiceOrderScheduleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetRecurringServiceOrderSchedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recurringServiceOrderScheduleId** | **int?**|  | 

### Return type

[**TsiWebRecurringServiceOrderSchedule**](TsiWebRecurringServiceOrderSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceorderassignedtechs"></a>
# **ServiceOrdersGetServiceOrderAssignedTechs**
> List<TsiWebServiceOrderAssignedTech> ServiceOrdersGetServiceOrderAssignedTechs (int? serviceOrderNumber)

Gets the service order assigned technicians.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderAssignedTechsExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.

            try
            {
                // Gets the service order assigned technicians.
                List&lt;TsiWebServiceOrderAssignedTech&gt; result = apiInstance.ServiceOrdersGetServiceOrderAssignedTechs(serviceOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderAssignedTechs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 

### Return type

[**List<TsiWebServiceOrderAssignedTech>**](TsiWebServiceOrderAssignedTech.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceorderbyexternalticket"></a>
# **ServiceOrdersGetServiceOrderByExternalTicket**
> TsiWebServiceOrderDetail ServiceOrdersGetServiceOrderByExternalTicket (string externalTicketId)

Gets the service order details by external ticket identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderByExternalTicketExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var externalTicketId = externalTicketId_example;  // string | The external ticket identifier.

            try
            {
                // Gets the service order details by external ticket identifier.
                TsiWebServiceOrderDetail result = apiInstance.ServiceOrdersGetServiceOrderByExternalTicket(externalTicketId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderByExternalTicket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalTicketId** | **string**| The external ticket identifier. | 

### Return type

[**TsiWebServiceOrderDetail**](TsiWebServiceOrderDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceordercompletedtasks"></a>
# **ServiceOrdersGetServiceOrderCompletedTasks**
> TsiWebTasksResponse ServiceOrdersGetServiceOrderCompletedTasks (int? serviceOrderNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the service order completed tasks.

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
    public class ServiceOrdersGetServiceOrderCompletedTasksExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the service order completed tasks.
                TsiWebTasksResponse result = apiInstance.ServiceOrdersGetServiceOrderCompletedTasks(serviceOrderNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderCompletedTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
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

<a name="serviceordersgetserviceorderdetail"></a>
# **ServiceOrdersGetServiceOrderDetail**
> TsiWebServiceOrderDetail ServiceOrdersGetServiceOrderDetail (int? serviceOrderNumber)

Gets the service order details.

DateTimeRequested has been deprecated please use DateRequested and TimeRequested instead.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderDetailExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.

            try
            {
                // Gets the service order details.
                TsiWebServiceOrderDetail result = apiInstance.ServiceOrdersGetServiceOrderDetail(serviceOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 

### Return type

[**TsiWebServiceOrderDetail**](TsiWebServiceOrderDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceorderexpense"></a>
# **ServiceOrdersGetServiceOrderExpense**
> TsiWebServiceOrderExpense ServiceOrdersGetServiceOrderExpense (int? serviceOrderNumber, int? serviceOrderExpenseNumber)

Gets a single service orde expense

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderExpenseExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var serviceOrderExpenseNumber = 56;  // int? | 

            try
            {
                // Gets a single service orde expense
                TsiWebServiceOrderExpense result = apiInstance.ServiceOrdersGetServiceOrderExpense(serviceOrderNumber, serviceOrderExpenseNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderExpense: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **serviceOrderExpenseNumber** | **int?**|  | 

### Return type

[**TsiWebServiceOrderExpense**](TsiWebServiceOrderExpense.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceorderexpenses"></a>
# **ServiceOrdersGetServiceOrderExpenses**
> List<TsiWebServiceOrderExpense> ServiceOrdersGetServiceOrderExpenses (int? serviceOrderNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the service order expenses.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderExpensesExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the service order expenses.
                List&lt;TsiWebServiceOrderExpense&gt; result = apiInstance.ServiceOrdersGetServiceOrderExpenses(serviceOrderNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderExpenses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**List<TsiWebServiceOrderExpense>**](TsiWebServiceOrderExpense.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceorderincompletetasks"></a>
# **ServiceOrdersGetServiceOrderIncompleteTasks**
> TsiWebTasksResponse ServiceOrdersGetServiceOrderIncompleteTasks (int? serviceOrderNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the service order incomplete tasks.

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
    public class ServiceOrdersGetServiceOrderIncompleteTasksExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the service order incomplete tasks.
                TsiWebTasksResponse result = apiInstance.ServiceOrdersGetServiceOrderIncompleteTasks(serviceOrderNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderIncompleteTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
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

<a name="serviceordersgetserviceorderitemserviced"></a>
# **ServiceOrdersGetServiceOrderItemServiced**
> TsiWebServiceOrderItemServicedResponse ServiceOrdersGetServiceOrderItemServiced (int? serviceOrderNumber, int? itemServicedNumber)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderItemServicedExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var itemServicedNumber = 56;  // int? | 

            try
            {
                TsiWebServiceOrderItemServicedResponse result = apiInstance.ServiceOrdersGetServiceOrderItemServiced(serviceOrderNumber, itemServicedNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderItemServiced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **itemServicedNumber** | **int?**|  | 

### Return type

[**TsiWebServiceOrderItemServicedResponse**](TsiWebServiceOrderItemServicedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceorderitemsserviced"></a>
# **ServiceOrdersGetServiceOrderItemsServiced**
> TsiWebServiceOrderItemsServicedResponse ServiceOrdersGetServiceOrderItemsServiced (int? serviceOrderNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the service order items serviced.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderItemsServicedExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the service order items serviced.
                TsiWebServiceOrderItemsServicedResponse result = apiInstance.ServiceOrdersGetServiceOrderItemsServiced(serviceOrderNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderItemsServiced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebServiceOrderItemsServicedResponse**](TsiWebServiceOrderItemsServicedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceordernotes"></a>
# **ServiceOrdersGetServiceOrderNotes**
> TsiWebServiceOrderNotesResponse ServiceOrdersGetServiceOrderNotes (int? serviceOrderNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the service order notes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderNotesExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the service order notes.
                TsiWebServiceOrderNotesResponse result = apiInstance.ServiceOrdersGetServiceOrderNotes(serviceOrderNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderNotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebServiceOrderNotesResponse**](TsiWebServiceOrderNotesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceorderparts"></a>
# **ServiceOrdersGetServiceOrderParts**
> TsiWebServiceOrderPartsUsedResponse ServiceOrdersGetServiceOrderParts (int? serviceOrderNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the service order parts used.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderPartsExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the service order parts used.
                TsiWebServiceOrderPartsUsedResponse result = apiInstance.ServiceOrdersGetServiceOrderParts(serviceOrderNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderParts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebServiceOrderPartsUsedResponse**](TsiWebServiceOrderPartsUsedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceorderprofiles"></a>
# **ServiceOrdersGetServiceOrderProfiles**
> TsiWebAssignedMarketingProfilesResponse ServiceOrdersGetServiceOrderProfiles (int? serviceOrderNumber)

Gets the Service order profiles.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderProfilesExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 

            try
            {
                // Gets the Service order profiles.
                TsiWebAssignedMarketingProfilesResponse result = apiInstance.ServiceOrdersGetServiceOrderProfiles(serviceOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 

### Return type

[**TsiWebAssignedMarketingProfilesResponse**](TsiWebAssignedMarketingProfilesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceorderquotes"></a>
# **ServiceOrdersGetServiceOrderQuotes**
> List<TsiWebServiceOrderQuote> ServiceOrdersGetServiceOrderQuotes (int? serviceOrderNumber)

Gets the service order quotes.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderQuotesExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.

            try
            {
                // Gets the service order quotes.
                List&lt;TsiWebServiceOrderQuote&gt; result = apiInstance.ServiceOrdersGetServiceOrderQuotes(serviceOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderQuotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 

### Return type

[**List<TsiWebServiceOrderQuote>**](TsiWebServiceOrderQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceordersubcontractors"></a>
# **ServiceOrdersGetServiceOrderSubContractors**
> TsiWebServiceOrderSubContractorsResponse ServiceOrdersGetServiceOrderSubContractors (int? serviceOrderNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the service order subcontractors.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderSubContractorsExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the service order subcontractors.
                TsiWebServiceOrderSubContractorsResponse result = apiInstance.ServiceOrdersGetServiceOrderSubContractors(serviceOrderNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderSubContractors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebServiceOrderSubContractorsResponse**](TsiWebServiceOrderSubContractorsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceordersummary"></a>
# **ServiceOrdersGetServiceOrderSummary**
> TsiWebServiceOrderSummary ServiceOrdersGetServiceOrderSummary (int? serviceOrderNumber)

Gets the service order summary.

DateTimeRequested has been deprecated please use DateRequested and TimeRequested instead.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderSummaryExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.

            try
            {
                // Gets the service order summary.
                TsiWebServiceOrderSummary result = apiInstance.ServiceOrdersGetServiceOrderSummary(serviceOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 

### Return type

[**TsiWebServiceOrderSummary**](TsiWebServiceOrderSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceordertasks"></a>
# **ServiceOrdersGetServiceOrderTasks**
> TsiWebTasksResponse ServiceOrdersGetServiceOrderTasks (int? serviceOrderNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the service order tasks. Includes both completed and incomplete tasks.

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
    public class ServiceOrdersGetServiceOrderTasksExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the service order tasks. Includes both completed and incomplete tasks.
                TsiWebTasksResponse result = apiInstance.ServiceOrdersGetServiceOrderTasks(serviceOrderNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
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

<a name="serviceordersgetserviceordertimelogs"></a>
# **ServiceOrdersGetServiceOrderTimeLogs**
> TsiWebServiceOrderTimeLogsResponse ServiceOrdersGetServiceOrderTimeLogs (int? serviceOrderNumber, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Gets the service order time logs.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderTimeLogsExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Gets the service order time logs.
                TsiWebServiceOrderTimeLogsResponse result = apiInstance.ServiceOrdersGetServiceOrderTimeLogs(serviceOrderNumber, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderTimeLogs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebServiceOrderTimeLogsResponse**](TsiWebServiceOrderTimeLogsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersgetserviceordertimelogsbylognumber"></a>
# **ServiceOrdersGetServiceOrderTimeLogsByLogNumber**
> TsiWebServiceOrderTimeLogsResponse ServiceOrdersGetServiceOrderTimeLogsByLogNumber (int? serviceOrderNumber, int? timeLogNumber)

Gets the service order time logs based on the log ID.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersGetServiceOrderTimeLogsByLogNumberExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var timeLogNumber = 56;  // int? | service order time log ID

            try
            {
                // Gets the service order time logs based on the log ID.
                TsiWebServiceOrderTimeLogsResponse result = apiInstance.ServiceOrdersGetServiceOrderTimeLogsByLogNumber(serviceOrderNumber, timeLogNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersGetServiceOrderTimeLogsByLogNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **timeLogNumber** | **int?**| service order time log ID | 

### Return type

[**TsiWebServiceOrderTimeLogsResponse**](TsiWebServiceOrderTimeLogsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchbyagreementnumber"></a>
# **ServiceOrdersSearchByAgreementNumber**
> TsiWebSearchServiceOrderResponse ServiceOrdersSearchByAgreementNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search service orders using an agreement number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchByAgreementNumberExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search service orders using an agreement number.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersSearchByAgreementNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchByAgreementNumber: " + e.Message );
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

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchbycustomfield"></a>
# **ServiceOrdersSearchByCustomField**
> TsiWebSearchServiceOrderResponse ServiceOrdersSearchByCustomField (TsiWebCustomFieldSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search Service Orders using a custom category and field label.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchByCustomFieldExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var model = new TsiWebCustomFieldSearchModel(); // TsiWebCustomFieldSearchModel | A {Tsi.Web.CustomFieldSearchModel}
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search Service Orders using a custom category and field label.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersSearchByCustomField(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchByCustomField: " + e.Message );
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

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchbycustomerpurchaseorder"></a>
# **ServiceOrdersSearchByCustomerPurchaseOrder**
> TsiWebSearchServiceOrderResponse ServiceOrdersSearchByCustomerPurchaseOrder (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search service orders using customer purchase order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchByCustomerPurchaseOrderExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search service orders using customer purchase order.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersSearchByCustomerPurchaseOrder(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchByCustomerPurchaseOrder: " + e.Message );
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

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchbyexternalproduct"></a>
# **ServiceOrdersSearchByExternalProduct**
> TsiWebSearchServiceOrderResponse ServiceOrdersSearchByExternalProduct (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search service orders using an external product name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchByExternalProductExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var criteria = criteria_example;  // string | An external product name, full name required.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search service orders using an external product name.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersSearchByExternalProduct(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchByExternalProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| An external product name, full name required. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchbyinvoicenumber"></a>
# **ServiceOrdersSearchByInvoiceNumber**
> TsiWebSearchServiceOrderResponse ServiceOrdersSearchByInvoiceNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search service orders using invoice number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchByInvoiceNumberExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search service orders using invoice number.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersSearchByInvoiceNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchByInvoiceNumber: " + e.Message );
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

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchbyitemserviced"></a>
# **ServiceOrdersSearchByItemServiced**
> TsiWebSearchServiceOrderResponse ServiceOrdersSearchByItemServiced (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search service orders using items serviced.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchByItemServicedExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search service orders using items serviced.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersSearchByItemServiced(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchByItemServiced: " + e.Message );
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

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchbyreference"></a>
# **ServiceOrdersSearchByReference**
> TsiWebSearchServiceOrderResponse ServiceOrdersSearchByReference (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search service orders using reference value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchByReferenceExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search service orders using reference value.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersSearchByReference(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchByReference: " + e.Message );
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

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchbyserviceordernumber"></a>
# **ServiceOrdersSearchByServiceOrderNumber**
> TsiWebSearchServiceOrderResponse ServiceOrdersSearchByServiceOrderNumber (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search service orders using service order number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchByServiceOrderNumberExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var criteria = criteria_example;  // string | A JSON or XML string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search service orders using service order number.
                TsiWebSearchServiceOrderResponse result = apiInstance.ServiceOrdersSearchByServiceOrderNumber(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchByServiceOrderNumber: " + e.Message );
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

[**TsiWebSearchServiceOrderResponse**](TsiWebSearchServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchexpensebyacceptancestatus"></a>
# **ServiceOrdersSearchExpenseByAcceptanceStatus**
> TsiWebServiceOrderExpenseSearchResponse ServiceOrdersSearchExpenseByAcceptanceStatus (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search expenses using an acceptanc estatus.

Valid criteria is an integer to specify the rep requested.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchExpenseByAcceptanceStatusExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var criteria = criteria_example;  // string | A string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search expenses using an acceptanc estatus.
                TsiWebServiceOrderExpenseSearchResponse result = apiInstance.ServiceOrdersSearchExpenseByAcceptanceStatus(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchExpenseByAcceptanceStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebServiceOrderExpenseSearchResponse**](TsiWebServiceOrderExpenseSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchexpensebyexpensedate"></a>
# **ServiceOrdersSearchExpenseByExpenseDate**
> TsiWebServiceOrderExpenseSearchResponse ServiceOrdersSearchExpenseByExpenseDate (TsiWebDateTimeSearchModel model, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search expenses using an expense date.

Valid criteria is a date.  <p>Valid MatchTypes are GreaterThan, GreaterThanEqual, Equal, LessThan, LessThanEqual. </p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchExpenseByExpenseDateExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var model = new TsiWebDateTimeSearchModel(); // TsiWebDateTimeSearchModel | 
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search expenses using an expense date.
                TsiWebServiceOrderExpenseSearchResponse result = apiInstance.ServiceOrdersSearchExpenseByExpenseDate(model, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchExpenseByExpenseDate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebDateTimeSearchModel**](TsiWebDateTimeSearchModel.md)|  | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebServiceOrderExpenseSearchResponse**](TsiWebServiceOrderExpenseSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchexpensebyexpensetype"></a>
# **ServiceOrdersSearchExpenseByExpenseType**
> TsiWebServiceOrderExpenseSearchResponse ServiceOrdersSearchExpenseByExpenseType (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search expenses using an expense type.

Valid criteria is a string with the expense type description or an integer expense type number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchExpenseByExpenseTypeExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var criteria = criteria_example;  // string | A string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search expenses using an expense type.
                TsiWebServiceOrderExpenseSearchResponse result = apiInstance.ServiceOrdersSearchExpenseByExpenseType(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchExpenseByExpenseType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebServiceOrderExpenseSearchResponse**](TsiWebServiceOrderExpenseSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssearchexpensebytechnician"></a>
# **ServiceOrdersSearchExpenseByTechnician**
> TsiWebServiceOrderExpenseSearchResponse ServiceOrdersSearchExpenseByTechnician (string criteria, int? pageRequestPageSize = null, int? pageRequestStartRow = null)

Search expenses using a technician name.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSearchExpenseByTechnicianExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var criteria = criteria_example;  // string | A string containing the criteria.
            var pageRequestPageSize = 56;  // int? |  (optional) 
            var pageRequestStartRow = 56;  // int? |  (optional) 

            try
            {
                // Search expenses using a technician name.
                TsiWebServiceOrderExpenseSearchResponse result = apiInstance.ServiceOrdersSearchExpenseByTechnician(criteria, pageRequestPageSize, pageRequestStartRow);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSearchExpenseByTechnician: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **criteria** | **string**| A string containing the criteria. | 
 **pageRequestPageSize** | **int?**|  | [optional] 
 **pageRequestStartRow** | **int?**|  | [optional] 

### Return type

[**TsiWebServiceOrderExpenseSearchResponse**](TsiWebServiceOrderExpenseSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderssetserviceorderprofile"></a>
# **ServiceOrdersSetServiceOrderProfile**
> TsiWebAssignedMarketingProfilesResponse ServiceOrdersSetServiceOrderProfile (int? serviceOrderNumber, string profile)

Assigns a profile to a service order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersSetServiceOrderProfileExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var profile = profile_example;  // string | The profile to assign.

            try
            {
                // Assigns a profile to a service order.
                TsiWebAssignedMarketingProfilesResponse result = apiInstance.ServiceOrdersSetServiceOrderProfile(serviceOrderNumber, profile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersSetServiceOrderProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **profile** | **string**| The profile to assign. | 

### Return type

[**TsiWebAssignedMarketingProfilesResponse**](TsiWebAssignedMarketingProfilesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceorderstimelogadvancedsearch"></a>
# **ServiceOrdersTimeLogAdvancedSearch**
> TsiWebSearchTimeLogResponse ServiceOrdersTimeLogAdvancedSearch (TsiWebAdvancedSearchRequest request)

Advanced search for service orders time logs.

Valid SearchType = TimeLogNumber,TechAssigned, LogReason,StartDate,EndDate.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersTimeLogAdvancedSearchExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var request = new TsiWebAdvancedSearchRequest(); // TsiWebAdvancedSearchRequest | An AdvancedSearchRequest

            try
            {
                // Advanced search for service orders time logs.
                TsiWebSearchTimeLogResponse result = apiInstance.ServiceOrdersTimeLogAdvancedSearch(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersTimeLogAdvancedSearch: " + e.Message );
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

[**TsiWebSearchTimeLogResponse**](TsiWebSearchTimeLogResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdatecustomfields"></a>
# **ServiceOrdersUpdateCustomFields**
> TsiWebCustomFieldsResponse ServiceOrdersUpdateCustomFields (int? serviceOrderNumber, List<TsiWebCustomField> customFields)

Updates account custom fields.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateCustomFieldsExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The account number.
            var customFields = new List<TsiWebCustomField>(); // List<TsiWebCustomField> | The custom fields.

            try
            {
                // Updates account custom fields.
                TsiWebCustomFieldsResponse result = apiInstance.ServiceOrdersUpdateCustomFields(serviceOrderNumber, customFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateCustomFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The account number. | 
 **customFields** | [**List&lt;TsiWebCustomField&gt;**](TsiWebCustomField.md)| The custom fields. | 

### Return type

[**TsiWebCustomFieldsResponse**](TsiWebCustomFieldsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateexpense"></a>
# **ServiceOrdersUpdateExpense**
> TsiWebServiceOrderExpensesResponse ServiceOrdersUpdateExpense (int? serviceOrderNumber, int? expenseNumber, TsiWebUpdateExpenseModel model)

Updates an expense.

The DistanceType field accepts values \"DoNotChangeDistance\", \"SetByEndOdometer\", or \"SetByDistance\".      <p>The AcceptanceStatus field accepts values \"Open\", \"Accepted\", \"Questioned\", or \"Resubmitted\".</p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateExpenseExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var expenseNumber = 56;  // int? | 
            var model = new TsiWebUpdateExpenseModel(); // TsiWebUpdateExpenseModel | 

            try
            {
                // Updates an expense.
                TsiWebServiceOrderExpensesResponse result = apiInstance.ServiceOrdersUpdateExpense(serviceOrderNumber, expenseNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateExpense: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **expenseNumber** | **int?**|  | 
 **model** | [**TsiWebUpdateExpenseModel**](TsiWebUpdateExpenseModel.md)|  | 

### Return type

[**TsiWebServiceOrderExpensesResponse**](TsiWebServiceOrderExpensesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdatemanagedserviceorder"></a>
# **ServiceOrdersUpdateManagedServiceOrder**
> TsiWebServiceOrderResponse ServiceOrdersUpdateManagedServiceOrder (TsiWebUpdateManagedServiceOrderModel model)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateManagedServiceOrderExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var model = new TsiWebUpdateManagedServiceOrderModel(); // TsiWebUpdateManagedServiceOrderModel | 

            try
            {
                TsiWebServiceOrderResponse result = apiInstance.ServiceOrdersUpdateManagedServiceOrder(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateManagedServiceOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebUpdateManagedServiceOrderModel**](TsiWebUpdateManagedServiceOrderModel.md)|  | 

### Return type

[**TsiWebServiceOrderResponse**](TsiWebServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateserviceorder"></a>
# **ServiceOrdersUpdateServiceOrder**
> TsiWebServiceOrderResponse ServiceOrdersUpdateServiceOrder (int? serviceOrderNumber, TsiWebUpdateServiceOrderModel model)

Updates the service order.

DateTimeRequested is an optional SplitDateTime type. Json format is \"DateTimeRequested\":{\"Date\":\"2018-03-06T00:00:00\", \"Time\":\"1900-01-01T14:09:02\"}

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateServiceOrderExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var model = new TsiWebUpdateServiceOrderModel(); // TsiWebUpdateServiceOrderModel | The update service order model

            try
            {
                // Updates the service order.
                TsiWebServiceOrderResponse result = apiInstance.ServiceOrdersUpdateServiceOrder(serviceOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateServiceOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **model** | [**TsiWebUpdateServiceOrderModel**](TsiWebUpdateServiceOrderModel.md)| The update service order model | 

### Return type

[**TsiWebServiceOrderResponse**](TsiWebServiceOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateserviceorderitemserviced"></a>
# **ServiceOrdersUpdateServiceOrderItemServiced**
> TsiWebServiceOrderItemServicedResponse ServiceOrdersUpdateServiceOrderItemServiced (int? serviceOrderNumber, int? itemServicedNumber, TsiWebUpdateServiceOrderItemServicedModel model)

Updates the item serviced

The UpdateContractMetersType accepts values \"DoNotUpdate\", \"UpdateByReading\", or \"UpdateByClicksUsed\".

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateServiceOrderItemServicedExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var itemServicedNumber = 56;  // int? | 
            var model = new TsiWebUpdateServiceOrderItemServicedModel(); // TsiWebUpdateServiceOrderItemServicedModel | 

            try
            {
                // Updates the item serviced
                TsiWebServiceOrderItemServicedResponse result = apiInstance.ServiceOrdersUpdateServiceOrderItemServiced(serviceOrderNumber, itemServicedNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateServiceOrderItemServiced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **itemServicedNumber** | **int?**|  | 
 **model** | [**TsiWebUpdateServiceOrderItemServicedModel**](TsiWebUpdateServiceOrderItemServicedModel.md)|  | 

### Return type

[**TsiWebServiceOrderItemServicedResponse**](TsiWebServiceOrderItemServicedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateserviceordernonstockpartsused"></a>
# **ServiceOrdersUpdateServiceOrderNonStockPartsUsed**
> TsiWebServiceOrderPartsUsedResponse ServiceOrdersUpdateServiceOrderNonStockPartsUsed (int? serviceOrderNumber, int? partNumber, TsiWebUpdateServiceOrderNonStockPartsUsedModel model)

Updates a non-stock part.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateServiceOrderNonStockPartsUsedExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var partNumber = 56;  // int? | The part number.
            var model = new TsiWebUpdateServiceOrderNonStockPartsUsedModel(); // TsiWebUpdateServiceOrderNonStockPartsUsedModel | 

            try
            {
                // Updates a non-stock part.
                TsiWebServiceOrderPartsUsedResponse result = apiInstance.ServiceOrdersUpdateServiceOrderNonStockPartsUsed(serviceOrderNumber, partNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateServiceOrderNonStockPartsUsed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **partNumber** | **int?**| The part number. | 
 **model** | [**TsiWebUpdateServiceOrderNonStockPartsUsedModel**](TsiWebUpdateServiceOrderNonStockPartsUsedModel.md)|  | 

### Return type

[**TsiWebServiceOrderPartsUsedResponse**](TsiWebServiceOrderPartsUsedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateserviceordernote"></a>
# **ServiceOrdersUpdateServiceOrderNote**
> TsiWebServiceOrderNoteResponse ServiceOrdersUpdateServiceOrderNote (int? serviceOrderNumber, int? serviceOrderNoteNumber, TsiWebServiceOrderNoteModel model)

Updates a service order note.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateServiceOrderNoteExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var serviceOrderNoteNumber = 56;  // int? | 
            var model = new TsiWebServiceOrderNoteModel(); // TsiWebServiceOrderNoteModel | 

            try
            {
                // Updates a service order note.
                TsiWebServiceOrderNoteResponse result = apiInstance.ServiceOrdersUpdateServiceOrderNote(serviceOrderNumber, serviceOrderNoteNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateServiceOrderNote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **serviceOrderNoteNumber** | **int?**|  | 
 **model** | [**TsiWebServiceOrderNoteModel**](TsiWebServiceOrderNoteModel.md)|  | 

### Return type

[**TsiWebServiceOrderNoteResponse**](TsiWebServiceOrderNoteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateserviceorderpartsused"></a>
# **ServiceOrdersUpdateServiceOrderPartsUsed**
> TsiWebServiceOrderPartsUsedResponse ServiceOrdersUpdateServiceOrderPartsUsed (int? serviceOrderNumber, int? partNumber, TsiWebUpdateServiceOrderPartsUsedModel model)

Updates a part on a service order.

The UseBookPricesAndDiscounts field is required; if it is true then Price Levels will be used, if it is false then Sell Price will be used. To change the estimated cost UseBookPricesAndDiscounts must have a value.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateServiceOrderPartsUsedExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number.
            var partNumber = 56;  // int? | The part number.
            var model = new TsiWebUpdateServiceOrderPartsUsedModel(); // TsiWebUpdateServiceOrderPartsUsedModel | 

            try
            {
                // Updates a part on a service order.
                TsiWebServiceOrderPartsUsedResponse result = apiInstance.ServiceOrdersUpdateServiceOrderPartsUsed(serviceOrderNumber, partNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateServiceOrderPartsUsed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number. | 
 **partNumber** | **int?**| The part number. | 
 **model** | [**TsiWebUpdateServiceOrderPartsUsedModel**](TsiWebUpdateServiceOrderPartsUsedModel.md)|  | 

### Return type

[**TsiWebServiceOrderPartsUsedResponse**](TsiWebServiceOrderPartsUsedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateserviceorderpartsusedassemblydetail"></a>
# **ServiceOrdersUpdateServiceOrderPartsUsedAssemblyDetail**
> TsiWebServiceOrderPartUsedResponse ServiceOrdersUpdateServiceOrderPartsUsedAssemblyDetail (int? serviceOrderNumber, int? partsUsedNumber, int? partUsedAssemblyDetailNumber, TsiWebUpdateServiceOrderPartsUsedAssemblyDetailModel model)

Updates the assembly detail for a service order part

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateServiceOrderPartsUsedAssemblyDetailExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var partsUsedNumber = 56;  // int? | 
            var partUsedAssemblyDetailNumber = 56;  // int? | 
            var model = new TsiWebUpdateServiceOrderPartsUsedAssemblyDetailModel(); // TsiWebUpdateServiceOrderPartsUsedAssemblyDetailModel | 

            try
            {
                // Updates the assembly detail for a service order part
                TsiWebServiceOrderPartUsedResponse result = apiInstance.ServiceOrdersUpdateServiceOrderPartsUsedAssemblyDetail(serviceOrderNumber, partsUsedNumber, partUsedAssemblyDetailNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateServiceOrderPartsUsedAssemblyDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **partsUsedNumber** | **int?**|  | 
 **partUsedAssemblyDetailNumber** | **int?**|  | 
 **model** | [**TsiWebUpdateServiceOrderPartsUsedAssemblyDetailModel**](TsiWebUpdateServiceOrderPartsUsedAssemblyDetailModel.md)|  | 

### Return type

[**TsiWebServiceOrderPartUsedResponse**](TsiWebServiceOrderPartUsedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateserviceorderpartsusedcomment"></a>
# **ServiceOrdersUpdateServiceOrderPartsUsedComment**
> TsiWebServiceOrderPartUsedResponse ServiceOrdersUpdateServiceOrderPartsUsedComment (int? serviceOrderNumber, int? partNumber, TsiWebServiceOrderPartsUsedCommentModel model)

Updates a line item comment for the service order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateServiceOrderPartsUsedCommentExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var partNumber = 56;  // int? | 
            var model = new TsiWebServiceOrderPartsUsedCommentModel(); // TsiWebServiceOrderPartsUsedCommentModel | 

            try
            {
                // Updates a line item comment for the service order.
                TsiWebServiceOrderPartUsedResponse result = apiInstance.ServiceOrdersUpdateServiceOrderPartsUsedComment(serviceOrderNumber, partNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateServiceOrderPartsUsedComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **partNumber** | **int?**|  | 
 **model** | [**TsiWebServiceOrderPartsUsedCommentModel**](TsiWebServiceOrderPartsUsedCommentModel.md)|  | 

### Return type

[**TsiWebServiceOrderPartUsedResponse**](TsiWebServiceOrderPartUsedResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateserviceorderresolution"></a>
# **ServiceOrdersUpdateServiceOrderResolution**
> TsiWebServiceOrderResolutionResponse ServiceOrdersUpdateServiceOrderResolution (int? serviceOrderNumber, int? resolutionIndex, string resolution)

Updates a resolution on a service order, acceptable values are 1-5

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateServiceOrderResolutionExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var resolutionIndex = 56;  // int? | 
            var resolution = resolution_example;  // string | 

            try
            {
                // Updates a resolution on a service order, acceptable values are 1-5
                TsiWebServiceOrderResolutionResponse result = apiInstance.ServiceOrdersUpdateServiceOrderResolution(serviceOrderNumber, resolutionIndex, resolution);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateServiceOrderResolution: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **resolutionIndex** | **int?**|  | 
 **resolution** | **string**|  | 

### Return type

[**TsiWebServiceOrderResolutionResponse**](TsiWebServiceOrderResolutionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateserviceordersymptom"></a>
# **ServiceOrdersUpdateServiceOrderSymptom**
> TsiWebServiceOrderSymptomResponse ServiceOrdersUpdateServiceOrderSymptom (int? serviceOrderNumber, int? symptomIndex, string symptom)

Updates a symptom on a service order, acceptable values are 1-5

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateServiceOrderSymptomExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var symptomIndex = 56;  // int? | 
            var symptom = symptom_example;  // string | 

            try
            {
                // Updates a symptom on a service order, acceptable values are 1-5
                TsiWebServiceOrderSymptomResponse result = apiInstance.ServiceOrdersUpdateServiceOrderSymptom(serviceOrderNumber, symptomIndex, symptom);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateServiceOrderSymptom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **symptomIndex** | **int?**|  | 
 **symptom** | **string**|  | 

### Return type

[**TsiWebServiceOrderSymptomResponse**](TsiWebServiceOrderSymptomResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceordersupdateserviceordertimelog"></a>
# **ServiceOrdersUpdateServiceOrderTimeLog**
> TsiWebServiceOrderTimeLogResponse ServiceOrdersUpdateServiceOrderTimeLog (int? serviceOrderNumber, int? timeLogNumber, TsiWebUpdateServiceOrderTimeLogModel model)

Updates a service order time log.

Valid billing option types are - \"InvoiceCustomer\", \"ApplyToContract\", \"ApplyToContractAndBillcustomer\", \"DoNotInvoice\",   <P>  Valid rate basis values are - \"Regular\", \"Overtime\", \"Premium\", \"Standard\", \"AccountDefault\", \"PriceBook\", \"FlatFee\", \"Manual\".  </P><P>  Valid copy indicator type values are - \"DoNotCopy,\"CopyWhenSaving,\"CopyWhenClosingLog\".  </P><P>  Valid time to invoice type values are - \"BillableHoursMinutes\", \"UtilizedTime\", \"RoundedMinimunUtilizedtime\", \"ActualTime\", \"RoundedMinimunActualTime\".  </P><P>  Valid acceptance status type values are - \"None\", \"Accepted\", \"Questioned\", \"Resubmitted\",.  </P><P>  If the user does have \"CanAdjustUtilizationHours\" permission, the deductible hours and minutes will not be updated.  </P><p>  If the user does have \"CanOverrideLaborRateOnTimeLogs\" permissions, then logreason labor rate, rate basis and rate type will not be updated.  </p>

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceOrdersUpdateServiceOrderTimeLogExample
    {
        public void main()
        {
            var apiInstance = new ServiceOrdersApi();
            var serviceOrderNumber = 56;  // int? | The service order number
            var timeLogNumber = 56;  // int? | The time log number
            var model = new TsiWebUpdateServiceOrderTimeLogModel(); // TsiWebUpdateServiceOrderTimeLogModel | The update service order time log model.

            try
            {
                // Updates a service order time log.
                TsiWebServiceOrderTimeLogResponse result = apiInstance.ServiceOrdersUpdateServiceOrderTimeLog(serviceOrderNumber, timeLogNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceOrdersApi.ServiceOrdersUpdateServiceOrderTimeLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**| The service order number | 
 **timeLogNumber** | **int?**| The time log number | 
 **model** | [**TsiWebUpdateServiceOrderTimeLogModel**](TsiWebUpdateServiceOrderTimeLogModel.md)| The update service order time log model. | 

### Return type

[**TsiWebServiceOrderTimeLogResponse**](TsiWebServiceOrderTimeLogResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

