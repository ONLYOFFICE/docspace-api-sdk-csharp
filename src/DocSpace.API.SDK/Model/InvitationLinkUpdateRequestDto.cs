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
    /// The invitation link being changed, with the deadline and use limit it is to have afterwards.
    /// </summary>
    [DataContract(Name = "InvitationLinkUpdateRequestDto")]
    public partial class InvitationLinkUpdateRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationLinkUpdateRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvitationLinkUpdateRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationLinkUpdateRequestDto" /> class.
        /// </summary>
        /// <param name="id">The link to change, by the &#x60;id&#x60; that creating or reading it returned. The role behind that id cannot be  changed here. (required).</param>
        /// <param name="expiration">The new deadline, read in the portal time zone. The body is applied as a whole, so leaving it out clears the  deadline rather than keeping the current one; a moment in the past is refused..</param>
        /// <param name="maxUseCount">The new total number of accounts that may join through the link. It may not be lower than the uses already  spent, which the link reports as &#x60;currentUseCount&#x60;, and leaving it out removes the limit rather than keeping  the current one..</param>
        public InvitationLinkUpdateRequestDto(Guid id = default, DateTime? expiration = default, int? maxUseCount = default)
        {
            this.Id = id;
            this.Expiration = expiration;
            this.MaxUseCount = maxUseCount;
        }

        /// <summary>
        /// The link to change, by the &#x60;id&#x60; that creating or reading it returned. The role behind that id cannot be  changed here.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// The new deadline, read in the portal time zone. The body is applied as a whole, so leaving it out clears the  deadline rather than keeping the current one; a moment in the past is refused.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "expiration", EmitDefaultValue = true)]
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// The new total number of accounts that may join through the link. It may not be lower than the uses already  spent, which the link reports as &#x60;currentUseCount&#x60;, and leaving it out removes the limit rather than keeping  the current one.
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
            sb.Append("class InvitationLinkUpdateRequestDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
