# SMSPool.Api.SMSApi

All URIs are relative to *https://api.smspool.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PurchaseSms**](SMSApi.md#purchasesms) | **POST** /purchase/sms | Order SMS |
| [**RequestActive**](SMSApi.md#requestactive) | **POST** /request/active | Active orders |
| [**RequestArchive**](SMSApi.md#requestarchive) | **POST** /request/archive | Archive all orders |
| [**RequestAreacodes**](SMSApi.md#requestareacodes) | **POST** /request/areacodes | Request available areacodes |
| [**RequestHistory**](SMSApi.md#requesthistory) | **POST** /request/history | Order History |
| [**RequestHistorySearch**](SMSApi.md#requesthistorysearch) | **POST** /request/history_search | Search order history |
| [**SmsActivate**](SMSApi.md#smsactivate) | **POST** /sms/activate | Activate SMS |
| [**SmsAllStock**](SMSApi.md#smsallstock) | **POST** /sms/all_stock | One-time stock for all services |
| [**SmsArchive**](SMSApi.md#smsarchive) | **POST** /sms/archive | Archive one order |
| [**SmsCancel**](SMSApi.md#smscancel) | **POST** /sms/cancel | Cancel SMS |
| [**SmsCancelAll**](SMSApi.md#smscancelall) | **POST** /sms/cancel_all | Cancel All SMS |
| [**SmsCheck**](SMSApi.md#smscheck) | **POST** /sms/check | Check SMS |
| [**SmsCheckResend**](SMSApi.md#smscheckresend) | **POST** /sms/check_resend | Check Resend |
| [**SmsClearCache**](SMSApi.md#smsclearcache) | **POST** /sms/clear_cache | Clear SMS Cache |
| [**SmsMissed**](SMSApi.md#smsmissed) | **POST** /sms/missed | Missed SMS |
| [**SmsReactivate**](SMSApi.md#smsreactivate) | **POST** /sms/reactivate | Reactivate SMS |
| [**SmsResend**](SMSApi.md#smsresend) | **POST** /sms/resend | Resend |
| [**SmsStock**](SMSApi.md#smsstock) | **POST** /sms/stock | One-time SMS stock |
| [**SmsUnarchive**](SMSApi.md#smsunarchive) | **POST** /sms/unarchive | Unarchive order |

<a id="purchasesms"></a>
# **PurchaseSms**
> Object PurchaseSms (string service, string idempotencyKey = null, string country = null, string pool = null, decimal? maxPrice = null, int? pricingOption = null, int? quantity = null, string areacode = null, int? exclude = null, int? createToken = null, string activationType = null, int? carrier = null, int? phonenumber = null, int? autoCountry = null, string response = null, int? software = null)

Order SMS

Orders one or more numbers for a service.  ### Response shapes  Without `response=v2` the shape depends on `quantity`: one number returns the order object; several return a JSON array of order objects; if ordering stops part-way, an object with the orders bought so far under `\"0\"`, `\"1\"`, ... plus `message`.  With `response=v2` every case returns the same object:  - `success`: 1 when every requested number was ordered, otherwise 0 - `orders`: the orders that were placed (may be empty) - `failed`: the error that stopped the request, as a one-element list (empty on success) - `message`: a summary - `auto_country`: only with `auto_country=1`, the chosen country  `response=v2` is ignored together with `create_token=1`.  ### Pool  `pool` is a pool ID or name from the `Pool List` endpoint. A name that does not exist answers 400 with `type: INVALID_POOL`. Leave it out (or send it empty or `0`) for any pool.  ### Retrying safely  Send an `Idempotency-Key` header so a retry after a timeout cannot buy twice.

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
    public class PurchaseSmsExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var service = "service_example";  // string | The service or number retrieved from the `Service List` endpoint
            var idempotencyKey = 3f1c2c0e-7d5b-4a52-9a53-1f6f0f0f2b11;  // string |  (optional) 
            var country = "country_example";  // string | The country in ISO format or number retrieved from the `Country List` endpoint (optional) 
            var pool = "pool_example";  // string | The pool ID or name retrieved from the `Pool List` endpoint (optional). An unknown name answers 400 `INVALID_POOL`. (optional) 
            var maxPrice = 8.14D;  // decimal? | The max price you are willing to pay per number (optional) 
            var pricingOption = 56;  // int? | Set to 0 if you'd like the cheapest numbers, set to 1 for highest success rate (optional) 
            var quantity = 56;  // int? | Quantity of numbers ordered, 1 to 20. Must be a whole number. (optional) 
            var areacode = "areacode_example";  // string | Areacodes you would like to include or exclude in JSON format (optional) 
            var exclude = 56;  // int? | Set exclude to 1 if you would like to exclude all listed area codes. (optional) 
            var createToken = 56;  // int? | Optional param; set to 1 if you'd like to create a token link that anyone can access. (optional) 
            var activationType = "activationType_example";  // string | Options: SMS, VOICE, FLASH. SMS will receive regular SMS, VOICE will receive phone calls that mentions the SMS and FLASH is for FLASH calls for verification. (optional) 
            var carrier = 56;  // int? | Options: 1 or 2. Pick a carrier (only works for pool Foxtrot US) (optional) 
            var phonenumber = 56;  // int? | In case you want to select a specific phone number to order. Digits with the country code; a leading +, spaces and dashes are ignored. (optional) 
            var autoCountry = 56;  // int? | Set to 1 to let SMSPool pick the country: every country with stock is scored on its expected success rate (estimated from the country's record across all services when the service has few orders there; weighed down when little stock backs it, minus a little per dollar) with a bonus for a local number, the country your request's IP resolves to; with pricing_option=1 the cheapest country close to the best score wins. Ignored when country is sent. The response then carries auto_country with the chosen country and the reason. (optional) 
            var response = "response_example";  // string | Set to `v2` for one response shape whatever the quantity: `{success, orders, failed, message}`. Leave out for the legacy shapes. (optional) 
            var software = 56;  // int? |  (optional) 

            try
            {
                // Order SMS
                Object result = apiInstance.PurchaseSms(service, idempotencyKey, country, pool, maxPrice, pricingOption, quantity, areacode, exclude, createToken, activationType, carrier, phonenumber, autoCountry, response, software);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.PurchaseSms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseSmsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Order SMS
    ApiResponse<Object> response = apiInstance.PurchaseSmsWithHttpInfo(service, idempotencyKey, country, pool, maxPrice, pricingOption, quantity, areacode, exclude, createToken, activationType, carrier, phonenumber, autoCountry, response, software);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.PurchaseSmsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **string** | The service or number retrieved from the &#x60;Service List&#x60; endpoint |  |
| **idempotencyKey** | **string** |  | [optional]  |
| **country** | **string** | The country in ISO format or number retrieved from the &#x60;Country List&#x60; endpoint | [optional]  |
| **pool** | **string** | The pool ID or name retrieved from the &#x60;Pool List&#x60; endpoint (optional). An unknown name answers 400 &#x60;INVALID_POOL&#x60;. | [optional]  |
| **maxPrice** | **decimal?** | The max price you are willing to pay per number | [optional]  |
| **pricingOption** | **int?** | Set to 0 if you&#39;d like the cheapest numbers, set to 1 for highest success rate | [optional]  |
| **quantity** | **int?** | Quantity of numbers ordered, 1 to 20. Must be a whole number. | [optional]  |
| **areacode** | **string** | Areacodes you would like to include or exclude in JSON format | [optional]  |
| **exclude** | **int?** | Set exclude to 1 if you would like to exclude all listed area codes. | [optional]  |
| **createToken** | **int?** | Optional param; set to 1 if you&#39;d like to create a token link that anyone can access. | [optional]  |
| **activationType** | **string** | Options: SMS, VOICE, FLASH. SMS will receive regular SMS, VOICE will receive phone calls that mentions the SMS and FLASH is for FLASH calls for verification. | [optional]  |
| **carrier** | **int?** | Options: 1 or 2. Pick a carrier (only works for pool Foxtrot US) | [optional]  |
| **phonenumber** | **int?** | In case you want to select a specific phone number to order. Digits with the country code; a leading +, spaces and dashes are ignored. | [optional]  |
| **autoCountry** | **int?** | Set to 1 to let SMSPool pick the country: every country with stock is scored on its expected success rate (estimated from the country&#39;s record across all services when the service has few orders there; weighed down when little stock backs it, minus a little per dollar) with a bonus for a local number, the country your request&#39;s IP resolves to; with pricing_option&#x3D;1 the cheapest country close to the best score wins. Ignored when country is sent. The response then carries auto_country with the chosen country and the reason. | [optional]  |
| **response** | **string** | Set to &#x60;v2&#x60; for one response shape whatever the quantity: &#x60;{success, orders, failed, message}&#x60;. Leave out for the legacy shapes. | [optional]  |
| **software** | **int?** |  | [optional]  |

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
| **409** | Error |  -  |
| **422** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="requestactive"></a>
# **RequestActive**
> Object RequestActive ()

Active orders

The recommended endpoint to retrieve your current active orders, this will display all your orders at the same time. We recommend using this endpoint to iterate through your active orders to retrieve your SMS messages.

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
    public class RequestActiveExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);

            try
            {
                // Active orders
                Object result = apiInstance.RequestActive();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.RequestActive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestActiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Active orders
    ApiResponse<Object> response = apiInstance.RequestActiveWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.RequestActiveWithHttpInfo: " + e.Message);
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

<a id="requestarchive"></a>
# **RequestArchive**
> Object RequestArchive ()

Archive all orders

This API endpoint is used to archive a request in the SMS Pool system. The HTTP POST request should be sent to `https://api.smspool.net/request/archive`.  ### Request Parameters  The \\`key\\` parameter is required for this endpoint, this is your API key.  ### Response  The response for this API endpoint will have a status code of 200, indicating a successful request. The response body will be in JSON format and will contain the following properties:  - `success` (integer): A flag indicating the success of the request. A value of 0 indicates failure. - `message` (string): An optional message providing additional information about the request. In this case, the message is empty.       Please note that the response may contain additional properties not mentioned here, but they can be ignored for the purpose of this documentation.

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
    public class RequestArchiveExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);

            try
            {
                // Archive all orders
                Object result = apiInstance.RequestArchive();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.RequestArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive all orders
    ApiResponse<Object> response = apiInstance.RequestArchiveWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.RequestArchiveWithHttpInfo: " + e.Message);
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

<a id="requestareacodes"></a>
# **RequestAreacodes**
> Object RequestAreacodes (string service, string country, string pool)

Request available areacodes

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
    public class RequestAreacodesExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var service = "service_example";  // string | The service or number retrieved from the `Service List` endpoint
            var country = "country_example";  // string | The country in ISO format or number retrieved from the `Country List` endpoint
            var pool = "pool_example";  // string | The pool or number retrieved from the `Pool List` endpoint (optional)

            try
            {
                // Request available areacodes
                Object result = apiInstance.RequestAreacodes(service, country, pool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.RequestAreacodes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestAreacodesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request available areacodes
    ApiResponse<Object> response = apiInstance.RequestAreacodesWithHttpInfo(service, country, pool);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.RequestAreacodesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **string** | The service or number retrieved from the &#x60;Service List&#x60; endpoint |  |
| **country** | **string** | The country in ISO format or number retrieved from the &#x60;Country List&#x60; endpoint |  |
| **pool** | **string** | The pool or number retrieved from the &#x60;Pool List&#x60; endpoint (optional) |  |

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

<a id="requesthistory"></a>
# **RequestHistory**
> Object RequestHistory (int? start = null, int? length = null, string search = null)

Order History

This API endpoint is used to retrieve the history of SMS requests. It is an HTTP POST request that should be made to the following URL: `https://api.smspool.net/request/history`.  The request requires the \\`key\\` parameter which is your API key.  The response returned by the API is a JSON array. Each element in the array represents a historical SMS request and contains the following properties:  - `cost`: The cost of the SMS request. - `order_code`: The order code associated with the SMS request. - `phonenumber`: The phone number to which the SMS was sent. - `code`: The code associated with the SMS request. - `full_code`: The full code associated with the SMS request. - `short_name`: The short name associated with the SMS request. - `service`: The service associated with the SMS request. - `status`: The status of the SMS request. - `pool`: The pool associated with the SMS request. - `timestamp`: The timestamp of the SMS request. - `completed_on`: The completion date of the SMS request. - `expiry`: The expiry time of the SMS request. - `time_left`: The time left for the SMS request to expire.       Please note that the values for the properties are not provided in the response example, so they may be empty or null.  The last execution of this API request returned a response with a status code of 200, indicating a successful execution. The response body contained an array of SMS request history objects.  Please refer to the API documentation for more details on how to use this endpoint and interpret the response.

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
    public class RequestHistoryExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var start = 56;  // int? | Which row you'd like to start from (optional) 
            var length = 56;  // int? | Max length of all rows (optional) 
            var search = "search_example";  // string | Search query for phone number, order_code, service or country (optional) 

            try
            {
                // Order History
                Object result = apiInstance.RequestHistory(start, length, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.RequestHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Order History
    ApiResponse<Object> response = apiInstance.RequestHistoryWithHttpInfo(start, length, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.RequestHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | Which row you&#39;d like to start from | [optional]  |
| **length** | **int?** | Max length of all rows | [optional]  |
| **search** | **string** | Search query for phone number, order_code, service or country | [optional]  |

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
| **403** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="requesthistorysearch"></a>
# **RequestHistorySearch**
> Object RequestHistorySearch (string search, string cursor = null, int? limit = null)

Search order history

One step of a search through your order history, newest orders first. Each call reads a bounded slice of your orders and returns the matches in it plus `next`. Pass `next` back as `cursor` to continue; the search is complete when `next` is `null`. A call can return no matches and still have a `next`.

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
    public class RequestHistorySearchExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var search = "search_example";  // string | The search term, as typed into the order history's search box. At most 32 characters.
            var cursor = "cursor_example";  // string | `next` from the previous call. Leave out for the first call. (optional) 
            var limit = 56;  // int? | Matches per call, 1 to 500 (default 100). (optional) 

            try
            {
                // Search order history
                Object result = apiInstance.RequestHistorySearch(search, cursor, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.RequestHistorySearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestHistorySearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search order history
    ApiResponse<Object> response = apiInstance.RequestHistorySearchWithHttpInfo(search, cursor, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.RequestHistorySearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **search** | **string** | The search term, as typed into the order history&#39;s search box. At most 32 characters. |  |
| **cursor** | **string** | &#x60;next&#x60; from the previous call. Leave out for the first call. | [optional]  |
| **limit** | **int?** | Matches per call, 1 to 500 (default 100). | [optional]  |

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
| **422** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="smsactivate"></a>
# **SmsActivate**
> Object SmsActivate (string orderid)

Activate SMS

This endpoint will forcefully activate an SMS to set it available for future resends, please keep in mind that these orders are NOT eligible for a refund after activating them.

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
    public class SmsActivateExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var orderid = "orderid_example";  // string | 

            try
            {
                // Activate SMS
                Object result = apiInstance.SmsActivate(orderid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsActivate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsActivateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate SMS
    ApiResponse<Object> response = apiInstance.SmsActivateWithHttpInfo(orderid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsActivateWithHttpInfo: " + e.Message);
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
| **404** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="smsallstock"></a>
# **SmsAllStock**
> Object SmsAllStock (string country = null, string service = null, string pool = null)

One-time stock for all services

Retrieves the one-time SMS stock for every country, service and pool, optionally filtered by `country`, `service` and `pool`. The API key is optional.  The unfiltered list is large and rebuilt once a minute. It is sent with `ETag`, `Last-Modified` and `Cache-Control` headers: send `If-None-Match` (or `If-Modified-Since`) with your next request and you get `304 Not Modified` with no body while the list has not changed.

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
    public class SmsAllStockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var country = "country_example";  // string | Country retrieved from ''Country list\\\" endpoint (optional) (optional) 
            var service = "service_example";  // string | Service retrieved from ''Service list\\\" endpoint (optional) (optional) 
            var pool = "pool_example";  // string | Pool retrieved from ''Pool list\\\" endpoint (optional) (optional) 

            try
            {
                // One-time stock for all services
                Object result = apiInstance.SmsAllStock(country, service, pool);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsAllStock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsAllStockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // One-time stock for all services
    ApiResponse<Object> response = apiInstance.SmsAllStockWithHttpInfo(country, service, pool);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsAllStockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **country** | **string** | Country retrieved from &#39;&#39;Country list\\\&quot; endpoint (optional) | [optional]  |
| **service** | **string** | Service retrieved from &#39;&#39;Service list\\\&quot; endpoint (optional) | [optional]  |
| **pool** | **string** | Pool retrieved from &#39;&#39;Pool list\\\&quot; endpoint (optional) | [optional]  |

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

<a id="smsarchive"></a>
# **SmsArchive**
> Object SmsArchive (string orderid)

Archive one order

Removes one finished order from your active orders. Nothing is refunded and the order stays in your history; `/sms/unarchive` brings it back. An order that is still waiting for an SMS cannot be archived: cancel it with `/sms/cancel` instead.

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
    public class SmsArchiveExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var orderid = "orderid_example";  // string | The order code from the `Order SMS` endpoint.

            try
            {
                // Archive one order
                Object result = apiInstance.SmsArchive(orderid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsArchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsArchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Archive one order
    ApiResponse<Object> response = apiInstance.SmsArchiveWithHttpInfo(orderid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsArchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderid** | **string** | The order code from the &#x60;Order SMS&#x60; endpoint. |  |

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

<a id="smscancel"></a>
# **SmsCancel**
> Object SmsCancel (string orderid = null, string orderids = null, int? expiry = null, int? ban = null)

Cancel SMS

Cancels an order. An order that has not received a code is cancelled and refunded. An order that already has its code cannot be refunded; it is only archived (removed from your active orders).  Both answer `success: 1`; `action` tells them apart: `refunded` or `archived`.  Send `orderids` (comma-separated) to cancel several orders at once; the response then lists one result per order under `results`.

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
    public class SmsCancelExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var orderid = "orderid_example";  // string |  (optional) 
            var orderids = "orderids_example";  // string |  (optional) 
            var expiry = 56;  // int? |  (optional) 
            var ban = 56;  // int? |  (optional) 

            try
            {
                // Cancel SMS
                Object result = apiInstance.SmsCancel(orderid, orderids, expiry, ban);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel SMS
    ApiResponse<Object> response = apiInstance.SmsCancelWithHttpInfo(orderid, orderids, expiry, ban);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderid** | **string** |  | [optional]  |
| **orderids** | **string** |  | [optional]  |
| **expiry** | **int?** |  | [optional]  |
| **ban** | **int?** |  | [optional]  |

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

<a id="smscancelall"></a>
# **SmsCancelAll**
> Object SmsCancelAll ()

Cancel All SMS

# Cancel your SMS order  ## Responses  | **Success** | {\"success\":1} | | **Fail** | {\"success\":0} |

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
    public class SmsCancelAllExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);

            try
            {
                // Cancel All SMS
                Object result = apiInstance.SmsCancelAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsCancelAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsCancelAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel All SMS
    ApiResponse<Object> response = apiInstance.SmsCancelAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsCancelAllWithHttpInfo: " + e.Message);
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

<a id="smscheck"></a>
# **SmsCheck**
> Object SmsCheck (string orderid)

Check SMS

You may run into ratelimits while using this endpoint for high rate requests, we recommend using /request/active instead as it will list all your orders at the same time.

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
    public class SmsCheckExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var orderid = "orderid_example";  // string | 

            try
            {
                // Check SMS
                Object result = apiInstance.SmsCheck(orderid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check SMS
    ApiResponse<Object> response = apiInstance.SmsCheckWithHttpInfo(orderid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsCheckWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="smscheckresend"></a>
# **SmsCheckResend**
> Object SmsCheckResend (string orderid)

Check Resend

Check if the order can be resent or not.

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
    public class SmsCheckResendExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var orderid = "orderid_example";  // string | 

            try
            {
                // Check Resend
                Object result = apiInstance.SmsCheckResend(orderid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsCheckResend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsCheckResendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Resend
    ApiResponse<Object> response = apiInstance.SmsCheckResendWithHttpInfo(orderid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsCheckResendWithHttpInfo: " + e.Message);
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
| **404** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="smsclearcache"></a>
# **SmsClearCache**
> Object SmsClearCache ()

Clear SMS Cache

# Clear your previous SMS cache to allocate previous numbers again  ## Responses  | **Success** | {\"success\":1} |   | **Fail** | {\"success\":0} |

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
    public class SmsClearCacheExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);

            try
            {
                // Clear SMS Cache
                Object result = apiInstance.SmsClearCache();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsClearCache: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsClearCacheWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clear SMS Cache
    ApiResponse<Object> response = apiInstance.SmsClearCacheWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsClearCacheWithHttpInfo: " + e.Message);
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

<a id="smsmissed"></a>
# **SmsMissed**
> Object SmsMissed (int? phonenumber = null, int? limit = null)

Missed SMS

Some messages arrive on a number from your one-time orders but cannot finish the order, such as Ticketmaster and Seated codes, Hark reward payouts or Neon Money Talks messages. This returns those messages, the same ones the Missed SMS tool on the website shows. Only numbers from pool Foxtrot are covered.  The newest messages come first. `url`, `code` and `email` hold the first link, code and email address found in the message, or an empty string.

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
    public class SmsMissedExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var phonenumber = 56;  // int? | Only return messages for this number, including the country code. Leave it out for all your numbers. (optional) 
            var limit = 56;  // int? | Maximum number of messages. Defaults to 100, at most 500. (optional) 

            try
            {
                // Missed SMS
                Object result = apiInstance.SmsMissed(phonenumber, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsMissed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsMissedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Missed SMS
    ApiResponse<Object> response = apiInstance.SmsMissedWithHttpInfo(phonenumber, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsMissedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phonenumber** | **int?** | Only return messages for this number, including the country code. Leave it out for all your numbers. | [optional]  |
| **limit** | **int?** | Maximum number of messages. Defaults to 100, at most 500. | [optional]  |

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

<a id="smsreactivate"></a>
# **SmsReactivate**
> Object SmsReactivate (string orderid)

Reactivate SMS

This endpoint will reactivate an order, please keep in mind that these orders are NOT eligible for a refund after activating them.

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
    public class SmsReactivateExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var orderid = "orderid_example";  // string | 

            try
            {
                // Reactivate SMS
                Object result = apiInstance.SmsReactivate(orderid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsReactivate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsReactivateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reactivate SMS
    ApiResponse<Object> response = apiInstance.SmsReactivateWithHttpInfo(orderid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsReactivateWithHttpInfo: " + e.Message);
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="smsresend"></a>
# **SmsResend**
> Object SmsResend (string orderid)

Resend

# Resend  Resend the order. Keep in mind that some pools will have a charge per resend. You can see whether the resend will have a charge using the \"Check Resend\" endpoint  ## Responses  | **Success** | {\"success\":1,\"message\":\"Number has been requested again\",\"resend\":0} |   | **Fail** | {\"success\":0,\"message\":\"Phonenumber could not be requested again, try later again.\",\"resend\":0} |

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
    public class SmsResendExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var orderid = "orderid_example";  // string | 

            try
            {
                // Resend
                Object result = apiInstance.SmsResend(orderid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsResend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsResendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resend
    ApiResponse<Object> response = apiInstance.SmsResendWithHttpInfo(orderid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsResendWithHttpInfo: " + e.Message);
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
| **404** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="smsstock"></a>
# **SmsStock**
> Object SmsStock (string country, string service, string pool = null, int? includePrice = null)

One-time SMS stock

Retrieves the one-time SMS stock for a country and service, optionally for one pool.  ### Request Parameters  The API key is optional. Without it the request is limited to 20 calls a minute per IP address; with it the limit is 200 a minute.  ### Response  - `success` (integer): 1 when the stock could be read, 0 otherwise. - `amount` (integer): the numbers in stock.

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
    public class SmsStockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var country = "country_example";  // string | Country retrieved from ''Country list\\\" endpoint
            var service = "service_example";  // string | Service retrieved from ''Service list\\\" endpoint
            var pool = "pool_example";  // string | Pool retrieved from ''Pool list\\\" endpoint (optional) 
            var includePrice = 56;  // int? |  (optional) 

            try
            {
                // One-time SMS stock
                Object result = apiInstance.SmsStock(country, service, pool, includePrice);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsStock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsStockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // One-time SMS stock
    ApiResponse<Object> response = apiInstance.SmsStockWithHttpInfo(country, service, pool, includePrice);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsStockWithHttpInfo: " + e.Message);
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
| **includePrice** | **int?** |  | [optional]  |

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

<a id="smsunarchive"></a>
# **SmsUnarchive**
> Object SmsUnarchive (string orderid)

Unarchive order

Move an archived order back to your active orders, so it shows up in **Active orders** and on your dashboard again. Use **Archive all orders** to archive them.

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
    public class SmsUnarchiveExample
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
            var apiInstance = new SMSApi(httpClient, config, httpClientHandler);
            var orderid = "orderid_example";  // string | The order ID retrieved from /purchase/sms

            try
            {
                // Unarchive order
                Object result = apiInstance.SmsUnarchive(orderid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SMSApi.SmsUnarchive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SmsUnarchiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unarchive order
    ApiResponse<Object> response = apiInstance.SmsUnarchiveWithHttpInfo(orderid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SMSApi.SmsUnarchiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderid** | **string** | The order ID retrieved from /purchase/sms |  |

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

