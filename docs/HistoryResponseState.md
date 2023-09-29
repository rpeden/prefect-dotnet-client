# PrefectClient.Model.HistoryResponseState
Represents a single state's history over an interval.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StateType** | **StateType** |  | 
**StateName** | **string** | The state name. | 
**CountRuns** | **int** | The number of runs in the specified state during the interval. | 
**SumEstimatedRunTime** | **decimal** | The total estimated run time of all runs during the interval. | 
**SumEstimatedLateness** | **decimal** | The sum of differences between actual and expected start time during the interval. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

