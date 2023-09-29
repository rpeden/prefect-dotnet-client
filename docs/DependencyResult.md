# PrefectClient.Model.DependencyResult
Represents the result of a dependency in a workflow, capturing various metadata and states.  Contains details such as unique identifier, associated upstream dependencies, runtime states, time metrics, and whether the result is trackable or not.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | 
**Name** | **string** |  | 
**UpstreamDependencies** | [**List&lt;TaskRunResult&gt;**](TaskRunResult.md) |  | 
**State** | [**State**](State.md) |  | 
**ExpectedStartTime** | **DateTime** |  | [optional] 
**StartTime** | **DateTime** |  | [optional] 
**EndTime** | **DateTime** |  | [optional] 
**TotalRunTime** | **decimal** |  | [optional] 
**EstimatedRunTime** | **decimal** |  | [optional] 
**UntrackableResult** | **bool** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

