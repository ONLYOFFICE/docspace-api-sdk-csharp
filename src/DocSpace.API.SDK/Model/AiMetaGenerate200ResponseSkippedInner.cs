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
    /// AiMetaGenerate200ResponseSkippedInner
    /// </summary>
    [DataContract(Name = "aiMetaGenerate_200_response_skipped_inner")]
    public partial class AiMetaGenerate200ResponseSkippedInner : IValidatableObject
    {
        /// <summary>
        /// Defines Reason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            /// <summary>
            /// Enum Unsupported for value: unsupported
            /// </summary>
            [EnumMember(Value = "unsupported")]
            Unsupported,

            /// <summary>
            /// Enum Limit for value: limit
            /// </summary>
            [EnumMember(Value = "limit")]
            Limit,

            /// <summary>
            /// Enum Forbidden for value: forbidden
            /// </summary>
            [EnumMember(Value = "forbidden")]
            Forbidden,

            /// <summary>
            /// Enum NotFound for value: not_found
            /// </summary>
            [EnumMember(Value = "not_found")]
            NotFound,

            /// <summary>
            /// Enum Empty for value: empty
            /// </summary>
            [EnumMember(Value = "empty")]
            Empty,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed
        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = true)]
        public ReasonEnum Reason { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaGenerate200ResponseSkippedInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiMetaGenerate200ResponseSkippedInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaGenerate200ResponseSkippedInner" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="title">title.</param>
        /// <param name="reason">reason (required).</param>
        public AiMetaGenerate200ResponseSkippedInner(string id = default, string title = default, ReasonEnum reason = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiMetaGenerate200ResponseSkippedInner and cannot be null");
            }
            this.Id = id;
            this.Reason = reason;
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiMetaGenerate200ResponseSkippedInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
