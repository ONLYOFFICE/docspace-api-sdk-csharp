# DocSpace.API.SDK.Model.StartUpdateUserTypeDto
The parameters for updating the type of the user or guest when reassigning rooms and shared files.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **EmployeeType** | The type to convert the account to. Only `Guest` and `User` are accepted, because they are the types that  cannot own rooms; `RoomAdmin`, `DocSpaceAdmin` and `All` are rejected here and belong to  `PUT api/2.0/people/type/{type}`. | [optional] 
**UserId** | **Guid** | The ID of the account being converted. It has to be an active account other than the caller, and only the  portal owner may pass the ID of a DocSpace administrator. | [optional] 
**ReassignUserId** | **Guid?** | The ID of the administrator who receives the rooms and the shared files of the converted account. It has to be  an active room admin or DocSpace admin other than the converted account, and when it is omitted the data goes  to the caller. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

