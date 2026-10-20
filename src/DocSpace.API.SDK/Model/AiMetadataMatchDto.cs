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
    /// Where a text search met the metadata of a file, a folder or a room: one string value that holds the searched text,  with the field it belongs to.
    /// </summary>
    [DataContract(Name = "AiMetadataMatchDto")]
    public partial class AiMetadataMatchDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetadataMatchDto" /> class.
        /// </summary>
        /// <param name="templateId">The ID of the metadata template the matching field belongs to. Null for a custom field, which belongs to no  template the API shows..</param>
        /// <param name="fieldId">The ID of the matching template field. Null for a custom field, which is addressed by its name alone..</param>
        /// <param name="fieldName">The name of the matching field: the template field or the custom field as it is shown in the entry metadata..</param>
        /// <param name="value">The stored value that holds the searched text, as it was written, not only the matching part of it..</param>
        public AiMetadataMatchDto(int? templateId = default, int? fieldId = default, string fieldName = default, string value = default)
        {
            this.TemplateId = templateId;
            this.FieldId = fieldId;
            this.FieldName = fieldName;
            this.Value = value;
        }

        /// <summary>
        /// The ID of the metadata template the matching field belongs to. Null for a custom field, which belongs to no  template the API shows.
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "templateId", EmitDefaultValue = true)]
        public int? TemplateId { get; set; }

        /// <summary>
        /// The ID of the matching template field. Null for a custom field, which is addressed by its name alone.
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "fieldId", EmitDefaultValue = true)]
        public int? FieldId { get; set; }

        /// <summary>
        /// The name of the matching field: the template field or the custom field as it is shown in the entry metadata.
        /// </summary>
        /// <example>Client</example>
        [DataMember(Name = "fieldName", EmitDefaultValue = true)]
        public string FieldName { get; set; }

        /// <summary>
        /// The stored value that holds the searched text, as it was written, not only the matching part of it.
        /// </summary>
        /// <example>ACME Corporation</example>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiMetadataMatchDto {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
