# DocSpace.API.SDK.Model.ActiveServiceDto
One wallet service the portal is running right now, with the allowance it grants where that is counted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | The stable key of the service, which is what `POST api/2.0/portal/payment/servicestate` takes to switch  it off again. | [optional] 
**ServiceUnit** | **string** | What `limit` and `used` count, in the portal language - gigabytes, editor seats, credits. | [optional] 
**Subscription** | **bool** | Whether the service is billed as a standing subscription rather than per unit consumed. Only a  subscription can carry `limit` and `used`. | [optional] 
**Title** | **string** | The service name in the portal language, for printing rather than matching. | [optional] 
**Limit** | **int?** | How much of the service the portal is entitled to. It is empty for a service whose consumption is not  counted this way, which is not the same as a service without a limit. | [optional] 
**Used** | **int?** | How much of that allowance is in use - the editors currently active for the cloud editors, the units  already consumed for disk storage. Empty under the same conditions as `limit`. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

