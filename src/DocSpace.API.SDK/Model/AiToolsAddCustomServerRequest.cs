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
    /// AiToolsAddCustomServerRequest
    /// </summary>
    [DataContract(Name = "aiToolsAddCustomServer_request")]
    public partial class AiToolsAddCustomServerRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiToolsAddCustomServerRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiToolsAddCustomServerRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiToolsAddCustomServerRequest" /> class.
        /// </summary>
        /// <param name="name">Server name (unique within scope). (required).</param>
        /// <param name="config">Server transport configuration. (required).</param>
        /// <param name="entityId">entityId.</param>
        public AiToolsAddCustomServerRequest(string name = default, Object config = default, string entityId = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AiToolsAddCustomServerRequest and cannot be null");
            }
            this.Name = name;
            // to ensure "config" is required (not null)
            if (config == null)
            {
                throw new ArgumentNullException("config is a required property for AiToolsAddCustomServerRequest and cannot be null");
            }
            this.Config = config;
            this.EntityId = entityId;
        }

        /// <summary>
        /// Server name (unique within scope).
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Server transport configuration.
        /// </summary>
        [DataMember(Name = "config", IsRequired = true, EmitDefaultValue = true)]
        public Object Config { get; set; }

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
            sb.Append("class AiToolsAddCustomServerRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
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
