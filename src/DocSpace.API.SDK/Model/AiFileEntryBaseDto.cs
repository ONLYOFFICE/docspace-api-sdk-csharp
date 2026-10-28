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
    /// What every file and folder in an answer has in common; the concrete shape is a file or a folder, told apart by the  entry type.
    /// </summary>
    [DataContract(Name = "AiFileEntryBaseDto")]
    public partial class AiFileEntryBaseDto : IValidatableObject
    {

        /// <summary>
        /// The level the calling account holds on this entry, resolved from its own rights, the groups it belongs to and  any link it came in through. It is the level itself, not what the account may do with it - the action flags  below answer that.
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public AiFileShare? Access { get; set; }

        /// <summary>
        /// The section the entry ultimately belongs to, which is what tells a personal document from one inside a room,  from a template and from something in the trash or the archive.
        /// </summary>
        [DataMember(Name = "rootFolderType", EmitDefaultValue = false)]
        public AiFolderType? RootFolderType { get; set; }

        /// <summary>
        /// The kind of room the entry lies in, which decides what the room allows - filling forms, public links,  indexing. It is null for an entry that is not inside a room at all.
        /// </summary>
        [DataMember(Name = "parentRoomType", EmitDefaultValue = false)]
        public AiFolderType? ParentRoomType { get; set; }

        /// <summary>
        /// Tells a folder from a file, and so which of the two shapes the rest of the object has. A room is reported as a  folder here.
        /// </summary>
        [DataMember(Name = "fileEntryType", EmitDefaultValue = false)]
        public AiFileEntryType? FileEntryType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiFileEntryBaseDto" /> class.
        /// </summary>
        /// <param name="title">The name shown for the entry. For a file it carries the extension, which is how the format is recognised, and  for a room it is the room name..</param>
        /// <param name="access">The level the calling account holds on this entry, resolved from its own rights, the groups it belongs to and  any link it came in through. It is the level itself, not what the account may do with it - the action flags  below answer that..</param>
        /// <param name="sharedBy">Who gave the calling account the access it is using. It is filled in only while the entry is being read  through a share, and never for a caller without an account..</param>
        /// <param name="ownedBy">Who owns the place the entry is shared from - the creator of the room it lies in, or of the personal section  that holds it. It is filled in only while the entry is being read through a share, and never for a caller  without an account..</param>
        /// <param name="shared">Whether at least one external link exists for the entry, whichever kind. It says nothing about accounts and  groups - those are counted by the flag for members below..</param>
        /// <param name="sharedForUser">Whether at least one account or group has been given rights on the entry directly, as opposed to reaching it  through a link or through the room around it..</param>
        /// <param name="sharedExternal">Whether one of the entry&#39;s links is open to people outside the portal, as opposed to a link that only its own  members can follow. This is the flag to watch when the concern is who can reach the content from outside..</param>
        /// <param name="parentShared">Whether the entry is reachable because the room or folder around it is shared, rather than through rights of  its own. A copy or a move takes the entry out of that scope..</param>
        /// <param name="shortWebUrl">A shortened address that opens the entry through the link it is being read with. It is an empty string  whenever no link applies, which is the usual case for a member browsing their own rooms..</param>
        /// <param name="created">When the entry was created, written with the offset of the portal&#39;s time zone. For a file restored from an  older version this is still the moment the file first appeared..</param>
        /// <param name="createdBy">Who created the entry. It is null for a caller without an account, who is told nothing about the portal&#39;s  members..</param>
        /// <param name="updated">When the entry last changed, written with the offset of the portal&#39;s time zone. It is never reported as  earlier than the creation moment, so the two can be compared safely..</param>
        /// <param name="autoDelete">When the entry will disappear on its own, written with the offset of the portal&#39;s time zone. It is filled in  only where a removal is actually scheduled - something in the trash while the portal cleans it up  automatically, or a guest&#39;s own documents - so a null means nothing is scheduled rather than that the entry is  permanent..</param>
        /// <param name="rootFolderType">The section the entry ultimately belongs to, which is what tells a personal document from one inside a room,  from a template and from something in the trash or the archive..</param>
        /// <param name="parentRoomType">The kind of room the entry lies in, which decides what the room allows - filling forms, public links,  indexing. It is null for an entry that is not inside a room at all..</param>
        /// <param name="updatedBy">Who changed the entry last. It is null for a caller without an account..</param>
        /// <param name="providerItem">Set when the entry is stored on a connected third-party account rather than on the portal, and null when it is  stored on the portal. Such an entry is identified by a string rather than a number, and some operations skip  it..</param>
        /// <param name="providerKey">Which third-party service holds the entry, matching the keys accepted by the third-party operations. It is  null for an entry stored on the portal..</param>
        /// <param name="providerId">The connected account the entry comes from, for telling apart two connections to the same service. It is null  for an entry stored on the portal..</param>
        /// <param name="order">The place of the entry in a room where the members arrange the content themselves, given as the position of  the entry preceded by the positions of the folders leading to it, separated by dots. It is empty when nothing  has been arranged..</param>
        /// <param name="isFavorite">Set when the calling account has marked the entry as a favorite, which is what puts it into the favorites  listing. For a file that is not marked it is null rather than false..</param>
        /// <param name="fileEntryType">Tells a folder from a file, and so which of the two shapes the rest of the object has. A room is reported as a  folder here..</param>
        public AiFileEntryBaseDto(string title = default, AiFileShare? access = default, AiEmployeeDto sharedBy = default, AiEmployeeDto ownedBy = default, bool shared = default, bool sharedForUser = default, bool sharedExternal = default, bool parentShared = default, string shortWebUrl = default, AiApiDateTime created = default, AiEmployeeDto createdBy = default, AiApiDateTime updated = default, AiApiDateTime autoDelete = default, AiFolderType? rootFolderType = default, AiFolderType? parentRoomType = default, AiEmployeeDto updatedBy = default, bool? providerItem = default, string providerKey = default, int? providerId = default, string order = default, bool? isFavorite = default, AiFileEntryType? fileEntryType = default)
        {
            this.Title = title;
            this.Access = access;
            this.SharedBy = sharedBy;
            this.OwnedBy = ownedBy;
            this.Shared = shared;
            this.SharedForUser = sharedForUser;
            this.SharedExternal = sharedExternal;
            this.ParentShared = parentShared;
            this.ShortWebUrl = shortWebUrl;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.Updated = updated;
            this.AutoDelete = autoDelete;
            this.RootFolderType = rootFolderType;
            this.ParentRoomType = parentRoomType;
            this.UpdatedBy = updatedBy;
            this.ProviderItem = providerItem;
            this.ProviderKey = providerKey;
            this.ProviderId = providerId;
            this.Order = order;
            this.IsFavorite = isFavorite;
            this.FileEntryType = fileEntryType;
        }

        /// <summary>
        /// The name shown for the entry. For a file it carries the extension, which is how the format is recognised, and  for a room it is the room name.
        /// </summary>
        /// <example>Some title.txt</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Who gave the calling account the access it is using. It is filled in only while the entry is being read  through a share, and never for a caller without an account.
        /// </summary>
        [DataMember(Name = "sharedBy", EmitDefaultValue = false)]
        public AiEmployeeDto SharedBy { get; set; }

        /// <summary>
        /// Who owns the place the entry is shared from - the creator of the room it lies in, or of the personal section  that holds it. It is filled in only while the entry is being read through a share, and never for a caller  without an account.
        /// </summary>
        [DataMember(Name = "ownedBy", EmitDefaultValue = false)]
        public AiEmployeeDto OwnedBy { get; set; }

        /// <summary>
        /// Whether at least one external link exists for the entry, whichever kind. It says nothing about accounts and  groups - those are counted by the flag for members below.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool Shared { get; set; }

        /// <summary>
        /// Whether at least one account or group has been given rights on the entry directly, as opposed to reaching it  through a link or through the room around it.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "sharedForUser", EmitDefaultValue = true)]
        public bool SharedForUser { get; set; }

        /// <summary>
        /// Whether one of the entry&#39;s links is open to people outside the portal, as opposed to a link that only its own  members can follow. This is the flag to watch when the concern is who can reach the content from outside.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "sharedExternal", EmitDefaultValue = true)]
        public bool SharedExternal { get; set; }

        /// <summary>
        /// Whether the entry is reachable because the room or folder around it is shared, rather than through rights of  its own. A copy or a move takes the entry out of that scope.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "parentShared", EmitDefaultValue = true)]
        public bool ParentShared { get; set; }

        /// <summary>
        /// A shortened address that opens the entry through the link it is being read with. It is an empty string  whenever no link applies, which is the usual case for a member browsing their own rooms.
        /// </summary>
        /// <example>http://localhost/s/abc123</example>
        [DataMember(Name = "shortWebUrl", EmitDefaultValue = true)]
        public string ShortWebUrl { get; set; }

        /// <summary>
        /// When the entry was created, written with the offset of the portal&#39;s time zone. For a file restored from an  older version this is still the moment the file first appeared.
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public AiApiDateTime Created { get; set; }

        /// <summary>
        /// Who created the entry. It is null for a caller without an account, who is told nothing about the portal&#39;s  members.
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public AiEmployeeDto CreatedBy { get; set; }

        /// <summary>
        /// When the entry last changed, written with the offset of the portal&#39;s time zone. It is never reported as  earlier than the creation moment, so the two can be compared safely.
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public AiApiDateTime Updated { get; set; }

        /// <summary>
        /// When the entry will disappear on its own, written with the offset of the portal&#39;s time zone. It is filled in  only where a removal is actually scheduled - something in the trash while the portal cleans it up  automatically, or a guest&#39;s own documents - so a null means nothing is scheduled rather than that the entry is  permanent.
        /// </summary>
        [DataMember(Name = "autoDelete", EmitDefaultValue = false)]
        public AiApiDateTime AutoDelete { get; set; }

        /// <summary>
        /// Who changed the entry last. It is null for a caller without an account.
        /// </summary>
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public AiEmployeeDto UpdatedBy { get; set; }

        /// <summary>
        /// Set when the entry is stored on a connected third-party account rather than on the portal, and null when it is  stored on the portal. Such an entry is identified by a string rather than a number, and some operations skip  it.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "providerItem", EmitDefaultValue = true)]
        public bool? ProviderItem { get; set; }

        /// <summary>
        /// Which third-party service holds the entry, matching the keys accepted by the third-party operations. It is  null for an entry stored on the portal.
        /// </summary>
        /// <example>google-drive</example>
        [DataMember(Name = "providerKey", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// The connected account the entry comes from, for telling apart two connections to the same service. It is null  for an entry stored on the portal.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "providerId", EmitDefaultValue = true)]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The place of the entry in a room where the members arrange the content themselves, given as the position of  the entry preceded by the positions of the folders leading to it, separated by dots. It is empty when nothing  has been arranged.
        /// </summary>
        /// <example>1.3.2</example>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public string Order { get; set; }

        /// <summary>
        /// Set when the calling account has marked the entry as a favorite, which is what puts it into the favorites  listing. For a file that is not marked it is null rather than false.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isFavorite", EmitDefaultValue = true)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiFileEntryBaseDto {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  SharedBy: ").Append(SharedBy).Append("\n");
            sb.Append("  OwnedBy: ").Append(OwnedBy).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  SharedForUser: ").Append(SharedForUser).Append("\n");
            sb.Append("  SharedExternal: ").Append(SharedExternal).Append("\n");
            sb.Append("  ParentShared: ").Append(ParentShared).Append("\n");
            sb.Append("  ShortWebUrl: ").Append(ShortWebUrl).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  AutoDelete: ").Append(AutoDelete).Append("\n");
            sb.Append("  RootFolderType: ").Append(RootFolderType).Append("\n");
            sb.Append("  ParentRoomType: ").Append(ParentRoomType).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  ProviderItem: ").Append(ProviderItem).Append("\n");
            sb.Append("  ProviderKey: ").Append(ProviderKey).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  IsFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  FileEntryType: ").Append(FileEntryType).Append("\n");
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
