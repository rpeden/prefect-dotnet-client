# PrefectClient.Api.ConcurrencyLimitsApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Create**](ConcurrencyLimitsApi.md#createconcurrencylimit) | **POST** /concurrency_limits/ | Create Concurrency Limit |
| [**Delete**](ConcurrencyLimitsApi.md#deleteconcurrencylimit) | **DELETE** /concurrency_limits/{id} | Delete Concurrency Limit |
| [**DeleteByTag**](ConcurrencyLimitsApi.md#deleteconcurrencylimitbytag) | **DELETE** /concurrency_limits/tag/{tag} | Delete Concurrency Limit By Tag |
| [**Read**](ConcurrencyLimitsApi.md#readconcurrencylimit) | **GET** /concurrency_limits/{id} | Read Concurrency Limit |
| [**ReadByTag**](ConcurrencyLimitsApi.md#readconcurrencylimitbytag) | **GET** /concurrency_limits/tag/{tag} | Read Concurrency Limit By Tag |
| [**ReadMany**](ConcurrencyLimitsApi.md#readconcurrencylimits) | **POST** /concurrency_limits/filter | Read Concurrency Limits |
| [**ResetByTag**](ConcurrencyLimitsApi.md#resetconcurrencylimitbytag) | **POST** /concurrency_limits/tag/{tag}/reset | Reset Concurrency Limit By Tag |

<a id="createconcurrencylimit"></a>
# **Create**
> ConcurrencyLimit Create (ConcurrencyLimitCreate concurrencyLimitCreate)

Create Concurrency Limit

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
            var apiInstance = new ConcurrencyLimitsApi(httpClient, config, httpClientHandler);
            var concurrencyLimitCreate = new ConcurrencyLimitCreate(); // ConcurrencyLimitCreate | 

            try
            {
                // Create Concurrency Limit
                ConcurrencyLimit result = apiInstance.Create(concurrencyLimitCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsApi.Create: " + e.Message);
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
    // Create Concurrency Limit
    ApiResponse<ConcurrencyLimit> response = apiInstance.CreateWithHttpInfo(concurrencyLimitCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsApi.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **concurrencyLimitCreate** | [**ConcurrencyLimitCreate**](ConcurrencyLimitCreate.md) |  |  |

### Return type

[**ConcurrencyLimit**](ConcurrencyLimit.md)

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

<a id="deleteconcurrencylimit"></a>
# **Delete**
> Object Delete (Guid id)

Delete Concurrency Limit

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
            var apiInstance = new ConcurrencyLimitsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The concurrency limit id

            try
            {
                // Delete Concurrency Limit
                Object result = apiInstance.Delete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsApi.Delete: " + e.Message);
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
    // Delete Concurrency Limit
    ApiResponse<Object> response = apiInstance.DeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsApi.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The concurrency limit id |  |

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
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteconcurrencylimitbytag"></a>
# **DeleteByTag**
> Object DeleteByTag (string tag)

Delete Concurrency Limit By Tag

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
    public class DeleteByTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsApi(httpClient, config, httpClientHandler);
            var tag = "tag_example";  // string | The tag name

            try
            {
                // Delete Concurrency Limit By Tag
                Object result = apiInstance.DeleteByTag(tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsApi.DeleteByTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteByTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Concurrency Limit By Tag
    ApiResponse<Object> response = apiInstance.DeleteByTagWithHttpInfo(tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsApi.DeleteByTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tag** | **string** | The tag name |  |

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
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readconcurrencylimit"></a>
# **Read**
> ConcurrencyLimit Read (Guid id)

Read Concurrency Limit

Get a concurrency limit by id.\\n\\nThe `active slots` field contains a list of TaskRun IDs currently using a\\nconcurrency slot for the specified tag.

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
            var apiInstance = new ConcurrencyLimitsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The concurrency limit id

            try
            {
                // Read Concurrency Limit
                ConcurrencyLimit result = apiInstance.Read(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsApi.Read: " + e.Message);
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
    // Read Concurrency Limit
    ApiResponse<ConcurrencyLimit> response = apiInstance.ReadWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsApi.ReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The concurrency limit id |  |

### Return type

[**ConcurrencyLimit**](ConcurrencyLimit.md)

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

<a id="readconcurrencylimitbytag"></a>
# **ReadByTag**
> ConcurrencyLimit ReadByTag (string tag)

Read Concurrency Limit By Tag

Get a concurrency limit by tag.\\n\\nThe `active slots` field contains a list of TaskRun IDs currently using a\\nconcurrency slot for the specified tag.

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
    public class ReadByTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsApi(httpClient, config, httpClientHandler);
            var tag = "tag_example";  // string | The tag name

            try
            {
                // Read Concurrency Limit By Tag
                ConcurrencyLimit result = apiInstance.ReadByTag(tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsApi.ReadByTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadByTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Concurrency Limit By Tag
    ApiResponse<ConcurrencyLimit> response = apiInstance.ReadByTagWithHttpInfo(tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsApi.ReadByTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tag** | **string** | The tag name |  |

### Return type

[**ConcurrencyLimit**](ConcurrencyLimit.md)

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

<a id="readconcurrencylimits"></a>
# **ReadMany**
> List&lt;ConcurrencyLimit&gt; ReadMany (ReadConcurrencyLimitsRequest readConcurrencyLimitsRequest = null)

Read Concurrency Limits

Query for concurrency limits.\\n\\nFor each concurrency limit the `active slots` field contains a list of TaskRun IDs\\ncurrently using a concurrency slot for the specified tag.

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
    public class ReadManyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsApi(httpClient, config, httpClientHandler);
            var readConcurrencyLimitsRequest = new ReadConcurrencyLimitsRequest(); // ReadConcurrencyLimitsRequest |  (optional) 

            try
            {
                // Read Concurrency Limits
                List<ConcurrencyLimit> result = apiInstance.ReadMany(readConcurrencyLimitsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsApi.ReadMany: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadManyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Concurrency Limits
    ApiResponse<List<ConcurrencyLimit>> response = apiInstance.ReadManyWithHttpInfo(readConcurrencyLimitsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsApi.ReadManyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readConcurrencyLimitsRequest** | [**ReadConcurrencyLimitsRequest**](ReadConcurrencyLimitsRequest.md) |  | [optional]  |

### Return type

[**List&lt;ConcurrencyLimit&gt;**](ConcurrencyLimit.md)

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

<a id="resetconcurrencylimitbytag"></a>
# **ResetByTag**
> Object ResetByTag (string tag, ResetConcurrencyLimitByTagRequest resetConcurrencyLimitByTagRequest = null)

Reset Concurrency Limit By Tag

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
    public class ResetByTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ConcurrencyLimitsApi(httpClient, config, httpClientHandler);
            var tag = "tag_example";  // string | The tag name
            var resetConcurrencyLimitByTagRequest = new ResetConcurrencyLimitByTagRequest(); // ResetConcurrencyLimitByTagRequest |  (optional) 

            try
            {
                // Reset Concurrency Limit By Tag
                Object result = apiInstance.ResetByTag(tag, resetConcurrencyLimitByTagRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConcurrencyLimitsApi.ResetByTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetByTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset Concurrency Limit By Tag
    ApiResponse<Object> response = apiInstance.ResetByTagWithHttpInfo(tag, resetConcurrencyLimitByTagRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConcurrencyLimitsApi.ResetByTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tag** | **string** | The tag name |  |
| **resetConcurrencyLimitByTagRequest** | [**ResetConcurrencyLimitByTagRequest**](ResetConcurrencyLimitByTagRequest.md) |  | [optional]  |

### Return type

**Object**

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

