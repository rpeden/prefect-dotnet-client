# PrefectClient.Model.FlowRunCreate
Data used by the Prefect REST API to create a flow run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | [**StateCreate**](StateCreate.md) |  | [optional] 
**Name** | **string** | The name of the flow run. Defaults to a random slug if not specified. | [optional] 
**FlowId** | **Guid** | The id of the flow being run. | [optional] 
**FlowVersion** | **string** | The version of the flow executed in this flow run. | [optional] 
**Parameters** | **Object** | Parameters for the flow run. | [optional] 
**Context** | **Object** | Additional context for the flow run. | [optional] 
**ParentTaskRunId** | **Guid** | If the flow run is a subflow, the id of the &#39;dummy&#39; task in the parent flow used to track subflow state. | [optional] 
**InfrastructureDocumentId** | **Guid** | The block document defining infrastructure to use this flow run. | [optional] 
**EmpiricalPolicy** | [**FlowRunPolicy**](FlowRunPolicy.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags on the flow run | [optional] 
**IdempotencyKey** | **string** | An optional idempotency key for the flow run. Used to ensure the same flow run is not created multiple times. | [optional] 
**DeploymentId** | **Guid** | DEPRECATED: The id of the deployment associated with this flow run, if available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

