# DocSpace.API.SDK.Model.CreateRoomRequestDto
The request parameters for creating a room.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The room name. | 
**Quota** | **long?** | The room quota. | [optional] 
**Indexing** | **bool?** | Specifies whether to create a room with indexing. | [optional] 
**DenyDownload** | **bool?** | Specifies whether to deny downloads from the room. | [optional] 
**Lifetime** | [**RoomDataLifetimeDto**](RoomDataLifetimeDto.md) | The room data lifetime information. | [optional] 
**Watermark** | [**WatermarkRequestDto**](WatermarkRequestDto.md) | The request parameters for adding watermarks. | [optional] 
**Logo** | [**LogoRequest**](LogoRequest.md) | The logo request parameters. | [optional] 
**Tags** | **List&lt;string&gt;** | The list of tags. | [optional] 
**Color** | **string** | The room color, as a six-digit hexadecimal value without a leading '#'. | [optional] 
**Cover** | **string** | The room cover. | [optional] 
**RoomType** | **RoomType** | The room type. | 
**Private** | **bool** | Specifies whether the room to be created is private or not. | [optional] 
**Share** | [**List&lt;FileShareParams&gt;**](FileShareParams.md) | The collection of sharing parameters. | [optional] 
**ChatSettings** | [**ChatSettings**](ChatSettings.md) | The chat settings. | [optional] 
**SendFormToExternalDB** | **bool?** | Specifies whether to send form data to external database. | [optional] 
**SaveFormAsXLSX** | **bool?** | Specifies whether to save form data as XLSX file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

