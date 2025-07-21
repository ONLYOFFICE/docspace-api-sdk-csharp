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
    /// The request parameters for updating an existing API key.
    /// </summary>
    [DataContract(Name = "UpdateApiKeyRequest")]
    public partial class UpdateApiKeyRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="name">The new name for the API key..</param>
        /// <param name="permissions">The new list of permissions for the API key..</param>
        /// <param name="isActive">Indicates whether the API key should be active or not..</param>
        public UpdateApiKeyRequest(string name = default, List<string> permissions = default, bool? isActive = default)
        {
            this.Name = name;
            this.Permissions = permissions;
            this.IsActive = isActive;
        }

        /// <summary>
        /// The new name for the API key.
        /// </summary>
        /// <value>The new name for the API key.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The new list of permissions for the API key.
        /// </summary>
        /// <value>The new list of permissions for the API key.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Indicates whether the API key should be active or not.
        /// </summary>
        /// <value>Indicates whether the API key should be active or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApiKeyRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 30.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            yield break;
        }
    }


}
