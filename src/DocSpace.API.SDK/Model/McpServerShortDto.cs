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
    /// Compact MCP server summary without sensitive details like endpoint URL or authentication headers.
    /// </summary>
    [DataContract(Name = "McpServerShortDto")]
    public partial class McpServerShortDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ServerType
        /// </summary>
        [DataMember(Name = "serverType", EmitDefaultValue = false)]
        public ServerType? ServerType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerShortDto" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of the MCP server..</param>
        /// <param name="name">Display name of the MCP server..</param>
        /// <param name="serverType">serverType.</param>
        /// <param name="enabled">Indicates whether the server is currently enabled and available for room assignment..</param>
        /// <param name="icon">icon.</param>
        /// <param name="needReset">Indicates whether the server requires a configuration reset due to connectivity or credential issues..</param>
        public McpServerShortDto(Guid id = default, string name = default, ServerType? serverType = default, bool enabled = default, Icon icon = default, bool needReset = default)
        {
            this.Id = id;
            this.Name = name;
            this.ServerType = serverType;
            this.Enabled = enabled;
            this.Icon = icon;
            this.NeedReset = needReset;
        }

        /// <summary>
        /// Unique identifier of the MCP server.
        /// </summary>
        /// <value>Unique identifier of the MCP server.</value>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Display name of the MCP server.
        /// </summary>
        /// <value>Display name of the MCP server.</value>
        /*
        <example>John Doe</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the server is currently enabled and available for room assignment.
        /// </summary>
        /// <value>Indicates whether the server is currently enabled and available for room assignment.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public Icon Icon { get; set; }

        /// <summary>
        /// Indicates whether the server requires a configuration reset due to connectivity or credential issues.
        /// </summary>
        /// <value>Indicates whether the server requires a configuration reset due to connectivity or credential issues.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "needReset", EmitDefaultValue = true)]
        public bool NeedReset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class McpServerShortDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ServerType: ").Append(ServerType).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  NeedReset: ").Append(NeedReset).Append("\n");
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
