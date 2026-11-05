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
    /// One user who cannot open some encrypted files of a private room yet.
    /// </summary>
    [DataContract(Name = "RoomMissingFileKeysDto")]
    public partial class RoomMissingFileKeysDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMissingFileKeysDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomMissingFileKeysDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMissingFileKeysDto" /> class.
        /// </summary>
        /// <param name="userId">The user the keys are missing for. (required).</param>
        /// <param name="fileIds">The encrypted files that hold no key for this user, anywhere in the room. Never empty: a user who has every key  is not listed at all. (required).</param>
        public RoomMissingFileKeysDto(Guid userId = default, List<int> fileIds = default)
        {
            this.UserId = userId;
            // to ensure "fileIds" is required (not null)
            if (fileIds == null)
            {
                throw new ArgumentNullException("fileIds is a required property for RoomMissingFileKeysDto and cannot be null");
            }
            this.FileIds = fileIds;
        }

        /// <summary>
        /// The user the keys are missing for.
        /// </summary>
        /// <example>9924256B-447C-4F19-9dbd-8ad8c39e8ff5</example>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The encrypted files that hold no key for this user, anywhere in the room. Never empty: a user who has every key  is not listed at all.
        /// </summary>
        /// <example>[1234,1235]</example>
        [DataMember(Name = "fileIds", IsRequired = true, EmitDefaultValue = true)]
        public List<int> FileIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomMissingFileKeysDto {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
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
