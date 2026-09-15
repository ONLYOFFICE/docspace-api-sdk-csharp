# DocSpace.API.SDK.Model.AutoCleanUpData
The trash auto-clearing setting of an account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsAutoCleanUp** | **bool** | Whether the trash of the account is cleared automatically. While it is false nothing is removed by the portal  and the interval below is kept but unused. | [optional] 
**Gap** | **DateToAutoCleanUp** | How long an item may stay in the trash before it is removed for good. It is reported even while clearing is  off, and it is what the moment in the `autoDelete` field of a trashed entry is computed from. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

