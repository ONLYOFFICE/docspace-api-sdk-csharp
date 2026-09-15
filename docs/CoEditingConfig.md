# DocSpace.API.SDK.Model.CoEditingConfig
How co-editing is preset when the document opens, and whether the user may switch it afterwards.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Change** | **bool** | Whether the user may switch between the two co-editing modes from the editor interface, or is held to the one  the portal preset. | [optional] 
**Fast** | **bool** | Whether other participants see each change as it is typed. Left off, changes are exchanged only when a  participant saves, and the paragraph being edited is locked for the others meanwhile. | [optional] 
**Mode** | **CoEditingConfigMode** | The mode the two settings above amount to, as the editors name it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

