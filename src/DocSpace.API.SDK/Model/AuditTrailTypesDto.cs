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
    /// The names of every audit trail type, one array per dimension of an audit event.
    /// </summary>
    [DataContract(Name = "AuditTrailTypesDto")]
    public partial class AuditTrailTypesDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailTypesDto" /> class.
        /// </summary>
        /// <param name="actions">The names of the audit event actions..</param>
        /// <param name="actionTypes">The names of the audit event action types..</param>
        /// <param name="productTypes">The names of the products an audit event can belong to..</param>
        /// <param name="moduleTypes">The names of the modules an audit event can belong to..</param>
        /// <param name="entryTypes">The names of the entry types an audit event can target..</param>
        public AuditTrailTypesDto(List<string> actions = default, List<string> actionTypes = default, List<string> productTypes = default, List<string> moduleTypes = default, List<string> entryTypes = default)
        {
            this.Actions = actions;
            this.ActionTypes = actionTypes;
            this.ProductTypes = productTypes;
            this.ModuleTypes = moduleTypes;
            this.EntryTypes = entryTypes;
        }

        /// <summary>
        /// The names of the audit event actions.
        /// </summary>
        /// <example>["FileCreated"]</example>
        [DataMember(Name = "actions", EmitDefaultValue = true)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// The names of the audit event action types.
        /// </summary>
        /// <example>["Create"]</example>
        [DataMember(Name = "actionTypes", EmitDefaultValue = true)]
        public List<string> ActionTypes { get; set; }

        /// <summary>
        /// The names of the products an audit event can belong to.
        /// </summary>
        /// <example>["Documents"]</example>
        [DataMember(Name = "productTypes", EmitDefaultValue = true)]
        public List<string> ProductTypes { get; set; }

        /// <summary>
        /// The names of the modules an audit event can belong to.
        /// </summary>
        /// <example>["Files"]</example>
        [DataMember(Name = "moduleTypes", EmitDefaultValue = true)]
        public List<string> ModuleTypes { get; set; }

        /// <summary>
        /// The names of the entry types an audit event can target.
        /// </summary>
        /// <example>["File"]</example>
        [DataMember(Name = "entryTypes", EmitDefaultValue = true)]
        public List<string> EntryTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditTrailTypesDto {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  ActionTypes: ").Append(ActionTypes).Append("\n");
            sb.Append("  ProductTypes: ").Append(ProductTypes).Append("\n");
            sb.Append("  ModuleTypes: ").Append(ModuleTypes).Append("\n");
            sb.Append("  EntryTypes: ").Append(EntryTypes).Append("\n");
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
