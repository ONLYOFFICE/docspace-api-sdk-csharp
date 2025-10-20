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
    /// The response containing the scope information.
    /// </summary>
    [DataContract(Name = "ScopeResponse")]
    public partial class ScopeResponse : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeResponse" /> class.
        /// </summary>
        /// <param name="name">The scope name..</param>
        /// <param name="group">The group the scope belongs to..</param>
        /// <param name="type">The scope type..</param>
        public ScopeResponse(string name = default, string group = default, string type = default)
        {
            this.Name = name;
            this.Group = group;
            this.Type = type;
        }

        /// <summary>
        /// The scope name.
        /// </summary>
        /// <value>The scope name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The group the scope belongs to.
        /// </summary>
        /// <value>The group the scope belongs to.</value>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public string Group { get; set; }

        /// <summary>
        /// The scope type.
        /// </summary>
        /// <value>The scope type.</value>
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
