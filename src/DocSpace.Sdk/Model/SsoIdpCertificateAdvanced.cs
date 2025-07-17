/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

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
            var sb = new StringBuilder();
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
