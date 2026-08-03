# DocSpace.API.SDK.Model.NewAiOpenOrCreateInput
Input for  {@link  ThreadsEngine.openOrCreate } : open an existing thread if `threadId` is given, otherwise create a new one with an auto-generated title derived from `firstMessage`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThreadId** | **string** |  | [optional] 
**Profile** | [**NewAiProfile**](NewAiProfile.md) |  | 
**ProfileId** | **string** |  | 
**FirstMessage** | [**NewAiThreadMessageLike**](NewAiThreadMessageLike.md) |  | 
**EntityId** | **string** | Opaque scope token persisted on a freshly created thread. Ignored when `threadId` is provided (the existing thread keeps its scope). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

