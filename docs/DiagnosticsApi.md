# IO.Swagger.Api.DiagnosticsApi

All URIs are relative to *http://api2.tigerpawsoftware.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DiagnosticsDatabaseVersion**](DiagnosticsApi.md#diagnosticsdatabaseversion) | **GET** /api/diagnostics/database/version | 
[**DiagnosticsGetProductInformation**](DiagnosticsApi.md#diagnosticsgetproductinformation) | **GET** /api/diagnostics/productInformation | Returns the database version and license information.
[**DiagnosticsValidateUser**](DiagnosticsApi.md#diagnosticsvalidateuser) | **GET** /api/diagnostics/validate/user | 


<a name="diagnosticsdatabaseversion"></a>
# **DiagnosticsDatabaseVersion**
> TsiWebResponse DiagnosticsDatabaseVersion ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DiagnosticsDatabaseVersionExample
    {
        public void main()
        {
            var apiInstance = new DiagnosticsApi();

            try
            {
                TsiWebResponse result = apiInstance.DiagnosticsDatabaseVersion();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.DiagnosticsDatabaseVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diagnosticsgetproductinformation"></a>
# **DiagnosticsGetProductInformation**
> TsiWebProductInformation DiagnosticsGetProductInformation ()

Returns the database version and license information.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DiagnosticsGetProductInformationExample
    {
        public void main()
        {
            var apiInstance = new DiagnosticsApi();

            try
            {
                // Returns the database version and license information.
                TsiWebProductInformation result = apiInstance.DiagnosticsGetProductInformation();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.DiagnosticsGetProductInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TsiWebProductInformation**](TsiWebProductInformation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diagnosticsvalidateuser"></a>
# **DiagnosticsValidateUser**
> TsiWebResponse DiagnosticsValidateUser ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DiagnosticsValidateUserExample
    {
        public void main()
        {
            var apiInstance = new DiagnosticsApi();

            try
            {
                TsiWebResponse result = apiInstance.DiagnosticsValidateUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiagnosticsApi.DiagnosticsValidateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TsiWebResponse**](TsiWebResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

