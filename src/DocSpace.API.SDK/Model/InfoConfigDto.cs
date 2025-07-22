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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The information config parameters.
    /// </summary>
    [DataContract(Name = "InfoConfigDto")]
    public partial class InfoConfigDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public EditorType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoConfigDto" /> class.
        /// </summary>
        /// <param name="favorite">Specifies if the file is favorite or not..</param>
        /// <param name="folder">The folder of the file..</param>
        /// <param name="owner">The file owner..</param>
        /// <param name="sharingSettings">The sharing settings of the file..</param>
        /// <param name="type">type.</param>
        /// <param name="uploaded">The uploaded file..</param>
        public InfoConfigDto(bool? favorite = default, string folder = default, string owner = default, List<AceShortWrapper> sharingSettings = default, EditorType? type = default, string uploaded = default)
        {
            this.Favorite = favorite;
            this.Folder = folder;
            this.Owner = owner;
            this.SharingSettings = sharingSettings;
            this.Type = type;
            this.Uploaded = uploaded;
        }

        /// <summary>
        /// Specifies if the file is favorite or not.
        /// </summary>
        /// <value>Specifies if the file is favorite or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "favorite", EmitDefaultValue = true)]
        public bool? Favorite { get; set; }

        /// <summary>
        /// The folder of the file.
        /// </summary>
        /// <value>The folder of the file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "folder", EmitDefaultValue = true)]
        public string Folder { get; set; }

        /// <summary>
        /// The file owner.
        /// </summary>
        /// <value>The file owner.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// The sharing settings of the file.
        /// </summary>
        /// <value>The sharing settings of the file.</value>
        [DataMember(Name = "sharingSettings", EmitDefaultValue = true)]
        public List<AceShortWrapper> SharingSettings { get; set; }

        /// <summary>
        /// The uploaded file.
        /// </summary>
        /// <value>The uploaded file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uploaded", EmitDefaultValue = true)]
        public string Uploaded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfoConfigDto {\n");
            sb.Append("  Favorite: ").Append(Favorite).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  SharingSettings: ").Append(SharingSettings).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uploaded: ").Append(Uploaded).Append("\n");
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
