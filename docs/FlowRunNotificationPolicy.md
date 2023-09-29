# PrefectClient.Model.FlowRunNotificationPolicy
An ORM representation of a flow run notification.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**IsActive** | **bool** | Whether the policy is currently active | [optional] [default to true]
**StateNames** | **List&lt;string&gt;** | The flow run states that trigger notifications | 
**Tags** | **List&lt;string&gt;** | The flow run tags that trigger notifications (set [] to disable) | 
**BlockDocumentId** | **Guid** | The block document ID used for sending notifications | 
**MessageTemplate** | **string** | A templatable notification message. Use {braces} to add variables. Valid variables include: &#39;flow_id&#39;, &#39;flow_name&#39;, &#39;flow_run_id&#39;, &#39;flow_run_name&#39;, &#39;flow_run_notification_policy_id&#39;, &#39;flow_run_parameters&#39;, &#39;flow_run_state_message&#39;, &#39;flow_run_state_name&#39;, &#39;flow_run_state_timestamp&#39;, &#39;flow_run_state_type&#39;, &#39;flow_run_url&#39; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

