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
    /// The request for updating client details.
    /// </summary>
    [DataContract(Name = "UpdateClientRequest")]
    public partial class UpdateClientRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClientRequest" /> class.
        /// </summary>
        /// <param name="name">The client name..</param>
        /// <param name="description">The client description.</param>
        /// <param name="logo">The client logo in base64 format..</param>
        /// <param name="allowPkce">Indicates whether PKCE is allowed for the client..</param>
        /// <param name="isPublic">Indicates whether the client is accessible by third-party tenants..</param>
        /// <param name="allowedOrigins">The allowed origins for the client..</param>
        public UpdateClientRequest(string name = default, string description = default, string logo = default, bool allowPkce = default, bool isPublic = default, List<string> allowedOrigins = default)
        {
            this.Name = name;
            this.Description = description;
            this.Logo = logo;
            this.AllowPkce = allowPkce;
            this.IsPublic = isPublic;
            this.AllowedOrigins = allowedOrigins;
        }

        /// <summary>
        /// The client name.
        /// </summary>
        /// <value>The client name.</value>
        /*
        <example>Updated Client</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The client description
        /// </summary>
        /// <value>The client description</value>
        /*
        <example>Updated description of the client</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The client logo in base64 format.
        /// </summary>
        /// <value>The client logo in base64 format.</value>
        /*
        <example>data:image/png;base64,...</example>
        */
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// Indicates whether PKCE is allowed for the client.
        /// </summary>
        /// <value>Indicates whether PKCE is allowed for the client.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "allow_pkce", EmitDefaultValue = true)]
        public bool AllowPkce { get; set; }

        /// <summary>
        /// Indicates whether the client is accessible by third-party tenants.
        /// </summary>
        /// <value>Indicates whether the client is accessible by third-party tenants.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "is_public", EmitDefaultValue = true)]
        public bool IsPublic { get; set; }

        /// <summary>
        /// The allowed origins for the client.
        /// </summary>
        /// <value>The allowed origins for the client.</value>
        /*
        <example>[&quot;http://allowed.origin&quot;]</example>
        */
        [DataMember(Name = "allowed_origins", EmitDefaultValue = false)]
        public List<string> AllowedOrigins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateClientRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  AllowPkce: ").Append(AllowPkce).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
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
            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // Logo (string) minLength
            if (this.Logo != null && this.Logo.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Logo, length must be greater than 1.", new [] { "Logo" });
            }

            if (this.Logo != null) {
                // Logo (string) pattern
                Regex regexLogo = new Regex(@"^data:image\/(?:png|jpeg|jpg|svg\+xml);base64,.*.{1,}", RegexOptions.CultureInvariant);
                if (!regexLogo.Match(this.Logo).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Logo, must match a pattern of " + regexLogo, new [] { "Logo" });
                }
            }

            yield break;
        }
    }


}
