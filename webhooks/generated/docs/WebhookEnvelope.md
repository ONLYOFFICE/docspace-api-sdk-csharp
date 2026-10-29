# DocSpace.Webhooks.SDK.Model.WebhookEnvelope
The body of every delivery. `payload` is narrowed by `event.trigger` per x-docspace-trigger-payloads.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Event** | [**WebhookEventInfo**](WebhookEventInfo.md) |  | [optional] 
**Payload** | **Object** | The user, group, file, folder, room, agent or form submission the event is about. Its schema follows from &#x60;event.trigger&#x60;: a user.* event carries a user, a file.* event a file, and so on. | [optional] 
**Webhook** | [**WebhookConfigInfo**](WebhookConfigInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

