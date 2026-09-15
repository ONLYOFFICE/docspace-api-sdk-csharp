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
    /// The request parameters for starting the reassignment process.
    /// </summary>
    [DataContract(Name = "StartReassignRequestDto")]
    public partial class StartReassignRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StartReassignRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StartReassignRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartReassignRequestDto" /> class.
        /// </summary>
        /// <param name="fromUserId">The ID of the user whose rooms and shared files are transferred away. The account has to have the &#x60;Terminated&#x60;  status already, and it cannot be a system account, the portal owner or the caller. (required).</param>
        /// <param name="toUserId">The ID of the user who receives the data. The account has to be an active room admin or DocSpace admin, so a  guest, a system account or a disabled account is rejected. (required).</param>
        /// <param name="deleteProfile">Specifies whether to delete the source profile once the transfer succeeds. When false, which is the default,  the emptied profile is kept and can be deleted later through &#x60;DELETE api/2.0/people/{userid}&#x60;..</param>
        public StartReassignRequestDto(Guid fromUserId = default, Guid toUserId = default, bool deleteProfile = default)
        {
            this.FromUserId = fromUserId;
            this.ToUserId = toUserId;
            this.DeleteProfile = deleteProfile;
        }

        /// <summary>
        /// The ID of the user whose rooms and shared files are transferred away. The account has to have the &#x60;Terminated&#x60;  status already, and it cannot be a system account, the portal owner or the caller.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "fromUserId", IsRequired = true, EmitDefaultValue = true)]
        public Guid FromUserId { get; set; }

        /// <summary>
        /// The ID of the user who receives the data. The account has to be an active room admin or DocSpace admin, so a  guest, a system account or a disabled account is rejected.
        /// </summary>
        /// <example>11111111-1111-1111-1111-111111111111</example>
        [DataMember(Name = "toUserId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ToUserId { get; set; }

        /// <summary>
        /// Specifies whether to delete the source profile once the transfer succeeds. When false, which is the default,  the emptied profile is kept and can be deleted later through &#x60;DELETE api/2.0/people/{userid}&#x60;.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "deleteProfile", EmitDefaultValue = true)]
        public bool DeleteProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartReassignRequestDto {\n");
            sb.Append("  FromUserId: ").Append(FromUserId).Append("\n");
            sb.Append("  ToUserId: ").Append(ToUserId).Append("\n");
            sb.Append("  DeleteProfile: ").Append(DeleteProfile).Append("\n");
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
