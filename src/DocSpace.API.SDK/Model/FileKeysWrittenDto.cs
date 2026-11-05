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
    /// The outcome of issuing file keys.
    /// </summary>
    [DataContract(Name = "FileKeysWrittenDto")]
    public partial class FileKeysWrittenDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileKeysWrittenDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileKeysWrittenDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileKeysWrittenDto" /> class.
        /// </summary>
        /// <param name="skippedUserIds">The recipients whose key was not stored, because they can no longer read the file. Empty when every key was  stored. (required).</param>
        public FileKeysWrittenDto(List<Guid> skippedUserIds = default)
        {
            // to ensure "skippedUserIds" is required (not null)
            if (skippedUserIds == null)
            {
                throw new ArgumentNullException("skippedUserIds is a required property for FileKeysWrittenDto and cannot be null");
            }
            this.SkippedUserIds = skippedUserIds;
        }

        /// <summary>
        /// The recipients whose key was not stored, because they can no longer read the file. Empty when every key was  stored.
        /// </summary>
        /// <example>["9924256B-447C-4F19-9dbd-8ad8c39e8ff5"]</example>
        [DataMember(Name = "skippedUserIds", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> SkippedUserIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileKeysWrittenDto {\n");
            sb.Append("  SkippedUserIds: ").Append(SkippedUserIds).Append("\n");
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
