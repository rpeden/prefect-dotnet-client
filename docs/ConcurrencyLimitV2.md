# PrefectClient.Model.ConcurrencyLimitV2
An ORM representation of a v2 concurrency limit.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Active** | **bool** | Whether the concurrency limit is active. | [optional] [default to true]
**Name** | **string** | The name of the concurrency limit. | 
**Limit** | **int** | The concurrency limit. | 
**ActiveSlots** | **int** | The number of active slots. | [optional] [default to 0]
**DeniedSlots** | **int** | The number of denied slots. | [optional] [default to 0]
**SlotDecayPerSecond** | **decimal** | The decay rate for active slots when used as a rate limit. | [optional] [default to 0M]
**AvgSlotOccupancySeconds** | **decimal** | The average amount of time a slot is occupied. | [optional] [default to 2M]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

