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
    /// The parameters required for the user authentication requests.
    /// </summary>
    [DataContract(Name = "AuthRequestsDto")]
    public partial class AuthRequestsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RecaptchaType
        /// </summary>
        [DataMember(Name = "recaptchaType", EmitDefaultValue = false)]
        public RecaptchaType? RecaptchaType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthRequestsDto" /> class.
        /// </summary>
        /// <param name="userName">The username or email used for authentication..</param>
        /// <param name="password">The password in plain text for user authentication..</param>
        /// <param name="passwordHash">The hashed password for secure verification..</param>
        /// <param name="provider">The type of authentication provider (e.g., internal, Google, Azure)..</param>
        /// <param name="accessToken">The access token used for authentication with external providers..</param>
        /// <param name="serializedProfile">The serialized user profile data, if applicable..</param>
        /// <param name="codeOAuth">The authorization code used for obtaining OAuth tokens..</param>
        /// <param name="session">Specifies whether the authentication is session-based..</param>
        /// <param name="confirmData">confirmData.</param>
        /// <param name="recaptchaType">recaptchaType.</param>
        /// <param name="recaptchaResponse">The user&#39;s response to the CAPTCHA challenge..</param>
        /// <param name="culture">The culture code for localization during authentication..</param>
        public AuthRequestsDto(string userName = default, string password = default, string passwordHash = default, string provider = default, string accessToken = default, string serializedProfile = default, string codeOAuth = default, bool session = default, ConfirmData confirmData = default, RecaptchaType? recaptchaType = default, string recaptchaResponse = default, string culture = default)
        {
            this.UserName = userName;
            this.Password = password;
            this.PasswordHash = passwordHash;
            this.Provider = provider;
            this.AccessToken = accessToken;
            this.SerializedProfile = serializedProfile;
            this.CodeOAuth = codeOAuth;
            this.Session = session;
            this.ConfirmData = confirmData;
            this.RecaptchaType = recaptchaType;
            this.RecaptchaResponse = recaptchaResponse;
            this.Culture = culture;
        }

        /// <summary>
        /// The username or email used for authentication.
        /// </summary>
        /// <value>The username or email used for authentication.</value>
        /*
        <example>user@example.com</example>
        */
        [DataMember(Name = "userName", EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// The password in plain text for user authentication.
        /// </summary>
        /// <value>The password in plain text for user authentication.</value>
        /*
        <example>SecurePassword123!</example>
        */
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The hashed password for secure verification.
        /// </summary>
        /// <value>The hashed password for secure verification.</value>
        /*
        <example>5f4dcc3b5aa765d61d8327deb882cf99</example>
        */
        [DataMember(Name = "passwordHash", EmitDefaultValue = true)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// The type of authentication provider (e.g., internal, Google, Azure).
        /// </summary>
        /// <value>The type of authentication provider (e.g., internal, Google, Azure).</value>
        /*
        <example>google</example>
        */
        [DataMember(Name = "provider", EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// The access token used for authentication with external providers.
        /// </summary>
        /// <value>The access token used for authentication with external providers.</value>
        /*
        <example>ya29.a0AfH6SMBx...</example>
        */
        [DataMember(Name = "accessToken", EmitDefaultValue = true)]
        public string AccessToken { get; set; }

        /// <summary>
        /// The serialized user profile data, if applicable.
        /// </summary>
        /// <value>The serialized user profile data, if applicable.</value>
        /*
        <example>{"name":"John Doe","email":"john@example.com"}</example>
        */
        [DataMember(Name = "serializedProfile", EmitDefaultValue = true)]
        public string SerializedProfile { get; set; }

        /// <summary>
        /// The authorization code used for obtaining OAuth tokens.
        /// </summary>
        /// <value>The authorization code used for obtaining OAuth tokens.</value>
        /*
        <example>4/0AY0e-g7...</example>
        */
        [DataMember(Name = "codeOAuth", EmitDefaultValue = true)]
        public string CodeOAuth { get; set; }

        /// <summary>
        /// Specifies whether the authentication is session-based.
        /// </summary>
        /// <value>Specifies whether the authentication is session-based.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "session", EmitDefaultValue = true)]
        public bool Session { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmData
        /// </summary>
        [DataMember(Name = "confirmData", EmitDefaultValue = false)]
        public ConfirmData ConfirmData { get; set; }

        /// <summary>
        /// The user&#39;s response to the CAPTCHA challenge.
        /// </summary>
        /// <value>The user&#39;s response to the CAPTCHA challenge.</value>
        /*
        <example>03AGdBq25...</example>
        */
        [DataMember(Name = "recaptchaResponse", EmitDefaultValue = true)]
        public string RecaptchaResponse { get; set; }

        /// <summary>
        /// The culture code for localization during authentication.
        /// </summary>
        /// <value>The culture code for localization during authentication.</value>
        /*
        <example>en-US</example>
        */
        [DataMember(Name = "culture", EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthRequestsDto {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PasswordHash: ").Append(PasswordHash).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  SerializedProfile: ").Append(SerializedProfile).Append("\n");
            sb.Append("  CodeOAuth: ").Append(CodeOAuth).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  ConfirmData: ").Append(ConfirmData).Append("\n");
            sb.Append("  RecaptchaType: ").Append(RecaptchaType).Append("\n");
            sb.Append("  RecaptchaResponse: ").Append(RecaptchaResponse).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
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
