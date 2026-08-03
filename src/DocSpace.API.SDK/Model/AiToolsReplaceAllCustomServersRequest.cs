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
    /// AiToolsReplaceAllCustomServersRequest
    /// </summary>
    [DataContract(Name = "aiToolsReplaceAllCustomServers_request")]
    public partial class AiToolsReplaceAllCustomServersRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiToolsReplaceAllCustomServersRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiToolsReplaceAllCustomServersRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiToolsReplaceAllCustomServersRequest" /> class.
        /// </summary>
        /// <param name="map">Full replacement set, keyed by server name. (required).</param>
        /// <param name="entityId">entityId.</param>
        public AiToolsReplaceAllCustomServersRequest(Dictionary<string, Object> map = default, string entityId = default)
        {
            // to ensure "map" is required (not null)
            if (map == null)
            {
                throw new ArgumentNullException("map is a required property for AiToolsReplaceAllCustomServersRequest and cannot be null");
            }
            this.Map = map;
            this.EntityId = entityId;
        }

        /// <summary>
        /// Full replacement set, keyed by server name.
        /// </summary>
        /// <value>Full replacement set, keyed by server name.</value>
        [DataMember(Name = "map", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Object> Map { get; set; }

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
            sb.Append("class AiToolsReplaceAllCustomServersRequest {\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
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
