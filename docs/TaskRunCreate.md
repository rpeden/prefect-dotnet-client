# PrefectClient.Model.TaskRunCreate
Data used by the Prefect REST API to create a task run

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | [**StateCreate**](StateCreate.md) |  | [optional] 
**Name** | **string** |  | [optional] 
**FlowRunId** | **Guid** | The flow run id of the task run. | [optional] 
**TaskKey** | **string** | A unique identifier for the task being run. | [optional] 
**DynamicKey** | **string** | A dynamic key used to differentiate between multiple runs of the same task within the same flow run. | [optional] 
**CacheKey** | **string** | An optional cache key. If a COMPLETED state associated with this cache key is found, the cached COMPLETED state will be used instead of executing the task run. | [optional] 
**CacheExpiration** | **DateTime** | Specifies when the cached state should expire. | [optional] 
**TaskVersion** | **string** | The version of the task being run. | [optional] 
**EmpiricalPolicy** | [**TaskRunPolicy**](TaskRunPolicy.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the task run. | [optional] 
**TaskInputs** | **Dictionary&lt;string, List&lt;TaskInputsInner&gt;&gt;** | Tracks the source of inputs to a task run. Used for internal bookkeeping. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

