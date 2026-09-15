# DocSpace.API.SDK.Model.ChunkedUploadSessionResponseWrapperInteger
The reserved chunked upload wrapped in the envelope the two older session operations answer with.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | Always true in a body that reaches the caller, because a call that does not succeed answers with an error  status and no body at all. It cannot be used to tell a refusal from a success. | [optional] 
**Data** | [**ChunkedUploadSessionResponseInteger**](ChunkedUploadSessionResponseInteger.md) | The reserved upload itself, in the same shape the newer session operations answer with directly. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

