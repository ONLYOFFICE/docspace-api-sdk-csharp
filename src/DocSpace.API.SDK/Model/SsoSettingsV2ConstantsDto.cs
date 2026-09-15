// (c) Copyright Ascensio System SIA 2026
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
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The SSO settings constants: every value the settings accept, by name.
    /// </summary>
    [DataContract(Name = "SsoSettingsV2ConstantsDto")]
    public partial class SsoSettingsV2ConstantsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoSettingsV2ConstantsDto" /> class.
        /// </summary>
        /// <param name="ssoNameIdFormatType">The values the &#x60;nameIdFormat&#x60; of the identity provider settings accepts. The built-in configuration uses  the SAML 2.0 transient format..</param>
        /// <param name="ssoBindingType">The values the &#x60;ssoBinding&#x60; and &#x60;sloBinding&#x60; of the identity provider settings accept - how the portal  sends its sign-in and sign-out requests. The built-in configuration uses HTTP POST for both..</param>
        /// <param name="ssoSigningAlgorithmType">The values the &#x60;signingAlgorithm&#x60; of the service provider certificate and the &#x60;verifyAlgorithm&#x60; of the  identity provider certificate accept. The built-in configuration uses RSA-SHA1 for both..</param>
        /// <param name="ssoEncryptAlgorithmType">The values the &#x60;encryptAlgorithm&#x60; and &#x60;decryptAlgorithm&#x60; of the certificate settings accept. The built-in  configuration uses AES-128 everywhere..</param>
        /// <param name="ssoSpCertificateActionType">The values the &#x60;action&#x60; of a service provider certificate accepts, which is what the portal&#39;s own key  pair may be used for..</param>
        /// <param name="ssoIdpCertificateActionType">The values the &#x60;action&#x60; of an identity provider certificate accepts, which is what the provider&#39;s  certificate may be used for - the mirror image of the service provider actions..</param>
        public SsoSettingsV2ConstantsDto(SsoNameIdFormatTypeDto ssoNameIdFormatType = default, SsoBindingTypeDto ssoBindingType = default, SsoSigningAlgorithmTypeDto ssoSigningAlgorithmType = default, SsoEncryptAlgorithmTypeDto ssoEncryptAlgorithmType = default, SsoSpCertificateActionTypeDto ssoSpCertificateActionType = default, SsoIdpCertificateActionTypeDto ssoIdpCertificateActionType = default)
        {
            this.SsoNameIdFormatType = ssoNameIdFormatType;
            this.SsoBindingType = ssoBindingType;
            this.SsoSigningAlgorithmType = ssoSigningAlgorithmType;
            this.SsoEncryptAlgorithmType = ssoEncryptAlgorithmType;
            this.SsoSpCertificateActionType = ssoSpCertificateActionType;
            this.SsoIdpCertificateActionType = ssoIdpCertificateActionType;
        }

        /// <summary>
        /// The values the &#x60;nameIdFormat&#x60; of the identity provider settings accepts. The built-in configuration uses  the SAML 2.0 transient format.
        /// </summary>
        [DataMember(Name = "ssoNameIdFormatType", EmitDefaultValue = false)]
        public SsoNameIdFormatTypeDto SsoNameIdFormatType { get; set; }

        /// <summary>
        /// The values the &#x60;ssoBinding&#x60; and &#x60;sloBinding&#x60; of the identity provider settings accept - how the portal  sends its sign-in and sign-out requests. The built-in configuration uses HTTP POST for both.
        /// </summary>
        [DataMember(Name = "ssoBindingType", EmitDefaultValue = false)]
        public SsoBindingTypeDto SsoBindingType { get; set; }

        /// <summary>
        /// The values the &#x60;signingAlgorithm&#x60; of the service provider certificate and the &#x60;verifyAlgorithm&#x60; of the  identity provider certificate accept. The built-in configuration uses RSA-SHA1 for both.
        /// </summary>
        [DataMember(Name = "ssoSigningAlgorithmType", EmitDefaultValue = false)]
        public SsoSigningAlgorithmTypeDto SsoSigningAlgorithmType { get; set; }

        /// <summary>
        /// The values the &#x60;encryptAlgorithm&#x60; and &#x60;decryptAlgorithm&#x60; of the certificate settings accept. The built-in  configuration uses AES-128 everywhere.
        /// </summary>
        [DataMember(Name = "ssoEncryptAlgorithmType", EmitDefaultValue = false)]
        public SsoEncryptAlgorithmTypeDto SsoEncryptAlgorithmType { get; set; }

        /// <summary>
        /// The values the &#x60;action&#x60; of a service provider certificate accepts, which is what the portal&#39;s own key  pair may be used for.
        /// </summary>
        [DataMember(Name = "ssoSpCertificateActionType", EmitDefaultValue = false)]
        public SsoSpCertificateActionTypeDto SsoSpCertificateActionType { get; set; }

        /// <summary>
        /// The values the &#x60;action&#x60; of an identity provider certificate accepts, which is what the provider&#39;s  certificate may be used for - the mirror image of the service provider actions.
        /// </summary>
        [DataMember(Name = "ssoIdpCertificateActionType", EmitDefaultValue = false)]
        public SsoIdpCertificateActionTypeDto SsoIdpCertificateActionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SsoSettingsV2ConstantsDto {\n");
            sb.Append("  SsoNameIdFormatType: ").Append(SsoNameIdFormatType).Append("\n");
            sb.Append("  SsoBindingType: ").Append(SsoBindingType).Append("\n");
            sb.Append("  SsoSigningAlgorithmType: ").Append(SsoSigningAlgorithmType).Append("\n");
            sb.Append("  SsoEncryptAlgorithmType: ").Append(SsoEncryptAlgorithmType).Append("\n");
            sb.Append("  SsoSpCertificateActionType: ").Append(SsoSpCertificateActionType).Append("\n");
            sb.Append("  SsoIdpCertificateActionType: ").Append(SsoIdpCertificateActionType).Append("\n");
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
