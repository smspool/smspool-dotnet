# SMSPool.Api.ESIMsApi

All URIs are relative to *https://api.smspool.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**EsimDelete**](ESIMsApi.md#esimdelete) | **POST** /esim/delete | Delete eSIM |
| [**EsimHistory**](ESIMsApi.md#esimhistory) | **POST** /esim/history | View eSIM history |
| [**EsimLabelUpdate**](ESIMsApi.md#esimlabelupdate) | **POST** /esim/label/update | Update eSIM label |
| [**EsimPlans**](ESIMsApi.md#esimplans) | **POST** /esim/plans | View eSIM plans per country |
| [**EsimPricing**](ESIMsApi.md#esimpricing) | **POST** /esim/pricing | View eSIM countries |
| [**EsimProfile**](ESIMsApi.md#esimprofile) | **POST** /esim/profile | View eSIM profile |
| [**EsimPurchase**](ESIMsApi.md#esimpurchase) | **POST** /esim/purchase | Purchase eSIM |
| [**EsimTopup**](ESIMsApi.md#esimtopup) | **POST** /esim/topup | Top up eSIM |
| [**EsimTopupPlans**](ESIMsApi.md#esimtopupplans) | **POST** /esim/topup_plans | Top Up Plans |

<a id="esimdelete"></a>
# **EsimDelete**
> Object EsimDelete (string transactionId)

Delete eSIM

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
    public class EsimDeleteExample
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
            var apiInstance = new ESIMsApi(httpClient, config, httpClientHandler);
            var transactionId = "transactionId_example";  // string | transactionId retrieved from /esim/purchase

            try
            {
                // Delete eSIM
                Object result = apiInstance.EsimDelete(transactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ESIMsApi.EsimDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EsimDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete eSIM
    ApiResponse<Object> response = apiInstance.EsimDeleteWithHttpInfo(transactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ESIMsApi.EsimDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | transactionId retrieved from /esim/purchase |  |

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

<a id="esimhistory"></a>
# **EsimHistory**
> Object EsimHistory (int? start = null, int? length = null, string search = null)

View eSIM history

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
    public class EsimHistoryExample
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
            var apiInstance = new ESIMsApi(httpClient, config, httpClientHandler);
            var start = 56;  // int? | Start page (optional) 
            var length = 56;  // int? | Amount of rows per page (optional) 
            var search = "search_example";  // string | Alphanumeric search (optional) 

            try
            {
                // View eSIM history
                Object result = apiInstance.EsimHistory(start, length, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ESIMsApi.EsimHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EsimHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // View eSIM history
    ApiResponse<Object> response = apiInstance.EsimHistoryWithHttpInfo(start, length, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ESIMsApi.EsimHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | Start page | [optional]  |
| **length** | **int?** | Amount of rows per page | [optional]  |
| **search** | **string** | Alphanumeric search | [optional]  |

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

<a id="esimlabelupdate"></a>
# **EsimLabelUpdate**
> Object EsimLabelUpdate (string transactionId, string label = null)

Update eSIM label

Set or clear the label of one of your eSIMs. The label is returned as `label` by **View eSIM history**, so you can use it to tell your eSIMs apart.  A label can be up to 30 characters long and may only contain letters, numbers and spaces. Leave `label` out, or send it empty, to remove the label.

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
    public class EsimLabelUpdateExample
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
            var apiInstance = new ESIMsApi(httpClient, config, httpClientHandler);
            var transactionId = "transactionId_example";  // string | transactionId retrieved from /esim/purchase
            var label = "label_example";  // string | The new label: letters, numbers and spaces, at most 30 characters. Empty or left out removes the label. (optional) 

            try
            {
                // Update eSIM label
                Object result = apiInstance.EsimLabelUpdate(transactionId, label);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ESIMsApi.EsimLabelUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EsimLabelUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update eSIM label
    ApiResponse<Object> response = apiInstance.EsimLabelUpdateWithHttpInfo(transactionId, label);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ESIMsApi.EsimLabelUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | transactionId retrieved from /esim/purchase |  |
| **label** | **string** | The new label: letters, numbers and spaces, at most 30 characters. Empty or left out removes the label. | [optional]  |

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

<a id="esimplans"></a>
# **EsimPlans**
> Object EsimPlans (string country)

View eSIM plans per country

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
    public class EsimPlansExample
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
            var apiInstance = new ESIMsApi(httpClient, config, httpClientHandler);
            var country = "country_example";  // string | ISO 3166 country code

            try
            {
                // View eSIM plans per country
                Object result = apiInstance.EsimPlans(country);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ESIMsApi.EsimPlans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EsimPlansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // View eSIM plans per country
    ApiResponse<Object> response = apiInstance.EsimPlansWithHttpInfo(country);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ESIMsApi.EsimPlansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **country** | **string** | ISO 3166 country code |  |

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

<a id="esimpricing"></a>
# **EsimPricing**
> Object EsimPricing (int? start = null, int? length = null, string search = null)

View eSIM countries

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
    public class EsimPricingExample
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
            var apiInstance = new ESIMsApi(httpClient, config, httpClientHandler);
            var start = 56;  // int? | Start page (optional) 
            var length = 56;  // int? | Amount of rows per page (optional) 
            var search = "search_example";  // string | Search query for country (optional) 

            try
            {
                // View eSIM countries
                Object result = apiInstance.EsimPricing(start, length, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ESIMsApi.EsimPricing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EsimPricingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // View eSIM countries
    ApiResponse<Object> response = apiInstance.EsimPricingWithHttpInfo(start, length, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ESIMsApi.EsimPricingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **int?** | Start page | [optional]  |
| **length** | **int?** | Amount of rows per page | [optional]  |
| **search** | **string** | Search query for country | [optional]  |

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

<a id="esimprofile"></a>
# **EsimProfile**
> Object EsimProfile (string transactionId = null)

View eSIM profile

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
    public class EsimProfileExample
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
            var apiInstance = new ESIMsApi(httpClient, config, httpClientHandler);
            var transactionId = "transactionId_example";  // string | transactionId retrieved from /esim/purchase (optional) 

            try
            {
                // View eSIM profile
                Object result = apiInstance.EsimProfile(transactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ESIMsApi.EsimProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EsimProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // View eSIM profile
    ApiResponse<Object> response = apiInstance.EsimProfileWithHttpInfo(transactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ESIMsApi.EsimProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | transactionId retrieved from /esim/purchase | [optional]  |

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

<a id="esimpurchase"></a>
# **EsimPurchase**
> Object EsimPurchase (int plan)

Purchase eSIM

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
    public class EsimPurchaseExample
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
            var apiInstance = new ESIMsApi(httpClient, config, httpClientHandler);
            var plan = 56;  // int | The plan ID which is obtained from /esim/pricing

            try
            {
                // Purchase eSIM
                Object result = apiInstance.EsimPurchase(plan);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ESIMsApi.EsimPurchase: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EsimPurchaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Purchase eSIM
    ApiResponse<Object> response = apiInstance.EsimPurchaseWithHttpInfo(plan);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ESIMsApi.EsimPurchaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **plan** | **int** | The plan ID which is obtained from /esim/pricing |  |

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

<a id="esimtopup"></a>
# **EsimTopup**
> Object EsimTopup (string transactionId, int plan)

Top up eSIM

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
    public class EsimTopupExample
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
            var apiInstance = new ESIMsApi(httpClient, config, httpClientHandler);
            var transactionId = "transactionId_example";  // string | Transaction ID retrieved from eSIM history
            var plan = 56;  // int | Topup plan retrieved from \\\"Top Up Plans\\\"

            try
            {
                // Top up eSIM
                Object result = apiInstance.EsimTopup(transactionId, plan);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ESIMsApi.EsimTopup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EsimTopupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Top up eSIM
    ApiResponse<Object> response = apiInstance.EsimTopupWithHttpInfo(transactionId, plan);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ESIMsApi.EsimTopupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | Transaction ID retrieved from eSIM history |  |
| **plan** | **int** | Topup plan retrieved from \\\&quot;Top Up Plans\\\&quot; |  |

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

<a id="esimtopupplans"></a>
# **EsimTopupPlans**
> Object EsimTopupPlans (int plan)

Top Up Plans

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
    public class EsimTopupPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.smspool.net";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ESIMsApi(httpClient, config, httpClientHandler);
            var plan = 56;  // int | `plan` retrieved from eSIM history

            try
            {
                // Top Up Plans
                Object result = apiInstance.EsimTopupPlans(plan);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ESIMsApi.EsimTopupPlans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EsimTopupPlansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Top Up Plans
    ApiResponse<Object> response = apiInstance.EsimTopupPlansWithHttpInfo(plan);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ESIMsApi.EsimTopupPlansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **plan** | **int** | &#x60;plan&#x60; retrieved from eSIM history |  |

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

