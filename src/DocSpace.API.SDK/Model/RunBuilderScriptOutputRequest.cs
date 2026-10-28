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
    /// Where one produced file goes.
    /// </summary>
    [DataContract(Name = "RunBuilderScriptOutputRequest")]
    public partial class RunBuilderScriptOutputRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RunBuilderScriptOutputRequest" /> class.
        /// </summary>
        /// <param name="fileId">The id of a portal file to store the result in as a new version, as reported by a folder listing such as  &#x60;GET api/2.0/files/{folderId}&#x60;..</param>
        /// <param name="folderId">The id of a folder to save the result in as a new file, as reported by a folder listing such as  &#x60;GET api/2.0/files/{folderId}&#x60;..</param>
        /// <param name="title">The title of the new file, when it has to differ from the name the script saved the result under..</param>
        public RunBuilderScriptOutputRequest(int? fileId = default, int? folderId = default, string title = default)
        {
            this.FileId = fileId;
            this.FolderId = folderId;
            this.Title = title;
        }

        /// <summary>
        /// The id of a portal file to store the result in as a new version, as reported by a folder listing such as  &#x60;GET api/2.0/files/{folderId}&#x60;.
        /// </summary>
        /// <example>1234</example>
        [DataMember(Name = "fileId", EmitDefaultValue = true)]
        public int? FileId { get; set; }

        /// <summary>
        /// The id of a folder to save the result in as a new file, as reported by a folder listing such as  &#x60;GET api/2.0/files/{folderId}&#x60;.
        /// </summary>
        /// <example>5678</example>
        [DataMember(Name = "folderId", EmitDefaultValue = true)]
        public int? FolderId { get; set; }

        /// <summary>
        /// The title of the new file, when it has to differ from the name the script saved the result under.
        /// </summary>
        /// <example>Quarterly report.pdf</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunBuilderScriptOutputRequest {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
