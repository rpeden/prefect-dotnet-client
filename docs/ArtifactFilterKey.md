# PrefectClient.Model.ArtifactFilterKey
Filter by `Artifact.key`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Any** | **List&lt;string&gt;** | A list of artifact keys to include | [optional] 
**Like** | **string** | A string to match artifact keys against. This can include SQL wildcard characters like &#x60;%&#x60; and &#x60;_&#x60;. | [optional] 
**Exists** | **bool** | If &#x60;true&#x60;, only include artifacts with a non-null key. If &#x60;false&#x60;, only include artifacts with a null key. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

