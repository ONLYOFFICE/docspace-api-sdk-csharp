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
    /// Client update request containing modified client details
    /// </summary>
    [DataContract(Name = "UpdateClientRequest")]
    public partial class UpdateClientRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClientRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateClientRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateClientRequest" /> class.
        /// </summary>
        /// <param name="name">The display name shown to the user on the consent screen. It has to be between 3 and 256 characters long. (required).</param>
        /// <param name="description">The free-text description shown next to the name on the consent screen, at most 255 characters..</param>
        /// <param name="logo">The client logo as a data URI carrying base64 image data, shown on the consent screen. Only png, jpeg, jpg and svg+xml are accepted. (required).</param>
        /// <param name="scopes">The permissions the client may ask for, named as they appear in the tenant scope catalogue - for example files:read, rooms:write or openid. A client cannot request a scope that is not listed here. (required).</param>
        /// <param name="allowPkce">Whether the client may use PKCE. Turning it on lets the client authenticate with the none method and prove itself with a code verifier instead of sending a secret, which is what a client that cannot keep a secret needs..</param>
        /// <param name="allowedOrigins">The web origins allowed to call the portal on behalf of this client, used for the CORS check. The set holds between 1 and 12 addresses. (required).</param>
        /// <param name="redirectUris">The URIs an authorization code may be delivered to. An authorization request naming any other URI is refused, and the set holds between 1 and 12 addresses. (required).</param>
        /// <param name="isPublic">Whether the client is offered to third-party tenants rather than only to the tenant that registers it..</param>
        public UpdateClientRequest(string name = default, string description = default, string logo = default, List<string> scopes = default, bool allowPkce = default, List<string> allowedOrigins = default, List<string> redirectUris = default, bool isPublic = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateClientRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "logo" is required (not null)
            if (logo == null)
            {
                throw new ArgumentNullException("logo is a required property for UpdateClientRequest and cannot be null");
            }
            this.Logo = logo;
            // to ensure "scopes" is required (not null)
            if (scopes == null)
            {
                throw new ArgumentNullException("scopes is a required property for UpdateClientRequest and cannot be null");
            }
            this.Scopes = scopes;
            // to ensure "allowedOrigins" is required (not null)
            if (allowedOrigins == null)
            {
                throw new ArgumentNullException("allowedOrigins is a required property for UpdateClientRequest and cannot be null");
            }
            this.AllowedOrigins = allowedOrigins;
            // to ensure "redirectUris" is required (not null)
            if (redirectUris == null)
            {
                throw new ArgumentNullException("redirectUris is a required property for UpdateClientRequest and cannot be null");
            }
            this.RedirectUris = redirectUris;
            this.Description = description;
            this.AllowPkce = allowPkce;
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// The display name shown to the user on the consent screen. It has to be between 3 and 256 characters long.
        /// </summary>
        /// <example>Updated Client</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The free-text description shown next to the name on the consent screen, at most 255 characters.
        /// </summary>
        /// <example>Updated description of the client</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The client logo as a data URI carrying base64 image data, shown on the consent screen. Only png, jpeg, jpg and svg+xml are accepted.
        /// </summary>
        /// <example>data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8z8BQDwAEhQGAhKmMIQAAAABJRU5ErkJggg==</example>
        [DataMember(Name = "logo", IsRequired = true, EmitDefaultValue = true)]
        public string Logo { get; set; }

        /// <summary>
        /// The permissions the client may ask for, named as they appear in the tenant scope catalogue - for example files:read, rooms:write or openid. A client cannot request a scope that is not listed here.
        /// </summary>
        [DataMember(Name = "scopes", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// Whether the client may use PKCE. Turning it on lets the client authenticate with the none method and prove itself with a code verifier instead of sending a secret, which is what a client that cannot keep a secret needs.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "allow_pkce", EmitDefaultValue = true)]
        public bool AllowPkce { get; set; }

        /// <summary>
        /// The web origins allowed to call the portal on behalf of this client, used for the CORS check. The set holds between 1 and 12 addresses.
        /// </summary>
        [DataMember(Name = "allowed_origins", IsRequired = true, EmitDefaultValue = true)]
        public List<string> AllowedOrigins { get; set; }

        /// <summary>
        /// The URIs an authorization code may be delivered to. An authorization request naming any other URI is refused, and the set holds between 1 and 12 addresses.
        /// </summary>
        [DataMember(Name = "redirect_uris", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RedirectUris { get; set; }

        /// <summary>
        /// Whether the client is offered to third-party tenants rather than only to the tenant that registers it.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "is_public", EmitDefaultValue = true)]
        public bool IsPublic { get; set; }

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
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  AllowPkce: ").Append(AllowPkce).Append("\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
            sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 256.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 3.", new [] { "Name" });
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
