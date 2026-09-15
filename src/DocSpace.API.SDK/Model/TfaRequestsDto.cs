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
    /// The portal two-factor policy: which method is in force, who must pass it, and from where it is waived.
    /// </summary>
    [DataContract(Name = "TfaRequestsDto")]
    public partial class TfaRequestsDto : IValidatableObject
    {

        /// <summary>
        /// The second factor the portal demands. The two methods are mutually exclusive, so switching one on switches  the other off, and any value outside the defined set is read as switching TFA off rather than refused.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TfaRequestsDtoType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TfaRequestsDto" /> class.
        /// </summary>
        /// <param name="type">The second factor the portal demands. The two methods are mutually exclusive, so switching one on switches  the other off, and any value outside the defined set is read as switching TFA off rather than refused..</param>
        /// <param name="id">The account the request concerns, by portal user ID. Naming the portal owner is refused unless it is the  caller&#39;s own account. Where an operation detaches an authenticator application, the empty GUID and the  caller&#39;s own ID both mean the caller..</param>
        /// <param name="trustedIps">The list of IP addresses that bypass TFA verification. Each entry is a single address, an inclusive  from-to range or a CIDR block. This is the whole list that is to hold afterwards, so send the addresses  already trusted along with a new one; an entry that cannot be parsed fails the call with 400, and accounts  named as mandatory still have to pass the challenge even from a trusted address..</param>
        /// <param name="mandatoryUsers">The accounts that must pass the challenge whatever their address, by portal user ID. This is the whole list  that is to hold afterwards - leaving it out clears it rather than keeping it - and naming the portal owner is  refused unless the caller is the owner..</param>
        /// <param name="mandatoryGroups">The groups whose members must pass the challenge whatever their address, by group ID. This is the whole list  that is to hold afterwards - leaving it out clears it rather than keeping it..</param>
        public TfaRequestsDto(TfaRequestsDtoType? type = default, Guid id = default, List<string> trustedIps = default, List<Guid> mandatoryUsers = default, List<Guid> mandatoryGroups = default)
        {
            this.Type = type;
            this.Id = id;
            this.TrustedIps = trustedIps;
            this.MandatoryUsers = mandatoryUsers;
            this.MandatoryGroups = mandatoryGroups;
        }

        /// <summary>
        /// The account the request concerns, by portal user ID. Naming the portal owner is refused unless it is the  caller&#39;s own account. Where an operation detaches an authenticator application, the empty GUID and the  caller&#39;s own ID both mean the caller.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The list of IP addresses that bypass TFA verification. Each entry is a single address, an inclusive  from-to range or a CIDR block. This is the whole list that is to hold afterwards, so send the addresses  already trusted along with a new one; an entry that cannot be parsed fails the call with 400, and accounts  named as mandatory still have to pass the challenge even from a trusted address.
        /// </summary>
        /// <example>["192.0.2.1","198.51.100.1-198.51.100.20","203.0.113.0/24"]</example>
        [DataMember(Name = "trustedIps", EmitDefaultValue = true)]
        public List<string> TrustedIps { get; set; }

        /// <summary>
        /// The accounts that must pass the challenge whatever their address, by portal user ID. This is the whole list  that is to hold afterwards - leaving it out clears it rather than keeping it - and naming the portal owner is  refused unless the caller is the owner.
        /// </summary>
        /// <example>["00000000-0000-0000-0000-000000000000"]</example>
        [DataMember(Name = "mandatoryUsers", EmitDefaultValue = true)]
        public List<Guid> MandatoryUsers { get; set; }

        /// <summary>
        /// The groups whose members must pass the challenge whatever their address, by group ID. This is the whole list  that is to hold afterwards - leaving it out clears it rather than keeping it.
        /// </summary>
        /// <example>["00000000-0000-0000-0000-000000000000"]</example>
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
