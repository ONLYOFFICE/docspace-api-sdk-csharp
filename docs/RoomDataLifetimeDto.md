# DocSpace.API.SDK.Model.RoomDataLifetimeDto
The rule by which the files of a room are removed once they have been lying in it for too long.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeletePermanently** | **bool** | Decides what happens to a file that has grown too old: it is erased outright, or it is moved to the trash of  the account that created the room, from where it can still be brought back. | [optional] 
**Period** | **RoomDataLifetimePeriod** | The unit the age is counted in. Months and years are counted as calendar ones, so the same number of them  covers a different number of days depending on when the clean-up runs. | [optional] 
**Value** | **int?** | How many periods a file may stay in the room, counted from the moment it was last changed rather than from the  moment the rule was set. Files that are already older than this are removed by the next clean-up. | [optional] 
**Enabled** | **bool?** | Switches the rule on and off. Switching it off erases the rule instead of keeping it aside, so afterwards the  room reports no rule at all and the other three values have to be sent again to bring it back. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

