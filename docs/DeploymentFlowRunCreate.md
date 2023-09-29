# PrefectClient.Model.DeploymentFlowRunCreate
Data used by the Prefect REST API to create a flow run from a deployment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | [**StateCreate**](StateCreate.md) |  | [optional] 
**Name** | **string** | The name of the flow run. Defaults to a random slug if not specified. | [optional] 
**Parameters** | **Object** | Parameters for the flow run. | [optional] 
**Context** | **Object** | Additional context for the flow run. | [optional] 
**InfrastructureDocumentId** | **Guid** | The block document defining infrastructure to use this flow run. | [optional] 
**EmpiricalPolicy** | [**FlowRunPolicy**](FlowRunPolicy.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags on the flow run | [optional] 
**IdempotencyKey** | **string** | An optional idempotency key for the flow run. Used to ensure the same flow run is not created multiple times. | [optional] 
**ParentTaskRunId** | **Guid** | If the flow run is a subflow, the id of the &#39;dummy&#39; task in the parent flow used to track subflow state. | [optional] 
**WorkQueueName** | **string** | The work queue that handled this flow run. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

