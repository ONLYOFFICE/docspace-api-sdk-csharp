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
    /// The SSO certificate parameters.
    /// </summary>
    [DataContract(Name = "SsoCertificate")]
    public partial class SsoCertificate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoCertificate" /> class.
        /// </summary>
        /// <param name="selfSigned">Specifies if a certificate is self-signed or not..</param>
        /// <param name="crt">The CRT certificate file..</param>
        /// <param name="key">The certificate key..</param>
        /// <param name="action">The certificate action..</param>
        /// <param name="domainName">The certificate domain name..</param>
        /// <param name="startDate">The certificate start date..</param>
        /// <param name="expiredDate">The certificate expiration date..</param>
        public SsoCertificate(bool selfSigned = default, string crt = default, string key = default, string action = default, string domainName = default, DateTime startDate = default, DateTime expiredDate = default)
        {
            this.SelfSigned = selfSigned;
            this.Crt = crt;
            this.Key = key;
            this.Action = action;
            this.DomainName = domainName;
            this.StartDate = startDate;
            this.ExpiredDate = expiredDate;
        }

        /// <summary>
        /// Specifies if a certificate is self-signed or not.
        /// </summary>
        /// <value>Specifies if a certificate is self-signed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "selfSigned", EmitDefaultValue = true)]
        public bool SelfSigned { get; set; }

        /// <summary>
        /// The CRT certificate file.
        /// </summary>
        /// <value>The CRT certificate file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "crt", EmitDefaultValue = true)]
        public string Crt { get; set; }

        /// <summary>
        /// The certificate key.
        /// </summary>
        /// <value>The certificate key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The certificate action.
        /// </summary>
        /// <value>The certificate action.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// The certificate domain name.
        /// </summary>
        /// <value>The certificate domain name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "domainName", EmitDefaultValue = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// The certificate start date.
        /// </summary>
        /// <value>The certificate start date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The certificate expiration date.
        /// </summary>
        /// <value>The certificate expiration date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "expiredDate", EmitDefaultValue = false)]
        public DateTime ExpiredDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SsoCertificate {\n");
            sb.Append("  SelfSigned: ").Append(SelfSigned).Append("\n");
            sb.Append("  Crt: ").Append(Crt).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  ExpiredDate: ").Append(ExpiredDate).Append("\n");
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
