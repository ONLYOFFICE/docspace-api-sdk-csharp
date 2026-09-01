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
    /// The file entry information.
    /// </summary>
    [DataContract(Name = "AiFileEntryBaseDto")]
    public partial class AiFileEntryBaseDto : IValidatableObject
    {

        /// <summary>
        /// The access rights to the file entry.
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public AiFileShare? Access { get; set; }

        /// <summary>
        /// The root folder type of the file entry.
        /// </summary>
        [DataMember(Name = "rootFolderType", EmitDefaultValue = false)]
        public AiFolderType? RootFolderType { get; set; }

        /// <summary>
        /// The parent room type of the file entry.
        /// </summary>
        [DataMember(Name = "parentRoomType", EmitDefaultValue = false)]
        public AiFolderType? ParentRoomType { get; set; }

        /// <summary>
        /// The file entry type.
        /// </summary>
        [DataMember(Name = "fileEntryType", EmitDefaultValue = false)]
        public AiFileEntryType? FileEntryType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiFileEntryBaseDto" /> class.
        /// </summary>
        /// <param name="title">The file entry title..</param>
        /// <param name="access">The access rights to the file entry..</param>
        /// <param name="sharedBy">Provides information about the employee who shared the file or folder..</param>
        /// <param name="ownedBy">The information about the employee who owns the file entry..</param>
        /// <param name="shared">Specifies if the file entry is shared via link or not..</param>
        /// <param name="sharedForUser">Specifies if the file entry is shared for user or not..</param>
        /// <param name="sharedExternal">Specifies if the file entry is shared via a public (non-internal) external link..</param>
        /// <param name="parentShared">Indicates whether the parent entity is shared..</param>
        /// <param name="shortWebUrl">The short Web URL..</param>
        /// <param name="created">The creation date and time of the file entry..</param>
        /// <param name="createdBy">The file entry author..</param>
        /// <param name="updated">The last date and time when the file entry was updated..</param>
        /// <param name="autoDelete">The date and time when the file entry will be automatically deleted..</param>
        /// <param name="rootFolderType">The root folder type of the file entry..</param>
        /// <param name="parentRoomType">The parent room type of the file entry..</param>
        /// <param name="updatedBy">The user who updated the file entry..</param>
        /// <param name="providerItem">Specifies if the file entry provider is specified or not..</param>
        /// <param name="providerKey">The provider key of the file entry..</param>
        /// <param name="providerId">The provider ID of the file entry..</param>
        /// <param name="order">The order of the file entry..</param>
        /// <param name="isFavorite">Specifies if the file is a favorite or not..</param>
        /// <param name="fileEntryType">The file entry type..</param>
        public AiFileEntryBaseDto(string title = default, AiFileShare? access = default, AiEmployeeDto sharedBy = default, AiEmployeeDto ownedBy = default, bool shared = default, bool sharedForUser = default, bool sharedExternal = default, bool parentShared = default, string shortWebUrl = default, DateTime? created = default, AiEmployeeDto createdBy = default, DateTime? updated = default, DateTime? autoDelete = default, AiFolderType? rootFolderType = default, AiFolderType? parentRoomType = default, AiEmployeeDto updatedBy = default, bool? providerItem = default, string providerKey = default, int? providerId = default, string order = default, bool? isFavorite = default, AiFileEntryType? fileEntryType = default)
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
        /// The file entry title.
        /// </summary>
        /// <example>Some title.txt</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Provides information about the employee who shared the file or folder.
        /// </summary>
        [DataMember(Name = "sharedBy", EmitDefaultValue = false)]
        public AiEmployeeDto SharedBy { get; set; }

        /// <summary>
        /// The information about the employee who owns the file entry.
        /// </summary>
        [DataMember(Name = "ownedBy", EmitDefaultValue = false)]
        public AiEmployeeDto OwnedBy { get; set; }

        /// <summary>
        /// Specifies if the file entry is shared via link or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool Shared { get; set; }

        /// <summary>
        /// Specifies if the file entry is shared for user or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "sharedForUser", EmitDefaultValue = true)]
        public bool SharedForUser { get; set; }

        /// <summary>
        /// Specifies if the file entry is shared via a public (non-internal) external link.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "sharedExternal", EmitDefaultValue = true)]
        public bool SharedExternal { get; set; }

        /// <summary>
        /// Indicates whether the parent entity is shared.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "parentShared", EmitDefaultValue = true)]
        public bool ParentShared { get; set; }

        /// <summary>
        /// The short Web URL.
        /// </summary>
        /// <example>http://localhost/s/abc123</example>
        [DataMember(Name = "shortWebUrl", EmitDefaultValue = true)]
        public string ShortWebUrl { get; set; }

        /// <summary>
        /// The creation date and time of the file entry.
        /// </summary>
        /// <example>2021-01-01T00:00:00Z</example>
        [DataMember(Name = "created", EmitDefaultValue = true)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// The file entry author.
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public AiEmployeeDto CreatedBy { get; set; }

        /// <summary>
        /// The last date and time when the file entry was updated.
        /// </summary>
        /// <example>2021-01-01T00:00:00Z</example>
        [DataMember(Name = "updated", EmitDefaultValue = true)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The date and time when the file entry will be automatically deleted.
        /// </summary>
        /// <example>2021-01-01T00:00:00Z</example>
        [DataMember(Name = "autoDelete", EmitDefaultValue = true)]
        public DateTime? AutoDelete { get; set; }

        /// <summary>
        /// The user who updated the file entry.
        /// </summary>
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public AiEmployeeDto UpdatedBy { get; set; }

        /// <summary>
        /// Specifies if the file entry provider is specified or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "providerItem", EmitDefaultValue = true)]
        public bool? ProviderItem { get; set; }

        /// <summary>
        /// The provider key of the file entry.
        /// </summary>
        /// <example>google-drive</example>
        [DataMember(Name = "providerKey", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// The provider ID of the file entry.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "providerId", EmitDefaultValue = true)]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The order of the file entry.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public string Order { get; set; }

        /// <summary>
        /// Specifies if the file is a favorite or not.
        /// </summary>
        /// <example>false</example>
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
