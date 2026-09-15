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
    /// One currency the portal&#39;s subscription prices can be quoted in, with the region it belongs to.
    /// </summary>
    [DataContract(Name = "CurrenciesDto")]
    public partial class CurrenciesDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrenciesDto" /> class.
        /// </summary>
        /// <param name="isoCountryCode">The two-letter ISO code of the country the currency is that of, which is the region the price list was  picked for rather than the country of the caller..</param>
        /// <param name="isoCurrencySymbol">The three-letter ISO 4217 code of the currency. On the first item of the answer it is the currency the  amounts from &#x60;GET api/2.0/portal/payment/prices&#x60; are expressed in..</param>
        /// <param name="currencyNativeName">The currency name in the language of its own region - not in the portal language, and not a symbol..</param>
        public CurrenciesDto(string isoCountryCode = default, string isoCurrencySymbol = default, string currencyNativeName = default)
        {
            this.IsoCountryCode = isoCountryCode;
            this.IsoCurrencySymbol = isoCurrencySymbol;
            this.CurrencyNativeName = currencyNativeName;
        }

        /// <summary>
        /// The two-letter ISO code of the country the currency is that of, which is the region the price list was  picked for rather than the country of the caller.
        /// </summary>
        /// <example>US</example>
        [DataMember(Name = "isoCountryCode", EmitDefaultValue = true)]
        public string IsoCountryCode { get; set; }

        /// <summary>
        /// The three-letter ISO 4217 code of the currency. On the first item of the answer it is the currency the  amounts from &#x60;GET api/2.0/portal/payment/prices&#x60; are expressed in.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "isoCurrencySymbol", EmitDefaultValue = true)]
        public string IsoCurrencySymbol { get; set; }

        /// <summary>
        /// The currency name in the language of its own region - not in the portal language, and not a symbol.
        /// </summary>
        /// <example>US Dollar</example>
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
