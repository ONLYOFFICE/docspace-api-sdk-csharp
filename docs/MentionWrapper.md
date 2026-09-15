# DocSpace.API.SDK.Model.MentionWrapper
A user the editor may offer: to be mentioned in a comment, or to be picked when protecting a document.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**User** | [**UserInfo**](UserInfo.md) | The account itself, in the shape the people listings use. | [optional] 
**Email** | **string** | Where a mention notification for this user is delivered. | [optional] [readonly] 
**Id** | **string** | The account id as text, the same value the account object carries; it is what identifies the user in a sharing  request built from this list. | [optional] [readonly] 
**Image** | **string** | An absolute address of the medium-sized avatar. A generated default avatar is reported when the user never  uploaded one, so the field is never empty. | [optional] [readonly] 
**HasAccess** | **bool** | Not filled in by the operations that return this list: it always comes back false. Whether a user can already  open the document has to be read from the sharing settings of the file. | [optional] [readonly] 
**Name** | **string** | The name to display, assembled the way the portal is configured to show names. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

