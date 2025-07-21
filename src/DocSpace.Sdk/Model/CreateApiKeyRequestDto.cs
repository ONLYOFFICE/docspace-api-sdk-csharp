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
    /// The request parameters for creating a new API key.
    /// </summary>
    [DataContract(Name = "CreateApiKeyRequestDto")]
    public partial class CreateApiKeyRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateApiKeyRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequestDto" /> class.
        /// </summary>
        /// <param name="name">The API key name. (required).</param>
        /// <param name="permissions">The list of permissions granted to the API key..</param>
        /// <param name="expiresInDays">The number of days until the API key expires (null for no expiration)..</param>
        public CreateApiKeyRequestDto(string name = default, List<string> permissions = default, int? expiresInDays = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateApiKeyRequestDto and cannot be null");
            }
            this.Name = name;
            this.Permissions = permissions;
            this.ExpiresInDays = expiresInDays;
        }

        /// <summary>
        /// The API key name.
        /// </summary>
        /// <value>The API key name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The list of permissions granted to the API key.
        /// </summary>
        /// <value>The list of permissions granted to the API key.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// The number of days until the API key expires (null for no expiration).
        /// </summary>
        /// <value>The number of days until the API key expires (null for no expiration).</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "expiresInDays", EmitDefaultValue = true)]
        public int? ExpiresInDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApiKeyRequestDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  ExpiresInDays: ").Append(ExpiresInDays).Append("\n");
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

            // ExpiresInDays (int?) maximum
            if (this.ExpiresInDays > (int?)365)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiresInDays, must be a value less than or equal to 365.", new [] { "ExpiresInDays" });
            }

            // ExpiresInDays (int?) minimum
            if (this.ExpiresInDays < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpiresInDays, must be a value greater than or equal to 1.", new [] { "ExpiresInDays" });
            }

            yield break;
        }
    }


}
