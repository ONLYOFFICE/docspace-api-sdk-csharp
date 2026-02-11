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
    /// McpServerStatusDto
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
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="serverType">serverType.</param>
        /// <param name="connected">connected.</param>
        /// <param name="icon">icon.</param>
        /// <param name="needReset">needReset.</param>
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
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>John Doe</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Connected
        /// </summary>
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
        /// Gets or Sets NeedReset
        /// </summary>
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
