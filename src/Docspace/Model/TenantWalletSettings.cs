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
    /// TenantWalletSettings
    /// </summary>
    [DataContract(Name = "TenantWalletSettings")]
    public partial class TenantWalletSettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantWalletSettings" /> class.
        /// </summary>
        /// <param name="enabled">Enabled.</param>
        /// <param name="minBalance">Minimun balance.</param>
        /// <param name="upToBalance">Up to balance.</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol..</param>
        /// <param name="lastModified">lastModified.</param>
        public TenantWalletSettings(bool enabled = default, int minBalance = default, int upToBalance = default, string currency = default, DateTime lastModified = default)
        {
            this.Enabled = enabled;
            this.MinBalance = minBalance;
            this.UpToBalance = upToBalance;
            this.Currency = currency;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Enabled
        /// </summary>
        /// <value>Enabled</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Minimun balance
        /// </summary>
        /// <value>Minimun balance</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "minBalance", EmitDefaultValue = false)]
        public int MinBalance { get; set; }

        /// <summary>
        /// Up to balance
        /// </summary>
        /// <value>Up to balance</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "upToBalance", EmitDefaultValue = false)]
        public int UpToBalance { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol.
        /// </summary>
        /// <value>The three-character ISO 4217 currency symbol.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

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
            sb.Append("class TenantWalletSettings {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MinBalance: ").Append(MinBalance).Append("\n");
            sb.Append("  UpToBalance: ").Append(UpToBalance).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            // MinBalance (int) maximum
            if (this.MinBalance > (int)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinBalance, must be a value less than or equal to 1000.", new [] { "MinBalance" });
            }

            // MinBalance (int) minimum
            if (this.MinBalance < (int)5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinBalance, must be a value greater than or equal to 5.", new [] { "MinBalance" });
            }

            // UpToBalance (int) maximum
            if (this.UpToBalance > (int)5000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UpToBalance, must be a value less than or equal to 5000.", new [] { "UpToBalance" });
            }

            // UpToBalance (int) minimum
            if (this.UpToBalance < (int)6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UpToBalance, must be a value greater than or equal to 6.", new [] { "UpToBalance" });
            }

            yield break;
        }
    }


}
