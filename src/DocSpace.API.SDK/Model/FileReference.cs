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
    /// The file reference parameters.
    /// </summary>
    [DataContract(Name = "FileReference")]
    public partial class FileReference : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileReference" /> class.
        /// </summary>
        /// <param name="referenceData">How this document is named when another spreadsheet refers to it. Send it back as it stands to resolve the  reference again..</param>
        /// <param name="error">Filled in when the reference resolved to nothing; the rest of the descriptor is then empty and must not be  handed to the editors..</param>
        /// <param name="path">The title of the document the reference resolved to..</param>
        /// <param name="url">Where the content is fetched from. It is addressed to the host the document service can reach, which on a  deployment with a private editor network is not the address a browser should follow..</param>
        /// <param name="fileType">The format the content is in, without the leading dot..</param>
        /// <param name="key">Identifies the exact revision to the editors: two clients that receive the same key read the same co-editing  session, and the key changes as soon as the document is saved..</param>
        /// <param name="link">The address of the document in the portal web editor - the link to put in front of a person, unlike the  download address above..</param>
        /// <param name="token">Signs this descriptor so that the editors can trust it. It stays empty on a portal that has no signature  secret configured for the document service..</param>
        public FileReference(FileReferenceData referenceData = default, string error = default, string path = default, string url = default, string fileType = default, string key = default, string link = default, string token = default)
        {
            this.ReferenceData = referenceData;
            this.Error = error;
            this.Path = path;
            this.Url = url;
            this.FileType = fileType;
            this.Key = key;
            this.Link = link;
            this.Token = token;
        }

        /// <summary>
        /// How this document is named when another spreadsheet refers to it. Send it back as it stands to resolve the  reference again.
        /// </summary>
        [DataMember(Name = "referenceData", EmitDefaultValue = false)]
        public FileReferenceData ReferenceData { get; set; }

        /// <summary>
        /// Filled in when the reference resolved to nothing; the rest of the descriptor is then empty and must not be  handed to the editors.
        /// </summary>
        /// <example>File not found</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The title of the document the reference resolved to.
        /// </summary>
        /// <example>Budget 2026.xlsx</example>
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Where the content is fetched from. It is addressed to the host the document service can reach, which on a  deployment with a private editor network is not the address a browser should follow.
        /// </summary>
        /// <example>https://portal.example.com/filehandler.ashx?action=download&amp;fileid=512</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The format the content is in, without the leading dot.
        /// </summary>
        /// <example>xlsx</example>
        [DataMember(Name = "fileType", EmitDefaultValue = true)]
        public string FileType { get; set; }

        /// <summary>
        /// Identifies the exact revision to the editors: two clients that receive the same key read the same co-editing  session, and the key changes as soon as the document is saved.
        /// </summary>
        /// <example>1_512_3</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The address of the document in the portal web editor - the link to put in front of a person, unlike the  download address above.
        /// </summary>
        /// <example>https://portal.example.com/doceditor?fileid=512</example>
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// Signs this descriptor so that the editors can trust it. It stays empty on a portal that has no signature  secret configured for the document service.
        /// </summary>
        /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...</example>
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileReference {\n");
            sb.Append("  ReferenceData: ").Append(ReferenceData).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
