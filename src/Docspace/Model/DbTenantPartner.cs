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
    /// The database tenant partner parameters.
    /// </summary>
    [DataContract(Name = "DbTenantPartner")]
    public partial class DbTenantPartner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DbTenantPartner" /> class.
        /// </summary>
        /// <param name="tenantId">The tenant ID..</param>
        /// <param name="partnerId">The partner ID..</param>
        /// <param name="affiliateId">The affiliate ID..</param>
        /// <param name="campaign">The tenant partner campaign..</param>
        public DbTenantPartner(int tenantId = default, string partnerId = default, string affiliateId = default, string campaign = default)
        {
            this.TenantId = tenantId;
            this.PartnerId = partnerId;
            this.AffiliateId = affiliateId;
            this.Campaign = campaign;
        }

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
        /// The partner ID.
        /// </summary>
        /// <value>The partner ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "partnerId", EmitDefaultValue = true)]
        public string PartnerId { get; set; }

        /// <summary>
        /// The affiliate ID.
        /// </summary>
        /// <value>The affiliate ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "affiliateId", EmitDefaultValue = true)]
        public string AffiliateId { get; set; }

        /// <summary>
        /// The tenant partner campaign.
        /// </summary>
        /// <value>The tenant partner campaign.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "campaign", EmitDefaultValue = true)]
        public string Campaign { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DbTenantPartner {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  AffiliateId: ").Append(AffiliateId).Append("\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
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
            // PartnerId (string) maxLength
            if (this.PartnerId != null && this.PartnerId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PartnerId, length must be less than 36.", new [] { "PartnerId" });
            }

            // AffiliateId (string) maxLength
            if (this.AffiliateId != null && this.AffiliateId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AffiliateId, length must be less than 50.", new [] { "AffiliateId" });
            }

            // Campaign (string) maxLength
            if (this.Campaign != null && this.Campaign.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Campaign, length must be less than 50.", new [] { "Campaign" });
            }

            yield break;
        }
    }


}
