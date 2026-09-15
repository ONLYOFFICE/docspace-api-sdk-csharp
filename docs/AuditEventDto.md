# DocSpace.API.SDK.Model.AuditEventDto
One entry of the portal audit trail: who changed what, from where, and where it belongs in the product.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The ID of the recorded entry. Nothing accepts it as an argument - no operation fetches a single audit event  - so it serves only to tell two otherwise identical entries apart. | [optional] 
**Date** | [**ApiDateTime**](ApiDateTime.md) | When the action happened, in the portal time zone. The `from` and `to` filters are read as UTC instants, so  the two do not line up on a portal that is not on UTC. | [optional] 
**User** | **string** | The display name of the user who acted, taken from the account as it stands now rather than as it stood  when the entry was written. A localised placeholder stands in when there is no account to read: a portal  background job, an anonymous guest, or a user who has since been deleted. | [optional] 
**UserId** | **Guid** | The ID of the user who acted, which is what the `userId` filter of this operation matches on. It stays  readable after the account is deleted, which is when `user` falls back to a placeholder. | [optional] 
**Action** | **string** | The whole event as a readable sentence in the portal language, with the names of the objects involved  substituted into it. On the two `audit/.../last` operations each substituted value is cut to 50 characters;  the filtered operations substitute them in full. It is empty when the build has no wording for the action. | [optional] 
**ActionId** | **MessageAction** | The action itself, as the `action` filter of this operation spells it and as  `GET api/2.0/security/audit/mappers` lists it under `messageAction`. Use this rather than parsing `action`,  which is prose and changes with the portal language. | [optional] 
**Ip** | **string** | The IP address the request came from, with the port stripped off. It is empty for an action a portal  background job performed, which has no request behind it. | [optional] 
**Country** | **string** | The English name of the country the IP address is located in, empty when the address cannot be located -  the normal outcome for private and loopback addresses. | [optional] 
**City** | **string** | The city the IP address is located in, empty under the same conditions as `country`. | [optional] 
**Browser** | **string** | The browser and its version as parsed from the user agent of the request, empty when the client sent none  that could be parsed or when no request was involved. | [optional] 
**Platform** | **string** | The operating system as parsed from the same user agent, empty under the same conditions as `browser`. | [optional] 
**Page** | **string** | Where in the portal the action was made from: the referrer of the request, or that request's own path when  it carried no referrer. Long values are cut off at 512 characters. | [optional] 
**ActionType** | **ActionType** | The kind of change the action stands for, as the `actionType` filter of this operation spells it. It is  derived from `actionId`, not stored per entry, so it is the same on every entry of one action. | [optional] 
**Product** | **ProductType** | The product the action belongs to. It cannot be filtered on here; the tree that groups actions by product  is `GET api/2.0/security/audit/mappers`. | [optional] 
**Location** | **LocationType** | The location inside that product, as the `moduleType` filter of this operation spells it. It is also  derived from `actionId` rather than stored per entry. | [optional] 
**Target** | **List&lt;string&gt;** | The objects the action was applied to, as the trail recorded them - a title, an account, an ID - one string  each. It is empty for an action that targets nothing, such as a settings change, and the `target` filter of  this operation matches one of these values in full. | [optional] 
**Entries** | [**List&lt;EntryType&gt;**](EntryType.md) | The kinds of object the action applies to, holding at most two entries and none at all for an action that  targets nothing. Only the first of them can be filtered on, through `entryType`. | [optional] 
**Context** | **string** | Where the action took place, spelled out in the portal language rather than as a code: for a Documents  event the room or the root folder it happened in, and for anything else the name of the module. Nothing  filters on it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

