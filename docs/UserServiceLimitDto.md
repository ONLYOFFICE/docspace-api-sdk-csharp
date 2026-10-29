# DocSpace.API.SDK.Model.UserServiceLimitDto
The spending limit on the AI services in force for one user: the user's personal limit, or else the limit for every  user, together with the money the user spent against it in the current period.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The service limit ID, used to read, change, switch off or delete the limit through the  `api/2.0/portal/payment/servicelimit` operations. For the limit for every user it is the same for all users. | [optional] 
**Scope** | **ServiceLimitScope** | Whether the limit is the user's own (`Custom`) or the limit for every user (`Global`) the user falls back to. | [optional] 
**AmountValue** | **double?** | The most money the AI services may cost the user per period, in `currency`. It is the only threshold a limit on  the AI services has: their services count in different units, so a threshold on a quantity is refused for them. | [optional] 
**AmountConsumed** | **double** | The money the AI services cost the user in the current period, in `currency`; 0 when nothing was spent yet,  including a user who has never used the AI services. | [optional] 
**Currency** | **string** | The currency `amountValue` and `amountConsumed` are expressed in; null when the limit has no money threshold. | [optional] 
**Period** | **ServiceLimitPeriod** | The window the threshold applies to. It resets at the start of the next day, week or month in UTC (a week on  Monday), not a fixed time after the first charge; a lifetime limit never resets. | [optional] 
**PeriodEnd** | **DateTime?** | The moment the current period ends and the spending starts over from zero, in UTC. Null for a lifetime limit,  which never resets. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

