# PrefectClient.Api.DeploymentsApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Count**](DeploymentsApi.md#countdeployments) | **POST** /deployments/count | Count Deployments |
| [**Create**](DeploymentsApi.md#createdeployment) | **POST** /deployments/ | Create Deployment |
| [**CreateFlowRunFrom**](DeploymentsApi.md#createflowrunfromdeployment) | **POST** /deployments/{id}/create_flow_run | Create Flow Run From Deployment |
| [**Delete**](DeploymentsApi.md#deletedeployment) | **DELETE** /deployments/{id} | Delete Deployment |
| [**Read**](DeploymentsApi.md#readdeployment) | **GET** /deployments/{id} | Read Deployment |
| [**ReadByName**](DeploymentsApi.md#readdeploymentbyname) | **GET** /deployments/name/{flow_name}/{deployment_name} | Read Deployment By Name |
| [**ReadMany**](DeploymentsApi.md#readdeployments) | **POST** /deployments/filter | Read Deployments |
| [**Schedule**](DeploymentsApi.md#scheduledeployment) | **POST** /deployments/{id}/schedule | Schedule Deployment |
| [**SetScheduleActive**](DeploymentsApi.md#setscheduleactive) | **POST** /deployments/{id}/set_schedule_active | Set Schedule Active |
| [**SetScheduleInactive**](DeploymentsApi.md#setscheduleinactive) | **POST** /deployments/{id}/set_schedule_inactive | Set Schedule Inactive |
| [**Update**](DeploymentsApi.md#updatedeployment) | **PATCH** /deployments/{id} | Update Deployment |
| [**WorkQueueCheck**](DeploymentsApi.md#workqueuecheckfordeployment) | **GET** /deployments/{id}/work_queue_check | Work Queue Check For Deployment |

<a id="countdeployments"></a>
# **Count**
> int Count (CountDeploymentsRequest countDeploymentsRequest = null)

Count Deployments

Count deployments.

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
    public class CountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var countDeploymentsRequest = new CountDeploymentsRequest(); // CountDeploymentsRequest |  (optional) 

            try
            {
                // Count Deployments
                int result = apiInstance.Count(countDeploymentsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.Count: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Count Deployments
    ApiResponse<int> response = apiInstance.CountWithHttpInfo(countDeploymentsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.CountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **countDeploymentsRequest** | [**CountDeploymentsRequest**](CountDeploymentsRequest.md) |  | [optional]  |

### Return type

**int**

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

<a id="createdeployment"></a>
# **Create**
> DeploymentResponse Create (DeploymentCreate deploymentCreate)

Create Deployment

Gracefully creates a new deployment from the provided schema. If a deployment with\\nthe same name and flow_id already exists, the deployment is updated.\\n\\nIf the deployment has an active schedule, flow runs will be scheduled.\\nWhen upserting, any scheduled runs from the existing deployment will be deleted.

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
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var deploymentCreate = new DeploymentCreate(); // DeploymentCreate | 

            try
            {
                // Create Deployment
                DeploymentResponse result = apiInstance.Create(deploymentCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.Create: " + e.Message);
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
    // Create Deployment
    ApiResponse<DeploymentResponse> response = apiInstance.CreateWithHttpInfo(deploymentCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deploymentCreate** | [**DeploymentCreate**](DeploymentCreate.md) |  |  |

### Return type

[**DeploymentResponse**](DeploymentResponse.md)

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

<a id="createflowrunfromdeployment"></a>
# **CreateFlowRunFrom**
> FlowRunResponse CreateFlowRunFrom (Guid id, DeploymentFlowRunCreate deploymentFlowRunCreate)

Create Flow Run From Deployment

Create a flow run from a deployment.\\n\\nAny parameters not provided will be inferred from the deployment parameters.\\nIf tags are not provided, the deployment tags will be used.\\n\\nIf no state is provided, the flow run will be created in a SCHEDULED state.

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
    public class CreateFlowRunFromExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The deployment id
            var deploymentFlowRunCreate = new DeploymentFlowRunCreate(); // DeploymentFlowRunCreate | 

            try
            {
                // Create Flow Run From Deployment
                FlowRunResponse result = apiInstance.CreateFlowRunFrom(id, deploymentFlowRunCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.CreateFlowRunFrom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFlowRunFromWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Flow Run From Deployment
    ApiResponse<FlowRunResponse> response = apiInstance.CreateFlowRunFromWithHttpInfo(id, deploymentFlowRunCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.CreateFlowRunFromWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The deployment id |  |
| **deploymentFlowRunCreate** | [**DeploymentFlowRunCreate**](DeploymentFlowRunCreate.md) |  |  |

### Return type

[**FlowRunResponse**](FlowRunResponse.md)

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

<a id="deletedeployment"></a>
# **Delete**
> void Delete (Guid id)

Delete Deployment

Delete a deployment by id.

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
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The deployment id

            try
            {
                // Delete Deployment
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.Delete: " + e.Message);
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
    // Delete Deployment
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The deployment id |  |

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

<a id="readdeployment"></a>
# **Read**
> DeploymentResponse Read (Guid id)

Read Deployment

Get a deployment by id.

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
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The deployment id

            try
            {
                // Read Deployment
                DeploymentResponse result = apiInstance.Read(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.Read: " + e.Message);
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
    // Read Deployment
    ApiResponse<DeploymentResponse> response = apiInstance.ReadWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.ReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The deployment id |  |

### Return type

[**DeploymentResponse**](DeploymentResponse.md)

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

<a id="readdeploymentbyname"></a>
# **ReadByName**
> DeploymentResponse ReadByName (string flowName, string deploymentName)

Read Deployment By Name

Get a deployment using the name of the flow and the deployment.

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
    public class ReadByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var flowName = "flowName_example";  // string | The name of the flow
            var deploymentName = "deploymentName_example";  // string | The name of the deployment

            try
            {
                // Read Deployment By Name
                DeploymentResponse result = apiInstance.ReadByName(flowName, deploymentName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.ReadByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Deployment By Name
    ApiResponse<DeploymentResponse> response = apiInstance.ReadByNameWithHttpInfo(flowName, deploymentName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.ReadByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **flowName** | **string** | The name of the flow |  |
| **deploymentName** | **string** | The name of the deployment |  |

### Return type

[**DeploymentResponse**](DeploymentResponse.md)

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

<a id="readdeployments"></a>
# **ReadMany**
> List&lt;DeploymentResponse&gt; ReadMany (ReadDeploymentsRequest readDeploymentsRequest = null)

Read Deployments

Query for deployments.

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
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var readDeploymentsRequest = new ReadDeploymentsRequest(); // ReadDeploymentsRequest |  (optional) 

            try
            {
                // Read Deployments
                List<DeploymentResponse> result = apiInstance.ReadMany(readDeploymentsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.ReadMany: " + e.Message);
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
    // Read Deployments
    ApiResponse<List<DeploymentResponse>> response = apiInstance.ReadManyWithHttpInfo(readDeploymentsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.ReadManyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readDeploymentsRequest** | [**ReadDeploymentsRequest**](ReadDeploymentsRequest.md) |  | [optional]  |

### Return type

[**List&lt;DeploymentResponse&gt;**](DeploymentResponse.md)

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

<a id="scheduledeployment"></a>
# **Schedule**
> Object Schedule (Guid id, ScheduleDeploymentRequest scheduleDeploymentRequest = null)

Schedule Deployment

Schedule runs for a deployment. For backfills, provide start/end times in the past.\\n\\nThis function will generate the minimum number of runs that satisfy the min\\nand max times, and the min and max counts. Specifically, the following order\\nwill be respected.\\n\\n    - Runs will be generated starting on or after the `start_time`\\n    - No more than `max_runs` runs will be generated\\n    - No runs will be generated after `end_time` is reached\\n    - At least `min_runs` runs will be generated\\n    - Runs will be generated until at least `start_time + min_time` is reached

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
    public class ScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The deployment id
            var scheduleDeploymentRequest = new ScheduleDeploymentRequest(); // ScheduleDeploymentRequest |  (optional) 

            try
            {
                // Schedule Deployment
                Object result = apiInstance.Schedule(id, scheduleDeploymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.Schedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Schedule Deployment
    ApiResponse<Object> response = apiInstance.ScheduleWithHttpInfo(id, scheduleDeploymentRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.ScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The deployment id |  |
| **scheduleDeploymentRequest** | [**ScheduleDeploymentRequest**](ScheduleDeploymentRequest.md) |  | [optional]  |

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

<a id="setscheduleactive"></a>
# **SetScheduleActive**
> Object SetScheduleActive (Guid id)

Set Schedule Active

Set a deployment schedule to active. Runs will be scheduled immediately.

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
    public class SetScheduleActiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The deployment id

            try
            {
                // Set Schedule Active
                Object result = apiInstance.SetScheduleActive(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.SetScheduleActive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetScheduleActiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Schedule Active
    ApiResponse<Object> response = apiInstance.SetScheduleActiveWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.SetScheduleActiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The deployment id |  |

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

<a id="setscheduleinactive"></a>
# **SetScheduleInactive**
> Object SetScheduleInactive (Guid id)

Set Schedule Inactive

Set a deployment schedule to inactive. Any auto-scheduled runs still in a Scheduled\\nstate will be deleted.

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
    public class SetScheduleInactiveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The deployment id

            try
            {
                // Set Schedule Inactive
                Object result = apiInstance.SetScheduleInactive(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.SetScheduleInactive: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetScheduleInactiveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Schedule Inactive
    ApiResponse<Object> response = apiInstance.SetScheduleInactiveWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.SetScheduleInactiveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The deployment id |  |

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

<a id="updatedeployment"></a>
# **Update**
> void Update (string id, DeploymentUpdate deploymentUpdate)

Update Deployment

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
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The deployment id
            var deploymentUpdate = new DeploymentUpdate(); // DeploymentUpdate | 

            try
            {
                // Update Deployment
                apiInstance.Update(id, deploymentUpdate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.Update: " + e.Message);
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
    // Update Deployment
    apiInstance.UpdateWithHttpInfo(id, deploymentUpdate);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.UpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The deployment id |  |
| **deploymentUpdate** | [**DeploymentUpdate**](DeploymentUpdate.md) |  |  |

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

<a id="workqueuecheckfordeployment"></a>
# **WorkQueueCheck**
> List&lt;WorkQueue&gt; WorkQueueCheck (Guid id)

Work Queue Check For Deployment

Get list of work-queues that are able to pick up the specified deployment.\\n\\nThis endpoint is intended to be used by the UI to provide users warnings\\nabout deployments that are unable to be executed because there are no work\\nqueues that will pick up their runs, based on existing filter criteria. It\\nmay be deprecated in the future because there is not a strict relationship\\nbetween work queues and deployments.

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
    public class WorkQueueCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DeploymentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The deployment id

            try
            {
                // Work Queue Check For Deployment
                List<WorkQueue> result = apiInstance.WorkQueueCheck(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeploymentsApi.WorkQueueCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WorkQueueCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Work Queue Check For Deployment
    ApiResponse<List<WorkQueue>> response = apiInstance.WorkQueueCheckWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeploymentsApi.WorkQueueCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The deployment id |  |

### Return type

[**List&lt;WorkQueue&gt;**](WorkQueue.md)

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

