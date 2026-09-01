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
    /// The group summary parameters.
    /// </summary>
    [DataContract(Name = "GroupSummaryDto")]
    public partial class GroupSummaryDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSummaryDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupSummaryDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSummaryDto" /> class.
        /// </summary>
        /// <param name="id">The group ID. (required).</param>
        /// <param name="name">The group name. (required).</param>
        /// <param name="manager">The group manager..</param>
        /// <param name="isSystem">Indicates whether the group is a system group..</param>
        public GroupSummaryDto(Guid id = default, string name = default, string manager = default, bool? isSystem = default)
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GroupSummaryDto and cannot be null");
            }
            this.Name = name;
            this.Manager = manager;
            this.IsSystem = isSystem;
        }

        /// <summary>
        /// The group ID.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// The group name.
        /// </summary>
        /// <example>Group Name</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The group manager.
        /// </summary>
        /// <example>Jake.Zazhitski</example>
        [DataMember(Name = "manager", EmitDefaultValue = true)]
        public string Manager { get; set; }

        /// <summary>
        /// Indicates whether the group is a system group.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isSystem", EmitDefaultValue = true)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupSummaryDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
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
