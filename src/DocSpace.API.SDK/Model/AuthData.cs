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
        /// <param name="token">The authentication token..</param>
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
        /// <example>user@example.com</example>
        [DataMember(Name = "login", EmitDefaultValue = true)]
        public string Login { get; set; }

        /// <summary>
        /// The authentication password.
        /// </summary>
        /// <example>p@ssw0rd!</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The authentication raw token.
        /// </summary>
        /// <example>{"access_token":"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...","expires_in":3600}</example>
        [DataMember(Name = "rawToken", EmitDefaultValue = true)]
        public string RawToken { get; set; }

        /// <summary>
        /// The authentication URL.
        /// </summary>
        /// <example>https://auth.example.com</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The authentication provider.
        /// </summary>
        /// <example>OAuth2</example>
        [DataMember(Name = "provider", EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// The authentication token.
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
