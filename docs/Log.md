# PrefectClient.Model.Log
An ORM representation of log data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Name** | **string** | The logger name. | 
**Level** | **int** | The log level. | 
**Message** | **string** | The log message. | 
**Timestamp** | **DateTime** | The log timestamp. | 
**FlowRunId** | **Guid** | The flow run ID associated with the log. | 
**TaskRunId** | **Guid** | The task run ID associated with the log. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

