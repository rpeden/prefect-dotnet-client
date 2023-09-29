# PrefectClient.Model.TaskRunPolicy
Defines of how a task run should retry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxRetries** | **int** | The maximum number of retries. Field is not used. Please use &#x60;retries&#x60; instead. | [optional] [default to 0]
**RetryDelaySeconds** | **decimal** | The delay between retries. Field is not used. Please use &#x60;retry_delay&#x60; instead. | [optional] [default to 0M]
**Retries** | **int** | The number of retries. | [optional] 
**RetryDelay** | [**RetryDelay**](RetryDelay.md) |  | [optional] 
**RetryJitterFactor** | **decimal** | Determines the amount a retry should jitter | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

