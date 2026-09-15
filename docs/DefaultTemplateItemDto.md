# DocSpace.API.SDK.Model.DefaultTemplateItemDto
The blank document configured for one extension.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelectedFile** | **int?** | The copy stored in the portal that serves as the blank for this extension. A null means no custom blank has  been chosen and new documents start from the portal's built-in one; the other fields of the entry are then  empty as well. | [optional] 
**FileExtension** | **string** | The extension the entry describes, in lower case with the leading dot. It is the value to send back when this  blank is replaced or reset. | 
**FileTitle** | **string** | The name the custom blank was copied under, useful for showing which document was chosen. Empty while the  built-in blank is in use. | [optional] 
**LastModified** | **DateTime?** | When the custom blank was last changed, in the time zone of the portal. Null while the built-in blank is in  use. | [optional] 
**FileSize** | **long?** | The size of the custom blank in bytes. Null while the built-in blank is in use. | [optional] 
**ViewUrl** | **string** | The address the custom blank can be downloaded from, already carrying the access key of the calling account.  Empty while the built-in blank is in use. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

