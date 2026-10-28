# DocSpace.API.SDK.Model.ConvertSpreadsheetLayoutRequest
How a spreadsheet converted to PDF is laid out on the page. A field left out takes the document service default.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IgnorePrintArea** | **bool?** | Whether the print area chosen in the spreadsheet is ignored; false converts only that area. | [optional] 
**Orientation** | **string** | The page orientation of the output PDF file: portrait or landscape. | [optional] 
**FitToHeight** | **int?** | The number of pages the converted area is fitted into in height; 0 does not fit it. | [optional] 
**Scale** | **int?** | The scale of the output PDF file, in percent. | [optional] 
**FitToWidth** | **int?** | The number of pages the converted area is fitted into in width; 0 does not fit it. | [optional] 
**Headings** | **bool?** | Whether the row and column headings are printed in the output PDF file. | [optional] 
**GridLines** | **bool?** | Whether the grid lines are printed in the output PDF file. | [optional] 
**Margins** | [**ConvertSpreadsheetMarginsRequest**](ConvertSpreadsheetMarginsRequest.md) | The margins of the output PDF file. | [optional] 
**PageSize** | [**ConvertSpreadsheetPageSizeRequest**](ConvertSpreadsheetPageSizeRequest.md) | The page size of the output PDF file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

