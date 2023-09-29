# PrefectClient.Model.SimpleFlowRun
Captures essential details of a flow run, including its identifier, state type, timestamp, duration, and any lateness.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The flow run id. | 
**StateType** | **StateType** |  | 
**Timestamp** | **DateTime** | The start time of the run, or the expected start time if it hasn&#39;t run yet. | 
**Duration** | **decimal** | The total run time of the run. | 
**Lateness** | **decimal** | The delay between the expected and actual start time. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

