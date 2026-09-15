# DocSpace.API.SDK.Model.TenantQuotaFeatureDto
One feature a quota switches on, with the limit it grants and how much of that limit is used.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The stable key of the feature - `total_size`, `manager`, `room`, `backup` and so on. It is the value to  branch on, since `title` is prose in the portal language. | [optional] 
**Title** | **string** | The feature described in the portal language, with its limit already substituted into the sentence, so it  can be printed as it is. It is empty when this build ships no wording for the feature. | [optional] 
**Image** | **string** | The feature's icon as SVG markup to render inline - not a URL to fetch. It is filled in only when the  quota comes from the catalogue, and left empty on the quota the portal is actually on, on a feature that  this quota switches off, and on a feature that ships no icon. | [optional] 
**Value** | **Object** |  | [optional] 
**Type** | **string** | How to read `value` and `used`: `size` for bytes, `count` for a number of things, `flag` for a feature  that is merely on or off. | [optional] 
**Used** | [**FeatureUsedDto**](FeatureUsedDto.md) | How much of the limit is already used. It is present only on the quota the portal is actually on, and  only for a feature whose consumption is counted; a guest is shown none of these figures and a plain member  only the one for total size, so an absent value can mean the caller may not see it rather than that  nothing is used. | [optional] 
**PriceTitle** | **string** | What the feature is charged as, in the portal language - for instance the per-unit price of an add-on. It  is filled in only for a feature that costs money on top of the plan. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

