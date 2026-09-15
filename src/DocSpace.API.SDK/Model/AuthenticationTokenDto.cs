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
    /// The outcome of a sign-in attempt: either the authentication token, or the second factor still to be passed.
    /// </summary>
    [DataContract(Name = "AuthenticationTokenDto")]
    public partial class AuthenticationTokenDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationTokenDto" /> class.
        /// </summary>
        /// <param name="token">The token to put in the &#x60;Authorization&#x60; header of later calls. It is empty whenever a second factor is  still outstanding, which is what &#x60;sms&#x60; or &#x60;tfa&#x60; then says; the same token is also set as a portal cookie by  the call that issued it, so a browser client does not have to carry it itself..</param>
        /// <param name="expires">When the token stops being accepted. It stays at its zero value when &#x60;session&#x3D;true&#x60; tied the token to the  browser session instead of to a fixed moment. On the two operations that only send an SMS it carries a  different meaning: there is no token, and this is the moment the code that was just sent expires..</param>
        /// <param name="sms">Whether an SMS code is the second factor in play. Next to an empty &#x60;token&#x60; it means the code has to be sent  to &#x60;POST api/2.0/authentication/{code}&#x60; before a token is issued; next to a filled &#x60;token&#x60; it means the  code just accepted was an SMS one..</param>
        /// <param name="phoneNoise">The stored phone number with its middle digits masked, filled in only while &#x60;sms&#x60; is set and a number is  already activated for the user. It is there to be shown to the person signing in, not to be sent back..</param>
        /// <param name="tfa">Whether an authenticator app is the second factor in play, with the same two readings as &#x60;sms&#x60;..</param>
        /// <param name="tfaKey">The secret to enrol in an authenticator app, in the manual-entry form. It is filled in only while &#x60;tfa&#x60; is  set and the app has not been connected yet, which is the one moment the secret is handed out; once the app  is connected it stays empty. &#x60;GET api/2.0/settings/tfaapp/setup&#x60; returns the same secret with a QR code..</param>
        /// <param name="confirmUrl">The confirmation link the client has to open to get past the second factor. It points at phone activation  while no number is activated, at authenticator-app activation while the app is not connected, and at the  plain code prompt once either is in place. It is empty in an answer that already carries a token..</param>
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
        /// The token to put in the &#x60;Authorization&#x60; header of later calls. It is empty whenever a second factor is  still outstanding, which is what &#x60;sms&#x60; or &#x60;tfa&#x60; then says; the same token is also set as a portal cookie by  the call that issued it, so a browser client does not have to carry it itself.
        /// </summary>
        /// <example>abcde12345</example>
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// When the token stops being accepted. It stays at its zero value when &#x60;session&#x3D;true&#x60; tied the token to the  browser session instead of to a fixed moment. On the two operations that only send an SMS it carries a  different meaning: there is no token, and this is the moment the code that was just sent expires.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public DateTime Expires { get; set; }

        /// <summary>
        /// Whether an SMS code is the second factor in play. Next to an empty &#x60;token&#x60; it means the code has to be sent  to &#x60;POST api/2.0/authentication/{code}&#x60; before a token is issued; next to a filled &#x60;token&#x60; it means the  code just accepted was an SMS one.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "sms", EmitDefaultValue = true)]
        public bool Sms { get; set; }

        /// <summary>
        /// The stored phone number with its middle digits masked, filled in only while &#x60;sms&#x60; is set and a number is  already activated for the user. It is there to be shown to the person signing in, not to be sent back.
        /// </summary>
        /// <example>+1***1234</example>
        [DataMember(Name = "phoneNoise", EmitDefaultValue = true)]
        public string PhoneNoise { get; set; }

        /// <summary>
        /// Whether an authenticator app is the second factor in play, with the same two readings as &#x60;sms&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "tfa", EmitDefaultValue = true)]
        public bool Tfa { get; set; }

        /// <summary>
        /// The secret to enrol in an authenticator app, in the manual-entry form. It is filled in only while &#x60;tfa&#x60; is  set and the app has not been connected yet, which is the one moment the secret is handed out; once the app  is connected it stays empty. &#x60;GET api/2.0/settings/tfaapp/setup&#x60; returns the same secret with a QR code.
        /// </summary>
        /// <example>JBSWY3DPEHPK3PXP</example>
        [DataMember(Name = "tfaKey", EmitDefaultValue = true)]
        public string TfaKey { get; set; }

        /// <summary>
        /// The confirmation link the client has to open to get past the second factor. It points at phone activation  while no number is activated, at authenticator-app activation while the app is not connected, and at the  plain code prompt once either is in place. It is empty in an answer that already carries a token.
        /// </summary>
        /// <example>https://example.com/confirm?token=abc123</example>
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
