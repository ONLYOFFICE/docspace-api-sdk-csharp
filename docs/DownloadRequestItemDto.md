# DocSpace.API.SDK.Model.DownloadRequestItemDto
One file of a bulk download, together with the format it is converted to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | [**DownloadRequestItemDtoKey**](DownloadRequestItemDtoKey.md) |  | 
**Value** | **string** | The format the file is converted to before it is packed, as a file extension without a leading dot. | 
**Password** | **string** | The password that opens the source file, for a file protected with one; a protected file cannot be converted  without it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

