# PrefectClient.Api.WorkPoolsApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Create**](WorkPoolsApi.md#createworkpool) | **POST** /work_pools/ | Create Work Pool |
| [**CreateWorkQueue**](WorkPoolsApi.md#createworkpoolworkqueue) | **POST** /work_pools/{work_pool_name}/queues | Create Work Queue |
| [**Delete**](WorkPoolsApi.md#deleteworkpool) | **DELETE** /work_pools/{name} | Delete Work Pool |
| [**DeleteWorkQueue**](WorkPoolsApi.md#deleteworkpoolworkqueue) | **DELETE** /work_pools/{work_pool_name}/queues/{name} | Delete Work Queue |
| [**GetScheduledFlowRuns**](WorkPoolsApi.md#getscheduledflowruns) | **POST** /work_pools/{name}/get_scheduled_flow_runs | Get Scheduled Flow Runs |
| [**Read**](WorkPoolsApi.md#readworkpool) | **GET** /work_pools/{name} | Read Work Pool |
| [**ReadWorkQueue**](WorkPoolsApi.md#readworkpoolworkqueue) | **GET** /work_pools/{work_pool_name}/queues/{name} | Read Work Queue |
| [**ReadWorkQueues**](WorkPoolsApi.md#readworkpoolworkqueues) | **POST** /work_pools/{work_pool_name}/queues/filter | Read Work Queues |
| [**ReadMany**](WorkPoolsApi.md#readworkpools) | **POST** /work_pools/filter | Read Work Pools |
| [**ReadWorkers**](WorkPoolsApi.md#readworkers) | **POST** /work_pools/{work_pool_name}/workers/filter | Read Workers |
| [**Update**](WorkPoolsApi.md#updateworkpool) | **PATCH** /work_pools/{name} | Update Work Pool |
| [**UpdateWorkQueue**](WorkPoolsApi.md#updateworkpoolworkqueue) | **PATCH** /work_pools/{work_pool_name}/queues/{name} | Update Work Queue |
| [**WorkerHeartbeat**](WorkPoolsApi.md#workerheartbeat) | **POST** /work_pools/{work_pool_name}/workers/heartbeat | Worker Heartbeat |

<a id="createworkpool"></a>
# **Create**
> WorkPool Create (WorkPoolCreate workPoolCreate)

Create Work Pool

Creates a new work pool. If a work pool with the same\\nname already exists, an error will be raised.

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
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var workPoolCreate = new WorkPoolCreate(); // WorkPoolCreate | 

            try
            {
                // Create Work Pool
                WorkPool result = apiInstance.Create(workPoolCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.Create: " + e.Message);
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
    // Create Work Pool
    ApiResponse<WorkPool> response = apiInstance.CreateWithHttpInfo(workPoolCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workPoolCreate** | [**WorkPoolCreate**](WorkPoolCreate.md) |  |  |

### Return type

[**WorkPool**](WorkPool.md)

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

<a id="createworkpoolworkqueue"></a>
# **CreateWorkQueue**
> WorkQueueResponse CreateWorkQueue (string workPoolName, WorkQueueCreate workQueueCreate)

Create Work Queue

Creates a new work pool queue. If a work pool queue with the same\\nname already exists, an error will be raised.

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
    public class CreateWorkQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var workPoolName = "workPoolName_example";  // string | The work pool name
            var workQueueCreate = new WorkQueueCreate(); // WorkQueueCreate | 

            try
            {
                // Create Work Queue
                WorkQueueResponse result = apiInstance.CreateWorkQueue(workPoolName, workQueueCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.CreateWorkQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWorkQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Work Queue
    ApiResponse<WorkQueueResponse> response = apiInstance.CreateWorkQueueWithHttpInfo(workPoolName, workQueueCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.CreateWorkQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workPoolName** | **string** | The work pool name |  |
| **workQueueCreate** | [**WorkQueueCreate**](WorkQueueCreate.md) |  |  |

### Return type

[**WorkQueueResponse**](WorkQueueResponse.md)

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

<a id="deleteworkpool"></a>
# **Delete**
> void Delete (string name)

Delete Work Pool

Delete a work pool

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
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The work pool name

            try
            {
                // Delete Work Pool
                apiInstance.Delete(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.Delete: " + e.Message);
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
    // Delete Work Pool
    apiInstance.DeleteWithHttpInfo(name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The work pool name |  |

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

<a id="deleteworkpoolworkqueue"></a>
# **DeleteWorkQueue**
> void DeleteWorkQueue (string workPoolName, string name)

Delete Work Queue

Delete a work pool queue

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
    public class DeleteWorkQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var workPoolName = "workPoolName_example";  // string | The work pool name
            var name = "name_example";  // string | The work pool queue name

            try
            {
                // Delete Work Queue
                apiInstance.DeleteWorkQueue(workPoolName, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.DeleteWorkQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWorkQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Work Queue
    apiInstance.DeleteWorkQueueWithHttpInfo(workPoolName, name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.DeleteWorkQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workPoolName** | **string** | The work pool name |  |
| **name** | **string** | The work pool queue name |  |

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

<a id="getscheduledflowruns"></a>
# **GetScheduledFlowRuns**
> List&lt;WorkerFlowRunResponse&gt; GetScheduledFlowRuns (string name, GetScheduledFlowRunsRequest getScheduledFlowRunsRequest = null)

Get Scheduled Flow Runs

Load scheduled runs for a worker

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
    public class GetScheduledFlowRunsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The work pool name
            var getScheduledFlowRunsRequest = new GetScheduledFlowRunsRequest(); // GetScheduledFlowRunsRequest |  (optional) 

            try
            {
                // Get Scheduled Flow Runs
                List<WorkerFlowRunResponse> result = apiInstance.GetScheduledFlowRuns(name, getScheduledFlowRunsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.GetScheduledFlowRuns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScheduledFlowRunsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Scheduled Flow Runs
    ApiResponse<List<WorkerFlowRunResponse>> response = apiInstance.GetScheduledFlowRunsWithHttpInfo(name, getScheduledFlowRunsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.GetScheduledFlowRunsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The work pool name |  |
| **getScheduledFlowRunsRequest** | [**GetScheduledFlowRunsRequest**](GetScheduledFlowRunsRequest.md) |  | [optional]  |

### Return type

[**List&lt;WorkerFlowRunResponse&gt;**](WorkerFlowRunResponse.md)

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

<a id="readworkpool"></a>
# **Read**
> WorkPool Read (string name)

Read Work Pool

Read a work pool by name

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
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The work pool name

            try
            {
                // Read Work Pool
                WorkPool result = apiInstance.Read(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.Read: " + e.Message);
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
    // Read Work Pool
    ApiResponse<WorkPool> response = apiInstance.ReadWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.ReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The work pool name |  |

### Return type

[**WorkPool**](WorkPool.md)

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

<a id="readworkpoolworkqueue"></a>
# **ReadWorkQueue**
> WorkQueueResponse ReadWorkQueue (string workPoolName, string name)

Read Work Queue

Read a work pool queue

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
    public class ReadWorkQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var workPoolName = "workPoolName_example";  // string | The work pool name
            var name = "name_example";  // string | The work pool queue name

            try
            {
                // Read Work Queue
                WorkQueueResponse result = apiInstance.ReadWorkQueue(workPoolName, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.ReadWorkQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadWorkQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Work Queue
    ApiResponse<WorkQueueResponse> response = apiInstance.ReadWorkQueueWithHttpInfo(workPoolName, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.ReadWorkQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workPoolName** | **string** | The work pool name |  |
| **name** | **string** | The work pool queue name |  |

### Return type

[**WorkQueueResponse**](WorkQueueResponse.md)

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

<a id="readworkpoolworkqueues"></a>
# **ReadWorkQueues**
> List&lt;WorkQueueResponse&gt; ReadWorkQueues (string workPoolName, ReadWorkQueuesRequest readWorkQueuesRequest = null)

Read Work Queues

Read all work pool queues

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
    public class ReadWorkQueuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var workPoolName = "workPoolName_example";  // string | The work pool name
            var readWorkQueuesRequest = new ReadWorkQueuesRequest(); // ReadWorkQueuesRequest |  (optional) 

            try
            {
                // Read Work Queues
                List<WorkQueueResponse> result = apiInstance.ReadWorkQueues(workPoolName, readWorkQueuesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.ReadWorkQueues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadWorkQueuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Work Queues
    ApiResponse<List<WorkQueueResponse>> response = apiInstance.ReadWorkQueuesWithHttpInfo(workPoolName, readWorkQueuesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.ReadWorkQueuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workPoolName** | **string** | The work pool name |  |
| **readWorkQueuesRequest** | [**ReadWorkQueuesRequest**](ReadWorkQueuesRequest.md) |  | [optional]  |

### Return type

[**List&lt;WorkQueueResponse&gt;**](WorkQueueResponse.md)

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

<a id="readworkpools"></a>
# **ReadMany**
> List&lt;WorkPool&gt; ReadMany (ReadWorkPoolsRequest readWorkPoolsRequest = null)

Read Work Pools

Read multiple work pools

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
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var readWorkPoolsRequest = new ReadWorkPoolsRequest(); // ReadWorkPoolsRequest |  (optional) 

            try
            {
                // Read Work Pools
                List<WorkPool> result = apiInstance.ReadMany(readWorkPoolsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.ReadMany: " + e.Message);
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
    // Read Work Pools
    ApiResponse<List<WorkPool>> response = apiInstance.ReadManyWithHttpInfo(readWorkPoolsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.ReadManyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readWorkPoolsRequest** | [**ReadWorkPoolsRequest**](ReadWorkPoolsRequest.md) |  | [optional]  |

### Return type

[**List&lt;WorkPool&gt;**](WorkPool.md)

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

<a id="readworkers"></a>
# **ReadWorkers**
> List&lt;Worker&gt; ReadWorkers (string workPoolName, ReadWorkersRequest readWorkersRequest = null)

Read Workers

Read all worker processes

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
    public class ReadWorkersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var workPoolName = "workPoolName_example";  // string | The work pool name
            var readWorkersRequest = new ReadWorkersRequest(); // ReadWorkersRequest |  (optional) 

            try
            {
                // Read Workers
                List<Worker> result = apiInstance.ReadWorkers(workPoolName, readWorkersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.ReadWorkers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadWorkersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Workers
    ApiResponse<List<Worker>> response = apiInstance.ReadWorkersWithHttpInfo(workPoolName, readWorkersRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.ReadWorkersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workPoolName** | **string** | The work pool name |  |
| **readWorkersRequest** | [**ReadWorkersRequest**](ReadWorkersRequest.md) |  | [optional]  |

### Return type

[**List&lt;Worker&gt;**](Worker.md)

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

<a id="updateworkpool"></a>
# **Update**
> void Update (string name, WorkPoolUpdate workPoolUpdate)

Update Work Pool

Update a work pool

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
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The work pool name
            var workPoolUpdate = new WorkPoolUpdate(); // WorkPoolUpdate | 

            try
            {
                // Update Work Pool
                apiInstance.Update(name, workPoolUpdate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.Update: " + e.Message);
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
    // Update Work Pool
    apiInstance.UpdateWithHttpInfo(name, workPoolUpdate);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.UpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The work pool name |  |
| **workPoolUpdate** | [**WorkPoolUpdate**](WorkPoolUpdate.md) |  |  |

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

<a id="updateworkpoolworkqueue"></a>
# **UpdateWorkQueue**
> void UpdateWorkQueue (string workPoolName, string name, WorkQueueUpdate workQueueUpdate)

Update Work Queue

Update a work pool queue

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
    public class UpdateWorkQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var workPoolName = "workPoolName_example";  // string | The work pool name
            var name = "name_example";  // string | The work pool queue name
            var workQueueUpdate = new WorkQueueUpdate(); // WorkQueueUpdate | 

            try
            {
                // Update Work Queue
                apiInstance.UpdateWorkQueue(workPoolName, name, workQueueUpdate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.UpdateWorkQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWorkQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Work Queue
    apiInstance.UpdateWorkQueueWithHttpInfo(workPoolName, name, workQueueUpdate);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.UpdateWorkQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workPoolName** | **string** | The work pool name |  |
| **name** | **string** | The work pool queue name |  |
| **workQueueUpdate** | [**WorkQueueUpdate**](WorkQueueUpdate.md) |  |  |

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

<a id="workerheartbeat"></a>
# **WorkerHeartbeat**
> void WorkerHeartbeat (string workPoolName, WorkerHeartbeatRequest workerHeartbeatRequest)

Worker Heartbeat

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
    public class WorkerHeartbeatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new WorkPoolsApi(httpClient, config, httpClientHandler);
            var workPoolName = "workPoolName_example";  // string | The work pool name
            var workerHeartbeatRequest = new WorkerHeartbeatRequest(); // WorkerHeartbeatRequest | 

            try
            {
                // Worker Heartbeat
                apiInstance.WorkerHeartbeat(workPoolName, workerHeartbeatRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkPoolsApi.WorkerHeartbeat: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkerHeartbeatWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Worker Heartbeat
    apiInstance.WorkerHeartbeatWithHttpInfo(workPoolName, workerHeartbeatRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkPoolsApi.WorkerHeartbeatWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workPoolName** | **string** | The work pool name |  |
| **workerHeartbeatRequest** | [**WorkerHeartbeatRequest**](WorkerHeartbeatRequest.md) |  |  |

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

