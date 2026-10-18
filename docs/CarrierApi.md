# SMSPool.Api.CarrierApi

All URIs are relative to *https://api.smspool.net*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CarrierPaidLookup**](CarrierApi.md#carrierpaidlookup) | **POST** /carrier/paid_lookup | Lookup |

<a id="carrierpaidlookup"></a>
# **CarrierPaidLookup**
> Object CarrierPaidLookup (int phonenumber)

Lookup

This API endpoint is used to perform a paid lookup for a phone number. The request is sent via an HTTP POST method to the following URL: `https://api.smspool.net/carrier/paid_lookup`  ``` json {   \"success\": true,   \"phonenumber\": \"\",   \"country\": \"\",   \"carrier\": \"\",   \"carrier_type\": \"\",   \"charge\": 0 }   ```  The `success` field indicates whether the lookup was successful or not. The `phonenumber` field represents the phone number for which the lookup was performed. The `country` field indicates the country associated with the phone number. The `carrier` field provides the name of the carrier associated with the phone number. The `carrier_type` field specifies the type of carrier. The `charge` field represents the cost charged for the lookup operation.  Please note that specific values for `phonenumber`, `country`, `carrier`, and `carrier_type` were not provided in the response, and the `charge` field had a value of 0.  To use this endpoint, send an HTTP POST request to the provided URL with the necessary parameters. The request should include the phone number for which you want to perform the lookup. The response will contain the details of the carrier and associated information.  Make sure to handle any errors that may occur during the lookup process and check the `success` field in the response to determine the outcome of the operation.

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
    public class CarrierPaidLookupExample
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
            var apiInstance = new CarrierApi(httpClient, config, httpClientHandler);
            var phonenumber = 56;  // int | 

            try
            {
                // Lookup
                Object result = apiInstance.CarrierPaidLookup(phonenumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CarrierApi.CarrierPaidLookup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CarrierPaidLookupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lookup
    ApiResponse<Object> response = apiInstance.CarrierPaidLookupWithHttpInfo(phonenumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CarrierApi.CarrierPaidLookupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **phonenumber** | **int** |  |  |

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

