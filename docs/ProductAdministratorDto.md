# DocSpace.API.SDK.Model.ProductAdministratorDto
Whether one user administers one portal module, echoing back the pair that was asked about.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **Guid** | The module the verdict is about, echoed from the request. The all-zero GUID stands for the portal as a  whole rather than for any single module. | 
**UserId** | **Guid** | The user the verdict is about, echoed from the request unchanged - it is not checked for existing. | 
**Administrator** | **bool** | Whether that user administers that module. It is `true` for a DocSpace administrator whatever the module,  since the portal-wide role covers every one of them. A `false` can also mean the identifiers name no user  or no module at all, so it is not proof that the user exists, and it says nothing about whether the module  is enabled for the portal - `GET api/2.0/settings/security/{id}` reports that. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

