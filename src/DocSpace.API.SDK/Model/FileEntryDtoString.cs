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
    /// The generic file entry information.
    /// </summary>
    [DataContract(Name = "FileEntryDtoString")]
    public partial class FileEntryDtoString : FileEntryBaseDto, IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileEntryDtoString" /> class.
        /// </summary>
        /// <param name="id">The file entry ID..</param>
        /// <param name="rootFolderId">The root folder ID of the file entry..</param>
        /// <param name="originId">The origin ID of the file entry..</param>
        /// <param name="originRoomId">The origin room ID of the file entry..</param>
        /// <param name="originTitle">The origin title of the file entry..</param>
        /// <param name="originRoomTitle">The origin room title of the file entry..</param>
        /// <param name="canShare">Specifies if the file entry can be shared or not..</param>
        /// <param name="shareSettings">shareSettings.</param>
        /// <param name="security">security.</param>
        /// <param name="availableExternalRights">The available external rights of the file entry..</param>
        /// <param name="requestToken">The request token of the file entry..</param>
        public FileEntryDtoString(string id = default, string rootFolderId = default, string originId = default, string originRoomId = default, string originTitle = default, string originRoomTitle = default, bool canShare = default, FileEntryDtoIntegerAllOfShareSettings shareSettings = default, FileEntryDtoIntegerAllOfSecurity security = default, Dictionary<string, bool> availableExternalRights = default, string requestToken = default)
        {
            this.Id = id;
            this.RootFolderId = rootFolderId;
            this.OriginId = originId;
            this.OriginRoomId = originRoomId;
            this.OriginTitle = originTitle;
            this.OriginRoomTitle = originRoomTitle;
            this.CanShare = canShare;
            this.ShareSettings = shareSettings;
            this.Security = security;
            this.AvailableExternalRights = availableExternalRights;
            this.RequestToken = requestToken;
        }

        /// <summary>
        /// The file entry ID.
        /// </summary>
        /// <value>The file entry ID.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The root folder ID of the file entry.
        /// </summary>
        /// <value>The root folder ID of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "rootFolderId", EmitDefaultValue = true)]
        public string RootFolderId { get; set; }

        /// <summary>
        /// The origin ID of the file entry.
        /// </summary>
        /// <value>The origin ID of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "originId", EmitDefaultValue = true)]
        public string OriginId { get; set; }

        /// <summary>
        /// The origin room ID of the file entry.
        /// </summary>
        /// <value>The origin room ID of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "originRoomId", EmitDefaultValue = true)]
        public string OriginRoomId { get; set; }

        /// <summary>
        /// The origin title of the file entry.
        /// </summary>
        /// <value>The origin title of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "originTitle", EmitDefaultValue = true)]
        public string OriginTitle { get; set; }

        /// <summary>
        /// The origin room title of the file entry.
        /// </summary>
        /// <value>The origin room title of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "originRoomTitle", EmitDefaultValue = true)]
        public string OriginRoomTitle { get; set; }

        /// <summary>
        /// Specifies if the file entry can be shared or not.
        /// </summary>
        /// <value>Specifies if the file entry can be shared or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canShare", EmitDefaultValue = true)]
        public bool CanShare { get; set; }

        /// <summary>
        /// Gets or Sets ShareSettings
        /// </summary>
        [DataMember(Name = "shareSettings", EmitDefaultValue = true)]
        public FileEntryDtoIntegerAllOfShareSettings ShareSettings { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = true)]
        public FileEntryDtoIntegerAllOfSecurity Security { get; set; }

        /// <summary>
        /// The available external rights of the file entry.
        /// </summary>
        /// <value>The available external rights of the file entry.</value>
        /*
        <example>[{&quot;key&quot;:&quot;some text&quot;,&quot;value&quot;:true}]</example>
        */
        [DataMember(Name = "availableExternalRights", EmitDefaultValue = true)]
        public Dictionary<string, bool> AvailableExternalRights { get; set; }

        /// <summary>
        /// The request token of the file entry.
        /// </summary>
        /// <value>The request token of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "requestToken", EmitDefaultValue = true)]
        public string RequestToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileEntryDtoString {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RootFolderId: ").Append(RootFolderId).Append("\n");
            sb.Append("  OriginId: ").Append(OriginId).Append("\n");
            sb.Append("  OriginRoomId: ").Append(OriginRoomId).Append("\n");
            sb.Append("  OriginTitle: ").Append(OriginTitle).Append("\n");
            sb.Append("  OriginRoomTitle: ").Append(OriginRoomTitle).Append("\n");
            sb.Append("  CanShare: ").Append(CanShare).Append("\n");
            sb.Append("  ShareSettings: ").Append(ShareSettings).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  AvailableExternalRights: ").Append(AvailableExternalRights).Append("\n");
            sb.Append("  RequestToken: ").Append(RequestToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
