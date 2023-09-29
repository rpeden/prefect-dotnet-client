# PrefectClient.Model.WorkPoolUpdate
Data used by the Prefect REST API to update a work pool.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A description of the work pool. | [optional] 
**IsPaused** | **bool** | Pausing the work pool stops the delivery of all work. | [optional] [default to false]
**BaseJobTemplate** | **Object** | The work pool&#39;s base job template. | [optional] 
**ConcurrencyLimit** | **int** | A concurrency limit for the work pool. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

