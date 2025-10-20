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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The security information request parameters.
    /// </summary>
    [DataContract(Name = "SecurityInfoRequestDto")]
    public partial class SecurityInfoRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityInfoRequestDto" /> class.
        /// </summary>
        /// <param name="folderIds">The list of the shared folder IDs..</param>
        /// <param name="fileIds">The list of the shared file IDs..</param>
        /// <param name="share">The collection of sharing parameters..</param>
        /// <param name="notify">Specifies whether to notify users about the shared file or not..</param>
        /// <param name="sharingMessage">The message to send when notifying about the shared file..</param>
        public SecurityInfoRequestDto(List<DuplicateRequestDtoAllOfFileIds> folderIds = default, List<DuplicateRequestDtoAllOfFileIds> fileIds = default, List<FileShareParams> share = default, bool notify = default, string sharingMessage = default)
        {
            this.FolderIds = folderIds;
            this.FileIds = fileIds;
            this.Share = share;
            this.Notify = notify;
            this.SharingMessage = sharingMessage;
        }

        /// <summary>
        /// The list of the shared folder IDs.
        /// </summary>
        /// <value>The list of the shared folder IDs.</value>
        [DataMember(Name = "folderIds", EmitDefaultValue = true)]
        public List<DuplicateRequestDtoAllOfFileIds> FolderIds { get; set; }

        /// <summary>
        /// The list of the shared file IDs.
        /// </summary>
        /// <value>The list of the shared file IDs.</value>
        [DataMember(Name = "fileIds", EmitDefaultValue = true)]
        public List<DuplicateRequestDtoAllOfFileIds> FileIds { get; set; }

        /// <summary>
        /// The collection of sharing parameters.
        /// </summary>
        /// <value>The collection of sharing parameters.</value>
        [DataMember(Name = "share", EmitDefaultValue = true)]
        public List<FileShareParams> Share { get; set; }

        /// <summary>
        /// Specifies whether to notify users about the shared file or not.
        /// </summary>
        /// <value>Specifies whether to notify users about the shared file or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "notify", EmitDefaultValue = true)]
        public bool Notify { get; set; }

        /// <summary>
        /// The message to send when notifying about the shared file.
        /// </summary>
        /// <value>The message to send when notifying about the shared file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "sharingMessage", EmitDefaultValue = true)]
        public string SharingMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityInfoRequestDto {\n");
            sb.Append("  FolderIds: ").Append(FolderIds).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  SharingMessage: ").Append(SharingMessage).Append("\n");
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
