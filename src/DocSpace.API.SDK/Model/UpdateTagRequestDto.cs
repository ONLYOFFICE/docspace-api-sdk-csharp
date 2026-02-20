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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The request parameters for creating a tag.
    /// </summary>
    [DataContract(Name = "UpdateTagRequestDto")]
    public partial class UpdateTagRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTagRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateTagRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTagRequestDto" /> class.
        /// </summary>
        /// <param name="oldName">The old tag name. (required).</param>
        /// <param name="newName">The new tag name. (required).</param>
        public UpdateTagRequestDto(string oldName = default, string newName = default)
        {
            // to ensure "oldName" is required (not null)
            if (oldName == null)
            {
                throw new ArgumentNullException("oldName is a required property for UpdateTagRequestDto and cannot be null");
            }
            this.OldName = oldName;
            // to ensure "newName" is required (not null)
            if (newName == null)
            {
                throw new ArgumentNullException("newName is a required property for UpdateTagRequestDto and cannot be null");
            }
            this.NewName = newName;
        }

        /// <summary>
        /// The old tag name.
        /// </summary>
        /// <value>The old tag name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "oldName", IsRequired = true, EmitDefaultValue = true)]
        public string OldName { get; set; }

        /// <summary>
        /// The new tag name.
        /// </summary>
        /// <value>The new tag name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "newName", IsRequired = true, EmitDefaultValue = true)]
        public string NewName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTagRequestDto {\n");
            sb.Append("  OldName: ").Append(OldName).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
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
            // OldName (string) maxLength
            if (this.OldName != null && this.OldName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OldName, length must be less than 255.", new [] { "OldName" });
            }

            // OldName (string) minLength
            if (this.OldName != null && this.OldName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OldName, length must be greater than 0.", new [] { "OldName" });
            }

            // NewName (string) maxLength
            if (this.NewName != null && this.NewName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewName, length must be less than 255.", new [] { "NewName" });
            }

            // NewName (string) minLength
            if (this.NewName != null && this.NewName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewName, length must be greater than 0.", new [] { "NewName" });
            }

            yield break;
        }

    }


}
