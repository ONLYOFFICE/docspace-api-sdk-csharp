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
    /// The request parameters for checking the document service location.
    /// </summary>
    [DataContract(Name = "CheckDocServiceUrlRequestDto")]
    public partial class CheckDocServiceUrlRequestDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckDocServiceUrlRequestDto" /> class.
        /// </summary>
        /// <param name="docServiceUrl">The ONLYOFFICE Docs URL address..</param>
        /// <param name="docServiceUrlInternal">The ONLYOFFICE Docs URL address in the local private network..</param>
        /// <param name="docServiceUrlPortal">The ONLYOFFICE Docs URL address..</param>
        /// <param name="docServiceSignatureSecret">The signature secret of the ONLYOFFICE Docs..</param>
        /// <param name="docServiceSignatureHeader">The signature header of the ONLYOFFICE Docs..</param>
        /// <param name="docServiceSslVerification">Specifies if the SSL verification of the ONLYOFFICE Docs is enabled or not..</param>
        public CheckDocServiceUrlRequestDto(string docServiceUrl = default, string docServiceUrlInternal = default, string docServiceUrlPortal = default, string docServiceSignatureSecret = default, string docServiceSignatureHeader = default, bool? docServiceSslVerification = default)
        {
            this.DocServiceUrl = docServiceUrl;
            this.DocServiceUrlInternal = docServiceUrlInternal;
            this.DocServiceUrlPortal = docServiceUrlPortal;
            this.DocServiceSignatureSecret = docServiceSignatureSecret;
            this.DocServiceSignatureHeader = docServiceSignatureHeader;
            this.DocServiceSslVerification = docServiceSslVerification;
        }

        /// <summary>
        /// The ONLYOFFICE Docs URL address.
        /// </summary>
        /// <value>The ONLYOFFICE Docs URL address.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceUrl", EmitDefaultValue = true)]
        public string DocServiceUrl { get; set; }

        /// <summary>
        /// The ONLYOFFICE Docs URL address in the local private network.
        /// </summary>
        /// <value>The ONLYOFFICE Docs URL address in the local private network.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceUrlInternal", EmitDefaultValue = true)]
        public string DocServiceUrlInternal { get; set; }

        /// <summary>
        /// The ONLYOFFICE Docs URL address.
        /// </summary>
        /// <value>The ONLYOFFICE Docs URL address.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceUrlPortal", EmitDefaultValue = true)]
        public string DocServiceUrlPortal { get; set; }

        /// <summary>
        /// The signature secret of the ONLYOFFICE Docs.
        /// </summary>
        /// <value>The signature secret of the ONLYOFFICE Docs.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceSignatureSecret", EmitDefaultValue = true)]
        public string DocServiceSignatureSecret { get; set; }

        /// <summary>
        /// The signature header of the ONLYOFFICE Docs.
        /// </summary>
        /// <value>The signature header of the ONLYOFFICE Docs.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceSignatureHeader", EmitDefaultValue = true)]
        public string DocServiceSignatureHeader { get; set; }

        /// <summary>
        /// Specifies if the SSL verification of the ONLYOFFICE Docs is enabled or not.
        /// </summary>
        /// <value>Specifies if the SSL verification of the ONLYOFFICE Docs is enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "docServiceSslVerification", EmitDefaultValue = true)]
        public bool? DocServiceSslVerification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckDocServiceUrlRequestDto {\n");
            sb.Append("  DocServiceUrl: ").Append(DocServiceUrl).Append("\n");
            sb.Append("  DocServiceUrlInternal: ").Append(DocServiceUrlInternal).Append("\n");
            sb.Append("  DocServiceUrlPortal: ").Append(DocServiceUrlPortal).Append("\n");
            sb.Append("  DocServiceSignatureSecret: ").Append(DocServiceSignatureSecret).Append("\n");
            sb.Append("  DocServiceSignatureHeader: ").Append(DocServiceSignatureHeader).Append("\n");
            sb.Append("  DocServiceSslVerification: ").Append(DocServiceSslVerification).Append("\n");
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
