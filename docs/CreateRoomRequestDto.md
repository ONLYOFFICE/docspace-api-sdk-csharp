# DocSpace.API.SDK.Model.CreateRoomRequestDto
The parameters of a new room in the Rooms section.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The name of the room. It is trimmed, characters that a folder name cannot hold are replaced with underscores  and the rest is truncated, so the stored title can differ from the one sent; a blank title is rejected. Titles  are not unique, and rooms are told apart by their id. | 
**Quota** | **long?** | The storage the room may take, in bytes. It is accepted only while the per-room quota feature is on for the  portal and must stay inside the portal own limit; leaving it out lets the room follow the portal default. | [optional] 
**Indexing** | **bool?** | Whether the room keeps a manual order of its contents. With it on every file and folder carries a position  that listings follow and that `PUT api/2.0/files/rooms/{id}/reorder` compacts; with it off the contents are  ordered by the sorting of the request. | [optional] 
**DenyDownload** | **bool?** | Whether members without editing rights are stopped from downloading and printing the contents of the room.  They can still open the documents in the editor. | [optional] 
**Lifetime** | [**RoomDataLifetimeDto**](RoomDataLifetimeDto.md) | How long files may stay in the room before they are deleted automatically. The countdown starts when the  setting is saved, and leaving the field out keeps the files forever. | [optional] 
**Watermark** | [**WatermarkRequestDto**](WatermarkRequestDto.md) | The watermark drawn over documents opened in the room. Leaving the field out adds no watermark, and sending it  with the switch turned off removes the one the room has. | [optional] 
**Logo** | [**LogoRequest**](LogoRequest.md) | The picture to use as the room logo, named by the path that `POST api/2.0/files/logos` returned for an image  uploaded beforehand, plus the crop to take from it. Leaving the field out keeps the room on its cover and  colour. | [optional] 
**Tags** | **List&lt;string&gt;** | The labels to attach to the room, by name. Names the portal tag catalogue does not hold yet are added to it,  and `GET api/2.0/files/tags` lists what already exists. | [optional] 
**Color** | **string** | The background colour the room is drawn with while it has no logo, as six hexadecimal digits with no leading  number sign. An empty value restores the default colour of the room type. | [optional] 
**Cover** | **string** | The picture drawn on the room while it has no logo, named by an identifier from  `GET api/2.0/files/rooms/covers`. Any other value is rejected, and an empty value leaves the room without a  cover. | [optional] 
**RoomType** | **RoomType** | What the room is for. It decides which sharing links, roles and form features the room offers, and it cannot  be changed once the room exists, so a room of the wrong kind has to be recreated. | 
**Private** | **bool** | Whether the room is end-to-end encrypted. Its files can then be opened only in the desktop application by  members whose encryption keys are set up, and the flag cannot be changed after the room is created. | [optional] 
**Share** | [**List&lt;FileShareParams&gt;**](FileShareParams.md) | Not implemented on room creation: any non-empty value is rejected, and members are invited afterwards with  `PUT api/2.0/files/rooms/{id}/share`. | [optional] 
**ChatSettings** | [**ChatSettings**](ChatSettings.md) | The model and the prompt an AI room answers with. It belongs to AI rooms only and is rejected for a room of  any other kind. | [optional] 
**SendFormToExternalDB** | **bool?** | For a form filling room, whether the data of every completed submission is also pushed to the external  database configured for the portal. It is what `POST api/2.0/files/rooms/{id}/externaldbsync` re-runs for the  forms already collected. | [optional] 
**SaveFormAsXLSX** | **bool?** | For a form filling room, whether the collected submissions are also gathered into a spreadsheet stored next to  the completed forms. With it off the submissions are kept only as the filled documents themselves. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

