# DocSpace.API.SDK.Model.FillingFormResultDtoInteger
The parameters of the form filling result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FormNumber** | **int** | The filling form number. | 
**CompletedForm** | [**FileDtoInteger**](FileDtoInteger.md) | The file with the completed forms. | [optional] 
**OriginalForm** | [**FileDtoInteger**](FileDtoInteger.md) | The file with the original forms. | [optional] 
**Manager** | [**EmployeeFullDto**](EmployeeFullDto.md) | The manager who is filling the form. | [optional] 
**RoomId** | **int** | The room ID where filling the form. | 
**IsRoomMember** | **bool** | Specifies if the manager who fills the form is a room member or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

