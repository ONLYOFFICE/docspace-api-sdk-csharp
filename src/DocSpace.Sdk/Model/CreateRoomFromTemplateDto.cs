// (c) Copyright Ascensio System SIA 2025
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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The parameters for creating a room from a template.
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
        /// <param name="templateId">The template ID from which the room to be created. (required).</param>
        /// <param name="title">The room title. (required).</param>
        /// <param name="logo">logo.</param>
        /// <param name="copyLogo">Specifies whether to copy a logo or not..</param>
        /// <param name="tags">The collection of tags..</param>
        /// <param name="color">The color of the room to be created..</param>
        /// <param name="cover">The cover of the room to be created..</param>
        /// <param name="quota">The room quota..</param>
        /// <param name="indexing">Specifies whether to create a room with indexing..</param>
        /// <param name="denyDownload">Specifies whether to deny downloads from the room..</param>
        /// <param name="lifetime">lifetime.</param>
        /// <param name="watermark">watermark.</param>
        /// <param name="@private">Specifies whether the room to be created is private or not..</param>
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
        /// The template ID from which the room to be created.
        /// </summary>
        /// <value>The template ID from which the room to be created.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "templateId", IsRequired = true, EmitDefaultValue = true)]
        public int TemplateId { get; set; }

        /// <summary>
        /// The room title.
        /// </summary>
        /// <value>The room title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoRequest Logo { get; set; }

        /// <summary>
        /// Specifies whether to copy a logo or not.
        /// </summary>
        /// <value>Specifies whether to copy a logo or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "copyLogo", EmitDefaultValue = true)]
        public bool CopyLogo { get; set; }

        /// <summary>
        /// The collection of tags.
        /// </summary>
        /// <value>The collection of tags.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The color of the room to be created.
        /// </summary>
        /// <value>The color of the room to be created.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// The cover of the room to be created.
        /// </summary>
        /// <value>The cover of the room to be created.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "cover", EmitDefaultValue = true)]
        public string Cover { get; set; }

        /// <summary>
        /// The room quota.
        /// </summary>
        /// <value>The room quota.</value>
        /*
        <example>1234</example>
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
        /// Specifies whether the room to be created is private or not.
        /// </summary>
        /// <value>Specifies whether the room to be created is private or not.</value>
        /*
        <example>true</example>
        */
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
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
