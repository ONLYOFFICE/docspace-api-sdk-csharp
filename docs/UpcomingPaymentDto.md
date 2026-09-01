# DocSpace.API.SDK.Model.UpcomingPaymentDto
The upcoming payment parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The quota ID. | [optional] 
**Name** | **string** | The quota name. | [optional] 
**Title** | **string** | The quota title. | [optional] 
**UnitOfMeasure** | **string** | The quota unit of measure. | [optional] 
**Quantity** | **int** | The quantity that will be charged (the next quantity if set, otherwise the current quantity). | [optional] 
**Wallet** | **bool** | The quota applies to the wallet or not. | [optional] 
**DueDate** | **DateTime?** | The due date of the upcoming payment in the portal time zone. | [optional] 
**Amount** | **double** | The amount that will be charged (unit price multiplied by the quantity). | [optional] 
**Currency** | **string** | The three-character ISO 4217 currency symbol of the amount. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

