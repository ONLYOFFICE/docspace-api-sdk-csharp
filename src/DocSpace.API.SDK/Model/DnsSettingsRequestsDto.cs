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
    /// The custom domain the portal answers on, and whether that mapping is in force.
    /// </summary>
    [DataContract(Name = "DnsSettingsRequestsDto")]
    public partial class DnsSettingsRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DnsSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="dnsName">The domain the portal is to be reachable under, as a bare hostname without a scheme. It must not collide with  the reserved base domain of the installation, and a name that fails validation is refused without disturbing  the mapping in force. It is read only while &#x60;enable&#x60; is true..</param>
        /// <param name="enable">Whether the custom domain is put in force. Setting it false clears the mapping and ignores &#x60;dnsName&#x60;; setting  it true also stops the previous domain from answering and rewrites any Content Security Policy entry that  named it..</param>
        public DnsSettingsRequestsDto(string dnsName = default, bool enable = default)
        {
            this.DnsName = dnsName;
            this.Enable = enable;
        }

        /// <summary>
        /// The domain the portal is to be reachable under, as a bare hostname without a scheme. It must not collide with  the reserved base domain of the installation, and a name that fails validation is refused without disturbing  the mapping in force. It is read only while &#x60;enable&#x60; is true.
        /// </summary>
        /// <example>example.com</example>
        [DataMember(Name = "dnsName", EmitDefaultValue = true)]
        public string DnsName { get; set; }

        /// <summary>
        /// Whether the custom domain is put in force. Setting it false clears the mapping and ignores &#x60;dnsName&#x60;; setting  it true also stops the previous domain from answering and rewrites any Content Security Policy entry that  named it.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enable", EmitDefaultValue = true)]
        public bool Enable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DnsSettingsRequestsDto {\n");
            sb.Append("  DnsName: ").Append(DnsName).Append("\n");
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
