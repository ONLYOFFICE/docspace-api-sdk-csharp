# DocSpace.API.SDK.Model.PaymentUrlRequestDto
The plan being bought and the two pages the hosted checkout returns the buyer to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BackUrl** | **string** | The absolute address the hosted checkout page sends the buyer back to when the purchase is abandoned. It has  to be a well-formed URL and is carried into the checkout page as it is given, so it must be reachable by the  buyer rather than by the portal. | 
**SuccessUrl** | **string** | The absolute address the hosted checkout page sends the buyer to once the payment provider accepts the  purchase. Reaching it says the provider took the money, not that the portal has already been switched to the  new plan, so a client that lands here reads the plan back rather than assuming it. | 
**Quantity** | **Dictionary&lt;string, int&gt;** | The plan being bought, as a single pair of the plan name and the number of units of it. The key is the `name`  of a monthly, non-wallet quota from `GET api/2.0/portal/payment/quotas`, and the value is how many  administrators the plan is to cover, which has to be greater than zero. Exactly one pair is accepted; yearly  and wallet products are refused with 400, and wallet services are bought through  `PUT api/2.0/portal/payment/updatewallet` instead. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

