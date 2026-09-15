# DocSpace.API.SDK.Model.ExternalShareDto
The outcome of validating an external share link and the entry it points at.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **Status** | How validating the link went. It is the first field to read: a refused link is reported here with the answer  still arriving as a success. A link that resolved describes both the entry and the link, one that is waiting  for its password describes only the entry, and one that failed outright leaves the rest of the object empty. | 
**Id** | **string** | The identifier of the room, folder or file the link points at, always rendered as a string even where the  portal stores it as a number. It is null when the link could not be resolved. | [optional] 
**Title** | **string** | The title of the entry the link points at, suitable for showing to the visitor before they are let in. It is  null when the link could not be resolved. | [optional] 
**Type** | **FileEntryType** | Whether the link points at a folder - a room counts as one - or at a single file. It is null when the link  could not be resolved. | [optional] 
**TenantId** | **int** | The portal the link belongs to, which matters for a client that works with more than one. It stays 0 for a  link that did not resolve. | 
**EntityId** | **string** | The identifier of the entry that was asked about through the request's file or folder parameter, echoed back  once it was found under the link's target. It is null when nothing was asked about, or when the entry lies  outside what the link opens. | [optional] 
**EntityTitle** | **string** | The title of that entry, null under the same conditions as its identifier. | [optional] 
**EntityType** | **FileEntryType** | Whether that entry is a folder or a file, null under the same conditions as its identifier. | [optional] 
**IsRoom** | **bool?** | True when the link opens a whole room rather than one entry inside it. It is null for a link to a file and for  a link that did not resolve. | [optional] 
**Shared** | **bool** | True when the entry now sits in the calling account's own lists - it was already shared with that account, or  resolving the link has just put it there. It stays false for a visitor browsing without an account, who  reaches the entry through the link alone. | 
**LinkId** | **Guid** | The link the token belongs to, which is also the subject under which the link appears among the sharing rights  of the entry. It is an empty identifier when the link did not resolve. | 
**IsAuthenticated** | **bool** | Whether the request carried a signed-in account. It says nothing about that account's rights on the entry, so  it must not be read as permission - it is false for every anonymous visitor and true for any member, even one  who is a stranger to the room. | 
**IsRoomMember** | **bool** | Whether the signed-in caller already has rights of their own on the room that holds the entry, as opposed to  reaching it through this link. It is false for an anonymous visitor and for a member who has never been  invited. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

