// (c) Copyright Ascensio System SIA 2025
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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The request parameters for uploading a file.
    /// </summary>
    [DataContract(Name = "UploadRequestDto")]
    public partial class UploadRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRequestDto" /> class.
        /// </summary>
        /// <param name="file">The file to be uploaded..</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="contentDisposition">contentDisposition.</param>
        /// <param name="files">The list of files when specified as multipart/form-data..</param>
        /// <param name="createNewIfExist">Specifies whether to create the new file if it already exists or not..</param>
        /// <param name="storeOriginalFileFlag">Specifies whether to upload documents in the original formats as well or not..</param>
        /// <param name="keepConvertStatus">Specifies whether to keep the file converting status or not..</param>
        /// <param name="stream">The request input stream..</param>
        public UploadRequestDto(FileParameter file = default, ContentType contentType = default, ContentDisposition contentDisposition = default, List<FileParameter> files = default, bool createNewIfExist = default, bool? storeOriginalFileFlag = default, bool keepConvertStatus = default, FileParameter stream = default)
        {
            this.File = file;
            this.ContentType = contentType;
            this.ContentDisposition = contentDisposition;
            this.Files = files;
            this.CreateNewIfExist = createNewIfExist;
            this.StoreOriginalFileFlag = storeOriginalFileFlag;
            this.KeepConvertStatus = keepConvertStatus;
            this.Stream = stream;
        }

        /// <summary>
        /// The file to be uploaded.
        /// </summary>
        /// <value>The file to be uploaded.</value>
        [DataMember(Name = "file", EmitDefaultValue = true)]
        public FileParameter File { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public ContentType ContentType { get; set; }

        /// <summary>
        /// Gets or Sets ContentDisposition
        /// </summary>
        [DataMember(Name = "contentDisposition", EmitDefaultValue = false)]
        public ContentDisposition ContentDisposition { get; set; }

        /// <summary>
        /// The list of files when specified as multipart/form-data.
        /// </summary>
        /// <value>The list of files when specified as multipart/form-data.</value>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<FileParameter> Files { get; set; }

        /// <summary>
        /// Specifies whether to create the new file if it already exists or not.
        /// </summary>
        /// <value>Specifies whether to create the new file if it already exists or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "createNewIfExist", EmitDefaultValue = true)]
        public bool CreateNewIfExist { get; set; }

        /// <summary>
        /// Specifies whether to upload documents in the original formats as well or not.
        /// </summary>
        /// <value>Specifies whether to upload documents in the original formats as well or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "storeOriginalFileFlag", EmitDefaultValue = true)]
        public bool? StoreOriginalFileFlag { get; set; }

        /// <summary>
        /// Specifies whether to keep the file converting status or not.
        /// </summary>
        /// <value>Specifies whether to keep the file converting status or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "keepConvertStatus", EmitDefaultValue = true)]
        public bool KeepConvertStatus { get; set; }

        /// <summary>
        /// The request input stream.
        /// </summary>
        /// <value>The request input stream.</value>
        [DataMember(Name = "stream", EmitDefaultValue = true)]
        public FileParameter Stream { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadRequestDto {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentDisposition: ").Append(ContentDisposition).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  CreateNewIfExist: ").Append(CreateNewIfExist).Append("\n");
            sb.Append("  StoreOriginalFileFlag: ").Append(StoreOriginalFileFlag).Append("\n");
            sb.Append("  KeepConvertStatus: ").Append(KeepConvertStatus).Append("\n");
            sb.Append("  Stream: ").Append(Stream).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
