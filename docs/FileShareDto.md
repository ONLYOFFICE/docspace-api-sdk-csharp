# DocSpace.API.SDK.Model.FileShareDto
The file sharing information and access rights.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Access** | **FileShare** | The access rights type. | [optional] 
**SharedTo** | **Object** |  | [optional] 
**SharedToUser** | [**EmployeeFullDto**](EmployeeFullDto.md) | The full list of user parameters. | [optional] 
**SharedToGroup** | [**GroupSummaryDto**](GroupSummaryDto.md) | The group summary parameters. | [optional] 
**SharedLink** | [**FileShareLink**](FileShareLink.md) | The user who has the access to the specified file. | [optional] 
**IsLocked** | **bool** | Specifies if the access right is locked or not. | 
**IsOwner** | **bool** | Specifies if the user is an owner of the specified file or not. | 
**CanEditAccess** | **bool** | Specifies if the user can edit the access to the specified file or not. | 
**CanEditInternal** | **bool** | Indicates whether internal editing permissions are granted. | 
**CanEditDenyDownload** | **bool** | Determines whether the user has permission to modify the deny download setting for the file share. | 
**CanEditExpirationDate** | **bool** | Indicates whether the expiration date of access permissions can be edited. | 
**CanRevoke** | **bool** | Specifies whether the file sharing access can be revoked by the current user. | 
**SubjectType** | **SubjectType** | The subject type of the access right. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

