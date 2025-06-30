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
    /// The SMTP settings parameters.
    /// </summary>
    [DataContract(Name = "SmtpSettingsDto")]
    public partial class SmtpSettingsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmtpSettingsDto" /> class.
        /// </summary>
        /// <param name="host">The SMTP host..</param>
        /// <param name="port">The SMTP port..</param>
        /// <param name="senderAddress">The sender address..</param>
        /// <param name="senderDisplayName">The sender display name..</param>
        /// <param name="credentialsUserName">The credentials username..</param>
        /// <param name="credentialsUserPassword">The credentials user password..</param>
        /// <param name="enableSSL">Specifies whether the SSL is enabled or not..</param>
        /// <param name="enableAuth">Specifies whether the authentication is enabled or not..</param>
        /// <param name="useNtlm">Specifies whether to use NTLM or not..</param>
        /// <param name="isDefaultSettings">Specifies if the current settings are default or not..</param>
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
        /// The SMTP host.
        /// </summary>
        /// <value>The SMTP host.</value>
        /*
        <example>mail.example.com</example>
        */
        [DataMember(Name = "host", EmitDefaultValue = true)]
        public string Host { get; set; }

        /// <summary>
        /// The SMTP port.
        /// </summary>
        /// <value>The SMTP port.</value>
        /*
        <example>25</example>
        */
        [DataMember(Name = "port", EmitDefaultValue = true)]
        public int? Port { get; set; }

        /// <summary>
        /// The sender address.
        /// </summary>
        /// <value>The sender address.</value>
        /*
        <example>notify@example.com</example>
        */
        [DataMember(Name = "senderAddress", EmitDefaultValue = true)]
        public string SenderAddress { get; set; }

        /// <summary>
        /// The sender display name.
        /// </summary>
        /// <value>The sender display name.</value>
        /*
        <example>Postman</example>
        */
        [DataMember(Name = "senderDisplayName", EmitDefaultValue = true)]
        public string SenderDisplayName { get; set; }

        /// <summary>
        /// The credentials username.
        /// </summary>
        /// <value>The credentials username.</value>
        /*
        <example>notify@example.com</example>
        */
        [DataMember(Name = "credentialsUserName", EmitDefaultValue = true)]
        public string CredentialsUserName { get; set; }

        /// <summary>
        /// The credentials user password.
        /// </summary>
        /// <value>The credentials user password.</value>
        /*
        <example>{password}</example>
        */
        [DataMember(Name = "credentialsUserPassword", EmitDefaultValue = true)]
        public string CredentialsUserPassword { get; set; }

        /// <summary>
        /// Specifies whether the SSL is enabled or not.
        /// </summary>
        /// <value>Specifies whether the SSL is enabled or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "enableSSL", EmitDefaultValue = true)]
        public bool EnableSSL { get; set; }

        /// <summary>
        /// Specifies whether the authentication is enabled or not.
        /// </summary>
        /// <value>Specifies whether the authentication is enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enableAuth", EmitDefaultValue = true)]
        public bool EnableAuth { get; set; }

        /// <summary>
        /// Specifies whether to use NTLM or not.
        /// </summary>
        /// <value>Specifies whether to use NTLM or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "useNtlm", EmitDefaultValue = true)]
        public bool UseNtlm { get; set; }

        /// <summary>
        /// Specifies if the current settings are default or not.
        /// </summary>
        /// <value>Specifies if the current settings are default or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isDefaultSettings", EmitDefaultValue = true)]
        public bool IsDefaultSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
