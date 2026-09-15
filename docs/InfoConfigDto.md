# DocSpace.API.SDK.Model.InfoConfigDto
The facts the editor information panel shows about the open document.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Favorite** | **bool?** | Whether the caller has this document among their favorites. It is empty when favorites do not apply - for an  anonymous caller, for a guest, and for an encrypted document. | [optional] 
**Folder** | **string** | The place of the document as a readable path, its folders joined from the root downwards. It is empty in the  embedded layout, which shows no such panel. | [optional] 
**Owner** | **string** | The display name of the owner of the document. It is empty for an anonymous session. | [optional] 
**SharingSettings** | [**List&lt;AceShortWrapper&gt;**](AceShortWrapper.md) | Who the document is shared with, as the information panel lists it. An empty list means it is shared with  nobody beyond its owner. | [optional] 
**Type** | **EditorType** | The layout the information panel is rendered for. | [optional] 
**Uploaded** | **string** | When the document was created on the portal, already formatted for reading in the culture of the caller rather  than as a machine timestamp. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

