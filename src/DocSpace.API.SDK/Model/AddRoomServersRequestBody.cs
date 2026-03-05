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
    /// Parameters specifying which MCP servers to assign to the room.
    /// </summary>
    [DataContract(Name = "AddRoomServersRequestBody")]
    public partial class AddRoomServersRequestBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AddRoomServersRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddRoomServersRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddRoomServersRequestBody" /> class.
        /// </summary>
        /// <param name="servers">Set of unique identifiers of MCP servers to associate with the room. A maximum of 5 servers can be assigned per room. (required).</param>
        public AddRoomServersRequestBody(List<Guid> servers = default)
        {
            // to ensure "servers" is required (not null)
            if (servers == null)
            {
                throw new ArgumentNullException("servers is a required property for AddRoomServersRequestBody and cannot be null");
            }
            this.Servers = servers;
        }

        /// <summary>
        /// Set of unique identifiers of MCP servers to associate with the room. A maximum of 5 servers can be assigned per room.
        /// </summary>
        /// <value>Set of unique identifiers of MCP servers to associate with the room. A maximum of 5 servers can be assigned per room.</value>
        /*
        <example>[&quot;00000000-0000-0000-0000-000000000000&quot;]</example>
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
            sb.Append("class AddRoomServersRequestBody {\n");
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
