# PrefectClient.Model.ReadWorkQueueRunsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduledBefore** | **DateTime** | Only flow runs scheduled to start before this time will be returned. | [optional] 
**AgentId** | **Guid** | An optional unique identifier for the agent making this query. If provided, the Prefect REST API will track the last time this agent polled the work queue. | [optional] 
**Limit** | **int** | Defaults to PREFECT_API_DEFAULT_LIMIT if not provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

