# DocSpace.API.SDK.Model.SocketSettingsDto
Where a client connects for the portal's live updates.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | The base address of the Socket.IO hub that pushes file changes, presence and quota alerts, always with a  trailing slash. It is empty when the installation runs no hub, and a client must then fall back to  polling rather than guessing an address. The value comes from the installation's configuration and cannot  be changed through this API. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

