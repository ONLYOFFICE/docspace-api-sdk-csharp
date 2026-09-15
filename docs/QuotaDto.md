# DocSpace.API.SDK.Model.QuotaDto
A quota - a plan, an add-on or a wallet service - with its price, the features it switches on and their limits.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The identifier of the quota, which is what the tariff reports as a quota `id` and what a purchase names.  A negative value belongs to a built-in quota rather than one on the price list. | 
**Title** | **string** | The quota name in the portal language, for printing rather than matching. It is empty when this build  ships no wording for the quota, which is normal for a quota that is not on the public price list. | [optional] 
**Price** | [**PriceDto**](PriceDto.md) | What the quota costs, in the currency resolved for the request. Its `value` is empty for a quota that is  not sold for money, which is what `free`, `trial` and `nonProfit` describe. | 
**NonProfit** | **bool** | Whether this is the non-profit quota, which is granted rather than bought. A portal on it cannot buy any  other plan, so a catalogue asked for plans returns this one alone. | 
**Free** | **bool** | Whether this is the free quota a portal falls back to when nothing is paid for. It has no end date and  the tightest limits of any quota. | 
**Trial** | **bool** | Whether this is the trial quota, which grants the paid limits for a while and then expires. A trial is not  extended by paying - a plan has to be bought instead. | 
**Features** | [**List&lt;TenantQuotaFeatureDto&gt;**](TenantQuotaFeatureDto.md) | The features the quota switches on, each with the limit it grants and, on the quota the portal is  actually on, how much of that limit is already used. A feature that is absent is off, so the list is the  whole truth about what the quota includes. | 
**UsersQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) | The per-member storage allowance an administrator has set on top of the quota, and whether it is applied  at all. It describes the live portal rather than this quota, so every entry of a catalogue listing repeats  the same values, and it is empty unless the portal is a server installation or its plan includes  statistics. | [optional] 
**RoomsQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) | The same kind of per-room storage override, filled in and read the same way as `usersQuota`. | [optional] 
**AiAgentsQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) | The same kind of per-agent storage override for AI agents, filled in and read the same way as  `usersQuota`. | [optional] 
**TenantCustomQuota** | [**TenantQuotaSettings**](TenantQuotaSettings.md) | The storage allowance an administrator has set for the portal as a whole, which caps it below what the  quota grants. Filled in under the same conditions as `usersQuota`. | [optional] 
**DueDate** | **DateTime?** | When the quota runs out, in UTC. It is empty on a quota from the catalogue, which has no date until it is  bought, and on a quota that never expires. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

