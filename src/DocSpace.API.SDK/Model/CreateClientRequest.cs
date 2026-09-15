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
    /// Client creation request containing client details
    /// </summary>
    [DataContract(Name = "CreateClientRequest")]
    public partial class CreateClientRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateClientRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientRequest" /> class.
        /// </summary>
        /// <param name="name">The display name shown to the user on the consent screen. It has to be between 3 and 256 characters long. (required).</param>
        /// <param name="description">The free-text description shown next to the name on the consent screen, at most 255 characters..</param>
        /// <param name="logo">The client logo as a data URI carrying base64 image data, shown on the consent screen. Only png, jpeg, jpg and svg+xml are accepted, the whole string may not exceed 2000000 characters and the decoded image may not exceed 256000 bytes. (required).</param>
        /// <param name="scopes">The permissions the client may ask for, named as they appear in the tenant scope catalogue - for example files:read, rooms:write or openid. A client cannot request a scope that is not listed here. (required).</param>
        /// <param name="allowPkce">Whether the client may use PKCE. Turning it on lets the client authenticate with the none method and prove itself with a code verifier instead of sending a secret, which is what a client that cannot keep a secret needs..</param>
        /// <param name="websiteUrl">The URL of the client home page, offered to the user before they consent. The value has to be an http or https URL. (required).</param>
        /// <param name="termsUrl">The URL of the client terms of service, linked from the consent screen. The value has to be an http or https URL. (required).</param>
        /// <param name="policyUrl">The URL of the client privacy policy, linked from the consent screen. The value has to be an http or https URL. (required).</param>
        /// <param name="redirectUris">The URIs an authorization code may be delivered to. An authorization request naming any other URI is refused, and the set holds between 1 and 12 addresses. (required).</param>
        /// <param name="allowedOrigins">The web origins allowed to call the portal on behalf of this client, used for the CORS check. The set holds between 1 and 12 addresses. (required).</param>
        /// <param name="logoutRedirectUri">The single URI the user may be sent back to once they have logged out. The value has to be an http or https URL. (required).</param>
        /// <param name="isPublic">Whether the client is offered to third-party tenants rather than only to the tenant that registers it..</param>
        public CreateClientRequest(string name = default, string description = default, string logo = default, List<string> scopes = default, bool allowPkce = default, string websiteUrl = default, string termsUrl = default, string policyUrl = default, List<string> redirectUris = default, List<string> allowedOrigins = default, string logoutRedirectUri = default, bool isPublic = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateClientRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "logo" is required (not null)
            if (logo == null)
            {
                throw new ArgumentNullException("logo is a required property for CreateClientRequest and cannot be null");
            }
            this.Logo = logo;
            // to ensure "scopes" is required (not null)
            if (scopes == null)
            {
                throw new ArgumentNullException("scopes is a required property for CreateClientRequest and cannot be null");
            }
            this.Scopes = scopes;
            // to ensure "websiteUrl" is required (not null)
            if (websiteUrl == null)
            {
                throw new ArgumentNullException("websiteUrl is a required property for CreateClientRequest and cannot be null");
            }
            this.WebsiteUrl = websiteUrl;
            // to ensure "termsUrl" is required (not null)
            if (termsUrl == null)
            {
                throw new ArgumentNullException("termsUrl is a required property for CreateClientRequest and cannot be null");
            }
            this.TermsUrl = termsUrl;
            // to ensure "policyUrl" is required (not null)
            if (policyUrl == null)
            {
                throw new ArgumentNullException("policyUrl is a required property for CreateClientRequest and cannot be null");
            }
            this.PolicyUrl = policyUrl;
            // to ensure "redirectUris" is required (not null)
            if (redirectUris == null)
            {
                throw new ArgumentNullException("redirectUris is a required property for CreateClientRequest and cannot be null");
            }
            this.RedirectUris = redirectUris;
            // to ensure "allowedOrigins" is required (not null)
            if (allowedOrigins == null)
            {
                throw new ArgumentNullException("allowedOrigins is a required property for CreateClientRequest and cannot be null");
            }
            this.AllowedOrigins = allowedOrigins;
            // to ensure "logoutRedirectUri" is required (not null)
            if (logoutRedirectUri == null)
            {
                throw new ArgumentNullException("logoutRedirectUri is a required property for CreateClientRequest and cannot be null");
            }
            this.LogoutRedirectUri = logoutRedirectUri;
            this.Description = description;
            this.AllowPkce = allowPkce;
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// The display name shown to the user on the consent screen. It has to be between 3 and 256 characters long.
        /// </summary>
        /// <example>Example Client</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The free-text description shown next to the name on the consent screen, at most 255 characters.
        /// </summary>
        /// <example>Description of the client</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The client logo as a data URI carrying base64 image data, shown on the consent screen. Only png, jpeg, jpg and svg+xml are accepted, the whole string may not exceed 2000000 characters and the decoded image may not exceed 256000 bytes.
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
        /// The URL of the client home page, offered to the user before they consent. The value has to be an http or https URL.
        /// </summary>
        /// <example>http://example.com</example>
        [DataMember(Name = "website_url", IsRequired = true, EmitDefaultValue = true)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// The URL of the client terms of service, linked from the consent screen. The value has to be an http or https URL.
        /// </summary>
        /// <example>http://example.com/terms</example>
        [DataMember(Name = "terms_url", IsRequired = true, EmitDefaultValue = true)]
        public string TermsUrl { get; set; }

        /// <summary>
        /// The URL of the client privacy policy, linked from the consent screen. The value has to be an http or https URL.
        /// </summary>
        /// <example>http://example.com/policy</example>
        [DataMember(Name = "policy_url", IsRequired = true, EmitDefaultValue = true)]
        public string PolicyUrl { get; set; }

        /// <summary>
        /// The URIs an authorization code may be delivered to. An authorization request naming any other URI is refused, and the set holds between 1 and 12 addresses.
        /// </summary>
        [DataMember(Name = "redirect_uris", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RedirectUris { get; set; }

        /// <summary>
        /// The web origins allowed to call the portal on behalf of this client, used for the CORS check. The set holds between 1 and 12 addresses.
        /// </summary>
        [DataMember(Name = "allowed_origins", IsRequired = true, EmitDefaultValue = true)]
        public List<string> AllowedOrigins { get; set; }

        /// <summary>
        /// The single URI the user may be sent back to once they have logged out. The value has to be an http or https URL.
        /// </summary>
        /// <example>http://example.com/logout</example>
        [DataMember(Name = "logout_redirect_uri", IsRequired = true, EmitDefaultValue = true)]
        public string LogoutRedirectUri { get; set; }

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
            sb.Append("class CreateClientRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  AllowPkce: ").Append(AllowPkce).Append("\n");
            sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
            sb.Append("  TermsUrl: ").Append(TermsUrl).Append("\n");
            sb.Append("  PolicyUrl: ").Append(PolicyUrl).Append("\n");
            sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
            sb.Append("  LogoutRedirectUri: ").Append(LogoutRedirectUri).Append("\n");
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

            // WebsiteUrl (string) minLength
            if (this.WebsiteUrl != null && this.WebsiteUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebsiteUrl, length must be greater than 1.", new [] { "WebsiteUrl" });
            }

            if (this.WebsiteUrl != null) {
                // WebsiteUrl (string) pattern
                                Regex regexWebsiteUrl = new Regex(@"^(https?://)?([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$|^https?://(\d{1,3}\.){3}\d{1,3}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$", RegexOptions.CultureInvariant);
                                if (!regexWebsiteUrl.Match(this.WebsiteUrl).Success)
                                {
                                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebsiteUrl, must match a pattern of " + regexWebsiteUrl, new [] { "WebsiteUrl" });
                                }
            }

            // TermsUrl (string) minLength
            if (this.TermsUrl != null && this.TermsUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TermsUrl, length must be greater than 1.", new [] { "TermsUrl" });
            }

            if (this.TermsUrl != null) {
                // TermsUrl (string) pattern
                                Regex regexTermsUrl = new Regex(@"^(https?://)?([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$|^https?://(\d{1,3}\.){3}\d{1,3}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$", RegexOptions.CultureInvariant);
                                if (!regexTermsUrl.Match(this.TermsUrl).Success)
                                {
                                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TermsUrl, must match a pattern of " + regexTermsUrl, new [] { "TermsUrl" });
                                }
            }

            // PolicyUrl (string) minLength
            if (this.PolicyUrl != null && this.PolicyUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PolicyUrl, length must be greater than 1.", new [] { "PolicyUrl" });
            }

            if (this.PolicyUrl != null) {
                // PolicyUrl (string) pattern
                                Regex regexPolicyUrl = new Regex(@"^(https?://)?([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$|^https?://(\d{1,3}\.){3}\d{1,3}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$", RegexOptions.CultureInvariant);
                                if (!regexPolicyUrl.Match(this.PolicyUrl).Success)
                                {
                                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PolicyUrl, must match a pattern of " + regexPolicyUrl, new [] { "PolicyUrl" });
                                }
            }

            // LogoutRedirectUri (string) minLength
            if (this.LogoutRedirectUri != null && this.LogoutRedirectUri.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogoutRedirectUri, length must be greater than 1.", new [] { "LogoutRedirectUri" });
            }

            if (this.LogoutRedirectUri != null) {
                // LogoutRedirectUri (string) pattern
                                Regex regexLogoutRedirectUri = new Regex(@"^(https?://)?([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$|^https?://(\d{1,3}\.){3}\d{1,3}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$", RegexOptions.CultureInvariant);
                                if (!regexLogoutRedirectUri.Match(this.LogoutRedirectUri).Success)
                                {
                                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogoutRedirectUri, must match a pattern of " + regexLogoutRedirectUri, new [] { "LogoutRedirectUri" });
                                }
            }

            yield break;
        }

    }


}
