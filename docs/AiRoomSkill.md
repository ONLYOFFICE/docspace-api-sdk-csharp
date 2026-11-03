# DocSpace.API.SDK.Model.AiRoomSkill
A skill of an Instructions room: the frontmatter of one Markdown skill file. `name` and `description` are what the model is shown; the body is read through `GET api/2.0/ai/context/get-room-skill`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The skill's ID, as `GET api/2.0/ai/context/get-room-skill` takes it. | 
**Name** | **string** | The skill's name, from its frontmatter. | 
**Description** | **string** | What the skill is for, from its frontmatter; empty when it declares none. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

