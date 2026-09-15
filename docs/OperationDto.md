# DocSpace.API.SDK.Model.OperationDto
One movement on the portal wallet: what it was for, who caused it, and how much money it moved.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | [**ApiDateTime**](ApiDateTime.md) | When the movement was booked, in the portal time zone - the same zone the `startDate` and `endDate`  filters are read in, so the two do line up here. | [optional] 
**Service** | **string** | The wallet service the movement belongs to, by its stable key. It is what the `serviceName` filter  matches on, and it is empty for a movement that belongs to no service, such as a top-up. | [optional] 
**Description** | **string** | A one-line summary of the movement in the portal language, already composed from the service and the  quantity - meant to be printed as it is rather than parsed. | [optional] 
**Details** | **string** | The longer explanation of the same movement, where the service recorded one. It is empty for a movement  that has nothing to add to `description`. | [optional] 
**ServiceUnit** | **string** | What `quantity` counts for this service, in the portal language. AI consumption is reported in tokens  here rather than in the AI credits the service is sold in. | [optional] 
**Quantity** | **int** | How many units the movement covers, in the unit named by `serviceUnit`. It is `0` for a movement that  moves money without consuming a service. | [optional] 
**Currency** | **string** | The currency `credit` and `debit` are expressed in, as a three-letter ISO 4217 code. It is the accounting  currency of the wallet, which need not be the currency the subscription is priced in. | [optional] 
**Credit** | **double** | The amount that went into the wallet. It is `0` on a movement that only took money out, so the pair of  `credit` and `debit` is what shows which way the money went; the `credit` and `debit` filters of the  operation select the two directions by exactly this. | [optional] 
**Debit** | **double** | The amount that was taken out of the wallet, `0` on a movement that put money in. | [optional] 
**ParticipantName** | **string** | Who caused the movement, as the billing service records them - an internal name, which is what the  `participantName` filter matches on. Show `participantDisplayName` instead. | [optional] 
**ParticipantDisplayName** | **string** | The same person as their portal display name. It falls back to `participantName` when the name belongs to  no portal account, so it is never empty while `participantName` is filled. | [optional] 
**SourceType** | **string** | What kind of thing an AI operation was run on - an agent, a file, a folder, a room or a form. It is empty  on any movement that is not an AI charge. | [optional] 
**SourceTitle** | **string** | The title that thing had when the operation ran, kept as recorded, so it does not follow a later rename.  Empty under the same conditions as `sourceType`. | [optional] 
**SourceId** | **string** | The identifier of that thing, to look it up in the module it belongs to. Empty under the same conditions  as `sourceType`. | [optional] 
**Type** | **OperationType** | What kind of movement this is - a payment, a charge, a refund, a correction. It is what the `type` filter  matches on, and `Unknown` covers a movement the billing service reported under a kind this build does not  recognise. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

