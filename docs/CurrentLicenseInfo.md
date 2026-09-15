# DocSpace.API.SDK.Model.CurrentLicenseInfo
The two facts about the subscription in force that a payment page needs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Trial** | **bool** | Whether the portal is on a trial rather than a paid subscription. A trial expires at `dueDate` and is not  extended by paying - a plan has to be bought instead. | 
**DueDate** | **DateTime** | The day the subscription runs out, with the time of day cut off. The largest value a date can hold means  it never runs out, which is how a free or unlimited plan is expressed. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

