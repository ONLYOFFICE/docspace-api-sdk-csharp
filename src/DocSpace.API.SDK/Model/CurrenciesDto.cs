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
    /// The currencies parameters.
    /// </summary>
    [DataContract(Name = "CurrenciesDto")]
    public partial class CurrenciesDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesDto" /> class.
        /// </summary>
        /// <param name="isoCountryCode">The ISO country code..</param>
        /// <param name="isoCurrencySymbol">The ISO currency symbol..</param>
        /// <param name="currencyNativeName">The currency native name..</param>
        public CurrenciesDto(string isoCountryCode = default, string isoCurrencySymbol = default, string currencyNativeName = default)
        {
            this.IsoCountryCode = isoCountryCode;
            this.IsoCurrencySymbol = isoCurrencySymbol;
            this.CurrencyNativeName = currencyNativeName;
        }

        /// <summary>
        /// The ISO country code.
        /// </summary>
        /// <value>The ISO country code.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "isoCountryCode", EmitDefaultValue = true)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// The ISO currency symbol.
        /// </summary>
        /// <value>The ISO currency symbol.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "isoCurrencySymbol", EmitDefaultValue = true)]
        public string IsoCurrencySymbol { get; set; }

        /// <summary>
        /// The currency native name.
        /// </summary>
        /// <value>The currency native name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "currencyNativeName", EmitDefaultValue = true)]
        public string CurrencyNativeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrenciesDto {\n");
            sb.Append("  IsoCountryCode: ").Append(IsoCountryCode).Append("\n");
            sb.Append("  IsoCurrencySymbol: ").Append(IsoCurrencySymbol).Append("\n");
            sb.Append("  CurrencyNativeName: ").Append(CurrencyNativeName).Append("\n");
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
