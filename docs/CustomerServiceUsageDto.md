# DocSpace.API.SDK.Model.CustomerServiceUsageDto
What one wallet service was consumed and cost over the requested period, added up rather than listed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Service** | **string** | The stable key of the service, which is what the `serviceName` filter of this operation matches on and  what `GET api/2.0/portal/payment/walletservice` looks a service up by. | [optional] 
**Title** | **string** | The service name in the portal language, for printing rather than matching. | [optional] 
**ServiceUnit** | **string** | What `totalQuantity` counts, in the portal language. AI consumption is reported in tokens here rather  than in the AI credits the service is sold in, so it does not line up with the price list. | [optional] 
**Currency** | **string** | The currency `totalAmount` and `price` are expressed in, as a three-letter ISO 4217 code. | [optional] 
**TotalQuantity** | **int** | How many units of the service were consumed over the period, in the unit named by `serviceUnit`. | [optional] 
**TotalAmount** | **double** | What that consumption cost over the period. It is what was actually charged, so it can differ from  `price` times `totalQuantity` when the price changed inside the period. | [optional] 
**OperationCount** | **int** | How many separate charges the total was added up from. The charges themselves are in  `GET api/2.0/portal/payment/customer/operations`. | [optional] 
**Price** | **double** | What one unit of the service costs today, not what it cost during the period. It is `0` when the service  is no longer on the installation's price list. | [optional] 
**Subscription** | **bool** | Whether the service is billed as a standing subscription rather than per unit consumed. It is derived  from today's price list, so it describes the service as it is sold now. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

