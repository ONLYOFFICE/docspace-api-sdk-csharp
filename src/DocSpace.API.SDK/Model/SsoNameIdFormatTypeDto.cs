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
    /// The SAML name ID formats the SSO settings accept.
    /// </summary>
    [DataContract(Name = "SsoNameIdFormatTypeDto")]
    public partial class SsoNameIdFormatTypeDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoNameIdFormatTypeDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SsoNameIdFormatTypeDto()
        {
        }

        /// <summary>
        /// The SAML 1.1 unspecified name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified</example>
        [DataMember(Name = "saml11Unspecified", EmitDefaultValue = true)]
        public string Saml11Unspecified { get; private set; }

        /// <summary>
        /// Returns false as Saml11Unspecified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml11Unspecified()
        {
            return false;
        }
        /// <summary>
        /// The SAML 1.1 email address name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress</example>
        [DataMember(Name = "saml11EmailAddress", EmitDefaultValue = true)]
        public string Saml11EmailAddress { get; private set; }

        /// <summary>
        /// Returns false as Saml11EmailAddress should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml11EmailAddress()
        {
            return false;
        }
        /// <summary>
        /// The SAML 2.0 entity name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:2.0:nameid-format:entity</example>
        [DataMember(Name = "saml20Entity", EmitDefaultValue = true)]
        public string Saml20Entity { get; private set; }

        /// <summary>
        /// Returns false as Saml20Entity should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml20Entity()
        {
            return false;
        }
        /// <summary>
        /// The SAML 2.0 transient name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:2.0:nameid-format:transient</example>
        [DataMember(Name = "saml20Transient", EmitDefaultValue = true)]
        public string Saml20Transient { get; private set; }

        /// <summary>
        /// Returns false as Saml20Transient should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml20Transient()
        {
            return false;
        }
        /// <summary>
        /// The SAML 2.0 persistent name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:2.0:nameid-format:persistent</example>
        [DataMember(Name = "saml20Persistent", EmitDefaultValue = true)]
        public string Saml20Persistent { get; private set; }

        /// <summary>
        /// Returns false as Saml20Persistent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml20Persistent()
        {
            return false;
        }
        /// <summary>
        /// The SAML 2.0 encrypted name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:2.0:nameid-format:encrypted</example>
        [DataMember(Name = "saml20Encrypted", EmitDefaultValue = true)]
        public string Saml20Encrypted { get; private set; }

        /// <summary>
        /// Returns false as Saml20Encrypted should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml20Encrypted()
        {
            return false;
        }
        /// <summary>
        /// The SAML 2.0 unspecified name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:2.0:nameid-format:unspecified</example>
        [DataMember(Name = "saml20Unspecified", EmitDefaultValue = true)]
        public string Saml20Unspecified { get; private set; }

        /// <summary>
        /// Returns false as Saml20Unspecified should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml20Unspecified()
        {
            return false;
        }
        /// <summary>
        /// The SAML 1.1 X.509 subject name name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:1.1:nameid-format:X509SubjectName</example>
        [DataMember(Name = "saml11X509SubjectName", EmitDefaultValue = true)]
        public string Saml11X509SubjectName { get; private set; }

        /// <summary>
        /// Returns false as Saml11X509SubjectName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml11X509SubjectName()
        {
            return false;
        }
        /// <summary>
        /// The SAML 1.1 Windows domain qualified name name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:1.1:nameid-format:WindowsDomainQualifiedName</example>
        [DataMember(Name = "saml11WindowsDomainQualifiedName", EmitDefaultValue = true)]
        public string Saml11WindowsDomainQualifiedName { get; private set; }

        /// <summary>
        /// Returns false as Saml11WindowsDomainQualifiedName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml11WindowsDomainQualifiedName()
        {
            return false;
        }
        /// <summary>
        /// The SAML 2.0 Kerberos name ID format.
        /// </summary>
        /// <example>urn:oasis:names:tc:SAML:2.0:nameid-format:kerberos</example>
        [DataMember(Name = "saml20Kerberos", EmitDefaultValue = true)]
        public string Saml20Kerberos { get; private set; }

        /// <summary>
        /// Returns false as Saml20Kerberos should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaml20Kerberos()
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
            sb.Append("class SsoNameIdFormatTypeDto {\n");
            sb.Append("  Saml11Unspecified: ").Append(Saml11Unspecified).Append("\n");
            sb.Append("  Saml11EmailAddress: ").Append(Saml11EmailAddress).Append("\n");
            sb.Append("  Saml20Entity: ").Append(Saml20Entity).Append("\n");
            sb.Append("  Saml20Transient: ").Append(Saml20Transient).Append("\n");
            sb.Append("  Saml20Persistent: ").Append(Saml20Persistent).Append("\n");
            sb.Append("  Saml20Encrypted: ").Append(Saml20Encrypted).Append("\n");
            sb.Append("  Saml20Unspecified: ").Append(Saml20Unspecified).Append("\n");
            sb.Append("  Saml11X509SubjectName: ").Append(Saml11X509SubjectName).Append("\n");
            sb.Append("  Saml11WindowsDomainQualifiedName: ").Append(Saml11WindowsDomainQualifiedName).Append("\n");
            sb.Append("  Saml20Kerberos: ").Append(Saml20Kerberos).Append("\n");
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
