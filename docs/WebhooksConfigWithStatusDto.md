# DocSpace.API.SDK.Model.WebhooksConfigWithStatusDto
A webhook subscription together with how its last delivery ended.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Configs** | [**WebhooksConfigDto**](WebhooksConfigDto.md) | The subscription itself. Despite the plural name it is one subscription, not a list. | [optional] 
**Status** | **int** | The HTTP status code the target answered on the last attempt. `0` means nothing has been delivered yet,  which is not the same as a failure. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

