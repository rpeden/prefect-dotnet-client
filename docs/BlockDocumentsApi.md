# PrefectClient.Api.BlockDocumentsApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Create**](BlockDocumentsApi.md#createblockdocument) | **POST** /block_documents/ | Create Block Document |
| [**Delete**](BlockDocumentsApi.md#deleteblockdocument) | **DELETE** /block_documents/{id} | Delete Block Document |
| [**Read**](BlockDocumentsApi.md#readblockdocumentbyid) | **GET** /block_documents/{id} | Read Block Document By Id |
| [**ReadBlockDocumentByName**](BlockDocumentsApi.md#readblockdocumentbynameforblocktype) | **GET** /block_types/slug/{slug}/block_documents/name/{block_document_name} | Read Block Document By Name For Block Type |
| [**ReadMany**](BlockDocumentsApi.md#readblockdocuments) | **POST** /block_documents/filter | Read Block Documents |
| [**ReadBlockDocuments**](BlockDocumentsApi.md#readblockdocumentsforblocktype) | **GET** /block_types/slug/{slug}/block_documents | Read Block Documents For Block Type |
| [**UpdateData**](BlockDocumentsApi.md#updateblockdocumentdata) | **PATCH** /block_documents/{id} | Update Block Document Data |

<a id="createblockdocument"></a>
# **Create**
> BlockDocument Create (BlockDocumentCreate blockDocumentCreate)

Create Block Document

Create a new block document.

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
            var apiInstance = new BlockDocumentsApi(httpClient, config, httpClientHandler);
            var blockDocumentCreate = new BlockDocumentCreate(); // BlockDocumentCreate | 

            try
            {
                // Create Block Document
                BlockDocument result = apiInstance.Create(blockDocumentCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockDocumentsApi.Create: " + e.Message);
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
    // Create Block Document
    ApiResponse<BlockDocument> response = apiInstance.CreateWithHttpInfo(blockDocumentCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockDocumentsApi.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **blockDocumentCreate** | [**BlockDocumentCreate**](BlockDocumentCreate.md) |  |  |

### Return type

[**BlockDocument**](BlockDocument.md)

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

<a id="deleteblockdocument"></a>
# **Delete**
> void Delete (Guid id)

Delete Block Document

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
            var apiInstance = new BlockDocumentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The block document id

            try
            {
                // Delete Block Document
                apiInstance.Delete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockDocumentsApi.Delete: " + e.Message);
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
    // Delete Block Document
    apiInstance.DeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockDocumentsApi.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The block document id |  |

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

<a id="readblockdocumentbyid"></a>
# **Read**
> BlockDocument Read (Guid id, bool? includeSecrets = null)

Read Block Document By Id

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
            var apiInstance = new BlockDocumentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The block document id
            var includeSecrets = false;  // bool? | Whether to include sensitive values in the block document. (optional)  (default to false)

            try
            {
                // Read Block Document By Id
                BlockDocument result = apiInstance.Read(id, includeSecrets);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockDocumentsApi.Read: " + e.Message);
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
    // Read Block Document By Id
    ApiResponse<BlockDocument> response = apiInstance.ReadWithHttpInfo(id, includeSecrets);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockDocumentsApi.ReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The block document id |  |
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
            var apiInstance = new BlockDocumentsApi(httpClient, config, httpClientHandler);
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
                Debug.Print("Exception when calling BlockDocumentsApi.ReadBlockDocumentByName: " + e.Message);
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
    Debug.Print("Exception when calling BlockDocumentsApi.ReadBlockDocumentByNameWithHttpInfo: " + e.Message);
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

<a id="readblockdocuments"></a>
# **ReadMany**
> List&lt;BlockDocument&gt; ReadMany (ReadBlockDocumentsRequest readBlockDocumentsRequest = null)

Read Block Documents

Query for block documents.

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
            var apiInstance = new BlockDocumentsApi(httpClient, config, httpClientHandler);
            var readBlockDocumentsRequest = new ReadBlockDocumentsRequest(); // ReadBlockDocumentsRequest |  (optional) 

            try
            {
                // Read Block Documents
                List<BlockDocument> result = apiInstance.ReadMany(readBlockDocumentsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockDocumentsApi.ReadMany: " + e.Message);
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
    // Read Block Documents
    ApiResponse<List<BlockDocument>> response = apiInstance.ReadManyWithHttpInfo(readBlockDocumentsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockDocumentsApi.ReadManyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **readBlockDocumentsRequest** | [**ReadBlockDocumentsRequest**](ReadBlockDocumentsRequest.md) |  | [optional]  |

### Return type

[**List&lt;BlockDocument&gt;**](BlockDocument.md)

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
            var apiInstance = new BlockDocumentsApi(httpClient, config, httpClientHandler);
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
                Debug.Print("Exception when calling BlockDocumentsApi.ReadBlockDocuments: " + e.Message);
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
    Debug.Print("Exception when calling BlockDocumentsApi.ReadBlockDocumentsWithHttpInfo: " + e.Message);
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

<a id="updateblockdocumentdata"></a>
# **UpdateData**
> void UpdateData (Guid id, BlockDocumentUpdate blockDocumentUpdate)

Update Block Document Data

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
    public class UpdateDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new BlockDocumentsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // Guid | The block document id
            var blockDocumentUpdate = new BlockDocumentUpdate(); // BlockDocumentUpdate | 

            try
            {
                // Update Block Document Data
                apiInstance.UpdateData(id, blockDocumentUpdate);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlockDocumentsApi.UpdateData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Block Document Data
    apiInstance.UpdateDataWithHttpInfo(id, blockDocumentUpdate);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlockDocumentsApi.UpdateDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The block document id |  |
| **blockDocumentUpdate** | [**BlockDocumentUpdate**](BlockDocumentUpdate.md) |  |  |

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

