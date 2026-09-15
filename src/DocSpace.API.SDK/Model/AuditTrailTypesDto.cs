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
    /// The vocabularies the audit and login-history filters accept, one array of names per dimension of an event.
    /// </summary>
    [DataContract(Name = "AuditTrailTypesDto")]
    public partial class AuditTrailTypesDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditTrailTypesDto" /> class.
        /// </summary>
        /// <param name="actions">Every action name the build can record, spelled as the &#x60;action&#x60; filter of  &#x60;GET api/2.0/security/audit/events/filter&#x60; and &#x60;GET api/2.0/security/audit/login/filter&#x60; expects it. It is  the whole vocabulary, not the actions this portal has recorded, and only a handful of the names are the  sign-in actions the login filter accepts..</param>
        /// <param name="actionTypes">The kinds of change an action can stand for, spelled as the &#x60;actionType&#x60; filter of  &#x60;GET api/2.0/security/audit/events/filter&#x60; expects it..</param>
        /// <param name="productTypes">The products an action can belong to, spelled as the &#x60;productType&#x60; filter of  &#x60;GET api/2.0/security/audit/mappers&#x60; expects it. The audit trail itself cannot be filtered by product..</param>
        /// <param name="moduleTypes">The locations inside those products, spelled as the &#x60;moduleType&#x60; filter of  &#x60;GET api/2.0/security/audit/events/filter&#x60; and &#x60;GET api/2.0/security/audit/mappers&#x60; expects it..</param>
        /// <param name="entryTypes">The kinds of object an action can be applied to, spelled as the &#x60;entryType&#x60; filter of  &#x60;GET api/2.0/security/audit/events/filter&#x60; expects it..</param>
        public AuditTrailTypesDto(List<string> actions = default, List<string> actionTypes = default, List<string> productTypes = default, List<string> moduleTypes = default, List<string> entryTypes = default)
        {
            this.Actions = actions;
            this.ActionTypes = actionTypes;
            this.ProductTypes = productTypes;
            this.ModuleTypes = moduleTypes;
            this.EntryTypes = entryTypes;
        }

        /// <summary>
        /// Every action name the build can record, spelled as the &#x60;action&#x60; filter of  &#x60;GET api/2.0/security/audit/events/filter&#x60; and &#x60;GET api/2.0/security/audit/login/filter&#x60; expects it. It is  the whole vocabulary, not the actions this portal has recorded, and only a handful of the names are the  sign-in actions the login filter accepts.
        /// </summary>
        /// <example>["FileCreated"]</example>
        [DataMember(Name = "actions", EmitDefaultValue = true)]
        public List<string> Actions { get; set; }

        /// <summary>
        /// The kinds of change an action can stand for, spelled as the &#x60;actionType&#x60; filter of  &#x60;GET api/2.0/security/audit/events/filter&#x60; expects it.
        /// </summary>
        /// <example>["Create"]</example>
        [DataMember(Name = "actionTypes", EmitDefaultValue = true)]
        public List<string> ActionTypes { get; set; }

        /// <summary>
        /// The products an action can belong to, spelled as the &#x60;productType&#x60; filter of  &#x60;GET api/2.0/security/audit/mappers&#x60; expects it. The audit trail itself cannot be filtered by product.
        /// </summary>
        /// <example>["Documents"]</example>
        [DataMember(Name = "productTypes", EmitDefaultValue = true)]
        public List<string> ProductTypes { get; set; }

        /// <summary>
        /// The locations inside those products, spelled as the &#x60;moduleType&#x60; filter of  &#x60;GET api/2.0/security/audit/events/filter&#x60; and &#x60;GET api/2.0/security/audit/mappers&#x60; expects it.
        /// </summary>
        /// <example>["Files"]</example>
        [DataMember(Name = "moduleTypes", EmitDefaultValue = true)]
        public List<string> ModuleTypes { get; set; }

        /// <summary>
        /// The kinds of object an action can be applied to, spelled as the &#x60;entryType&#x60; filter of  &#x60;GET api/2.0/security/audit/events/filter&#x60; expects it.
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
