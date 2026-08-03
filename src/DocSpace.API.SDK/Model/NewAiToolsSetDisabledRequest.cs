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
    /// NewAiToolsSetDisabledRequest
    /// </summary>
    [DataContract(Name = "newAiToolsSetDisabled_request")]
    public partial class NewAiToolsSetDisabledRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiToolsSetDisabledRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiToolsSetDisabledRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiToolsSetDisabledRequest" /> class.
        /// </summary>
        /// <param name="serverType">serverType (required).</param>
        /// <param name="toolNames">Tool names to disable. (required).</param>
        /// <param name="entityId">entityId.</param>
        public NewAiToolsSetDisabledRequest(string serverType = default, List<string> toolNames = default, string entityId = default)
        {
            // to ensure "serverType" is required (not null)
            if (serverType == null)
            {
                throw new ArgumentNullException("serverType is a required property for NewAiToolsSetDisabledRequest and cannot be null");
            }
            this.ServerType = serverType;
            // to ensure "toolNames" is required (not null)
            if (toolNames == null)
            {
                throw new ArgumentNullException("toolNames is a required property for NewAiToolsSetDisabledRequest and cannot be null");
            }
            this.ToolNames = toolNames;
            this.EntityId = entityId;
        }

        /// <summary>
        /// Gets or Sets ServerType
        /// </summary>
        [DataMember(Name = "serverType", IsRequired = true, EmitDefaultValue = true)]
        public string ServerType { get; set; }

        /// <summary>
        /// Tool names to disable.
        /// </summary>
        /// <value>Tool names to disable.</value>
        [DataMember(Name = "toolNames", IsRequired = true, EmitDefaultValue = true)]
        public List<string> ToolNames { get; set; }

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
            sb.Append("class NewAiToolsSetDisabledRequest {\n");
            sb.Append("  ServerType: ").Append(ServerType).Append("\n");
            sb.Append("  ToolNames: ").Append(ToolNames).Append("\n");
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
