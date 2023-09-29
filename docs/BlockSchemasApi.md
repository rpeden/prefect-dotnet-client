# PrefectClient.Api.BlockSchemasApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Create**](BlockSchemasApi.md#createblockschema) | **POST** /block_schemas/ | Create Block Schema |
| [**Delete**](BlockSchemasApi.md#deleteblockschema) | **DELETE** /block_schemas/{id} | Delete Block Schema |
| [**ReadByChecksum**](BlockSchemasApi.md#readblockschemabychecksum) | **GET** /block_schemas/checksum/{checksum} | Read Block Schema By Checksum |
| [**Read**](BlockSchemasApi.md#readblockschemabyid) | **GET** /block_schemas/{id} | Read Block Schema By Id |
| [**ReadMany**](BlockSchemasApi.md#readblockschemas) | **POST** /block_schemas/filter | Read Block Schemas |

<a id="createblockschema"></a>
# **Create**
> BlockSchema Create (BlockSchemaCreate blockSchemaCreate)

Create Block Schema

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
            var apiInstance = new BlockSchemasApi(httpClient, config, httpClientHandler);
            var blockSchemaCreate = new BlockSchemaCreate(); // BlockSchemaCreate | 

            try
            {
                // Create Block Schema
                BlockSchema result = apiInstance.Create(blockSchemaCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockSchemasApi.Create: " + e.Message);
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
    // Create Block Schema
    ApiResponse<BlockSchema> response = apiInstance.CreateWithHttpInfo(blockSchemaCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockSchemasApi.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockSchemaCreate** | [**BlockSchemaCreate**](BlockSchemaCreate.md) |  |  |

### Return type

[**BlockSchema**](BlockSchema.md)

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

<a id="deleteblockschema"></a>
# **Delete**
> void Delete (Guid id)

Delete Block Schema

Delete a block schema by id.

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
            var apiInstance = new BlockSchemasApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The block schema id

            try
            {
                // Delete Block Schema
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockSchemasApi.Delete: " + e.Message);
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
    // Delete Block Schema
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockSchemasApi.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The block schema id |  |

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

<a id="readblockschemabychecksum"></a>
# **ReadByChecksum**
> BlockSchema ReadByChecksum (string checksum, string varVersion = null)

Read Block Schema By Checksum

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
    public class ReadByChecksumExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BlockSchemasApi(httpClient, config, httpClientHandler);
            var checksum = "checksum_example";  // string | The block schema checksum
            var varVersion = "varVersion_example";  // string | Version of block schema. If not provided the most recently created block schema with the matching checksum will be returned. (optional) 

            try
            {
                // Read Block Schema By Checksum
                BlockSchema result = apiInstance.ReadByChecksum(checksum, varVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockSchemasApi.ReadByChecksum: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadByChecksumWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Block Schema By Checksum
    ApiResponse<BlockSchema> response = apiInstance.ReadByChecksumWithHttpInfo(checksum, varVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockSchemasApi.ReadByChecksumWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **checksum** | **string** | The block schema checksum |  |
| **varVersion** | **string** | Version of block schema. If not provided the most recently created block schema with the matching checksum will be returned. | [optional]  |

### Return type

[**BlockSchema**](BlockSchema.md)

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

<a id="readblockschemabyid"></a>
# **Read**
> BlockSchema Read (Guid id)

Read Block Schema By Id

Get a block schema by id.

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
            var apiInstance = new BlockSchemasApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The block schema id

            try
            {
                // Read Block Schema By Id
                BlockSchema result = apiInstance.Read(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockSchemasApi.Read: " + e.Message);
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
    // Read Block Schema By Id
    ApiResponse<BlockSchema> response = apiInstance.ReadWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockSchemasApi.ReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The block schema id |  |

### Return type

[**BlockSchema**](BlockSchema.md)

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

<a id="readblockschemas"></a>
# **ReadMany**
> List&lt;BlockSchema&gt; ReadMany (ReadBlockSchemasRequest readBlockSchemasRequest = null)

Read Block Schemas

Read all block schemas, optionally filtered by type

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
            var apiInstance = new BlockSchemasApi(httpClient, config, httpClientHandler);
            var readBlockSchemasRequest = new ReadBlockSchemasRequest(); // ReadBlockSchemasRequest |  (optional) 

            try
            {
                // Read Block Schemas
                List<BlockSchema> result = apiInstance.ReadMany(readBlockSchemasRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockSchemasApi.ReadMany: " + e.Message);
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
    // Read Block Schemas
    ApiResponse<List<BlockSchema>> response = apiInstance.ReadManyWithHttpInfo(readBlockSchemasRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockSchemasApi.ReadManyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readBlockSchemasRequest** | [**ReadBlockSchemasRequest**](ReadBlockSchemasRequest.md) |  | [optional]  |

### Return type

[**List&lt;BlockSchema&gt;**](BlockSchema.md)

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

