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
    /// The parameters of the migrating files.
    /// </summary>
    [DataContract(Name = "MigratingApiFiles")]
    public partial class MigratingApiFiles : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MigratingApiFiles" /> class.
        /// </summary>
        /// <param name="foldersCount">The number of folders..</param>
        /// <param name="filesCount">The number of files..</param>
        /// <param name="bytesTotal">The total number of bytes..</param>
        public MigratingApiFiles(int foldersCount = default, int filesCount = default, long bytesTotal = default)
        {
            this.FoldersCount = foldersCount;
            this.FilesCount = filesCount;
            this.BytesTotal = bytesTotal;
        }

        /// <summary>
        /// The number of folders.
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "foldersCount", EmitDefaultValue = false)]
        public int FoldersCount { get; set; }

        /// <summary>
        /// The number of files.
        /// </summary>
        /// <example>48</example>
        [DataMember(Name = "filesCount", EmitDefaultValue = false)]
        public int FilesCount { get; set; }

        /// <summary>
        /// The total number of bytes.
        /// </summary>
        /// <example>104857600</example>
        [DataMember(Name = "bytesTotal", EmitDefaultValue = false)]
        public long BytesTotal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigratingApiFiles {\n");
            sb.Append("  FoldersCount: ").Append(FoldersCount).Append("\n");
            sb.Append("  FilesCount: ").Append(FilesCount).Append("\n");
            sb.Append("  BytesTotal: ").Append(BytesTotal).Append("\n");
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
