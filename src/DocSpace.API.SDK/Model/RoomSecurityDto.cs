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
    /// The outcome of a change of the room membership.
    /// </summary>
    [DataContract(Name = "RoomSecurityDto")]
    public partial class RoomSecurityDto : IValidatableObject
    {

        /// <summary>
        /// Reports the one case in which nothing at all was changed: a member being removed still holds a role in a form  of the room, and the request did not ask to remove them anyway. Repeat the call with &#x60;force&#x60; to remove them  together with the role.
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public RoomSecurityError? Error { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomSecurityDto" /> class.
        /// </summary>
        /// <param name="members">The access entries of the subjects named in the request, read back after the change was applied. A subject the  caller may not see is missing from it, so comparing this list with the request is the way to learn who was  skipped; it is null when nothing was applied at all..</param>
        /// <param name="warning">The reason the first subject that could not be handled was skipped, in the language of the request, while the  rest of the list was still applied. Null when every named subject went through. The text is meant to be shown  to a person, not matched against..</param>
        /// <param name="error">Reports the one case in which nothing at all was changed: a member being removed still holds a role in a form  of the room, and the request did not ask to remove them anyway. Repeat the call with &#x60;force&#x60; to remove them  together with the role..</param>
        public RoomSecurityDto(List<FileShareDto> members = default, string warning = default, RoomSecurityError? error = default)
        {
            this.Members = members;
            this.Warning = warning;
            this.Error = error;
        }

        /// <summary>
        /// The access entries of the subjects named in the request, read back after the change was applied. A subject the  caller may not see is missing from it, so comparing this list with the request is the way to learn who was  skipped; it is null when nothing was applied at all.
        /// </summary>
        /// <example>[{"access":10,"isOwner":false,"subjectType":0}]</example>
        [DataMember(Name = "members", EmitDefaultValue = true)]
        public List<FileShareDto> Members { get; set; }

        /// <summary>
        /// The reason the first subject that could not be handled was skipped, in the language of the request, while the  rest of the list was still applied. Null when every named subject went through. The text is meant to be shown  to a person, not matched against.
        /// </summary>
        /// <example>The maximum number of links is 10</example>
        [DataMember(Name = "warning", EmitDefaultValue = true)]
        public string Warning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomSecurityDto {\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
