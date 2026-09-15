# DocSpace.API.SDK.Model.EditHistoryDto
One saved revision of a file, as the editing service recorded it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The file the revision belongs to; every entry of one history carries the same value. | [optional] 
**Key** | **string** | The document key of this revision, which the editing service uses to tell the revisions of a file apart and to  reuse the copy it has cached. Hand it back unchanged when asking the editor for this revision. | [optional] 
**@Version** | **int** | The number of the revision, counting up from 1 in the order the revisions were saved. It is the value the  operations that show the changes of a revision or restore it expect. | [optional] 
**VersionGroup** | **int** | Groups the revisions written by one editing session: entries sharing this number were saved while the same  session was open, which is how a client collapses a long list of revisions into the versions a person would  recognise. | [optional] 
**User** | [**EditHistoryAuthor**](EditHistoryAuthor.md) | The account that saved the revision. A revision saved by an account that no longer exists, or through an  anonymous link, is reported as a guest. | [optional] 
**Created** | [**ApiDateTime**](ApiDateTime.md) | When the revision was saved, written with the offset of the portal's time zone rather than as plain UTC. The  times of one history are consistent with each other, so order and display the revisions by them. | [optional] 
**ChangesHistory** | **string** | The change record the editing service stored for this revision, as the raw JSON it was written in, and empty  for a revision the portal has no record for - one uploaded as a whole file, for instance. `changes` is the  same record already parsed. | [optional] 
**Changes** | [**List&lt;EditHistoryChangesWrapper&gt;**](EditHistoryChangesWrapper.md) | The single changes this revision introduced - who made each of them and when - taken from the stored change  record. It comes back empty both for a revision whose changes were never recorded and for one whose record is  in a format the portal no longer reads, so an empty list is not proof that nothing changed. | [optional] 
**ServerVersion** | **string** | The build of the editing service that wrote the change record of this revision, taken from the record itself;  empty when the portal holds no record for the revision. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

