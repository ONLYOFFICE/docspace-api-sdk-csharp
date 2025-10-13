# DocSpace.API.SDK.Model.GroupDto
The group parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The group name. | 
**Parent** | **Guid?** | The parent group ID. | [optional] 
**Category** | **Guid** | The group category ID. | 
**Id** | **Guid** | The group ID. | 
**IsLDAP** | **bool** | Specifies if the LDAP settings are enabled for the group or not. | 
**IsSystem** | **bool?** | Indicates whether the group is a system group. | [optional] 
**Manager** | [**EmployeeFullDto**](EmployeeFullDto.md) |  | [optional] 
**Members** | [**List&lt;EmployeeFullDto&gt;**](EmployeeFullDto.md) | The list of group members. | [optional] 
**Shared** | **bool?** | Specifies whether the group can be shared or not. | [optional] 
**MembersCount** | **int** | The number of group members. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

