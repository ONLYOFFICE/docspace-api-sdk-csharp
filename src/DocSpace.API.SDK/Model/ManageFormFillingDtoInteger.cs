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
    /// The parameters for managing form filling.
    /// </summary>
    [DataContract(Name = "ManageFormFillingDtoInteger")]
    public partial class ManageFormFillingDtoInteger : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public FormFillingManageAction? Action { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageFormFillingDtoInteger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManageFormFillingDtoInteger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageFormFillingDtoInteger" /> class.
        /// </summary>
        /// <param name="formId">The ID of the form to manage. (required).</param>
        /// <param name="action">action.</param>
        public ManageFormFillingDtoInteger(int formId = default, FormFillingManageAction? action = default)
        {
            this.FormId = formId;
            this.Action = action;
        }

        /// <summary>
        /// The ID of the form to manage.
        /// </summary>
        /// <value>The ID of the form to manage.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "formId", IsRequired = true, EmitDefaultValue = true)]
        public int FormId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManageFormFillingDtoInteger {\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
