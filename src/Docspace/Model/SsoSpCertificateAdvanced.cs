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
    /// The SP advanced certificate parameters.
    /// </summary>
    [DataContract(Name = "SsoSpCertificateAdvanced")]
    public partial class SsoSpCertificateAdvanced : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoSpCertificateAdvanced" /> class.
        /// </summary>
        /// <param name="signingAlgorithm">The certificate signing algorithm..</param>
        /// <param name="signAuthRequests">Specifies if SP will sign the SAML authentication requests sent to IdP or not..</param>
        /// <param name="signLogoutRequests">Specifies if SP will sign the SAML logout requests sent to IdP or not..</param>
        /// <param name="signLogoutResponses">Specifies if SP will sign the SAML logout responses sent to IdP or not..</param>
        /// <param name="encryptAlgorithm">The certificate encryption algorithm..</param>
        /// <param name="decryptAlgorithm">The certificate decryption algorithm..</param>
        /// <param name="encryptAssertions">Specifies if the assertions will be encrypted or not..</param>
        public SsoSpCertificateAdvanced(string signingAlgorithm = default, bool signAuthRequests = default, bool signLogoutRequests = default, bool signLogoutResponses = default, string encryptAlgorithm = default, string decryptAlgorithm = default, bool encryptAssertions = default)
        {
            this.SigningAlgorithm = signingAlgorithm;
            this.SignAuthRequests = signAuthRequests;
            this.SignLogoutRequests = signLogoutRequests;
            this.SignLogoutResponses = signLogoutResponses;
            this.EncryptAlgorithm = encryptAlgorithm;
            this.DecryptAlgorithm = decryptAlgorithm;
            this.EncryptAssertions = encryptAssertions;
        }

        /// <summary>
        /// The certificate signing algorithm.
        /// </summary>
        /// <value>The certificate signing algorithm.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "signingAlgorithm", EmitDefaultValue = true)]
        public string SigningAlgorithm { get; set; }

        /// <summary>
        /// Specifies if SP will sign the SAML authentication requests sent to IdP or not.
        /// </summary>
        /// <value>Specifies if SP will sign the SAML authentication requests sent to IdP or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "signAuthRequests", EmitDefaultValue = true)]
        public bool SignAuthRequests { get; set; }

        /// <summary>
        /// Specifies if SP will sign the SAML logout requests sent to IdP or not.
        /// </summary>
        /// <value>Specifies if SP will sign the SAML logout requests sent to IdP or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "signLogoutRequests", EmitDefaultValue = true)]
        public bool SignLogoutRequests { get; set; }

        /// <summary>
        /// Specifies if SP will sign the SAML logout responses sent to IdP or not.
        /// </summary>
        /// <value>Specifies if SP will sign the SAML logout responses sent to IdP or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "signLogoutResponses", EmitDefaultValue = true)]
        public bool SignLogoutResponses { get; set; }

        /// <summary>
        /// The certificate encryption algorithm.
        /// </summary>
        /// <value>The certificate encryption algorithm.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "encryptAlgorithm", EmitDefaultValue = true)]
        public string EncryptAlgorithm { get; set; }

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
        /// Specifies if the assertions will be encrypted or not.
        /// </summary>
        /// <value>Specifies if the assertions will be encrypted or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "encryptAssertions", EmitDefaultValue = true)]
        public bool EncryptAssertions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SsoSpCertificateAdvanced {\n");
            sb.Append("  SigningAlgorithm: ").Append(SigningAlgorithm).Append("\n");
            sb.Append("  SignAuthRequests: ").Append(SignAuthRequests).Append("\n");
            sb.Append("  SignLogoutRequests: ").Append(SignLogoutRequests).Append("\n");
            sb.Append("  SignLogoutResponses: ").Append(SignLogoutResponses).Append("\n");
            sb.Append("  EncryptAlgorithm: ").Append(EncryptAlgorithm).Append("\n");
            sb.Append("  DecryptAlgorithm: ").Append(DecryptAlgorithm).Append("\n");
            sb.Append("  EncryptAssertions: ").Append(EncryptAssertions).Append("\n");
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
