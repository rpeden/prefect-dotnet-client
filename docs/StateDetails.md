# PrefectClient.Model.StateDetails
Describes various attributes that detail the state of a flow or task run, including cache settings, pause configurations, and associated run IDs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FlowRunId** | **Guid** |  | [optional] 
**TaskRunId** | **Guid** |  | [optional] 
**ChildFlowRunId** | **Guid** |  | [optional] 
**ScheduledTime** | **DateTime** |  | [optional] 
**CacheKey** | **string** |  | [optional] 
**CacheExpiration** | **DateTime** |  | [optional] 
**UntrackableResult** | **bool** |  | [optional] [default to false]
**PauseTimeout** | **DateTime** |  | [optional] 
**PauseReschedule** | **bool** |  | [optional] [default to false]
**PauseKey** | **string** |  | [optional] 
**RefreshCache** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

