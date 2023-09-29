# PrefectClient.Model.WorkPool
An ORM representation of a work pool

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Name** | **string** | The name of the work pool. | 
**Description** | **string** | A description of the work pool. | [optional] 
**Type** | **string** | The work pool type. | 
**BaseJobTemplate** | **Object** | The work pool&#39;s base job template. | [optional] 
**IsPaused** | **bool** | Pausing the work pool stops the delivery of all work. | [optional] [default to false]
**ConcurrencyLimit** | **int** | A concurrency limit for the work pool. | [optional] 
**DefaultQueueId** | **Guid** | The id of the pool&#39;s default queue. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

