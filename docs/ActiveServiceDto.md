# DocSpace.API.SDK.Model.ActiveServiceDto
Represents an active wallet service (quota) of the current portal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | The name of the service. | [optional] 
**ServiceUnit** | **string** | The unit of measurement for the service. | [optional] 
**Subscription** | **bool** | Indicates whether the service is subscription-based. | [optional] 
**Title** | **string** | The title of the service. | [optional] 
**Limit** | **int?** | The service limit. Populated only for the subscription-based services. | [optional] 
**Used** | **int?** | The current service usage. Populated only for the subscription-based services. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

