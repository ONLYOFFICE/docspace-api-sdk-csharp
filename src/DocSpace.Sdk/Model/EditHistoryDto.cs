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
using FileParameter = DocSpace.Sdk.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Sdk.Client.OpenAPIDateConverter;

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The file editing history parameters.
    /// </summary>
    [DataContract(Name = "EditHistoryDto")]
    public partial class EditHistoryDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryDto" /> class.
        /// </summary>
        /// <param name="id">The document ID..</param>
        /// <param name="key">The document identifier used to unambiguously identify the document file..</param>
        /// <param name="varVersion">The document version number..</param>
        /// <param name="versionGroup">The document version group..</param>
        /// <param name="user">user.</param>
        /// <param name="created">created.</param>
        /// <param name="changesHistory">The file history changes in the string format..</param>
        /// <param name="changes">The list of file history changes..</param>
        /// <param name="serverVersion">The current server version number..</param>
        public EditHistoryDto(int id = default, string key = default, int varVersion = default, int versionGroup = default, EditHistoryAuthor user = default, ApiDateTime created = default, string changesHistory = default, List<EditHistoryChangesWrapper> changes = default, string serverVersion = default)
        {
            this.Id = id;
            this.Key = key;
            this.VarVersion = varVersion;
            this.VersionGroup = versionGroup;
            this.User = user;
            this.Created = created;
            this.ChangesHistory = changesHistory;
            this.Changes = changes;
            this.ServerVersion = serverVersion;
        }

        /// <summary>
        /// The document ID.
        /// </summary>
        /// <value>The document ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The document identifier used to unambiguously identify the document file.
        /// </summary>
        /// <value>The document identifier used to unambiguously identify the document file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The document version number.
        /// </summary>
        /// <value>The document version number.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// The document version group.
        /// </summary>
        /// <value>The document version group.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "versionGroup", EmitDefaultValue = false)]
        public int VersionGroup { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public EditHistoryAuthor User { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public ApiDateTime Created { get; set; }

        /// <summary>
        /// The file history changes in the string format.
        /// </summary>
        /// <value>The file history changes in the string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "changesHistory", EmitDefaultValue = true)]
        public string ChangesHistory { get; set; }

        /// <summary>
        /// The list of file history changes.
        /// </summary>
        /// <value>The list of file history changes.</value>
        [DataMember(Name = "changes", EmitDefaultValue = true)]
        public List<EditHistoryChangesWrapper> Changes { get; set; }

        /// <summary>
        /// The current server version number.
        /// </summary>
        /// <value>The current server version number.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "serverVersion", EmitDefaultValue = true)]
        public string ServerVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EditHistoryDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  VersionGroup: ").Append(VersionGroup).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  ChangesHistory: ").Append(ChangesHistory).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
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
