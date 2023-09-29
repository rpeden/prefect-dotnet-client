# PrefectClient.Api.UIApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReadDashboardCounts**](UIApi.md#readdashboardtaskruncounts) | **POST** /ui/task_runs/dashboard/counts | Read Dashboard Task Run Counts |
| [**ReadHistory**](UIApi.md#readflowrunhistory) | **POST** /ui/flow_runs/history | Read Flow Run History |

<a id="readdashboardtaskruncounts"></a>
# **ReadDashboardCounts**
> List&lt;TaskRunCount&gt; ReadDashboardCounts (ReadDashboardTaskRunCountsRequest readDashboardTaskRunCountsRequest)

Read Dashboard Task Run Counts

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
    public class ReadDashboardCountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UIApi(httpClient, config, httpClientHandler);
            var readDashboardTaskRunCountsRequest = new ReadDashboardTaskRunCountsRequest(); // ReadDashboardTaskRunCountsRequest | 

            try
            {
                // Read Dashboard Task Run Counts
                List<TaskRunCount> result = apiInstance.ReadDashboardCounts(readDashboardTaskRunCountsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UIApi.ReadDashboardCounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadDashboardCountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Dashboard Task Run Counts
    ApiResponse<List<TaskRunCount>> response = apiInstance.ReadDashboardCountsWithHttpInfo(readDashboardTaskRunCountsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UIApi.ReadDashboardCountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readDashboardTaskRunCountsRequest** | [**ReadDashboardTaskRunCountsRequest**](ReadDashboardTaskRunCountsRequest.md) |  |  |

### Return type

[**List&lt;TaskRunCount&gt;**](TaskRunCount.md)

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

<a id="readflowrunhistory"></a>
# **ReadHistory**
> List&lt;SimpleFlowRun&gt; ReadHistory (ReadFlowRunHistoryRequest readFlowRunHistoryRequest = null)

Read Flow Run History

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
    public class ReadHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UIApi(httpClient, config, httpClientHandler);
            var readFlowRunHistoryRequest = new ReadFlowRunHistoryRequest(); // ReadFlowRunHistoryRequest |  (optional) 

            try
            {
                // Read Flow Run History
                List<SimpleFlowRun> result = apiInstance.ReadHistory(readFlowRunHistoryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UIApi.ReadHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Flow Run History
    ApiResponse<List<SimpleFlowRun>> response = apiInstance.ReadHistoryWithHttpInfo(readFlowRunHistoryRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UIApi.ReadHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readFlowRunHistoryRequest** | [**ReadFlowRunHistoryRequest**](ReadFlowRunHistoryRequest.md) |  | [optional]  |

### Return type

[**List&lt;SimpleFlowRun&gt;**](SimpleFlowRun.md)

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

