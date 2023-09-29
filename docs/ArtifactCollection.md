# PrefectClient.Model.ArtifactCollection
A PrefectBaseModel with an auto-generated UUID ID value and created /\\nupdated timestamps, intended for compatibility with our standard ORM models.\\n\\nThe ID, created, and updated fields are reset on copy() and not included in\\nequality comparisons.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Key** | **string** | An optional unique reference key for this artifact. | 
**LatestId** | **Guid** | The latest artifact ID associated with the key. | 
**Type** | **string** | An identifier that describes the shape of the data field. e.g. result, table, markdown | [optional] 
**Description** | **string** | A markdown-enabled description of the artifact. | [optional] 
**Data** | **Object** |  | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | User-defined artifact metadata. Content must be string key and value pairs. | [optional] 
**FlowRunId** | **Guid** | The flow run associated with the artifact. | [optional] 
**TaskRunId** | **Guid** | The task run associated with the artifact. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

