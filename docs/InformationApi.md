# SMSPool.Api.InformationApi

All URIs are relative to *https://api.smspool.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CountryRetrieveAll**](InformationApi.md#countryretrieveall) | **GET** /country/retrieve_all | Country list |
| [**PoolRetrieveAll**](InformationApi.md#poolretrieveall) | **POST** /pool/retrieve_all | Pool list |
| [**PoolRetrieveValid**](InformationApi.md#poolretrievevalid) | **POST** /pool/retrieve_valid | Suggested Pools |
| [**RequestBalance**](InformationApi.md#requestbalance) | **POST** /request/balance | Balance |
| [**RequestSuccessRate**](InformationApi.md#requestsuccessrate) | **POST** /request/success_rate | Retrieve country success rates per service |
| [**RequestSuggestedCountries**](InformationApi.md#requestsuggestedcountries) | **POST** /request/suggested_countries | Suggested Countries |
| [**ServiceRetrieveAll**](InformationApi.md#serviceretrieveall) | **GET** /service/retrieve_all | Service list |

<a id="countryretrieveall"></a>
# **CountryRetrieveAll**
> Object CountryRetrieveAll (string showAll = null)

Country list

This API endpoint is used to retrieve the full country list for SMSPool requests. It sends an HTTP GET request to the URL `https://api.smspool.net/country/retrieve_all`.

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
    public class CountryRetrieveAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InformationApi(httpClient, config, httpClientHandler);
            var showAll = "showAll_example";  // string |  (optional) 

            try
            {
                // Country list
                Object result = apiInstance.CountryRetrieveAll(showAll);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InformationApi.CountryRetrieveAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CountryRetrieveAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Country list
    ApiResponse<Object> response = apiInstance.CountryRetrieveAllWithHttpInfo(showAll);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InformationApi.CountryRetrieveAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **showAll** | **string** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="poolretrieveall"></a>
# **PoolRetrieveAll**
> Object PoolRetrieveAll ()

Pool list

This API endpoint is used to retrieve a list of our active pools for SMSPool requests. It sends an HTTP POST request to the URL `https://api.smspool.net/pool/retrieve_all`.

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
    public class PoolRetrieveAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InformationApi(httpClient, config, httpClientHandler);

            try
            {
                // Pool list
                Object result = apiInstance.PoolRetrieveAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InformationApi.PoolRetrieveAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PoolRetrieveAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pool list
    ApiResponse<Object> response = apiInstance.PoolRetrieveAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InformationApi.PoolRetrieveAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="poolretrievevalid"></a>
# **PoolRetrieveValid**
> Object PoolRetrieveValid (string service, string country, string web = null, string includeStock = null)

Suggested Pools

This API endpoint is used to retrieve suggested pools for SMSPool requests. It sends an HTTP POST request to the URL `https://api.smspool.net/pool/retrieve_valid`.  Please use either the service ID, or the service name as service param.

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
    public class PoolRetrieveValidExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InformationApi(httpClient, config, httpClientHandler);
            var service = "service_example";  // string | Service retrieved from ''Service list\\\" endpoint
            var country = "country_example";  // string | Country retrieved from ''Country list\\\" endpoint
            var web = "web_example";  // string | Return array format (optional) 
            var includeStock = "includeStock_example";  // string |  (optional) 

            try
            {
                // Suggested Pools
                Object result = apiInstance.PoolRetrieveValid(service, country, web, includeStock);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InformationApi.PoolRetrieveValid: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PoolRetrieveValidWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Suggested Pools
    ApiResponse<Object> response = apiInstance.PoolRetrieveValidWithHttpInfo(service, country, web, includeStock);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InformationApi.PoolRetrieveValidWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **string** | Service retrieved from &#39;&#39;Service list\\\&quot; endpoint |  |
| **country** | **string** | Country retrieved from &#39;&#39;Country list\\\&quot; endpoint |  |
| **web** | **string** | Return array format | [optional]  |
| **includeStock** | **string** |  | [optional]  |

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

<a id="requestbalance"></a>
# **RequestBalance**
> Object RequestBalance ()

Balance

This HTTP POST request is used to retrieve the balance for a specific SMSPool. The request is sent to the URL `https://api.smspool.net/request/balance`.  ### Request Parameters  This request require the \\`key\\` param which is your API key  ### Response  The response to this request will have a status code of 200 if the request is successful. The response body will be in JSON format and will include a `balance` field. However, the last execution of this request returned an empty string for the `balance` field.  Please note that the actual value of the `balance` field may vary depending on the user and its configuration.

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
    public class RequestBalanceExample
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
            var apiInstance = new InformationApi(httpClient, config, httpClientHandler);

            try
            {
                // Balance
                Object result = apiInstance.RequestBalance();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InformationApi.RequestBalance: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestBalanceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Balance
    ApiResponse<Object> response = apiInstance.RequestBalanceWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InformationApi.RequestBalanceWithHttpInfo: " + e.Message);
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
| **400** | Error |  -  |
| **401** | Malformed API key |  -  |
| **403** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="requestsuccessrate"></a>
# **RequestSuccessRate**
> Object RequestSuccessRate (string service, string country = null)

Retrieve country success rates per service

This API endpoint is used to retrieve success per country for SMSPool requests. It sends an HTTP POST request to the URL `https://api.smspool.net/request/success_rate`.  Please use either the service ID, or the service name as service param.

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
    public class RequestSuccessRateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InformationApi(httpClient, config, httpClientHandler);
            var service = "service_example";  // string | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint
            var country = "country_example";  // string | Country name or country ID which can be retrieved at the /country/retrieve_all endpoint (optional) 

            try
            {
                // Retrieve country success rates per service
                Object result = apiInstance.RequestSuccessRate(service, country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InformationApi.RequestSuccessRate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestSuccessRateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve country success rates per service
    ApiResponse<Object> response = apiInstance.RequestSuccessRateWithHttpInfo(service, country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InformationApi.RequestSuccessRateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **string** | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint |  |
| **country** | **string** | Country name or country ID which can be retrieved at the /country/retrieve_all endpoint | [optional]  |

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

<a id="requestsuggestedcountries"></a>
# **RequestSuggestedCountries**
> Object RequestSuggestedCountries (string service)

Suggested Countries

This API endpoint is used to retrieve suggested countries for SMS pool requests. It sends an HTTP POST request to the URL `https://api.smspool.net/request/suggested_countries`.  Please use either the service ID, or the service name as service param.

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
    public class RequestSuggestedCountriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InformationApi(httpClient, config, httpClientHandler);
            var service = "service_example";  // string | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint

            try
            {
                // Suggested Countries
                Object result = apiInstance.RequestSuggestedCountries(service);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InformationApi.RequestSuggestedCountries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestSuggestedCountriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Suggested Countries
    ApiResponse<Object> response = apiInstance.RequestSuggestedCountriesWithHttpInfo(service);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InformationApi.RequestSuggestedCountriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **string** | Service name or service ID which can be retrieved at the /service/retrieve_all endpoint |  |

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

<a id="serviceretrieveall"></a>
# **ServiceRetrieveAll**
> Object ServiceRetrieveAll (string country = null)

Service list

This API endpoint is used to retrieve the full service list for SMSPool requests. It sends an HTTP GET request to the URL `https://api.smspool.net/service/retrieve_all`.

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
    public class ServiceRetrieveAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new InformationApi(httpClient, config, httpClientHandler);
            var country = 1;  // string |  (optional) 

            try
            {
                // Service list
                Object result = apiInstance.ServiceRetrieveAll(country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InformationApi.ServiceRetrieveAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceRetrieveAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Service list
    ApiResponse<Object> response = apiInstance.ServiceRetrieveAllWithHttpInfo(country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InformationApi.ServiceRetrieveAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **country** | **string** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

