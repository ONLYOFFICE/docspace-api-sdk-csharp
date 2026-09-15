# DocSpace.API.SDK.Model.NotificationSettingsRequestsDto
Which kind of notification the calling user switches, and which way.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **NotificationType** | The kind of notification being switched. A value outside the defined set is echoed back while nothing is  stored, so confirm the result with `GET api/2.0/settings/notification/{type}` rather than trusting the  answer. | 
**IsEnabled** | **bool** | Whether that kind reaches the calling account. It applies to the caller own account alone and to every room  at once; a single room is silenced with `POST api/2.0/settings/notification/rooms` instead. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

