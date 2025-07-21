// (c) Copyright Ascensio System SIA 2025
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
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
            var sb = new StringBuilder();
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
