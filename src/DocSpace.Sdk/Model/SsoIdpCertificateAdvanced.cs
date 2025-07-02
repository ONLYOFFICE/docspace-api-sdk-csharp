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
    /// The IdP advanced certificate parameters.
    /// </summary>
    [DataContract(Name = "SsoIdpCertificateAdvanced")]
    public partial class SsoIdpCertificateAdvanced : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoIdpCertificateAdvanced" /> class.
        /// </summary>
        /// <param name="verifyAlgorithm">The certificate verification algorithm..</param>
        /// <param name="verifyAuthResponsesSign">Specifies if the signatures of the SAML authentication responses sent to SP will be verified or not..</param>
        /// <param name="verifyLogoutRequestsSign">Specifies if the signatures of the SAML logout requests sent to SP will be verified or not..</param>
        /// <param name="verifyLogoutResponsesSign">Specifies if the signatures of the SAML logout responses sent to SP will be verified or not..</param>
        /// <param name="decryptAlgorithm">The certificate decryption algorithm..</param>
        /// <param name="decryptAssertions">Specifies if the assertions will be decrypted or not..</param>
        public SsoIdpCertificateAdvanced(string verifyAlgorithm = default, bool verifyAuthResponsesSign = default, bool verifyLogoutRequestsSign = default, bool verifyLogoutResponsesSign = default, string decryptAlgorithm = default, bool decryptAssertions = default)
        {
            this.VerifyAlgorithm = verifyAlgorithm;
            this.VerifyAuthResponsesSign = verifyAuthResponsesSign;
            this.VerifyLogoutRequestsSign = verifyLogoutRequestsSign;
            this.VerifyLogoutResponsesSign = verifyLogoutResponsesSign;
            this.DecryptAlgorithm = decryptAlgorithm;
            this.DecryptAssertions = decryptAssertions;
        }

        /// <summary>
        /// The certificate verification algorithm.
        /// </summary>
        /// <value>The certificate verification algorithm.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "verifyAlgorithm", EmitDefaultValue = true)]
        public string VerifyAlgorithm { get; set; }

        /// <summary>
        /// Specifies if the signatures of the SAML authentication responses sent to SP will be verified or not.
        /// </summary>
        /// <value>Specifies if the signatures of the SAML authentication responses sent to SP will be verified or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "verifyAuthResponsesSign", EmitDefaultValue = true)]
        public bool VerifyAuthResponsesSign { get; set; }

        /// <summary>
        /// Specifies if the signatures of the SAML logout requests sent to SP will be verified or not.
        /// </summary>
        /// <value>Specifies if the signatures of the SAML logout requests sent to SP will be verified or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "verifyLogoutRequestsSign", EmitDefaultValue = true)]
        public bool VerifyLogoutRequestsSign { get; set; }

        /// <summary>
        /// Specifies if the signatures of the SAML logout responses sent to SP will be verified or not.
        /// </summary>
        /// <value>Specifies if the signatures of the SAML logout responses sent to SP will be verified or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "verifyLogoutResponsesSign", EmitDefaultValue = true)]
        public bool VerifyLogoutResponsesSign { get; set; }

        /// <summary>
        /// The certificate decryption algorithm.
        /// </summary>
        /// <value>The certificate decryption algorithm.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "decryptAlgorithm", EmitDefaultValue = true)]
        public string DecryptAlgorithm { get; set; }

        /// <summary>
        /// Specifies if the assertions will be decrypted or not.
        /// </summary>
        /// <value>Specifies if the assertions will be decrypted or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "decryptAssertions", EmitDefaultValue = true)]
        public bool DecryptAssertions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SsoIdpCertificateAdvanced {\n");
            sb.Append("  VerifyAlgorithm: ").Append(VerifyAlgorithm).Append("\n");
            sb.Append("  VerifyAuthResponsesSign: ").Append(VerifyAuthResponsesSign).Append("\n");
            sb.Append("  VerifyLogoutRequestsSign: ").Append(VerifyLogoutRequestsSign).Append("\n");
            sb.Append("  VerifyLogoutResponsesSign: ").Append(VerifyLogoutResponsesSign).Append("\n");
            sb.Append("  DecryptAlgorithm: ").Append(DecryptAlgorithm).Append("\n");
            sb.Append("  DecryptAssertions: ").Append(DecryptAssertions).Append("\n");
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
