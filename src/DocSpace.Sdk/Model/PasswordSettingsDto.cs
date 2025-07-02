// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


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
using FileParameter = DocSpace.Sdk.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Sdk.Client.OpenAPIDateConverter;

namespace DocSpace.Sdk.Model
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
        /// <param name="minLength">The minimum number of characters required for valid passwords..</param>
        /// <param name="upperCase">Specifies whether the password should contain the uppercase letters or not..</param>
        /// <param name="digits">Specifies whether the password should contain the digits or not..</param>
        /// <param name="specSymbols">Specifies whether the password should contain the special symbols or not..</param>
        /// <param name="allowedCharactersRegexStr">The allowed password characters in the regex string format..</param>
        /// <param name="digitsRegexStr">The password digits in the regex string format..</param>
        /// <param name="upperCaseRegexStr">The password uppercase letters in the regex string format..</param>
        /// <param name="specSymbolsRegexStr">The passaword special symbols in the regex string format..</param>
        public PasswordSettingsDto(int minLength = default, bool upperCase = default, bool digits = default, bool specSymbols = default, string allowedCharactersRegexStr = default, string digitsRegexStr = default, string upperCaseRegexStr = default, string specSymbolsRegexStr = default)
        {
            this.MinLength = minLength;
            this.UpperCase = upperCase;
            this.Digits = digits;
            this.SpecSymbols = specSymbols;
            this.AllowedCharactersRegexStr = allowedCharactersRegexStr;
            this.DigitsRegexStr = digitsRegexStr;
            this.UpperCaseRegexStr = upperCaseRegexStr;
            this.SpecSymbolsRegexStr = specSymbolsRegexStr;
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
        /// The allowed password characters in the regex string format.
        /// </summary>
        /// <value>The allowed password characters in the regex string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "allowedCharactersRegexStr", EmitDefaultValue = true)]
        public string AllowedCharactersRegexStr { get; set; }

        /// <summary>
        /// The password digits in the regex string format.
        /// </summary>
        /// <value>The password digits in the regex string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "digitsRegexStr", EmitDefaultValue = true)]
        public string DigitsRegexStr { get; set; }

        /// <summary>
        /// The password uppercase letters in the regex string format.
        /// </summary>
        /// <value>The password uppercase letters in the regex string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "upperCaseRegexStr", EmitDefaultValue = true)]
        public string UpperCaseRegexStr { get; set; }

        /// <summary>
        /// The passaword special symbols in the regex string format.
        /// </summary>
        /// <value>The passaword special symbols in the regex string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "specSymbolsRegexStr", EmitDefaultValue = true)]
        public string SpecSymbolsRegexStr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
