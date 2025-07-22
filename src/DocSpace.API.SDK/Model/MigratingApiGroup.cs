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
    /// MigratingApiGroup
    /// </summary>
    [DataContract(Name = "MigratingApiGroup")]
    public partial class MigratingApiGroup : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MigratingApiGroup" /> class.
        /// </summary>
        /// <param name="shouldImport">shouldImport.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="moduleName">moduleName.</param>
        /// <param name="userUidList">userUidList.</param>
        public MigratingApiGroup(bool shouldImport = default, string groupName = default, string moduleName = default, List<string> userUidList = default)
        {
            this.ShouldImport = shouldImport;
            this.GroupName = groupName;
            this.ModuleName = moduleName;
            this.UserUidList = userUidList;
        }

        /// <summary>
        /// Gets or Sets ShouldImport
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "shouldImport", EmitDefaultValue = true)]
        public bool ShouldImport { get; set; }

        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or Sets ModuleName
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "moduleName", EmitDefaultValue = true)]
        public string ModuleName { get; set; }

        /// <summary>
        /// Gets or Sets UserUidList
        /// </summary>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "userUidList", EmitDefaultValue = true)]
        public List<string> UserUidList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigratingApiGroup {\n");
            sb.Append("  ShouldImport: ").Append(ShouldImport).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  ModuleName: ").Append(ModuleName).Append("\n");
            sb.Append("  UserUidList: ").Append(UserUidList).Append("\n");
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
