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
    /// Parameters specifying which MCP servers to delete.
    /// </summary>
    [DataContract(Name = "DeleteServersRequestBody")]
    public partial class DeleteServersRequestBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServersRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteServersRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteServersRequestBody" /> class.
        /// </summary>
        /// <param name="servers">Set of unique identifiers of the MCP servers to permanently remove. All room associations and connection data will also be deleted. (required).</param>
        public DeleteServersRequestBody(List<Guid> servers = default)
        {
            // to ensure "servers" is required (not null)
            if (servers == null)
            {
                throw new ArgumentNullException("servers is a required property for DeleteServersRequestBody and cannot be null");
            }
            this.Servers = servers;
        }

        /// <summary>
        /// Set of unique identifiers of the MCP servers to permanently remove. All room associations and connection data will also be deleted.
        /// </summary>
        /// <value>Set of unique identifiers of the MCP servers to permanently remove. All room associations and connection data will also be deleted.</value>
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
            sb.Append("class DeleteServersRequestBody {\n");
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
