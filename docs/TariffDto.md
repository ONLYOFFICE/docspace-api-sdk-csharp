# DocSpace.API.SDK.Model.TariffDto
The subscription this portal runs on: its state, the end of the current period, and the quotas it is made of.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OpenSource** | **bool?** | Whether the installation runs the open-source build, which has no paid plan at all. This flag and the two  below describe the build rather than the subscription, and all three are left empty for a caller without  the portal-settings right. | [optional] 
**Enterprise** | **bool?** | Whether the installation runs on an Enterprise licence file, which is what makes the licence operations  under `api/2.0/settings/license` usable. | [optional] 
**Developer** | **bool?** | Whether the installation runs on a Developer licence, an Enterprise licence meant for embedding rather  than for production use. | [optional] 
**Id** | **int** | The identifier of the subscription record itself, for quoting when a charge has to be traced. It is filled  in for a caller with the portal-settings right only, and nothing accepts it as an argument. | [optional] 
**State** | **TariffState** | How the subscription stands: on trial, paid, inside the grace period that follows the due date, or unpaid.  It is the one field every caller gets, whatever their role, so a client can warn about payment without  needing administrator rights. | [optional] 
**DueDate** | [**ApiDateTime**](ApiDateTime.md) | When the current period ends, in the portal time zone. It is filled in for a room or DocSpace  administrator only, and set to the largest value a date can hold for a subscription that never ends. | [optional] 
**DelayDueDate** | [**ApiDateTime**](ApiDateTime.md) | When the grace period after `dueDate` runs out and the portal is cut off, in the portal time zone. Filled  in under the same conditions as `dueDate`, and equal to it when the plan grants no grace period. | [optional] 
**LicenseDate** | [**ApiDateTime**](ApiDateTime.md) | When the licence file behind the subscription was issued, in the portal time zone. It is meaningful on a  server installation and filled in for a caller with the portal-settings right only. | [optional] 
**CustomerId** | **string** | The account in the billing system the subscription is charged to, empty for a portal that has never been  billed. Filled in for a caller with the portal-settings right only. | [optional] 
**Quotas** | [**List&lt;TariffQuotaDto&gt;**](TariffQuotaDto.md) | The quotas the subscription is made of - the plan itself and its add-ons - with the overdue ones listed  alongside the current ones, so an entry here is not proof that it is still being paid for; read each  entry's own `state` for that. Filled in for a caller with the portal-settings right only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

