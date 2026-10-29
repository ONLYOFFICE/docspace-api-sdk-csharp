# DocSpace.Webhooks.SDK.Model.UserSummaryPayload
A short reference to a user from another payload: the author or the last editor of a file, folder or room, the manager of a group, or the creator of an account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The ID of the referenced user; &#x60;GET api/2.0/people/{userid}&#x60; returns the full profile by it. | [optional] 
**DisplayName** | **string** | The user&#39;s full name in the name order set for the portal, HTML-encoded. | [optional] 
**UserName** | **string** | The unique login name of the user, made from the local part of their email address when the account is created. Absent when the subscription&#39;s creator is a User or a Guest, who may not see the contacts of other users, unless this user is that creator. | [optional] 
**Avatar** | **string** | The absolute URL of the 82x82 avatar, with a hash query parameter that changes when the profile does. | [optional] 
**ProfileUrl** | **string** | The absolute link to the user in the portal&#39;s list of people, or of guests for a guest; today it is a search of that list by the user&#39;s email address. Absent when the subscription&#39;s creator is a User or a Guest, who may not see the contacts of other users, unless this user is that creator. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

