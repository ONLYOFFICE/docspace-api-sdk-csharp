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
    /// The response containing public client information.
    /// </summary>
    [DataContract(Name = "ClientInfoResponse")]
    public partial class ClientInfoResponse : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInfoResponse" /> class.
        /// </summary>
        /// <param name="name">The client name..</param>
        /// <param name="description">The client description..</param>
        /// <param name="scopes">The client scopes..</param>
        /// <param name="clientId">The client ID..</param>
        /// <param name="websiteUrl">The URL to the client&#39;s website.</param>
        /// <param name="termsUrl">The URL to the client&#39;s terms of service..</param>
        /// <param name="policyUrl">The URL to the client&#39;s privacy policy..</param>
        /// <param name="logo">The client logo in base64 format..</param>
        /// <param name="authenticationMethods">The authentication methods supported by the client..</param>
        /// <param name="isPublic">Indicates whether the client is accessible by third-party tenants..</param>
        /// <param name="createdOn">The date and time when the client was created..</param>
        /// <param name="createdBy">The user who created the client..</param>
        /// <param name="modifiedOn">The date and time when the client was last modified..</param>
        /// <param name="modifiedBy">The user who last modified the client..</param>
        public ClientInfoResponse(string name = default, string description = default, List<string> scopes = default, string clientId = default, string websiteUrl = default, string termsUrl = default, string policyUrl = default, string logo = default, List<string> authenticationMethods = default, bool isPublic = default, DateTime createdOn = default, string createdBy = default, DateTime modifiedOn = default, string modifiedBy = default)
        {
            this.Name = name;
            this.Description = description;
            this.Scopes = scopes;
            this.ClientId = clientId;
            this.WebsiteUrl = websiteUrl;
            this.TermsUrl = termsUrl;
            this.PolicyUrl = policyUrl;
            this.Logo = logo;
            this.AuthenticationMethods = authenticationMethods;
            this.IsPublic = isPublic;
            this.CreatedOn = createdOn;
            this.CreatedBy = createdBy;
            this.ModifiedOn = modifiedOn;
            this.ModifiedBy = modifiedBy;
        }

        /// <summary>
        /// The client name.
        /// </summary>
        /// <value>The client name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The client description.
        /// </summary>
        /// <value>The client description.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The client scopes.
        /// </summary>
        /// <value>The client scopes.</value>
        [DataMember(Name = "scopes", EmitDefaultValue = false)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// The client ID.
        /// </summary>
        /// <value>The client ID.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The URL to the client&#39;s website
        /// </summary>
        /// <value>The URL to the client&#39;s website</value>
        [DataMember(Name = "website_url", EmitDefaultValue = false)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// The URL to the client&#39;s terms of service.
        /// </summary>
        /// <value>The URL to the client&#39;s terms of service.</value>
        [DataMember(Name = "terms_url", EmitDefaultValue = false)]
        public string TermsUrl { get; set; }

        /// <summary>
        /// The URL to the client&#39;s privacy policy.
        /// </summary>
        /// <value>The URL to the client&#39;s privacy policy.</value>
        [DataMember(Name = "policy_url", EmitDefaultValue = false)]
        public string PolicyUrl { get; set; }

        /// <summary>
        /// The client logo in base64 format.
        /// </summary>
        /// <value>The client logo in base64 format.</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// The authentication methods supported by the client.
        /// </summary>
        /// <value>The authentication methods supported by the client.</value>
        [DataMember(Name = "authentication_methods", EmitDefaultValue = false)]
        public List<string> AuthenticationMethods { get; set; }

        /// <summary>
        /// Indicates whether the client is accessible by third-party tenants.
        /// </summary>
        /// <value>Indicates whether the client is accessible by third-party tenants.</value>
        [DataMember(Name = "is_public", EmitDefaultValue = true)]
        public bool IsPublic { get; set; }

        /// <summary>
        /// The date and time when the client was created.
        /// </summary>
        /// <value>The date and time when the client was created.</value>
        [DataMember(Name = "created_on", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// The user who created the client.
        /// </summary>
        /// <value>The user who created the client.</value>
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The date and time when the client was last modified.
        /// </summary>
        /// <value>The date and time when the client was last modified.</value>
        [DataMember(Name = "modified_on", EmitDefaultValue = false)]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// The user who last modified the client.
        /// </summary>
        /// <value>The user who last modified the client.</value>
        [DataMember(Name = "modified_by", EmitDefaultValue = false)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientInfoResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
            sb.Append("  TermsUrl: ").Append(TermsUrl).Append("\n");
            sb.Append("  PolicyUrl: ").Append(PolicyUrl).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  AuthenticationMethods: ").Append(AuthenticationMethods).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
