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
    /// The parameters of a room built from a room template.
    /// </summary>
    [DataContract(Name = "CreateRoomFromTemplateDto")]
    public partial class CreateRoomFromTemplateDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoomFromTemplateDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRoomFromTemplateDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRoomFromTemplateDto" /> class.
        /// </summary>
        /// <param name="templateId">The room template to copy. Templates live in their own section and are listed by &#x60;GET api/2.0/files/rooms&#x60;  with a search area of 4; an ordinary room id is rejected here. (required).</param>
        /// <param name="title">The name of the room to create. It is sanitised and truncated the way a room title is, and a blank value is  rejected; the title of the template is not reused. (required).</param>
        /// <param name="logo">The picture to use as the room logo, named by the path that &#x60;POST api/2.0/files/logos&#x60; returned for an image  uploaded beforehand, plus the crop to take from it. Leaving the field out keeps the room on its cover and  colour. It is ignored when the logo of the template is copied instead..</param>
        /// <param name="copyLogo">Whether the new room keeps the logo of the template. With it on the uploaded picture is ignored; with it off  the room starts with no logo unless one is supplied..</param>
        /// <param name="tags">The labels to attach to the room, by name. Names the portal tag catalogue does not hold yet are added to it,  and &#x60;GET api/2.0/files/tags&#x60; lists what already exists. Leaving the field out keeps the tags of the template..</param>
        /// <param name="color">The background colour the room is drawn with while it has no logo, as six hexadecimal digits with no leading  number sign. An empty value restores the default colour of the room type..</param>
        /// <param name="cover">The picture drawn on the room while it has no logo, named by an identifier from  &#x60;GET api/2.0/files/rooms/covers&#x60;. Any other value is rejected, and an empty value leaves the room without a  cover..</param>
        /// <param name="quota">The storage the room may take, in bytes. It is accepted only while the per-room quota feature is on for the  portal and must stay inside the portal own limit; leaving it out lets the room follow the portal default..</param>
        /// <param name="indexing">Whether the room keeps a manual order of its contents. With it on every file and folder carries a position  that listings follow and that &#x60;PUT api/2.0/files/rooms/{id}/reorder&#x60; compacts; with it off the contents are  ordered by the sorting of the request. Leaving it out keeps the setting of the template..</param>
        /// <param name="denyDownload">Whether members without editing rights are stopped from downloading and printing the contents of the room.  They can still open the documents in the editor. Leaving it out keeps the setting of the template..</param>
        /// <param name="lifetime">How long files may stay in the room before they are deleted automatically. The countdown starts when the  setting is saved, and leaving the field out keeps the files forever. Leaving the field out keeps the setting  of the template..</param>
        /// <param name="watermark">The watermark drawn over documents opened in the room. Leaving the field out adds no watermark, and sending it  with the switch turned off removes the one the room has. Leaving the field out keeps the setting of the  template..</param>
        /// <param name="private">Whether the room is end-to-end encrypted. Its files can then be opened only in the desktop application by  members whose encryption keys are set up, and the flag cannot be changed after the room is created..</param>
        public CreateRoomFromTemplateDto(int templateId = default, string title = default, LogoRequest logo = default, bool copyLogo = default, List<string> tags = default, string color = default, string cover = default, long? quota = default, bool? indexing = default, bool? denyDownload = default, RoomDataLifetimeDto lifetime = default, WatermarkRequestDto watermark = default, bool? @private = default)
        {
            this.TemplateId = templateId;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateRoomFromTemplateDto and cannot be null");
            }
            this.Title = title;
            this.Logo = logo;
            this.CopyLogo = copyLogo;
            this.Tags = tags;
            this.Color = color;
            this.Cover = cover;
            this.Quota = quota;
            this.Indexing = indexing;
            this.DenyDownload = denyDownload;
            this.Lifetime = lifetime;
            this.Watermark = watermark;
            this.Private = @private;
        }

        /// <summary>
        /// The room template to copy. Templates live in their own section and are listed by &#x60;GET api/2.0/files/rooms&#x60;  with a search area of 4; an ordinary room id is rejected here.
        /// </summary>
        /// <example>42</example>
        [DataMember(Name = "templateId", IsRequired = true, EmitDefaultValue = true)]
        public int TemplateId { get; set; }

        /// <summary>
        /// The name of the room to create. It is sanitised and truncated the way a room title is, and a blank value is  rejected; the title of the template is not reused.
        /// </summary>
        /// <example>Project Alpha</example>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The picture to use as the room logo, named by the path that &#x60;POST api/2.0/files/logos&#x60; returned for an image  uploaded beforehand, plus the crop to take from it. Leaving the field out keeps the room on its cover and  colour. It is ignored when the logo of the template is copied instead.
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoRequest Logo { get; set; }

        /// <summary>
        /// Whether the new room keeps the logo of the template. With it on the uploaded picture is ignored; with it off  the room starts with no logo unless one is supplied.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "copyLogo", EmitDefaultValue = true)]
        public bool CopyLogo { get; set; }

        /// <summary>
        /// The labels to attach to the room, by name. Names the portal tag catalogue does not hold yet are added to it,  and &#x60;GET api/2.0/files/tags&#x60; lists what already exists. Leaving the field out keeps the tags of the template.
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
        /// The storage the room may take, in bytes. It is accepted only while the per-room quota feature is on for the  portal and must stay inside the portal own limit; leaving it out lets the room follow the portal default.
        /// </summary>
        /// <example>1073741824</example>
        [DataMember(Name = "quota", EmitDefaultValue = true)]
        public long? Quota { get; set; }

        /// <summary>
        /// Whether the room keeps a manual order of its contents. With it on every file and folder carries a position  that listings follow and that &#x60;PUT api/2.0/files/rooms/{id}/reorder&#x60; compacts; with it off the contents are  ordered by the sorting of the request. Leaving it out keeps the setting of the template.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool? Indexing { get; set; }

        /// <summary>
        /// Whether members without editing rights are stopped from downloading and printing the contents of the room.  They can still open the documents in the editor. Leaving it out keeps the setting of the template.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool? DenyDownload { get; set; }

        /// <summary>
        /// How long files may stay in the room before they are deleted automatically. The countdown starts when the  setting is saved, and leaving the field out keeps the files forever. Leaving the field out keeps the setting  of the template.
        /// </summary>
        [DataMember(Name = "lifetime", EmitDefaultValue = false)]
        public RoomDataLifetimeDto Lifetime { get; set; }

        /// <summary>
        /// The watermark drawn over documents opened in the room. Leaving the field out adds no watermark, and sending it  with the switch turned off removes the one the room has. Leaving the field out keeps the setting of the  template.
        /// </summary>
        [DataMember(Name = "watermark", EmitDefaultValue = false)]
        public WatermarkRequestDto Watermark { get; set; }

        /// <summary>
        /// Whether the room is end-to-end encrypted. Its files can then be opened only in the desktop application by  members whose encryption keys are set up, and the flag cannot be changed after the room is created.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool? Private { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRoomFromTemplateDto {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  CopyLogo: ").Append(CopyLogo).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
            sb.Append("  Indexing: ").Append(Indexing).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  Lifetime: ").Append(Lifetime).Append("\n");
            sb.Append("  Watermark: ").Append(Watermark).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
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

            // Color (string) maxLength
            if (this.Color != null && this.Color.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Color, length must be less than 6.", new [] { "Color" });
            }

            // Color (string) minLength
            if (this.Color != null && this.Color.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Color, length must be greater than 0.", new [] { "Color" });
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
