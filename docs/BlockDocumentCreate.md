# PrefectClient.Model.BlockDocumentCreate
Data used by the Prefect REST API to create a block document.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The block document&#39;s name. Not required for anonymous block documents. | [optional] 
**Data** | **Object** | The block document&#39;s data | [optional] 
**BlockSchemaId** | **Guid** | A block schema ID | [optional] 
**BlockTypeId** | **Guid** | A block type ID | [optional] 
**IsAnonymous** | **bool** | Whether the block is anonymous (anonymous blocks are usually created by Prefect automatically) | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

