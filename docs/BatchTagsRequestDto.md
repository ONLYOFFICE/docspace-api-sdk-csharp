# DocSpace.API.SDK.Model.BatchTagsRequestDto
The tag names a request attaches to a room or detaches from it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Names** | **List&lt;string&gt;** | The tags, by name: a tag has no identifier of its own, and the name is what links a room to it.  `GET api/2.0/files/tags` lists the names already in the portal catalogue. An empty list is accepted and does  nothing, while a blank or overlong entry makes the whole request invalid. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

