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
    /// How access to one portal module is configured: whether it is restricted, and who is let in.
    /// </summary>
    [DataContract(Name = "SecurityDto")]
    public partial class SecurityDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityDto" /> class.
        /// </summary>
        /// <param name="webItemId">The module this entry is about, echoed from the identifier that was asked about. When several identifiers  are asked about at once, entries come back one per identifier and in the order they were sent, so they can  also be matched by position..</param>
        /// <param name="users">The individual members the rule was stored for. Members the caller is not allowed to see are left out, so  the same module can come back with different lists for different callers and an empty list does not prove  that nobody was granted access..</param>
        /// <param name="groups">The groups the rule was stored for, listed in full - unlike &#x60;users&#x60;, nothing is filtered out of it..</param>
        /// <param name="enabled">Whether access to the module is restricted to the subjects listed here. It is &#x60;false&#x60; for a module nobody  has ever configured, in which case the two lists say nothing about who may open it..</param>
        /// <param name="isSubItem">Whether the module hangs under another one rather than standing on its own. A sub-module is never returned  by &#x60;GET api/2.0/settings/security/modules&#x60;, which lists top-level modules only..</param>
        public SecurityDto(string webItemId = default, List<EmployeeDto> users = default, List<GroupSummaryDto> groups = default, bool enabled = default, bool isSubItem = default)
        {
            this.WebItemId = webItemId;
            this.Users = users;
            this.Groups = groups;
            this.Enabled = enabled;
            this.IsSubItem = isSubItem;
        }

        /// <summary>
        /// The module this entry is about, echoed from the identifier that was asked about. When several identifiers  are asked about at once, entries come back one per identifier and in the order they were sent, so they can  also be matched by position.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "webItemId", EmitDefaultValue = true)]
        public string WebItemId { get; set; }

        /// <summary>
        /// The individual members the rule was stored for. Members the caller is not allowed to see are left out, so  the same module can come back with different lists for different callers and an empty list does not prove  that nobody was granted access.
        /// </summary>
        /// <example>[{"displayName":"John Doe"}]</example>
        [DataMember(Name = "users", EmitDefaultValue = true)]
        public List<EmployeeDto> Users { get; set; }

        /// <summary>
        /// The groups the rule was stored for, listed in full - unlike &#x60;users&#x60;, nothing is filtered out of it.
        /// </summary>
        /// <example>[{"id":"00000000-0000-0000-0000-000000000000","name":"Administrators"}]</example>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<GroupSummaryDto> Groups { get; set; }

        /// <summary>
        /// Whether access to the module is restricted to the subjects listed here. It is &#x60;false&#x60; for a module nobody  has ever configured, in which case the two lists say nothing about who may open it.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether the module hangs under another one rather than standing on its own. A sub-module is never returned  by &#x60;GET api/2.0/settings/security/modules&#x60;, which lists top-level modules only.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isSubItem", EmitDefaultValue = true)]
        public bool IsSubItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityDto {\n");
            sb.Append("  WebItemId: ").Append(WebItemId).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  IsSubItem: ").Append(IsSubItem).Append("\n");
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
