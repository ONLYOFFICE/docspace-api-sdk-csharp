# DocSpace.API.SDK.Model.ConvertFileRequestDto
What to convert, where to keep the result, and the parameters the document service is handed. Everything below the  first two fields is the contract of the document service itself, named and shaped exactly as it names it, so that  the portal passes the request on rather than translating it. What the portal can read off the file - its format,  its name and the key of its revision - is not asked for and cannot be overridden.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileId** | **int** | The id of the portal file to convert, as reported by a folder listing such as `GET api/2.0/files/{folderId}`. | 
**FolderId** | **int?** | The id of the folder to save the converted file in, as reported by a folder listing such as  `GET api/2.0/files/{folderId}`. | [optional] 
**CodePage** | **int?** | The encoding of a csv or txt source, as a code page number: 1251 for Cyrillic, 65001 for UTF-8, and so on.  Leaving it out lets the document service guess, which garbles non-latin text. | [optional] 
**Delimiter** | **int?** | The character separating the values of a csv source: 0 - none, 1 - tab, 2 - semicolon, 3 - colon, 4 - comma,  5 - space. | [optional] 
**DocumentLayout** | [**ConvertDocumentLayoutRequest**](ConvertDocumentLayoutRequest.md) | The layout of forms printed as pdf documents or images. | [optional] 
**DocumentRenderer** | [**ConvertDocumentRendererRequest**](ConvertDocumentRendererRequest.md) | How the text of a pdf, xps or oxps source is read back. | [optional] 
**Outputtype** | **string** | The extension of the format to convert to, without the dot. The formats a source can become are listed under  `extsConvertible` in `GET api/2.0/files/settings`, keyed by the source extension, both with a leading dot there. | 
**Password** | **string** | The password of the source document, for a document that is protected with one. | [optional] 
**Region** | **string** | The culture code whose currency, date and time formats a spreadsheet converted to PDF is shown in. | [optional] 
**Thumbnail** | [**ConvertThumbnailRequest**](ConvertThumbnailRequest.md) | How a thumbnail is fitted, when the target format is an image. | [optional] 
**SpreadsheetLayout** | [**ConvertSpreadsheetLayoutRequest**](ConvertSpreadsheetLayoutRequest.md) | How a spreadsheet is laid out on the page, when it is converted to PDF. | [optional] 
**Pdf** | [**ConvertPdfRequest**](ConvertPdfRequest.md) | The PDF settings, used when the target format is PDF. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

