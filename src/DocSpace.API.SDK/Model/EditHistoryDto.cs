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
    /// One saved revision of a file, as the editing service recorded it.
    /// </summary>
    [DataContract(Name = "EditHistoryDto")]
    public partial class EditHistoryDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryDto" /> class.
        /// </summary>
        /// <param name="id">The file the revision belongs to; every entry of one history carries the same value..</param>
        /// <param name="key">The document key of this revision, which the editing service uses to tell the revisions of a file apart and to  reuse the copy it has cached. Hand it back unchanged when asking the editor for this revision..</param>
        /// <param name="version">The number of the revision, counting up from 1 in the order the revisions were saved. It is the value the  operations that show the changes of a revision or restore it expect..</param>
        /// <param name="versionGroup">Groups the revisions written by one editing session: entries sharing this number were saved while the same  session was open, which is how a client collapses a long list of revisions into the versions a person would  recognise..</param>
        /// <param name="user">The account that saved the revision. A revision saved by an account that no longer exists, or through an  anonymous link, is reported as a guest..</param>
        /// <param name="created">When the revision was saved, written with the offset of the portal&#39;s time zone rather than as plain UTC. The  times of one history are consistent with each other, so order and display the revisions by them..</param>
        /// <param name="changesHistory">The change record the editing service stored for this revision, as the raw JSON it was written in, and empty  for a revision the portal has no record for - one uploaded as a whole file, for instance. &#x60;changes&#x60; is the  same record already parsed..</param>
        /// <param name="changes">The single changes this revision introduced - who made each of them and when - taken from the stored change  record. It comes back empty both for a revision whose changes were never recorded and for one whose record is  in a format the portal no longer reads, so an empty list is not proof that nothing changed..</param>
        /// <param name="serverVersion">The build of the editing service that wrote the change record of this revision, taken from the record itself;  empty when the portal holds no record for the revision..</param>
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
        /// The file the revision belongs to; every entry of one history carries the same value.
        /// </summary>
        /// <example>123</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The document key of this revision, which the editing service uses to tell the revisions of a file apart and to  reuse the copy it has cached. Hand it back unchanged when asking the editor for this revision.
        /// </summary>
        /// <example>doc-key-abc123</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The number of the revision, counting up from 1 in the order the revisions were saved. It is the value the  operations that show the changes of a revision or restore it expect.
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// Groups the revisions written by one editing session: entries sharing this number were saved while the same  session was open, which is how a client collapses a long list of revisions into the versions a person would  recognise.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "versionGroup", EmitDefaultValue = false)]
        public int VersionGroup { get; set; }

        /// <summary>
        /// The account that saved the revision. A revision saved by an account that no longer exists, or through an  anonymous link, is reported as a guest.
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public EditHistoryAuthor User { get; set; }

        /// <summary>
        /// When the revision was saved, written with the offset of the portal&#39;s time zone rather than as plain UTC. The  times of one history are consistent with each other, so order and display the revisions by them.
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public ApiDateTime Created { get; set; }

        /// <summary>
        /// The change record the editing service stored for this revision, as the raw JSON it was written in, and empty  for a revision the portal has no record for - one uploaded as a whole file, for instance. &#x60;changes&#x60; is the  same record already parsed.
        /// </summary>
        /// <example>Changes history text</example>
        [DataMember(Name = "changesHistory", EmitDefaultValue = true)]
        public string ChangesHistory { get; set; }

        /// <summary>
        /// The single changes this revision introduced - who made each of them and when - taken from the stored change  record. It comes back empty both for a revision whose changes were never recorded and for one whose record is  in a format the portal no longer reads, so an empty list is not proof that nothing changed.
        /// </summary>
        /// <example>[{"user":{"id":"123","name":"John Doe"},"created":"2021-01-01T00:00:00Z"}]</example>
        [DataMember(Name = "changes", EmitDefaultValue = true)]
        public List<EditHistoryChangesWrapper> Changes { get; set; }

        /// <summary>
        /// The build of the editing service that wrote the change record of this revision, taken from the record itself;  empty when the portal holds no record for the revision.
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
