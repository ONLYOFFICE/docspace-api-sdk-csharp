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
    /// The folder, with the fields that only a room carries filled in when the folder is a room.
    /// </summary>
    [DataContract(Name = "FolderDto")]
    public partial class FolderDto : FileEntryDto, IValidatableObject
    {

        /// <summary>
        /// The kind of the room, which decides the default access rules of its members. Null for a folder that is not a  room.
        /// </summary>
        [DataMember(Name = "roomType", EmitDefaultValue = false)]
        public RoomType? RoomType { get; set; }

        /// <summary>
        /// The part the folder plays inside its room: one of the service folders of the form-filling flow, or the  knowledge and result storages of an AI room. It stays null for an ordinary folder and for the room itself, so  it does not describe folders in general.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public FolderType? Type { get; set; }

        /// <summary>
        /// The kind of the room the folder lies in. It is filled in only for the folder a folder-contents answer is  about, and only when that room is an AI room, so it is null in every other answer and for every other room  kind.
        /// </summary>
        [DataMember(Name = "rootRoomType", EmitDefaultValue = false)]
        public RoomType? RootRoomType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderDto" /> class.
        /// </summary>
        /// <param name="parentId">The folder this one is listed in. For a room it is the root of the section the room lives in, and for an entry  opened through a sharing link whose real parent the caller may not read it is the root of the section with the  entries shared with them..</param>
        /// <param name="filesCount">How many files lie directly in the folder, without counting the subfolders. The roots of the &#x60;Rooms&#x60;, room  templates and default templates sections always report 0, because the number is not collected for them..</param>
        /// <param name="foldersCount">How many subfolders lie directly in the folder. For an AI room the two service subfolders it always holds are  subtracted, so the number matches what a listing of it shows, and the roots of the &#x60;Rooms&#x60; and templates  sections report 0..</param>
        /// <param name="isShareable">Whether the caller may hand out access to the folder. It is filled in only for the folder a folder-contents  answer is about, and is null in every other answer, so null says nothing about the sharing rights..</param>
        /// <param name="new">How many entries inside the folder the caller has not opened yet, the number drawn as the badge on it. An  account that turned the badges off in its own settings always reads 0 here, so 0 alone does not prove that  everything has been seen..</param>
        /// <param name="mute">Whether the caller silenced the notifications of this room: true means no message about its activity reaches  them. The choice belongs to the reading account rather than to the room, so two members of one room read  different values..</param>
        /// <param name="tags">The names of the tags attached to the room. Empty for a folder that is not a room, since only rooms carry  tags, and the names are the ones from the portal tag catalogue..</param>
        /// <param name="logo">The addresses of the room logo in four sizes, together with the colour and the built-in cover that are drawn  when no logo was uploaded. A room without a logo answers with four empty addresses rather than with null, and  the field is null for a folder that is not a room..</param>
        /// <param name="pinned">Whether the caller pinned the room to the top of their own room list. Pinning is personal and is lost when the  room is archived..</param>
        /// <param name="roomType">The kind of the room, which decides the default access rules of its members. Null for a folder that is not a  room..</param>
        /// <param name="private">Whether the room is a private one, which limits it to the accounts invited into it and needs encryption keys  set up for each of them..</param>
        /// <param name="indexing">Whether the contents of the room are kept in an explicit numbered order, the one reported as &#x60;order&#x60; on each  entry, instead of being left to the sorting the reader asks for..</param>
        /// <param name="denyDownload">Whether downloading and printing the contents of the room is forbidden, which leaves its members with viewing  and editing in the editor..</param>
        /// <param name="lifetime">The rule by which the files of the room are removed once they grow old. Null when the room has no such rule,  which is also what is reported after the rule is switched off, because switching it off erases it..</param>
        /// <param name="watermark">The watermark stamped over the documents of the room while they are viewed and printed. Null when the room has  no watermark, and for every folder that is not a room..</param>
        /// <param name="type">The part the folder plays inside its room: one of the service folders of the form-filling flow, or the  knowledge and result storages of an AI room. It stays null for an ordinary folder and for the room itself, so  it does not describe folders in general..</param>
        /// <param name="inRoom">Whether the caller holds the room through an invitation of their own: true for the account that created it and  for a member invited personally, false when the access comes from a group they belong to, and null for a  folder that is not a room..</param>
        /// <param name="quotaLimit">How much space the files of the room may take, in bytes. It is the limit set on this room, or the portal  default for rooms when none was set. Null when the tariff of the portal does not count room statistics, when  room quotas are switched off, when the room lies in the archive or the trash, or when the caller may only read  it..</param>
        /// <param name="isCustomQuota">Whether &#x60;quotaLimit&#x60; is a limit set on this room (true) or the portal default for rooms (false). Null exactly  when &#x60;quotaLimit&#x60; is null..</param>
        /// <param name="usedSpace">How much the files of the room take, in bytes, as of the last time the counter was recomputed. The counter is  refreshed when a file operation finishes, so a read right after an upload or a deletion can still report the  previous figure. Null for a folder that is not a room..</param>
        /// <param name="passwordProtected">Whether the sharing link the folder was opened through asks for a password that has not been entered yet.  While it is true the contents stay unreadable; send the password to &#x60;POST api/2.0/files/share/{key}/password&#x60;  first. Null when the folder was not reached through a link..</param>
        /// <param name="expired">Deprecated, read &#x60;isLinkExpired&#x60; instead: whether the sharing link the folder was opened through has run out  of its lifetime..</param>
        /// <param name="chatSettings">The chat configuration of an AI room. Only the system prompt is reported here, whatever else the room stores,  and the field is null for every folder that is not an AI room..</param>
        /// <param name="rootRoomType">The kind of the room the folder lies in. It is filled in only for the folder a folder-contents answer is  about, and only when that room is an AI room, so it is null in every other answer and for every other room  kind..</param>
        /// <param name="saveFormAsXLSX">Whether the answers collected in this form-filling room are also gathered into a spreadsheet next to the  completed copies. Filled in for form-filling rooms only..</param>
        /// <param name="sendFormToExternalDB">Whether the answers collected in this form-filling room are also pushed into the external database configured  for the portal. Filled in for form-filling rooms only..</param>
        /// <param name="originalFormId">The form the completed copies in this folder were filled from, taken from the copy submitted last. Null while  the folder holds no completed copy, and for every folder that does not collect them..</param>
        public FolderDto(int parentId = default, int filesCount = default, int foldersCount = default, bool? isShareable = default, int @new = default, bool mute = default, List<string> tags = default, Logo logo = default, bool pinned = default, RoomType? roomType = default, bool @private = default, bool indexing = default, bool denyDownload = default, RoomDataLifetimeDto lifetime = default, WatermarkDto watermark = default, FolderType? type = default, bool? inRoom = default, long? quotaLimit = default, bool? isCustomQuota = default, long? usedSpace = default, bool? passwordProtected = default, bool? expired = default, ChatSettingsDto chatSettings = default, RoomType? rootRoomType = default, bool? saveFormAsXLSX = default, bool? sendFormToExternalDB = default, int? originalFormId = default)
        {
            this.ParentId = parentId;
            this.FilesCount = filesCount;
            this.FoldersCount = foldersCount;
            this.IsShareable = isShareable;
            this.New = @new;
            this.Mute = mute;
            this.Tags = tags;
            this.Logo = logo;
            this.Pinned = pinned;
            this.RoomType = roomType;
            this.Private = @private;
            this.Indexing = indexing;
            this.DenyDownload = denyDownload;
            this.Lifetime = lifetime;
            this.Watermark = watermark;
            this.Type = type;
            this.InRoom = inRoom;
            this.QuotaLimit = quotaLimit;
            this.IsCustomQuota = isCustomQuota;
            this.UsedSpace = usedSpace;
            this.PasswordProtected = passwordProtected;
            this.Expired = expired;
            this.ChatSettings = chatSettings;
            this.RootRoomType = rootRoomType;
            this.SaveFormAsXLSX = saveFormAsXLSX;
            this.SendFormToExternalDB = sendFormToExternalDB;
            this.OriginalFormId = originalFormId;
        }

        /// <summary>
        /// The folder this one is listed in. For a room it is the root of the section the room lives in, and for an entry  opened through a sharing link whose real parent the caller may not read it is the root of the section with the  entries shared with them.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "parentId", EmitDefaultValue = false)]
        public int ParentId { get; set; }

        /// <summary>
        /// How many files lie directly in the folder, without counting the subfolders. The roots of the &#x60;Rooms&#x60;, room  templates and default templates sections always report 0, because the number is not collected for them.
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "filesCount", EmitDefaultValue = false)]
        public int FilesCount { get; set; }

        /// <summary>
        /// How many subfolders lie directly in the folder. For an AI room the two service subfolders it always holds are  subtracted, so the number matches what a listing of it shows, and the roots of the &#x60;Rooms&#x60; and templates  sections report 0.
        /// </summary>
        /// <example>7</example>
        [DataMember(Name = "foldersCount", EmitDefaultValue = false)]
        public int FoldersCount { get; set; }

        /// <summary>
        /// Whether the caller may hand out access to the folder. It is filled in only for the folder a folder-contents  answer is about, and is null in every other answer, so null says nothing about the sharing rights.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isShareable", EmitDefaultValue = true)]
        public bool? IsShareable { get; set; }

        /// <summary>
        /// How many entries inside the folder the caller has not opened yet, the number drawn as the badge on it. An  account that turned the badges off in its own settings always reads 0 here, so 0 alone does not prove that  everything has been seen.
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "new", EmitDefaultValue = false)]
        public int New { get; set; }

        /// <summary>
        /// Whether the caller silenced the notifications of this room: true means no message about its activity reaches  them. The choice belongs to the reading account rather than to the room, so two members of one room read  different values.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "mute", EmitDefaultValue = true)]
        public bool Mute { get; set; }

        /// <summary>
        /// The names of the tags attached to the room. Empty for a folder that is not a room, since only rooms carry  tags, and the names are the ones from the portal tag catalogue.
        /// </summary>
        /// <example>["Marketing","Q3"]</example>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The addresses of the room logo in four sizes, together with the colour and the built-in cover that are drawn  when no logo was uploaded. A room without a logo answers with four empty addresses rather than with null, and  the field is null for a folder that is not a room.
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public Logo Logo { get; set; }

        /// <summary>
        /// Whether the caller pinned the room to the top of their own room list. Pinning is personal and is lost when the  room is archived.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "pinned", EmitDefaultValue = true)]
        public bool Pinned { get; set; }

        /// <summary>
        /// Whether the room is a private one, which limits it to the accounts invited into it and needs encryption keys  set up for each of them.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private { get; set; }

        /// <summary>
        /// Whether the contents of the room are kept in an explicit numbered order, the one reported as &#x60;order&#x60; on each  entry, instead of being left to the sorting the reader asks for.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool Indexing { get; set; }

        /// <summary>
        /// Whether downloading and printing the contents of the room is forbidden, which leaves its members with viewing  and editing in the editor.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// The rule by which the files of the room are removed once they grow old. Null when the room has no such rule,  which is also what is reported after the rule is switched off, because switching it off erases it.
        /// </summary>
        [DataMember(Name = "lifetime", EmitDefaultValue = false)]
        public RoomDataLifetimeDto Lifetime { get; set; }

        /// <summary>
        /// The watermark stamped over the documents of the room while they are viewed and printed. Null when the room has  no watermark, and for every folder that is not a room.
        /// </summary>
        [DataMember(Name = "watermark", EmitDefaultValue = false)]
        public WatermarkDto Watermark { get; set; }

        /// <summary>
        /// Whether the caller holds the room through an invitation of their own: true for the account that created it and  for a member invited personally, false when the access comes from a group they belong to, and null for a  folder that is not a room.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "inRoom", EmitDefaultValue = true)]
        public bool? InRoom { get; set; }

        /// <summary>
        /// How much space the files of the room may take, in bytes. It is the limit set on this room, or the portal  default for rooms when none was set. Null when the tariff of the portal does not count room statistics, when  room quotas are switched off, when the room lies in the archive or the trash, or when the caller may only read  it.
        /// </summary>
        /// <example>1073741824</example>
        [DataMember(Name = "quotaLimit", EmitDefaultValue = true)]
        public long? QuotaLimit { get; set; }

        /// <summary>
        /// Whether &#x60;quotaLimit&#x60; is a limit set on this room (true) or the portal default for rooms (false). Null exactly  when &#x60;quotaLimit&#x60; is null.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isCustomQuota", EmitDefaultValue = true)]
        public bool? IsCustomQuota { get; set; }

        /// <summary>
        /// How much the files of the room take, in bytes, as of the last time the counter was recomputed. The counter is  refreshed when a file operation finishes, so a read right after an upload or a deletion can still report the  previous figure. Null for a folder that is not a room.
        /// </summary>
        /// <example>524288000</example>
        [DataMember(Name = "usedSpace", EmitDefaultValue = true)]
        public long? UsedSpace { get; set; }

        /// <summary>
        /// Whether the sharing link the folder was opened through asks for a password that has not been entered yet.  While it is true the contents stay unreadable; send the password to &#x60;POST api/2.0/files/share/{key}/password&#x60;  first. Null when the folder was not reached through a link.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "passwordProtected", EmitDefaultValue = true)]
        public bool? PasswordProtected { get; set; }

        /// <summary>
        /// Deprecated, read &#x60;isLinkExpired&#x60; instead: whether the sharing link the folder was opened through has run out  of its lifetime.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "expired", EmitDefaultValue = true)]
        [Obsolete]
        public bool? Expired { get; set; }

        /// <summary>
        /// The chat configuration of an AI room. Only the system prompt is reported here, whatever else the room stores,  and the field is null for every folder that is not an AI room.
        /// </summary>
        [DataMember(Name = "chatSettings", EmitDefaultValue = false)]
        public ChatSettingsDto ChatSettings { get; set; }

        /// <summary>
        /// Whether the answers collected in this form-filling room are also gathered into a spreadsheet next to the  completed copies. Filled in for form-filling rooms only.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "saveFormAsXLSX", EmitDefaultValue = true)]
        public bool? SaveFormAsXLSX { get; set; }

        /// <summary>
        /// Whether the answers collected in this form-filling room are also pushed into the external database configured  for the portal. Filled in for form-filling rooms only.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "sendFormToExternalDB", EmitDefaultValue = true)]
        public bool? SendFormToExternalDB { get; set; }

        /// <summary>
        /// The form the completed copies in this folder were filled from, taken from the copy submitted last. Null while  the folder holds no completed copy, and for every folder that does not collect them.
        /// </summary>
        /// <example>42</example>
        [DataMember(Name = "originalFormId", EmitDefaultValue = true)]
        public int? OriginalFormId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderDto {\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  FilesCount: ").Append(FilesCount).Append("\n");
            sb.Append("  FoldersCount: ").Append(FoldersCount).Append("\n");
            sb.Append("  IsShareable: ").Append(IsShareable).Append("\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Mute: ").Append(Mute).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  RoomType: ").Append(RoomType).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  Indexing: ").Append(Indexing).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  Lifetime: ").Append(Lifetime).Append("\n");
            sb.Append("  Watermark: ").Append(Watermark).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InRoom: ").Append(InRoom).Append("\n");
            sb.Append("  QuotaLimit: ").Append(QuotaLimit).Append("\n");
            sb.Append("  IsCustomQuota: ").Append(IsCustomQuota).Append("\n");
            sb.Append("  UsedSpace: ").Append(UsedSpace).Append("\n");
            sb.Append("  PasswordProtected: ").Append(PasswordProtected).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  ChatSettings: ").Append(ChatSettings).Append("\n");
            sb.Append("  RootRoomType: ").Append(RootRoomType).Append("\n");
            sb.Append("  SaveFormAsXLSX: ").Append(SaveFormAsXLSX).Append("\n");
            sb.Append("  SendFormToExternalDB: ").Append(SendFormToExternalDB).Append("\n");
            sb.Append("  OriginalFormId: ").Append(OriginalFormId).Append("\n");
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
