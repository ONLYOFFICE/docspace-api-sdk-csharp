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
    /// The file entry information.
    /// </summary>
    [DataContract(Name = "FileEntryBaseDto")]
    public partial class FileEntryBaseDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }

        /// <summary>
        /// Gets or Sets RootFolderType
        /// </summary>
        [DataMember(Name = "rootFolderType", EmitDefaultValue = false)]
        public FolderType? RootFolderType { get; set; }

        /// <summary>
        /// Gets or Sets ParentRoomType
        /// </summary>
        [DataMember(Name = "parentRoomType", EmitDefaultValue = false)]
        public FolderType? ParentRoomType { get; set; }

        /// <summary>
        /// Gets or Sets FileEntryType
        /// </summary>
        [DataMember(Name = "fileEntryType", EmitDefaultValue = false)]
        public FileEntryType? FileEntryType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileEntryBaseDto" /> class.
        /// </summary>
        /// <param name="title">The file entry title..</param>
        /// <param name="access">access.</param>
        /// <param name="shared">Specifies if the file entry is shared or not..</param>
        /// <param name="created">created.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updated">updated.</param>
        /// <param name="autoDelete">autoDelete.</param>
        /// <param name="rootFolderType">rootFolderType.</param>
        /// <param name="parentRoomType">parentRoomType.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="providerItem">Specifies if the file entry provider is specified or not..</param>
        /// <param name="providerKey">The provider key of the file entry..</param>
        /// <param name="providerId">The provider ID of the file entry..</param>
        /// <param name="order">The order of the file entry..</param>
        /// <param name="fileEntryType">fileEntryType.</param>
        public FileEntryBaseDto(string title = default, FileShare? access = default, bool shared = default, ApiDateTime created = default, EmployeeDto createdBy = default, ApiDateTime updated = default, ApiDateTime autoDelete = default, FolderType? rootFolderType = default, FolderType? parentRoomType = default, EmployeeDto updatedBy = default, bool? providerItem = default, string providerKey = default, int? providerId = default, string order = default, FileEntryType? fileEntryType = default)
        {
            this.Title = title;
            this.Access = access;
            this.Shared = shared;
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
            this.FileEntryType = fileEntryType;
        }

        /// <summary>
        /// The file entry title.
        /// </summary>
        /// <value>The file entry title.</value>
        /*
        <example>Some titile.txt/ Some title</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Specifies if the file entry is shared or not.
        /// </summary>
        /// <value>Specifies if the file entry is shared or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool Shared { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public ApiDateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public EmployeeDto CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public ApiDateTime Updated { get; set; }

        /// <summary>
        /// Gets or Sets AutoDelete
        /// </summary>
        [DataMember(Name = "autoDelete", EmitDefaultValue = false)]
        public ApiDateTime AutoDelete { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public EmployeeDto UpdatedBy { get; set; }

        /// <summary>
        /// Specifies if the file entry provider is specified or not.
        /// </summary>
        /// <value>Specifies if the file entry provider is specified or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "providerItem", EmitDefaultValue = true)]
        public bool? ProviderItem { get; set; }

        /// <summary>
        /// The provider key of the file entry.
        /// </summary>
        /// <value>The provider key of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "providerKey", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// The provider ID of the file entry.
        /// </summary>
        /// <value>The provider ID of the file entry.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "providerId", EmitDefaultValue = true)]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The order of the file entry.
        /// </summary>
        /// <value>The order of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public string Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileEntryBaseDto {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
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
