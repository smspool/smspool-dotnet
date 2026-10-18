# SMSPool.Api.PricingApi

All URIs are relative to *https://api.smspool.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RequestPrice**](PricingApi.md#requestprice) | **POST** /request/price | Retrieve specific price &amp; Success Rate |
| [**RequestPricing**](PricingApi.md#requestpricing) | **POST** /request/pricing | Retrieve all pricing |

<a id="requestprice"></a>
# **RequestPrice**
> Object RequestPrice (string country, string service, string pool = null, string skipSuccessRate = null)

Retrieve specific price & Success Rate

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
    public class RequestPriceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PricingApi(httpClient, config, httpClientHandler);
            var country = "country_example";  // string | Country retrieved from ''Country list\\\" endpoint
            var service = "service_example";  // string | Service retrieved from ''Service list\\\" endpoint
            var pool = "pool_example";  // string | Pool retrieved from ''Pool list\\\" endpoint (optional) 
            var skipSuccessRate = "skipSuccessRate_example";  // string |  (optional) 

            try
            {
                // Retrieve specific price & Success Rate
                Object result = apiInstance.RequestPrice(country, service, pool, skipSuccessRate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PricingApi.RequestPrice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestPriceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve specific price & Success Rate
    ApiResponse<Object> response = apiInstance.RequestPriceWithHttpInfo(country, service, pool, skipSuccessRate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PricingApi.RequestPriceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **country** | **string** | Country retrieved from &#39;&#39;Country list\\\&quot; endpoint |  |
| **service** | **string** | Service retrieved from &#39;&#39;Service list\\\&quot; endpoint |  |
| **pool** | **string** | Pool retrieved from &#39;&#39;Pool list\\\&quot; endpoint | [optional]  |
| **skipSuccessRate** | **string** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="requestpricing"></a>
# **RequestPricing**
> Object RequestPricing (string country = null, string service = null, string pool = null, decimal? maxPrice = null)

Retrieve all pricing

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
    public class RequestPricingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new PricingApi(httpClient, config, httpClientHandler);
            var country = "country_example";  // string | Optional parameter to request services per country (optional) 
            var service = "service_example";  // string | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint (optional) 
            var pool = "pool_example";  // string |  (optional) 
            var maxPrice = 8.14D;  // decimal? |  (optional) 

            try
            {
                // Retrieve all pricing
                Object result = apiInstance.RequestPricing(country, service, pool, maxPrice);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PricingApi.RequestPricing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestPricingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve all pricing
    ApiResponse<Object> response = apiInstance.RequestPricingWithHttpInfo(country, service, pool, maxPrice);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PricingApi.RequestPricingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **country** | **string** | Optional parameter to request services per country | [optional]  |
| **service** | **string** | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint | [optional]  |
| **pool** | **string** |  | [optional]  |
| **maxPrice** | **decimal?** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

