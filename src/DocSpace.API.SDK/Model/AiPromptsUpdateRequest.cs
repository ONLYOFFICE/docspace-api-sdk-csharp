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
    /// AiPromptsUpdateRequest
    /// </summary>
    [DataContract(Name = "aiPromptsUpdate_request")]
    public partial class AiPromptsUpdateRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiPromptsUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiPromptsUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiPromptsUpdateRequest" /> class.
        /// </summary>
        /// <param name="id">Prompt id to update. (required).</param>
        /// <param name="updates">updates (required).</param>
        public AiPromptsUpdateRequest(string id = default, AiPromptsUpdateRequestUpdates updates = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiPromptsUpdateRequest and cannot be null");
            }
            this.Id = id;
            // to ensure "updates" is required (not null)
            if (updates == null)
            {
                throw new ArgumentNullException("updates is a required property for AiPromptsUpdateRequest and cannot be null");
            }
            this.Updates = updates;
        }

        /// <summary>
        /// Prompt id to update.
        /// </summary>
        /// <value>Prompt id to update.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Updates
        /// </summary>
        [DataMember(Name = "updates", IsRequired = true, EmitDefaultValue = true)]
        public AiPromptsUpdateRequestUpdates Updates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiPromptsUpdateRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Updates: ").Append(Updates).Append("\n");
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
