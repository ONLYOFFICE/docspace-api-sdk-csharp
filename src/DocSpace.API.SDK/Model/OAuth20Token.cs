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
    /// OAuth20Token
    /// </summary>
    [DataContract(Name = "OAuth20Token")]
    public partial class OAuth20Token : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth20Token" /> class.
        /// </summary>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="refreshToken">refreshToken.</param>
        /// <param name="expiresIn">expiresIn.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="clientSecret">clientSecret.</param>
        /// <param name="redirectUri">redirectUri.</param>
        /// <param name="timestamp">timestamp.</param>
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
        /// Gets or Sets AccessToken
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "access_token", EmitDefaultValue = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "refresh_token", EmitDefaultValue = true)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "client_id", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "client_secret", EmitDefaultValue = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or Sets RedirectUri
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "redirect_uri", EmitDefaultValue = true)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets IsExpired
        /// </summary>
        /*
        <example>true</example>
        */
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
