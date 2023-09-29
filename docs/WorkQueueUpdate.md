# PrefectClient.Model.WorkQueueUpdate
Data used by the Prefect REST API to update a work queue.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the work queue. | [optional] 
**Description** | **string** | An optional description for the work queue. | [optional] [default to ""]
**IsPaused** | **bool** | Whether or not the work queue is paused. | [optional] [default to false]
**ConcurrencyLimit** | **int** | An optional concurrency limit for the work queue. | [optional] 
**Priority** | **int** | The queue&#39;s priority. Lower values are higher priority (1 is the highest). | [optional] [default to 1]
**LastPolled** | **DateTime** | The last time an agent polled this queue for work. | [optional] 
**Filter** | [**QueueFilter**](QueueFilter.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

