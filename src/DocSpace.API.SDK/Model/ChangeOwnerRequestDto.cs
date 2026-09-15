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
    /// The rooms and files to hand over, together with the account that takes them.
    /// </summary>
    [DataContract(Name = "ChangeOwnerRequestDto")]
    public partial class ChangeOwnerRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeOwnerRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeOwnerRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeOwnerRequestDto" /> class.
        /// </summary>
        /// <param name="folderIds">The rooms to hand over, identified as &#x60;GET api/2.0/files/rooms&#x60; returns them - a number for a room stored on  the portal and a string for one that lives on a connected third-party account. Only rooms belong here; a  folder inside a room is refused..</param>
        /// <param name="fileIds">The files to hand over, identified as a listing operation returns them - a number for a file stored on the  portal and a string for one on a connected third-party account. Only a file kept in the portal&#39;s common  section is accepted..</param>
        /// <param name="userId">The account that becomes the owner of every listed entry. It has to be an active member allowed to manage  rooms, so a deactivated account, a guest or a plain member is rejected, and for a private room the account  must have set up its encryption keys beforehand. (required).</param>
        public ChangeOwnerRequestDto(List<BatchRequestDtoAllOfFileIds> folderIds = default, List<BatchRequestDtoAllOfFileIds> fileIds = default, Guid userId = default)
        {
            this.UserId = userId;
            this.FolderIds = folderIds;
            this.FileIds = fileIds;
        }

        /// <summary>
        /// The rooms to hand over, identified as &#x60;GET api/2.0/files/rooms&#x60; returns them - a number for a room stored on  the portal and a string for one that lives on a connected third-party account. Only rooms belong here; a  folder inside a room is refused.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "folderIds", EmitDefaultValue = true)]
        public List<BatchRequestDtoAllOfFileIds> FolderIds { get; set; }

        /// <summary>
        /// The files to hand over, identified as a listing operation returns them - a number for a file stored on the  portal and a string for one on a connected third-party account. Only a file kept in the portal&#39;s common  section is accepted.
        /// </summary>
        /// <example>[7,8]</example>
        [DataMember(Name = "fileIds", EmitDefaultValue = true)]
        public List<BatchRequestDtoAllOfFileIds> FileIds { get; set; }

        /// <summary>
        /// The account that becomes the owner of every listed entry. It has to be an active member allowed to manage  rooms, so a deactivated account, a guest or a plain member is rejected, and for a private room the account  must have set up its encryption keys beforehand.
        /// </summary>
        /// <example>9924256a-739c-462b-af15-e652a3b1b6eb</example>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeOwnerRequestDto {\n");
            sb.Append("  FolderIds: ").Append(FolderIds).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
