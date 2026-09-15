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
    /// The address, document key and format of the revision a comparison is made against.
    /// </summary>
    [DataContract(Name = "EditHistoryUrl")]
    public partial class EditHistoryUrl : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryUrl" /> class.
        /// </summary>
        /// <param name="key">The document key of that revision. When the file has no earlier revision the portal generates a fresh key for  the template it falls back to, so the value is not always one an earlier revision ever had..</param>
        /// <param name="url">The address that revision&#39;s content is served from. It is meant for the editing service and carries its own  key, which is valid for a limited time..</param>
        /// <param name="fileType">The format of that revision, as an extension without the leading dot..</param>
        public EditHistoryUrl(string key = default, string url = default, string fileType = default)
        {
            this.Key = key;
            this.Url = url;
            this.FileType = fileType;
        }

        /// <summary>
        /// The document key of that revision. When the file has no earlier revision the portal generates a fresh key for  the template it falls back to, so the value is not always one an earlier revision ever had.
        /// </summary>
        /// <example>doc_v2_20260101</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The address that revision&#39;s content is served from. It is meant for the editing service and carries its own  key, which is valid for a limited time.
        /// </summary>
        /// <example>https://files.example.com/history/doc_v2_20260101.docx</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The format of that revision, as an extension without the leading dot.
        /// </summary>
        /// <example>docx</example>
        [DataMember(Name = "fileType", EmitDefaultValue = true)]
        public string FileType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditHistoryUrl {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
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
