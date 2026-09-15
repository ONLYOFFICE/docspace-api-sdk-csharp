# DocSpace.API.SDK.Model.CronParams
The time a scheduled backup runs at.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Period** | **BackupPeriod** | How often the backup runs: 0 for every day, 1 for every week and 2 for every month. | [optional] 
**Hour** | **int** | The hour of the day the backup starts at, from 0 to 23. | [optional] 
**Day** | **int** | The day the backup runs on: the day of the week from 1 to 7, Sunday being 1, for a weekly schedule,  and the day of the month from 1 to 31 for a monthly one. It is 0 for a daily schedule. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

