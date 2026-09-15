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
    /// One single change inside a saved revision of a file.
    /// </summary>
    [DataContract(Name = "EditHistoryChangesWrapper")]
    public partial class EditHistoryChangesWrapper : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryChangesWrapper" /> class.
        /// </summary>
        /// <param name="user">The account that made this change, as the editing service reported it; an account it could not name is  reported as a guest..</param>
        /// <param name="created">When this change was made, written with the offset of the portal&#39;s time zone rather than as plain UTC..</param>
        /// <param name="documentSha256">The SHA-256 hash of the document as it stood after this change, where the editing service recorded one, so  that a client can check a stored copy against the change it claims to hold. Empty when the change record  carries no hash..</param>
        public EditHistoryChangesWrapper(EditHistoryAuthor user = default, ApiDateTime created = default, string documentSha256 = default)
        {
            this.User = user;
            this.Created = created;
            this.DocumentSha256 = documentSha256;
        }

        /// <summary>
        /// The account that made this change, as the editing service reported it; an account it could not name is  reported as a guest.
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public EditHistoryAuthor User { get; set; }

        /// <summary>
        /// When this change was made, written with the offset of the portal&#39;s time zone rather than as plain UTC.
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public ApiDateTime Created { get; set; }

        /// <summary>
        /// The SHA-256 hash of the document as it stood after this change, where the editing service recorded one, so  that a client can check a stored copy against the change it claims to hold. Empty when the change record  carries no hash.
        /// </summary>
        /// <example>9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08</example>
        [DataMember(Name = "documentSha256", EmitDefaultValue = true)]
        public string DocumentSha256 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditHistoryChangesWrapper {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DocumentSha256: ").Append(DocumentSha256).Append("\n");
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
