# DocSpace.API.SDK.Model.DocsCloudTenant
Represents a DocsCloud tenant of a portal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DedicatedResourceExId** | **int** | The external ID of the dedicated resource the tenant is hosted on. | [optional] 
**Alias** | **string** | The tenant alias. | [optional] 
**Name** | **string** | The tenant name. | [optional] 
**ModifiedDate** | **DateTime** | The date and time when the tenant was last modified. | [optional] 
**CustomerId** | **string** | The customer ID. | [optional] 
**CustomerName** | **string** | The customer name. | [optional] 
**EndDate** | **DateTime** | The date and time when the tenant subscription ends. | [optional] 
**ResourceType** | **int** | The resource type. | [optional] 
**IsActive** | **bool** | Whether the tenant is active (the end date is in the future). | [optional] 
**Address** | **string** | The tenant address. | [optional] 
**Payment** | [**DocsCloudPayment**](DocsCloudPayment.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

