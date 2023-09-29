# PrefectClient.Model.DeploymentUpdate
Data used by the Prefect REST API to update a deployment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | An optional version for the deployment. | [optional] 
**Schedule** | [**Schedule**](Schedule.md) |  | [optional] 
**Description** | **string** | A description for the deployment. | [optional] 
**IsScheduleActive** | **bool** | Whether or not the deployment schedule is active. | [optional] [default to true]
**Parameters** | **Object** | Parameters for flow runs scheduled by the deployment. | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags for the deployment | [optional] 
**WorkQueueName** | **string** | The work queue for the deployment. If no work queue is set, work will not be scheduled. | [optional] 
**WorkPoolName** | **string** | The name of the deployment work pool. | [optional] 
**Path** | **string** | The path to the working directory for the workflow, relative to remote storage or an absolute path. | [optional] 
**InfraOverrides** | **Object** | Overrides to apply to the base infrastructure block at runtime. | [optional] 
**Entrypoint** | **string** | The path to the entrypoint for the workflow, relative to the &#x60;path&#x60;. | [optional] 
**ManifestPath** | **string** | The path to the flow&#39;s manifest file, relative to the chosen storage. | [optional] 
**StorageDocumentId** | **Guid** | The block document defining storage used for this flow. | [optional] 
**InfrastructureDocumentId** | **Guid** | The block document defining infrastructure to use for flow runs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

