# DocSpace.API.SDK.Model.RoomLinkRequest
The link of a room to create, change or revoke.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LinkId** | **Guid** | Which link to change, taken from `GET api/2.0/files/rooms/{id}/links`. Leaving it out creates a link, and an  identifier the room does not know creates a link carrying that identifier. | [optional] 
**Access** | **FileShare** | What whoever opens the link may do in the room. The value 0 revokes the link instead of changing it, and the  levels a room accepts depend on its kind. | [optional] 
**ExpirationDate** | [**ApiDateTime**](ApiDateTime.md) | When the link stops working, written with the offset of the portal time zone. A date already past is dropped  silently for an external link and refused for an invitation link, and a date further ahead than the portal  allows is refused as well; leaving it out means the link does not expire. | [optional] 
**Internal** | **bool** | Whether the external link works only for people already signed in to the portal. With it off the link opens  the room for anyone who has the address, subject to the password. | [optional] 
**Title** | **string** | The name the link is shown under in the room. An empty value is accepted and the portal names the link itself,  so the answer is what tells the caller the name in use. | [optional] 
**LinkType** | **LinkType** | Which kind of link to create: an invitation link makes whoever opens it a member of the room, while an  external link opens the room without an account. It is fixed when the link is created and is ignored on later  changes. | [optional] 
**Password** | **string** | The password an external link asks for before it opens the room. An empty value leaves the link open to anyone  who has the address, and the password is never returned when links are listed. | [optional] 
**DenyDownload** | **bool** | Whether people arriving through the link are stopped from downloading and printing what they open. They can  still read the documents in the editor. | [optional] 
**MaxUseCount** | **int?** | How many people an invitation link may still let in before it stops working. A value below the number of  people who already used it is refused, and leaving it out puts no ceiling on the link. | [optional] 
**CurrentUseCount** | **int** | How many people have already joined through this invitation link. The value is kept by the portal: it is  reported back when links are listed and anything sent here is ignored. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

