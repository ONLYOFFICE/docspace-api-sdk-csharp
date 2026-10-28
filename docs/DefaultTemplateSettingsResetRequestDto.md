# DocSpace.API.SDK.Model.DefaultTemplateSettingsResetRequestDto
The extension whose custom blank is dropped in favour of the built-in one.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileExtension** | **string** | The extension whose custom blank is dropped, written in lower case with the leading dot. Only the extensions  the portal's built-in template set covers are accepted, and `GET api/2.0/files/settings/defaulttemplate`  returns exactly that list; an extension outside it leaves the settings unchanged instead of failing. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

