# PrefectClient.Model.FlowRunUpdate
Data used by the Prefect REST API to update a flow run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the flow run. Defaults to a random slug if not specified. | [optional] 
**FlowVersion** | **string** | The version of the flow executed in this flow run. | [optional] 
**Parameters** | **Object** | Parameters for the flow run. | [optional] 
**EmpiricalPolicy** | [**FlowRunPolicy**](FlowRunPolicy.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags on the flow run | [optional] 
**InfrastructurePid** | **string** | The id of the flow run as returned by an infrastructure block. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

