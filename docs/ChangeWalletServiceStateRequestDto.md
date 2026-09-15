# DocSpace.API.SDK.Model.ChangeWalletServiceStateRequestDto
Which wallet service is switched, and which way.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **TenantWalletService** | The service being switched, given by its catalogue name. Switching it on only makes it available to the  portal; its units are still bought with `PUT api/2.0/portal/payment/updatewallet`. | [optional] 
**Enabled** | **bool** | Which way the service is switched: `true` makes it available to the portal, `false` withdraws it. Setting the  state the service already has changes nothing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

