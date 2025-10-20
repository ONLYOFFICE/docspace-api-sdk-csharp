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
    /// The parameters for saving form role mapping.
    /// </summary>
    [DataContract(Name = "SaveFormRoleMappingDtoInteger")]
    public partial class SaveFormRoleMappingDtoInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveFormRoleMappingDtoInteger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaveFormRoleMappingDtoInteger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveFormRoleMappingDtoInteger" /> class.
        /// </summary>
        /// <param name="formId">The form ID. (required).</param>
        /// <param name="roles">The collection of roles. (required).</param>
        public SaveFormRoleMappingDtoInteger(int formId = default, List<FormRole> roles = default)
        {
            this.FormId = formId;
            // to ensure "roles" is required (not null)
            if (roles == null)
            {
                throw new ArgumentNullException("roles is a required property for SaveFormRoleMappingDtoInteger and cannot be null");
            }
            this.Roles = roles;
        }

        /// <summary>
        /// The form ID.
        /// </summary>
        /// <value>The form ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "formId", IsRequired = true, EmitDefaultValue = true)]
        public int FormId { get; set; }

        /// <summary>
        /// The collection of roles.
        /// </summary>
        /// <value>The collection of roles.</value>
        [DataMember(Name = "roles", IsRequired = true, EmitDefaultValue = true)]
        public List<FormRole> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveFormRoleMappingDtoInteger {\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
