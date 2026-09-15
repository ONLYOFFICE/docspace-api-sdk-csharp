# DocSpace.API.SDK.Model.MentionMessageWrapper
The mention notification to send: what to say, whom to tell and where in the document the mention sits.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionLink** | [**ActionLinkConfig**](ActionLinkConfig.md) | The place in the document the notification link should open at, as the editor reports it when the mention is  made. Left out, the link opens the file at its beginning. | [optional] 
**Emails** | **List&lt;string&gt;** | The addresses to notify. Only an address that belongs to a portal account receives a mail; an unknown address  is skipped, and the answer then carries the access list of the file so that the client can invite its owner. | [optional] 
**Message** | **string** | The note shown next to the link in the mail. Only its first 200 characters are sent, and a value longer than  the field allows is refused. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

