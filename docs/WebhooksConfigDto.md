# DocSpace.API.SDK.Model.WebhooksConfigDto
One webhook subscription of the portal: where deliveries go, which events they cover, and how they have fared.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The identifier of the subscription, which is what `PUT api/2.0/settings/webhook`,  `DELETE api/2.0/settings/webhook/{id}` and the `configId` filter of the delivery log address it by. | 
**Name** | **string** | The label the subscription was given, free text with no meaning to the portal. | [optional] 
**Uri** | **string** | The address every delivery is posted to. The signing secret that lets the receiver verify a delivery is  never part of this answer, so it has to be kept from the moment the subscription was created. | [optional] 
**Enabled** | **bool** | Whether the subscription is delivering. While it is `false` events are dropped rather than queued, so  nothing arrives late after it is switched back on. | [optional] 
**Ssl** | **bool** | Whether the certificate of `uri` is verified before a delivery. While it is `false` a self-signed  certificate is accepted as well. | [optional] 
**Triggers** | **WebhookTrigger** | The events the subscription covers, as the bits of `GET api/2.0/settings/webhook/triggers` added  together. `0` is the catch-all and means every event, not none. | [optional] 
**TargetId** | **string** | The single room or file the subscription is narrowed to, empty for a subscription that covers the whole  portal. It is kept as an opaque value, so both a numeric and a third-party identifier can appear. | [optional] 
**CreatedBy** | [**EmployeeDto**](EmployeeDto.md) | The member who created the subscription, which is also who a non-administrator is limited to seeing. It is  empty for a subscription created by a portal background job. | [optional] 
**CreatedOn** | **DateTime?** | When the subscription was created, in the portal time zone. | [optional] 
**ModifiedBy** | [**EmployeeDto**](EmployeeDto.md) | The member who last changed the subscription, empty while nobody has changed it since it was created. | [optional] 
**ModifiedOn** | **DateTime?** | When it was last changed, in the portal time zone, and empty under the same condition as `modifiedBy`. | [optional] 
**LastFailureOn** | **DateTime?** | When a delivery last failed, in the portal time zone. It is empty for a subscription that has never  failed, and it is not cleared by a later success - compare it with `lastSuccessOn` to see which came last. | [optional] 
**LastFailureContent** | **string** | What the target answered on that failure, truncated, for diagnosing without opening the delivery log. It  is empty when the failure produced no body at all, a timeout for instance. | [optional] 
**LastSuccessOn** | **DateTime?** | When a delivery last succeeded, in the portal time zone, empty for a subscription that has never  delivered. Both this and `lastFailureOn` being empty means nothing has been attempted yet. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

