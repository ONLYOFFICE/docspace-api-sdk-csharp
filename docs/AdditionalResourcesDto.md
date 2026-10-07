# DocSpace.API.SDK.Model.AdditionalResourcesDto
Which of the ONLYOFFICE help and community entries the interface may offer, installation-wide, in the shape the  reset of these flags returns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDocsEnabled** | **bool** | Whether the sample documents that ONLYOFFICE ships may be placed in a new user's Documents. Unlike the link  flags below it depends on nothing that has to be configured, so its built-in value is always `true`. | [optional] 
**HelpCenterEnabled** | **bool** | Whether the interface may offer the Help Center entry. It is `false` both when the entry was switched off  for the installation and when the installation configures no Help Center address at all; the addresses  themselves are not part of this answer and arrive in `externalResources` of `GET api/2.0/settings`. | [optional] 
**FeedbackAndSupportEnabled** | **bool** | Whether the interface may offer the Feedback and Support entry, `false` for the same two reasons as  `helpCenterEnabled`. | [optional] 
**UserForumEnabled** | **bool** | Whether the interface may offer the user forum entry, `false` for the same two reasons as  `helpCenterEnabled`. | [optional] 
**VideoGuidesEnabled** | **bool** | Whether the interface may offer the Video Guides entry, `false` for the same two reasons as  `helpCenterEnabled`. | [optional] 
**LicenseAgreementsEnabled** | **bool** | Whether the interface may offer the License Agreements entry, `false` for the same two reasons as  `helpCenterEnabled`. | [optional] 
**LastModified** | **DateTime** | When these flags were last stored. Flags that were never stored report the moment they were read, and the  answer of the reset operation reports `0001-01-01T00:00:00`. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

