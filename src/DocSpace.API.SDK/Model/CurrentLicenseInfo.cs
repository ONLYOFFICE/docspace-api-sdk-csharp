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
    /// The current license information.
    /// </summary>
    [DataContract(Name = "CurrentLicenseInfo")]
    public partial class CurrentLicenseInfo : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentLicenseInfo" /> class.
        /// </summary>
        /// <param name="trial">Specifies whether the license is trial or not..</param>
        /// <param name="dueDate">The date when the license expires..</param>
        public CurrentLicenseInfo(bool trial = default, DateTime dueDate = default)
        {
            this.Trial = trial;
            this.DueDate = dueDate;
        }

        /// <summary>
        /// Specifies whether the license is trial or not.
        /// </summary>
        /// <value>Specifies whether the license is trial or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "trial", EmitDefaultValue = true)]
        public bool Trial { get; set; }

        /// <summary>
        /// The date when the license expires.
        /// </summary>
        /// <value>The date when the license expires.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentLicenseInfo {\n");
            sb.Append("  Trial: ").Append(Trial).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
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
