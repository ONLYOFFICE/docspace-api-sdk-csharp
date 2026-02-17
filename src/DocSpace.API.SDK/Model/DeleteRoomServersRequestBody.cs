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
    /// Parameters specifying which MCP servers to detach from the room.
    /// </summary>
    [DataContract(Name = "DeleteRoomServersRequestBody")]
    public partial class DeleteRoomServersRequestBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRoomServersRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteRoomServersRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRoomServersRequestBody" /> class.
        /// </summary>
        /// <param name="servers">Set of unique identifiers of MCP servers to remove from the room. Associated connections and tool configurations will also be cleaned up. (required).</param>
        public DeleteRoomServersRequestBody(List<Guid> servers = default)
        {
            // to ensure "servers" is required (not null)
            if (servers == null)
            {
                throw new ArgumentNullException("servers is a required property for DeleteRoomServersRequestBody and cannot be null");
            }
            this.Servers = servers;
        }

        /// <summary>
        /// Set of unique identifiers of MCP servers to remove from the room. Associated connections and tool configurations will also be cleaned up.
        /// </summary>
        /// <value>Set of unique identifiers of MCP servers to remove from the room. Associated connections and tool configurations will also be cleaned up.</value>
        /*
        <example>[&quot;75a5f745-f697-4418-b38d-0fe0d277e258&quot;]</example>
        */
        [DataMember(Name = "servers", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> Servers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRoomServersRequestBody {\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
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
