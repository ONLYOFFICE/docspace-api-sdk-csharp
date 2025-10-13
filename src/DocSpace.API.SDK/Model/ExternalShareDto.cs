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
    /// The external sharing information and validation data.
    /// </summary>
    [DataContract(Name = "ExternalShareDto")]
    public partial class ExternalShareDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public FileEntryType? Type { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
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
        /// <param name="status">status (required).</param>
        /// <param name="id">The external data ID. (required).</param>
        /// <param name="title">The external data title. (required).</param>
        /// <param name="type">type.</param>
        /// <param name="tenantId">The tenant ID. (required).</param>
        /// <param name="entityId">The unique identifier of the shared entity..</param>
        /// <param name="entityTitle">The title of the shared entity..</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="isRoom">Indicates whether the entity represents a room..</param>
        /// <param name="shared">Specifies whether to share the external data or not. (required).</param>
        /// <param name="linkId">The link ID of the external data. (required).</param>
        /// <param name="isAuthenticated">Specifies whether the user is authenticated or not. (required).</param>
        /// <param name="isRoomMember">The room ID of the external data..</param>
        public ExternalShareDto(Status status = default, string id = default, string title = default, FileEntryType? type = default, int tenantId = default, string entityId = default, string entityTitle = default, FileEntryType? entityType = default, bool? isRoom = default, bool shared = default, Guid linkId = default, bool isAuthenticated = default, bool isRoomMember = default)
        {
            this.Status = status;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ExternalShareDto and cannot be null");
            }
            this.Id = id;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for ExternalShareDto and cannot be null");
            }
            this.Title = title;
            this.TenantId = tenantId;
            this.Shared = shared;
            this.LinkId = linkId;
            this.IsAuthenticated = isAuthenticated;
            this.Type = type;
            this.EntityId = entityId;
            this.EntityTitle = entityTitle;
            this.EntityType = entityType;
            this.IsRoom = isRoom;
            this.IsRoomMember = isRoomMember;
        }

        /// <summary>
        /// The external data ID.
        /// </summary>
        /// <value>The external data ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The external data title.
        /// </summary>
        /// <value>The external data title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The tenant ID.
        /// </summary>
        /// <value>The tenant ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public int TenantId { get; set; }

        /// <summary>
        /// The unique identifier of the shared entity.
        /// </summary>
        /// <value>The unique identifier of the shared entity.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "entityId", EmitDefaultValue = true)]
        public string EntityId { get; set; }

        /// <summary>
        /// The title of the shared entity.
        /// </summary>
        /// <value>The title of the shared entity.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "entityTitle", EmitDefaultValue = true)]
        public string EntityTitle { get; set; }

        /// <summary>
        /// Indicates whether the entity represents a room.
        /// </summary>
        /// <value>Indicates whether the entity represents a room.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isRoom", EmitDefaultValue = true)]
        public bool? IsRoom { get; set; }

        /// <summary>
        /// Specifies whether to share the external data or not.
        /// </summary>
        /// <value>Specifies whether to share the external data or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "shared", IsRequired = true, EmitDefaultValue = true)]
        public bool Shared { get; set; }

        /// <summary>
        /// The link ID of the external data.
        /// </summary>
        /// <value>The link ID of the external data.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "linkId", IsRequired = true, EmitDefaultValue = true)]
        public Guid LinkId { get; set; }

        /// <summary>
        /// Specifies whether the user is authenticated or not.
        /// </summary>
        /// <value>Specifies whether the user is authenticated or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isAuthenticated", IsRequired = true, EmitDefaultValue = true)]
        public bool IsAuthenticated { get; set; }

        /// <summary>
        /// The room ID of the external data.
        /// </summary>
        /// <value>The room ID of the external data.</value>
        /*
        <example>true</example>
        */
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
