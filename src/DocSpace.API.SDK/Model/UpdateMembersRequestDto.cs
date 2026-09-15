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
    /// The request parameters for updating the user information.
    /// </summary>
    [DataContract(Name = "UpdateMembersRequestDto")]
    public partial class UpdateMembersRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMembersRequestDto" /> class.
        /// </summary>
        /// <param name="userIds">The accounts the operation applies to. System accounts are dropped from the list without an error, and the  remaining ones are processed in the order they are given..</param>
        /// <param name="resendAll">Reaches every pending account of the portal instead of the ones in &#x60;userIds&#x60;. It is read only by  &#x60;PUT api/2.0/people/invite&#x60; and is ignored by every other operation that binds this body..</param>
        public UpdateMembersRequestDto(List<Guid> userIds = default, bool resendAll = default)
        {
            this.UserIds = userIds;
            this.ResendAll = resendAll;
        }

        /// <summary>
        /// The accounts the operation applies to. System accounts are dropped from the list without an error, and the  remaining ones are processed in the order they are given.
        /// </summary>
        /// <example>["00000000-0000-0000-0000-000000000000","11111111-1111-1111-1111-111111111111"]</example>
        [DataMember(Name = "userIds", EmitDefaultValue = true)]
        public List<Guid> UserIds { get; set; }

        /// <summary>
        /// Reaches every pending account of the portal instead of the ones in &#x60;userIds&#x60;. It is read only by  &#x60;PUT api/2.0/people/invite&#x60; and is ignored by every other operation that binds this body.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "resendAll", EmitDefaultValue = true)]
        public bool ResendAll { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMembersRequestDto {\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  ResendAll: ").Append(ResendAll).Append("\n");
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
