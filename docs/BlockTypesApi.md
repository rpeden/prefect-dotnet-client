# PrefectClient.Api.BlockTypesApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Create**](BlockTypesApi.md#createblocktype) | **POST** /block_types/ | Create Block Type |
| [**Delete**](BlockTypesApi.md#deleteblocktype) | **DELETE** /block_types/{id} | Delete Block Type |
| [**InstallSystem**](BlockTypesApi.md#installsystemblocktypes) | **POST** /block_types/install_system_block_types | Install System Block Types |
| [**ReadBlockDocumentByName**](BlockTypesApi.md#readblockdocumentbynameforblocktype) | **GET** /block_types/slug/{slug}/block_documents/name/{block_document_name} | Read Block Document By Name For Block Type |
| [**ReadBlockDocumentByName**](BlockTypesApi.md#readblockdocumentbynameforblocktype_0) | **GET** /block_types/slug/{slug}/block_documents/name/{block_document_name} | Read Block Document By Name For Block Type |
| [**ReadBlockDocuments**](BlockTypesApi.md#readblockdocumentsforblocktype) | **GET** /block_types/slug/{slug}/block_documents | Read Block Documents For Block Type |
| [**ReadBlockDocuments**](BlockTypesApi.md#readblockdocumentsforblocktype_0) | **GET** /block_types/slug/{slug}/block_documents | Read Block Documents For Block Type |
| [**Read**](BlockTypesApi.md#readblocktypebyid) | **GET** /block_types/{id} | Read Block Type By Id |
| [**ReadBySlug**](BlockTypesApi.md#readblocktypebyslug) | **GET** /block_types/slug/{slug} | Read Block Type By Slug |
| [**ReadMany**](BlockTypesApi.md#readblocktypes) | **POST** /block_types/filter | Read Block Types |
| [**Update**](BlockTypesApi.md#updateblocktype) | **PATCH** /block_types/{id} | Update Block Type |

<a id="createblocktype"></a>
# **Create**
> BlockType Create (BlockTypeCreate blockTypeCreate)

Create Block Type

Create a new block type

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
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);
            var blockTypeCreate = new BlockTypeCreate(); // BlockTypeCreate | 

            try
            {
                // Create Block Type
                BlockType result = apiInstance.Create(blockTypeCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.Create: " + e.Message);
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
    // Create Block Type
    ApiResponse<BlockType> response = apiInstance.CreateWithHttpInfo(blockTypeCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockTypeCreate** | [**BlockTypeCreate**](BlockTypeCreate.md) |  |  |

### Return type

[**BlockType**](BlockType.md)

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

<a id="deleteblocktype"></a>
# **Delete**
> void Delete (Guid id)

Delete Block Type

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
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The block type ID

            try
            {
                // Delete Block Type
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.Delete: " + e.Message);
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
    // Delete Block Type
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The block type ID |  |

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

<a id="installsystemblocktypes"></a>
# **InstallSystem**
> Object InstallSystem ()

Install System Block Types

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
    public class InstallSystemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);

            try
            {
                // Install System Block Types
                Object result = apiInstance.InstallSystem();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.InstallSystem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallSystemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Install System Block Types
    ApiResponse<Object> response = apiInstance.InstallSystemWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.InstallSystemWithHttpInfo: " + e.Message);
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
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="readblockdocumentbynameforblocktype"></a>
# **ReadBlockDocumentByName**
> BlockDocument ReadBlockDocumentByName (string slug, string blockDocumentName, bool? includeSecrets = null)

Read Block Document By Name For Block Type

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
    public class ReadBlockDocumentByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);
            var slug = "slug_example";  // string | The block type name
            var blockDocumentName = "blockDocumentName_example";  // string | The block type name
            var includeSecrets = false;  // bool? | Whether to include sensitive values in the block document. (optional)  (default to false)

            try
            {
                // Read Block Document By Name For Block Type
                BlockDocument result = apiInstance.ReadBlockDocumentByName(slug, blockDocumentName, includeSecrets);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.ReadBlockDocumentByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadBlockDocumentByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Block Document By Name For Block Type
    ApiResponse<BlockDocument> response = apiInstance.ReadBlockDocumentByNameWithHttpInfo(slug, blockDocumentName, includeSecrets);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.ReadBlockDocumentByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | The block type name |  |
| **blockDocumentName** | **string** | The block type name |  |
| **includeSecrets** | **bool?** | Whether to include sensitive values in the block document. | [optional] [default to false] |

### Return type

[**BlockDocument**](BlockDocument.md)

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

<a id="readblockdocumentbynameforblocktype_0"></a>
# **ReadBlockDocumentByName**
> BlockDocument ReadBlockDocumentByName (string slug, string blockDocumentName, bool? includeSecrets = null)

Read Block Document By Name For Block Type

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
    public class ReadBlockDocumentByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);
            var slug = "slug_example";  // string | The block type name
            var blockDocumentName = "blockDocumentName_example";  // string | The block type name
            var includeSecrets = false;  // bool? | Whether to include sensitive values in the block document. (optional)  (default to false)

            try
            {
                // Read Block Document By Name For Block Type
                BlockDocument result = apiInstance.ReadBlockDocumentByName(slug, blockDocumentName, includeSecrets);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.ReadBlockDocumentByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadBlockDocumentByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Block Document By Name For Block Type
    ApiResponse<BlockDocument> response = apiInstance.ReadBlockDocumentByNameWithHttpInfo(slug, blockDocumentName, includeSecrets);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.ReadBlockDocumentByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | The block type name |  |
| **blockDocumentName** | **string** | The block type name |  |
| **includeSecrets** | **bool?** | Whether to include sensitive values in the block document. | [optional] [default to false] |

### Return type

[**BlockDocument**](BlockDocument.md)

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

<a id="readblockdocumentsforblocktype"></a>
# **ReadBlockDocuments**
> List&lt;BlockDocument&gt; ReadBlockDocuments (string slug, bool? includeSecrets = null)

Read Block Documents For Block Type

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
    public class ReadBlockDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);
            var slug = "slug_example";  // string | The block type name
            var includeSecrets = false;  // bool? | Whether to include sensitive values in the block document. (optional)  (default to false)

            try
            {
                // Read Block Documents For Block Type
                List<BlockDocument> result = apiInstance.ReadBlockDocuments(slug, includeSecrets);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.ReadBlockDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadBlockDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Block Documents For Block Type
    ApiResponse<List<BlockDocument>> response = apiInstance.ReadBlockDocumentsWithHttpInfo(slug, includeSecrets);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.ReadBlockDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | The block type name |  |
| **includeSecrets** | **bool?** | Whether to include sensitive values in the block document. | [optional] [default to false] |

### Return type

[**List&lt;BlockDocument&gt;**](BlockDocument.md)

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

<a id="readblockdocumentsforblocktype_0"></a>
# **ReadBlockDocuments**
> List&lt;BlockDocument&gt; ReadBlockDocuments (string slug, bool? includeSecrets = null)

Read Block Documents For Block Type

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
    public class ReadBlockDocumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);
            var slug = "slug_example";  // string | The block type name
            var includeSecrets = false;  // bool? | Whether to include sensitive values in the block document. (optional)  (default to false)

            try
            {
                // Read Block Documents For Block Type
                List<BlockDocument> result = apiInstance.ReadBlockDocuments(slug, includeSecrets);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.ReadBlockDocuments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadBlockDocumentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Block Documents For Block Type
    ApiResponse<List<BlockDocument>> response = apiInstance.ReadBlockDocumentsWithHttpInfo(slug, includeSecrets);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.ReadBlockDocumentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | The block type name |  |
| **includeSecrets** | **bool?** | Whether to include sensitive values in the block document. | [optional] [default to false] |

### Return type

[**List&lt;BlockDocument&gt;**](BlockDocument.md)

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

<a id="readblocktypebyid"></a>
# **Read**
> BlockType Read (Guid id)

Read Block Type By Id

Get a block type by ID.

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
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The block type ID

            try
            {
                // Read Block Type By Id
                BlockType result = apiInstance.Read(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.Read: " + e.Message);
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
    // Read Block Type By Id
    ApiResponse<BlockType> response = apiInstance.ReadWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.ReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The block type ID |  |

### Return type

[**BlockType**](BlockType.md)

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

<a id="readblocktypebyslug"></a>
# **ReadBySlug**
> BlockType ReadBySlug (string slug)

Read Block Type By Slug

Get a block type by name.

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
    public class ReadBySlugExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);
            var slug = "slug_example";  // string | The block type name

            try
            {
                // Read Block Type By Slug
                BlockType result = apiInstance.ReadBySlug(slug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.ReadBySlug: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReadBySlugWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Read Block Type By Slug
    ApiResponse<BlockType> response = apiInstance.ReadBySlugWithHttpInfo(slug);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.ReadBySlugWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | The block type name |  |

### Return type

[**BlockType**](BlockType.md)

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

<a id="readblocktypes"></a>
# **ReadMany**
> List&lt;BlockType&gt; ReadMany (ReadBlockTypesRequest readBlockTypesRequest = null)

Read Block Types

Gets all block types. Optionally limit return with limit and offset.

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
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);
            var readBlockTypesRequest = new ReadBlockTypesRequest(); // ReadBlockTypesRequest |  (optional) 

            try
            {
                // Read Block Types
                List<BlockType> result = apiInstance.ReadMany(readBlockTypesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.ReadMany: " + e.Message);
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
    // Read Block Types
    ApiResponse<List<BlockType>> response = apiInstance.ReadManyWithHttpInfo(readBlockTypesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.ReadManyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readBlockTypesRequest** | [**ReadBlockTypesRequest**](ReadBlockTypesRequest.md) |  | [optional]  |

### Return type

[**List&lt;BlockType&gt;**](BlockType.md)

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

<a id="updateblocktype"></a>
# **Update**
> void Update (Guid id, BlockTypeUpdate blockTypeUpdate)

Update Block Type

Update a block type.

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
            var apiInstance = new BlockTypesApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The block type ID
            var blockTypeUpdate = new BlockTypeUpdate(); // BlockTypeUpdate | 

            try
            {
                // Update Block Type
                apiInstance.Update(id, blockTypeUpdate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockTypesApi.Update: " + e.Message);
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
    // Update Block Type
    apiInstance.UpdateWithHttpInfo(id, blockTypeUpdate);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockTypesApi.UpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The block type ID |  |
| **blockTypeUpdate** | [**BlockTypeUpdate**](BlockTypeUpdate.md) |  |  |

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

