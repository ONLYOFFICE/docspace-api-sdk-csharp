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
    /// The body of a spreadsheet reference request: the source spreadsheet, and the three ways of naming the document it  refers to, which are tried in the order they are described.
    /// </summary>
    [DataContract(Name = "GetReferenceDataDto")]
    public partial class GetReferenceDataDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReferenceDataDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetReferenceDataDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReferenceDataDto" /> class.
        /// </summary>
        /// <param name="fileKey">The id of the referenced file as the document service recorded it in the formula. It is tried first, and only  when &#x60;instanceId&#x60; names this portal. (required).</param>
        /// <param name="instanceId">The portal the reference was made on, as the document service recorded it. Only the id of this portal makes  the file key resolvable; any other value falls through to the path and the link. (required).</param>
        /// <param name="sourceFileId">The spreadsheet the formula sits in. The path is resolved against it - the referenced file is looked for among  the files lying next to it - and it is the file whose read access is checked..</param>
        /// <param name="path">The title of the referenced file exactly as the formula spells it, matched against the files lying next to the  source file. It is tried after the file key, and only when no link is given..</param>
        /// <param name="link">The web address the formula points at, an editor link of this portal or one of its short links. It is tried  last, and an address belonging to another site is not resolved at all but handed back for the client to follow  as it is..</param>
        public GetReferenceDataDto(string fileKey = default, string instanceId = default, int sourceFileId = default, string path = default, string link = default)
        {
            // to ensure "fileKey" is required (not null)
            if (fileKey == null)
            {
                throw new ArgumentNullException("fileKey is a required property for GetReferenceDataDto and cannot be null");
            }
            this.FileKey = fileKey;
            // to ensure "instanceId" is required (not null)
            if (instanceId == null)
            {
                throw new ArgumentNullException("instanceId is a required property for GetReferenceDataDto and cannot be null");
            }
            this.InstanceId = instanceId;
            this.SourceFileId = sourceFileId;
            this.Path = path;
            this.Link = link;
        }

        /// <summary>
        /// The id of the referenced file as the document service recorded it in the formula. It is tried first, and only  when &#x60;instanceId&#x60; names this portal.
        /// </summary>
        /// <example>512</example>
        [DataMember(Name = "fileKey", IsRequired = true, EmitDefaultValue = true)]
        public string FileKey { get; set; }

        /// <summary>
        /// The portal the reference was made on, as the document service recorded it. Only the id of this portal makes  the file key resolvable; any other value falls through to the path and the link.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "instanceId", IsRequired = true, EmitDefaultValue = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The spreadsheet the formula sits in. The path is resolved against it - the referenced file is looked for among  the files lying next to it - and it is the file whose read access is checked.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "sourceFileId", EmitDefaultValue = false)]
        public int SourceFileId { get; set; }

        /// <summary>
        /// The title of the referenced file exactly as the formula spells it, matched against the files lying next to the  source file. It is tried after the file key, and only when no link is given.
        /// </summary>
        /// <example>Budget 2026.xlsx</example>
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// The web address the formula points at, an editor link of this portal or one of its short links. It is tried  last, and an address belonging to another site is not resolved at all but handed back for the client to follow  as it is.
        /// </summary>
        /// <example>https://portal.example.com/doc/512</example>
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetReferenceDataDto {\n");
            sb.Append("  FileKey: ").Append(FileKey).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  SourceFileId: ").Append(SourceFileId).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
