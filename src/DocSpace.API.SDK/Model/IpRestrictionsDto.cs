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
    /// The addresses allowed to reach the portal, and whether the restriction is enforced.
    /// </summary>
    [DataContract(Name = "IpRestrictionsDto")]
    public partial class IpRestrictionsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IpRestrictionsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IpRestrictionsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IpRestrictionsDto" /> class.
        /// </summary>
        /// <param name="ipRestrictions">The allowed addresses, each entry pairing a single IPv4 or IPv6 address with the flag that limits it to  administrators. This is the whole list that is to hold afterwards: entries not repeated here are deleted.  Ranges written as &#x60;from-to&#x60; and CIDR blocks are refused with 400, even though the portal matches such forms  when they are already stored. Enforcement spares only the portal owner and the installation own networks, so  a list without the caller address locks the remaining administrators out. (required).</param>
        /// <param name="enable">Whether the list is enforced. Leaving it out follows the list - on when addresses are sent, off when the list  is empty - and sending &#x60;true&#x60; with an empty list is refused with 400, since that would admit nobody..</param>
        public IpRestrictionsDto(List<IpRestrictionBase> ipRestrictions = default, bool? enable = default)
        {
            // to ensure "ipRestrictions" is required (not null)
            if (ipRestrictions == null)
            {
                throw new ArgumentNullException("ipRestrictions is a required property for IpRestrictionsDto and cannot be null");
            }
            this.IpRestrictions = ipRestrictions;
            this.Enable = enable;
        }

        /// <summary>
        /// The allowed addresses, each entry pairing a single IPv4 or IPv6 address with the flag that limits it to  administrators. This is the whole list that is to hold afterwards: entries not repeated here are deleted.  Ranges written as &#x60;from-to&#x60; and CIDR blocks are refused with 400, even though the portal matches such forms  when they are already stored. Enforcement spares only the portal owner and the installation own networks, so  a list without the caller address locks the remaining administrators out.
        /// </summary>
        /// <example>[{"ip":"192.0.2.1","forAdmin":false}]</example>
        [DataMember(Name = "ipRestrictions", IsRequired = true, EmitDefaultValue = true)]
        public List<IpRestrictionBase> IpRestrictions { get; set; }

        /// <summary>
        /// Whether the list is enforced. Leaving it out follows the list - on when addresses are sent, off when the list  is empty - and sending &#x60;true&#x60; with an empty list is refused with 400, since that would admit nobody.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool? Enable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpRestrictionsDto {\n");
            sb.Append("  IpRestrictions: ").Append(IpRestrictions).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
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
