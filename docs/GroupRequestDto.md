# DocSpace.API.SDK.Model.GroupRequestDto
The group request parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Members** | **List&lt;Guid&gt;** | The accounts to put into the new group. Every one of them has to be an active member that is not a guest,  otherwise the whole call is rejected. Omit it to create an empty group. | [optional] 
**GroupManager** | **Guid** | The account to make the manager of the new group. It is added to the group as well, so it does not have to be  repeated in `members`. Omit it to create a group without a manager. | [optional] 
**GroupName** | **string** | The name of the group, from 1 to 128 characters. It is required, it may not be blank, and it does not have to  be unique. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

