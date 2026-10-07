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
    /// The value of a metadata field on an entry. Exactly one of the value properties is set, the one matching the field type:  &#x60;stringValue&#x60; for a string field, &#x60;numberValue&#x60; for a number field, &#x60;dateValue&#x60; for a date field,  &#x60;optionIds&#x60; for a single or multiple choice field.
    /// </summary>
    [DataContract(Name = "MetadataValueDto")]
    public partial class MetadataValueDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataValueDto" /> class.
        /// </summary>
        /// <param name="stringValue">The string value..</param>
        /// <param name="numberValue">The number value..</param>
        /// <param name="dateValue">The date value..</param>
        /// <param name="optionIds">The selected choice option IDs..</param>
        public MetadataValueDto(string stringValue = default, long? numberValue = default, ApiDateTime dateValue = default, List<Guid> optionIds = default)
        {
            this.StringValue = stringValue;
            this.NumberValue = numberValue;
            this.DateValue = dateValue;
            this.OptionIds = optionIds;
        }

        /// <summary>
        /// The string value.
        /// </summary>
        /// <example>ACME Corp</example>
        [DataMember(Name = "stringValue", EmitDefaultValue = true)]
        public string StringValue { get; set; }

        /// <summary>
        /// The number value.
        /// </summary>
        /// <example>150000</example>
        [DataMember(Name = "numberValue", EmitDefaultValue = true)]
        public long? NumberValue { get; set; }

        /// <summary>
        /// The date value.
        /// </summary>
        [DataMember(Name = "dateValue", EmitDefaultValue = false)]
        public ApiDateTime DateValue { get; set; }

        /// <summary>
        /// The selected choice option IDs.
        /// </summary>
        /// <example>["4f1e2d3c-5b6a-4788-99aa-0c1d2e3f4a55"]</example>
        [DataMember(Name = "optionIds", EmitDefaultValue = true)]
        public List<Guid> OptionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataValueDto {\n");
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
