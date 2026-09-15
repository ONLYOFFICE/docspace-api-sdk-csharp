# DocSpace.API.SDK.Model.CustomizationConfigDto
How the editor interface is dressed: branding, the buttons that lead back into the portal, and the behaviour of  review, mentions and form submission.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**About** | **bool** | Whether the About entry of the editor menu is shown. | [optional] 
**Customer** | [**CustomerConfigDto**](CustomerConfigDto.md) | The branding of the organization running the portal. It is filled in on a server installation only and is  empty in the cloud. | [optional] 
**Anonymous** | [**AnonymousConfigDto**](AnonymousConfigDto.md) | How an anonymous participant is treated in this session. | [optional] 
**Feedback** | [**FeedbackConfig**](FeedbackConfig.md) | The support link the editor offers behind its feedback button. | [optional] 
**Forcesave** | **bool?** | Whether the editors write intermediate revisions while the document stays open. It is empty when the portal  leaves the decision to the editors themselves. | [optional] 
**Goback** | [**GobackConfig**](GobackConfig.md) | Where the editor returns the user to when they leave the document. It is empty when there is nowhere to go  back to, as in an embedded opening. | [optional] 
**Review** | [**ReviewConfig**](ReviewConfig.md) | How tracked changes are displayed when the document opens; it depends on whether this session may write. | [optional] 
**Logo** | [**LogoConfigDto**](LogoConfigDto.md) | The logo the editor shows, in the variants the current layout and file type need. | [optional] 
**MentionShare** | **bool** | Whether mentioning a user who cannot yet open the document offers to share it with them, instead of silently  notifying nobody. | [optional] 
**SubmitForm** | [**SubmitForm**](SubmitForm.md) | The submit button of a form: whether it is shown and what it says. | [optional] 
**StartFillingForm** | [**StartFillingForm**](StartFillingForm.md) | The button that starts filling out the form. It is empty when this opening offers no such button. | [optional] 
**Ai** | [**AIConfig**](AIConfig.md) | The AI configuration settings. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

