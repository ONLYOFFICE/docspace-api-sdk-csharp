# DocSpace.API.SDK.Model.UpdateWebhooksConfigRequestsDto
The request parameters for updating the webhook configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The human-readable name of the webhook configuration. | 
**Uri** | **string** | The destination URL where the webhook events will be sent. | 
**SecretKey** | **string** | The webhook secret key used to sign the webhook payloads for the security verification. | [optional] 
**Enabled** | **bool** | Specifies whether the webhook configuration is active or not. | [optional] 
**Ssl** | **bool** | Specifies whether the SSL certificate verification is required or not. | [optional] 
**Triggers** | **WebhookTrigger** |  | [optional] 
**TargetId** | **string** | Target ID | [optional] 
**Id** | **int** | The webhook configuration ID. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

