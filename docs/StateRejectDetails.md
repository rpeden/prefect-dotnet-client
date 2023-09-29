# PrefectClient.Model.StateRejectDetails
Details associated with a REJECT state transition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of state transition detail. Used to ensure pydantic does not coerce into a different type. | [optional] [default to TypeEnum.RejectDetails]
**Reason** | **string** | The reason why the state transition was rejected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

