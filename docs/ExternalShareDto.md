# DocSpace.API.SDK.Model.ExternalShareDto
The external sharing information and validation data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **Status** |  | 
**Id** | **string** | The external data ID. | 
**Title** | **string** | The external data title. | 
**Type** | **FileEntryType** |  | [optional] 
**TenantId** | **int** | The tenant ID. | 
**EntityId** | **string** | The unique identifier of the shared entity. | [optional] 
**EntityTitle** | **string** | The title of the shared entity. | [optional] 
**EntityType** | **FileEntryType** |  | [optional] 
**IsRoom** | **bool?** | Indicates whether the entity represents a room. | [optional] 
**Shared** | **bool** | Specifies whether to share the external data or not. | 
**LinkId** | **Guid** | The link ID of the external data. | 
**IsAuthenticated** | **bool** | Specifies whether the user is authenticated or not. | 
**IsRoomMember** | **bool** | The room ID of the external data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

