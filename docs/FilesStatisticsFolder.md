# DocSpace.API.SDK.Model.FilesStatisticsFolder
One section of the portal and the space its documents take.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The name of the section as the interface shows it, translated into the language used by the caller, so it  suits display but not matching - which section an entry describes is told by the field that carries it. | [optional] 
**UsedSpace** | **long** | The size of the files kept in the section, in bytes, counting every folder and room inside it; 0 means the  section holds nothing. The counter is brought up to date as an operation finishes, so a reading taken right  after an upload or a delete can still show the previous value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

