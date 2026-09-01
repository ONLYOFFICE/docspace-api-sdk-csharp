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
    /// The file editing history parameters.
    /// </summary>
    [DataContract(Name = "EditHistoryDto")]
    public partial class EditHistoryDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryDto" /> class.
        /// </summary>
        /// <param name="id">The document ID..</param>
        /// <param name="key">The document identifier used to unambiguously identify the document file..</param>
        /// <param name="version">The document version number..</param>
        /// <param name="versionGroup">The document version group..</param>
        /// <param name="user">The information about the file editing history author..</param>
        /// <param name="created">The API date and time parameters..</param>
        /// <param name="changesHistory">The file history changes in the string format..</param>
        /// <param name="changes">The list of file history changes..</param>
        /// <param name="serverVersion">The current server version number..</param>
        public EditHistoryDto(int id = default, string key = default, int version = default, int versionGroup = default, EditHistoryAuthor user = default, ApiDateTime created = default, string changesHistory = default, List<EditHistoryChangesWrapper> changes = default, string serverVersion = default)
        {
            this.Id = id;
            this.Key = key;
            this.@Version = version;
            this.VersionGroup = versionGroup;
            this.User = user;
            this.Created = created;
            this.ChangesHistory = changesHistory;
            this.Changes = changes;
            this.ServerVersion = serverVersion;
        }

        /// <summary>
        /// The document ID.
        /// </summary>
        /// <example>123</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The document identifier used to unambiguously identify the document file.
        /// </summary>
        /// <example>doc-key-abc123</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The document version number.
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// The document version group.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "versionGroup", EmitDefaultValue = false)]
        public int VersionGroup { get; set; }

        /// <summary>
        /// The information about the file editing history author.
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public EditHistoryAuthor User { get; set; }

        /// <summary>
        /// The API date and time parameters.
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public ApiDateTime Created { get; set; }

        /// <summary>
        /// The file history changes in the string format.
        /// </summary>
        /// <example>Changes history text</example>
        [DataMember(Name = "changesHistory", EmitDefaultValue = true)]
        public string ChangesHistory { get; set; }

        /// <summary>
        /// The list of file history changes.
        /// </summary>
        /// <example>[{"user":{"id":"123","name":"John Doe"},"created":"2021-01-01T00:00:00Z"}]</example>
        [DataMember(Name = "changes", EmitDefaultValue = true)]
        public List<EditHistoryChangesWrapper> Changes { get; set; }

        /// <summary>
        /// The current server version number.
        /// </summary>
        /// <example>8.0.1</example>
        [DataMember(Name = "serverVersion", EmitDefaultValue = true)]
        public string ServerVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditHistoryDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  VersionGroup: ").Append(VersionGroup).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ChangesHistory: ").Append(ChangesHistory).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
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
