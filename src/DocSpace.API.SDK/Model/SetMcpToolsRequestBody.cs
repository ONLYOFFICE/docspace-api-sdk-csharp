// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// Parameters for updating the disabled tools list of an MCP server in a room.
    /// </summary>
    [DataContract(Name = "SetMcpToolsRequestBody")]
    public partial class SetMcpToolsRequestBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SetMcpToolsRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetMcpToolsRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetMcpToolsRequestBody" /> class.
        /// </summary>
        /// <param name="disabledTools">List of tool names to disable. Tools not included in this list will remain enabled. Pass an empty list to enable all tools. (required).</param>
        public SetMcpToolsRequestBody(List<string> disabledTools = default)
        {
            // to ensure "disabledTools" is required (not null)
            if (disabledTools == null)
            {
                throw new ArgumentNullException("disabledTools is a required property for SetMcpToolsRequestBody and cannot be null");
            }
            this.DisabledTools = disabledTools;
        }

        /// <summary>
        /// List of tool names to disable. Tools not included in this list will remain enabled. Pass an empty list to enable all tools.
        /// </summary>
        /// <value>List of tool names to disable. Tools not included in this list will remain enabled. Pass an empty list to enable all tools.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "disabledTools", IsRequired = true, EmitDefaultValue = true)]
        public List<string> DisabledTools { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetMcpToolsRequestBody {\n");
            sb.Append("  DisabledTools: ").Append(DisabledTools).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
