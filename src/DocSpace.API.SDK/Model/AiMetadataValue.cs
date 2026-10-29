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
    /// A metadata value: exactly one member, by the field&#39;s type.
    /// </summary>
    [DataContract(Name = "AiMetadataValue")]
    public partial class AiMetadataValue : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetadataValue" /> class.
        /// </summary>
        /// <param name="stringValue">stringValue.</param>
        /// <param name="numberValue">numberValue.</param>
        /// <param name="dateValue">ISO 8601 date-time, UTC midnight of the date..</param>
        /// <param name="optionIds">optionIds.</param>
        public AiMetadataValue(string stringValue = default, decimal numberValue = default, string dateValue = default, List<string> optionIds = default)
        {
            this.StringValue = stringValue;
            this.NumberValue = numberValue;
            this.DateValue = dateValue;
            this.OptionIds = optionIds;
        }

        /// <summary>
        /// Gets or Sets StringValue
        /// </summary>
        [DataMember(Name = "stringValue", EmitDefaultValue = false)]
        public string StringValue { get; set; }

        /// <summary>
        /// Gets or Sets NumberValue
        /// </summary>
        [DataMember(Name = "numberValue", EmitDefaultValue = false)]
        public decimal NumberValue { get; set; }

        /// <summary>
        /// ISO 8601 date-time, UTC midnight of the date.
        /// </summary>
        [DataMember(Name = "dateValue", EmitDefaultValue = false)]
        public string DateValue { get; set; }

        /// <summary>
        /// Gets or Sets OptionIds
        /// </summary>
        [DataMember(Name = "optionIds", EmitDefaultValue = false)]
        public List<string> OptionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiMetadataValue {\n");
            sb.Append("  StringValue: ").Append(StringValue).Append("\n");
            sb.Append("  NumberValue: ").Append(NumberValue).Append("\n");
            sb.Append("  DateValue: ").Append(DateValue).Append("\n");
            sb.Append("  OptionIds: ").Append(OptionIds).Append("\n");
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
