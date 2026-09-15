# DocSpace.API.SDK.Model.DocumentConfigDto
The document itself as the editors address it: what to fetch, under which revision key, and what this caller may  do with it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileType** | **string** | The format the editors treat the content as, without the leading dot. For a file that had to be converted this  is the format it was converted to, not the one it is stored under. | [optional] 
**Info** | [**InfoConfigDto**](InfoConfigDto.md) | The facts the editor information panel shows about the document. | [optional] 
**IsLinkedForMe** | **bool** | Whether the caller opened the original document rather than a link pointing at it, which matters only for  formats whose editing is restricted through links. | [optional] 
**Key** | **string** | Identifies the exact revision to the editors: everyone who receives the same key joins the same co-editing  session, and the key changes as soon as the document is saved. | [optional] 
**Permissions** | [**PermissionsConfig**](PermissionsConfig.md) | What this caller may do inside the editor - edit, comment, review, fill, download, print, copy and chat. | [optional] 
**SharedLinkParam** | **string** | The name of the query parameter that carries the external share key. It is set only when the document was  opened through an external link. | [optional] 
**SharedLinkKey** | **string** | The external share key this opening runs under, empty when the caller opened the document as a portal member.  The editors pass it back on every request they make for the document. | [optional] 
**ReferenceData** | [**FileReferenceData**](FileReferenceData.md) | How another spreadsheet names this document in a formula. Pass it to `POST api/2.0/files/file/referencedata`  to resolve such a reference. | [optional] 
**Title** | **string** | The name the editors display. When a past version was opened, the moment that version was created is appended  to it in brackets. | [optional] 
**Url** | **string** | Where the editors fetch the content. It is addressed to the host the document service can reach, which is not  necessarily the address a browser should follow. | [optional] 
**IsForm** | **bool** | Whether the document is a fillable PDF form. A PDF that the portal has never classified is inspected while the  configuration is built, so the answer is trustworthy even for a freshly uploaded file. | [optional] 
**Options** | [**Options**](Options.md) | Extra instructions for the editors, currently the watermark to draw over the document. It is empty when the  room sets no watermark. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

