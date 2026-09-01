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
    /// The SSO IdP settings.
    /// </summary>
    [DataContract(Name = "SsoIdpSettings")]
    public partial class SsoIdpSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoIdpSettings" /> class.
        /// </summary>
        /// <param name="entityId">The entity ID..</param>
        /// <param name="ssoUrl">The SSO URL..</param>
        /// <param name="ssoBinding">The SSO binding..</param>
        /// <param name="sloUrl">The SLO URL..</param>
        /// <param name="sloBinding">The SLO binding..</param>
        /// <param name="nameIdFormat">The name ID format..</param>
        public SsoIdpSettings(string entityId = default, string ssoUrl = default, string ssoBinding = default, string sloUrl = default, string sloBinding = default, string nameIdFormat = default)
        {
            this.EntityId = entityId;
            this.SsoUrl = ssoUrl;
            this.SsoBinding = ssoBinding;
            this.SloUrl = sloUrl;
            this.SloBinding = sloBinding;
            this.NameIdFormat = nameIdFormat;
        }

        /// <summary>
        /// The entity ID.
        /// </summary>
        /// <example>https://idp.company.com/saml</example>
        [DataMember(Name = "entityId", EmitDefaultValue = true)]
        public string EntityId { get; set; }

        /// <summary>
        /// The SSO URL.
        /// </summary>
        /// <example>https://idp.example.com/sso</example>
        [DataMember(Name = "ssoUrl", EmitDefaultValue = true)]
        public string SsoUrl { get; set; }

        /// <summary>
        /// The SSO binding.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect</example>
        [DataMember(Name = "ssoBinding", EmitDefaultValue = true)]
        public string SsoBinding { get; set; }

        /// <summary>
        /// The SLO URL.
        /// </summary>
        /// <example>https://idp.example.com/slo</example>
        [DataMember(Name = "sloUrl", EmitDefaultValue = true)]
        public string SloUrl { get; set; }

        /// <summary>
        /// The SLO binding.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect</example>
        [DataMember(Name = "sloBinding", EmitDefaultValue = true)]
        public string SloBinding { get; set; }

        /// <summary>
        /// The name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress</example>
        [DataMember(Name = "nameIdFormat", EmitDefaultValue = true)]
        public string NameIdFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SsoIdpSettings {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  SsoUrl: ").Append(SsoUrl).Append("\n");
            sb.Append("  SsoBinding: ").Append(SsoBinding).Append("\n");
            sb.Append("  SloUrl: ").Append(SloUrl).Append("\n");
            sb.Append("  SloBinding: ").Append(SloBinding).Append("\n");
            sb.Append("  NameIdFormat: ").Append(NameIdFormat).Append("\n");
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
