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
    /// The payment settings parameters.
    /// </summary>
    [DataContract(Name = "PaymentSettingsDto")]
    public partial class PaymentSettingsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSettingsDto" /> class.
        /// </summary>
        /// <param name="salesEmail">The email address for sales inquiries and support..</param>
        /// <param name="feedbackAndSupportUrl">The URL for accessing the feedback and support resources..</param>
        /// <param name="buyUrl">The URL for purchasing or upgrading the product..</param>
        /// <param name="standalone">Indicates whether the system is running in standalone mode..</param>
        /// <param name="currentLicense">currentLicense.</param>
        /// <param name="max">The maximum quota quantity..</param>
        public PaymentSettingsDto(string salesEmail = default, string feedbackAndSupportUrl = default, string buyUrl = default, bool standalone = default, CurrentLicenseInfo currentLicense = default, int max = default)
        {
            this.SalesEmail = salesEmail;
            this.FeedbackAndSupportUrl = feedbackAndSupportUrl;
            this.BuyUrl = buyUrl;
            this.Standalone = standalone;
            this.CurrentLicense = currentLicense;
            this.Max = max;
        }

        /// <summary>
        /// The email address for sales inquiries and support.
        /// </summary>
        /// <value>The email address for sales inquiries and support.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "salesEmail", EmitDefaultValue = true)]
        public string SalesEmail { get; set; }

        /// <summary>
        /// The URL for accessing the feedback and support resources.
        /// </summary>
        /// <value>The URL for accessing the feedback and support resources.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "feedbackAndSupportUrl", EmitDefaultValue = true)]
        public string FeedbackAndSupportUrl { get; set; }

        /// <summary>
        /// The URL for purchasing or upgrading the product.
        /// </summary>
        /// <value>The URL for purchasing or upgrading the product.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "buyUrl", EmitDefaultValue = true)]
        public string BuyUrl { get; set; }

        /// <summary>
        /// Indicates whether the system is running in standalone mode.
        /// </summary>
        /// <value>Indicates whether the system is running in standalone mode.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "standalone", EmitDefaultValue = true)]
        public bool Standalone { get; set; }

        /// <summary>
        /// Gets or Sets CurrentLicense
        /// </summary>
        [DataMember(Name = "currentLicense", EmitDefaultValue = false)]
        public CurrentLicenseInfo CurrentLicense { get; set; }

        /// <summary>
        /// The maximum quota quantity.
        /// </summary>
        /// <value>The maximum quota quantity.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public int Max { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentSettingsDto {\n");
            sb.Append("  SalesEmail: ").Append(SalesEmail).Append("\n");
            sb.Append("  FeedbackAndSupportUrl: ").Append(FeedbackAndSupportUrl).Append("\n");
            sb.Append("  BuyUrl: ").Append(BuyUrl).Append("\n");
            sb.Append("  Standalone: ").Append(Standalone).Append("\n");
            sb.Append("  CurrentLicense: ").Append(CurrentLicense).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
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
