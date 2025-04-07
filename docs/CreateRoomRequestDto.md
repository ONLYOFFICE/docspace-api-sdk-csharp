# Docspace.Model.CreateRoomRequestDto
Request parameters for creating a room

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | Room name | [optional] 
**Quota** | **long?** | Room quota | [optional] 
**Indexing** | **bool?** | Indexing | [optional] 
**DenyDownload** | **bool?** | Room quota | [optional] 
**Lifetime** | [**RoomDataLifetimeDto**](RoomDataLifetimeDto.md) |  | [optional] 
**Watermark** | [**WatermarkRequestDto**](WatermarkRequestDto.md) |  | [optional] 
**Logo** | [**LogoRequest**](LogoRequest.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of tags | [optional] 
**Color** | **string** | Color | [optional] 
**Cover** | **string** | Cover | [optional] 
**RoomType** | **RoomType** |  | [optional] 
**Private** | **bool** | Private | [optional] 
**Share** | [**List&lt;FileShareParams&gt;**](FileShareParams.md) | Collection of sharing parameters | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

