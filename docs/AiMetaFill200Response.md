# DocSpace.API.SDK.Model.AiMetaFill200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DryRun** | **bool** | Whether the values were only proposed (`true`) or written as well. | 
**Metadata** | [**AiEntryMetadata**](AiEntryMetadata.md) | The entry's metadata after the write (or as it stands, with `dryRun`), as `GET api/2.0/files/metadata/{kind}/{id}` returns it. | 
**Filled** | [**List&lt;AiMetaFill200ResponseFilledInner&gt;**](AiMetaFill200ResponseFilledInner.md) | The values written, or proposed with `dryRun`: a typed value for a template field, a string for a custom field. | 
**Unresolved** | [**List&lt;AiMetaFill200ResponseUnresolvedInner&gt;**](AiMetaFill200ResponseUnresolvedInner.md) | The fields left as they were, with the reason for each. | 
**Sources** | [**List&lt;AiMetaFill200ResponseSourcesInner&gt;**](AiMetaFill200ResponseSourcesInner.md) | The documents the values were read from. | 
**Skipped** | [**List&lt;AiMetaGenerate200ResponseSkippedInner&gt;**](AiMetaGenerate200ResponseSkippedInner.md) | The entries that were left out, with the reason for each. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

