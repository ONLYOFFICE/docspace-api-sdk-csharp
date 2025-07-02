# DocSpace.Sdk.Model.UpdateRoomRequest
The request parameters for updating a room.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The room title. | [optional] 
**Quota** | **long?** | The room quota. | [optional] 
**Indexing** | **bool?** | Specifies whether to create a third-party room with indexing. | [optional] 
**DenyDownload** | **bool?** | Specifies whether to deny downloads from the third-party room. | [optional] 
**Lifetime** | [**RoomDataLifetimeDto**](RoomDataLifetimeDto.md) |  | [optional] 
**Watermark** | [**WatermarkRequestDto**](WatermarkRequestDto.md) |  | [optional] 
**Logo** | [**LogoRequest**](LogoRequest.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** | The list of tags. | [optional] 
**Color** | **string** | The room color. | [optional] 
**Cover** | **string** | The room cover. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

