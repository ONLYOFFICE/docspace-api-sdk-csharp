# DocSpace.API.SDK.Model.AiAttachment
Persistent record for a single attachment (file or image) referenced from a user message. Files carry extracted text in `content`; images carry base64 data in `base64`. Metadata (`title`, `path`, `type`) is always present for display purposes regardless of whether the heavy payload is loaded.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Storage-assigned UUID. | 
**Kind** | **string** | file | image. | 
**Source** | **string** | Where the attachment came from: `user` - attached by the user (also when unset); `tool` - produced by a tool call (for example `generate_image`). | [optional] 
**Title** | **string** | Display label (filename or user-visible title). | 
**Content** | **string** | Extracted text for files. | [optional] 
**Base64** | **string** | Base64 data URL for images. | [optional] 
**Path** | **string** | Original host file path (for files). | [optional] 
**Type** | **decimal** | ONLYOFFICE file type code (for files). | [optional] 
**MessageId** | **string** | Owning message id once linked. Unset while the attachment is a draft. | [optional] 
**ThreadId** | **string** | Owning thread id once linked. Unset while the attachment is a draft. | [optional] 
**EntityId** | **string** | The room or folder the attachment was created in, as an opaque token; once the attachment is bound to a message it repeats the thread's own scope. | [optional] 
**CreatedAt** | **decimal** | Storage-assigned creation timestamp. | 
**CanAnalyze** | **bool** | Whether the attached form can be analyzed. | [optional] 
**FormKeys** | [**List&lt;AiAttachmentFormKeysInner&gt;**](AiAttachmentFormKeysInner.md) | Keys of the fields inside the form. `key` is the field identifier, `text` its human-readable label. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

