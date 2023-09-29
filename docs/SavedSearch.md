# PrefectClient.Model.SavedSearch
An ORM representation of saved search data. Represents a set of filter criteria.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Created** | **DateTime** |  | [optional] 
**Updated** | **DateTime** |  | [optional] 
**Name** | **string** | The name of the saved search. | 
**Filters** | [**List&lt;SavedSearchFilter&gt;**](SavedSearchFilter.md) | The filter set for the saved search. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

