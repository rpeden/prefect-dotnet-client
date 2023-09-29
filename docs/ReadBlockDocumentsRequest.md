# PrefectClient.Model.ReadBlockDocumentsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockDocuments** | [**BlockDocumentFilter**](BlockDocumentFilter.md) |  | [optional] 
**BlockTypes** | [**BlockTypeFilter**](BlockTypeFilter.md) |  | [optional] 
**BlockSchemas** | [**BlockSchemaFilter**](BlockSchemaFilter.md) |  | [optional] 
**IncludeSecrets** | **bool** | Whether to include sensitive values in the block document. | [optional] [default to false]
**Offset** | **int** |  | [optional] [default to 0]
**Limit** | **int** | Defaults to PREFECT_API_DEFAULT_LIMIT if not provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

