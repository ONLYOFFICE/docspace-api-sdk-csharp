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
    /// AiMetaFill200ResponseUnresolvedInner
    /// </summary>
    [DataContract(Name = "aiMetaFill_200_response_unresolved_inner")]
    public partial class AiMetaFill200ResponseUnresolvedInner : IValidatableObject
    {
        /// <summary>
        /// Defines Reason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum AlreadySet for value: already_set
            /// </summary>
            [EnumMember(Value = "already_set")]
            AlreadySet,

            /// <summary>
            /// Enum NotFound for value: not_found
            /// </summary>
            [EnumMember(Value = "not_found")]
            NotFound,

            /// <summary>
            /// Enum InvalidValue for value: invalid_value
            /// </summary>
            [EnumMember(Value = "invalid_value")]
            InvalidValue,

            /// <summary>
            /// Enum UnknownOption for value: unknown_option
            /// </summary>
            [EnumMember(Value = "unknown_option")]
            UnknownOption,

            /// <summary>
            /// Enum WriteFailed for value: write_failed
            /// </summary>
            [EnumMember(Value = "write_failed")]
            WriteFailed
        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = true)]
        public ReasonEnum Reason { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaFill200ResponseUnresolvedInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiMetaFill200ResponseUnresolvedInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaFill200ResponseUnresolvedInner" /> class.
        /// </summary>
        /// <param name="fieldId">fieldId.</param>
        /// <param name="name">name (required).</param>
        /// <param name="reason">reason (required).</param>
        public AiMetaFill200ResponseUnresolvedInner(decimal fieldId = default, string name = default, ReasonEnum reason = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AiMetaFill200ResponseUnresolvedInner and cannot be null");
            }
            this.Name = name;
            this.Reason = reason;
            this.FieldId = fieldId;
        }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public decimal FieldId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiMetaFill200ResponseUnresolvedInner {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
