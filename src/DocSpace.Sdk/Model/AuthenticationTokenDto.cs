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
    /// The authentication token parameters.
    /// </summary>
    [DataContract(Name = "AuthenticationTokenDto")]
    public partial class AuthenticationTokenDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationTokenDto" /> class.
        /// </summary>
        /// <param name="token">The authentication token..</param>
        /// <param name="expires">The token expiration time..</param>
        /// <param name="sms">Specifies if the authentication code is sent by SMS or not..</param>
        /// <param name="phoneNoise">The phone number..</param>
        /// <param name="tfa">Specifies if the two-factor application is used or not..</param>
        /// <param name="tfaKey">The two-factor authentication key..</param>
        /// <param name="confirmUrl">The confirmation email URL..</param>
        public AuthenticationTokenDto(string token = default, DateTime expires = default, bool sms = default, string phoneNoise = default, bool tfa = default, string tfaKey = default, string confirmUrl = default)
        {
            this.Token = token;
            this.Expires = expires;
            this.Sms = sms;
            this.PhoneNoise = phoneNoise;
            this.Tfa = tfa;
            this.TfaKey = tfaKey;
            this.ConfirmUrl = confirmUrl;
        }

        /// <summary>
        /// The authentication token.
        /// </summary>
        /// <value>The authentication token.</value>
        /*
        <example>abcde12345</example>
        */
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// The token expiration time.
        /// </summary>
        /// <value>The token expiration time.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public DateTime Expires { get; set; }

        /// <summary>
        /// Specifies if the authentication code is sent by SMS or not.
        /// </summary>
        /// <value>Specifies if the authentication code is sent by SMS or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "sms", EmitDefaultValue = true)]
        public bool Sms { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        /// <value>The phone number.</value>
        [DataMember(Name = "phoneNoise", EmitDefaultValue = true)]
        public string PhoneNoise { get; set; }

        /// <summary>
        /// Specifies if the two-factor application is used or not.
        /// </summary>
        /// <value>Specifies if the two-factor application is used or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "tfa", EmitDefaultValue = true)]
        public bool Tfa { get; set; }

        /// <summary>
        /// The two-factor authentication key.
        /// </summary>
        /// <value>The two-factor authentication key.</value>
        [DataMember(Name = "tfaKey", EmitDefaultValue = true)]
        public string TfaKey { get; set; }

        /// <summary>
        /// The confirmation email URL.
        /// </summary>
        /// <value>The confirmation email URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "confirmUrl", EmitDefaultValue = true)]
        public string ConfirmUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationTokenDto {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  PhoneNoise: ").Append(PhoneNoise).Append("\n");
            sb.Append("  Tfa: ").Append(Tfa).Append("\n");
            sb.Append("  TfaKey: ").Append(TfaKey).Append("\n");
            sb.Append("  ConfirmUrl: ").Append(ConfirmUrl).Append("\n");
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
