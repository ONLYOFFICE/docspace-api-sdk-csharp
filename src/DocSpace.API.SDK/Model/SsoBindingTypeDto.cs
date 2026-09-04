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
    /// The SAML bindings the SSO settings accept.
    /// </summary>
    [DataContract(Name = "SsoBindingTypeDto")]
    public partial class SsoBindingTypeDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoBindingTypeDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SsoBindingTypeDto()
        {
        }

        /// <summary>
        /// The SAML 2.0 HTTP POST binding.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST</example>
        [DataMember(Name = "saml20HttpPost", EmitDefaultValue = true)]
        public string Saml20HttpPost { get; private set; }

        /// <summary>
        /// Returns false as Saml20HttpPost should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml20HttpPost()
        {
            return false;
        }
        /// <summary>
        /// The SAML 2.0 HTTP redirect binding.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect</example>
        [DataMember(Name = "saml20HttpRedirect", EmitDefaultValue = true)]
        public string Saml20HttpRedirect { get; private set; }

        /// <summary>
        /// Returns false as Saml20HttpRedirect should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml20HttpRedirect()
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
            sb.Append("class SsoBindingTypeDto {\n");
            sb.Append("  Saml20HttpPost: ").Append(Saml20HttpPost).Append("\n");
            sb.Append("  Saml20HttpRedirect: ").Append(Saml20HttpRedirect).Append("\n");
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
