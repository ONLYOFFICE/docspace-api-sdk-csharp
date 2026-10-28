# DocSpace.API.SDK.Model.ConvertDocumentLayoutRequest
The layout of forms printed as pdf documents or images.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DrawPlaceHolders** | **bool?** | Whether an empty form field shows its placeholder text in the result; false leaves it blank. | [optional] 
**DrawFormHighlight** | **bool?** | Whether form fields keep their highlight colour in the result; false draws them without it. | [optional] 
**IsPrint** | **bool?** | Whether the print mode is turned on. It only applies to a docx converted into pdf: with the print mode off  the highlight flag does nothing and the placeholder flag saves the forms in the pdf. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

