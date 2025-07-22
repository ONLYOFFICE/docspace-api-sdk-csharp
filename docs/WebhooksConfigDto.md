# DocSpace.API.SDK.Model.WebhooksConfigDto
The webhook configuration parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The webhook ID. | [optional] 
**Name** | **string** | The webhook name. | [optional] 
**Uri** | **string** | The webhook URI. | [optional] 
**Enabled** | **bool** | Specifies if the webhooks are enabled or not. | [optional] 
**Ssl** | **bool** | The webhook SSL verification (enabled or not). | [optional] 
**Triggers** | **WebhookTrigger** |  | [optional] 
**TargetId** | **string** | The webhook target ID. | [optional] 
**CreatedBy** | [**EmployeeDto**](EmployeeDto.md) |  | [optional] 
**CreatedOn** | **DateTime?** | The date and time when the webhook was created. | [optional] 
**ModifiedBy** | [**EmployeeDto**](EmployeeDto.md) |  | [optional] 
**ModifiedOn** | **DateTime?** | The date and time when the webhook was modified. | [optional] 
**LastFailureOn** | **DateTime?** | The date and time of the webhook last failure. | [optional] 
**LastFailureContent** | **string** | The webhook last failure content. | [optional] 
**LastSuccessOn** | **DateTime?** | The date and time of the webhook last success. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

