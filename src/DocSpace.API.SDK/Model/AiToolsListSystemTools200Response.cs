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
    /// AiToolsListSystemTools200Response
    /// </summary>
    [DataContract(Name = "aiToolsListSystemTools_200_response")]
    public partial class AiToolsListSystemTools200Response : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiToolsListSystemTools200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiToolsListSystemTools200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiToolsListSystemTools200Response" /> class.
        /// </summary>
        /// <param name="groups">Tools by server name, covering both the host-configured system servers and the custom MCP servers registered for this scope. (required).</param>
        /// <param name="errors">Why a registered custom server could not be reached, keyed by server name. A server that answered is absent from this map. (required).</param>
        /// <param name="system">Names of the host-configured system servers among the keys of &#x60;groups&#x60;; everything else there was registered as a custom server. (required).</param>
        public AiToolsListSystemTools200Response(Dictionary<string, List<AiTMCPItem>> groups = default, Dictionary<string, string> errors = default, List<string> @system = default)
        {
            // to ensure "groups" is required (not null)
            if (groups == null)
            {
                throw new ArgumentNullException("groups is a required property for AiToolsListSystemTools200Response and cannot be null");
            }
            this.Groups = groups;
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new ArgumentNullException("errors is a required property for AiToolsListSystemTools200Response and cannot be null");
            }
            this.Errors = errors;
            // to ensure "@system" is required (not null)
            if (@system == null)
            {
                throw new ArgumentNullException("@system is a required property for AiToolsListSystemTools200Response and cannot be null");
            }
            this.System = @system;
        }

        /// <summary>
        /// Tools by server name, covering both the host-configured system servers and the custom MCP servers registered for this scope.
        /// </summary>
        [DataMember(Name = "groups", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, List<AiTMCPItem>> Groups { get; set; }

        /// <summary>
        /// Why a registered custom server could not be reached, keyed by server name. A server that answered is absent from this map.
        /// </summary>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Errors { get; set; }

        /// <summary>
        /// Names of the host-configured system servers among the keys of &#x60;groups&#x60;; everything else there was registered as a custom server.
        /// </summary>
        [DataMember(Name = "system", IsRequired = true, EmitDefaultValue = true)]
        public List<string> System { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiToolsListSystemTools200Response {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
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
