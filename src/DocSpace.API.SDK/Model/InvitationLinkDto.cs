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
    /// The invitation link parameters.
    /// </summary>
    [DataContract(Name = "InvitationLinkDto")]
    public partial class InvitationLinkDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EmployeeType
        /// </summary>
        [DataMember(Name = "employeeType", IsRequired = true, EmitDefaultValue = true)]
        public EmployeeType EmployeeType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationLinkDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvitationLinkDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationLinkDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the invitation link..</param>
        /// <param name="employeeType">employeeType (required).</param>
        /// <param name="expiration">expiration.</param>
        /// <param name="isExpired">Indicates whether the invitation link has expired..</param>
        /// <param name="maxUseCount">The maximum number of times the invitation link can be used..</param>
        /// <param name="currentUseCount">The current number of times the invitation link has been used..</param>
        /// <param name="url">The URL of the invitation link..</param>
        public InvitationLinkDto(Guid id = default, EmployeeType employeeType = default, ApiDateTime expiration = default, bool isExpired = default, int? maxUseCount = default, int currentUseCount = default, string url = default)
        {
            this.EmployeeType = employeeType;
            this.Id = id;
            this.Expiration = expiration;
            this.IsExpired = isExpired;
            this.MaxUseCount = maxUseCount;
            this.CurrentUseCount = currentUseCount;
            this.Url = url;
        }

        /// <summary>
        /// The ID of the invitation link.
        /// </summary>
        /// <value>The ID of the invitation link.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Expiration
        /// </summary>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public ApiDateTime Expiration { get; set; }

        /// <summary>
        /// Indicates whether the invitation link has expired.
        /// </summary>
        /// <value>Indicates whether the invitation link has expired.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isExpired", EmitDefaultValue = true)]
        public bool IsExpired { get; set; }

        /// <summary>
        /// The maximum number of times the invitation link can be used.
        /// </summary>
        /// <value>The maximum number of times the invitation link can be used.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "maxUseCount", EmitDefaultValue = true)]
        public int? MaxUseCount { get; set; }

        /// <summary>
        /// The current number of times the invitation link has been used.
        /// </summary>
        /// <value>The current number of times the invitation link has been used.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "currentUseCount", EmitDefaultValue = false)]
        public int CurrentUseCount { get; set; }

        /// <summary>
        /// The URL of the invitation link.
        /// </summary>
        /// <value>The URL of the invitation link.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvitationLinkDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeeType: ").Append(EmployeeType).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  MaxUseCount: ").Append(MaxUseCount).Append("\n");
            sb.Append("  CurrentUseCount: ").Append(CurrentUseCount).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
