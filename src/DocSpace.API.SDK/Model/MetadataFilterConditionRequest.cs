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
    /// One metadata filter condition as the clients send it: an element of the metadataFilters JSON of the listings and of  the body of the search endpoints. All conditions are combined with AND.
    /// </summary>
    [DataContract(Name = "MetadataFilterConditionRequest")]
    public partial class MetadataFilterConditionRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFilterConditionRequest" /> class.
        /// </summary>
        /// <param name="fieldId">The ID of the template field the condition is on. A custom field is addressed by ASC.Files.Core.MetadataFilterConditionRequest.Name instead..</param>
        /// <param name="name">The name of a custom field, for the conditions on the custom fields, which have no identifier outside. Either the  field ID or the name is given; the name is matched without regard to case..</param>
        /// <param name="op">The operator, one of ASC.Files.Core.MetadataFilterOperators. Optional: the field type alone determines how the  condition is evaluated, so an omitted operator is accepted, while a present one has to match the field type..</param>
        /// <param name="value">The exact value: string fields, and number fields given a single value. A JSON number is accepted as well as a string..</param>
        /// <param name="from">The inclusive lower bound of a range. A date given without a time (2026-06-01) is the start of that day (UTC)..</param>
        /// <param name="to">The inclusive upper bound of a range. A date given without a time (2026-06-30) covers the whole day (UTC);  a value with a time is an instant and is taken as is..</param>
        /// <param name="optionIds">The options any of which the choice field must hold..</param>
        public MetadataFilterConditionRequest(int fieldId = default, string name = default, string op = default, string value = default, string from = default, string to = default, List<Guid> optionIds = default)
        {
            this.FieldId = fieldId;
            this.Name = name;
            this.Op = op;
            this.Value = value;
            this.From = from;
            this.To = to;
            this.OptionIds = optionIds;
        }

        /// <summary>
        /// The ID of the template field the condition is on. A custom field is addressed by ASC.Files.Core.MetadataFilterConditionRequest.Name instead.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public int FieldId { get; set; }

        /// <summary>
        /// The name of a custom field, for the conditions on the custom fields, which have no identifier outside. Either the  field ID or the name is given; the name is matched without regard to case.
        /// </summary>
        /// <example>Client</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The operator, one of ASC.Files.Core.MetadataFilterOperators. Optional: the field type alone determines how the  condition is evaluated, so an omitted operator is accepted, while a present one has to match the field type.
        /// </summary>
        /// <example>eq</example>
        [DataMember(Name = "op", EmitDefaultValue = true)]
        public string Op { get; set; }

        /// <summary>
        /// The exact value: string fields, and number fields given a single value. A JSON number is accepted as well as a string.
        /// </summary>
        /// <example>ACME</example>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// The inclusive lower bound of a range. A date given without a time (2026-06-01) is the start of that day (UTC).
        /// </summary>
        /// <example>2026-01-01</example>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// The inclusive upper bound of a range. A date given without a time (2026-06-30) covers the whole day (UTC);  a value with a time is an instant and is taken as is.
        /// </summary>
        /// <example>2026-06-30</example>
        [DataMember(Name = "to", EmitDefaultValue = true)]
        public string To { get; set; }

        /// <summary>
        /// The options any of which the choice field must hold.
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
            sb.Append("class MetadataFilterConditionRequest {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
