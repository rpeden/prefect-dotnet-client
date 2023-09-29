# PrefectClient.Api.FlowRunNotificationPoliciesApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFlowRunNotificationPolicy**](FlowRunNotificationPoliciesApi.md#createflowrunnotificationpolicy) | **POST** /flow_run_notification_policies/ | Create Flow Run Notification Policy |
| [**DeleteFlowRunNotificationPolicy**](FlowRunNotificationPoliciesApi.md#deleteflowrunnotificationpolicy) | **DELETE** /flow_run_notification_policies/{id} | Delete Flow Run Notification Policy |
| [**ReadMany**](FlowRunNotificationPoliciesApi.md#readflowrunnotificationpolicies) | **POST** /flow_run_notification_policies/filter | Read Flow Run Notification Policies |
| [**ReadFlowRunNotificationPolicy**](FlowRunNotificationPoliciesApi.md#readflowrunnotificationpolicy) | **GET** /flow_run_notification_policies/{id} | Read Flow Run Notification Policy |
| [**UpdateFlowRunNotificationPolicy**](FlowRunNotificationPoliciesApi.md#updateflowrunnotificationpolicy) | **PATCH** /flow_run_notification_policies/{id} | Update Flow Run Notification Policy |

<a id="createflowrunnotificationpolicy"></a>
# **CreateFlowRunNotificationPolicy**
> FlowRunNotificationPolicy CreateFlowRunNotificationPolicy (FlowRunNotificationPolicyCreate flowRunNotificationPolicyCreate)

Create Flow Run Notification Policy

Creates a new flow run notification policy.

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
    public class CreateFlowRunNotificationPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FlowRunNotificationPoliciesApi(httpClient, config, httpClientHandler);
            var flowRunNotificationPolicyCreate = new FlowRunNotificationPolicyCreate(); // FlowRunNotificationPolicyCreate | 

            try
            {
                // Create Flow Run Notification Policy
                FlowRunNotificationPolicy result = apiInstance.CreateFlowRunNotificationPolicy(flowRunNotificationPolicyCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlowRunNotificationPoliciesApi.CreateFlowRunNotificationPolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFlowRunNotificationPolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Flow Run Notification Policy
    ApiResponse<FlowRunNotificationPolicy> response = apiInstance.CreateFlowRunNotificationPolicyWithHttpInfo(flowRunNotificationPolicyCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlowRunNotificationPoliciesApi.CreateFlowRunNotificationPolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **flowRunNotificationPolicyCreate** | [**FlowRunNotificationPolicyCreate**](FlowRunNotificationPolicyCreate.md) |  |  |

### Return type

[**FlowRunNotificationPolicy**](FlowRunNotificationPolicy.md)

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

<a id="deleteflowrunnotificationpolicy"></a>
# **DeleteFlowRunNotificationPolicy**
> void DeleteFlowRunNotificationPolicy (Guid id)

Delete Flow Run Notification Policy

Delete a flow run notification policy by id.

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
    public class DeleteFlowRunNotificationPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FlowRunNotificationPoliciesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The flow run notification policy id

            try
            {
                // Delete Flow Run Notification Policy
                apiInstance.DeleteFlowRunNotificationPolicy(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlowRunNotificationPoliciesApi.DeleteFlowRunNotificationPolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFlowRunNotificationPolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Flow Run Notification Policy
    apiInstance.DeleteFlowRunNotificationPolicyWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlowRunNotificationPoliciesApi.DeleteFlowRunNotificationPolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The flow run notification policy id |  |

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

<a id="readflowrunnotificationpolicies"></a>
# **ReadMany**
> List&lt;FlowRunNotificationPolicy&gt; ReadMany (ReadFlowRunNotificationPoliciesRequest readFlowRunNotificationPoliciesRequest = null)

Read Flow Run Notification Policies

Query for flow run notification policies.

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
            var apiInstance = new FlowRunNotificationPoliciesApi(httpClient, config, httpClientHandler);
            var readFlowRunNotificationPoliciesRequest = new ReadFlowRunNotificationPoliciesRequest(); // ReadFlowRunNotificationPoliciesRequest |  (optional) 

            try
            {
                // Read Flow Run Notification Policies
                List<FlowRunNotificationPolicy> result = apiInstance.ReadMany(readFlowRunNotificationPoliciesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlowRunNotificationPoliciesApi.ReadMany: " + e.Message);
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
    // Read Flow Run Notification Policies
    ApiResponse<List<FlowRunNotificationPolicy>> response = apiInstance.ReadManyWithHttpInfo(readFlowRunNotificationPoliciesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlowRunNotificationPoliciesApi.ReadManyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readFlowRunNotificationPoliciesRequest** | [**ReadFlowRunNotificationPoliciesRequest**](ReadFlowRunNotificationPoliciesRequest.md) |  | [optional]  |

### Return type

[**List&lt;FlowRunNotificationPolicy&gt;**](FlowRunNotificationPolicy.md)

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

<a id="readflowrunnotificationpolicy"></a>
# **ReadFlowRunNotificationPolicy**
> FlowRunNotificationPolicy ReadFlowRunNotificationPolicy (Guid id)

Read Flow Run Notification Policy

Get a flow run notification policy by id.

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
    public class ReadFlowRunNotificationPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FlowRunNotificationPoliciesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The flow run notification policy id

            try
            {
                // Read Flow Run Notification Policy
                FlowRunNotificationPolicy result = apiInstance.ReadFlowRunNotificationPolicy(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlowRunNotificationPoliciesApi.ReadFlowRunNotificationPolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadFlowRunNotificationPolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Flow Run Notification Policy
    ApiResponse<FlowRunNotificationPolicy> response = apiInstance.ReadFlowRunNotificationPolicyWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlowRunNotificationPoliciesApi.ReadFlowRunNotificationPolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The flow run notification policy id |  |

### Return type

[**FlowRunNotificationPolicy**](FlowRunNotificationPolicy.md)

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

<a id="updateflowrunnotificationpolicy"></a>
# **UpdateFlowRunNotificationPolicy**
> void UpdateFlowRunNotificationPolicy (Guid id, FlowRunNotificationPolicyUpdate flowRunNotificationPolicyUpdate)

Update Flow Run Notification Policy

Updates an existing flow run notification policy.

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
    public class UpdateFlowRunNotificationPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new FlowRunNotificationPoliciesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The flow run notification policy id
            var flowRunNotificationPolicyUpdate = new FlowRunNotificationPolicyUpdate(); // FlowRunNotificationPolicyUpdate | 

            try
            {
                // Update Flow Run Notification Policy
                apiInstance.UpdateFlowRunNotificationPolicy(id, flowRunNotificationPolicyUpdate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FlowRunNotificationPoliciesApi.UpdateFlowRunNotificationPolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateFlowRunNotificationPolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Flow Run Notification Policy
    apiInstance.UpdateFlowRunNotificationPolicyWithHttpInfo(id, flowRunNotificationPolicyUpdate);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FlowRunNotificationPoliciesApi.UpdateFlowRunNotificationPolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The flow run notification policy id |  |
| **flowRunNotificationPolicyUpdate** | [**FlowRunNotificationPolicyUpdate**](FlowRunNotificationPolicyUpdate.md) |  |  |

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

