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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// SetupCode
    /// </summary>
    [DataContract(Name = "SetupCode")]
    public partial class SetupCode : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SetupCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SetupCode()
        {
        }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        /*
        <example>some text</example>
        */
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
        /// Gets or Sets ManualEntryKey
        /// </summary>
        /*
        <example>some text</example>
        */
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
        /// Gets or Sets QrCodeSetupImageUrl
        /// </summary>
        /*
        <example>some text</example>
        */
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
            sb.Append("class SetupCode {\n");
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
