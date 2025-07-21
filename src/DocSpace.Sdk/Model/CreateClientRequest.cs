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
    /// The request parameters for creating a client.
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
        /// <param name="name">The client name..</param>
        /// <param name="description">The client description..</param>
        /// <param name="logo">The client logo in base64 format..</param>
        /// <param name="scopes">The client scopes..</param>
        /// <param name="allowPkce">Indicates whether PKCE is allowed for the client..</param>
        /// <param name="isPublic">Indicates whether the client is accessible by third-party tenants..</param>
        /// <param name="websiteUrl">The URL to the client&#39;s website..</param>
        /// <param name="termsUrl">The URL to the client&#39;s terms of service..</param>
        /// <param name="policyUrl">The URL to the client&#39;s privacy policy..</param>
        /// <param name="redirectUris">The list of allowed redirect URIs. (required).</param>
        /// <param name="allowedOrigins">The list of allowed CORS origins. (required).</param>
        /// <param name="logoutRedirectUri">The list of allowed logout redirect URIs..</param>
        public CreateClientRequest(string name = default, string description = default, string logo = default, List<string> scopes = default, bool allowPkce = default, bool isPublic = default, string websiteUrl = default, string termsUrl = default, string policyUrl = default, List<string> redirectUris = default, List<string> allowedOrigins = default, string logoutRedirectUri = default)
        {
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
            this.Name = name;
            this.Description = description;
            this.Logo = logo;
            this.Scopes = scopes;
            this.AllowPkce = allowPkce;
            this.IsPublic = isPublic;
            this.WebsiteUrl = websiteUrl;
            this.TermsUrl = termsUrl;
            this.PolicyUrl = policyUrl;
            this.LogoutRedirectUri = logoutRedirectUri;
        }

        /// <summary>
        /// The client name.
        /// </summary>
        /// <value>The client name.</value>
        /*
        <example>Example Client</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The client description.
        /// </summary>
        /// <value>The client description.</value>
        /*
        <example>Description of the client</example>
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
        /// The client scopes.
        /// </summary>
        /// <value>The client scopes.</value>
        /*
        <example>[&quot;read&quot;,&quot;write&quot;]</example>
        */
        [DataMember(Name = "scopes", EmitDefaultValue = false)]
        public List<string> Scopes { get; set; }

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
        /// The URL to the client&#39;s website.
        /// </summary>
        /// <value>The URL to the client&#39;s website.</value>
        /*
        <example>http://example.com</example>
        */
        [DataMember(Name = "website_url", EmitDefaultValue = false)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// The URL to the client&#39;s terms of service.
        /// </summary>
        /// <value>The URL to the client&#39;s terms of service.</value>
        /*
        <example>http://example.com/terms</example>
        */
        [DataMember(Name = "terms_url", EmitDefaultValue = false)]
        public string TermsUrl { get; set; }

        /// <summary>
        /// The URL to the client&#39;s privacy policy.
        /// </summary>
        /// <value>The URL to the client&#39;s privacy policy.</value>
        /*
        <example>http://example.com/policy</example>
        */
        [DataMember(Name = "policy_url", EmitDefaultValue = false)]
        public string PolicyUrl { get; set; }

        /// <summary>
        /// The list of allowed redirect URIs.
        /// </summary>
        /// <value>The list of allowed redirect URIs.</value>
        /*
        <example>[&quot;http://example.com/redirect&quot;]</example>
        */
        [DataMember(Name = "redirect_uris", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RedirectUris { get; set; }

        /// <summary>
        /// The list of allowed CORS origins.
        /// </summary>
        /// <value>The list of allowed CORS origins.</value>
        /*
        <example>[&quot;http://example.com&quot;]</example>
        */
        [DataMember(Name = "allowed_origins", IsRequired = true, EmitDefaultValue = true)]
        public List<string> AllowedOrigins { get; set; }

        /// <summary>
        /// The list of allowed logout redirect URIs.
        /// </summary>
        /// <value>The list of allowed logout redirect URIs.</value>
        /*
        <example>http://example.com/logout</example>
        */
        [DataMember(Name = "logout_redirect_uri", EmitDefaultValue = false)]
        public string LogoutRedirectUri { get; set; }

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
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
            sb.Append("  TermsUrl: ").Append(TermsUrl).Append("\n");
            sb.Append("  PolicyUrl: ").Append(PolicyUrl).Append("\n");
            sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
            sb.Append("  AllowedOrigins: ").Append(AllowedOrigins).Append("\n");
            sb.Append("  LogoutRedirectUri: ").Append(LogoutRedirectUri).Append("\n");
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
                Regex regexWebsiteUrl = new Regex(@"^(https?://)?(([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}|localhost|[a-zA-Z0-9-]+)(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$|^https?://(\d{1,3}\.){3}\d{1,3}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$", RegexOptions.CultureInvariant);
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
                Regex regexTermsUrl = new Regex(@"^(https?://)?(([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}|localhost|[a-zA-Z0-9-]+)(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$|^https?://(\d{1,3}\.){3}\d{1,3}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$", RegexOptions.CultureInvariant);
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
                Regex regexPolicyUrl = new Regex(@"^(https?://)?(([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}|localhost|[a-zA-Z0-9-]+)(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$|^https?://(\d{1,3}\.){3}\d{1,3}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$", RegexOptions.CultureInvariant);
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
                Regex regexLogoutRedirectUri = new Regex(@"^(https?://)?(([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}|localhost|[a-zA-Z0-9-]+)(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$|^https?://(\d{1,3}\.){3}\d{1,3}(:\d+)?(/[a-zA-Z0-9-._~:/?#\[\]@!$&'()*+,;=]*)?$", RegexOptions.CultureInvariant);
                if (!regexLogoutRedirectUri.Match(this.LogoutRedirectUri).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogoutRedirectUri, must match a pattern of " + regexLogoutRedirectUri, new [] { "LogoutRedirectUri" });
                }
            }

            yield break;
        }
    }


}
