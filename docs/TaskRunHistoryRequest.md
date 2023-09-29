# PrefectClient.Model.TaskRunHistoryRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HistoryStart** | **DateTime** | The history&#39;s start time. | 
**HistoryEnd** | **DateTime** | The history&#39;s end time. | 
**HistoryIntervalSeconds** | **decimal** | The size of each history interval, in seconds. Must be at least 1 second. | 
**Flows** | [**FlowFilter**](FlowFilter.md) |  | [optional] 
**FlowRuns** | [**FlowRunFilter**](FlowRunFilter.md) |  | [optional] 
**TaskRuns** | [**TaskRunFilter**](TaskRunFilter.md) |  | [optional] 
**Deployments** | [**DeploymentFilter**](DeploymentFilter.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

