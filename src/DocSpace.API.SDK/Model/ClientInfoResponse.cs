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
    /// The consent-facing subset of a client: everything needed to render a consent screen, and nothing that would let a caller act as the client.
    /// </summary>
    [DataContract(Name = "ClientInfoResponse")]
    public partial class ClientInfoResponse : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientInfoResponse" /> class.
        /// </summary>
        /// <param name="name">The display name shown to the user on the consent screen, between 3 and 256 characters..</param>
        /// <param name="description">The free-text description shown next to the name on the consent screen, at most 255 characters..</param>
        /// <param name="scopes">The permissions the client may ask for, named as they appear in the tenant scope catalogue - for example files:read, rooms:write or openid. A client cannot request a scope that is not listed here..</param>
        /// <param name="clientId">The generated identifier of the client, sent as client_id in every OAuth2 request. It is assigned when the client is registered and never changes afterwards..</param>
        /// <param name="websiteUrl">The URL of the client home page, offered to the user before they consent..</param>
        /// <param name="termsUrl">The URL of the client terms of service, linked from the consent screen..</param>
        /// <param name="policyUrl">The URL of the client privacy policy, linked from the consent screen..</param>
        /// <param name="logo">The client logo as a data URI carrying base64 image data, shown on the consent screen. Only png, jpeg, jpg and svg+xml are accepted, the whole string may not exceed 2000000 characters and the decoded image may not exceed 256000 bytes..</param>
        /// <param name="authenticationMethods">How the client authenticates itself at the token endpoint: client_secret_post for a confidential client that sends its secret, none for a public client that proves itself with PKCE instead..</param>
        /// <param name="createdOn">When the client was registered, as an ISO-8601 timestamp with a zone offset..</param>
        /// <param name="createdBy">The identifier of the user who registered the client. A plain user may read and change only the clients where this is their own identifier..</param>
        /// <param name="modifiedOn">When the client was last changed, as an ISO-8601 timestamp with a zone offset..</param>
        /// <param name="modifiedBy">The identifier of the user who last changed the client..</param>
        /// <param name="isPublic">Whether the client is offered to third-party tenants rather than only to the tenant that registered it..</param>
        public ClientInfoResponse(string name = default, string description = default, List<string> scopes = default, string clientId = default, string websiteUrl = default, string termsUrl = default, string policyUrl = default, string logo = default, List<string> authenticationMethods = default, DateTime createdOn = default, string createdBy = default, DateTime modifiedOn = default, string modifiedBy = default, bool isPublic = default)
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
            this.CreatedOn = createdOn;
            this.CreatedBy = createdBy;
            this.ModifiedOn = modifiedOn;
            this.ModifiedBy = modifiedBy;
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// The display name shown to the user on the consent screen, between 3 and 256 characters.
        /// </summary>
        /// <example>Example Name</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The free-text description shown next to the name on the consent screen, at most 255 characters.
        /// </summary>
        /// <example>Example Description</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The permissions the client may ask for, named as they appear in the tenant scope catalogue - for example files:read, rooms:write or openid. A client cannot request a scope that is not listed here.
        /// </summary>
        [DataMember(Name = "scopes", EmitDefaultValue = false)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// The generated identifier of the client, sent as client_id in every OAuth2 request. It is assigned when the client is registered and never changes afterwards.
        /// </summary>
        /// <example>6c7cf17b-1bd3-47d5-94c6-be2d3570e168</example>
        [DataMember(Name = "client_id", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The URL of the client home page, offered to the user before they consent.
        /// </summary>
        /// <example>http://example.com</example>
        [DataMember(Name = "website_url", EmitDefaultValue = false)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// The URL of the client terms of service, linked from the consent screen.
        /// </summary>
        /// <example>http://example.com</example>
        [DataMember(Name = "terms_url", EmitDefaultValue = false)]
        public string TermsUrl { get; set; }

        /// <summary>
        /// The URL of the client privacy policy, linked from the consent screen.
        /// </summary>
        /// <example>http://example.com</example>
        [DataMember(Name = "policy_url", EmitDefaultValue = false)]
        public string PolicyUrl { get; set; }

        /// <summary>
        /// The client logo as a data URI carrying base64 image data, shown on the consent screen. Only png, jpeg, jpg and svg+xml are accepted, the whole string may not exceed 2000000 characters and the decoded image may not exceed 256000 bytes.
        /// </summary>
        /// <example>data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAADUlEQVR42mP8z8BQDwAEhQGAhKmMIQAAAABJRU5ErkJggg==</example>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// How the client authenticates itself at the token endpoint: client_secret_post for a confidential client that sends its secret, none for a public client that proves itself with PKCE instead.
        /// </summary>
        [DataMember(Name = "authentication_methods", EmitDefaultValue = false)]
        public List<string> AuthenticationMethods { get; set; }

        /// <summary>
        /// When the client was registered, as an ISO-8601 timestamp with a zone offset.
        /// </summary>
        /// <example>2024-04-04T12:00:00Z</example>
        [DataMember(Name = "created_on", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// The identifier of the user who registered the client. A plain user may read and change only the clients where this is their own identifier.
        /// </summary>
        /// <example>6c7cf17b-1bd3-47d5-94c6-be2d3570e168</example>
        [DataMember(Name = "created_by", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// When the client was last changed, as an ISO-8601 timestamp with a zone offset.
        /// </summary>
        /// <example>2024-04-04T12:00:00Z</example>
        [DataMember(Name = "modified_on", EmitDefaultValue = false)]
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// The identifier of the user who last changed the client.
        /// </summary>
        /// <example>6c7cf17b-1bd3-47d5-94c6-be2d3570e168</example>
        [DataMember(Name = "modified_by", EmitDefaultValue = false)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Whether the client is offered to third-party tenants rather than only to the tenant that registered it.
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
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
            yield break;
        }

    }


}
