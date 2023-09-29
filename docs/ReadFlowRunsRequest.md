# PrefectClient.Model.ReadFlowRunsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sort** | **FlowRunSort** |  | [optional] 
**Offset** | **int** |  | [optional] [default to 0]
**Flows** | [**FlowFilter**](FlowFilter.md) |  | [optional] 
**FlowRuns** | [**FlowRunFilter**](FlowRunFilter.md) |  | [optional] 
**TaskRuns** | [**TaskRunFilter**](TaskRunFilter.md) |  | [optional] 
**Deployments** | [**DeploymentFilter**](DeploymentFilter.md) |  | [optional] 
**WorkPools** | [**WorkPoolFilter**](WorkPoolFilter.md) |  | [optional] 
**WorkPoolQueues** | [**WorkQueueFilter**](WorkQueueFilter.md) |  | [optional] 
**Limit** | **int** | Defaults to PREFECT_API_DEFAULT_LIMIT if not provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

