# DocSpace.Model.AuditEventDto
The audit event parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The audit event ID. | [optional] 
**Date** | [**ApiDateTime**](.md) |  | [optional] 
**User** | **string** | The name of the user who triggered the audit event. | [optional] 
**UserId** | **Guid** | The ID of the user who triggered the audit event. | [optional] 
**Action** | **string** | The audit event action. | [optional] 
**ActionId** | **MessageAction** |  | [optional] 
**Ip** | **string** | The audit event IP. | [optional] 
**Country** | **string** | The audit event country. | [optional] 
**City** | **string** | The audit event city. | [optional] 
**Browser** | **string** | The audit event browser. | [optional] 
**Platform** | **string** | The audit event platform. | [optional] 
**Page** | **string** | The audit event page. | [optional] 
**ActionType** | **ActionType** |  | [optional] 
**Product** | **ProductType** |  | [optional] 
**Module** | **ModuleType** |  | [optional] 
**Target** | **List&lt;string&gt;** | The list of target objects affected by the audit event (e.g., document ID, user account). | [optional] 
**Entries** | [**List&lt;EntryType&gt;**](.md) | The list of audit entry types (e.g., Folder, User, File). | [optional] 
**Context** | **string** | The audit event context. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

