# DocSpace.API.SDK.Model.NotificationChannelDto
One delivery channel of the installation, with the state it is in for this portal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The internal name of the channel as the notification service knows it - `email.sender` for letters,  `telegram.sender` for Telegram messages. It is a key to match on, not a label to print. | 
**IsEnabled** | **bool** | Whether the channel can deliver for this portal. Letters are enabled whenever the channel is listed at  all, while Telegram is enabled only while the portal has a bot name and token stored. It says nothing  about the caller, who also has to connect their own Telegram account through  `GET api/2.0/settings/telegram/link`. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

