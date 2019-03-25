# IO.Swagger.Api.PurchaseOrdersApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PurchaseOrdersCreatePurchaseOrder**](PurchaseOrdersApi.md#purchaseorderscreatepurchaseorder) | **POST** /api/PurchaseOrders | Creates a purchase order.
[**PurchaseOrdersGetCreateServiceOrderItemsWorkOrderLowestCostVendor**](PurchaseOrdersApi.md#purchaseordersgetcreateserviceorderitemsworkorderlowestcostvendor) | **GET** /api/serviceorders/{serviceOrderNumber}/purchaseorder/neededItems/lowestcostvendors | Retrieve vendor item lists from service order using the price book item&#39;s lowest cost vendor.
[**PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOneVendor**](PurchaseOrdersApi.md#purchaseordersgetcreateserviceorderitemsworkorderonevendor) | **GET** /api/serviceorders/{serviceOrderNumber}/purchaseorder/neededItems/onevendor | Retrieve vendor item lists from service order using the price book item&#39;s lowest cost vendor.
[**PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOrderPrimaryVendor**](PurchaseOrdersApi.md#purchaseordersgetcreateserviceorderitemsworkorderorderprimaryvendor) | **GET** /api/serviceorders/{serviceOrderNumber}/purchaseorder/neededItems/orderprimaryvendors | Retrieve vendor item lists from service orders using the item&#39;s primary vendor on the order.
[**PurchaseOrdersGetCreateServiceOrderItemsWorkOrderPriceBookPrimaryVendor**](PurchaseOrdersApi.md#purchaseordersgetcreateserviceorderitemsworkorderpricebookprimaryvendor) | **GET** /api/serviceorders/{serviceOrderNumber}/purchaseorder/neededItems/pricebookprimaryvendors | Retrieve vendor item lists from service order using the price book item&#39;s primary vendor.
[**PurchaseOrdersGetPurchaseOrderDetail**](PurchaseOrdersApi.md#purchaseordersgetpurchaseorderdetail) | **GET** /api/purchaseorders/{purchaseOrderNumber}/details | Gets the purchase order details.
[**PurchaseOrdersGetPurchaseOrderLineItemReciepts**](PurchaseOrdersApi.md#purchaseordersgetpurchaseorderlineitemreciepts) | **GET** /api/purchaseorders/{purchaseOrderNumber}/items/{purchaseOrderLineItemNumber}/receipts | Returns the receipts on the line items.
[**PurchaseOrdersGetPurchaseOrderLineItemSerialNumbers**](PurchaseOrdersApi.md#purchaseordersgetpurchaseorderlineitemserialnumbers) | **GET** /api/purchaseorders/{purchaseOrderNumber}/items/{purchaseOrderLineItemNumber}/serialnumbers | Returns the serial numbers on the line item.
[**PurchaseOrdersGetPurchaseOrderLineItems**](PurchaseOrdersApi.md#purchaseordersgetpurchaseorderlineitems) | **GET** /api/purchaseorders/{purchaseOrderNumber}/items | Returns the line items on the purchase order.
[**PurchaseOrdersGetPurchaseOrderSummary**](PurchaseOrdersApi.md#purchaseordersgetpurchaseordersummary) | **GET** /api/purchaseorders/{purchaseOrderNumber} | Gets the purchase order summary.
[**PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderLowestCostVendor**](PurchaseOrdersApi.md#purchaseordersgetpurchaseordervendoritemsworkorderlowestcostvendor) | **GET** /api/quotes/{quoteNumber}/purchaseorder/neededItems/lowestcostvendors | Retrieve vendor item lists from work order using the price book item&#39;s lowest cost vendor.
[**PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOneVendor**](PurchaseOrdersApi.md#purchaseordersgetpurchaseordervendoritemsworkorderonevendor) | **GET** /api/quotes/{quoteNumber}/purchaseorder/neededItems/onevendor | Retrieve vendor item lists work order using the price book item&#39;s lowest cost vendor.
[**PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOrderPrimaryVendor**](PurchaseOrdersApi.md#purchaseordersgetpurchaseordervendoritemsworkorderorderprimaryvendor) | **GET** /api/quotes/{quoteNumber}/purchaseorder/neededItems/orderprimaryvendors | Retrieve vendor item lists from work order using the item&#39;s primary vendor on the order.
[**PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderPriceBookPrimaryVendor**](PurchaseOrdersApi.md#purchaseordersgetpurchaseordervendoritemsworkorderpricebookprimaryvendor) | **GET** /api/quotes/{quoteNumber}/purchaseorder/neededItems/pricebookprimaryvendors | Retrieve vendor item lists from work order using the price book item&#39;s primary vendor.
[**PurchaseOrdersUpdatePurchaseOrder**](PurchaseOrdersApi.md#purchaseordersupdatepurchaseorder) | **PUT** /api/purchaseorders/{purchaseOrderNumber} | Updates a purchase order.


<a name="purchaseorderscreatepurchaseorder"></a>
# **PurchaseOrdersCreatePurchaseOrder**
> TsiWebCreatePurchaseOrderResponse PurchaseOrdersCreatePurchaseOrder (TsiWebCreatePurchaseOrderModel model)

Creates a purchase order.

AssemblyCostToUseType : Base, Average, Latest, OrderDetailEstimatedCost.<br />  ShipToAddressType: Default,PrimaryAlternate, AccountNumber,None,AlternateAddressId.<br />  BillToAddressType: Default,PrimaryAlternate, AccountNumber,None,AlternateAddressId.<br />  UseVendorCostInPriceBook: if true the cost for pricebook items will be overriden if the vendor is configured with a cost on the price book item. Not applicable if CostToUseType = OrderDetailEstimatedCost<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersCreatePurchaseOrderExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var model = new TsiWebCreatePurchaseOrderModel(); // TsiWebCreatePurchaseOrderModel | 

            try
            {
                // Creates a purchase order.
                TsiWebCreatePurchaseOrderResponse result = apiInstance.PurchaseOrdersCreatePurchaseOrder(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersCreatePurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TsiWebCreatePurchaseOrderModel**](TsiWebCreatePurchaseOrderModel.md)|  | 

### Return type

[**TsiWebCreatePurchaseOrderResponse**](TsiWebCreatePurchaseOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetcreateserviceorderitemsworkorderlowestcostvendor"></a>
# **PurchaseOrdersGetCreateServiceOrderItemsWorkOrderLowestCostVendor**
> TsiWebPurchaseOrderVendorItemsResponse PurchaseOrdersGetCreateServiceOrderItemsWorkOrderLowestCostVendor (int? serviceOrderNumber, string purchaseOrderCostToUseType = null, int? vendorAccountNumber = null, int? orderItemsInPhaseNumber = null, bool? orderItemsInPhase = null, bool? orderLaborItems = null, bool? orderOnlyInsufficentItems = null, bool? orderVendorlessItems = null)

Retrieve vendor item lists from service order using the price book item's lowest cost vendor.

purchaseOrderCostToUseType : Base, Average, Latest, OrderDetailEstimatedCost - - the order item cost will only be used if \"Use  this estimated cost when purchasing\" is selected on the work/serivce order item, otherwise the base price will be used. <br />  orderItemsInPhaseNumber: null for all phases, 0 for no phase, or the specific number for that phase.<br />  orderVendorlessItems: if true a value is required for VendorAcountNumber.<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetCreateServiceOrderItemsWorkOrderLowestCostVendorExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var purchaseOrderCostToUseType = purchaseOrderCostToUseType_example;  // string |  (optional) 
            var vendorAccountNumber = 56;  // int? |  (optional) 
            var orderItemsInPhaseNumber = 56;  // int? |  (optional) 
            var orderItemsInPhase = true;  // bool? |  (optional) 
            var orderLaborItems = true;  // bool? |  (optional) 
            var orderOnlyInsufficentItems = true;  // bool? |  (optional) 
            var orderVendorlessItems = true;  // bool? |  (optional) 

            try
            {
                // Retrieve vendor item lists from service order using the price book item's lowest cost vendor.
                TsiWebPurchaseOrderVendorItemsResponse result = apiInstance.PurchaseOrdersGetCreateServiceOrderItemsWorkOrderLowestCostVendor(serviceOrderNumber, purchaseOrderCostToUseType, vendorAccountNumber, orderItemsInPhaseNumber, orderItemsInPhase, orderLaborItems, orderOnlyInsufficentItems, orderVendorlessItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetCreateServiceOrderItemsWorkOrderLowestCostVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **purchaseOrderCostToUseType** | **string**|  | [optional] 
 **vendorAccountNumber** | **int?**|  | [optional] 
 **orderItemsInPhaseNumber** | **int?**|  | [optional] 
 **orderItemsInPhase** | **bool?**|  | [optional] 
 **orderLaborItems** | **bool?**|  | [optional] 
 **orderOnlyInsufficentItems** | **bool?**|  | [optional] 
 **orderVendorlessItems** | **bool?**|  | [optional] 

### Return type

[**TsiWebPurchaseOrderVendorItemsResponse**](TsiWebPurchaseOrderVendorItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetcreateserviceorderitemsworkorderonevendor"></a>
# **PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOneVendor**
> TsiWebPurchaseOrderVendorItemsResponse PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOneVendor (int? serviceOrderNumber, string purchaseOrderCostToUseType = null, int? vendorAccountNumber = null, int? orderItemsInPhaseNumber = null, bool? orderItemsInPhase = null, bool? orderLaborItems = null, bool? orderOnlyInsufficentItems = null, bool? orderVendorlessItems = null)

Retrieve vendor item lists from service order using the price book item's lowest cost vendor.

A value is required for VendorAcountNumber.<br />  purchaseOrderCostToUseType : Base, Average, Latest, OrderDetailEstimatedCost - - the order item cost will only be used if \"Use  this estimated cost when purchasing\" is selected on the work/serivce order item, otherwise the base price will be used. <br />  orderItemsInPhaseNumber: null for all phases, 0 for no phase, or the specific number for that phase.<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOneVendorExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var purchaseOrderCostToUseType = purchaseOrderCostToUseType_example;  // string |  (optional) 
            var vendorAccountNumber = 56;  // int? |  (optional) 
            var orderItemsInPhaseNumber = 56;  // int? |  (optional) 
            var orderItemsInPhase = true;  // bool? |  (optional) 
            var orderLaborItems = true;  // bool? |  (optional) 
            var orderOnlyInsufficentItems = true;  // bool? |  (optional) 
            var orderVendorlessItems = true;  // bool? |  (optional) 

            try
            {
                // Retrieve vendor item lists from service order using the price book item's lowest cost vendor.
                TsiWebPurchaseOrderVendorItemsResponse result = apiInstance.PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOneVendor(serviceOrderNumber, purchaseOrderCostToUseType, vendorAccountNumber, orderItemsInPhaseNumber, orderItemsInPhase, orderLaborItems, orderOnlyInsufficentItems, orderVendorlessItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOneVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **purchaseOrderCostToUseType** | **string**|  | [optional] 
 **vendorAccountNumber** | **int?**|  | [optional] 
 **orderItemsInPhaseNumber** | **int?**|  | [optional] 
 **orderItemsInPhase** | **bool?**|  | [optional] 
 **orderLaborItems** | **bool?**|  | [optional] 
 **orderOnlyInsufficentItems** | **bool?**|  | [optional] 
 **orderVendorlessItems** | **bool?**|  | [optional] 

### Return type

[**TsiWebPurchaseOrderVendorItemsResponse**](TsiWebPurchaseOrderVendorItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetcreateserviceorderitemsworkorderorderprimaryvendor"></a>
# **PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOrderPrimaryVendor**
> TsiWebPurchaseOrderVendorItemsResponse PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOrderPrimaryVendor (int? serviceOrderNumber, string purchaseOrderCostToUseType = null, int? vendorAccountNumber = null, int? orderItemsInPhaseNumber = null, bool? orderItemsInPhase = null, bool? orderLaborItems = null, bool? orderOnlyInsufficentItems = null, bool? orderVendorlessItems = null)

Retrieve vendor item lists from service orders using the item's primary vendor on the order.

purchaseOrderCostToUseType : Base, Average, Latest, OrderDetailEstimatedCost - - the order item cost will only be used if \"Use  this estimated cost when purchasing\" is selected on the work/serivce order item, otherwise the base price will be used. <br />  orderItemsInPhaseNumber: null for all phases, 0 for no phase, or the specific number for that phase.<br />  orderVendorlessItems: if true a value is required for VendorAcountNumber.<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOrderPrimaryVendorExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var purchaseOrderCostToUseType = purchaseOrderCostToUseType_example;  // string |  (optional) 
            var vendorAccountNumber = 56;  // int? |  (optional) 
            var orderItemsInPhaseNumber = 56;  // int? |  (optional) 
            var orderItemsInPhase = true;  // bool? |  (optional) 
            var orderLaborItems = true;  // bool? |  (optional) 
            var orderOnlyInsufficentItems = true;  // bool? |  (optional) 
            var orderVendorlessItems = true;  // bool? |  (optional) 

            try
            {
                // Retrieve vendor item lists from service orders using the item's primary vendor on the order.
                TsiWebPurchaseOrderVendorItemsResponse result = apiInstance.PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOrderPrimaryVendor(serviceOrderNumber, purchaseOrderCostToUseType, vendorAccountNumber, orderItemsInPhaseNumber, orderItemsInPhase, orderLaborItems, orderOnlyInsufficentItems, orderVendorlessItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetCreateServiceOrderItemsWorkOrderOrderPrimaryVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **purchaseOrderCostToUseType** | **string**|  | [optional] 
 **vendorAccountNumber** | **int?**|  | [optional] 
 **orderItemsInPhaseNumber** | **int?**|  | [optional] 
 **orderItemsInPhase** | **bool?**|  | [optional] 
 **orderLaborItems** | **bool?**|  | [optional] 
 **orderOnlyInsufficentItems** | **bool?**|  | [optional] 
 **orderVendorlessItems** | **bool?**|  | [optional] 

### Return type

[**TsiWebPurchaseOrderVendorItemsResponse**](TsiWebPurchaseOrderVendorItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetcreateserviceorderitemsworkorderpricebookprimaryvendor"></a>
# **PurchaseOrdersGetCreateServiceOrderItemsWorkOrderPriceBookPrimaryVendor**
> TsiWebPurchaseOrderVendorItemsResponse PurchaseOrdersGetCreateServiceOrderItemsWorkOrderPriceBookPrimaryVendor (int? serviceOrderNumber, string purchaseOrderCostToUseType = null, int? vendorAccountNumber = null, int? orderItemsInPhaseNumber = null, bool? orderItemsInPhase = null, bool? orderLaborItems = null, bool? orderOnlyInsufficentItems = null, bool? orderVendorlessItems = null)

Retrieve vendor item lists from service order using the price book item's primary vendor.

purchaseOrderCostToUseType : Base, Average, Latest, OrderDetailEstimatedCost - - the order item cost will only be used if \"Use  this estimated cost when purchasing\" is selected on the work/serivce order item, otherwise the base price will be used. <br />  orderItemsInPhaseNumber: null for all phases, 0 for no phase, or the specific number for that phase.<br />  orderVendorlessItems: if true a value is required for VendorAcountNumber.<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetCreateServiceOrderItemsWorkOrderPriceBookPrimaryVendorExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var serviceOrderNumber = 56;  // int? | 
            var purchaseOrderCostToUseType = purchaseOrderCostToUseType_example;  // string |  (optional) 
            var vendorAccountNumber = 56;  // int? |  (optional) 
            var orderItemsInPhaseNumber = 56;  // int? |  (optional) 
            var orderItemsInPhase = true;  // bool? |  (optional) 
            var orderLaborItems = true;  // bool? |  (optional) 
            var orderOnlyInsufficentItems = true;  // bool? |  (optional) 
            var orderVendorlessItems = true;  // bool? |  (optional) 

            try
            {
                // Retrieve vendor item lists from service order using the price book item's primary vendor.
                TsiWebPurchaseOrderVendorItemsResponse result = apiInstance.PurchaseOrdersGetCreateServiceOrderItemsWorkOrderPriceBookPrimaryVendor(serviceOrderNumber, purchaseOrderCostToUseType, vendorAccountNumber, orderItemsInPhaseNumber, orderItemsInPhase, orderLaborItems, orderOnlyInsufficentItems, orderVendorlessItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetCreateServiceOrderItemsWorkOrderPriceBookPrimaryVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceOrderNumber** | **int?**|  | 
 **purchaseOrderCostToUseType** | **string**|  | [optional] 
 **vendorAccountNumber** | **int?**|  | [optional] 
 **orderItemsInPhaseNumber** | **int?**|  | [optional] 
 **orderItemsInPhase** | **bool?**|  | [optional] 
 **orderLaborItems** | **bool?**|  | [optional] 
 **orderOnlyInsufficentItems** | **bool?**|  | [optional] 
 **orderVendorlessItems** | **bool?**|  | [optional] 

### Return type

[**TsiWebPurchaseOrderVendorItemsResponse**](TsiWebPurchaseOrderVendorItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetpurchaseorderdetail"></a>
# **PurchaseOrdersGetPurchaseOrderDetail**
> TsiWebPurchaseOrderDetail PurchaseOrdersGetPurchaseOrderDetail (int? purchaseOrderNumber)

Gets the purchase order details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetPurchaseOrderDetailExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var purchaseOrderNumber = 56;  // int? | The purchase order number.

            try
            {
                // Gets the purchase order details.
                TsiWebPurchaseOrderDetail result = apiInstance.PurchaseOrdersGetPurchaseOrderDetail(purchaseOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetPurchaseOrderDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderNumber** | **int?**| The purchase order number. | 

### Return type

[**TsiWebPurchaseOrderDetail**](TsiWebPurchaseOrderDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetpurchaseorderlineitemreciepts"></a>
# **PurchaseOrdersGetPurchaseOrderLineItemReciepts**
> List<TsiWebPurchaseOrderLineItemReceipt> PurchaseOrdersGetPurchaseOrderLineItemReciepts (int? purchaseOrderNumber, int? purchaseOrderLineItemNumber)

Returns the receipts on the line items.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetPurchaseOrderLineItemRecieptsExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var purchaseOrderNumber = 56;  // int? | 
            var purchaseOrderLineItemNumber = 56;  // int? | 

            try
            {
                // Returns the receipts on the line items.
                List&lt;TsiWebPurchaseOrderLineItemReceipt&gt; result = apiInstance.PurchaseOrdersGetPurchaseOrderLineItemReciepts(purchaseOrderNumber, purchaseOrderLineItemNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetPurchaseOrderLineItemReciepts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderNumber** | **int?**|  | 
 **purchaseOrderLineItemNumber** | **int?**|  | 

### Return type

[**List<TsiWebPurchaseOrderLineItemReceipt>**](TsiWebPurchaseOrderLineItemReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetpurchaseorderlineitemserialnumbers"></a>
# **PurchaseOrdersGetPurchaseOrderLineItemSerialNumbers**
> List<TsiWebPurchaseOrderLineItemSerialNumber> PurchaseOrdersGetPurchaseOrderLineItemSerialNumbers (int? purchaseOrderNumber, int? purchaseOrderLineItemNumber)

Returns the serial numbers on the line item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetPurchaseOrderLineItemSerialNumbersExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var purchaseOrderNumber = 56;  // int? | 
            var purchaseOrderLineItemNumber = 56;  // int? | 

            try
            {
                // Returns the serial numbers on the line item.
                List&lt;TsiWebPurchaseOrderLineItemSerialNumber&gt; result = apiInstance.PurchaseOrdersGetPurchaseOrderLineItemSerialNumbers(purchaseOrderNumber, purchaseOrderLineItemNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetPurchaseOrderLineItemSerialNumbers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderNumber** | **int?**|  | 
 **purchaseOrderLineItemNumber** | **int?**|  | 

### Return type

[**List<TsiWebPurchaseOrderLineItemSerialNumber>**](TsiWebPurchaseOrderLineItemSerialNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetpurchaseorderlineitems"></a>
# **PurchaseOrdersGetPurchaseOrderLineItems**
> List<TsiWebPurchaseOrderLineItem> PurchaseOrdersGetPurchaseOrderLineItems (int? purchaseOrderNumber)

Returns the line items on the purchase order.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetPurchaseOrderLineItemsExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var purchaseOrderNumber = 56;  // int? | 

            try
            {
                // Returns the line items on the purchase order.
                List&lt;TsiWebPurchaseOrderLineItem&gt; result = apiInstance.PurchaseOrdersGetPurchaseOrderLineItems(purchaseOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetPurchaseOrderLineItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderNumber** | **int?**|  | 

### Return type

[**List<TsiWebPurchaseOrderLineItem>**](TsiWebPurchaseOrderLineItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetpurchaseordersummary"></a>
# **PurchaseOrdersGetPurchaseOrderSummary**
> TsiWebPurchaseOrderSummary PurchaseOrdersGetPurchaseOrderSummary (int? purchaseOrderNumber)

Gets the purchase order summary.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetPurchaseOrderSummaryExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var purchaseOrderNumber = 56;  // int? | The purchase order number.

            try
            {
                // Gets the purchase order summary.
                TsiWebPurchaseOrderSummary result = apiInstance.PurchaseOrdersGetPurchaseOrderSummary(purchaseOrderNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetPurchaseOrderSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderNumber** | **int?**| The purchase order number. | 

### Return type

[**TsiWebPurchaseOrderSummary**](TsiWebPurchaseOrderSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetpurchaseordervendoritemsworkorderlowestcostvendor"></a>
# **PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderLowestCostVendor**
> TsiWebPurchaseOrderVendorItemsResponse PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderLowestCostVendor (int? quoteNumber, string purchaseOrderCostToUseType = null, int? vendorAccountNumber = null, int? orderItemsInPhaseNumber = null, bool? orderItemsInPhase = null, bool? orderLaborItems = null, bool? orderOnlyInsufficentItems = null, bool? orderVendorlessItems = null)

Retrieve vendor item lists from work order using the price book item's lowest cost vendor.

purchaseOrderCostToUseType : Base, Average, Latest, OrderDetailEstimatedCost - - the order item cost will only be used if \"Use  this estimated cost when purchasing\" is selected on the work/serivce order item, otherwise the base price will be used. <br />  orderItemsInPhaseNumber: null for all phases, 0 for no phase, or the specific number for that phase.<br />  orderVendorlessItems: if true a value is required for VendorAcountNumber.<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderLowestCostVendorExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var quoteNumber = 56;  // int? | 
            var purchaseOrderCostToUseType = purchaseOrderCostToUseType_example;  // string |  (optional) 
            var vendorAccountNumber = 56;  // int? |  (optional) 
            var orderItemsInPhaseNumber = 56;  // int? |  (optional) 
            var orderItemsInPhase = true;  // bool? |  (optional) 
            var orderLaborItems = true;  // bool? |  (optional) 
            var orderOnlyInsufficentItems = true;  // bool? |  (optional) 
            var orderVendorlessItems = true;  // bool? |  (optional) 

            try
            {
                // Retrieve vendor item lists from work order using the price book item's lowest cost vendor.
                TsiWebPurchaseOrderVendorItemsResponse result = apiInstance.PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderLowestCostVendor(quoteNumber, purchaseOrderCostToUseType, vendorAccountNumber, orderItemsInPhaseNumber, orderItemsInPhase, orderLaborItems, orderOnlyInsufficentItems, orderVendorlessItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderLowestCostVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**|  | 
 **purchaseOrderCostToUseType** | **string**|  | [optional] 
 **vendorAccountNumber** | **int?**|  | [optional] 
 **orderItemsInPhaseNumber** | **int?**|  | [optional] 
 **orderItemsInPhase** | **bool?**|  | [optional] 
 **orderLaborItems** | **bool?**|  | [optional] 
 **orderOnlyInsufficentItems** | **bool?**|  | [optional] 
 **orderVendorlessItems** | **bool?**|  | [optional] 

### Return type

[**TsiWebPurchaseOrderVendorItemsResponse**](TsiWebPurchaseOrderVendorItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetpurchaseordervendoritemsworkorderonevendor"></a>
# **PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOneVendor**
> TsiWebPurchaseOrderVendorItemsResponse PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOneVendor (int? quoteNumber, string purchaseOrderCostToUseType = null, int? vendorAccountNumber = null, int? orderItemsInPhaseNumber = null, bool? orderItemsInPhase = null, bool? orderLaborItems = null, bool? orderOnlyInsufficentItems = null, bool? orderVendorlessItems = null)

Retrieve vendor item lists work order using the price book item's lowest cost vendor.

A value is required for VendorAcountNumber.<br />  purchaseOrderCostToUseType : Base, Average, Latest, OrderDetailEstimatedCost - - the order item cost will only be used if \"Use  this estimated cost when purchasing\" is selected on the work/serivce order item, otherwise the base price will be used. <br />  orderItemsInPhaseNumber: null for all phases, 0 for no phase, or the specific number for that phase.<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOneVendorExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var quoteNumber = 56;  // int? | 
            var purchaseOrderCostToUseType = purchaseOrderCostToUseType_example;  // string |  (optional) 
            var vendorAccountNumber = 56;  // int? |  (optional) 
            var orderItemsInPhaseNumber = 56;  // int? |  (optional) 
            var orderItemsInPhase = true;  // bool? |  (optional) 
            var orderLaborItems = true;  // bool? |  (optional) 
            var orderOnlyInsufficentItems = true;  // bool? |  (optional) 
            var orderVendorlessItems = true;  // bool? |  (optional) 

            try
            {
                // Retrieve vendor item lists work order using the price book item's lowest cost vendor.
                TsiWebPurchaseOrderVendorItemsResponse result = apiInstance.PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOneVendor(quoteNumber, purchaseOrderCostToUseType, vendorAccountNumber, orderItemsInPhaseNumber, orderItemsInPhase, orderLaborItems, orderOnlyInsufficentItems, orderVendorlessItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOneVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**|  | 
 **purchaseOrderCostToUseType** | **string**|  | [optional] 
 **vendorAccountNumber** | **int?**|  | [optional] 
 **orderItemsInPhaseNumber** | **int?**|  | [optional] 
 **orderItemsInPhase** | **bool?**|  | [optional] 
 **orderLaborItems** | **bool?**|  | [optional] 
 **orderOnlyInsufficentItems** | **bool?**|  | [optional] 
 **orderVendorlessItems** | **bool?**|  | [optional] 

### Return type

[**TsiWebPurchaseOrderVendorItemsResponse**](TsiWebPurchaseOrderVendorItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetpurchaseordervendoritemsworkorderorderprimaryvendor"></a>
# **PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOrderPrimaryVendor**
> TsiWebPurchaseOrderVendorItemsResponse PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOrderPrimaryVendor (int? quoteNumber, string purchaseOrderCostToUseType = null, int? vendorAccountNumber = null, int? orderItemsInPhaseNumber = null, bool? orderItemsInPhase = null, bool? orderLaborItems = null, bool? orderOnlyInsufficentItems = null, bool? orderVendorlessItems = null)

Retrieve vendor item lists from work order using the item's primary vendor on the order.

purchaseOrderCostToUseType : Base, Average, Latest, OrderDetailEstimatedCost - - the order item cost will only be used if \"Use  this estimated cost when purchasing\" is selected on the work/serivce order item, otherwise the base price will be used. <br />  orderItemsInPhaseNumber: null for all phases, 0 for no phase, or the specific number for that phase.<br />  orderVendorlessItems: if true a value is required for VendorAcountNumber.<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOrderPrimaryVendorExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var quoteNumber = 56;  // int? | 
            var purchaseOrderCostToUseType = purchaseOrderCostToUseType_example;  // string |  (optional) 
            var vendorAccountNumber = 56;  // int? |  (optional) 
            var orderItemsInPhaseNumber = 56;  // int? |  (optional) 
            var orderItemsInPhase = true;  // bool? |  (optional) 
            var orderLaborItems = true;  // bool? |  (optional) 
            var orderOnlyInsufficentItems = true;  // bool? |  (optional) 
            var orderVendorlessItems = true;  // bool? |  (optional) 

            try
            {
                // Retrieve vendor item lists from work order using the item's primary vendor on the order.
                TsiWebPurchaseOrderVendorItemsResponse result = apiInstance.PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOrderPrimaryVendor(quoteNumber, purchaseOrderCostToUseType, vendorAccountNumber, orderItemsInPhaseNumber, orderItemsInPhase, orderLaborItems, orderOnlyInsufficentItems, orderVendorlessItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderOrderPrimaryVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**|  | 
 **purchaseOrderCostToUseType** | **string**|  | [optional] 
 **vendorAccountNumber** | **int?**|  | [optional] 
 **orderItemsInPhaseNumber** | **int?**|  | [optional] 
 **orderItemsInPhase** | **bool?**|  | [optional] 
 **orderLaborItems** | **bool?**|  | [optional] 
 **orderOnlyInsufficentItems** | **bool?**|  | [optional] 
 **orderVendorlessItems** | **bool?**|  | [optional] 

### Return type

[**TsiWebPurchaseOrderVendorItemsResponse**](TsiWebPurchaseOrderVendorItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersgetpurchaseordervendoritemsworkorderpricebookprimaryvendor"></a>
# **PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderPriceBookPrimaryVendor**
> TsiWebPurchaseOrderVendorItemsResponse PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderPriceBookPrimaryVendor (int? quoteNumber, string purchaseOrderCostToUseType = null, int? vendorAccountNumber = null, int? orderItemsInPhaseNumber = null, bool? orderItemsInPhase = null, bool? orderLaborItems = null, bool? orderOnlyInsufficentItems = null, bool? orderVendorlessItems = null)

Retrieve vendor item lists from work order using the price book item's primary vendor.

purchaseOrderCostToUseType : Base, Average, Latest, OrderDetailEstimatedCost - - the order item cost will only be used if \"Use  this estimated cost when purchasing\" is selected on the work/serivce order item, otherwise the base price will be used. <br />  orderItemsInPhaseNumber: null for all phases, 0 for no phase, or the specific number for that phase.<br />  orderVendorlessItems: if true a value is required for VendorAcountNumber.<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderPriceBookPrimaryVendorExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var quoteNumber = 56;  // int? | 
            var purchaseOrderCostToUseType = purchaseOrderCostToUseType_example;  // string |  (optional) 
            var vendorAccountNumber = 56;  // int? |  (optional) 
            var orderItemsInPhaseNumber = 56;  // int? |  (optional) 
            var orderItemsInPhase = true;  // bool? |  (optional) 
            var orderLaborItems = true;  // bool? |  (optional) 
            var orderOnlyInsufficentItems = true;  // bool? |  (optional) 
            var orderVendorlessItems = true;  // bool? |  (optional) 

            try
            {
                // Retrieve vendor item lists from work order using the price book item's primary vendor.
                TsiWebPurchaseOrderVendorItemsResponse result = apiInstance.PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderPriceBookPrimaryVendor(quoteNumber, purchaseOrderCostToUseType, vendorAccountNumber, orderItemsInPhaseNumber, orderItemsInPhase, orderLaborItems, orderOnlyInsufficentItems, orderVendorlessItems);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersGetPurchaseOrderVendorItemsWorkOrderPriceBookPrimaryVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quoteNumber** | **int?**|  | 
 **purchaseOrderCostToUseType** | **string**|  | [optional] 
 **vendorAccountNumber** | **int?**|  | [optional] 
 **orderItemsInPhaseNumber** | **int?**|  | [optional] 
 **orderItemsInPhase** | **bool?**|  | [optional] 
 **orderLaborItems** | **bool?**|  | [optional] 
 **orderOnlyInsufficentItems** | **bool?**|  | [optional] 
 **orderVendorlessItems** | **bool?**|  | [optional] 

### Return type

[**TsiWebPurchaseOrderVendorItemsResponse**](TsiWebPurchaseOrderVendorItemsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="purchaseordersupdatepurchaseorder"></a>
# **PurchaseOrdersUpdatePurchaseOrder**
> TsiWebPurchaseOrderResponse PurchaseOrdersUpdatePurchaseOrder (int? purchaseOrderNumber, TsiWebUpdatePurchaseOrderModel model)

Updates a purchase order.

purchaseOrderCostToUseType : Base, Average, Latest, OrderDetailEstimatedCost - - the order item cost will only be used if \"Use  this estimated cost when purchasing\" is selected on the work/serivce order item, otherwise the base price will be used. <br />  ShipToAddressType: Default,PrimaryAlternate, AccountNumber,None,AlternateAddressId.<br />  BillToAddressType: Default,PrimaryAlternate, AccountNumber,None,AlternateAddressId.<br />

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PurchaseOrdersUpdatePurchaseOrderExample
    {
        public void main()
        {
            var apiInstance = new PurchaseOrdersApi();
            var purchaseOrderNumber = 56;  // int? | 
            var model = new TsiWebUpdatePurchaseOrderModel(); // TsiWebUpdatePurchaseOrderModel | 

            try
            {
                // Updates a purchase order.
                TsiWebPurchaseOrderResponse result = apiInstance.PurchaseOrdersUpdatePurchaseOrder(purchaseOrderNumber, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PurchaseOrdersApi.PurchaseOrdersUpdatePurchaseOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **purchaseOrderNumber** | **int?**|  | 
 **model** | [**TsiWebUpdatePurchaseOrderModel**](TsiWebUpdatePurchaseOrderModel.md)|  | 

### Return type

[**TsiWebPurchaseOrderResponse**](TsiWebPurchaseOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded, application/json, application/xml, text/xml
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

