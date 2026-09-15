# DocSpace.API.SDK.Model.CheckConversionRequestDtoInteger
The parameters of one file conversion.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileId** | **int** | The file to convert. It is taken from the route of the operation, so a value sent in the body is overwritten. | [optional] 
**Sync** | **bool** | How to wait for the result: `true` converts inside the request and answers with the finished result, which is  only sensible for small documents, while `false` queues the conversion and answers with an entry to poll. | [optional] 
**StartConvert** | **bool** | Whether the conversion is to be started. It is set by the operation itself, so a value sent in the body is  overwritten. | [optional] 
**@Version** | **int** | The version to convert; 0 or less means the current version. | [optional] 
**Password** | **string** | The password that opens the source document, for a file that is protected by one; anything else may be left  out. | [optional] 
**OutputType** | **string** | The extension of the format to convert into, without the dot, and one the portal can produce from that  source format; left out, the default of the portal for that kind of document is used. | [optional] 
**CreateNewIfExist** | **bool** | Where the result goes when the file has been converted before: `true` creates another file beside the source,  `false` replaces the converted file that already exists. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

