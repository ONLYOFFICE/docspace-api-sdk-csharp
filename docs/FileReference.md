# DocSpace.API.SDK.Model.FileReference
The file reference parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReferenceData** | [**FileReferenceData**](FileReferenceData.md) | How this document is named when another spreadsheet refers to it. Send it back as it stands to resolve the  reference again. | [optional] 
**Error** | **string** | Filled in when the reference resolved to nothing; the rest of the descriptor is then empty and must not be  handed to the editors. | [optional] 
**Path** | **string** | The title of the document the reference resolved to. | [optional] 
**Url** | **string** | Where the content is fetched from. It is addressed to the host the document service can reach, which on a  deployment with a private editor network is not the address a browser should follow. | [optional] 
**FileType** | **string** | The format the content is in, without the leading dot. | [optional] 
**Key** | **string** | Identifies the exact revision to the editors: two clients that receive the same key read the same co-editing  session, and the key changes as soon as the document is saved. | [optional] 
**Link** | **string** | The address of the document in the portal web editor - the link to put in front of a person, unlike the  download address above. | [optional] 
**Token** | **string** | Signs this descriptor so that the editors can trust it. It stays empty on a portal that has no signature  secret configured for the document service. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

