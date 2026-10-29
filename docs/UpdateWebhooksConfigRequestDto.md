# DocSpace.API.SDK.Model.UpdateWebhooksConfigRequestDto
The webhook subscription being changed, with the parameters it is to have afterwards.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The label the subscription is listed under. It is for the administrator reading the list and is never sent to  the target; it does not have to be unique. | 
**Uri** | **string** | The address the portal posts the event payload to. It has to be an absolute `http` or `https` address outside  the installation own network, and it is probed before anything is stored: it must answer a HEAD request with  a success code, and a redirect does not count as one. | 
**SecretKey** | **string** | The shared secret the payload signature is computed with, so the receiver can tell a genuine call from a  forged one. It has to satisfy the portal password rules published by  `GET api/2.0/settings/security/password`, and it is never echoed back by any operation. On an update an empty  value keeps the secret already stored. | [optional] 
**Enabled** | **bool** | Whether the subscription delivers at all. While it is off the matching events are dropped rather than queued,  so nothing from that period arrives once it is switched on again. | [optional] 
**Ssl** | **bool** | Whether the target certificate is verified. `true` demands an `https` address with a valid certificate; `false`  delivers without checking the certificate, and is what a plain `http` target needs. | [optional] 
**Triggers** | **WebhookTrigger** | The events the subscription listens for, as a bitmask adding together the `id` values of the entries of `GET  api/2.0/settings/webhook/triggers`. 0 is the catch-all, not none: it stands for every event the  subscription creator's role may receive, not for every event of the portal. | [optional] 
**TargetId** | **string** | The single entity the subscription is narrowed to, by its identifier in the API that owns it. For user events  it is the GUID of a user (`id` of `GET api/2.0/people`), for group events the GUID of a group (`id` of `GET  api/2.0/group`), and either must be one the subscription's creator may see; for file, folder, room and form  events it is the entry ID from the Files API (`id` of `GET api/2.0/files/rooms` or of a folder listing), a  number for the portal's own storage and a string for third-party storage. Leaving it out delivers events  about every entity the subscribed triggers cover. | [optional] 
**Id** | **int** | The subscription to act on, by the `id` that `GET api/2.0/settings/webhook` reports. It travels in the body  rather than in the path, and an id that exists in no portal subscription answers 404. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

