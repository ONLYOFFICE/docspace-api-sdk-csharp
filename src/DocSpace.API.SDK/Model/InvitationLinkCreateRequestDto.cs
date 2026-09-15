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
    /// The role a new invitation link grants, and the limits placed on it.
    /// </summary>
    [DataContract(Name = "InvitationLinkCreateRequestDto")]
    public partial class InvitationLinkCreateRequestDto : IValidatableObject
    {

        /// <summary>
        /// The role whoever follows the link joins with. Only &#x60;DocSpaceAdmin&#x60;, &#x60;RoomAdmin&#x60; and &#x60;User&#x60; are accepted, and  the role cannot be changed afterwards - delete the link and create one for the other role instead.
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
        /// <param name="employeeType">The role whoever follows the link joins with. Only &#x60;DocSpaceAdmin&#x60;, &#x60;RoomAdmin&#x60; and &#x60;User&#x60; are accepted, and  the role cannot be changed afterwards - delete the link and create one for the other role instead. (required).</param>
        /// <param name="expiration">When the link stops letting anyone in, read in the portal time zone. It has to lie in the future; leaving it  out creates a link with no deadline at all..</param>
        /// <param name="maxUseCount">How many accounts may join through the link in total. Leaving it out creates a link with no use limit; the  uses spent so far are reported as &#x60;currentUseCount&#x60;..</param>
        public InvitationLinkCreateRequestDto(EmployeeType employeeType = default, DateTime? expiration = default, int? maxUseCount = default)
        {
            this.EmployeeType = employeeType;
            this.Expiration = expiration;
            this.MaxUseCount = maxUseCount;
        }

        /// <summary>
        /// When the link stops letting anyone in, read in the portal time zone. It has to lie in the future; leaving it  out creates a link with no deadline at all.
        /// </summary>
        /// <example>2025-06-15T10:30:00.0000000Z</example>
        [DataMember(Name = "expiration", EmitDefaultValue = true)]
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// How many accounts may join through the link in total. Leaving it out creates a link with no use limit; the  uses spent so far are reported as &#x60;currentUseCount&#x60;.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "maxUseCount", EmitDefaultValue = true)]
        public int? MaxUseCount { get; set; }

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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // MaxUseCount (int?) maximum
            if (this.MaxUseCount > (int?)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxUseCount, must be a value less than or equal to 1000.", new [] { "MaxUseCount" });
            }

            // MaxUseCount (int?) minimum
            if (this.MaxUseCount < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxUseCount, must be a value greater than or equal to 1.", new [] { "MaxUseCount" });
            }

            yield break;
        }

    }


}
