# PrefectClient.Model.WorkQueue
An ORM representation of a work queue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Name** | **string** | The name of the work queue. | 
**Description** | **string** | An optional description for the work queue. | [optional] [default to ""]
**IsPaused** | **bool** | Whether or not the work queue is paused. | [optional] [default to false]
**ConcurrencyLimit** | **int** | An optional concurrency limit for the work queue. | [optional] 
**Priority** | **int** | The queue&#39;s priority. Lower values are higher priority (1 is the highest). | [optional] [default to 1]
**WorkPoolId** | **Guid** | The work pool with which the queue is associated. | [optional] 
**Filter** | [**QueueFilter**](QueueFilter.md) |  | [optional] 
**LastPolled** | **DateTime** | The last time an agent polled this queue for work. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

