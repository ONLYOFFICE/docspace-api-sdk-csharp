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
    /// The price parameters.
    /// </summary>
    [DataContract(Name = "PriceDto")]
    public partial class PriceDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceDto" /> class.
        /// </summary>
        /// <param name="value">The price value..</param>
        /// <param name="currencySymbol">The currency symbol..</param>
        /// <param name="isoCurrencySymbol">The three-character ISO 4217 currency symbol..</param>
        public PriceDto(double? value = default, string currencySymbol = default, string isoCurrencySymbol = default)
        {
            this.Value = value;
            this.CurrencySymbol = currencySymbol;
            this.IsoCurrencySymbol = isoCurrencySymbol;
        }

        /// <summary>
        /// The price value.
        /// </summary>
        /// <example>99.99</example>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public double? Value { get; set; }

        /// <summary>
        /// The currency symbol.
        /// </summary>
        /// <example>$</example>
        [DataMember(Name = "currencySymbol", EmitDefaultValue = true)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "isoCurrencySymbol", EmitDefaultValue = true)]
        public string IsoCurrencySymbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceDto {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  IsoCurrencySymbol: ").Append(IsoCurrencySymbol).Append("\n");
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
