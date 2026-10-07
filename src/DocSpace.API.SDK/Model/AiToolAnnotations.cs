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
    /// MCP tool annotations (&#x60;Tool.annotations&#x60; in the protocol). All hints are advisory and optional; the protocol&#39;s defaults are &#x60;readOnlyHint: false&#x60; and &#x60;destructiveHint: true&#x60;, which is why an unannotated tool is treated as one that may destroy state.
    /// </summary>
    [DataContract(Name = "AiToolAnnotations")]
    public partial class AiToolAnnotations : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiToolAnnotations" /> class.
        /// </summary>
        /// <param name="title">title.</param>
        /// <param name="readOnlyHint">readOnlyHint.</param>
        /// <param name="destructiveHint">destructiveHint.</param>
        /// <param name="idempotentHint">idempotentHint.</param>
        /// <param name="openWorldHint">openWorldHint.</param>
        public AiToolAnnotations(string title = default, bool readOnlyHint = default, bool destructiveHint = default, bool idempotentHint = default, bool openWorldHint = default)
        {
            this.Title = title;
            this.ReadOnlyHint = readOnlyHint;
            this.DestructiveHint = destructiveHint;
            this.IdempotentHint = idempotentHint;
            this.OpenWorldHint = openWorldHint;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnlyHint
        /// </summary>
        [DataMember(Name = "readOnlyHint", EmitDefaultValue = true)]
        public bool ReadOnlyHint { get; set; }

        /// <summary>
        /// Gets or Sets DestructiveHint
        /// </summary>
        [DataMember(Name = "destructiveHint", EmitDefaultValue = true)]
        public bool DestructiveHint { get; set; }

        /// <summary>
        /// Gets or Sets IdempotentHint
        /// </summary>
        [DataMember(Name = "idempotentHint", EmitDefaultValue = true)]
        public bool IdempotentHint { get; set; }

        /// <summary>
        /// Gets or Sets OpenWorldHint
        /// </summary>
        [DataMember(Name = "openWorldHint", EmitDefaultValue = true)]
        public bool OpenWorldHint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiToolAnnotations {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ReadOnlyHint: ").Append(ReadOnlyHint).Append("\n");
            sb.Append("  DestructiveHint: ").Append(DestructiveHint).Append("\n");
            sb.Append("  IdempotentHint: ").Append(IdempotentHint).Append("\n");
            sb.Append("  OpenWorldHint: ").Append(OpenWorldHint).Append("\n");
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
