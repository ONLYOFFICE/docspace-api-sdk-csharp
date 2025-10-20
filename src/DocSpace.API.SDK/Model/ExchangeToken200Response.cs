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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// ExchangeToken200Response
    /// </summary>
    [DataContract(Name = "exchangeToken_200_response")]
    public partial class ExchangeToken200Response : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeToken200Response" /> class.
        /// </summary>
        /// <param name="accessToken">The access token issued by the authorization server..</param>
        /// <param name="tokenType">The type of token issued, typically &#39;Bearer&#39;..</param>
        /// <param name="expiresIn">The number of seconds until the access token expires..</param>
        /// <param name="refreshToken">The token used to obtain a new access token when the current one expires..</param>
        public ExchangeToken200Response(string accessToken = default, string tokenType = default, int expiresIn = default, string refreshToken = default)
        {
            this.AccessToken = accessToken;
            this.TokenType = tokenType;
            this.ExpiresIn = expiresIn;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// The access token issued by the authorization server.
        /// </summary>
        /// <value>The access token issued by the authorization server.</value>
        /*
        <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...</example>
        */
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// The type of token issued, typically &#39;Bearer&#39;.
        /// </summary>
        /// <value>The type of token issued, typically &#39;Bearer&#39;.</value>
        /*
        <example>Bearer</example>
        */
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// The number of seconds until the access token expires.
        /// </summary>
        /// <value>The number of seconds until the access token expires.</value>
        /*
        <example>3600</example>
        */
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// The token used to obtain a new access token when the current one expires.
        /// </summary>
        /// <value>The token used to obtain a new access token when the current one expires.</value>
        /*
        <example>def502...</example>
        */
        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExchangeToken200Response {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
