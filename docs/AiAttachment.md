# DocSpace.API.SDK.Model.AiAttachment
Persistent record for a single attachment (file or image) referenced from a user message. Files carry extracted text in `content`; images carry base64 data in `base64`. Metadata (`title`, `path`, `type`) is always present for display purposes regardless of whether the heavy payload is loaded.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Storage-assigned UUID. | 
**Kind** | **string** | file | image. | 
**Source** | **string** | Origin of the attachment. `user` — uploaded by the user in the composer (the default when unset, for backward compatibility). `tool` — produced by a tool call (e.g. `generate_image`). Lets the integrator's adapter route or apply policies (separate bucket, quotas, TTL, CDN) per source. | [optional] 
**Title** | **string** | Display label (filename or user-visible title). | 
**Content** | **string** | Extracted text for files. | [optional] 
**Base64** | **string** | Base64 data URL for images. | [optional] 
**Path** | **string** | Original host file path (for files). | [optional] 
**Type** | **decimal** | ONLYOFFICE file type code (for files). | [optional] 
**MessageId** | **string** | Owning message id once linked. Unset while the attachment is a draft. | [optional] 
**ThreadId** | **string** | Owning thread id once linked. Unset while the attachment is a draft. | [optional] 
**EntityId** | **string** | Opaque scope token (entity / room) the attachment was created in. Drafts carry it so an entity switch keeps in-flight composer state isolated; once linked to a message the field is redundant with the thread's own entity binding. | [optional] 
**CreatedAt** | **decimal** | Storage-assigned creation timestamp. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

