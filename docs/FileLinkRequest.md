# DocSpace.API.SDK.Model.FileLinkRequest
The settings of an external link to a file.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LinkId** | **Guid** | The link to rewrite, as reported by `GET api/2.0/files/file/{id}/links`. An identifier that is not yet in use,  the empty one included, creates a link instead. | [optional] 
**Access** | **FileShare** | The rights the link grants to whoever follows it. The value that denies everything revokes the link. | [optional] 
**ExpirationDate** | [**ApiDateTime**](ApiDateTime.md) | The moment the link stops working, read in the time zone of the portal. A date more than a few years ahead is  rejected as an invalid request; left out, the link does not expire on its own. | [optional] 
**Title** | **string** | The name the link carries in the sharing list of the file, for the people who manage it; it is not shown to  whoever follows the link. | [optional] 
**Internal** | **bool** | Who may follow the link: `true` admits only accounts that are signed in to the portal, `false` admits anybody  who has the address. | [optional] 
**Primary** | **bool** | Whether this link becomes the primary link of the file - the one the Copy link action of a client hands out.  A file has one primary link at a time. | [optional] 
**DenyDownload** | **bool** | What a visitor may do with the content: `true` leaves them with viewing in the browser, `false` lets them  download and print it as their rights allow. | [optional] 
**Password** | **string** | The secret a visitor has to type before the file opens; left out, the link opens without one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

