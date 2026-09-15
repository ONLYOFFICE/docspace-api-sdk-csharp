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
    /// The parameters for updating the type of the user or guest when reassigning rooms and shared files.
    /// </summary>
    [DataContract(Name = "StartUpdateUserTypeDto")]
    public partial class StartUpdateUserTypeDto : IValidatableObject
    {

        /// <summary>
        /// The type to convert the account to. Only &#x60;Guest&#x60; and &#x60;User&#x60; are accepted, because they are the types that  cannot own rooms; &#x60;RoomAdmin&#x60;, &#x60;DocSpaceAdmin&#x60; and &#x60;All&#x60; are rejected here and belong to  &#x60;PUT api/2.0/people/type/{type}&#x60;.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public EmployeeType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StartUpdateUserTypeDto" /> class.
        /// </summary>
        /// <param name="type">The type to convert the account to. Only &#x60;Guest&#x60; and &#x60;User&#x60; are accepted, because they are the types that  cannot own rooms; &#x60;RoomAdmin&#x60;, &#x60;DocSpaceAdmin&#x60; and &#x60;All&#x60; are rejected here and belong to  &#x60;PUT api/2.0/people/type/{type}&#x60;..</param>
        /// <param name="userId">The ID of the account being converted. It has to be an active account other than the caller, and only the  portal owner may pass the ID of a DocSpace administrator..</param>
        /// <param name="reassignUserId">The ID of the administrator who receives the rooms and the shared files of the converted account. It has to be  an active room admin or DocSpace admin other than the converted account, and when it is omitted the data goes  to the caller..</param>
        public StartUpdateUserTypeDto(EmployeeType? type = default, Guid userId = default, Guid? reassignUserId = default)
        {
            this.Type = type;
            this.UserId = userId;
            this.ReassignUserId = reassignUserId;
        }

        /// <summary>
        /// The ID of the account being converted. It has to be an active account other than the caller, and only the  portal owner may pass the ID of a DocSpace administrator.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The ID of the administrator who receives the rooms and the shared files of the converted account. It has to be  an active room admin or DocSpace admin other than the converted account, and when it is omitted the data goes  to the caller.
        /// </summary>
        /// <example>11111111-1111-1111-1111-111111111111</example>
        [DataMember(Name = "reassignUserId", EmitDefaultValue = true)]
        public Guid? ReassignUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartUpdateUserTypeDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ReassignUserId: ").Append(ReassignUserId).Append("\n");
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
