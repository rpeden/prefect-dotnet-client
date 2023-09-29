# PrefectClient.Model.WorkQueueStatusDetail
Indicates if the work queue is healthy, based on late runs and last polling time.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Healthy** | **bool** | Whether or not the work queue is healthy. | 
**LateRunsCount** | **int** | The number of late flow runs in the work queue. | [optional] [default to 0]
**LastPolled** | **DateTime** | The last time an agent polled this queue for work. | [optional] 
**HealthCheckPolicy** | [**WorkQueueHealthPolicy**](WorkQueueHealthPolicy.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

