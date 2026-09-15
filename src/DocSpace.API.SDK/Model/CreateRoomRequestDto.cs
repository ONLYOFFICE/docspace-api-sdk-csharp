// (c) Copyright Ascensio System SIA 2026
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The parameters of a new room in the Rooms section.
    /// </summary>
    [DataContract(Name = "CreateRoomRequestDto")]
    public partial class CreateRoomRequestDto : IValidatableObject
    {

        /// <summary>
        /// What the room is for. It decides which sharing links, roles and form features the room offers, and it cannot  be changed once the room exists, so a room of the wrong kind has to be recreated.
        /// </summary>
        [DataMember(Name = "roomType", IsRequired = true, EmitDefaultValue = true)]
        public RoomType RoomType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoomRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRoomRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoomRequestDto" /> class.
        /// </summary>
        /// <param name="title">The name of the room. It is trimmed, characters that a folder name cannot hold are replaced with underscores  and the rest is truncated, so the stored title can differ from the one sent; a blank title is rejected. Titles  are not unique, and rooms are told apart by their id. (required).</param>
        /// <param name="quota">The storage the room may take, in bytes. It is accepted only while the per-room quota feature is on for the  portal and must stay inside the portal own limit; leaving it out lets the room follow the portal default..</param>
        /// <param name="indexing">Whether the room keeps a manual order of its contents. With it on every file and folder carries a position  that listings follow and that &#x60;PUT api/2.0/files/rooms/{id}/reorder&#x60; compacts; with it off the contents are  ordered by the sorting of the request..</param>
        /// <param name="denyDownload">Whether members without editing rights are stopped from downloading and printing the contents of the room.  They can still open the documents in the editor..</param>
        /// <param name="lifetime">How long files may stay in the room before they are deleted automatically. The countdown starts when the  setting is saved, and leaving the field out keeps the files forever..</param>
        /// <param name="watermark">The watermark drawn over documents opened in the room. Leaving the field out adds no watermark, and sending it  with the switch turned off removes the one the room has..</param>
        /// <param name="logo">The picture to use as the room logo, named by the path that &#x60;POST api/2.0/files/logos&#x60; returned for an image  uploaded beforehand, plus the crop to take from it. Leaving the field out keeps the room on its cover and  colour..</param>
        /// <param name="tags">The labels to attach to the room, by name. Names the portal tag catalogue does not hold yet are added to it,  and &#x60;GET api/2.0/files/tags&#x60; lists what already exists..</param>
        /// <param name="color">The background colour the room is drawn with while it has no logo, as six hexadecimal digits with no leading  number sign. An empty value restores the default colour of the room type..</param>
        /// <param name="cover">The picture drawn on the room while it has no logo, named by an identifier from  &#x60;GET api/2.0/files/rooms/covers&#x60;. Any other value is rejected, and an empty value leaves the room without a  cover..</param>
        /// <param name="roomType">What the room is for. It decides which sharing links, roles and form features the room offers, and it cannot  be changed once the room exists, so a room of the wrong kind has to be recreated. (required).</param>
        /// <param name="private">Whether the room is end-to-end encrypted. Its files can then be opened only in the desktop application by  members whose encryption keys are set up, and the flag cannot be changed after the room is created..</param>
        /// <param name="share">Not implemented on room creation: any non-empty value is rejected, and members are invited afterwards with  &#x60;PUT api/2.0/files/rooms/{id}/share&#x60;..</param>
        /// <param name="chatSettings">The model and the prompt an AI room answers with. It belongs to AI rooms only and is rejected for a room of  any other kind..</param>
        /// <param name="sendFormToExternalDB">For a form filling room, whether the data of every completed submission is also pushed to the external  database configured for the portal. It is what &#x60;POST api/2.0/files/rooms/{id}/externaldbsync&#x60; re-runs for the  forms already collected..</param>
        /// <param name="saveFormAsXLSX">For a form filling room, whether the collected submissions are also gathered into a spreadsheet stored next to  the completed forms. With it off the submissions are kept only as the filled documents themselves..</param>
        public CreateRoomRequestDto(string title = default, long? quota = default, bool? indexing = default, bool? denyDownload = default, RoomDataLifetimeDto lifetime = default, WatermarkRequestDto watermark = default, LogoRequest logo = default, List<string> tags = default, string color = default, string cover = default, RoomType roomType = default, bool @private = default, List<FileShareParams> share = default, ChatSettings chatSettings = default, bool? sendFormToExternalDB = default, bool? saveFormAsXLSX = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateRoomRequestDto and cannot be null");
            }
            this.Title = title;
            this.RoomType = roomType;
            this.Quota = quota;
            this.Indexing = indexing;
            this.DenyDownload = denyDownload;
            this.Lifetime = lifetime;
            this.Watermark = watermark;
            this.Logo = logo;
            this.Tags = tags;
            this.Color = color;
            this.Cover = cover;
            this.Private = @private;
            this.Share = share;
            this.ChatSettings = chatSettings;
            this.SendFormToExternalDB = sendFormToExternalDB;
            this.SaveFormAsXLSX = saveFormAsXLSX;
        }

        /// <summary>
        /// The name of the room. It is trimmed, characters that a folder name cannot hold are replaced with underscores  and the rest is truncated, so the stored title can differ from the one sent; a blank title is rejected. Titles  are not unique, and rooms are told apart by their id.
        /// </summary>
        /// <example>Project Alpha</example>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The storage the room may take, in bytes. It is accepted only while the per-room quota feature is on for the  portal and must stay inside the portal own limit; leaving it out lets the room follow the portal default.
        /// </summary>
        /// <example>1073741824</example>
        [DataMember(Name = "quota", EmitDefaultValue = true)]
        public long? Quota { get; set; }

        /// <summary>
        /// Whether the room keeps a manual order of its contents. With it on every file and folder carries a position  that listings follow and that &#x60;PUT api/2.0/files/rooms/{id}/reorder&#x60; compacts; with it off the contents are  ordered by the sorting of the request.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool? Indexing { get; set; }

        /// <summary>
        /// Whether members without editing rights are stopped from downloading and printing the contents of the room.  They can still open the documents in the editor.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool? DenyDownload { get; set; }

        /// <summary>
        /// How long files may stay in the room before they are deleted automatically. The countdown starts when the  setting is saved, and leaving the field out keeps the files forever.
        /// </summary>
        [DataMember(Name = "lifetime", EmitDefaultValue = false)]
        public RoomDataLifetimeDto Lifetime { get; set; }

        /// <summary>
        /// The watermark drawn over documents opened in the room. Leaving the field out adds no watermark, and sending it  with the switch turned off removes the one the room has.
        /// </summary>
        [DataMember(Name = "watermark", EmitDefaultValue = false)]
        public WatermarkRequestDto Watermark { get; set; }

        /// <summary>
        /// The picture to use as the room logo, named by the path that &#x60;POST api/2.0/files/logos&#x60; returned for an image  uploaded beforehand, plus the crop to take from it. Leaving the field out keeps the room on its cover and  colour.
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoRequest Logo { get; set; }

        /// <summary>
        /// The labels to attach to the room, by name. Names the portal tag catalogue does not hold yet are added to it,  and &#x60;GET api/2.0/files/tags&#x60; lists what already exists.
        /// </summary>
        /// <example>["Finance","2026"]</example>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The background colour the room is drawn with while it has no logo, as six hexadecimal digits with no leading  number sign. An empty value restores the default colour of the room type.
        /// </summary>
        /// <example>FF5733</example>
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// The picture drawn on the room while it has no logo, named by an identifier from  &#x60;GET api/2.0/files/rooms/covers&#x60;. Any other value is rejected, and an empty value leaves the room without a  cover.
        /// </summary>
        /// <example>bookmark</example>
        [DataMember(Name = "cover", EmitDefaultValue = true)]
        public string Cover { get; set; }

        /// <summary>
        /// Whether the room is end-to-end encrypted. Its files can then be opened only in the desktop application by  members whose encryption keys are set up, and the flag cannot be changed after the room is created.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private { get; set; }

        /// <summary>
        /// Not implemented on room creation: any non-empty value is rejected, and members are invited afterwards with  &#x60;PUT api/2.0/files/rooms/{id}/share&#x60;.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "share", EmitDefaultValue = true)]
        public List<FileShareParams> Share { get; set; }

        /// <summary>
        /// The model and the prompt an AI room answers with. It belongs to AI rooms only and is rejected for a room of  any other kind.
        /// </summary>
        [DataMember(Name = "chatSettings", EmitDefaultValue = false)]
        public ChatSettings ChatSettings { get; set; }

        /// <summary>
        /// For a form filling room, whether the data of every completed submission is also pushed to the external  database configured for the portal. It is what &#x60;POST api/2.0/files/rooms/{id}/externaldbsync&#x60; re-runs for the  forms already collected.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "sendFormToExternalDB", EmitDefaultValue = true)]
        public bool? SendFormToExternalDB { get; set; }

        /// <summary>
        /// For a form filling room, whether the collected submissions are also gathered into a spreadsheet stored next to  the completed forms. With it off the submissions are kept only as the filled documents themselves.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "saveFormAsXLSX", EmitDefaultValue = true)]
        public bool? SaveFormAsXLSX { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRoomRequestDto {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
            sb.Append("  Indexing: ").Append(Indexing).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  Lifetime: ").Append(Lifetime).Append("\n");
            sb.Append("  Watermark: ").Append(Watermark).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
            sb.Append("  RoomType: ").Append(RoomType).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  ChatSettings: ").Append(ChatSettings).Append("\n");
            sb.Append("  SendFormToExternalDB: ").Append(SendFormToExternalDB).Append("\n");
            sb.Append("  SaveFormAsXLSX: ").Append(SaveFormAsXLSX).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 170)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 170.", new [] { "Title" });
            }

            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 0.", new [] { "Title" });
            }

            if (this.Color != null) {
                // Color (string) pattern
                                Regex regexColor = new Regex(@"^[0-9a-fA-F]{6}$", RegexOptions.CultureInvariant);
                                if (!regexColor.Match(this.Color).Success)
                                {
                                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Color, must match a pattern of " + regexColor, new [] { "Color" });
                                }
            }

            // Cover (string) maxLength
            if (this.Cover != null && this.Cover.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cover, length must be less than 50.", new [] { "Cover" });
            }

            // Cover (string) minLength
            if (this.Cover != null && this.Cover.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cover, length must be greater than 0.", new [] { "Cover" });
            }

            yield break;
        }

    }


}
