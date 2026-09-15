# DocSpace.API.SDK.Model.AuthServiceRequestsDto
One third-party authorization or storage provider and the keys the portal connects to it with.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The provider being configured, by its internal key such as `google` or `box`. Take it from the `name` of  `GET api/2.0/settings/authservice`; it is the only field that selects the provider, and a key this  installation does not know is refused the same way a provider that forbids changes is. | [optional] 
**Title** | **string** | The provider name as it is shown in the interface. It is filled in by the portal when the providers are  listed and is ignored when keys are saved. | [optional] 
**Description** | **string** | A sentence about what connecting the provider gives the portal, shown next to it in the interface. It is  filled in by the portal and ignored when keys are saved. | [optional] 
**Instruction** | **string** | The steps an administrator has to take on the provider side to obtain the keys, shown in the interface. It is  filled in by the portal and ignored when keys are saved. | [optional] 
**CanSet** | **bool** | Whether this provider accepts keys through the API at all. A provider whose keys are fixed by the  installation reports `false`, and saving keys for it is refused; the field is reported by the portal and  ignored on the way in. | [optional] 
**Paid** | **bool** | Whether the provider is a paid option. A paid one can only be connected while the portal plan includes  third-party storage or the installation is licensed as self-hosted; the field is reported by the portal and  ignored on the way in. | [optional] 
**Props** | [**List&lt;AuthKey&gt;**](AuthKey.md) | The credentials the portal authenticates to the provider with, as the name and value pairs the provider  defines. Send the whole set the provider expects: leaving every value empty disconnects it, and a set that  fails the provider validation is cleared rather than stored half-applied. The listing operation reports the  values last saved, and a provider that forbids changes reports none at all. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

