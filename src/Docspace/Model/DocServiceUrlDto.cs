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
    /// The document service URL parameters.
    /// </summary>
    [DataContract(Name = "DocServiceUrlDto")]
    public partial class DocServiceUrlDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocServiceUrlDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocServiceUrlDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocServiceUrlDto" /> class.
        /// </summary>
        /// <param name="varVersion">The version of the document service. (required).</param>
        /// <param name="docServiceUrlApi">The document service URL API. (required).</param>
        /// <param name="docServiceUrl">The document service URL. (required).</param>
        /// <param name="docServiceUrlInternal">The internal document service URL. (required).</param>
        /// <param name="docServicePortalUrl">The document service portal URL. (required).</param>
        /// <param name="docServiceSignatureHeader">The document service signature header..</param>
        /// <param name="docServiceSslVerification">Specifies if the document service SSL verification is enabled..</param>
        /// <param name="isDefault">Specifies if the document service is default. (required).</param>
        public DocServiceUrlDto(string varVersion = default, string docServiceUrlApi = default, string docServiceUrl = default, string docServiceUrlInternal = default, string docServicePortalUrl = default, string docServiceSignatureHeader = default, bool docServiceSslVerification = default, bool isDefault = default)
        {
            // to ensure "varVersion" is required (not null)
            if (varVersion == null)
            {
                throw new ArgumentNullException("varVersion is a required property for DocServiceUrlDto and cannot be null");
            }
            this.VarVersion = varVersion;
            // to ensure "docServiceUrlApi" is required (not null)
            if (docServiceUrlApi == null)
            {
                throw new ArgumentNullException("docServiceUrlApi is a required property for DocServiceUrlDto and cannot be null");
            }
            this.DocServiceUrlApi = docServiceUrlApi;
            // to ensure "docServiceUrl" is required (not null)
            if (docServiceUrl == null)
            {
                throw new ArgumentNullException("docServiceUrl is a required property for DocServiceUrlDto and cannot be null");
            }
            this.DocServiceUrl = docServiceUrl;
            // to ensure "docServiceUrlInternal" is required (not null)
            if (docServiceUrlInternal == null)
            {
                throw new ArgumentNullException("docServiceUrlInternal is a required property for DocServiceUrlDto and cannot be null");
            }
            this.DocServiceUrlInternal = docServiceUrlInternal;
            // to ensure "docServicePortalUrl" is required (not null)
            if (docServicePortalUrl == null)
            {
                throw new ArgumentNullException("docServicePortalUrl is a required property for DocServiceUrlDto and cannot be null");
            }
            this.DocServicePortalUrl = docServicePortalUrl;
            this.IsDefault = isDefault;
            this.DocServiceSignatureHeader = docServiceSignatureHeader;
            this.DocServiceSslVerification = docServiceSslVerification;
        }

        /// <summary>
        /// The version of the document service.
        /// </summary>
        /// <value>The version of the document service.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// The document service URL API.
        /// </summary>
        /// <value>The document service URL API.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceUrlApi", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceUrlApi { get; set; }

        /// <summary>
        /// The document service URL.
        /// </summary>
        /// <value>The document service URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceUrl", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceUrl { get; set; }

        /// <summary>
        /// The internal document service URL.
        /// </summary>
        /// <value>The internal document service URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceUrlInternal", IsRequired = true, EmitDefaultValue = true)]
        public string DocServiceUrlInternal { get; set; }

        /// <summary>
        /// The document service portal URL.
        /// </summary>
        /// <value>The document service portal URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServicePortalUrl", IsRequired = true, EmitDefaultValue = true)]
        public string DocServicePortalUrl { get; set; }

        /// <summary>
        /// The document service signature header.
        /// </summary>
        /// <value>The document service signature header.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "docServiceSignatureHeader", EmitDefaultValue = true)]
        public string DocServiceSignatureHeader { get; set; }

        /// <summary>
        /// Specifies if the document service SSL verification is enabled.
        /// </summary>
        /// <value>Specifies if the document service SSL verification is enabled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "docServiceSslVerification", EmitDefaultValue = true)]
        public bool DocServiceSslVerification { get; set; }

        /// <summary>
        /// Specifies if the document service is default.
        /// </summary>
        /// <value>Specifies if the document service is default.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isDefault", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocServiceUrlDto {\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  DocServiceUrlApi: ").Append(DocServiceUrlApi).Append("\n");
            sb.Append("  DocServiceUrl: ").Append(DocServiceUrl).Append("\n");
            sb.Append("  DocServiceUrlInternal: ").Append(DocServiceUrlInternal).Append("\n");
            sb.Append("  DocServicePortalUrl: ").Append(DocServicePortalUrl).Append("\n");
            sb.Append("  DocServiceSignatureHeader: ").Append(DocServiceSignatureHeader).Append("\n");
            sb.Append("  DocServiceSslVerification: ").Append(DocServiceSslVerification).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
