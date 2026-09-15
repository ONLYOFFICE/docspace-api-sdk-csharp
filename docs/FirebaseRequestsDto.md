# DocSpace.API.SDK.Model.FirebaseRequestsDto
Which mobile device receives the Documents push notifications, and whether it is subscribed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirebaseDeviceToken** | **string** | The registration token Firebase issued to the mobile client for this device, obtained on the device itself.  It is kept as an opaque string of up to 255 characters and is never verified here; it identifies the device  and is matched but never changed, and a token belonging to another member or another portal matches nothing. | [optional] 
**IsSubscribed** | **bool** | Whether the device is to receive the room activity messages - an invitation, a role change, an archived room,  a new document. On a first registration it is stored as given; on a registration that already exists it is  ignored, because registering does not update, and the subscription is changed with  `PUT api/2.0/settings/push/docsubscribe` instead. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

