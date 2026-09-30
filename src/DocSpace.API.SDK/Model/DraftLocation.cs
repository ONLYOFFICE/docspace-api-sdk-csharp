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
    /// Where the caller&#39;s own filling draft of a form is kept.
    /// </summary>
    [DataContract(Name = "DraftLocation")]
    public partial class DraftLocation : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftLocation" /> class.
        /// </summary>
        /// <param name="folderId">The folder holding the draft: the sub-folder that the room for filling keeps for drafts of this particular  form..</param>
        /// <param name="folderTitle">The title of that folder, which the portal takes from the form itself when the form is released for filling..</param>
        /// <param name="fileId">The draft itself - the copy the caller fills in, not the original form, and the identifier to pass to the file  operations while filling..</param>
        /// <param name="fileTitle">The title of the draft, which the portal builds from the name of the person filling it and the name of the  form. Null when the draft the record points at no longer exists..</param>
        public DraftLocation(int folderId = default, string folderTitle = default, int fileId = default, string fileTitle = default)
        {
            this.FolderId = folderId;
            this.FolderTitle = folderTitle;
            this.FileId = fileId;
            this.FileTitle = fileTitle;
        }

        /// <summary>
        /// The folder holding the draft: the sub-folder that the room for filling keeps for drafts of this particular  form.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public int FolderId { get; set; }

        /// <summary>
        /// The title of that folder, which the portal takes from the form itself when the form is released for filling.
        /// </summary>
        /// <example>Application</example>
        [DataMember(Name = "folderTitle", EmitDefaultValue = true)]
        public string FolderTitle { get; set; }

        /// <summary>
        /// The draft itself - the copy the caller fills in, not the original form, and the identifier to pass to the file  operations while filling.
        /// </summary>
        /// <example>123</example>
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public int FileId { get; set; }

        /// <summary>
        /// The title of the draft, which the portal builds from the name of the person filling it and the name of the  form. Null when the draft the record points at no longer exists.
        /// </summary>
        /// <example>John Doe - Application.pdf</example>
        [DataMember(Name = "fileTitle", EmitDefaultValue = true)]
        public string FileTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DraftLocation {\n");
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
