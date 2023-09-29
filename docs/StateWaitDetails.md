# PrefectClient.Model.StateWaitDetails
Details associated with a WAIT state transition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of state transition detail. Used to ensure pydantic does not coerce into a different type. | [optional] [default to TypeEnum.WaitDetails]
**DelaySeconds** | **int** | The length of time in seconds the client should wait before transitioning states. | 
**Reason** | **string** | The reason why the state transition should wait. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

