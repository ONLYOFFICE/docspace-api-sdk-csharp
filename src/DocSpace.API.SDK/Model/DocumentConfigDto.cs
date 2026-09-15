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
    /// The document itself as the editors address it: what to fetch, under which revision key, and what this caller may  do with it.
    /// </summary>
    [DataContract(Name = "DocumentConfigDto")]
    public partial class DocumentConfigDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConfigDto" /> class.
        /// </summary>
        /// <param name="fileType">The format the editors treat the content as, without the leading dot. For a file that had to be converted this  is the format it was converted to, not the one it is stored under..</param>
        /// <param name="info">The facts the editor information panel shows about the document..</param>
        /// <param name="isLinkedForMe">Whether the caller opened the original document rather than a link pointing at it, which matters only for  formats whose editing is restricted through links..</param>
        /// <param name="key">Identifies the exact revision to the editors: everyone who receives the same key joins the same co-editing  session, and the key changes as soon as the document is saved..</param>
        /// <param name="permissions">What this caller may do inside the editor - edit, comment, review, fill, download, print, copy and chat..</param>
        /// <param name="sharedLinkParam">The name of the query parameter that carries the external share key. It is set only when the document was  opened through an external link..</param>
        /// <param name="sharedLinkKey">The external share key this opening runs under, empty when the caller opened the document as a portal member.  The editors pass it back on every request they make for the document..</param>
        /// <param name="referenceData">How another spreadsheet names this document in a formula. Pass it to &#x60;POST api/2.0/files/file/referencedata&#x60;  to resolve such a reference..</param>
        /// <param name="title">The name the editors display. When a past version was opened, the moment that version was created is appended  to it in brackets..</param>
        /// <param name="url">Where the editors fetch the content. It is addressed to the host the document service can reach, which is not  necessarily the address a browser should follow..</param>
        /// <param name="isForm">Whether the document is a fillable PDF form. A PDF that the portal has never classified is inspected while the  configuration is built, so the answer is trustworthy even for a freshly uploaded file..</param>
        /// <param name="options">Extra instructions for the editors, currently the watermark to draw over the document. It is empty when the  room sets no watermark..</param>
        public DocumentConfigDto(string fileType = default, InfoConfigDto info = default, bool isLinkedForMe = default, string key = default, PermissionsConfig permissions = default, string sharedLinkParam = default, string sharedLinkKey = default, FileReferenceData referenceData = default, string title = default, string url = default, bool isForm = default, Options options = default)
        {
            this.FileType = fileType;
            this.Info = info;
            this.IsLinkedForMe = isLinkedForMe;
            this.Key = key;
            this.Permissions = permissions;
            this.SharedLinkParam = sharedLinkParam;
            this.SharedLinkKey = sharedLinkKey;
            this.ReferenceData = referenceData;
            this.Title = title;
            this.Url = url;
            this.IsForm = isForm;
            this.Options = options;
        }

        /// <summary>
        /// The format the editors treat the content as, without the leading dot. For a file that had to be converted this  is the format it was converted to, not the one it is stored under.
        /// </summary>
        /// <example>docx</example>
        [DataMember(Name = "fileType", EmitDefaultValue = true)]
        public string FileType { get; set; }

        /// <summary>
        /// The facts the editor information panel shows about the document.
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public InfoConfigDto Info { get; set; }

        /// <summary>
        /// Whether the caller opened the original document rather than a link pointing at it, which matters only for  formats whose editing is restricted through links.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isLinkedForMe", EmitDefaultValue = true)]
        public bool IsLinkedForMe { get; set; }

        /// <summary>
        /// Identifies the exact revision to the editors: everyone who receives the same key joins the same co-editing  session, and the key changes as soon as the document is saved.
        /// </summary>
        /// <example>1_512_3</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// What this caller may do inside the editor - edit, comment, review, fill, download, print, copy and chat.
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public PermissionsConfig Permissions { get; set; }

        /// <summary>
        /// The name of the query parameter that carries the external share key. It is set only when the document was  opened through an external link.
        /// </summary>
        /// <example>share</example>
        [DataMember(Name = "sharedLinkParam", EmitDefaultValue = true)]
        public string SharedLinkParam { get; set; }

        /// <summary>
        /// The external share key this opening runs under, empty when the caller opened the document as a portal member.  The editors pass it back on every request they make for the document.
        /// </summary>
        /// <example>HkQd9nT2</example>
        [DataMember(Name = "sharedLinkKey", EmitDefaultValue = true)]
        public string SharedLinkKey { get; set; }

        /// <summary>
        /// How another spreadsheet names this document in a formula. Pass it to &#x60;POST api/2.0/files/file/referencedata&#x60;  to resolve such a reference.
        /// </summary>
        [DataMember(Name = "referenceData", EmitDefaultValue = false)]
        public FileReferenceData ReferenceData { get; set; }

        /// <summary>
        /// The name the editors display. When a past version was opened, the moment that version was created is appended  to it in brackets.
        /// </summary>
        /// <example>Budget 2026.xlsx</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Where the editors fetch the content. It is addressed to the host the document service can reach, which is not  necessarily the address a browser should follow.
        /// </summary>
        /// <example>https://portal.example.com/filehandler.ashx?action=download&amp;fileid=512</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Whether the document is a fillable PDF form. A PDF that the portal has never classified is inspected while the  configuration is built, so the answer is trustworthy even for a freshly uploaded file.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isForm", EmitDefaultValue = true)]
        public bool IsForm { get; set; }

        /// <summary>
        /// Extra instructions for the editors, currently the watermark to draw over the document. It is empty when the  room sets no watermark.
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public Options Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentConfigDto {\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  IsLinkedForMe: ").Append(IsLinkedForMe).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  SharedLinkParam: ").Append(SharedLinkParam).Append("\n");
            sb.Append("  SharedLinkKey: ").Append(SharedLinkKey).Append("\n");
            sb.Append("  ReferenceData: ").Append(ReferenceData).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IsForm: ").Append(IsForm).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
