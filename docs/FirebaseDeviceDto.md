# DocSpace.API.SDK.Model.FirebaseDeviceDto
One mobile device of the calling user registered for push notifications.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The id of the registration. | [optional] 
**UserId** | **Guid** | The account the device belongs to; always the caller. | [optional] 
**TenantId** | **int** | The portal the registration belongs to; always the current one. | [optional] 
**FirebaseDeviceToken** | **string** | The Firebase token the device was issued, as it was sent at registration. | [optional] 
**Application** | **string** | The application the registration is for; `doc` for the Documents application. | [optional] 
**IsSubscribed** | **bool?** | Whether the device is currently sent push notifications. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

