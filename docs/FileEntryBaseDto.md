# DocSpace.API.SDK.Model.FileEntryBaseDto
The file entry information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The file entry title. | [optional] 
**Access** | **FileShare** |  | [optional] 
**Shared** | **bool** | Specifies if the file entry is shared via link or not. | [optional] 
**SharedForUser** | **bool** | Specifies if the file entry is shared for user or not. | [optional] 
**ParentShared** | **bool** | Indicates whether the parent entity is shared. | [optional] 
**ShortWebUrl** | **string** | The short Web URL. | [optional] 
**Created** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**CreatedBy** | [**EmployeeDto**](EmployeeDto.md) |  | [optional] 
**Updated** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**AutoDelete** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**RootFolderType** | **FolderType** |  | [optional] 
**ParentRoomType** | **FolderType** |  | [optional] 
**UpdatedBy** | [**EmployeeDto**](EmployeeDto.md) |  | [optional] 
**ProviderItem** | **bool?** | Specifies if the file entry provider is specified or not. | [optional] 
**ProviderKey** | **string** | The provider key of the file entry. | [optional] 
**ProviderId** | **int?** | The provider ID of the file entry. | [optional] 
**Order** | **string** | The order of the file entry. | [optional] 
**IsFavorite** | **bool?** | Specifies if the file is a favorite or not. | [optional] 
**FileEntryType** | **FileEntryType** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

