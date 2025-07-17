/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The room template parameters.
    /// </summary>
    [DataContract(Name = "RoomTemplateDto")]
    public partial class RoomTemplateDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomTemplateDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomTemplateDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomTemplateDto" /> class.
        /// </summary>
        /// <param name="roomId">The room template ID. (required).</param>
        /// <param name="title">The room template title..</param>
        /// <param name="logo">logo.</param>
        /// <param name="copyLogo">Specifies whether to copy room logo or not..</param>
        /// <param name="share">The collection of email addresses of users with whom to share a room..</param>
        /// <param name="groups">The collection of groups with whom to share a room..</param>
        /// <param name="@public">Specifies whether the room template is public or not..</param>
        /// <param name="tags">The collection of tags..</param>
        /// <param name="color">The color of the room template..</param>
        /// <param name="cover">The cover of the room template..</param>
        /// <param name="quota">Room quota.</param>
        public RoomTemplateDto(int roomId = default, string title = default, LogoRequest logo = default, bool copyLogo = default, List<string> share = default, List<Guid> groups = default, bool @public = default, List<string> tags = default, string color = default, string cover = default, long? quota = default)
        {
            this.RoomId = roomId;
            this.Title = title;
            this.Logo = logo;
            this.CopyLogo = copyLogo;
            this.Share = share;
            this.Groups = groups;
            this.Public = @public;
            this.Tags = tags;
            this.Color = color;
            this.Cover = cover;
            this.Quota = quota;
        }

        /// <summary>
        /// The room template ID.
        /// </summary>
        /// <value>The room template ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "roomId", IsRequired = true, EmitDefaultValue = true)]
        public int RoomId { get; set; }

        /// <summary>
        /// The room template title.
        /// </summary>
        /// <value>The room template title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoRequest Logo { get; set; }

        /// <summary>
        /// Specifies whether to copy room logo or not.
        /// </summary>
        /// <value>Specifies whether to copy room logo or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "copyLogo", EmitDefaultValue = true)]
        public bool CopyLogo { get; set; }

        /// <summary>
        /// The collection of email addresses of users with whom to share a room.
        /// </summary>
        /// <value>The collection of email addresses of users with whom to share a room.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "share", EmitDefaultValue = true)]
        public List<string> Share { get; set; }

        /// <summary>
        /// The collection of groups with whom to share a room.
        /// </summary>
        /// <value>The collection of groups with whom to share a room.</value>
        /*
        <example>[&quot;75a5f745-f697-4418-b38d-0fe0d277e258&quot;]</example>
        */
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<Guid> Groups { get; set; }

        /// <summary>
        /// Specifies whether the room template is public or not.
        /// </summary>
        /// <value>Specifies whether the room template is public or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "public", EmitDefaultValue = true)]
        public bool Public { get; set; }

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
        /// The color of the room template.
        /// </summary>
        /// <value>The color of the room template.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// The cover of the room template.
        /// </summary>
        /// <value>The cover of the room template.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "cover", EmitDefaultValue = true)]
        public string Cover { get; set; }

        /// <summary>
        /// Room quota
        /// </summary>
        /// <value>Room quota</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "quota", EmitDefaultValue = true)]
        public long? Quota { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomTemplateDto {\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  CopyLogo: ").Append(CopyLogo).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
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
