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
    /// The request parameters for changing the file owner.
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
        /// <param name="folderIds">The list of folder IDs to change the owner..</param>
        /// <param name="fileIds">The list of file IDs to change the owner..</param>
        /// <param name="userId">The new file owner ID. (required).</param>
        public ChangeOwnerRequestDto(List<BatchRequestDtoAllOfFileIds> folderIds = default, List<BatchRequestDtoAllOfFileIds> fileIds = default, Guid userId = default)
        {
            this.UserId = userId;
            this.FolderIds = folderIds;
            this.FileIds = fileIds;
        }

        /// <summary>
        /// The list of folder IDs to change the owner.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "folderIds", EmitDefaultValue = true)]
        public List<BatchRequestDtoAllOfFileIds> FolderIds { get; set; }

        /// <summary>
        /// The list of file IDs to change the owner.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "fileIds", EmitDefaultValue = true)]
        public List<BatchRequestDtoAllOfFileIds> FileIds { get; set; }

        /// <summary>
        /// The new file owner ID.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
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
