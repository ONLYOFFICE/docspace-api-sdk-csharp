# DocSpace.API.SDK.Model.FileReferenceData
The pair of values that names a document across portals, as it is written into a spreadsheet formula.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileKey** | **string** | The id of the document inside the portal named below. | [optional] 
**InstanceId** | **string** | The portal the document lives in. A reference whose value is not this portal cannot be resolved by the file  key and falls back to the path or the link. | [optional] 
**RoomId** | **string** | The room the document lies in. It is filled in only for a document opened in a virtual data room, and stays  empty everywhere else. | [optional] 
**CanEditRoom** | **bool** | Whether the caller may manage the room named above; it is only meaningful together with it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

