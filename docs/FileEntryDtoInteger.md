# DocSpace.API.SDK.Model.FileEntryDtoInteger
The generic file entry information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The file entry title. | [optional] 
**Access** | **FileShare** | The access rights to the file entry. | [optional] 
**SharedBy** | [**EmployeeDto**](EmployeeDto.md) | Provides information about the employee who shared the file or folder. | [optional] 
**OwnedBy** | [**EmployeeDto**](EmployeeDto.md) | The information about the employee who owns the file entry. | [optional] 
**Shared** | **bool** | Specifies if the file entry is shared via link or not. | [optional] 
**SharedForUser** | **bool** | Specifies if the file entry is shared for user or not. | [optional] 
**SharedExternal** | **bool** | Specifies if the file entry is shared via a public (non-internal) external link. | [optional] 
**ParentShared** | **bool** | Indicates whether the parent entity is shared. | [optional] 
**ShortWebUrl** | **string** | The short Web URL. | [optional] 
**Created** | [**ApiDateTime**](ApiDateTime.md) | The creation date and time of the file entry. | [optional] 
**CreatedBy** | [**EmployeeDto**](EmployeeDto.md) | The file entry author. | [optional] 
**Updated** | [**ApiDateTime**](ApiDateTime.md) | The last date and time when the file entry was updated. | [optional] 
**AutoDelete** | [**ApiDateTime**](ApiDateTime.md) | The date and time when the file entry will be automatically deleted. | [optional] 
**RootFolderType** | **FolderType** | The root folder type of the file entry. | [optional] 
**ParentRoomType** | **FolderType** | The parent room type of the file entry. | [optional] 
**UpdatedBy** | [**EmployeeDto**](EmployeeDto.md) | The user who updated the file entry. | [optional] 
**ProviderItem** | **bool** | Specifies if the file entry provider is specified or not. | [optional] 
**ProviderKey** | **string** | The provider key of the file entry. | [optional] 
**ProviderId** | **int** | The provider ID of the file entry. | [optional] 
**Order** | **string** | The order of the file entry. | [optional] 
**IsFavorite** | **bool** | Specifies if the file is a favorite or not. | [optional] 
**FileEntryType** | **FileEntryType** | The file entry type. | [optional] 
**Id** | **int** | The file entry ID. | [optional] 
**RootFolderId** | **int** | The root folder ID of the file entry. | [optional] 
**OriginId** | **int** | The origin ID of the file entry. | [optional] 
**OriginRoomId** | **int** | The origin room ID of the file entry. | [optional] 
**OriginTitle** | **string** | The origin title of the file entry. | [optional] 
**OriginRoomTitle** | **string** | The origin room title of the file entry. | [optional] 
**CanShare** | **bool** | Specifies if the file entry can be shared or not. | [optional] 
**ShareSettings** | [**FileEntryDtoIntegerAllOfShareSettings**](FileEntryDtoIntegerAllOfShareSettings.md) |  | [optional] 
**Security** | [**FileEntryDtoIntegerAllOfSecurity**](FileEntryDtoIntegerAllOfSecurity.md) |  | [optional] 
**AvailableShareRights** | [**FileEntryDtoIntegerAllOfAvailableShareRights**](FileEntryDtoIntegerAllOfAvailableShareRights.md) |  | [optional] 
**RequestToken** | **string** | The request token of the file entry. | [optional] 
**External** | **bool?** | Specifies if the folder can be accessed via an external link or not. | [optional] 
**ExpirationDate** | [**ApiDateTime**](ApiDateTime.md) | Represents the expiration date of the file entry. | [optional] 
**IsLinkExpired** | **bool?** | Indicates whether the shareable link associated with the file or folder has expired. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

