# DocSpace.API.SDK.Model.SaveCompanyInfoRequest
The company the installation is branded for, as shown on the About page and in letters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyName** | **string** | The company name. | [optional] 
**Site** | **string** | The company website, as an absolute URL. | [optional] 
**Email** | **string** | The contact email address. | [optional] 
**Address** | **string** | The postal address. | [optional] 
**Phone** | **string** | The contact phone number. | [optional] 
**IsLicensor** | **bool** | Accepted for compatibility with earlier clients and not read: saved details are never those of the licensor, so the server always stores `false`. | [optional] 
**HideAbout** | **bool** | Whether the About page is hidden. | [optional] 
**LastModified** | **DateTime** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

