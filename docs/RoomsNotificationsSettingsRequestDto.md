# DocSpace.API.SDK.Model.RoomsNotificationsSettingsRequestDto
Which single room the calling user silences, and which way.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RoomsId** | **Object** |  | [optional] 
**Mute** | **bool** | Which way the room goes: `true` adds it to the caller silenced list, `false` takes it off again. While a room  is silenced its activity is left out of the hourly and daily digests, the letters it would send at once are  not sent, and its new-item counters are hidden. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

