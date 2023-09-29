# PrefectClient.Model.TaskRun
An ORM representation of task run data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Name** | **string** |  | [optional] 
**FlowRunId** | **Guid** | The flow run id of the task run. | 
**TaskKey** | **string** | A unique identifier for the task being run. | 
**DynamicKey** | **string** | A dynamic key used to differentiate between multiple runs of the same task within the same flow run. | 
**CacheKey** | **string** | An optional cache key. If a COMPLETED state associated with this cache key is found, the cached COMPLETED state will be used instead of executing the task run. | [optional] 
**CacheExpiration** | **DateTime** | Specifies when the cached state should expire. | [optional] 
**TaskVersion** | **string** | The version of the task being run. | [optional] 
**EmpiricalPolicy** | [**TaskRunPolicy**](TaskRunPolicy.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the task run. | [optional] 
**StateId** | **Guid** | The id of the current task run state. | [optional] 
**TaskInputs** | **Dictionary&lt;string, List&lt;TaskInputsInner&gt;&gt;** | Tracks the source of inputs to a task run. Used for internal bookkeeping. | [optional] 
**StateType** | **StateType** |  | [optional] 
**StateName** | **string** | The name of the current task run state. | [optional] 
**RunCount** | **int** | The number of times the task run has been executed. | [optional] [default to 0]
**FlowRunRunCount** | **int** | If the parent flow has retried, this indicates the flow retry this run is associated with. | [optional] [default to 0]
**ExpectedStartTime** | **DateTime** | The task run&#39;s expected start time. | [optional] 
**NextScheduledStartTime** | **DateTime** | The next time the task run is scheduled to start. | [optional] 
**StartTime** | **DateTime** | The actual start time. | [optional] 
**EndTime** | **DateTime** | The actual end time. | [optional] 
**TotalRunTime** | **decimal** | Total run time. If the task run was executed multiple times, the time of each run will be summed. | [optional] [default to 0M]
**EstimatedRunTime** | **decimal** | A real-time estimate of total run time. | [optional] [default to 0M]
**EstimatedStartTimeDelta** | **decimal** | The difference between actual and expected start time. | [optional] [default to 0M]
**State** | [**State**](State.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

