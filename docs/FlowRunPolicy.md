# PrefectClient.Model.FlowRunPolicy
Defines of how a flow run should retry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxRetries** | **int** | The maximum number of retries. Field is not used. Please use &#x60;retries&#x60; instead. | [optional] [default to 0]
**RetryDelaySeconds** | **decimal** | The delay between retries. Field is not used. Please use &#x60;retry_delay&#x60; instead. | [optional] [default to 0M]
**Retries** | **int** | The number of retries. | [optional] 
**RetryDelay** | **int** | The delay time between retries, in seconds. | [optional] 
**PauseKeys** | **List&lt;Object&gt;** | Tracks pauses this run has observed. | [optional] 
**Resuming** | **bool** | Indicates if this run is resuming from a pause. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

