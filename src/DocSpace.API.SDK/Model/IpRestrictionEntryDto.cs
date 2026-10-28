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
    /// One allowed address.
    /// </summary>
    [DataContract(Name = "IpRestrictionEntryDto")]
    public partial class IpRestrictionEntryDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IpRestrictionEntryDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IpRestrictionEntryDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IpRestrictionEntryDto" /> class.
        /// </summary>
        /// <param name="ip">The IPv4 or IPv6 address. (required).</param>
        /// <param name="forAdmin">Whether the address admits administrators only..</param>
        public IpRestrictionEntryDto(string ip = default, bool forAdmin = default)
        {
            // to ensure "ip" is required (not null)
            if (ip == null)
            {
                throw new ArgumentNullException("ip is a required property for IpRestrictionEntryDto and cannot be null");
            }
            this.Ip = ip;
            this.ForAdmin = forAdmin;
        }

        /// <summary>
        /// The IPv4 or IPv6 address.
        /// </summary>
        /// <example>192.0.2.1</example>
        [DataMember(Name = "ip", IsRequired = true, EmitDefaultValue = true)]
        public string Ip { get; set; }

        /// <summary>
        /// Whether the address admits administrators only.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "forAdmin", EmitDefaultValue = true)]
        public bool ForAdmin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpRestrictionEntryDto {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  ForAdmin: ").Append(ForAdmin).Append("\n");
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
