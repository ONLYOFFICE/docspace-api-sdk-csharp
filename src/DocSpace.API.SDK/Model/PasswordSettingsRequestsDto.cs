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
    /// The request parameters for configuring the password complexity requirements.
    /// </summary>
    [DataContract(Name = "PasswordSettingsRequestsDto")]
    public partial class PasswordSettingsRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="minLength">The minimum number of characters required for valid passwords..</param>
        /// <param name="upperCase">Specifies whether the password should contain the uppercase letters or not..</param>
        /// <param name="digits">Specifies whether the password should contain the digits or not..</param>
        /// <param name="specSymbols">Specifies whether the password should contain the special symbols or not..</param>
        public PasswordSettingsRequestsDto(int minLength = default, bool upperCase = default, bool digits = default, bool specSymbols = default)
        {
            this.MinLength = minLength;
            this.UpperCase = upperCase;
            this.Digits = digits;
            this.SpecSymbols = specSymbols;
        }

        /// <summary>
        /// The minimum number of characters required for valid passwords.
        /// </summary>
        /// <value>The minimum number of characters required for valid passwords.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "minLength", EmitDefaultValue = false)]
        public int MinLength { get; set; }

        /// <summary>
        /// Specifies whether the password should contain the uppercase letters or not.
        /// </summary>
        /// <value>Specifies whether the password should contain the uppercase letters or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "upperCase", EmitDefaultValue = true)]
        public bool UpperCase { get; set; }

        /// <summary>
        /// Specifies whether the password should contain the digits or not.
        /// </summary>
        /// <value>Specifies whether the password should contain the digits or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "digits", EmitDefaultValue = true)]
        public bool Digits { get; set; }

        /// <summary>
        /// Specifies whether the password should contain the special symbols or not.
        /// </summary>
        /// <value>Specifies whether the password should contain the special symbols or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "specSymbols", EmitDefaultValue = true)]
        public bool SpecSymbols { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordSettingsRequestsDto {\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  UpperCase: ").Append(UpperCase).Append("\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
            sb.Append("  SpecSymbols: ").Append(SpecSymbols).Append("\n");
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
