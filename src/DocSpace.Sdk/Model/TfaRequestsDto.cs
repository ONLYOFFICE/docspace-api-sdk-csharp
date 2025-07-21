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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The request parameters for configuring the Two-Factor Authentication (TFA) settings.
    /// </summary>
    [DataContract(Name = "TfaRequestsDto")]
    public partial class TfaRequestsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TfaRequestsDtoType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TfaRequestsDto" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="id">The ID of the user for whom the TFA settings are being configured..</param>
        /// <param name="trustedIps">The list of IP addresses that bypass TFA verification..</param>
        /// <param name="mandatoryUsers">The list of user IDs for whom TFA is mandatory..</param>
        /// <param name="mandatoryGroups">The list group IDs whose members must use TFA..</param>
        public TfaRequestsDto(TfaRequestsDtoType? type = default, Guid id = default, List<string> trustedIps = default, List<Guid> mandatoryUsers = default, List<Guid> mandatoryGroups = default)
        {
            this.Type = type;
            this.Id = id;
            this.TrustedIps = trustedIps;
            this.MandatoryUsers = mandatoryUsers;
            this.MandatoryGroups = mandatoryGroups;
        }

        /// <summary>
        /// The ID of the user for whom the TFA settings are being configured.
        /// </summary>
        /// <value>The ID of the user for whom the TFA settings are being configured.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The list of IP addresses that bypass TFA verification.
        /// </summary>
        /// <value>The list of IP addresses that bypass TFA verification.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "trustedIps", EmitDefaultValue = true)]
        public List<string> TrustedIps { get; set; }

        /// <summary>
        /// The list of user IDs for whom TFA is mandatory.
        /// </summary>
        /// <value>The list of user IDs for whom TFA is mandatory.</value>
        /*
        <example>[&quot;75a5f745-f697-4418-b38d-0fe0d277e258&quot;]</example>
        */
        [DataMember(Name = "mandatoryUsers", EmitDefaultValue = true)]
        public List<Guid> MandatoryUsers { get; set; }

        /// <summary>
        /// The list group IDs whose members must use TFA.
        /// </summary>
        /// <value>The list group IDs whose members must use TFA.</value>
        /*
        <example>[&quot;75a5f745-f697-4418-b38d-0fe0d277e258&quot;]</example>
        */
        [DataMember(Name = "mandatoryGroups", EmitDefaultValue = true)]
        public List<Guid> MandatoryGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaRequestsDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TrustedIps: ").Append(TrustedIps).Append("\n");
            sb.Append("  MandatoryUsers: ").Append(MandatoryUsers).Append("\n");
            sb.Append("  MandatoryGroups: ").Append(MandatoryGroups).Append("\n");
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
