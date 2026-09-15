# DocSpace.API.SDK.Model.WebItemsSecurityRequestsDto
The modules switched on or off together, one entry per module.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**List&lt;ItemKeyValuePairStringBoolean&gt;**](ItemKeyValuePairStringBoolean.md) | The modules to switch, each entry pairing a module GUID as its `key` with the new enabled flag as its  `value`. A key that is not a GUID fails the whole request as invalid, and a module listed twice is applied  once, from its first entry. No allow-list travels here: switching a product module on restores the users and  groups it was last restricted to, and everything else is stored as a plain allow or deny for everyone. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

