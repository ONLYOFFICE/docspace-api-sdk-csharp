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
    /// The parameters for creating a third-party room.
    /// </summary>
    [DataContract(Name = "CreateThirdPartyRoom")]
    public partial class CreateThirdPartyRoom : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RoomType
        /// </summary>
        [DataMember(Name = "roomType", IsRequired = true, EmitDefaultValue = true)]
        public RoomType RoomType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThirdPartyRoom" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateThirdPartyRoom() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThirdPartyRoom" /> class.
        /// </summary>
        /// <param name="createAsNewFolder">Specifies whether to create a third-party room as a new folder or not..</param>
        /// <param name="title">The third-party room name to be created. (required).</param>
        /// <param name="roomType">roomType (required).</param>
        /// <param name="@private">Specifies whether to create the private third-party room or not..</param>
        /// <param name="indexing">Specifies whether to create the third-party room with indexing..</param>
        /// <param name="denyDownload">Specifies whether to deny downloads from the third-party room..</param>
        /// <param name="color">The color of the third-party room..</param>
        /// <param name="cover">The cover of the third-party room..</param>
        /// <param name="tags">The list of tags of the third-party room..</param>
        /// <param name="logo">logo.</param>
        public CreateThirdPartyRoom(bool createAsNewFolder = default, string title = default, RoomType roomType = default, bool @private = default, bool indexing = default, bool denyDownload = default, string color = default, string cover = default, List<string> tags = default, LogoRequest logo = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateThirdPartyRoom and cannot be null");
            }
            this.Title = title;
            this.RoomType = roomType;
            this.CreateAsNewFolder = createAsNewFolder;
            this.Private = @private;
            this.Indexing = indexing;
            this.DenyDownload = denyDownload;
            this.Color = color;
            this.Cover = cover;
            this.Tags = tags;
            this.Logo = logo;
        }

        /// <summary>
        /// Specifies whether to create a third-party room as a new folder or not.
        /// </summary>
        /// <value>Specifies whether to create a third-party room as a new folder or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "createAsNewFolder", EmitDefaultValue = true)]
        public bool CreateAsNewFolder { get; set; }

        /// <summary>
        /// The third-party room name to be created.
        /// </summary>
        /// <value>The third-party room name to be created.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Specifies whether to create the private third-party room or not.
        /// </summary>
        /// <value>Specifies whether to create the private third-party room or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private { get; set; }

        /// <summary>
        /// Specifies whether to create the third-party room with indexing.
        /// </summary>
        /// <value>Specifies whether to create the third-party room with indexing.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool Indexing { get; set; }

        /// <summary>
        /// Specifies whether to deny downloads from the third-party room.
        /// </summary>
        /// <value>Specifies whether to deny downloads from the third-party room.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// The color of the third-party room.
        /// </summary>
        /// <value>The color of the third-party room.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// The cover of the third-party room.
        /// </summary>
        /// <value>The cover of the third-party room.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "cover", EmitDefaultValue = true)]
        public string Cover { get; set; }

        /// <summary>
        /// The list of tags of the third-party room.
        /// </summary>
        /// <value>The list of tags of the third-party room.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public LogoRequest Logo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateThirdPartyRoom {\n");
            sb.Append("  CreateAsNewFolder: ").Append(CreateAsNewFolder).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  RoomType: ").Append(RoomType).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  Indexing: ").Append(Indexing).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
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
            yield break;
        }
    }


}
