# DocSpace.API.SDK.Model.FileShareDto
The file sharing information and access rights.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Access** | **FileShare** |  | [optional] 
**SharedTo** | **Object** | The user who has the access to the specified file. | [optional] 
**SharedToUser** | [**EmployeeFullDto**](EmployeeFullDto.md) |  | [optional] 
**SharedToGroup** | [**GroupSummaryDto**](GroupSummaryDto.md) |  | [optional] 
**SharedLink** | [**FileShareLink**](FileShareLink.md) |  | [optional] 
**IsLocked** | **bool** | Specifies if the access right is locked or not. | 
**IsOwner** | **bool** | Specifies if the user is an owner of the specified file or not. | 
**CanEditAccess** | **bool** | Specifies if the user can edit the access to the specified file or not. | 
**CanEditInternal** | **bool** | Indicates whether internal editing permissions are granted. | 
**CanEditDenyDownload** | **bool** | Determines whether the user has permission to modify the deny download setting for the file share. | 
**CanEditExpirationDate** | **bool** | Indicates whether the expiration date of access permissions can be edited. | 
**SubjectType** | **SubjectType** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

