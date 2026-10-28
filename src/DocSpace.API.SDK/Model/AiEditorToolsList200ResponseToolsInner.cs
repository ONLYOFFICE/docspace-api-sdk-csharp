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
    /// AiEditorToolsList200ResponseToolsInner
    /// </summary>
    [DataContract(Name = "aiEditorToolsList_200_response_tools_inner")]
    public partial class AiEditorToolsList200ResponseToolsInner : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiEditorToolsList200ResponseToolsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiEditorToolsList200ResponseToolsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiEditorToolsList200ResponseToolsInner" /> class.
        /// </summary>
        /// <param name="name">Tool name, as it is passed back to the call endpoint. (required).</param>
        /// <param name="description">What the tool does, empty when the server declares nothing. (required).</param>
        /// <param name="inputSchema">JSON Schema of the tool arguments. (required).</param>
        /// <param name="requireApproval">Whether the editor has to ask the user before running the tool. Read-only operations arrive with this off. (required).</param>
        public AiEditorToolsList200ResponseToolsInner(string name = default, string description = default, Dictionary<string, Object> inputSchema = default, bool requireApproval = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AiEditorToolsList200ResponseToolsInner and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for AiEditorToolsList200ResponseToolsInner and cannot be null");
            }
            this.Description = description;
            // to ensure "inputSchema" is required (not null)
            if (inputSchema == null)
            {
                throw new ArgumentNullException("inputSchema is a required property for AiEditorToolsList200ResponseToolsInner and cannot be null");
            }
            this.InputSchema = inputSchema;
            this.RequireApproval = requireApproval;
        }

        /// <summary>
        /// Tool name, as it is passed back to the call endpoint.
        /// </summary>
        /// <example>docspace_search_files</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// What the tool does, empty when the server declares nothing.
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// JSON Schema of the tool arguments.
        /// </summary>
        [DataMember(Name = "inputSchema", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> InputSchema { get; set; }

        /// <summary>
        /// Whether the editor has to ask the user before running the tool. Read-only operations arrive with this off.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "requireApproval", IsRequired = true, EmitDefaultValue = true)]
        public bool RequireApproval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiEditorToolsList200ResponseToolsInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
            sb.Append("  RequireApproval: ").Append(RequireApproval).Append("\n");
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
