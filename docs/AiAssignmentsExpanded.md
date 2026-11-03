# DocSpace.API.SDK.Model.AiAssignmentsExpanded
The bindings with `expand=profile`: the bound profiles themselves, plus how many profiles the portal has, so a chat can start on this one read.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assignments** | [**Dictionary&lt;string, AiProfile&gt;**](AiProfile.md) | The bound profiles keyed by action type, as `GET api/2.0/ai/profiles/list` describes them. A binding whose profile no longer exists is left out. | 
**ProfilesTotal** | **int** | How many profiles the portal has. | 
**ChatProfilesTotal** | **int** | How many of those profiles can chat; a profile without declared capabilities counts as one that can. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

