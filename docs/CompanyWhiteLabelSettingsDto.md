# DocSpace.API.SDK.Model.CompanyWhiteLabelSettingsDto
The vendor details the About page and the notification letters print, shared by the whole installation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyName** | **string** | The vendor name the About page shows and the letters sign off with. Until details are saved it holds  whatever the installation ships as its built-in vendor, and it is empty on an installation that ships none. | 
**Site** | **string** | The address the vendor name links to, as an absolute URL with its scheme. Empty under the same conditions  as `companyName`. | 
**Email** | **string** | The mailbox the About page offers for reaching the vendor. It is not the portal's own support address, and  it is empty under the same conditions as `companyName`. | 
**Address** | **string** | The postal address of the vendor as one free-form line, in the shape it was saved in - no structure is  imposed on it. | 
**Phone** | **string** | The telephone number of the vendor in the shape it was saved in, with no dialling format enforced. | 
**IsLicensor** | **bool** | Whether these details are those of the licensor of the product itself rather than of a reseller. Saving  through `POST api/2.0/settings/rebranding/company` always clears it, so only details that came with the  installation can report `true`. | 
**HideAbout** | **bool** | Whether the About page is hidden from the interface. A plan that does not include branding cannot switch it  on: the value is stored as `false` in that case, so it can come back different from what was saved. | 
**IsDefault** | **bool** | Whether every field above still matches the installation's built-in vendor details. It turns `false` as  soon as one of them is saved differently and `true` again after  `DELETE api/2.0/settings/rebranding/company`. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

