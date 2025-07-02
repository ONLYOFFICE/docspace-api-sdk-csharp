# DocSpace.Sdk.Model.DbTenant
The database tenant parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The tenant ID. | [optional] 
**Name** | **string** | The tenant name. | [optional] 
**Alias** | **string** | The tenant alias. | [optional] 
**MappedDomain** | **string** | Mapped domain | [optional] 
**VarVersion** | **int** | The tenant version. | [optional] 
**VersionChanged** | **DateTime?** | The Version_changed field. | [optional] 
**VersionChanged** | **DateTime** | The date and time when the version was changed. | [optional] 
**Language** | **string** | The tenant language. | [optional] 
**VarTimeZone** | **string** | The tenant time zone. | [optional] 
**TrustedDomainsRaw** | **string** | The tenant trusted domains raw. | [optional] 
**TrustedDomainsEnabled** | **TenantTrustedDomainsType** |  | [optional] 
**Status** | **TenantStatus** |  | [optional] 
**StatusChanged** | **DateTime?** | The date and time when the tenant status was changed. | [optional] 
**StatusChangedHack** | **DateTime** | The hacked date and time when the tenant status was changed. | [optional] 
**CreationDateTime** | **DateTime** | The tenant creation date. | [optional] 
**OwnerId** | **Guid?** | The tenant owner ID. | [optional] 
**PaymentId** | **string** | The tenant payment ID. | [optional] 
**Industry** | **TenantIndustry** |  | [optional] 
**LastModified** | **DateTime** | The date and time when the tenant was last modified. | [optional] 
**Calls** | **bool** | Specifies if the calls are available for the current tenant or not. | [optional] 
**Partner** | [**DbTenantPartner**](DbTenantPartner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

