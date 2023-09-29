# PrefectClient.Model.State
Represents the state of a run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Type** | **StateType** |  | 
**Name** | **string** |  | [optional] 
**Timestamp** | **DateTime** |  | [optional] 
**Message** | **string** |  | [optional] 
**Data** | **Object** | Data associated with the state, e.g. a result. Content must be storable as JSON. | [optional] 
**StateDetails** | [**StateDetails**](StateDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

