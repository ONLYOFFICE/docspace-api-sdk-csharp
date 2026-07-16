# DocSpace.API.SDK.Model.ExternalSharingSettingsRequestDto
The Access Control external sharing settings request parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalShare** | **bool** | Specifies whether external (public) link creation is allowed. | [optional] 
**DefaultShareLinkInternal** | **bool** | Specifies the default sharing link type: true = DocSpace users only, false = Anyone with the link.  Relevant only when ExternalShare is true. | [optional] 
**ExternalShareApplyToDocuments** | **bool** | When external sharing is restricted, specifies whether to apply the restriction to the My Documents section.  Relevant only when ExternalShare is false. | [optional] 
**ExternalShareApplyToRooms** | **bool** | When external sharing is restricted, specifies whether to apply the restriction to the Rooms section.  Relevant only when ExternalShare is false. | [optional] 
**BlockExistingLinksOnRestrict** | **bool** | When external sharing is restricted, specifies whether to block existing public links immediately.  Relevant only when ExternalShare is false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

