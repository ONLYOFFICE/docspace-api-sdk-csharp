# DocSpace.API.SDK.Model.EditHistoryAuthor
The person a saved revision of a file, or one single change in it, is attributed to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The account the revision or the change is attributed to, as the editing service stored it. It is normally the  identifier of a portal account; the empty identifier stands for a change nobody could be named for. | 
**Name** | **string** | The display name of that account as the portal spells it now, which need not be the name that was stored with  the revision. An account that cannot be resolved - one removed from the portal, or a change made through an  anonymous link - is reported as a guest. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

