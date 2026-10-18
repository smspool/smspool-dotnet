# SMSPool.Api.VoucherApi

All URIs are relative to *https://api.smspool.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**VoucherBulkGenerate**](VoucherApi.md#voucherbulkgenerate) | **POST** /voucher/bulk_generate | Bulk generate vouchers |
| [**VoucherDelete**](VoucherApi.md#voucherdelete) | **POST** /voucher/delete | Delete voucher |
| [**VoucherGenerate**](VoucherApi.md#vouchergenerate) | **POST** /voucher/generate | Generate voucher |
| [**VoucherRetrieve**](VoucherApi.md#voucherretrieve) | **POST** /voucher/retrieve | Retrieve vouchers |

<a id="voucherbulkgenerate"></a>
# **VoucherBulkGenerate**
> Object VoucherBulkGenerate (decimal amount, int quantity)

Bulk generate vouchers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using SMSPool.Api;
using SMSPool.Client;
using SMSPool.Model;

namespace Example
{
    public class VoucherBulkGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new VoucherApi(httpClient, config, httpClientHandler);
            var amount = 8.14D;  // decimal | 
            var quantity = 56;  // int | 

            try
            {
                // Bulk generate vouchers
                Object result = apiInstance.VoucherBulkGenerate(amount, quantity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherBulkGenerate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoucherBulkGenerateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk generate vouchers
    ApiResponse<Object> response = apiInstance.VoucherBulkGenerateWithHttpInfo(amount, quantity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherApi.VoucherBulkGenerateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amount** | **decimal** |  |  |
| **quantity** | **int** |  |  |

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON response |  -  |
| **401** | Malformed API key |  -  |
| **403** | Unknown or revoked API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="voucherdelete"></a>
# **VoucherDelete**
> Object VoucherDelete (string voucher)

Delete voucher

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using SMSPool.Api;
using SMSPool.Client;
using SMSPool.Model;

namespace Example
{
    public class VoucherDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new VoucherApi(httpClient, config, httpClientHandler);
            var voucher = "voucher_example";  // string | Your voucher code

            try
            {
                // Delete voucher
                Object result = apiInstance.VoucherDelete(voucher);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoucherDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete voucher
    ApiResponse<Object> response = apiInstance.VoucherDeleteWithHttpInfo(voucher);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherApi.VoucherDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **voucher** | **string** | Your voucher code |  |

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON response |  -  |
| **401** | Malformed API key |  -  |
| **403** | Unknown or revoked API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="vouchergenerate"></a>
# **VoucherGenerate**
> Object VoucherGenerate (decimal amount)

Generate voucher

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using SMSPool.Api;
using SMSPool.Client;
using SMSPool.Model;

namespace Example
{
    public class VoucherGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new VoucherApi(httpClient, config, httpClientHandler);
            var amount = 8.14D;  // decimal | The amount per promocode

            try
            {
                // Generate voucher
                Object result = apiInstance.VoucherGenerate(amount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherGenerate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoucherGenerateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate voucher
    ApiResponse<Object> response = apiInstance.VoucherGenerateWithHttpInfo(amount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherApi.VoucherGenerateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amount** | **decimal** | The amount per promocode |  |

### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON response |  -  |
| **401** | Malformed API key |  -  |
| **403** | Unknown or revoked API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="voucherretrieve"></a>
# **VoucherRetrieve**
> Object VoucherRetrieve ()

Retrieve vouchers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using SMSPool.Api;
using SMSPool.Client;
using SMSPool.Model;

namespace Example
{
    public class VoucherRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new VoucherApi(httpClient, config, httpClientHandler);

            try
            {
                // Retrieve vouchers
                Object result = apiInstance.VoucherRetrieve();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VoucherApi.VoucherRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoucherRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve vouchers
    ApiResponse<Object> response = apiInstance.VoucherRetrieveWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VoucherApi.VoucherRetrieveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON response |  -  |
| **401** | Malformed API key |  -  |
| **403** | Unknown or revoked API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

