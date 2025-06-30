# DocSpace.Model.GroupDto
The group parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The group name. | [optional] 
**Parent** | **Guid?** | The parent group ID. | [optional] 
**Category** | **Guid** | The group category ID. | [optional] 
**Id** | **Guid** | The group ID. | [optional] 
**IsLDAP** | **bool** | Specifies if the LDAP settings are enabled for the group or not. | [optional] 
**Manager** | [**EmployeeFullDto**](.md) |  | [optional] 
**Members** | [**List&lt;EmployeeFullDto&gt;**](.md) | The list of group members. | [optional] 
**Shared** | **bool?** | Specifies whether the group can be shared or not. | [optional] 
**MembersCount** | **int** | The number of group members. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

