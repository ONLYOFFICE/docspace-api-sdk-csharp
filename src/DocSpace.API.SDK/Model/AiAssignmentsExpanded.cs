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
    /// The bindings with &#x60;expand&#x3D;profile&#x60;: the bound profiles themselves, plus how many profiles the portal has, so a chat can start on this one read.
    /// </summary>
    [DataContract(Name = "AiAssignmentsExpanded")]
    public partial class AiAssignmentsExpanded : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAssignmentsExpanded" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiAssignmentsExpanded() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAssignmentsExpanded" /> class.
        /// </summary>
        /// <param name="assignments">The bound profiles keyed by action type, as &#x60;GET api/2.0/ai/profiles/list&#x60; describes them. A binding whose profile no longer exists is left out. (required).</param>
        /// <param name="profilesTotal">How many profiles the portal has. (required).</param>
        /// <param name="chatProfilesTotal">How many of those profiles can chat; a profile without declared capabilities counts as one that can. (required).</param>
        public AiAssignmentsExpanded(Dictionary<string, AiProfile> assignments = default, int profilesTotal = default, int chatProfilesTotal = default)
        {
            // to ensure "assignments" is required (not null)
            if (assignments == null)
            {
                throw new ArgumentNullException("assignments is a required property for AiAssignmentsExpanded and cannot be null");
            }
            this.Assignments = assignments;
            this.ProfilesTotal = profilesTotal;
            this.ChatProfilesTotal = chatProfilesTotal;
        }

        /// <summary>
        /// The bound profiles keyed by action type, as &#x60;GET api/2.0/ai/profiles/list&#x60; describes them. A binding whose profile no longer exists is left out.
        /// </summary>
        [DataMember(Name = "assignments", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, AiProfile> Assignments { get; set; }

        /// <summary>
        /// How many profiles the portal has.
        /// </summary>
        [DataMember(Name = "profilesTotal", IsRequired = true, EmitDefaultValue = true)]
        public int ProfilesTotal { get; set; }

        /// <summary>
        /// How many of those profiles can chat; a profile without declared capabilities counts as one that can.
        /// </summary>
        [DataMember(Name = "chatProfilesTotal", IsRequired = true, EmitDefaultValue = true)]
        public int ChatProfilesTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiAssignmentsExpanded {\n");
            sb.Append("  Assignments: ").Append(Assignments).Append("\n");
            sb.Append("  ProfilesTotal: ").Append(ProfilesTotal).Append("\n");
            sb.Append("  ChatProfilesTotal: ").Append(ChatProfilesTotal).Append("\n");
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
