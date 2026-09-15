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
    /// The confirmation link the caller has to follow to pass the two-factor step, and the cookie it depends on.
    /// </summary>
    [DataContract(Name = "TfaConfirmDataDto")]
    public partial class TfaConfirmDataDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TfaConfirmDataDto" /> class.
        /// </summary>
        /// <param name="url">The link to open. Its &#x60;type&#x60; shows which step it is: phone activation or phone authorization for the SMS  method, and authenticator activation or re-verification for the application method. The whole body is empty  when the portal requires no second factor of the caller..</param>
        /// <param name="cookieName">The name of the confirmation cookie the link is validated against. It is filled in only for the  authenticator-application method; the SMS method returns &#x60;url&#x60; alone..</param>
        /// <param name="cookieValue">The value of that cookie. The call already set it on the response, so it is repeated here only for a client  that does not keep cookies of its own; it is filled in under the same condition as &#x60;cookieName&#x60;, and a  later call to this operation replaces it..</param>
        public TfaConfirmDataDto(string url = default, string cookieName = default, string cookieValue = default)
        {
            this.Url = url;
            this.CookieName = cookieName;
            this.CookieValue = cookieValue;
        }

        /// <summary>
        /// The link to open. Its &#x60;type&#x60; shows which step it is: phone activation or phone authorization for the SMS  method, and authenticator activation or re-verification for the application method. The whole body is empty  when the portal requires no second factor of the caller.
        /// </summary>
        /// <example>https://example.com/confirm?type=TfaAuth&amp;key=abc123</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The name of the confirmation cookie the link is validated against. It is filled in only for the  authenticator-application method; the SMS method returns &#x60;url&#x60; alone.
        /// </summary>
        /// <example>asc_confirm_key_TfaAuth</example>
        [DataMember(Name = "cookieName", EmitDefaultValue = true)]
        public string CookieName { get; set; }

        /// <summary>
        /// The value of that cookie. The call already set it on the response, so it is repeated here only for a client  that does not keep cookies of its own; it is filled in under the same condition as &#x60;cookieName&#x60;, and a  later call to this operation replaces it.
        /// </summary>
        /// <example>1234567890.abcdef</example>
        [DataMember(Name = "cookieValue", EmitDefaultValue = true)]
        public string CookieValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaConfirmDataDto {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  CookieName: ").Append(CookieName).Append("\n");
            sb.Append("  CookieValue: ").Append(CookieValue).Append("\n");
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
