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
    /// The pair of values that names a document across portals, as it is written into a spreadsheet formula.
    /// </summary>
    [DataContract(Name = "FileReferenceData")]
    public partial class FileReferenceData : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileReferenceData" /> class.
        /// </summary>
        /// <param name="fileKey">The id of the document inside the portal named below..</param>
        /// <param name="instanceId">The portal the document lives in. A reference whose value is not this portal cannot be resolved by the file  key and falls back to the path or the link..</param>
        /// <param name="roomId">The room the document lies in. It is filled in only for a document opened in a virtual data room, and stays  empty everywhere else..</param>
        /// <param name="canEditRoom">Whether the caller may manage the room named above; it is only meaningful together with it..</param>
        public FileReferenceData(string fileKey = default, string instanceId = default, string roomId = default, bool canEditRoom = default)
        {
            this.FileKey = fileKey;
            this.InstanceId = instanceId;
            this.RoomId = roomId;
            this.CanEditRoom = canEditRoom;
        }

        /// <summary>
        /// The id of the document inside the portal named below.
        /// </summary>
        /// <example>512</example>
        [DataMember(Name = "fileKey", EmitDefaultValue = true)]
        public string FileKey { get; set; }

        /// <summary>
        /// The portal the document lives in. A reference whose value is not this portal cannot be resolved by the file  key and falls back to the path or the link.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "instanceId", EmitDefaultValue = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The room the document lies in. It is filled in only for a document opened in a virtual data room, and stays  empty everywhere else.
        /// </summary>
        /// <example>42</example>
        [DataMember(Name = "roomId", EmitDefaultValue = true)]
        public string RoomId { get; set; }

        /// <summary>
        /// Whether the caller may manage the room named above; it is only meaningful together with it.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canEditRoom", EmitDefaultValue = true)]
        public bool CanEditRoom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileReferenceData {\n");
            sb.Append("  FileKey: ").Append(FileKey).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  CanEditRoom: ").Append(CanEditRoom).Append("\n");
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
