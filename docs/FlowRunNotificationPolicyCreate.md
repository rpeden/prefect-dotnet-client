# PrefectClient.Model.FlowRunNotificationPolicyCreate
Data used by the Prefect REST API to create a flow run notification policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsActive** | **bool** | Whether the policy is currently active | [optional] [default to true]
**StateNames** | **List&lt;string&gt;** | The flow run states that trigger notifications | [optional] 
**Tags** | **List&lt;string&gt;** | The flow run tags that trigger notifications (set [] to disable) | [optional] 
**BlockDocumentId** | **Guid** | The block document ID used for sending notifications | [optional] 
**MessageTemplate** | **string** | A templatable notification message. Use {braces} to add variables. Valid variables include: &#39;flow_id&#39;, &#39;flow_name&#39;, &#39;flow_run_id&#39;, &#39;flow_run_name&#39;, &#39;flow_run_notification_policy_id&#39;, &#39;flow_run_parameters&#39;, &#39;flow_run_state_message&#39;, &#39;flow_run_state_name&#39;, &#39;flow_run_state_timestamp&#39;, &#39;flow_run_state_type&#39;, &#39;flow_run_url&#39; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

