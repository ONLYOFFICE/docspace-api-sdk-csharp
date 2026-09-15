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
    /// The mail server the portal sends its letters through.
    /// </summary>
    [DataContract(Name = "SmtpSettingsDto")]
    public partial class SmtpSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmtpSettingsDto" /> class.
        /// </summary>
        /// <param name="host">The host name or address of the mail server. On a cloud portal that has saved no relay of its own every  field of this object comes back empty, because the installation&#39;s own server is not disclosed - only  &#x60;isDefaultSettings&#x60; is set there..</param>
        /// <param name="port">The port the mail server is reached on - conventionally 25 or 587 without encryption from the start, 465  with it. It is empty when no port was stored, in which case the portal falls back to its own default..</param>
        /// <param name="senderAddress">The address the letters are sent from, which appears in the From header and is what a reply goes to..</param>
        /// <param name="senderDisplayName">The name shown beside that address in a recipient&#39;s mailbox..</param>
        /// <param name="credentialsUserName">The account the portal signs in to the mail server as, meaningful only while &#x60;enableAuth&#x60; is &#x60;true&#x60;..</param>
        /// <param name="credentialsUserPassword">Always empty here: the stored password is never returned, so a client that sends these settings back has  to supply it again rather than echoing what it read..</param>
        /// <param name="enableSSL">Whether the connection to the mail server is encrypted..</param>
        /// <param name="enableAuth">Whether the portal signs in to the mail server at all. While it is &#x60;false&#x60; the credentials above are  ignored and the server is expected to accept mail unauthenticated..</param>
        /// <param name="useNtlm">Always &#x60;false&#x60; here: the flag is accepted when settings are saved but is not stored, so it never comes  back set and says nothing about how the portal authenticates..</param>
        /// <param name="isDefaultSettings">Whether the portal is still on the mail configuration of the installation rather than on a relay of its  own. &#x60;DELETE api/2.0/smtpsettings/smtp&#x60; puts it back to &#x60;true&#x60;, and while it is &#x60;true&#x60; on a cloud portal  the fields above are blank rather than showing the installation&#39;s server..</param>
        public SmtpSettingsDto(string host = default, int? port = default, string senderAddress = default, string senderDisplayName = default, string credentialsUserName = default, string credentialsUserPassword = default, bool enableSSL = default, bool enableAuth = default, bool useNtlm = default, bool isDefaultSettings = default)
        {
            this.Host = host;
            this.Port = port;
            this.SenderAddress = senderAddress;
            this.SenderDisplayName = senderDisplayName;
            this.CredentialsUserName = credentialsUserName;
            this.CredentialsUserPassword = credentialsUserPassword;
            this.EnableSSL = enableSSL;
            this.EnableAuth = enableAuth;
            this.UseNtlm = useNtlm;
            this.IsDefaultSettings = isDefaultSettings;
        }

        /// <summary>
        /// The host name or address of the mail server. On a cloud portal that has saved no relay of its own every  field of this object comes back empty, because the installation&#39;s own server is not disclosed - only  &#x60;isDefaultSettings&#x60; is set there.
        /// </summary>
        /// <example>mail.example.com</example>
        [DataMember(Name = "host", EmitDefaultValue = true)]
        public string Host { get; set; }

        /// <summary>
        /// The port the mail server is reached on - conventionally 25 or 587 without encryption from the start, 465  with it. It is empty when no port was stored, in which case the portal falls back to its own default.
        /// </summary>
        /// <example>25</example>
        [DataMember(Name = "port", EmitDefaultValue = true)]
        public int? Port { get; set; }

        /// <summary>
        /// The address the letters are sent from, which appears in the From header and is what a reply goes to.
        /// </summary>
        /// <example>notify@example.com</example>
        [DataMember(Name = "senderAddress", EmitDefaultValue = true)]
        public string SenderAddress { get; set; }

        /// <summary>
        /// The name shown beside that address in a recipient&#39;s mailbox.
        /// </summary>
        /// <example>Postman</example>
        [DataMember(Name = "senderDisplayName", EmitDefaultValue = true)]
        public string SenderDisplayName { get; set; }

        /// <summary>
        /// The account the portal signs in to the mail server as, meaningful only while &#x60;enableAuth&#x60; is &#x60;true&#x60;.
        /// </summary>
        /// <example>notify@example.com</example>
        [DataMember(Name = "credentialsUserName", EmitDefaultValue = true)]
        public string CredentialsUserName { get; set; }

        /// <summary>
        /// Always empty here: the stored password is never returned, so a client that sends these settings back has  to supply it again rather than echoing what it read.
        /// </summary>
        [DataMember(Name = "credentialsUserPassword", EmitDefaultValue = true)]
        public string CredentialsUserPassword { get; set; }

        /// <summary>
        /// Whether the connection to the mail server is encrypted.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enableSSL", EmitDefaultValue = true)]
        public bool EnableSSL { get; set; }

        /// <summary>
        /// Whether the portal signs in to the mail server at all. While it is &#x60;false&#x60; the credentials above are  ignored and the server is expected to accept mail unauthenticated.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enableAuth", EmitDefaultValue = true)]
        public bool EnableAuth { get; set; }

        /// <summary>
        /// Always &#x60;false&#x60; here: the flag is accepted when settings are saved but is not stored, so it never comes  back set and says nothing about how the portal authenticates.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "useNtlm", EmitDefaultValue = true)]
        public bool UseNtlm { get; set; }

        /// <summary>
        /// Whether the portal is still on the mail configuration of the installation rather than on a relay of its  own. &#x60;DELETE api/2.0/smtpsettings/smtp&#x60; puts it back to &#x60;true&#x60;, and while it is &#x60;true&#x60; on a cloud portal  the fields above are blank rather than showing the installation&#39;s server.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isDefaultSettings", EmitDefaultValue = true)]
        public bool IsDefaultSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmtpSettingsDto {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
            sb.Append("  SenderDisplayName: ").Append(SenderDisplayName).Append("\n");
            sb.Append("  CredentialsUserName: ").Append(CredentialsUserName).Append("\n");
            sb.Append("  CredentialsUserPassword: ").Append(CredentialsUserPassword).Append("\n");
            sb.Append("  EnableSSL: ").Append(EnableSSL).Append("\n");
            sb.Append("  EnableAuth: ").Append(EnableAuth).Append("\n");
            sb.Append("  UseNtlm: ").Append(UseNtlm).Append("\n");
            sb.Append("  IsDefaultSettings: ").Append(IsDefaultSettings).Append("\n");
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
            // Host (string) maxLength
            if (this.Host != null && this.Host.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Host, length must be less than 255.", new [] { "Host" });
            }

            // Host (string) minLength
            if (this.Host != null && this.Host.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Host, length must be greater than 0.", new [] { "Host" });
            }

            // Port (int?) maximum
            if (this.Port > (int?)65535)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Port, must be a value less than or equal to 65535.", new [] { "Port" });
            }

            // Port (int?) minimum
            if (this.Port < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Port, must be a value greater than or equal to 1.", new [] { "Port" });
            }

            // SenderAddress (string) maxLength
            if (this.SenderAddress != null && this.SenderAddress.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderAddress, length must be less than 255.", new [] { "SenderAddress" });
            }

            // SenderAddress (string) minLength
            if (this.SenderAddress != null && this.SenderAddress.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderAddress, length must be greater than 0.", new [] { "SenderAddress" });
            }

            // SenderDisplayName (string) maxLength
            if (this.SenderDisplayName != null && this.SenderDisplayName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderDisplayName, length must be less than 255.", new [] { "SenderDisplayName" });
            }

            // SenderDisplayName (string) minLength
            if (this.SenderDisplayName != null && this.SenderDisplayName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderDisplayName, length must be greater than 0.", new [] { "SenderDisplayName" });
            }

            // CredentialsUserName (string) maxLength
            if (this.CredentialsUserName != null && this.CredentialsUserName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CredentialsUserName, length must be less than 255.", new [] { "CredentialsUserName" });
            }

            // CredentialsUserName (string) minLength
            if (this.CredentialsUserName != null && this.CredentialsUserName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CredentialsUserName, length must be greater than 0.", new [] { "CredentialsUserName" });
            }

            yield break;
        }

    }


}
