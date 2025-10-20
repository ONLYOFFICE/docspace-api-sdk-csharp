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
    /// The authentication data.
    /// </summary>
    [DataContract(Name = "AuthData")]
    public partial class AuthData : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthData" /> class.
        /// </summary>
        /// <param name="login">The authentication login..</param>
        /// <param name="password">The authentication password..</param>
        /// <param name="rawToken">The authentication raw token..</param>
        /// <param name="url">The authentication URL..</param>
        /// <param name="provider">The authentication provider..</param>
        /// <param name="token">token.</param>
        public AuthData(string login = default, string password = default, string rawToken = default, string url = default, string provider = default, OAuth20Token token = default)
        {
            this.Login = login;
            this.Password = password;
            this.RawToken = rawToken;
            this.Url = url;
            this.Provider = provider;
            this.Token = token;
        }

        /// <summary>
        /// The authentication login.
        /// </summary>
        /// <value>The authentication login.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "login", EmitDefaultValue = true)]
        public string Login { get; set; }

        /// <summary>
        /// The authentication password.
        /// </summary>
        /// <value>The authentication password.</value>
        /*
        <example>vfmf2vO1Kp</example>
        */
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The authentication raw token.
        /// </summary>
        /// <value>The authentication raw token.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "rawToken", EmitDefaultValue = true)]
        public string RawToken { get; set; }

        /// <summary>
        /// The authentication URL.
        /// </summary>
        /// <value>The authentication URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The authentication provider.
        /// </summary>
        /// <value>The authentication provider.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "provider", EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public OAuth20Token Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthData {\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  RawToken: ").Append(RawToken).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
