# PrefectClient.Model.WorkPoolCreate
Data used by the Prefect REST API to create a work pool.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the work pool. | [optional] 
**Description** | **string** | A description of the work pool. | [optional] 
**Type** | **string** | The work pool type. | [optional] [default to "prefect-agent"]
**BaseJobTemplate** | **Object** | The work pool&#39;s base job template. | [optional] 
**IsPaused** | **bool** | Pausing the work pool stops the delivery of all work. | [optional] [default to false]
**ConcurrencyLimit** | **int** | A concurrency limit for the work pool. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

