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
    /// The request parameters for updating a room.
    /// </summary>
    [DataContract(Name = "UpdateRoomRequest")]
    public partial class UpdateRoomRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRoomRequest" /> class.
        /// </summary>
        /// <param name="title">The room title..</param>
        /// <param name="quota">The room quota..</param>
        /// <param name="indexing">Specifies whether to create a third-party room with indexing..</param>
        /// <param name="denyDownload">Specifies whether to deny downloads from the third-party room..</param>
        /// <param name="lifetime">lifetime.</param>
        /// <param name="watermark">watermark.</param>
        /// <param name="logo">logo.</param>
        /// <param name="tags">The list of tags..</param>
        /// <param name="color">The room color..</param>
        /// <param name="cover">The room cover..</param>
        /// <param name="chatSettings">chatSettings.</param>
        /// <param name="sendFormToExternalDB">Specifies whether to send form data to external database..</param>
        /// <param name="saveFormAsXLSX">Specifies whether to save form data as XLSX file..</param>
        public UpdateRoomRequest(string title = default, long? quota = default, bool? indexing = default, bool? denyDownload = default, RoomDataLifetimeDto lifetime = default, WatermarkRequestDto watermark = default, LogoRequest logo = default, List<string> tags = default, string color = default, string cover = default, ChatSettings chatSettings = default, bool? sendFormToExternalDB = default, bool? saveFormAsXLSX = default)
        {
            this.Title = title;
            this.Quota = quota;
            this.Indexing = indexing;
            this.DenyDownload = denyDownload;
            this.Lifetime = lifetime;
            this.Watermark = watermark;
            this.Logo = logo;
            this.Tags = tags;
            this.Color = color;
            this.Cover = cover;
            this.ChatSettings = chatSettings;
            this.SendFormToExternalDB = sendFormToExternalDB;
            this.SaveFormAsXLSX = saveFormAsXLSX;
        }

        /// <summary>
        /// The room title.
        /// </summary>
        /// <value>The room title.</value>
        /*
        <example>My Document</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The room quota.
        /// </summary>
        /// <value>The room quota.</value>
        /*
        <example>10485760</example>
        */
        [DataMember(Name = "quota", EmitDefaultValue = true)]
        public long? Quota { get; set; }

        /// <summary>
        /// Specifies whether to create a third-party room with indexing.
        /// </summary>
        /// <value>Specifies whether to create a third-party room with indexing.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool? Indexing { get; set; }

        /// <summary>
        /// Specifies whether to deny downloads from the third-party room.
        /// </summary>
        /// <value>Specifies whether to deny downloads from the third-party room.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool? DenyDownload { get; set; }

        /// <summary>
        /// Gets or Sets Lifetime
        /// </summary>
        [DataMember(Name = "lifetime", EmitDefaultValue = false)]
        public RoomDataLifetimeDto Lifetime { get; set; }

        /// <summary>
        /// Gets or Sets Watermark
        /// </summary>
        [DataMember(Name = "watermark", EmitDefaultValue = false)]
        public WatermarkRequestDto Watermark { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoRequest Logo { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        /// <value>The list of tags.</value>
        /*
        <example>["tag1","tag2"]</example>
        */
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The room color.
        /// </summary>
        /// <value>The room color.</value>
        /*
        <example>#FF5733</example>
        */
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// The room cover.
        /// </summary>
        /// <value>The room cover.</value>
        /*
        <example>cover1</example>
        */
        [DataMember(Name = "cover", EmitDefaultValue = true)]
        public string Cover { get; set; }

        /// <summary>
        /// Gets or Sets ChatSettings
        /// </summary>
        [DataMember(Name = "chatSettings", EmitDefaultValue = false)]
        public ChatSettings ChatSettings { get; set; }

        /// <summary>
        /// Specifies whether to send form data to external database.
        /// </summary>
        /// <value>Specifies whether to send form data to external database.</value>
        [DataMember(Name = "sendFormToExternalDB", EmitDefaultValue = true)]
        public bool? SendFormToExternalDB { get; set; }

        /// <summary>
        /// Specifies whether to save form data as XLSX file.
        /// </summary>
        /// <value>Specifies whether to save form data as XLSX file.</value>
        [DataMember(Name = "saveFormAsXLSX", EmitDefaultValue = true)]
        public bool? SaveFormAsXLSX { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRoomRequest {\n");
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
