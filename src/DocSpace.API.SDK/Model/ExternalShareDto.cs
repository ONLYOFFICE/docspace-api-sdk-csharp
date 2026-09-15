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
    /// The outcome of validating an external share link and the entry it points at.
    /// </summary>
    [DataContract(Name = "ExternalShareDto")]
    public partial class ExternalShareDto : IValidatableObject
    {

        /// <summary>
        /// How validating the link went. It is the first field to read: a refused link is reported here with the answer  still arriving as a success. A link that resolved describes both the entry and the link, one that is waiting  for its password describes only the entry, and one that failed outright leaves the rest of the object empty.
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Whether the link points at a folder - a room counts as one - or at a single file. It is null when the link  could not be resolved.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public FileEntryType? Type { get; set; }

        /// <summary>
        /// Whether that entry is a folder or a file, null under the same conditions as its identifier.
        /// </summary>
        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public FileEntryType? EntityType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShareDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalShareDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShareDto" /> class.
        /// </summary>
        /// <param name="status">How validating the link went. It is the first field to read: a refused link is reported here with the answer  still arriving as a success. A link that resolved describes both the entry and the link, one that is waiting  for its password describes only the entry, and one that failed outright leaves the rest of the object empty. (required).</param>
        /// <param name="id">The identifier of the room, folder or file the link points at, always rendered as a string even where the  portal stores it as a number. It is null when the link could not be resolved..</param>
        /// <param name="title">The title of the entry the link points at, suitable for showing to the visitor before they are let in. It is  null when the link could not be resolved..</param>
        /// <param name="type">Whether the link points at a folder - a room counts as one - or at a single file. It is null when the link  could not be resolved..</param>
        /// <param name="tenantId">The portal the link belongs to, which matters for a client that works with more than one. It stays 0 for a  link that did not resolve. (required).</param>
        /// <param name="entityId">The identifier of the entry that was asked about through the request&#39;s file or folder parameter, echoed back  once it was found under the link&#39;s target. It is null when nothing was asked about, or when the entry lies  outside what the link opens..</param>
        /// <param name="entityTitle">The title of that entry, null under the same conditions as its identifier..</param>
        /// <param name="entityType">Whether that entry is a folder or a file, null under the same conditions as its identifier..</param>
        /// <param name="isRoom">True when the link opens a whole room rather than one entry inside it. It is null for a link to a file and for  a link that did not resolve..</param>
        /// <param name="shared">True when the entry now sits in the calling account&#39;s own lists - it was already shared with that account, or  resolving the link has just put it there. It stays false for a visitor browsing without an account, who  reaches the entry through the link alone. (required).</param>
        /// <param name="linkId">The link the token belongs to, which is also the subject under which the link appears among the sharing rights  of the entry. It is an empty identifier when the link did not resolve. (required).</param>
        /// <param name="isAuthenticated">Whether the request carried a signed-in account. It says nothing about that account&#39;s rights on the entry, so  it must not be read as permission - it is false for every anonymous visitor and true for any member, even one  who is a stranger to the room. (required).</param>
        /// <param name="isRoomMember">Whether the signed-in caller already has rights of their own on the room that holds the entry, as opposed to  reaching it through this link. It is false for an anonymous visitor and for a member who has never been  invited..</param>
        public ExternalShareDto(Status status = default, string id = default, string title = default, FileEntryType? type = default, int tenantId = default, string entityId = default, string entityTitle = default, FileEntryType? entityType = default, bool? isRoom = default, bool shared = default, Guid linkId = default, bool isAuthenticated = default, bool isRoomMember = default)
        {
            this.Status = status;
            this.TenantId = tenantId;
            this.Shared = shared;
            this.LinkId = linkId;
            this.IsAuthenticated = isAuthenticated;
            this.Id = id;
            this.Title = title;
            this.Type = type;
            this.EntityId = entityId;
            this.EntityTitle = entityTitle;
            this.EntityType = entityType;
            this.IsRoom = isRoom;
            this.IsRoomMember = isRoomMember;
        }

        /// <summary>
        /// The identifier of the room, folder or file the link points at, always rendered as a string even where the  portal stores it as a number. It is null when the link could not be resolved.
        /// </summary>
        /// <example>42</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The title of the entry the link points at, suitable for showing to the visitor before they are let in. It is  null when the link could not be resolved.
        /// </summary>
        /// <example>Project documents</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The portal the link belongs to, which matters for a client that works with more than one. It stays 0 for a  link that did not resolve.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public int TenantId { get; set; }

        /// <summary>
        /// The identifier of the entry that was asked about through the request&#39;s file or folder parameter, echoed back  once it was found under the link&#39;s target. It is null when nothing was asked about, or when the entry lies  outside what the link opens.
        /// </summary>
        /// <example>9</example>
        [DataMember(Name = "entityId", EmitDefaultValue = true)]
        public string EntityId { get; set; }

        /// <summary>
        /// The title of that entry, null under the same conditions as its identifier.
        /// </summary>
        /// <example>Contract.docx</example>
        [DataMember(Name = "entityTitle", EmitDefaultValue = true)]
        public string EntityTitle { get; set; }

        /// <summary>
        /// True when the link opens a whole room rather than one entry inside it. It is null for a link to a file and for  a link that did not resolve.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isRoom", EmitDefaultValue = true)]
        public bool? IsRoom { get; set; }

        /// <summary>
        /// True when the entry now sits in the calling account&#39;s own lists - it was already shared with that account, or  resolving the link has just put it there. It stays false for a visitor browsing without an account, who  reaches the entry through the link alone.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "shared", IsRequired = true, EmitDefaultValue = true)]
        public bool Shared { get; set; }

        /// <summary>
        /// The link the token belongs to, which is also the subject under which the link appears among the sharing rights  of the entry. It is an empty identifier when the link did not resolve.
        /// </summary>
        /// <example>b3a1f0c7-5d2e-4a19-9f38-71c6e0d4b852</example>
        [DataMember(Name = "linkId", IsRequired = true, EmitDefaultValue = true)]
        public Guid LinkId { get; set; }

        /// <summary>
        /// Whether the request carried a signed-in account. It says nothing about that account&#39;s rights on the entry, so  it must not be read as permission - it is false for every anonymous visitor and true for any member, even one  who is a stranger to the room.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isAuthenticated", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAuthenticated { get; set; }

        /// <summary>
        /// Whether the signed-in caller already has rights of their own on the room that holds the entry, as opposed to  reaching it through this link. It is false for an anonymous visitor and for a member who has never been  invited.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isRoomMember", EmitDefaultValue = true)]
        public bool IsRoomMember { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalShareDto {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityTitle: ").Append(EntityTitle).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  IsRoom: ").Append(IsRoom).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  LinkId: ").Append(LinkId).Append("\n");
            sb.Append("  IsAuthenticated: ").Append(IsAuthenticated).Append("\n");
            sb.Append("  IsRoomMember: ").Append(IsRoomMember).Append("\n");
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
