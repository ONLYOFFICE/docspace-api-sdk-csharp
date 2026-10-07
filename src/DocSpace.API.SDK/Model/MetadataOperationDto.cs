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
    /// The cascade metadata assignment operation status.
    /// </summary>
    [DataContract(Name = "MetadataOperationDto")]
    public partial class MetadataOperationDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataOperationDto" /> class.
        /// </summary>
        /// <param name="id">The operation ID..</param>
        /// <param name="progress">The operation progress percentage..</param>
        /// <param name="isCompleted">Specifies if the operation is completed..</param>
        /// <param name="error">The operation error message..</param>
        public MetadataOperationDto(string id = default, double progress = default, bool isCompleted = default, string error = default)
        {
            this.Id = id;
            this.Progress = progress;
            this.IsCompleted = isCompleted;
            this.Error = error;
        }

        /// <summary>
        /// The operation ID.
        /// </summary>
        /// <example>a1f4c9b2-3d8e-4f77-9b16-2c5de8f0a913</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The operation progress percentage.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public double Progress { get; set; }

        /// <summary>
        /// Specifies if the operation is completed.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isCompleted", EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// The operation error message.
        /// </summary>
        /// <example>Folder not found.</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataOperationDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
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
