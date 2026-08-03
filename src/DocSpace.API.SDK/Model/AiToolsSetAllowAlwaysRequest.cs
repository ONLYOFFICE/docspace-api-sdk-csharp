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
    /// AiToolsSetAllowAlwaysRequest
    /// </summary>
    [DataContract(Name = "aiToolsSetAllowAlways_request")]
    public partial class AiToolsSetAllowAlwaysRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiToolsSetAllowAlwaysRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiToolsSetAllowAlwaysRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiToolsSetAllowAlwaysRequest" /> class.
        /// </summary>
        /// <param name="serverType">serverType (required).</param>
        /// <param name="toolName">toolName (required).</param>
        /// <param name="value">Whether the tool is always allowed. (required).</param>
        /// <param name="entityId">entityId.</param>
        public AiToolsSetAllowAlwaysRequest(string serverType = default, string toolName = default, bool value = default, string entityId = default)
        {
            // to ensure "serverType" is required (not null)
            if (serverType == null)
            {
                throw new ArgumentNullException("serverType is a required property for AiToolsSetAllowAlwaysRequest and cannot be null");
            }
            this.ServerType = serverType;
            // to ensure "toolName" is required (not null)
            if (toolName == null)
            {
                throw new ArgumentNullException("toolName is a required property for AiToolsSetAllowAlwaysRequest and cannot be null");
            }
            this.ToolName = toolName;
            this.Value = value;
            this.EntityId = entityId;
        }

        /// <summary>
        /// Gets or Sets ServerType
        /// </summary>
        [DataMember(Name = "serverType", IsRequired = true, EmitDefaultValue = true)]
        public string ServerType { get; set; }

        /// <summary>
        /// Gets or Sets ToolName
        /// </summary>
        [DataMember(Name = "toolName", IsRequired = true, EmitDefaultValue = true)]
        public string ToolName { get; set; }

        /// <summary>
        /// Whether the tool is always allowed.
        /// </summary>
        /// <value>Whether the tool is always allowed.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public bool Value { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiToolsSetAllowAlwaysRequest {\n");
            sb.Append("  ServerType: ").Append(ServerType).Append("\n");
            sb.Append("  ToolName: ").Append(ToolName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
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
