# DocSpace.API.SDK.Model.RoomTemplateDto
The room template parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RoomId** | **int** | The room template ID. | 
**Title** | **string** | The room template title. | [optional] 
**Logo** | [**LogoRequest**](LogoRequest.md) |  | [optional] 
**CopyLogo** | **bool** | Specifies whether to copy room logo or not. | [optional] 
**Share** | **List&lt;string&gt;** | The collection of email addresses of users with whom to share a room. | [optional] 
**Groups** | **List&lt;Guid&gt;** | The collection of groups with whom to share a room. | [optional] 
**Public** | **bool** | Specifies whether the room template is public or not. | [optional] 
**Tags** | **List&lt;string&gt;** | The collection of tags. | [optional] 
**Color** | **string** | The color of the room template. | [optional] 
**Cover** | **string** | The cover of the room template. | [optional] 
**Quota** | **long?** | Room quota | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

