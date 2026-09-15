# DocSpace.API.SDK.Model.ConversationResultDto
The progress of one file conversion, together with the converted file once it exists.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the conversion entry. The portal leaves it empty for file conversions, so a caller follows  its own conversion by the file it queued rather than by this value. | 
**Operation** | **FileOperationType** | Tells which kind of file operation the entry describes, so that a conversion can be told apart from the copy,  move and download entries that share this envelope. A conversion entry reports the conversion type. | 
**Progress** | **int** | How far the conversion has got, counted in percent from 0 while it is only queued to 100 once it is over -  whether it ended with a converted file or with an error. 100 is the value a polling caller waits for. | 
**Source** | **string** | Describes what is being converted: the identifier of the source file, the version that was taken and whether  an existing result may be overwritten, packed as a JSON object inside a string. It is what identifies the  entry when several conversions of the same caller are in flight. | [optional] 
**Result** | **Object** |  | [optional] 
**Error** | **string** | The reason the conversion stopped, in the language of the caller, and empty while it is running and after it  has succeeded. `progress` reaches 100 for a failure as well, so this field is what separates a converted file  from a broken conversion; a conversion still unfinished after ten minutes ends with a timeout reported here. | [optional] 
**Processed** | **string** | Reports whether the portal has taken the entry as far as it goes: `1` once the conversion has finished or  failed, and empty while it is still queued or still being converted. It is the bookkeeping of the conversion  queue rather than a result - what happened is in `progress`, `error` and `result`. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

