# DocSpace.API.SDK.Model.SecurityInfoRequestDto
The entries whose sharing rights are being changed, and the rights to apply to them.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FolderIds** | [**List&lt;DuplicateRequestDtoAllOfFileIds&gt;**](DuplicateRequestDtoAllOfFileIds.md) | The folders and rooms whose rights are being changed, identified as a listing operation returns them - a  number on the portal, a string on a connected third-party account. | [optional] 
**FileIds** | [**List&lt;DuplicateRequestDtoAllOfFileIds&gt;**](DuplicateRequestDtoAllOfFileIds.md) | The files whose rights are being changed, identified as a listing operation returns them - a number on the  portal, a string on a connected third-party account. | [optional] 
**Share** | [**List&lt;FileShareParams&gt;**](FileShareParams.md) | One record per account or group whose rights are being set, each naming the subject and the level it gets on  all of the listed entries; a level of `None` takes the access away. An empty collection makes the call change  nothing. | [optional] 
**Notify** | **bool** | Set to true to have every account named in `share` emailed about the access it just received; false changes  the rights without telling anyone. | [optional] 
**SharingMessage** | **string** | The text put into that email, ignored while `notify` is false. Markup is stripped before sending, so only the  plain text of the value survives. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

