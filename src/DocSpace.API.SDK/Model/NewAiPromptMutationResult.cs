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
    /// Outcome of &#x60;create&#x60; / &#x60;update&#x60; / &#x60;move&#x60; on a prompt — either the persisted prompt or a field-scoped error.
    /// </summary>
    [DataContract(Name = "NewAiPromptMutationResult")]
    public partial class NewAiPromptMutationResult : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiPromptMutationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiPromptMutationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiPromptMutationResult" /> class.
        /// </summary>
        /// <param name="success">success (required).</param>
        /// <param name="prompt">prompt.</param>
        /// <param name="error">error.</param>
        public NewAiPromptMutationResult(bool success = default, NewAiPrompt prompt = default, NewAiTErrorData error = default)
        {
            this.Success = success;
            this.Prompt = prompt;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", IsRequired = true, EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Prompt
        /// </summary>
        [DataMember(Name = "prompt", EmitDefaultValue = false)]
        public NewAiPrompt Prompt { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public NewAiTErrorData Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiPromptMutationResult {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
