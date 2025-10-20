# DocSpace.API.SDK.Model.CreateRoomRequestDto
The request parameters for creating a room.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The room name. | 
**Quota** | **long?** | The room quota. | [optional] 
**Indexing** | **bool?** | Specifies whether to create a room with indexing. | [optional] 
**DenyDownload** | **bool?** | Specifies whether to deny downloads from the room. | [optional] 
**Lifetime** | [**RoomDataLifetimeDto**](RoomDataLifetimeDto.md) |  | [optional] 
**Watermark** | [**WatermarkRequestDto**](WatermarkRequestDto.md) |  | [optional] 
**Logo** | [**LogoRequest**](LogoRequest.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | The list of tags. | [optional] 
**Color** | **string** | The room color. | [optional] 
**Cover** | **string** | The room cover. | [optional] 
**RoomType** | **RoomType** |  | 
**Private** | **bool** | Specifies whether the room to be created is private or not. | [optional] 
**Share** | [**List&lt;FileShareParams&gt;**](FileShareParams.md) | The collection of sharing parameters. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

