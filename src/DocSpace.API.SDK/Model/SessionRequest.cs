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
    /// The file a chunked upload session is opened for, and how a clash with an existing name is settled.
    /// </summary>
    [DataContract(Name = "SessionRequest")]
    public partial class SessionRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequest" /> class.
        /// </summary>
        /// <param name="fileName">The name to store the file under, extension included. Characters a title cannot hold are replaced and the name  is truncated, so the stored title can differ from the one sent. (required).</param>
        /// <param name="fileSize">The exact number of bytes that will be sent. The size is reserved when the session opens and compared with the  parts as they arrive; below the portal chunk size the session takes the whole payload in one part, and above  the portal limit for chunked uploads it is refused..</param>
        /// <param name="relativePath">A slash-separated chain of folder titles under the target folder to store the file in; folders in the chain  that do not exist yet are created. Leave it empty to store the file in the folder from the path itself..</param>
        /// <param name="createOn">The creation time to stamp on a newly created file instead of the moment the upload finishes. It is ignored  when the upload lands on a file that already exists..</param>
        /// <param name="encrypted">Marks the stored file as client-side encrypted, which is how content uploaded into a private room is kept;  with false the bytes are stored as they arrive..</param>
        /// <param name="createNewIfExist">Settles the clash when the folder already holds a file with this name: true stores the upload beside it under  a name with a numeric suffix, false takes the existing file over and adds the content to it as a new version..</param>
        public SessionRequest(string fileName = default, long fileSize = default, string relativePath = default, ApiDateTime createOn = default, bool encrypted = default, bool createNewIfExist = default)
        {
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName is a required property for SessionRequest and cannot be null");
            }
            this.FileName = fileName;
            this.FileSize = fileSize;
            this.RelativePath = relativePath;
            this.CreateOn = createOn;
            this.Encrypted = encrypted;
            this.CreateNewIfExist = createNewIfExist;
        }

        /// <summary>
        /// The name to store the file under, extension included. Characters a title cannot hold are replaced and the name  is truncated, so the stored title can differ from the one sent.
        /// </summary>
        /// <example>My Document.docx</example>
        [DataMember(Name = "fileName", IsRequired = true, EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// The exact number of bytes that will be sent. The size is reserved when the session opens and compared with the  parts as they arrive; below the portal chunk size the session takes the whole payload in one part, and above  the portal limit for chunked uploads it is refused.
        /// </summary>
        /// <example>10485760</example>
        [DataMember(Name = "fileSize", EmitDefaultValue = false)]
        public long FileSize { get; set; }

        /// <summary>
        /// A slash-separated chain of folder titles under the target folder to store the file in; folders in the chain  that do not exist yet are created. Leave it empty to store the file in the folder from the path itself.
        /// </summary>
        /// <example>subfolder/documents</example>
        [DataMember(Name = "relativePath", EmitDefaultValue = true)]
        public string RelativePath { get; set; }

        /// <summary>
        /// The creation time to stamp on a newly created file instead of the moment the upload finishes. It is ignored  when the upload lands on a file that already exists.
        /// </summary>
        [DataMember(Name = "createOn", EmitDefaultValue = false)]
        public ApiDateTime CreateOn { get; set; }

        /// <summary>
        /// Marks the stored file as client-side encrypted, which is how content uploaded into a private room is kept;  with false the bytes are stored as they arrive.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "encrypted", EmitDefaultValue = true)]
        public bool Encrypted { get; set; }

        /// <summary>
        /// Settles the clash when the folder already holds a file with this name: true stores the upload beside it under  a name with a numeric suffix, false takes the existing file over and adds the content to it as a new version.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "createNewIfExist", EmitDefaultValue = true)]
        public bool CreateNewIfExist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionRequest {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  RelativePath: ").Append(RelativePath).Append("\n");
            sb.Append("  CreateOn: ").Append(CreateOn).Append("\n");
            sb.Append("  Encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  CreateNewIfExist: ").Append(CreateNewIfExist).Append("\n");
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
