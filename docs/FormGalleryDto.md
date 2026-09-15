# DocSpace.API.SDK.Model.FormGalleryDto
Where the ready-made form templates are served from, for browsing them and for submitting new ones.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The path under `domain` that the gallery's own listing API is reached at. It is joined to `domain` by the  client; the portal only relays the values from its configuration. | 
**Domain** | **string** | The address of the gallery service, which is a service of the vendor rather than part of the portal. Every  field of this object is empty on an installation that configures no gallery, and a client should then not  offer the gallery at all. | 
**Ext** | **string** | The file extension to ask the gallery for, which decides which rendition of a template is downloaded when  several are published. | 
**UploadPath** | **string** | The path used for submitting a form of one's own to the gallery, the counterpart of `path` for the upload  side. The four `upload` fields are empty when the installation allows browsing but not submitting. | 
**UploadDomain** | **string** | The address the submission is sent to, which may differ from `domain`. | 
**UploadExt** | **string** | The file extension a submitted form has to carry. | 
**UploadDashboard** | **string** | The page a person is sent to in order to follow up on a submission, joined to `uploadDomain` the same way  as `uploadPath`. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

