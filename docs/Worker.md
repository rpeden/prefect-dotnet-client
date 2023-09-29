# PrefectClient.Model.Worker
An ORM representation of a worker

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Name** | **string** | The name of the worker. | 
**WorkPoolId** | **Guid** | The work pool with which the queue is associated. | 
**LastHeartbeatTime** | **DateTime** | The last time the worker process sent a heartbeat. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

