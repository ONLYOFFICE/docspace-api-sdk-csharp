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
    /// The file draft parameters.
    /// </summary>
    [DataContract(Name = "DraftLocationInteger")]
    public partial class DraftLocationInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftLocationInteger" /> class.
        /// </summary>
        /// <param name="folderId">The InProcess folder ID of the draft..</param>
        /// <param name="folderTitle">The InProcess folder title of the draft..</param>
        /// <param name="fileId">The draft ID..</param>
        /// <param name="fileTitle">The draft title..</param>
        public DraftLocationInteger(int folderId = default, string folderTitle = default, int fileId = default, string fileTitle = default)
        {
            this.FolderId = folderId;
            this.FolderTitle = folderTitle;
            this.FileId = fileId;
            this.FileTitle = fileTitle;
        }

        /// <summary>
        /// The InProcess folder ID of the draft.
        /// </summary>
        /// <value>The InProcess folder ID of the draft.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public int FolderId { get; set; }

        /// <summary>
        /// The InProcess folder title of the draft.
        /// </summary>
        /// <value>The InProcess folder title of the draft.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "folderTitle", EmitDefaultValue = true)]
        public string FolderTitle { get; set; }

        /// <summary>
        /// The draft ID.
        /// </summary>
        /// <value>The draft ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public int FileId { get; set; }

        /// <summary>
        /// The draft title.
        /// </summary>
        /// <value>The draft title.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileTitle", EmitDefaultValue = true)]
        public string FileTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DraftLocationInteger {\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  FolderTitle: ").Append(FolderTitle).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  FileTitle: ").Append(FileTitle).Append("\n");
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
