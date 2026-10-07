# DocSpace.API.SDK.Model.CustomColorThemeRequestDto
A colour theme to store.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The id of the custom theme to replace, or an id no stored theme has to add a new one. | [optional] 
**Name** | **string** | Accepted for compatibility with earlier clients and not read: a custom theme is always stored without a name. | [optional] 
**Main** | [**ColorThemeColorsRequestDto**](ColorThemeColorsRequestDto.md) | The accent and button colours of the interface. Left out, a stored theme keeps its own. | [optional] 
**Text** | [**ColorThemeColorsRequestDto**](ColorThemeColorsRequestDto.md) | The colours of the text shown on the accent and on the buttons. Left out, a stored theme keeps its own. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

