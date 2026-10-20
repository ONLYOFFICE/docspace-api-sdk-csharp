# DocSpace.API.SDK.Model.RoomsMetadataSearchRequestDto
The typed form of the metadata search of the rooms: the same filter the rooms listing takes in the metadataTemplateId  and metadataFilters query parameters, with the conditions as objects instead of a JSON string.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetadataTemplateId** | **int?** | The ID of the metadata template the rooms must be assigned to. On its own it narrows the listing to the rooms  carrying the template; together with the conditions it also pins the template the filtered fields belong to. | [optional] 
**MetadataFilters** | [**List&lt;MetadataFilterConditionRequest&gt;**](MetadataFilterConditionRequest.md) | The metadata filter conditions, combined with AND. A custom field is addressed by its name instead of the field ID. | [optional] 
**IncludeHiddenMetadata** | **bool?** | Whether the text search, and the metadataMatches it reports, also look at the values of the hidden metadata  templates (created with visible false for the metadata a service keeps for itself, which the web client never  shows). False, the default, leaves them out, so an entry is not found by such a value; true takes them in.  metadataTemplateId and metadataFilters are not concerned: a hidden template or field named there is searched  either way. | [optional] 
**FilterValue** | **string** | The text to search for in the room titles and in the string metadata values of the rooms, the custom fields and  the template fields alike; a room found by its metadata says where in metadataMatches. | [optional] 
**SearchArea** | **SearchArea** | The section to search in: the active rooms (the default), the archive or the templates. | [optional] 
**Type** | [**List&lt;RoomType&gt;**](RoomType.md) | The room types to search among. | [optional] 
**Count** | **int** | The number of rooms to return, from 1 to 100. | [optional] 
**StartIndex** | **int** | The zero-based index of the first room to return. | [optional] 
**SortBy** | **string** | The field to sort by, a name of the SortedByType values. | [optional] 
**SortOrder** | **SortOrder** | The sort order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

