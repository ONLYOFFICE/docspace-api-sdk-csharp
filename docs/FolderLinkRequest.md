# DocSpace.API.SDK.Model.FolderLinkRequest
The external link of a folder, as it is to be created or rewritten.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LinkId** | **Guid** | Which link the request addresses: the identifier of an existing link rewrites that link, while an identifier  that is not in use, the empty one included, creates a new link. Take an existing identifier from  `GET api/2.0/files/folder/{id}/links`. | [optional] 
**Access** | **FileShare** | The rights a visitor following the link is given. The value that grants nothing revokes the link instead of  setting it, and the answer is then empty. | [optional] 
**ExpirationDate** | [**ApiDateTime**](ApiDateTime.md) | The moment the link stops working, sent as an ISO-8601 stamp. A moment that lies in the past is ignored,  and leaving the field out gives the link no expiry. | [optional] 
**Title** | **string** | The name the link is listed under for the people who manage the folder; a visitor following it never sees the  name. | [optional] 
**Password** | **string** | The secret a visitor has to enter before the link opens. Leave it out for a link that opens without one; the  secret itself is never given back, only the fact that one is set. | [optional] 
**DenyDownload** | **bool** | Whether visitors are left with viewing alone: with true downloading and copying through the link are blocked,  with false they are allowed. | [optional] 
**Internal** | **bool** | Whether the link admits signed-in portal members only: with true a visitor has to sign in before the link  opens, with false anyone holding the address may follow it. | [optional] 
**Primary** | **bool** | Whether this link becomes the primary link of the folder, the one the Copy link action of a client hands  out; a folder has one primary link at a time. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

