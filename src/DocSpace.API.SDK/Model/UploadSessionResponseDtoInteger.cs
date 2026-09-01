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
    /// The upload session response parameters.
    /// </summary>
    [DataContract(Name = "UploadSessionResponseDtoInteger")]
    public partial class UploadSessionResponseDtoInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadSessionResponseDtoInteger" /> class.
        /// </summary>
        /// <param name="id">The upload session ID..</param>
        /// <param name="folderId">The folder ID where the file is being uploaded..</param>
        /// <param name="version">The file version number..</param>
        /// <param name="title">The file title..</param>
        /// <param name="providerKey">The third-party provider key..</param>
        /// <param name="uploaded">Specifies whether the file has been uploaded..</param>
        /// <param name="file">The file parameters..</param>
        public UploadSessionResponseDtoInteger(int id = default, int folderId = default, int version = default, string title = default, string providerKey = default, bool uploaded = default, FileDtoInteger file = default)
        {
            this.Id = id;
            this.FolderId = folderId;
            this.@Version = version;
            this.Title = title;
            this.ProviderKey = providerKey;
            this.Uploaded = uploaded;
            this.File = file;
        }

        /// <summary>
        /// The upload session ID.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The folder ID where the file is being uploaded.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public int FolderId { get; set; }

        /// <summary>
        /// The file version number.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// The file title.
        /// </summary>
        /// <example>My Document.docx</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The third-party provider key.
        /// </summary>
        /// <example>Google</example>
        [DataMember(Name = "providerKey", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// Specifies whether the file has been uploaded.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "uploaded", EmitDefaultValue = true)]
        public bool Uploaded { get; set; }

        /// <summary>
        /// The file parameters.
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public FileDtoInteger File { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadSessionResponseDtoInteger {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ProviderKey: ").Append(ProviderKey).Append("\n");
            sb.Append("  Uploaded: ").Append(Uploaded).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
