# SMSPool.Api.RentalApi

All URIs are relative to *https://api.smspool.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PurchaseRental**](RentalApi.md#purchaserental) | **POST** /purchase/rental | Order Rental |
| [**RentalAutoExtend**](RentalApi.md#rentalautoextend) | **POST** /rental/auto_extend | Enable Auto Extend Rental |
| [**RentalExtend**](RentalApi.md#rentalextend) | **POST** /rental/extend | Extend Rental |
| [**RentalHistory**](RentalApi.md#rentalhistory) | **POST** /rental/history | Rental History |
| [**RentalInfo**](RentalApi.md#rentalinfo) | **POST** /rental/info | Retrieve Rental Info |
| [**RentalRefund**](RentalApi.md#rentalrefund) | **POST** /rental/refund | Refund Rental |
| [**RentalReset**](RentalApi.md#rentalreset) | **POST** /rental/reset | Reset Rental |
| [**RentalRetrieve**](RentalApi.md#rentalretrieve) | **POST** /rental/retrieve | Retrieve Active Rentals |
| [**RentalRetrieveAll**](RentalApi.md#rentalretrieveall) | **POST** /rental/retrieve_all | Retrieve Rental IDs |
| [**RentalRetrieveHistory**](RentalApi.md#rentalretrievehistory) | **POST** /rental/retrieve_history | Retrieve your rentals |
| [**RentalRetrieveMessages**](RentalApi.md#rentalretrievemessages) | **POST** /rental/retrieve_messages | Retrieve Rental Messages |
| [**RentalRetrievePricing**](RentalApi.md#rentalretrievepricing) | **POST** /rental/retrieve_pricing | Retrieve Rental Pricing |
| [**RentalRetrieveServices**](RentalApi.md#rentalretrieveservices) | **POST** /rental/retrieve_services | Retrieve Rental Services |
| [**RentalRetrieveStatus**](RentalApi.md#rentalretrievestatus) | **POST** /rental/retrieve_status | Retrieve Rental Status |
| [**RentalServicePrice**](RentalApi.md#rentalserviceprice) | **POST** /rental/service_price | Retrieve rental service price |
| [**RentalStock**](RentalApi.md#rentalstock) | **POST** /rental/stock | Retrieve Rental Stock |

<a id="purchaserental"></a>
# **PurchaseRental**
> Object PurchaseRental (int id, int days, int? serviceId = null, int? createToken = null, string city = null, string state = null, string zipcode = null)

Order Rental

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
    public class PurchaseRentalExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | Rental ID retrieved from Retrieve Rental IDs
            var days = 56;  // int | 
            var serviceId = 56;  // int? | Optional value on which service you'd purchase the rental for (optional) 
            var createToken = 56;  // int? | Create a rental token which allows you to share this specific rental (optional) 
            var city = "city_example";  // string |  (optional) 
            var state = "state_example";  // string |  (optional) 
            var zipcode = "zipcode_example";  // string |  (optional) 

            try
            {
                // Order Rental
                Object result = apiInstance.PurchaseRental(id, days, serviceId, createToken, city, state, zipcode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.PurchaseRental: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseRentalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Order Rental
    ApiResponse<Object> response = apiInstance.PurchaseRentalWithHttpInfo(id, days, serviceId, createToken, city, state, zipcode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.PurchaseRentalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | Rental ID retrieved from Retrieve Rental IDs |  |
| **days** | **int** |  |  |
| **serviceId** | **int?** | Optional value on which service you&#39;d purchase the rental for | [optional]  |
| **createToken** | **int?** | Create a rental token which allows you to share this specific rental | [optional]  |
| **city** | **string** |  | [optional]  |
| **state** | **string** |  | [optional]  |
| **zipcode** | **string** |  | [optional]  |

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

<a id="rentalautoextend"></a>
# **RentalAutoExtend**
> Object RentalAutoExtend (string rentalCode)

Enable Auto Extend Rental

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
    public class RentalAutoExtendExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var rentalCode = "rentalCode_example";  // string | The retrieved rental code from the `Order rental` endpoint.

            try
            {
                // Enable Auto Extend Rental
                Object result = apiInstance.RentalAutoExtend(rentalCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalAutoExtend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalAutoExtendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable Auto Extend Rental
    ApiResponse<Object> response = apiInstance.RentalAutoExtendWithHttpInfo(rentalCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalAutoExtendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rentalCode** | **string** | The retrieved rental code from the &#x60;Order rental&#x60; endpoint. |  |

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

<a id="rentalextend"></a>
# **RentalExtend**
> Object RentalExtend (int days, string rentalCode)

Extend Rental

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
    public class RentalExtendExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var days = 56;  // int | 
            var rentalCode = "rentalCode_example";  // string | The retrieved rental code from the `Order rental` endpoint.

            try
            {
                // Extend Rental
                Object result = apiInstance.RentalExtend(days, rentalCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalExtend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalExtendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extend Rental
    ApiResponse<Object> response = apiInstance.RentalExtendWithHttpInfo(days, rentalCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalExtendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **days** | **int** |  |  |
| **rentalCode** | **string** | The retrieved rental code from the &#x60;Order rental&#x60; endpoint. |  |

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

<a id="rentalhistory"></a>
# **RentalHistory**
> Object RentalHistory ()

Rental History

Retrieve a history of all your rental actions.

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
    public class RentalHistoryExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);

            try
            {
                // Rental History
                Object result = apiInstance.RentalHistory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rental History
    ApiResponse<Object> response = apiInstance.RentalHistoryWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalHistoryWithHttpInfo: " + e.Message);
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
| **403** | Unknown or revoked API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rentalinfo"></a>
# **RentalInfo**
> Object RentalInfo (string rentalCode)

Retrieve Rental Info

Retrieve rental information

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
    public class RentalInfoExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var rentalCode = "rentalCode_example";  // string | The retrieved rental code from the `Order rental` endpoint.

            try
            {
                // Retrieve Rental Info
                Object result = apiInstance.RentalInfo(rentalCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rental Info
    ApiResponse<Object> response = apiInstance.RentalInfoWithHttpInfo(rentalCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rentalCode** | **string** | The retrieved rental code from the &#x60;Order rental&#x60; endpoint. |  |

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

<a id="rentalrefund"></a>
# **RentalRefund**
> Object RentalRefund (string rentalCode)

Refund Rental

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
    public class RentalRefundExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var rentalCode = "rentalCode_example";  // string | The retrieved rental code from the `Order rental` endpoint.

            try
            {
                // Refund Rental
                Object result = apiInstance.RentalRefund(rentalCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalRefund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalRefundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refund Rental
    ApiResponse<Object> response = apiInstance.RentalRefundWithHttpInfo(rentalCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalRefundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rentalCode** | **string** | The retrieved rental code from the &#x60;Order rental&#x60; endpoint. |  |

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

<a id="rentalreset"></a>
# **RentalReset**
> Object RentalReset (string rentalCode)

Reset Rental

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
    public class RentalResetExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var rentalCode = "rentalCode_example";  // string | The retrieved rental code from the `Order rental` endpoint.

            try
            {
                // Reset Rental
                Object result = apiInstance.RentalReset(rentalCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalReset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalResetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset Rental
    ApiResponse<Object> response = apiInstance.RentalResetWithHttpInfo(rentalCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalResetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rentalCode** | **string** | The retrieved rental code from the &#x60;Order rental&#x60; endpoint. |  |

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
| **404** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rentalretrieve"></a>
# **RentalRetrieve**
> Object RentalRetrieve ()

Retrieve Active Rentals

Retrieve a history of all your rental actions.

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
    public class RentalRetrieveExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);

            try
            {
                // Retrieve Active Rentals
                Object result = apiInstance.RentalRetrieve();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalRetrieve: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalRetrieveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Active Rentals
    ApiResponse<Object> response = apiInstance.RentalRetrieveWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalRetrieveWithHttpInfo: " + e.Message);
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
| **403** | Unknown or revoked API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rentalretrieveall"></a>
# **RentalRetrieveAll**
> Object RentalRetrieveAll (int type)

Retrieve Rental IDs

Retrieve available rental products. Each listing includes `is_refundable` (`0` or `1`), `refund_within` (hours after purchase a refund is allowed; `0` when not refundable), and `refund_min_days` (minimum duration that is eligible for a refund; `0` when there is no duration floor or the rental is never refundable). Refunds also require that no messages have been received.

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
    public class RentalRetrieveAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var type = 56;  // int | Choose whether the rental is extendable or not with a 0 or 1

            try
            {
                // Retrieve Rental IDs
                Object result = apiInstance.RentalRetrieveAll(type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalRetrieveAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalRetrieveAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rental IDs
    ApiResponse<Object> response = apiInstance.RentalRetrieveAllWithHttpInfo(type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalRetrieveAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **int** | Choose whether the rental is extendable or not with a 0 or 1 |  |

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
| **404** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rentalretrievehistory"></a>
# **RentalRetrieveHistory**
> Object RentalRetrieveHistory ()

Retrieve your rentals

List every rental on your account that was not refunded, including expired ones. For the actions taken on your rentals (activations, extensions, refunds) use **Rental History** instead.  - `rental`: the rental ID from **Retrieve Rental IDs** - `rental_code`: use it with the other rental endpoints, such as **Retrieve Rental Messages** - `expiration_date`: Unix timestamp - `source`: the pool the number comes from - `state`: the US state of the number, or `Unknown`

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
    public class RentalRetrieveHistoryExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);

            try
            {
                // Retrieve your rentals
                Object result = apiInstance.RentalRetrieveHistory();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalRetrieveHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalRetrieveHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve your rentals
    ApiResponse<Object> response = apiInstance.RentalRetrieveHistoryWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalRetrieveHistoryWithHttpInfo: " + e.Message);
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
| **403** | Unknown or revoked API key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rentalretrievemessages"></a>
# **RentalRetrieveMessages**
> Object RentalRetrieveMessages (string rentalCode)

Retrieve Rental Messages

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
    public class RentalRetrieveMessagesExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var rentalCode = "rentalCode_example";  // string | The retrieved rental code from the `Order rental` endpoint.

            try
            {
                // Retrieve Rental Messages
                Object result = apiInstance.RentalRetrieveMessages(rentalCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalRetrieveMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalRetrieveMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rental Messages
    ApiResponse<Object> response = apiInstance.RentalRetrieveMessagesWithHttpInfo(rentalCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalRetrieveMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rentalCode** | **string** | The retrieved rental code from the &#x60;Order rental&#x60; endpoint. |  |

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

<a id="rentalretrievepricing"></a>
# **RentalRetrievePricing**
> Object RentalRetrievePricing (int id, string service = null)

Retrieve Rental Pricing

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
    public class RentalRetrievePricingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | The rental ID retrieved from `Retrieve Rental IDs`
            var service = "service_example";  // string | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint (optional) 

            try
            {
                // Retrieve Rental Pricing
                Object result = apiInstance.RentalRetrievePricing(id, service);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalRetrievePricing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalRetrievePricingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rental Pricing
    ApiResponse<Object> response = apiInstance.RentalRetrievePricingWithHttpInfo(id, service);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalRetrievePricingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The rental ID retrieved from &#x60;Retrieve Rental IDs&#x60; |  |
| **service** | **string** | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint | [optional]  |

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

<a id="rentalretrieveservices"></a>
# **RentalRetrieveServices**
> Object RentalRetrieveServices (int? rental = null)

Retrieve Rental Services

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
    public class RentalRetrieveServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var rental = 56;  // int? | The rental ID retrieved from `Retrieve Rental IDs` (optional) 

            try
            {
                // Retrieve Rental Services
                Object result = apiInstance.RentalRetrieveServices(rental);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalRetrieveServices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalRetrieveServicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rental Services
    ApiResponse<Object> response = apiInstance.RentalRetrieveServicesWithHttpInfo(rental);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalRetrieveServicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rental** | **int?** | The rental ID retrieved from &#x60;Retrieve Rental IDs&#x60; | [optional]  |

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

<a id="rentalretrievestatus"></a>
# **RentalRetrieveStatus**
> Object RentalRetrieveStatus (string rentalCode)

Retrieve Rental Status

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
    public class RentalRetrieveStatusExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var rentalCode = "rentalCode_example";  // string | The retrieved rental code from the `Order rental` endpoint.

            try
            {
                // Retrieve Rental Status
                Object result = apiInstance.RentalRetrieveStatus(rentalCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalRetrieveStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalRetrieveStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rental Status
    ApiResponse<Object> response = apiInstance.RentalRetrieveStatusWithHttpInfo(rentalCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalRetrieveStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rentalCode** | **string** | The retrieved rental code from the &#x60;Order rental&#x60; endpoint. |  |

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

<a id="rentalserviceprice"></a>
# **RentalServicePrice**
> Object RentalServicePrice (int id, int serviceId)

Retrieve rental service price

Some rentals are bound to a single service. This returns the price of a rental for that service, with the custom pricing on your account applied.

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
    public class RentalServicePriceExample
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
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | The rental ID retrieved from `Retrieve Rental IDs`
            var serviceId = 56;  // int | The service ID retrieved from `Retrieve Rental Services`

            try
            {
                // Retrieve rental service price
                Object result = apiInstance.RentalServicePrice(id, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalServicePrice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalServicePriceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve rental service price
    ApiResponse<Object> response = apiInstance.RentalServicePriceWithHttpInfo(id, serviceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalServicePriceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The rental ID retrieved from &#x60;Retrieve Rental IDs&#x60; |  |
| **serviceId** | **int** | The service ID retrieved from &#x60;Retrieve Rental Services&#x60; |  |

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

<a id="rentalstock"></a>
# **RentalStock**
> Object RentalStock (int id, int days, int? serviceId = null)

Retrieve Rental Stock

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
    public class RentalStockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RentalApi(httpClient, config, httpClientHandler);
            var id = 56;  // int | The rental ID retrieved from `Retrieve Rental IDs`
            var days = 56;  // int | 
            var serviceId = 56;  // int? |  (optional) 

            try
            {
                // Retrieve Rental Stock
                Object result = apiInstance.RentalStock(id, days, serviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RentalApi.RentalStock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RentalStockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Rental Stock
    ApiResponse<Object> response = apiInstance.RentalStockWithHttpInfo(id, days, serviceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RentalApi.RentalStockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** | The rental ID retrieved from &#x60;Retrieve Rental IDs&#x60; |  |
| **days** | **int** |  |  |
| **serviceId** | **int?** |  | [optional]  |

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

