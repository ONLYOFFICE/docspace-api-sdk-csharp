# DocSpace.API.SDK.Model.LoginSettingsRequestDto
The brute-force protection of the sign-in form: how many failures, over how long, cost how long a block.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttemptCount** | **int** | How many failed sign-in attempts inside one window are tolerated before the offender is blocked. Attempts are  counted per user name and client address together, so one member being blocked leaves the rest of the portal  signing in normally. | [optional] 
**BlockTime** | **int** | How long, in seconds, a blocked user name and address pair stays refused. While the block lasts the sign-in  is refused even when the password is finally correct. | [optional] 
**CheckPeriod** | **int** | The length, in seconds, of the rolling window the failed attempts are counted over. A wider window makes the  same `attemptCount` stricter, because failures further apart still add up. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

