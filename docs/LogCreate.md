# PrefectClient.Model.LogCreate
Data used by the Prefect REST API to create a log.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The logger name. | [optional] 
**Level** | **int** | The log level. | [optional] 
**Message** | **string** | The log message. | [optional] 
**Timestamp** | **DateTime** | The log timestamp. | [optional] 
**FlowRunId** | **Guid** | The flow run ID associated with the log. | [optional] 
**TaskRunId** | **Guid** | The task run ID associated with the log. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

