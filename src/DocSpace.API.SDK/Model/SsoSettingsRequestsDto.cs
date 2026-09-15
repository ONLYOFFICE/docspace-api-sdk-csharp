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
    /// The whole SAML Single Sign-On configuration of the portal, carried as a serialised JSON object.
    /// </summary>
    [DataContract(Name = "SsoSettingsRequestsDto")]
    public partial class SsoSettingsRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SsoSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="serializeSettings">The configuration object serialised to a JSON string, not a nested object. It is the complete configuration  rather than a patch - fields left out are stored empty - so start from &#x60;GET api/2.0/settings/ssov2&#x60; or  &#x60;GET api/2.0/settings/ssov2/default&#x60; and send back a changed copy. The identity provider entity ID and  sign-in URL are required, the sign-in and sign-out URLs have to be absolute &#x60;http&#x60; or &#x60;https&#x60; addresses, and  the attribute mapping has to name the first name, last name and email fields; the values each SAML field  accepts are listed by &#x60;GET api/2.0/settings/ssov2/constants&#x60;. An empty string, or a string that carries no  configuration object, is refused with 400. (required).</param>
        public SsoSettingsRequestsDto(string serializeSettings = default)
        {
            // to ensure "serializeSettings" is required (not null)
            if (serializeSettings == null)
            {
                throw new ArgumentNullException("serializeSettings is a required property for SsoSettingsRequestsDto and cannot be null");
            }
            this.SerializeSettings = serializeSettings;
        }

        /// <summary>
        /// The configuration object serialised to a JSON string, not a nested object. It is the complete configuration  rather than a patch - fields left out are stored empty - so start from &#x60;GET api/2.0/settings/ssov2&#x60; or  &#x60;GET api/2.0/settings/ssov2/default&#x60; and send back a changed copy. The identity provider entity ID and  sign-in URL are required, the sign-in and sign-out URLs have to be absolute &#x60;http&#x60; or &#x60;https&#x60; addresses, and  the attribute mapping has to name the first name, last name and email fields; the values each SAML field  accepts are listed by &#x60;GET api/2.0/settings/ssov2/constants&#x60;. An empty string, or a string that carries no  configuration object, is refused with 400.
        /// </summary>
        /// <example>{"enableSso":true,"idpSettings":{"entityId":"https://idp.example.com"}}</example>
        [DataMember(Name = "serializeSettings", IsRequired = true, EmitDefaultValue = true)]
        public string SerializeSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SsoSettingsRequestsDto {\n");
            sb.Append("  SerializeSettings: ").Append(SerializeSettings).Append("\n");
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
