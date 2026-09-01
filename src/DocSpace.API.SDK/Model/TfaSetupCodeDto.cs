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
    /// The setup TFA code parameters.
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
        /// The account for which the setup code is generated.
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
        /// The manual entry key.
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
        /// The QR-code setup image URL (base64-encoded PNG image).
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
