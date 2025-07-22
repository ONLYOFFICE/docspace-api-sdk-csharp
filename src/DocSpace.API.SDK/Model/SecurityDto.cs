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
    /// The security information.
    /// </summary>
    [DataContract(Name = "SecurityDto")]
    public partial class SecurityDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityDto" /> class.
        /// </summary>
        /// <param name="webItemId">The module ID..</param>
        /// <param name="users">The list of users with the access to the module..</param>
        /// <param name="groups">The list of groups with the access to the module..</param>
        /// <param name="enabled">Specifies if the security settings are enabled or not..</param>
        /// <param name="isSubItem">Specifies if the module is a subitem or not..</param>
        public SecurityDto(string webItemId = default, List<EmployeeDto> users = default, List<GroupSummaryDto> groups = default, bool enabled = default, bool isSubItem = default)
        {
            this.WebItemId = webItemId;
            this.Users = users;
            this.Groups = groups;
            this.Enabled = enabled;
            this.IsSubItem = isSubItem;
        }

        /// <summary>
        /// The module ID.
        /// </summary>
        /// <value>The module ID.</value>
        /*
        <example>{00000000-0000-0000-0000-000000000000}</example>
        */
        [DataMember(Name = "webItemId", EmitDefaultValue = true)]
        public string WebItemId { get; set; }

        /// <summary>
        /// The list of users with the access to the module.
        /// </summary>
        /// <value>The list of users with the access to the module.</value>
        [DataMember(Name = "users", EmitDefaultValue = true)]
        public List<EmployeeDto> Users { get; set; }

        /// <summary>
        /// The list of groups with the access to the module.
        /// </summary>
        /// <value>The list of groups with the access to the module.</value>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<GroupSummaryDto> Groups { get; set; }

        /// <summary>
        /// Specifies if the security settings are enabled or not.
        /// </summary>
        /// <value>Specifies if the security settings are enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Specifies if the module is a subitem or not.
        /// </summary>
        /// <value>Specifies if the module is a subitem or not.</value>
        /*
        <example>false</example>
        */
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
