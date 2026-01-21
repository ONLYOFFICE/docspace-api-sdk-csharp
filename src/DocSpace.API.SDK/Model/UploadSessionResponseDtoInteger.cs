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
    /// UploadSessionResponseDtoInteger
    /// </summary>
    [DataContract(Name = "UploadSessionResponseDtoInteger")]
    public partial class UploadSessionResponseDtoInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadSessionResponseDtoInteger" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="folderId">folderId.</param>
        /// <param name="version">version.</param>
        /// <param name="title">title.</param>
        /// <param name="providerKey">providerKey.</param>
        /// <param name="uploaded">uploaded.</param>
        /// <param name="file">file.</param>
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
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets FolderId
        /// </summary>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public int FolderId { get; set; }

        /// <summary>
        /// Gets or Sets @Version
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ProviderKey
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "providerKey", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// Gets or Sets Uploaded
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "uploaded", EmitDefaultValue = true)]
        public bool Uploaded { get; set; }

        /// <summary>
        /// Gets or Sets File
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
