# DocSpace.API.SDK.Model.FileShareParams
One sharing entry: an account, a group or an email address, and the access level it is given.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | The address of somebody who has no portal account yet. An invitation is sent to it and an account is created  once it is accepted, so this is the field to use instead of an account identifier when the person is new to  the portal. | [optional] 
**ShareTo** | **Guid** | The account or the group the entry is about, taken from the portal people and group listings. Leave it out and  give an email address instead to share with somebody who has no account yet. | [optional] 
**Access** | **FileShare** | What the subject may do with the shared item. The value 0 takes the access away again, and which of the other  levels are accepted depends on what is being shared. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

