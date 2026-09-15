# DocSpace.API.SDK.Model.WhiteLabelItemDto
One branding logo slot of the portal: the size it is drawn at, and where its images are served from.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **WhiteLabelLogoType** | Which branding slot this entry describes. `Notification` is part of the type but never appears here: that  logo is derived from the login-page one and used only in letters. | [optional] 
**Name** | **string** | The stable name of the same slot, which is what `GET api/2.0/settings/whitelabel/logos/isdefault` keys its  entries by. It is a name to match on, not a file name. | [optional] 
**Size** | [**WhiteLabelItemSizeDto**](WhiteLabelItemSizeDto.md) | The pixel box the slot is drawn in. Only `width` and `height` carry information here; the resize flags and  offsets alongside them are left at their defaults and say nothing about how an uploaded image is treated. | [optional] 
**Path** | [**WhiteLabelItemPathDto**](WhiteLabelItemPathDto.md) | The absolute URLs to render the slot from, one per theme. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

