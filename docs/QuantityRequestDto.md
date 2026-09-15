# DocSpace.API.SDK.Model.QuantityRequestDto
The new size of the portal subscription.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quantity** | **Dictionary&lt;string, int&gt;** | The plan and the number of units it is to cover, as a single pair. While the portal is on a priced plan the  key has to be the `name` of that same plan, which `GET api/2.0/portal/payment/quota` reports, because the  subscription is resized rather than swapped; the value is the total the subscription is to have afterwards,  not the difference. Exactly one pair is accepted, and a value that is already in effect is refused with 400. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

