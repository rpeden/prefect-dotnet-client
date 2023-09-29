# PrefectClient.Api.ConcurrencyLimitsV2Api

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BulkDecrementActiveSlots**](ConcurrencyLimitsV2Api.md#bulkdecrementactiveslots) | **POST** /v2/concurrency_limits/decrement | Bulk Decrement Active Slots |
| [**BulkIncrementActiveSlots**](ConcurrencyLimitsV2Api.md#bulkincrementactiveslots) | **POST** /v2/concurrency_limits/increment | Bulk Increment Active Slots |
| [**Create**](ConcurrencyLimitsV2Api.md#createconcurrencylimitv2) | **POST** /v2/concurrency_limits/ | Create Concurrency Limit V2 |
| [**Delete**](ConcurrencyLimitsV2Api.md#deleteconcurrencylimitv2) | **DELETE** /v2/concurrency_limits/{id_or_name} | Delete Concurrency Limit V2 |
| [**ReadAll**](ConcurrencyLimitsV2Api.md#readallconcurrencylimitsv2) | **POST** /v2/concurrency_limits/filter | Read All Concurrency Limits V2 |
| [**Read**](ConcurrencyLimitsV2Api.md#readconcurrencylimitv2) | **GET** /v2/concurrency_limits/{id_or_name} | Read Concurrency Limit V2 |
| [**Update**](ConcurrencyLimitsV2Api.md#updateconcurrencylimitv2) | **PATCH** /v2/concurrency_limits/{id_or_name} | Update Concurrency Limit V2 |

<a id="bulkdecrementactiveslots"></a>
# **BulkDecrementActiveSlots**
> List&lt;MinimalConcurrencyLimitResponse&gt; BulkDecrementActiveSlots (BulkDecrementActiveSlotsRequest bulkDecrementActiveSlotsRequest)

Bulk Decrement Active Slots

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using PrefectClient.Api;
using PrefectClient.Client;
using PrefectClient.Model;

namespace Example
{
    public class BulkDecrementActiveSlotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsV2Api(httpClient, config, httpClientHandler);
            var bulkDecrementActiveSlotsRequest = new BulkDecrementActiveSlotsRequest(); // BulkDecrementActiveSlotsRequest | 

            try
            {
                // Bulk Decrement Active Slots
                List<MinimalConcurrencyLimitResponse> result = apiInstance.BulkDecrementActiveSlots(bulkDecrementActiveSlotsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsV2Api.BulkDecrementActiveSlots: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkDecrementActiveSlotsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Decrement Active Slots
    ApiResponse<List<MinimalConcurrencyLimitResponse>> response = apiInstance.BulkDecrementActiveSlotsWithHttpInfo(bulkDecrementActiveSlotsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsV2Api.BulkDecrementActiveSlotsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bulkDecrementActiveSlotsRequest** | [**BulkDecrementActiveSlotsRequest**](BulkDecrementActiveSlotsRequest.md) |  |  |

### Return type

[**List&lt;MinimalConcurrencyLimitResponse&gt;**](MinimalConcurrencyLimitResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bulkincrementactiveslots"></a>
# **BulkIncrementActiveSlots**
> List&lt;MinimalConcurrencyLimitResponse&gt; BulkIncrementActiveSlots (BulkIncrementActiveSlotsRequest bulkIncrementActiveSlotsRequest)

Bulk Increment Active Slots

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using PrefectClient.Api;
using PrefectClient.Client;
using PrefectClient.Model;

namespace Example
{
    public class BulkIncrementActiveSlotsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsV2Api(httpClient, config, httpClientHandler);
            var bulkIncrementActiveSlotsRequest = new BulkIncrementActiveSlotsRequest(); // BulkIncrementActiveSlotsRequest | 

            try
            {
                // Bulk Increment Active Slots
                List<MinimalConcurrencyLimitResponse> result = apiInstance.BulkIncrementActiveSlots(bulkIncrementActiveSlotsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsV2Api.BulkIncrementActiveSlots: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkIncrementActiveSlotsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Increment Active Slots
    ApiResponse<List<MinimalConcurrencyLimitResponse>> response = apiInstance.BulkIncrementActiveSlotsWithHttpInfo(bulkIncrementActiveSlotsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsV2Api.BulkIncrementActiveSlotsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bulkIncrementActiveSlotsRequest** | [**BulkIncrementActiveSlotsRequest**](BulkIncrementActiveSlotsRequest.md) |  |  |

### Return type

[**List&lt;MinimalConcurrencyLimitResponse&gt;**](MinimalConcurrencyLimitResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createconcurrencylimitv2"></a>
# **Create**
> ConcurrencyLimitV2 Create (ConcurrencyLimitV2Create concurrencyLimitV2Create)

Create Concurrency Limit V2

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using PrefectClient.Api;
using PrefectClient.Client;
using PrefectClient.Model;

namespace Example
{
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsV2Api(httpClient, config, httpClientHandler);
            var concurrencyLimitV2Create = new ConcurrencyLimitV2Create(); // ConcurrencyLimitV2Create | 

            try
            {
                // Create Concurrency Limit V2
                ConcurrencyLimitV2 result = apiInstance.Create(concurrencyLimitV2Create);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsV2Api.Create: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Concurrency Limit V2
    ApiResponse<ConcurrencyLimitV2> response = apiInstance.CreateWithHttpInfo(concurrencyLimitV2Create);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsV2Api.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **concurrencyLimitV2Create** | [**ConcurrencyLimitV2Create**](ConcurrencyLimitV2Create.md) |  |  |

### Return type

[**ConcurrencyLimitV2**](ConcurrencyLimitV2.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteconcurrencylimitv2"></a>
# **Delete**
> void Delete (IdOrName idOrName)

Delete Concurrency Limit V2

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using PrefectClient.Api;
using PrefectClient.Client;
using PrefectClient.Model;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsV2Api(httpClient, config, httpClientHandler);
            var idOrName = new IdOrName(); // IdOrName | The ID or name of the concurrency limit

            try
            {
                // Delete Concurrency Limit V2
                apiInstance.Delete(idOrName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsV2Api.Delete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Concurrency Limit V2
    apiInstance.DeleteWithHttpInfo(idOrName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsV2Api.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idOrName** | [**IdOrName**](IdOrName.md) | The ID or name of the concurrency limit |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readallconcurrencylimitsv2"></a>
# **ReadAll**
> List&lt;ConcurrencyLimitV2&gt; ReadAll (ReadAllConcurrencyLimitsV2Request readAllConcurrencyLimitsV2Request = null)

Read All Concurrency Limits V2

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using PrefectClient.Api;
using PrefectClient.Client;
using PrefectClient.Model;

namespace Example
{
    public class ReadAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsV2Api(httpClient, config, httpClientHandler);
            var readAllConcurrencyLimitsV2Request = new ReadAllConcurrencyLimitsV2Request(); // ReadAllConcurrencyLimitsV2Request |  (optional) 

            try
            {
                // Read All Concurrency Limits V2
                List<ConcurrencyLimitV2> result = apiInstance.ReadAll(readAllConcurrencyLimitsV2Request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsV2Api.ReadAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read All Concurrency Limits V2
    ApiResponse<List<ConcurrencyLimitV2>> response = apiInstance.ReadAllWithHttpInfo(readAllConcurrencyLimitsV2Request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsV2Api.ReadAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readAllConcurrencyLimitsV2Request** | [**ReadAllConcurrencyLimitsV2Request**](ReadAllConcurrencyLimitsV2Request.md) |  | [optional]  |

### Return type

[**List&lt;ConcurrencyLimitV2&gt;**](ConcurrencyLimitV2.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readconcurrencylimitv2"></a>
# **Read**
> ConcurrencyLimitV2 Read (IdOrName idOrName)

Read Concurrency Limit V2

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using PrefectClient.Api;
using PrefectClient.Client;
using PrefectClient.Model;

namespace Example
{
    public class ReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsV2Api(httpClient, config, httpClientHandler);
            var idOrName = new IdOrName(); // IdOrName | The ID or name of the concurrency limit

            try
            {
                // Read Concurrency Limit V2
                ConcurrencyLimitV2 result = apiInstance.Read(idOrName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsV2Api.Read: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Concurrency Limit V2
    ApiResponse<ConcurrencyLimitV2> response = apiInstance.ReadWithHttpInfo(idOrName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsV2Api.ReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idOrName** | [**IdOrName**](IdOrName.md) | The ID or name of the concurrency limit |  |

### Return type

[**ConcurrencyLimitV2**](ConcurrencyLimitV2.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateconcurrencylimitv2"></a>
# **Update**
> void Update (IdOrName idOrName, ConcurrencyLimitV2Update concurrencyLimitV2Update)

Update Concurrency Limit V2

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using PrefectClient.Api;
using PrefectClient.Client;
using PrefectClient.Model;

namespace Example
{
    public class UpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsV2Api(httpClient, config, httpClientHandler);
            var idOrName = new IdOrName(); // IdOrName | The ID or name of the concurrency limit
            var concurrencyLimitV2Update = new ConcurrencyLimitV2Update(); // ConcurrencyLimitV2Update | 

            try
            {
                // Update Concurrency Limit V2
                apiInstance.Update(idOrName, concurrencyLimitV2Update);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsV2Api.Update: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Concurrency Limit V2
    apiInstance.UpdateWithHttpInfo(idOrName, concurrencyLimitV2Update);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsV2Api.UpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idOrName** | [**IdOrName**](IdOrName.md) | The ID or name of the concurrency limit |  |
| **concurrencyLimitV2Update** | [**ConcurrencyLimitV2Update**](ConcurrencyLimitV2Update.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

