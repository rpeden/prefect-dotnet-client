# PrefectClient.Model.ScheduleDeploymentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartTime** | **DateTime** | The earliest date to schedule | [optional] 
**EndTime** | **DateTime** | The latest date to schedule | [optional] 
**MinTime** | **decimal** | Runs will be scheduled until at least this long after the &#x60;start_time&#x60; | [optional] 
**MinRuns** | **int** | The minimum number of runs to schedule | [optional] 
**MaxRuns** | **int** | The maximum number of runs to schedule | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

