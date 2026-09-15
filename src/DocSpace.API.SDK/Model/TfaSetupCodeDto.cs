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
    /// The secret to enrol in an authenticator application, in both of the forms an application can take it.
    /// </summary>
    [DataContract(Name = "TfaSetupCodeDto")]
    public partial class TfaSetupCodeDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TfaSetupCodeDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TfaSetupCodeDto()
        {
        }

        /// <summary>
        /// The label the authenticator application will list the credential under, which is the caller&#39;s own email  address. It identifies the entry to a person, and no application checks it.
        /// </summary>
        /// <example>john.doe@onlyoffice.com</example>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public string Account { get; private set; }

        /// <summary>
        /// Returns false as Account should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccount()
        {
            return false;
        }
        /// <summary>
        /// The secret in the base32 form that is typed into an application by hand. It describes the very same  credential as &#x60;qrCodeSetupImageUrl&#x60;, and repeating the call hands back the same value for the account until  the credential is reset.
        /// </summary>
        /// <example>JBSWY3DPEHPK3PXP</example>
        [DataMember(Name = "manualEntryKey", EmitDefaultValue = true)]
        public string ManualEntryKey { get; private set; }

        /// <summary>
        /// Returns false as ManualEntryKey should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeManualEntryKey()
        {
            return false;
        }
        /// <summary>
        /// The same secret as a scannable image, given as a &#x60;data:image/png;base64,&#x60; URL that can be rendered  directly - it is not a link to fetch.
        /// </summary>
        /// <example>data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAAAAAA6fptVAAAACklEQVR4nGMAAgAABAABiCEmiQAAAABJRU5ErkJggg==</example>
        [DataMember(Name = "qrCodeSetupImageUrl", EmitDefaultValue = true)]
        public string QrCodeSetupImageUrl { get; private set; }

        /// <summary>
        /// Returns false as QrCodeSetupImageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeQrCodeSetupImageUrl()
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
            sb.Append("class TfaSetupCodeDto {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  ManualEntryKey: ").Append(ManualEntryKey).Append("\n");
            sb.Append("  QrCodeSetupImageUrl: ").Append(QrCodeSetupImageUrl).Append("\n");
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
