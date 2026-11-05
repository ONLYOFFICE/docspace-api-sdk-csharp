# DocSpace.API.SDK.Model.RoomMissingFileKeysDto
One user who cannot open some encrypted files of a private room yet.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **Guid** | The user the keys are missing for. | 
**FileIds** | **List&lt;int&gt;** | The encrypted files that hold no key for this user, anywhere in the room. Never empty: a user who has every key  is not listed at all. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

