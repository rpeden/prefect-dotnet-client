# PrefectClient.Model.FlowRun
An ORM representation of flow run data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Name** | **string** | The name of the flow run. Defaults to a random slug if not specified. | [optional] 
**FlowId** | **Guid** | The id of the flow being run. | 
**StateId** | **Guid** | The id of the flow run&#39;s current state. | [optional] 
**DeploymentId** | **Guid** | The id of the deployment associated with this flow run, if available. | [optional] 
**WorkQueueName** | **string** | The work queue that handled this flow run. | [optional] 
**FlowVersion** | **string** | The version of the flow executed in this flow run. | [optional] 
**Parameters** | **Object** | Parameters for the flow run. | [optional] 
**IdempotencyKey** | **string** | An optional idempotency key for the flow run. Used to ensure the same flow run is not created multiple times. | [optional] 
**Context** | **Object** | Additional context for the flow run. | [optional] 
**EmpiricalPolicy** | [**FlowRunPolicy**](FlowRunPolicy.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags on the flow run | [optional] 
**ParentTaskRunId** | **Guid** | If the flow run is a subflow, the id of the &#39;dummy&#39; task in the parent flow used to track subflow state. | [optional] 
**StateType** | **StateType** |  | [optional] 
**StateName** | **string** | The name of the current flow run state. | [optional] 
**RunCount** | **int** | The number of times the flow run was executed. | [optional] [default to 0]
**ExpectedStartTime** | **DateTime** | The flow run&#39;s expected start time. | [optional] 
**NextScheduledStartTime** | **DateTime** | The next time the flow run is scheduled to start. | [optional] 
**StartTime** | **DateTime** | The actual start time. | [optional] 
**EndTime** | **DateTime** | The actual end time. | [optional] 
**TotalRunTime** | **decimal** | Total run time. If the flow run was executed multiple times, the time of each run will be summed. | [optional] [default to 0M]
**EstimatedRunTime** | **decimal** | A real-time estimate of the total run time. | [optional] [default to 0M]
**EstimatedStartTimeDelta** | **decimal** | The difference between actual and expected start time. | [optional] [default to 0M]
**AutoScheduled** | **bool** | Whether or not the flow run was automatically scheduled. | [optional] [default to false]
**InfrastructureDocumentId** | **Guid** | The block document defining infrastructure to use this flow run. | [optional] 
**InfrastructurePid** | **string** | The id of the flow run as returned by an infrastructure block. | [optional] 
**CreatedBy** | [**CreatedBy**](CreatedBy.md) |  | [optional] 
**WorkQueueId** | **Guid** | The id of the run&#39;s work pool queue. | [optional] 
**State** | [**State**](State.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

