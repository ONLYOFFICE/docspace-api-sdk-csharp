# DocSpace.API.SDK.Model.Cron
The request parameters for the time the scheduled backup runs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Period** | **BackupPeriod** | How often the backup runs: `EveryDay`, `EveryWeek` or `EveryMonth`. It defaults to `EveryDay`. | [optional] 
**Hour** | **int** | The hour of the day the backup starts at, from 0 to 23. Minutes cannot be chosen - it always starts  on the hour. | [optional] 
**Day** | **int?** | The day the backup runs on: the day of the week from 1 to 7, Sunday being 1, for `EveryWeek`, and the  day of the month from 1 to 31 for `EveryMonth`. Leave it out for `EveryDay` only - an omitted value is  stored as 0, which neither of the other two periods accepts, so a weekly or monthly schedule sent  without it fails. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

