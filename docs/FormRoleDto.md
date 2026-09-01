# DocSpace.API.SDK.Model.FormRoleDto
The form role parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RoleName** | **string** | The role name. | 
**RoleColor** | **string** | The role color. | [optional] 
**User** | [**EmployeeFullDto**](EmployeeFullDto.md) | The user of the role. | [optional] 
**Sequence** | **int** | The role sequence. | 
**Submitted** | **bool** | Specifies if the role is submitted. | 
**StopedBy** | [**EmployeeFullDto**](EmployeeFullDto.md) | The user who stopped the role. | [optional] 
**History** | **Dictionary&lt;string, DateTime&gt;** | The role history. | [optional] 
**RoleStatus** | **FormFillingStatus** | The role status. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

