# DocSpace.API.SDK.Model.AiAgentsUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileId** | **string** | Profile id to rebind (optional). | [optional] 
**ChatSettings** | **Object** | Chat settings (`ChatSettings`); requires a valid provider/model. | [optional] 
**SendFormToExternalDB** | **bool** | Whether form results are sent to an external DB. | [optional] 
**SaveFormAsXLSX** | **bool** | Whether forms are saved as XLSX. | [optional] 
**Title** | **string** | Agent (room) title. | [optional] 
**Quota** | **decimal** | Room quota in bytes. | [optional] 
**Indexing** | **bool** | Whether room content is indexed for search. | [optional] 
**DenyDownload** | **bool** | Whether downloading room content is denied. | [optional] 
**Lifetime** | **Object** | Room data lifetime policy (`RoomDataLifetimeDto`). | [optional] 
**Watermark** | **Object** | Watermark settings (`WatermarkRequestDto`). | [optional] 
**Logo** | **Object** | Room logo (`LogoRequest`). | [optional] 
**Tags** | **List&lt;string&gt;** | Room tags. | [optional] 
**Color** | **string** | Room accent color. | [optional] 
**Cover** | **string** | Room cover image id. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

