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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
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
            var sb = new StringBuilder();
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
