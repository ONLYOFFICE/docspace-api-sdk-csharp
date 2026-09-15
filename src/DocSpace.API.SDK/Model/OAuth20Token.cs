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
    /// The OAuth 2.0 token issued by a third-party provider.
    /// </summary>
    [DataContract(Name = "OAuth20Token")]
    public partial class OAuth20Token : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20Token" /> class.
        /// </summary>
        /// <param name="accessToken">The token sent to the provider with every request made on behalf of the account..</param>
        /// <param name="refreshToken">The token used to obtain a new access token when the current one expires. A provider that issues no refresh  token leaves it empty, and the account then has to be connected again to keep working..</param>
        /// <param name="expiresIn">How long the access token stays usable, in seconds counted from &#x60;timestamp&#x60;. Zero means the provider did not  say, and the token is then treated as expired..</param>
        /// <param name="clientId">The OAuth 2.0 client ID of the application the token was issued to..</param>
        /// <param name="clientSecret">The client secret of the application the token was issued to, needed when the token is refreshed..</param>
        /// <param name="redirectUri">The redirect URL the authorization code behind this token was obtained with; providers require the same value  again when the token is refreshed..</param>
        /// <param name="timestamp">When the token was issued, in UTC. This is the point &#x60;expires_in&#x60; is counted from..</param>
        public OAuth20Token(string accessToken = default, string refreshToken = default, long expiresIn = default, string clientId = default, string clientSecret = default, string redirectUri = default, DateTime timestamp = default)
        {
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
            this.ExpiresIn = expiresIn;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.RedirectUri = redirectUri;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// The token sent to the provider with every request made on behalf of the account.
        /// </summary>
        /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...</example>
        [DataMember(Name = "access_token", EmitDefaultValue = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// The token used to obtain a new access token when the current one expires. A provider that issues no refresh  token leaves it empty, and the account then has to be connected again to keep working.
        /// </summary>
        /// <example>def50200a1b2c3d4e5f6...</example>
        [DataMember(Name = "refresh_token", EmitDefaultValue = true)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// How long the access token stays usable, in seconds counted from &#x60;timestamp&#x60;. Zero means the provider did not  say, and the token is then treated as expired.
        /// </summary>
        /// <example>3600</example>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// The OAuth 2.0 client ID of the application the token was issued to.
        /// </summary>
        /// <example>my-client-id</example>
        [DataMember(Name = "client_id", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// The client secret of the application the token was issued to, needed when the token is refreshed.
        /// </summary>
        /// <example>my-client-secret</example>
        [DataMember(Name = "client_secret", EmitDefaultValue = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The redirect URL the authorization code behind this token was obtained with; providers require the same value  again when the token is refreshed.
        /// </summary>
        /// <example>https://app.example.com/callback</example>
        [DataMember(Name = "redirect_uri", EmitDefaultValue = true)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// When the token was issued, in UTC. This is the point &#x60;expires_in&#x60; is counted from.
        /// </summary>
        /// <example>2026-01-01T00:00:00Z</example>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Whether the access token can no longer be used and has to be refreshed. It is also true when the provider did  not say how long the token lives.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isExpired", EmitDefaultValue = true)]
        public bool IsExpired { get; private set; }

        /// <summary>
        /// Returns false as IsExpired should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsExpired()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuth20Token {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
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
