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
    /// The request parameters for creating an invitation link.
    /// </summary>
    [DataContract(Name = "InvitationLinkCreateRequestDto")]
    public partial class InvitationLinkCreateRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EmployeeType
        /// </summary>
        [DataMember(Name = "employeeType", IsRequired = true, EmitDefaultValue = true)]
        public EmployeeType EmployeeType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationLinkCreateRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvitationLinkCreateRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationLinkCreateRequestDto" /> class.
        /// </summary>
        /// <param name="employeeType">employeeType (required).</param>
        /// <param name="expiration">The expiration date of the invitation link..</param>
        /// <param name="maxUseCount">The maximum number of times the invitation link can be used..</param>
        public InvitationLinkCreateRequestDto(EmployeeType employeeType = default, DateTime expiration = default, int maxUseCount = default)
        {
            this.EmployeeType = employeeType;
            this.Expiration = expiration;
            this.MaxUseCount = maxUseCount;
        }

        /// <summary>
        /// The expiration date of the invitation link.
        /// </summary>
        /// <value>The expiration date of the invitation link.</value>
        /*
        <example>2008-04-10T06:30:00.0000000+04:00</example>
        */
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public DateTime Expiration { get; set; }

        /// <summary>
        /// The maximum number of times the invitation link can be used.
        /// </summary>
        /// <value>The maximum number of times the invitation link can be used.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "maxUseCount", EmitDefaultValue = false)]
        public int MaxUseCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvitationLinkCreateRequestDto {\n");
            sb.Append("  EmployeeType: ").Append(EmployeeType).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  MaxUseCount: ").Append(MaxUseCount).Append("\n");
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
            // MaxUseCount (int) maximum
            if (this.MaxUseCount > (int)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxUseCount, must be a value less than or equal to 1000.", new [] { "MaxUseCount" });
            }

            // MaxUseCount (int) minimum
            if (this.MaxUseCount < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxUseCount, must be a value greater than or equal to 1.", new [] { "MaxUseCount" });
            }

            yield break;
        }

    }


}
