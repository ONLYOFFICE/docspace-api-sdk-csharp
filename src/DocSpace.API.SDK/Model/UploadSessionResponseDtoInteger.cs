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
    /// How far a chunked upload has got, and the file it produced once the last byte has arrived.
    /// </summary>
    [DataContract(Name = "UploadSessionResponseDtoInteger")]
    public partial class UploadSessionResponseDtoInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadSessionResponseDtoInteger" /> class.
        /// </summary>
        /// <param name="id">The file the parts are being written into. An upload that took over a file of the same title carries it from  the start, while an upload that creates a new file has nothing to name yet and reports 0 until the answer that  sets &#x60;uploaded&#x60; to true..</param>
        /// <param name="folderId">The folder receiving the file. It is the folder the upload was reserved against, or the sub-folder created for  it when the reservation declared a relative path..</param>
        /// <param name="version">The revision the content is being written as: 1 for a file that did not exist, the next number when the upload  took over a file of the same title, and the unchanged current number for an upload opened over an existing  file, which replaces its content in place..</param>
        /// <param name="title">The title the file is stored under, after characters a title cannot hold were replaced and, where a second  copy was asked for, a numeric suffix was added - so it can differ from the name that was sent..</param>
        /// <param name="providerKey">The third-party service holding the destination, such as &#x60;GoogleDrive&#x60; or &#x60;OneDrive&#x60;, and null for a folder  stored on the portal itself..</param>
        /// <param name="uploaded">False while bytes are still missing, when the answer only reports progress; true in the answer that reports  the stored file, which is also the answer that arrives with 201..</param>
        /// <param name="file">The file as it stands. It is filled in both answers, but while &#x60;uploaded&#x60; is false it describes a file that  has not been written yet, so its identifier, size and links are only worth reading once that flag turns true..</param>
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
        /// The file the parts are being written into. An upload that took over a file of the same title carries it from  the start, while an upload that creates a new file has nothing to name yet and reports 0 until the answer that  sets &#x60;uploaded&#x60; to true.
        /// </summary>
        /// <example>1234</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The folder receiving the file. It is the folder the upload was reserved against, or the sub-folder created for  it when the reservation declared a relative path.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public int FolderId { get; set; }

        /// <summary>
        /// The revision the content is being written as: 1 for a file that did not exist, the next number when the upload  took over a file of the same title, and the unchanged current number for an upload opened over an existing  file, which replaces its content in place.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// The title the file is stored under, after characters a title cannot hold were replaced and, where a second  copy was asked for, a numeric suffix was added - so it can differ from the name that was sent.
        /// </summary>
        /// <example>Quarterly report.docx</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The third-party service holding the destination, such as &#x60;GoogleDrive&#x60; or &#x60;OneDrive&#x60;, and null for a folder  stored on the portal itself.
        /// </summary>
        /// <example>GoogleDrive</example>
        [DataMember(Name = "providerKey", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// False while bytes are still missing, when the answer only reports progress; true in the answer that reports  the stored file, which is also the answer that arrives with 201.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "uploaded", EmitDefaultValue = true)]
        public bool Uploaded { get; set; }

        /// <summary>
        /// The file as it stands. It is filled in both answers, but while &#x60;uploaded&#x60; is false it describes a file that  has not been written yet, so its identifier, size and links are only worth reading once that flag turns true.
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
