# DocSpace.API.SDK.Model.SetPublicDto
The public access to set on a room template.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The identifier of the room template. Take it from `templateId` of `GET api/2.0/files/roomtemplate/status`, or  from the folder list of `GET api/2.0/files/rooms` called with `searchArea` set to 4; an identifier of an  ordinary room is not accepted. | 
**Public** | **bool** | Whether the Everyone group keeps read access to the template. True shares it with every member allowed to  create rooms; false leaves it reachable only for its owner. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

