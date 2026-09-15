# DocSpace.API.SDK.Model.DeepLinkDto
What a mobile client needs to hand a portal link to the installed application instead of the browser.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AndroidPackageName** | **string** | The package name to look for on Android, and to build a store link from when the application is missing.  All three fields are empty strings on an installation that ships no mobile application, which is the  signal to keep opening links in the browser. | 
**Url** | **string** | The address the client redirects a portal link through so that the application can claim it. It is the  installation's own deep-link host, not a link to any particular document. | 
**IosPackageId** | **string** | The bundle identifier to look for on iOS, used the same way as `androidPackageName`. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

