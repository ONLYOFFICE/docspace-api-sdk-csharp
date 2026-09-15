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
    /// Everything an editor needs in order to show what one revision of a file changed.
    /// </summary>
    [DataContract(Name = "EditHistoryDataDto")]
    public partial class EditHistoryDataDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryDataDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EditHistoryDataDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryDataDto" /> class.
        /// </summary>
        /// <param name="changesUrl">The address the editor downloads the recorded changes of this revision from. It is filled in only when the  portal has a change record for the revision; without it the revision can be shown as a whole document but not  as a set of changes..</param>
        /// <param name="key">The document key of the revision being shown, which the editing service uses to identify it and to reuse the  copy it has cached. (required).</param>
        /// <param name="previous">The revision this one is compared against. It arrives together with &#x60;changesUrl&#x60;, and when the revision shown  is the first one the file ever had, it points at the blank template the file was created from instead of at an  earlier revision..</param>
        /// <param name="token">The signature over the whole answer, as a JSON Web Token that the editing service verifies before it accepts  the addresses in it. Empty when the portal runs without a document-service secret..</param>
        /// <param name="url">The address the content of this revision is served from. It is meant for the editing service and carries its  own key, which is valid for a limited time. (required).</param>
        /// <param name="version">Echoes the revision that was asked for, so it reports 0 when the request named no version and the current  revision was taken. (required).</param>
        /// <param name="fileType">The format of the revision being shown, as an extension without the leading dot. (required).</param>
        public EditHistoryDataDto(string changesUrl = default, string key = default, EditHistoryUrl previous = default, string token = default, string url = default, int version = default, string fileType = default)
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for EditHistoryDataDto and cannot be null");
            }
            this.Key = key;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for EditHistoryDataDto and cannot be null");
            }
            this.Url = url;
            this.@Version = version;
            // to ensure "fileType" is required (not null)
            if (fileType == null)
            {
                throw new ArgumentNullException("fileType is a required property for EditHistoryDataDto and cannot be null");
            }
            this.FileType = fileType;
            this.ChangesUrl = changesUrl;
            this.Previous = previous;
            this.Token = token;
        }

        /// <summary>
        /// The address the editor downloads the recorded changes of this revision from. It is filled in only when the  portal has a change record for the revision; without it the revision can be shown as a whole document but not  as a set of changes.
        /// </summary>
        /// <example>https://example.com/changes</example>
        [DataMember(Name = "changesUrl", EmitDefaultValue = true)]
        public string ChangesUrl { get; set; }

        /// <summary>
        /// The document key of the revision being shown, which the editing service uses to identify it and to reuse the  copy it has cached.
        /// </summary>
        /// <example>doc1</example>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The revision this one is compared against. It arrives together with &#x60;changesUrl&#x60;, and when the revision shown  is the first one the file ever had, it points at the blank template the file was created from instead of at an  earlier revision.
        /// </summary>
        [DataMember(Name = "previous", EmitDefaultValue = false)]
        public EditHistoryUrl Previous { get; set; }

        /// <summary>
        /// The signature over the whole answer, as a JSON Web Token that the editing service verifies before it accepts  the addresses in it. Empty when the portal runs without a document-service secret.
        /// </summary>
        /// <example>eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ2ZXJzaW9uIjoxfQ.7HxQ0Zx1</example>
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// The address the content of this revision is served from. It is meant for the editing service and carries its  own key, which is valid for a limited time.
        /// </summary>
        /// <example>https://example.com/file.docx</example>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Echoes the revision that was asked for, so it reports 0 when the request named no version and the current  revision was taken.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int @Version { get; set; }

        /// <summary>
        /// The format of the revision being shown, as an extension without the leading dot.
        /// </summary>
        /// <example>docx</example>
        [DataMember(Name = "fileType", IsRequired = true, EmitDefaultValue = true)]
        public string FileType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditHistoryDataDto {\n");
            sb.Append("  ChangesUrl: ").Append(ChangesUrl).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
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
