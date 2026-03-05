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
    /// Request to create a new AI agent room.
    /// </summary>
    [DataContract(Name = "CreateAgentRequestDto")]
    public partial class CreateAgentRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAgentRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestDto" /> class.
        /// </summary>
        /// <param name="title">The room name. (required).</param>
        /// <param name="quota">The room quota..</param>
        /// <param name="indexing">Specifies whether to create a room with indexing..</param>
        /// <param name="denyDownload">Specifies whether to deny downloads from the room..</param>
        /// <param name="lifetime">lifetime.</param>
        /// <param name="watermark">watermark.</param>
        /// <param name="logo">logo.</param>
        /// <param name="tags">The list of tags..</param>
        /// <param name="color">The room color..</param>
        /// <param name="cover">The room cover..</param>
        /// <param name="@private">Specifies whether the room to be created is private or not..</param>
        /// <param name="share">The collection of sharing parameters..</param>
        /// <param name="chatSettings">chatSettings (required).</param>
        /// <param name="attachDefaultTools">Specifies whether to attach default tools to the agent or not..</param>
        public CreateAgentRequestDto(string title = default, long? quota = default, bool? indexing = default, bool? denyDownload = default, RoomDataLifetimeDto lifetime = default, WatermarkRequestDto watermark = default, LogoRequest logo = default, List<string> tags = default, string color = default, string cover = default, bool @private = default, List<FileShareParams> share = default, ChatSettings chatSettings = default, bool attachDefaultTools = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateAgentRequestDto and cannot be null");
            }
            this.Title = title;
            // to ensure "chatSettings" is required (not null)
            if (chatSettings == null)
            {
                throw new ArgumentNullException("chatSettings is a required property for CreateAgentRequestDto and cannot be null");
            }
            this.ChatSettings = chatSettings;
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
            this.AttachDefaultTools = attachDefaultTools;
        }

        /// <summary>
        /// The room name.
        /// </summary>
        /// <value>The room name.</value>
        /*
        <example>My AI Agent Room</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
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
        /// Specifies whether to create a room with indexing.
        /// </summary>
        /// <value>Specifies whether to create a room with indexing.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool? Indexing { get; set; }

        /// <summary>
        /// Specifies whether to deny downloads from the room.
        /// </summary>
        /// <value>Specifies whether to deny downloads from the room.</value>
        /*
        <example>false</example>
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
        <example>[&quot;ai&quot;,&quot;assistant&quot;]</example>
        */
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The room color.
        /// </summary>
        /// <value>The room color.</value>
        /*
        <example>FF6600</example>
        */
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// The room cover.
        /// </summary>
        /// <value>The room cover.</value>
        /*
        <example>cover1.jpg</example>
        */
        [DataMember(Name = "cover", EmitDefaultValue = true)]
        public string Cover { get; set; }

        /// <summary>
        /// Specifies whether the room to be created is private or not.
        /// </summary>
        /// <value>Specifies whether the room to be created is private or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private { get; set; }

        /// <summary>
        /// The collection of sharing parameters.
        /// </summary>
        /// <value>The collection of sharing parameters.</value>
        /*
        <example>[{&quot;shareId&quot;:&quot;user@example.com&quot;,&quot;access&quot;:1}]</example>
        */
        [DataMember(Name = "share", EmitDefaultValue = true)]
        public List<FileShareParams> Share { get; set; }

        /// <summary>
        /// Gets or Sets ChatSettings
        /// </summary>
        [DataMember(Name = "chatSettings", IsRequired = true, EmitDefaultValue = true)]
        public ChatSettings ChatSettings { get; set; }

        /// <summary>
        /// Specifies whether to attach default tools to the agent or not.
        /// </summary>
        /// <value>Specifies whether to attach default tools to the agent or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "attachDefaultTools", EmitDefaultValue = true)]
        public bool AttachDefaultTools { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAgentRequestDto {\n");
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
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  ChatSettings: ").Append(ChatSettings).Append("\n");
            sb.Append("  AttachDefaultTools: ").Append(AttachDefaultTools).Append("\n");
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
