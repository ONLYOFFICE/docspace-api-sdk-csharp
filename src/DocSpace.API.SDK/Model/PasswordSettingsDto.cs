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
    /// The password settings parameters.
    /// </summary>
    [DataContract(Name = "PasswordSettingsDto")]
    public partial class PasswordSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordSettingsDto" /> class.
        /// </summary>
        /// <param name="minLength">The minimum number of characters required for valid passwords. (required).</param>
        /// <param name="upperCase">Specifies whether the password should contain the uppercase letters or not. (required).</param>
        /// <param name="digits">Specifies whether the password should contain the digits or not. (required).</param>
        /// <param name="specSymbols">Specifies whether the password should contain the special symbols or not. (required).</param>
        /// <param name="allowedCharactersRegexStr">The allowed password characters in the regex string format. (required).</param>
        /// <param name="digitsRegexStr">The password digits in the regex string format. (required).</param>
        /// <param name="upperCaseRegexStr">The password uppercase letters in the regex string format. (required).</param>
        /// <param name="specSymbolsRegexStr">The passaword special symbols in the regex string format. (required).</param>
        public PasswordSettingsDto(int minLength = default, bool upperCase = default, bool digits = default, bool specSymbols = default, string allowedCharactersRegexStr = default, string digitsRegexStr = default, string upperCaseRegexStr = default, string specSymbolsRegexStr = default)
        {
            this.MinLength = minLength;
            this.UpperCase = upperCase;
            this.Digits = digits;
            this.SpecSymbols = specSymbols;
            // to ensure "allowedCharactersRegexStr" is required (not null)
            if (allowedCharactersRegexStr == null)
            {
                throw new ArgumentNullException("allowedCharactersRegexStr is a required property for PasswordSettingsDto and cannot be null");
            }
            this.AllowedCharactersRegexStr = allowedCharactersRegexStr;
            // to ensure "digitsRegexStr" is required (not null)
            if (digitsRegexStr == null)
            {
                throw new ArgumentNullException("digitsRegexStr is a required property for PasswordSettingsDto and cannot be null");
            }
            this.DigitsRegexStr = digitsRegexStr;
            // to ensure "upperCaseRegexStr" is required (not null)
            if (upperCaseRegexStr == null)
            {
                throw new ArgumentNullException("upperCaseRegexStr is a required property for PasswordSettingsDto and cannot be null");
            }
            this.UpperCaseRegexStr = upperCaseRegexStr;
            // to ensure "specSymbolsRegexStr" is required (not null)
            if (specSymbolsRegexStr == null)
            {
                throw new ArgumentNullException("specSymbolsRegexStr is a required property for PasswordSettingsDto and cannot be null");
            }
            this.SpecSymbolsRegexStr = specSymbolsRegexStr;
        }

        /// <summary>
        /// The minimum number of characters required for valid passwords.
        /// </summary>
        /// <value>The minimum number of characters required for valid passwords.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "minLength", IsRequired = true, EmitDefaultValue = true)]
        public int MinLength { get; set; }

        /// <summary>
        /// Specifies whether the password should contain the uppercase letters or not.
        /// </summary>
        /// <value>Specifies whether the password should contain the uppercase letters or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "upperCase", IsRequired = true, EmitDefaultValue = true)]
        public bool UpperCase { get; set; }

        /// <summary>
        /// Specifies whether the password should contain the digits or not.
        /// </summary>
        /// <value>Specifies whether the password should contain the digits or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "digits", IsRequired = true, EmitDefaultValue = true)]
        public bool Digits { get; set; }

        /// <summary>
        /// Specifies whether the password should contain the special symbols or not.
        /// </summary>
        /// <value>Specifies whether the password should contain the special symbols or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "specSymbols", IsRequired = true, EmitDefaultValue = true)]
        public bool SpecSymbols { get; set; }

        /// <summary>
        /// The allowed password characters in the regex string format.
        /// </summary>
        /// <value>The allowed password characters in the regex string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "allowedCharactersRegexStr", IsRequired = true, EmitDefaultValue = true)]
        public string AllowedCharactersRegexStr { get; set; }

        /// <summary>
        /// The password digits in the regex string format.
        /// </summary>
        /// <value>The password digits in the regex string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "digitsRegexStr", IsRequired = true, EmitDefaultValue = true)]
        public string DigitsRegexStr { get; set; }

        /// <summary>
        /// The password uppercase letters in the regex string format.
        /// </summary>
        /// <value>The password uppercase letters in the regex string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "upperCaseRegexStr", IsRequired = true, EmitDefaultValue = true)]
        public string UpperCaseRegexStr { get; set; }

        /// <summary>
        /// The passaword special symbols in the regex string format.
        /// </summary>
        /// <value>The passaword special symbols in the regex string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "specSymbolsRegexStr", IsRequired = true, EmitDefaultValue = true)]
        public string SpecSymbolsRegexStr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordSettingsDto {\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  UpperCase: ").Append(UpperCase).Append("\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
            sb.Append("  SpecSymbols: ").Append(SpecSymbols).Append("\n");
            sb.Append("  AllowedCharactersRegexStr: ").Append(AllowedCharactersRegexStr).Append("\n");
            sb.Append("  DigitsRegexStr: ").Append(DigitsRegexStr).Append("\n");
            sb.Append("  UpperCaseRegexStr: ").Append(UpperCaseRegexStr).Append("\n");
            sb.Append("  SpecSymbolsRegexStr: ").Append(SpecSymbolsRegexStr).Append("\n");
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
