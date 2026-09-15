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
    /// One scope from the tenant scope catalogue, as it may be requested by a client.
    /// </summary>
    [DataContract(Name = "ScopeResponse")]
    public partial class ScopeResponse : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeResponse" /> class.
        /// </summary>
        /// <param name="name">The scope exactly as it is written in an authorization request, for example files:read or openid..</param>
        /// <param name="group">The area of the portal the scope belongs to, which is what groups the scopes on the consent screen: files, rooms, contacts, profiles or openid..</param>
        /// <param name="type">What the scope allows inside its group: read for read-only access, write for changes, and openid for the identity scope itself..</param>
        public ScopeResponse(string name = default, string group = default, string type = default)
        {
            this.Name = name;
            this.Group = group;
            this.Type = type;
        }

        /// <summary>
        /// The scope exactly as it is written in an authorization request, for example files:read or openid.
        /// </summary>
        /// <example>files:read</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The area of the portal the scope belongs to, which is what groups the scopes on the consent screen: files, rooms, contacts, profiles or openid.
        /// </summary>
        /// <example>files</example>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public string Group { get; set; }

        /// <summary>
        /// What the scope allows inside its group: read for read-only access, write for changes, and openid for the identity scope itself.
        /// </summary>
        /// <example>read</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScopeResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
