# Docspace.Model.CreateRoomFromTemplateDto
The parameters for creating a room from a template.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **int** | The template ID from which the room to be created. | 
**Title** | **string** | The room title. | 
**Logo** | [**LogoRequest**](LogoRequest.md) |  | [optional] 
**CopyLogo** | **bool** | Specifies whether to copy a logo or not. | [optional] 
**Tags** | **List&lt;string&gt;** | The collection of tags. | [optional] 
**Color** | **string** | The color of the room to be created. | [optional] 
**Cover** | **string** | The cover of the room to be created. | [optional] 
**Quota** | **long?** | Room quota | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

