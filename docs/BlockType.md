# PrefectClient.Model.BlockType
An ORM representation of a block type

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Name** | **string** | A block type&#39;s name | 
**Slug** | **string** | A block type&#39;s slug | 
**LogoUrl** | **string** | Web URL for the block type&#39;s logo | [optional] 
**DocumentationUrl** | **string** | Web URL for the block type&#39;s documentation | [optional] 
**Description** | **string** | A short blurb about the corresponding block&#39;s intended use | [optional] 
**CodeExample** | **string** | A code snippet demonstrating use of the corresponding block | [optional] 
**IsProtected** | **bool** | Protected block types cannot be modified via API. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

