# DocSpace.API.SDK.Model.Quota
The quota parameters.  <example>  {    id: 1,    quantity: 50,    wallet: false,    additional: false,    dueDate: 2026-03-31T00:00:00Z,    nextQuantity: 100,    state: Active  }  </example>

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The quota ID. | [optional] 
**Quantity** | **int** | The quota quantity. | [optional] 
**Wallet** | **bool** | The quota applies to the wallet or not | [optional] 
**DueDate** | **DateTime?** | The quota due date. | [optional] 
**NextQuantity** | **int?** | The quota next quantity. | [optional] 
**Additional** | **bool** | Indicates whether the quota is primary or additional. | [optional] 
**NextQuota** | **int?** | The quota ID to switch to at the next period. | [optional] 
**State** | **QuotaState** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

