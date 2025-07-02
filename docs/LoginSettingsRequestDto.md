# DocSpace.Sdk.Model.LoginSettingsRequestDto
The request parameters for configuring login security and performance settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttemptCount** | **int** | The maximum number of consecutive failed login attempts allowed before triggering account suspension. | [optional] 
**BlockTime** | **int** | The duration (in minutes) for which an account remains suspended after exceeding maximum login attempts. | [optional] 
**CheckPeriod** | **int** | The maximum time (in seconds) allowed for server to process and respond to login requests. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

