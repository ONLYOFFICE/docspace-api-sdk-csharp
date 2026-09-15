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
    /// The access rule stored for one portal module: whether it may be opened, and by whom.
    /// </summary>
    [DataContract(Name = "WebItemSecurityRequestsDto")]
    public partial class WebItemSecurityRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebItemSecurityRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebItemSecurityRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebItemSecurityRequestsDto" /> class.
        /// </summary>
        /// <param name="id">The module the rule applies to, given as a GUID. A value that is not a GUID fails the request as invalid. (required).</param>
        /// <param name="enabled">Whether the module may be opened. It decides the outcome only while &#x60;subjects&#x60; names somebody: an empty  &#x60;subjects&#x60; array is stored as access for everyone whatever this flag says..</param>
        /// <param name="subjects">The users and groups the rule is stored for, given by their IDs. This is the whole allow-list that is to hold  afterwards and not a list of additions - what was stored before is dropped. Leaving it out applies &#x60;enabled&#x60;  to everyone and skips the audit trail entry, while sending it empty stores access for everyone..</param>
        public WebItemSecurityRequestsDto(string id = default, bool enabled = default, List<Guid> subjects = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for WebItemSecurityRequestsDto and cannot be null");
            }
            this.Id = id;
            this.Enabled = enabled;
            this.Subjects = subjects;
        }

        /// <summary>
        /// The module the rule applies to, given as a GUID. A value that is not a GUID fails the request as invalid.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Whether the module may be opened. It decides the outcome only while &#x60;subjects&#x60; names somebody: an empty  &#x60;subjects&#x60; array is stored as access for everyone whatever this flag says.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The users and groups the rule is stored for, given by their IDs. This is the whole allow-list that is to hold  afterwards and not a list of additions - what was stored before is dropped. Leaving it out applies &#x60;enabled&#x60;  to everyone and skips the audit trail entry, while sending it empty stores access for everyone.
        /// </summary>
        /// <example>["00000000-0000-0000-0000-000000000000"]</example>
        [DataMember(Name = "subjects", EmitDefaultValue = true)]
        public List<Guid> Subjects { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebItemSecurityRequestsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Subjects: ").Append(Subjects).Append("\n");
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
