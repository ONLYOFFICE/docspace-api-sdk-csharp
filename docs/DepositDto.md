# DocSpace.API.SDK.Model.DepositDto
One payment into the portal wallet: when it was made, how much it brought in, how it ended, and whether an  invoice stands behind it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | The identifier of the top-up, which is what `GET api/2.0/portal/payment/customer/deposits/{id}/invoice` takes  to read its invoice. | [optional] 
**Date** | [**ApiDateTime**](ApiDateTime.md) | When the top-up was booked, as an ISO 8601 timestamp that carries its own offset: that of the portal's time  zone, written as `Z` for a portal in UTC - the zone in which `startDate` and `endDate` without an offset are  read. | [optional] 
**Amount** | **double** | The amount that went into the wallet, in `currency`. | [optional] 
**Currency** | **string** | The currency `amount` is expressed in, as a three-letter ISO 4217 code - the accounting currency of the  wallet. | [optional] 
**Status** | **OperationStatus** | How the top-up ended. A pending one is still being settled and may change later, so only a completed one has  actually raised the balance. | [optional] 
**HasInvoice** | **bool** | Whether the billing provider holds an invoice for the payment behind the top-up, which is when  `GET api/2.0/portal/payment/customer/deposits/{id}/invoice` can open it. It is `false` for a top-up whose  payment came without one, and asking for its invoice then fails with 404. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

