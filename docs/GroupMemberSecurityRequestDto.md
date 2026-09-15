# DocSpace.API.SDK.Model.GroupMemberSecurityRequestDto
One member of a portal group together with the access that member has on the file or folder the group was granted  rights to. Every line of the answer describes the same file or folder and differs only in the member and in the  level that applies to them.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**User** | [**EmployeeFullDto**](EmployeeFullDto.md) | The member the line is about, as the portal reports the account: the display name, the avatar and the portal  role to show next to the access level. | 
**GroupAccess** | **FileShare** | The level granted to the group as a whole on this file or folder. It belongs to the group record rather than  to the member, so the same value repeats on every line of the answer; a group whose record was set back to  none is answered with an empty list instead. | 
**UserAccess** | **FileShare** | The level granted to this member alone on the same file or folder, or `null` when the member has no record of  their own and the group level is what applies. The member who created the file or folder is always reported  here as a room manager, whatever their own record says. | [optional] 
**Overridden** | **bool** | Whether `userAccess` is the level that decides what the member may do. When it is false the member inherits  `groupAccess`, and the creator of the file or folder is always reported as overridden because of the room  manager level forced onto them. | 
**CanEditAccess** | **bool** | Whether the caller may still change the level of this member. It comes back false on the line of the member  who created the file or folder, on the line of the caller themselves, and on every line at once when the  caller may read the file or folder but not manage access to it. | 
**Owner** | **bool** | Whether this member created the file or folder - the owner of the entry, not the owner of the group. Their  level is reported as a room manager one and cannot be taken away through this group. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

