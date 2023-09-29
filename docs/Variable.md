# PrefectClient.Model.Variable
A PrefectBaseModel with an auto-generated UUID ID value and created /\\nupdated timestamps, intended for compatibility with our standard ORM models.\\n\\nThe ID, created, and updated fields are reset on copy() and not included in\\nequality comparisons.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Name** | **string** | The name of the variable | 
**Value** | **string** | The value of the variable | 
**Tags** | **List&lt;string&gt;** | A list of variable tags | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

