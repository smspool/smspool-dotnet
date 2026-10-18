# SMSPool.Api.PreordersApi

All URIs are relative to *https://api.smspool.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PreorderCancel**](PreordersApi.md#preordercancel) | **POST** /preorder/cancel | Cancel |
| [**PreorderCheck**](PreordersApi.md#preordercheck) | **POST** /preorder/check | Check |
| [**PreorderCreate**](PreordersApi.md#preordercreate) | **POST** /preorder/create | Create |
| [**PreorderPrice**](PreordersApi.md#preorderprice) | **POST** /preorder/price | Price |
| [**PreorderRetrieve**](PreordersApi.md#preorderretrieve) | **POST** /preorder/retrieve | Retrieve |

<a id="preordercancel"></a>
# **PreorderCancel**
> Object PreorderCancel (string orderid)

Cancel

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
    public class PreorderCancelExample
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
            var apiInstance = new PreordersApi(httpClient, config, httpClientHandler);
            var orderid = "orderid_example";  // string | 

            try
            {
                // Cancel
                Object result = apiInstance.PreorderCancel(orderid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreordersApi.PreorderCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PreorderCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel
    ApiResponse<Object> response = apiInstance.PreorderCancelWithHttpInfo(orderid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreordersApi.PreorderCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderid** | **string** |  |  |

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
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Malformed API key |  -  |
| **403** | Unknown or revoked API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="preordercheck"></a>
# **PreorderCheck**
> Object PreorderCheck (string orderid)

Check

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
    public class PreorderCheckExample
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
            var apiInstance = new PreordersApi(httpClient, config, httpClientHandler);
            var orderid = "orderid_example";  // string | 

            try
            {
                // Check
                Object result = apiInstance.PreorderCheck(orderid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreordersApi.PreorderCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PreorderCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check
    ApiResponse<Object> response = apiInstance.PreorderCheckWithHttpInfo(orderid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreordersApi.PreorderCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderid** | **string** |  |  |

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
| **200** | OK |  -  |
| **401** | Malformed API key |  -  |
| **403** | Unknown or revoked API key |  -  |
| **404** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="preordercreate"></a>
# **PreorderCreate**
> Object PreorderCreate (string service, string country, string pool, decimal maxPrice, string areacode = null)

Create

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
    public class PreorderCreateExample
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
            var apiInstance = new PreordersApi(httpClient, config, httpClientHandler);
            var service = "service_example";  // string | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint
            var country = "country_example";  // string | Country name or country ID which can be retrieved at the /country/retrieve_all endpoint
            var pool = "pool_example";  // string | 
            var maxPrice = 8.14D;  // decimal | 
            var areacode = "areacode_example";  // string |  (optional) 

            try
            {
                // Create
                Object result = apiInstance.PreorderCreate(service, country, pool, maxPrice, areacode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreordersApi.PreorderCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PreorderCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create
    ApiResponse<Object> response = apiInstance.PreorderCreateWithHttpInfo(service, country, pool, maxPrice, areacode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreordersApi.PreorderCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **string** | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint |  |
| **country** | **string** | Country name or country ID which can be retrieved at the /country/retrieve_all endpoint |  |
| **pool** | **string** |  |  |
| **maxPrice** | **decimal** |  |  |
| **areacode** | **string** |  | [optional]  |

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
| **200** | OK |  -  |
| **400** | Error |  -  |
| **401** | Malformed API key |  -  |
| **403** | Unknown or revoked API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="preorderprice"></a>
# **PreorderPrice**
> Object PreorderPrice (string service, string country, string pool)

Price

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
    public class PreorderPriceExample
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
            var apiInstance = new PreordersApi(httpClient, config, httpClientHandler);
            var service = "service_example";  // string | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint
            var country = "country_example";  // string | Country name or country ID which can be retrieved at the /country/retrieve_all endpoint
            var pool = "pool_example";  // string | 

            try
            {
                // Price
                Object result = apiInstance.PreorderPrice(service, country, pool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreordersApi.PreorderPrice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PreorderPriceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Price
    ApiResponse<Object> response = apiInstance.PreorderPriceWithHttpInfo(service, country, pool);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreordersApi.PreorderPriceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **string** | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint |  |
| **country** | **string** | Country name or country ID which can be retrieved at the /country/retrieve_all endpoint |  |
| **pool** | **string** |  |  |

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
| **200** | OK |  -  |
| **401** | Malformed API key |  -  |
| **403** | Unknown or revoked API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="preorderretrieve"></a>
# **PreorderRetrieve**
> Object PreorderRetrieve ()

Retrieve

This API endpoint allows you to retrieve preorders from the SMS Pool system. It is an HTTP POST request sent to the URL `https://api.smspool.net/preorder/retrieve`.  ### Request Parameters  This endpoint requires the \\`key\\` parameter which is your API key.

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
    public class PreorderRetrieveExample
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
            var apiInstance = new PreordersApi(httpClient, config, httpClientHandler);

            try
            {
                // Retrieve
                Object result = apiInstance.PreorderRetrieve();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PreordersApi.PreorderRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PreorderRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve
    ApiResponse<Object> response = apiInstance.PreorderRetrieveWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PreordersApi.PreorderRetrieveWithHttpInfo: " + e.Message);
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
| **200** | OK |  -  |
| **401** | Malformed API key |  -  |
| **403** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

