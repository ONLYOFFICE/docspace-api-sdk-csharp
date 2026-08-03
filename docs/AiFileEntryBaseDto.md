# DocSpace.API.SDK.Model.AiFileEntryBaseDto
The file entry information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The file entry title. | [optional] 
**Access** | **AiFileShare** |  | [optional] 
**SharedBy** | [**AiEmployeeDto**](AiEmployeeDto.md) |  | [optional] 
**OwnedBy** | [**AiEmployeeDto**](AiEmployeeDto.md) |  | [optional] 
**Shared** | **bool** | Specifies if the file entry is shared via link or not. | [optional] 
**SharedForUser** | **bool** | Specifies if the file entry is shared for user or not. | [optional] 
**SharedExternal** | **bool** | Specifies if the file entry is shared via a public (non-internal) external link. | [optional] 
**ParentShared** | **bool** | Indicates whether the parent entity is shared. | [optional] 
**ShortWebUrl** | **string** | The short Web URL. | [optional] 
**Created** | [**AiApiDateTime**](AiApiDateTime.md) |  | [optional] 
**CreatedBy** | [**AiEmployeeDto**](AiEmployeeDto.md) |  | [optional] 
**Updated** | [**AiApiDateTime**](AiApiDateTime.md) |  | [optional] 
**AutoDelete** | [**AiApiDateTime**](AiApiDateTime.md) |  | [optional] 
**RootFolderType** | **AiFolderType** |  | [optional] 
**ParentRoomType** | **AiFolderType** |  | [optional] 
**UpdatedBy** | [**AiEmployeeDto**](AiEmployeeDto.md) |  | [optional] 
**ProviderItem** | **bool?** | Specifies if the file entry provider is specified or not. | [optional] 
**ProviderKey** | **string** | The provider key of the file entry. | [optional] 
**ProviderId** | **int?** | The provider ID of the file entry. | [optional] 
**Order** | **string** | The order of the file entry. | [optional] 
**IsFavorite** | **bool?** | Specifies if the file is a favorite or not. | [optional] 
**FileEntryType** | **AiFileEntryType** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

