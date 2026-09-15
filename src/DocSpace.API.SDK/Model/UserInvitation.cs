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
    /// Which pending room invitations are to be sent again.
    /// </summary>
    [DataContract(Name = "UserInvitation")]
    public partial class UserInvitation : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitation" /> class.
        /// </summary>
        /// <param name="usersIds">The accounts to write to, taken from &#x60;GET api/2.0/files/rooms/{id}/share&#x60;. Anyone who has already joined, is  not in the room, or is invisible to the caller is skipped without an error, and the field is ignored once  every pending invitation is being resent..</param>
        /// <param name="resendAll">Whether every invitation of the room that is still waiting is sent again. With it on the list of accounts is  ignored, and with it off an empty list means that nothing is sent at all..</param>
        public UserInvitation(List<Guid> usersIds = default, bool resendAll = default)
        {
            this.UsersIds = usersIds;
            this.ResendAll = resendAll;
        }

        /// <summary>
        /// The accounts to write to, taken from &#x60;GET api/2.0/files/rooms/{id}/share&#x60;. Anyone who has already joined, is  not in the room, or is invisible to the caller is skipped without an error, and the field is ignored once  every pending invitation is being resent.
        /// </summary>
        /// <example>["e9a7b4c1-2d3f-4a56-8b90-1c2d3e4f5a6b"]</example>
        [DataMember(Name = "usersIds", EmitDefaultValue = true)]
        public List<Guid> UsersIds { get; set; }

        /// <summary>
        /// Whether every invitation of the room that is still waiting is sent again. With it on the list of accounts is  ignored, and with it off an empty list means that nothing is sent at all.
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
            sb.Append("class UserInvitation {\n");
            sb.Append("  UsersIds: ").Append(UsersIds).Append("\n");
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
