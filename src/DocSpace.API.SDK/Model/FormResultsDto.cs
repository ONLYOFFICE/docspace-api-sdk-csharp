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
    /// FormResultsDto
    /// </summary>
    [DataContract(Name = "FormResultsDto")]
    public partial class FormResultsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormResultsDto" /> class.
        /// </summary>
        /// <param name="createOn">The date and time when the form was created..</param>
        /// <param name="formsData">The list of forms data..</param>
        public FormResultsDto(DateTime createOn = default, List<FormsItemData> formsData = default)
        {
            this.CreateOn = createOn;
            this.FormsData = formsData;
        }

        /// <summary>
        /// The date and time when the form was created.
        /// </summary>
        /// <value>The date and time when the form was created.</value>
        /*
        <example>2008-04-10T06:30:00.0000000+04:00</example>
        */
        [DataMember(Name = "createOn", EmitDefaultValue = false)]
        public DateTime CreateOn { get; set; }

        /// <summary>
        /// The list of forms data.
        /// </summary>
        /// <value>The list of forms data.</value>
        [DataMember(Name = "formsData", EmitDefaultValue = false)]
        public List<FormsItemData> FormsData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormResultsDto {\n");
            sb.Append("  CreateOn: ").Append(CreateOn).Append("\n");
            sb.Append("  FormsData: ").Append(FormsData).Append("\n");
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
