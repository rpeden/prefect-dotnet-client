# PrefectClient.Model.WorkQueueHealthPolicy
Sets limits for late runs and polling frequency to gauge queue health.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaximumLateRuns** | **int** | The maximum number of late runs in the work queue before it is deemed unhealthy. Defaults to &#x60;0&#x60;. | [optional] [default to 0]
**MaximumSecondsSinceLastPolled** | **int** | The maximum number of time in seconds elapsed since work queue has been polled before it is deemed unhealthy. Defaults to &#x60;60&#x60;. | [optional] [default to 60]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

