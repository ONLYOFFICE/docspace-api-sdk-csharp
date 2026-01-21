# DocSpace.API.SDK.Model.SecurityInfoRequestDto
The security information request parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FolderIds** | [**List&lt;DuplicateRequestDtoAllOfFileIds&gt;**](DuplicateRequestDtoAllOfFileIds.md) | The list of the shared folder IDs. | [optional] 
**FileIds** | [**List&lt;DuplicateRequestDtoAllOfFileIds&gt;**](DuplicateRequestDtoAllOfFileIds.md) | The list of the shared file IDs. | [optional] 
**Share** | [**List&lt;FileShareParams&gt;**](FileShareParams.md) | The collection of sharing parameters. | [optional] 
**Notify** | **bool** | Specifies whether to notify users about the shared file or not. | [optional] 
**SharingMessage** | **string** | The message to send when notifying about the shared file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

