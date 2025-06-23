// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
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
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public Status? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalShareDto" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="id">The external data ID..</param>
        /// <param name="title">The external data title..</param>
        /// <param name="tenantId">The tenant ID..</param>
        /// <param name="entityId">The unique identifier of the shared entity..</param>
        /// <param name="entryTitle">The title of the shared entry..</param>
        /// <param name="shared">Specifies whether to share the external data or not..</param>
        /// <param name="linkId">The link ID of the external data..</param>
        /// <param name="isAuthenticated">Specifies whether the user is authenticated or not..</param>
        public ExternalShareDto(Status? status = default, string id = default, string title = default, int tenantId = default, string entityId = default, string entryTitle = default, bool shared = default, Guid linkId = default, bool isAuthenticated = default)
        {
            this.Status = status;
            this.Id = id;
            this.Title = title;
            this.TenantId = tenantId;
            this.EntityId = entityId;
            this.EntryTitle = entryTitle;
            this.Shared = shared;
            this.LinkId = linkId;
            this.IsAuthenticated = isAuthenticated;
        }

        /// <summary>
        /// The external data ID.
        /// </summary>
        /// <value>The external data ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The external data title.
        /// </summary>
        /// <value>The external data title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The tenant ID.
        /// </summary>
        /// <value>The tenant ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
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
        /// The title of the shared entry.
        /// </summary>
        /// <value>The title of the shared entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "entryTitle", EmitDefaultValue = true)]
        public string EntryTitle { get; set; }

        /// <summary>
        /// Specifies whether to share the external data or not.
        /// </summary>
        /// <value>Specifies whether to share the external data or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool Shared { get; set; }

        /// <summary>
        /// The link ID of the external data.
        /// </summary>
        /// <value>The link ID of the external data.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "linkId", EmitDefaultValue = false)]
        public Guid LinkId { get; set; }

        /// <summary>
        /// Specifies whether the user is authenticated or not.
        /// </summary>
        /// <value>Specifies whether the user is authenticated or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isAuthenticated", EmitDefaultValue = true)]
        public bool IsAuthenticated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExternalShareDto {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntryTitle: ").Append(EntryTitle).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  LinkId: ").Append(LinkId).Append("\n");
            sb.Append("  IsAuthenticated: ").Append(IsAuthenticated).Append("\n");
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
