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
    /// MCP server status within a room, reflecting the current user&#39;s connection state for OAuth-based servers.
    /// </summary>
    [DataContract(Name = "McpServerStatusDto")]
    public partial class McpServerStatusDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ServerType
        /// </summary>
        [DataMember(Name = "serverType", EmitDefaultValue = false)]
        public ServerType? ServerType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerStatusDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected McpServerStatusDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerStatusDto" /> class.
        /// </summary>
        /// <param name="id">Unique identifier of the MCP server..</param>
        /// <param name="name">Display name of the MCP server. (required).</param>
        /// <param name="serverType">serverType.</param>
        /// <param name="connected">Indicates whether the current user has an active connection to this server. For direct-connection servers this is always true; for OAuth-based servers it reflects whether the user has completed authorization..</param>
        /// <param name="icon">icon.</param>
        /// <param name="needReset">Indicates whether the server requires a configuration reset due to connectivity or credential issues..</param>
        public McpServerStatusDto(Guid id = default, string name = default, ServerType? serverType = default, bool connected = default, Icon icon = default, bool needReset = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for McpServerStatusDto and cannot be null");
            }
            this.Name = name;
            this.Id = id;
            this.ServerType = serverType;
            this.Connected = connected;
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
        <example>DocSpace Tools</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates whether the current user has an active connection to this server. For direct-connection servers this is always true; for OAuth-based servers it reflects whether the user has completed authorization.
        /// </summary>
        /// <value>Indicates whether the current user has an active connection to this server. For direct-connection servers this is always true; for OAuth-based servers it reflects whether the user has completed authorization.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "connected", EmitDefaultValue = true)]
        public bool Connected { get; set; }

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
        <example>false</example>
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
            sb.Append("class McpServerStatusDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ServerType: ").Append(ServerType).Append("\n");
            sb.Append("  Connected: ").Append(Connected).Append("\n");
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
