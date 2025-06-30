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
using FileParameter = DocSpace.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Client.OpenAPIDateConverter;

namespace DocSpace.Model
{
    /// <summary>
    /// The room quota settings.
    /// </summary>
    [DataContract(Name = "TenantRoomQuotaSettings")]
    public partial class TenantRoomQuotaSettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantRoomQuotaSettings" /> class.
        /// </summary>
        /// <param name="enableQuota">Specifies if the quota is enabled for the tenant entity or not..</param>
        /// <param name="defaultQuota">The default quota of the tenant entity..</param>
        /// <param name="lastRecalculateDate">The date of the last quota recalculation..</param>
        /// <param name="lastModified">lastModified.</param>
        public TenantRoomQuotaSettings(bool enableQuota = default, long defaultQuota = default, DateTime? lastRecalculateDate = default, DateTime lastModified = default)
        {
            this.EnableQuota = enableQuota;
            this.DefaultQuota = defaultQuota;
            this.LastRecalculateDate = lastRecalculateDate;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Specifies if the quota is enabled for the tenant entity or not.
        /// </summary>
        /// <value>Specifies if the quota is enabled for the tenant entity or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enableQuota", EmitDefaultValue = true)]
        public bool EnableQuota { get; set; }

        /// <summary>
        /// The default quota of the tenant entity.
        /// </summary>
        /// <value>The default quota of the tenant entity.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "defaultQuota", EmitDefaultValue = false)]
        public long DefaultQuota { get; set; }

        /// <summary>
        /// The date of the last quota recalculation.
        /// </summary>
        /// <value>The date of the last quota recalculation.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastRecalculateDate", EmitDefaultValue = true)]
        public DateTime? LastRecalculateDate { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantRoomQuotaSettings {\n");
            sb.Append("  EnableQuota: ").Append(EnableQuota).Append("\n");
            sb.Append("  DefaultQuota: ").Append(DefaultQuota).Append("\n");
            sb.Append("  LastRecalculateDate: ").Append(LastRecalculateDate).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
