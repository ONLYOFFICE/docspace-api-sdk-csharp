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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The editor tool call state. Used to run the agent flow in the editor.
    /// </summary>
    [DataContract(Name = "EditorToolCallStateDto")]
    public partial class EditorToolCallStateDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorToolCallStateDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EditorToolCallStateDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorToolCallStateDto" /> class.
        /// </summary>
        /// <param name="toolName">The tool name. (required).</param>
        /// <param name="parameters">The editor tool call parameters. (required).</param>
        public EditorToolCallStateDto(string toolName = default, Object parameters = default)
        {
            // to ensure "toolName" is required (not null)
            if (toolName == null)
            {
                throw new ArgumentNullException("toolName is a required property for EditorToolCallStateDto and cannot be null");
            }
            this.ToolName = toolName;
            // to ensure "parameters" is required (not null)
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters is a required property for EditorToolCallStateDto and cannot be null");
            }
            this.Parameters = parameters;
        }

        /// <summary>
        /// The tool name.
        /// </summary>
        /// <value>The tool name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "toolName", IsRequired = true, EmitDefaultValue = true)]
        public string ToolName { get; set; }

        /// <summary>
        /// The editor tool call parameters.
        /// </summary>
        /// <value>The editor tool call parameters.</value>
        [DataMember(Name = "parameters", IsRequired = true, EmitDefaultValue = true)]
        public Object Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditorToolCallStateDto {\n");
            sb.Append("  ToolName: ").Append(ToolName).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
