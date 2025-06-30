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
    /// The SSO portal settings.
    /// </summary>
    [DataContract(Name = "SsoSettingsV2")]
    public partial class SsoSettingsV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoSettingsV2" /> class.
        /// </summary>
        /// <param name="lastModified">lastModified.</param>
        /// <param name="enableSso">Specifies if the SSO settings are enabled or not..</param>
        /// <param name="idpSettings">idpSettings.</param>
        /// <param name="idpCertificates">The list of the IdP certificates..</param>
        /// <param name="idpCertificateAdvanced">idpCertificateAdvanced.</param>
        /// <param name="spLoginLabel">The SP login label..</param>
        /// <param name="spCertificates">The list of the SP certificates..</param>
        /// <param name="spCertificateAdvanced">spCertificateAdvanced.</param>
        /// <param name="fieldMapping">fieldMapping.</param>
        /// <param name="hideAuthPage">Specifies if the authentication page will be hidden or not..</param>
        /// <param name="usersType">The user type..</param>
        /// <param name="disableEmailVerification">Specifies if the email verification is disabled or not..</param>
        public SsoSettingsV2(DateTime lastModified = default, bool? enableSso = default, SsoIdpSettings idpSettings = default, List<SsoCertificate> idpCertificates = default, SsoIdpCertificateAdvanced idpCertificateAdvanced = default, string spLoginLabel = default, List<SsoCertificate> spCertificates = default, SsoSpCertificateAdvanced spCertificateAdvanced = default, SsoFieldMapping fieldMapping = default, bool hideAuthPage = default, int usersType = default, bool disableEmailVerification = default)
        {
            this.LastModified = lastModified;
            this.EnableSso = enableSso;
            this.IdpSettings = idpSettings;
            this.IdpCertificates = idpCertificates;
            this.IdpCertificateAdvanced = idpCertificateAdvanced;
            this.SpLoginLabel = spLoginLabel;
            this.SpCertificates = spCertificates;
            this.SpCertificateAdvanced = spCertificateAdvanced;
            this.FieldMapping = fieldMapping;
            this.HideAuthPage = hideAuthPage;
            this.UsersType = usersType;
            this.DisableEmailVerification = disableEmailVerification;
        }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Specifies if the SSO settings are enabled or not.
        /// </summary>
        /// <value>Specifies if the SSO settings are enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enableSso", EmitDefaultValue = true)]
        public bool? EnableSso { get; set; }

        /// <summary>
        /// Gets or Sets IdpSettings
        /// </summary>
        [DataMember(Name = "idpSettings", EmitDefaultValue = false)]
        public SsoIdpSettings IdpSettings { get; set; }

        /// <summary>
        /// The list of the IdP certificates.
        /// </summary>
        /// <value>The list of the IdP certificates.</value>
        [DataMember(Name = "idpCertificates", EmitDefaultValue = true)]
        public List<SsoCertificate> IdpCertificates { get; set; }

        /// <summary>
        /// Gets or Sets IdpCertificateAdvanced
        /// </summary>
        [DataMember(Name = "idpCertificateAdvanced", EmitDefaultValue = false)]
        public SsoIdpCertificateAdvanced IdpCertificateAdvanced { get; set; }

        /// <summary>
        /// The SP login label.
        /// </summary>
        /// <value>The SP login label.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "spLoginLabel", EmitDefaultValue = true)]
        public string SpLoginLabel { get; set; }

        /// <summary>
        /// The list of the SP certificates.
        /// </summary>
        /// <value>The list of the SP certificates.</value>
        [DataMember(Name = "spCertificates", EmitDefaultValue = true)]
        public List<SsoCertificate> SpCertificates { get; set; }

        /// <summary>
        /// Gets or Sets SpCertificateAdvanced
        /// </summary>
        [DataMember(Name = "spCertificateAdvanced", EmitDefaultValue = false)]
        public SsoSpCertificateAdvanced SpCertificateAdvanced { get; set; }

        /// <summary>
        /// Gets or Sets FieldMapping
        /// </summary>
        [DataMember(Name = "fieldMapping", EmitDefaultValue = false)]
        public SsoFieldMapping FieldMapping { get; set; }

        /// <summary>
        /// Specifies if the authentication page will be hidden or not.
        /// </summary>
        /// <value>Specifies if the authentication page will be hidden or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "hideAuthPage", EmitDefaultValue = true)]
        public bool HideAuthPage { get; set; }

        /// <summary>
        /// The user type.
        /// </summary>
        /// <value>The user type.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "usersType", EmitDefaultValue = false)]
        public int UsersType { get; set; }

        /// <summary>
        /// Specifies if the email verification is disabled or not.
        /// </summary>
        /// <value>Specifies if the email verification is disabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "disableEmailVerification", EmitDefaultValue = true)]
        public bool DisableEmailVerification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SsoSettingsV2 {\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  EnableSso: ").Append(EnableSso).Append("\n");
            sb.Append("  IdpSettings: ").Append(IdpSettings).Append("\n");
            sb.Append("  IdpCertificates: ").Append(IdpCertificates).Append("\n");
            sb.Append("  IdpCertificateAdvanced: ").Append(IdpCertificateAdvanced).Append("\n");
            sb.Append("  SpLoginLabel: ").Append(SpLoginLabel).Append("\n");
            sb.Append("  SpCertificates: ").Append(SpCertificates).Append("\n");
            sb.Append("  SpCertificateAdvanced: ").Append(SpCertificateAdvanced).Append("\n");
            sb.Append("  FieldMapping: ").Append(FieldMapping).Append("\n");
            sb.Append("  HideAuthPage: ").Append(HideAuthPage).Append("\n");
            sb.Append("  UsersType: ").Append(UsersType).Append("\n");
            sb.Append("  DisableEmailVerification: ").Append(DisableEmailVerification).Append("\n");
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
