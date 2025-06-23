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
    /// The request parameters for managing the user storage quota configurations.
    /// </summary>
    [DataContract(Name = "QuotaSettingsRequestsDto")]
    public partial class QuotaSettingsRequestsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotaSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="enableQuota">Specifies whether the storage quota restrictions are enabled..</param>
        /// <param name="defaultQuota">defaultQuota (required).</param>
        public QuotaSettingsRequestsDto(bool enableQuota = default, QuotaSettingsRequestsDtoDefaultQuota defaultQuota = default)
        {
            // to ensure "defaultQuota" is required (not null)
            if (defaultQuota == null)
            {
                throw new ArgumentNullException("defaultQuota is a required property for QuotaSettingsRequestsDto and cannot be null");
            }
            this.DefaultQuota = defaultQuota;
            this.EnableQuota = enableQuota;
        }

        /// <summary>
        /// Specifies whether the storage quota restrictions are enabled.
        /// </summary>
        /// <value>Specifies whether the storage quota restrictions are enabled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enableQuota", EmitDefaultValue = true)]
        public bool EnableQuota { get; set; }

        /// <summary>
        /// Gets or Sets DefaultQuota
        /// </summary>
        [DataMember(Name = "defaultQuota", IsRequired = true, EmitDefaultValue = true)]
        public QuotaSettingsRequestsDtoDefaultQuota DefaultQuota { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuotaSettingsRequestsDto {\n");
            sb.Append("  EnableQuota: ").Append(EnableQuota).Append("\n");
            sb.Append("  DefaultQuota: ").Append(DefaultQuota).Append("\n");
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
