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
    /// The password policy of the portal, with the expressions a client can check a password against.
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
        /// <param name="minLength">The shortest password the portal accepts, 8 characters on a portal nobody has configured. Whatever the  policy says, a password longer than 30 characters is refused as well, and that ceiling is not reported  here. (required).</param>
        /// <param name="upperCase">Whether at least one uppercase letter is demanded. While it is &#x60;false&#x60; an uppercase letter is still  allowed - the flag adds a requirement rather than permission. (required).</param>
        /// <param name="digits">Whether at least one digit is demanded, read the same way as &#x60;upperCase&#x60;. (required).</param>
        /// <param name="specSymbols">Whether at least one special symbol is demanded, read the same way as &#x60;upperCase&#x60;. Which symbols count is  spelled out by &#x60;specSymbolsRegexStr&#x60;. (required).</param>
        /// <param name="allowedCharactersRegexStr">The expression the whole password has to match, which is what defines the alphabet the portal accepts at  all. It comes from the installation&#39;s configuration rather than from the portal policy, so it is the same  for every portal of an installation and unaffected by the flags above. (required).</param>
        /// <param name="digitsRegexStr">The look-ahead expression that tests the digit requirement, meant to be applied only while &#x60;digits&#x60; is  &#x60;true&#x60;. It is always filled in, so its presence is not itself a requirement. (required).</param>
        /// <param name="upperCaseRegexStr">The look-ahead expression that tests the uppercase requirement, to be applied while &#x60;upperCase&#x60; is &#x60;true&#x60;. (required).</param>
        /// <param name="specSymbolsRegexStr">The look-ahead expression that tests the special-symbol requirement, to be applied while &#x60;specSymbols&#x60; is  &#x60;true&#x60;. It also enumerates the symbols the portal treats as special. (required).</param>
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
        /// The shortest password the portal accepts, 8 characters on a portal nobody has configured. Whatever the  policy says, a password longer than 30 characters is refused as well, and that ceiling is not reported  here.
        /// </summary>
        /// <example>8</example>
        [DataMember(Name = "minLength", IsRequired = true, EmitDefaultValue = true)]
        public int MinLength { get; set; }

        /// <summary>
        /// Whether at least one uppercase letter is demanded. While it is &#x60;false&#x60; an uppercase letter is still  allowed - the flag adds a requirement rather than permission.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "upperCase", IsRequired = true, EmitDefaultValue = true)]
        public bool UpperCase { get; set; }

        /// <summary>
        /// Whether at least one digit is demanded, read the same way as &#x60;upperCase&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "digits", IsRequired = true, EmitDefaultValue = true)]
        public bool Digits { get; set; }

        /// <summary>
        /// Whether at least one special symbol is demanded, read the same way as &#x60;upperCase&#x60;. Which symbols count is  spelled out by &#x60;specSymbolsRegexStr&#x60;.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "specSymbols", IsRequired = true, EmitDefaultValue = true)]
        public bool SpecSymbols { get; set; }

        /// <summary>
        /// The expression the whole password has to match, which is what defines the alphabet the portal accepts at  all. It comes from the installation&#39;s configuration rather than from the portal policy, so it is the same  for every portal of an installation and unaffected by the flags above.
        /// </summary>
        /// <example>^[a-zA-Z0-9!@#$%^&amp;*()]+$</example>
        [DataMember(Name = "allowedCharactersRegexStr", IsRequired = true, EmitDefaultValue = true)]
        public string AllowedCharactersRegexStr { get; set; }

        /// <summary>
        /// The look-ahead expression that tests the digit requirement, meant to be applied only while &#x60;digits&#x60; is  &#x60;true&#x60;. It is always filled in, so its presence is not itself a requirement.
        /// </summary>
        /// <example>(?=.*\\d)</example>
        [DataMember(Name = "digitsRegexStr", IsRequired = true, EmitDefaultValue = true)]
        public string DigitsRegexStr { get; set; }

        /// <summary>
        /// The look-ahead expression that tests the uppercase requirement, to be applied while &#x60;upperCase&#x60; is &#x60;true&#x60;.
        /// </summary>
        /// <example>(?=.*[A-Z])</example>
        [DataMember(Name = "upperCaseRegexStr", IsRequired = true, EmitDefaultValue = true)]
        public string UpperCaseRegexStr { get; set; }

        /// <summary>
        /// The look-ahead expression that tests the special-symbol requirement, to be applied while &#x60;specSymbols&#x60; is  &#x60;true&#x60;. It also enumerates the symbols the portal treats as special.
        /// </summary>
        /// <example>(?=.*[!@#$%^&amp;*()])</example>
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
