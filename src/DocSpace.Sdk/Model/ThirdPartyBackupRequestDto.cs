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
    /// The third-party backup request parameters.
    /// </summary>
    [DataContract(Name = "ThirdPartyBackupRequestDto")]
    public partial class ThirdPartyBackupRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyBackupRequestDto" /> class.
        /// </summary>
        /// <param name="url">The connection URL for the sharepoint..</param>
        /// <param name="login">The login..</param>
        /// <param name="password">The password..</param>
        /// <param name="token">The authentication token..</param>
        /// <param name="customerTitle">The customer title..</param>
        /// <param name="providerKey">The provider key..</param>
        public ThirdPartyBackupRequestDto(string url = default, string login = default, string password = default, string token = default, string customerTitle = default, string providerKey = default)
        {
            this.Url = url;
            this.Login = login;
            this.Password = password;
            this.Token = token;
            this.CustomerTitle = customerTitle;
            this.ProviderKey = providerKey;
        }

        /// <summary>
        /// The connection URL for the sharepoint.
        /// </summary>
        /// <value>The connection URL for the sharepoint.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The login.
        /// </summary>
        /// <value>The login.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "login", EmitDefaultValue = true)]
        public string Login { get; set; }

        /// <summary>
        /// The password.
        /// </summary>
        /// <value>The password.</value>
        /*
        <example>vfmf2vO1Kp</example>
        */
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The authentication token.
        /// </summary>
        /// <value>The authentication token.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// The customer title.
        /// </summary>
        /// <value>The customer title.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "customerTitle", EmitDefaultValue = true)]
        public string CustomerTitle { get; set; }

        /// <summary>
        /// The provider key.
        /// </summary>
        /// <value>The provider key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "providerKey", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThirdPartyBackupRequestDto {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  CustomerTitle: ").Append(CustomerTitle).Append("\n");
            sb.Append("  ProviderKey: ").Append(ProviderKey).Append("\n");
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
