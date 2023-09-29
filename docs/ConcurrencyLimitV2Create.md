# PrefectClient.Model.ConcurrencyLimitV2Create
Data used by the Prefect REST API to create a v2 concurrency limit.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Whether the concurrency limit is active. | [optional] [default to true]
**Name** | **string** | The name of the concurrency limit. | [optional] 
**Limit** | **int** | The concurrency limit. | [optional] 
**ActiveSlots** | **int** | The number of active slots. | [optional] [default to 0]
**DeniedSlots** | **int** | The number of denied slots. | [optional] [default to 0]
**SlotDecayPerSecond** | **decimal** | The decay rate for active slots when used as a rate limit. | [optional] [default to 0M]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

