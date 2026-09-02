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
        /// <param name="availableShareRights">availableShareRights.</param>
        /// <param name="requestToken">The request token of the file entry..</param>
        /// <param name="external">Specifies if the folder can be accessed via an external link or not..</param>
        /// <param name="expirationDate">Represents the expiration date of the file entry..</param>
        /// <param name="isLinkExpired">Indicates whether the shareable link associated with the file or folder has expired..</param>
        public FileEntryDtoString(string id = default, string rootFolderId = default, string originId = default, string originRoomId = default, string originTitle = default, string originRoomTitle = default, bool canShare = default, FileEntryDtoIntegerAllOfShareSettings shareSettings = default, FileEntryDtoIntegerAllOfSecurity security = default, FileEntryDtoIntegerAllOfAvailableShareRights availableShareRights = default, string requestToken = default, bool? external = default, ApiDateTime expirationDate = default, bool? isLinkExpired = default)
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
            this.AvailableShareRights = availableShareRights;
            this.RequestToken = requestToken;
            this.External = external;
            this.ExpirationDate = expirationDate;
            this.IsLinkExpired = isLinkExpired;
        }

        /// <summary>
        /// The file entry ID.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The root folder ID of the file entry.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "rootFolderId", EmitDefaultValue = true)]
        public string RootFolderId { get; set; }

        /// <summary>
        /// The origin ID of the file entry.
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "originId", EmitDefaultValue = true)]
        public string OriginId { get; set; }

        /// <summary>
        /// The origin room ID of the file entry.
        /// </summary>
        /// <example>22</example>
        [DataMember(Name = "originRoomId", EmitDefaultValue = true)]
        public string OriginRoomId { get; set; }

        /// <summary>
        /// The origin title of the file entry.
        /// </summary>
        /// <example>Original Title</example>
        [DataMember(Name = "originTitle", EmitDefaultValue = true)]
        public string OriginTitle { get; set; }

        /// <summary>
        /// The origin room title of the file entry.
        /// </summary>
        /// <example>Original Room</example>
        [DataMember(Name = "originRoomTitle", EmitDefaultValue = true)]
        public string OriginRoomTitle { get; set; }

        /// <summary>
        /// Specifies if the file entry can be shared or not.
        /// </summary>
        /// <example>true</example>
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
        /// Gets or Sets AvailableShareRights
        /// </summary>
        [DataMember(Name = "availableShareRights", EmitDefaultValue = true)]
        public FileEntryDtoIntegerAllOfAvailableShareRights AvailableShareRights { get; set; }

        /// <summary>
        /// The request token of the file entry.
        /// </summary>
        /// <example>token-abc-123</example>
        [DataMember(Name = "requestToken", EmitDefaultValue = true)]
        public string RequestToken { get; set; }

        /// <summary>
        /// Specifies if the folder can be accessed via an external link or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "external", EmitDefaultValue = true)]
        public bool? External { get; set; }

        /// <summary>
        /// Represents the expiration date of the file entry.
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public ApiDateTime ExpirationDate { get; set; }

        /// <summary>
        /// Indicates whether the shareable link associated with the file or folder has expired.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isLinkExpired", EmitDefaultValue = true)]
        public bool? IsLinkExpired { get; set; }

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
            sb.Append("  AvailableShareRights: ").Append(AvailableShareRights).Append("\n");
            sb.Append("  RequestToken: ").Append(RequestToken).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IsLinkExpired: ").Append(IsLinkExpired).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
