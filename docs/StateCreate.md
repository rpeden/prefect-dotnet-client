# PrefectClient.Model.StateCreate
Data used by the Prefect REST API to create a new state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **StateType** |  | [optional] 
**Name** | **string** |  | [optional] 
**Message** | **string** |  | [optional] 
**Data** | **Object** | Data associated with the state, e.g. a result. Content must be storable as JSON. | [optional] 
**StateDetails** | [**StateDetails**](StateDetails.md) |  | [optional] 
**Timestamp** | **DateTime** |  | [optional] 
**Id** | **Guid** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

