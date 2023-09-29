# PrefectClient.Model.ConcurrencyLimit
An ORM representation of a concurrency limit.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Tag** | **string** | A tag the concurrency limit is applied to. | 
**VarConcurrencyLimit** | **int** | The concurrency limit. | 
**ActiveSlots** | **List&lt;Guid&gt;** | A list of active run ids using a concurrency slot | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

