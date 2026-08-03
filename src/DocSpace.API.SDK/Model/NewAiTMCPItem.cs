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
    /// Descriptor for a tool exposed by an MCP server.
    /// </summary>
    [DataContract(Name = "NewAiTMCPItem")]
    public partial class NewAiTMCPItem : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiTMCPItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiTMCPItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiTMCPItem" /> class.
        /// </summary>
        /// <param name="name">Tool name as registered on the MCP server (e.g. &#x60;web_search&#x60;, &#x60;insert_text&#x60;). (required).</param>
        /// <param name="description">Human-readable description shown to the AI model and in the tools list UI. (required).</param>
        /// <param name="inputSchema">JSON Schema describing the tool&#39;s input parameters. (required).</param>
        /// <param name="enabled">Whether this tool is currently enabled. Disabled tools are hidden from the AI model..</param>
        /// <param name="requireApproval">Whether the consumer must show an approval dialog before this tool runs. The engine reads it when deciding the &#x60;autoAllow&#x60; flag on a &#x60;tool-call-pending&#x60; event: &#x60;requireApproval &#x3D;&#x3D;&#x3D; false&#x60; auto-allows the call (no dialog), &#x60;true&#x60; always prompts. &#x60;undefined&#x60; leaves the decision to the persisted always-allow list alone — so MCP / custom-server tools (which never set it) keep prompting as before, while host tools opt into auto-allow by default. Wire-serializable, so it survives a remote (server-side) engine..</param>
        public NewAiTMCPItem(string name = default, string description = default, Object inputSchema = default, bool enabled = default, bool requireApproval = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for NewAiTMCPItem and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for NewAiTMCPItem and cannot be null");
            }
            this.Description = description;
            // to ensure "inputSchema" is required (not null)
            if (inputSchema == null)
            {
                throw new ArgumentNullException("inputSchema is a required property for NewAiTMCPItem and cannot be null");
            }
            this.InputSchema = inputSchema;
            this.Enabled = enabled;
            this.RequireApproval = requireApproval;
        }

        /// <summary>
        /// Tool name as registered on the MCP server (e.g. &#x60;web_search&#x60;, &#x60;insert_text&#x60;).
        /// </summary>
        /// <value>Tool name as registered on the MCP server (e.g. &#x60;web_search&#x60;, &#x60;insert_text&#x60;).</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Human-readable description shown to the AI model and in the tools list UI.
        /// </summary>
        /// <value>Human-readable description shown to the AI model and in the tools list UI.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// JSON Schema describing the tool&#39;s input parameters.
        /// </summary>
        /// <value>JSON Schema describing the tool&#39;s input parameters.</value>
        [DataMember(Name = "inputSchema", IsRequired = true, EmitDefaultValue = true)]
        public Object InputSchema { get; set; }

        /// <summary>
        /// Whether this tool is currently enabled. Disabled tools are hidden from the AI model.
        /// </summary>
        /// <value>Whether this tool is currently enabled. Disabled tools are hidden from the AI model.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether the consumer must show an approval dialog before this tool runs. The engine reads it when deciding the &#x60;autoAllow&#x60; flag on a &#x60;tool-call-pending&#x60; event: &#x60;requireApproval &#x3D;&#x3D;&#x3D; false&#x60; auto-allows the call (no dialog), &#x60;true&#x60; always prompts. &#x60;undefined&#x60; leaves the decision to the persisted always-allow list alone — so MCP / custom-server tools (which never set it) keep prompting as before, while host tools opt into auto-allow by default. Wire-serializable, so it survives a remote (server-side) engine.
        /// </summary>
        /// <value>Whether the consumer must show an approval dialog before this tool runs. The engine reads it when deciding the &#x60;autoAllow&#x60; flag on a &#x60;tool-call-pending&#x60; event: &#x60;requireApproval &#x3D;&#x3D;&#x3D; false&#x60; auto-allows the call (no dialog), &#x60;true&#x60; always prompts. &#x60;undefined&#x60; leaves the decision to the persisted always-allow list alone — so MCP / custom-server tools (which never set it) keep prompting as before, while host tools opt into auto-allow by default. Wire-serializable, so it survives a remote (server-side) engine.</value>
        [DataMember(Name = "requireApproval", EmitDefaultValue = true)]
        public bool RequireApproval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiTMCPItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InputSchema: ").Append(InputSchema).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
