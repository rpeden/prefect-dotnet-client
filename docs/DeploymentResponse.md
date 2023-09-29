# PrefectClient.Model.DeploymentResponse
A PrefectBaseModel with an auto-generated UUID ID value and created /\\nupdated timestamps, intended for compatibility with our standard ORM models.\\n\\nThe ID, created, and updated fields are reset on copy() and not included in\\nequality comparisons.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Name** | **string** | The name of the deployment. | [optional] 
**VarVersion** | **string** | An optional version for the deployment. | [optional] 
**Description** | **string** | A description for the deployment. | [optional] 
**FlowId** | **Guid** | The flow id associated with the deployment. | [optional] 
**Schedule** | [**Schedule**](Schedule.md) |  | [optional] 
**IsScheduleActive** | **bool** | Whether or not the deployment schedule is active. | [optional] [default to true]
**InfraOverrides** | **Object** | Overrides to apply to the base infrastructure block at runtime. | [optional] 
**Parameters** | **Object** | Parameters for flow runs scheduled by the deployment. | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the deployment | [optional] 
**WorkQueueName** | **string** | The work queue for the deployment. If no work queue is set, work will not be scheduled. | [optional] 
**ParameterOpenapiSchema** | **Object** | The parameter schema of the flow, including defaults. | [optional] 
**Path** | **string** | The path to the working directory for the workflow, relative to remote storage or an absolute path. | [optional] 
**PullSteps** | **List&lt;Object&gt;** | Pull steps for cloning and running this deployment. | [optional] 
**Entrypoint** | **string** | The path to the entrypoint for the workflow, relative to the &#x60;path&#x60;. | [optional] 
**ManifestPath** | **string** | The path to the flow&#39;s manifest file, relative to the chosen storage. | [optional] 
**StorageDocumentId** | **Guid** | The block document defining storage used for this flow. | [optional] 
**InfrastructureDocumentId** | **Guid** | The block document defining infrastructure to use for flow runs. | [optional] 
**CreatedBy** | [**CreatedBy**](CreatedBy.md) |  | [optional] 
**UpdatedBy** | [**UpdatedBy**](UpdatedBy.md) |  | [optional] 
**WorkPoolName** | **string** | The name of the deployment work pool. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

