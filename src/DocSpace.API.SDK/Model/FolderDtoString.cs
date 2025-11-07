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
    /// The folder parameters.
    /// </summary>
    [DataContract(Name = "FolderDtoString")]
    public partial class FolderDtoString : FileEntryDtoString, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RoomType
        /// </summary>
        [DataMember(Name = "roomType", EmitDefaultValue = false)]
        public RoomType? RoomType { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public FolderType? Type { get; set; }

        /// <summary>
        /// Gets or Sets RootRoomType
        /// </summary>
        [DataMember(Name = "rootRoomType", EmitDefaultValue = false)]
        public RoomType? RootRoomType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderDtoString" /> class.
        /// </summary>
        /// <param name="parentId">The parent folder ID of the folder..</param>
        /// <param name="filesCount">The number of files that the folder contains..</param>
        /// <param name="foldersCount">The number of folders that the folder contains..</param>
        /// <param name="isShareable">Specifies if the folder can be shared or not..</param>
        /// <param name="@new">The new element index in the folder..</param>
        /// <param name="mute">Specifies if the folder notifications are enabled or not..</param>
        /// <param name="tags">The list of tags of the folder..</param>
        /// <param name="logo">logo.</param>
        /// <param name="pinned">Specifies if the folder is pinned or not..</param>
        /// <param name="roomType">roomType.</param>
        /// <param name="@private">Specifies if the folder is private or not..</param>
        /// <param name="indexing">Specifies if the folder is indexed or not..</param>
        /// <param name="denyDownload">Specifies if the folder can be downloaded or not..</param>
        /// <param name="lifetime">lifetime.</param>
        /// <param name="watermark">watermark.</param>
        /// <param name="type">type.</param>
        /// <param name="inRoom">Specifies if the folder is placed in the room or not..</param>
        /// <param name="quotaLimit">The folder quota limit..</param>
        /// <param name="isCustomQuota">Specifies if the folder room has a custom quota or not..</param>
        /// <param name="usedSpace">How much folder space is used (counter)..</param>
        /// <param name="passwordProtected">Specifies if the folder is password protected or not..</param>
        /// <param name="expired">Specifies if an external link to the folder is expired or not..</param>
        /// <param name="chatSettings">chatSettings.</param>
        /// <param name="rootRoomType">rootRoomType.</param>
        public FolderDtoString(string parentId = default, int filesCount = default, int foldersCount = default, bool? isShareable = default, int @new = default, bool mute = default, List<string> tags = default, Logo logo = default, bool pinned = default, RoomType? roomType = default, bool @private = default, bool indexing = default, bool denyDownload = default, RoomDataLifetimeDto lifetime = default, WatermarkDto watermark = default, FolderType? type = default, bool? inRoom = default, long? quotaLimit = default, bool? isCustomQuota = default, long? usedSpace = default, bool? passwordProtected = default, bool? expired = default, ChatSettings chatSettings = default, RoomType? rootRoomType = default)
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
        }

        /// <summary>
        /// The parent folder ID of the folder.
        /// </summary>
        /// <value>The parent folder ID of the folder.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "parentId", EmitDefaultValue = true)]
        public string ParentId { get; set; }

        /// <summary>
        /// The number of files that the folder contains.
        /// </summary>
        /// <value>The number of files that the folder contains.</value>
        /*
        <example>5</example>
        */
        [DataMember(Name = "filesCount", EmitDefaultValue = false)]
        public int FilesCount { get; set; }

        /// <summary>
        /// The number of folders that the folder contains.
        /// </summary>
        /// <value>The number of folders that the folder contains.</value>
        /*
        <example>7</example>
        */
        [DataMember(Name = "foldersCount", EmitDefaultValue = false)]
        public int FoldersCount { get; set; }

        /// <summary>
        /// Specifies if the folder can be shared or not.
        /// </summary>
        /// <value>Specifies if the folder can be shared or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isShareable", EmitDefaultValue = true)]
        public bool? IsShareable { get; set; }

        /// <summary>
        /// The new element index in the folder.
        /// </summary>
        /// <value>The new element index in the folder.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "new", EmitDefaultValue = false)]
        public int New { get; set; }

        /// <summary>
        /// Specifies if the folder notifications are enabled or not.
        /// </summary>
        /// <value>Specifies if the folder notifications are enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "mute", EmitDefaultValue = true)]
        public bool Mute { get; set; }

        /// <summary>
        /// The list of tags of the folder.
        /// </summary>
        /// <value>The list of tags of the folder.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public Logo Logo { get; set; }

        /// <summary>
        /// Specifies if the folder is pinned or not.
        /// </summary>
        /// <value>Specifies if the folder is pinned or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "pinned", EmitDefaultValue = true)]
        public bool Pinned { get; set; }

        /// <summary>
        /// Specifies if the folder is private or not.
        /// </summary>
        /// <value>Specifies if the folder is private or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private { get; set; }

        /// <summary>
        /// Specifies if the folder is indexed or not.
        /// </summary>
        /// <value>Specifies if the folder is indexed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool Indexing { get; set; }

        /// <summary>
        /// Specifies if the folder can be downloaded or not.
        /// </summary>
        /// <value>Specifies if the folder can be downloaded or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// Gets or Sets Lifetime
        /// </summary>
        [DataMember(Name = "lifetime", EmitDefaultValue = false)]
        public RoomDataLifetimeDto Lifetime { get; set; }

        /// <summary>
        /// Gets or Sets Watermark
        /// </summary>
        [DataMember(Name = "watermark", EmitDefaultValue = false)]
        public WatermarkDto Watermark { get; set; }

        /// <summary>
        /// Specifies if the folder is placed in the room or not.
        /// </summary>
        /// <value>Specifies if the folder is placed in the room or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "inRoom", EmitDefaultValue = true)]
        public bool? InRoom { get; set; }

        /// <summary>
        /// The folder quota limit.
        /// </summary>
        /// <value>The folder quota limit.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "quotaLimit", EmitDefaultValue = true)]
        public long? QuotaLimit { get; set; }

        /// <summary>
        /// Specifies if the folder room has a custom quota or not.
        /// </summary>
        /// <value>Specifies if the folder room has a custom quota or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isCustomQuota", EmitDefaultValue = true)]
        public bool? IsCustomQuota { get; set; }

        /// <summary>
        /// How much folder space is used (counter).
        /// </summary>
        /// <value>How much folder space is used (counter).</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "usedSpace", EmitDefaultValue = true)]
        public long? UsedSpace { get; set; }

        /// <summary>
        /// Specifies if the folder is password protected or not.
        /// </summary>
        /// <value>Specifies if the folder is password protected or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "passwordProtected", EmitDefaultValue = true)]
        public bool? PasswordProtected { get; set; }

        /// <summary>
        /// Specifies if an external link to the folder is expired or not.
        /// </summary>
        /// <value>Specifies if an external link to the folder is expired or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "expired", EmitDefaultValue = true)]
        [Obsolete]
        public bool? Expired { get; set; }

        /// <summary>
        /// Gets or Sets ChatSettings
        /// </summary>
        [DataMember(Name = "chatSettings", EmitDefaultValue = false)]
        public ChatSettings ChatSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderDtoString {\n");
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
