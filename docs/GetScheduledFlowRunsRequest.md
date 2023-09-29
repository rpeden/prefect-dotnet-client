# PrefectClient.Model.GetScheduledFlowRunsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorkQueueNames** | **List&lt;string&gt;** | The names of work pool queues | [optional] 
**ScheduledBefore** | **DateTime** | The maximum time to look for scheduled flow runs | [optional] 
**ScheduledAfter** | **DateTime** | The minimum time to look for scheduled flow runs | [optional] 
**Limit** | **int** | Defaults to PREFECT_API_DEFAULT_LIMIT if not provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

