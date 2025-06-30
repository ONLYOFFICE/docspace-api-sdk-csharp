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
    /// The request parameters for initial configuration of the setup wizard.
    /// </summary>
    [DataContract(Name = "WizardRequestsDto")]
    public partial class WizardRequestsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WizardRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WizardRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WizardRequestsDto" /> class.
        /// </summary>
        /// <param name="email">The user&#39;s email address for authentication and communication. (required).</param>
        /// <param name="passwordHash">The hashed representation of the user&#39;s password. (required).</param>
        /// <param name="lng">The user&#39;s preferred interface language code..</param>
        /// <param name="varTimeZone">The user&#39;s time zone identifier..</param>
        /// <param name="amiId">The Amazon Machine Image (AMI) identifier..</param>
        /// <param name="subscribeFromSite">Specifies whether the user opted in for site communications..</param>
        public WizardRequestsDto(string email = default, string passwordHash = default, string lng = default, string varTimeZone = default, string amiId = default, bool subscribeFromSite = default)
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for WizardRequestsDto and cannot be null");
            }
            this.Email = email;
            // to ensure "passwordHash" is required (not null)
            if (passwordHash == null)
            {
                throw new ArgumentNullException("passwordHash is a required property for WizardRequestsDto and cannot be null");
            }
            this.PasswordHash = passwordHash;
            this.Lng = lng;
            this.VarTimeZone = varTimeZone;
            this.AmiId = amiId;
            this.SubscribeFromSite = subscribeFromSite;
        }

        /// <summary>
        /// The user&#39;s email address for authentication and communication.
        /// </summary>
        /// <value>The user&#39;s email address for authentication and communication.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The hashed representation of the user&#39;s password.
        /// </summary>
        /// <value>The hashed representation of the user&#39;s password.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "passwordHash", IsRequired = true, EmitDefaultValue = true)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// The user&#39;s preferred interface language code.
        /// </summary>
        /// <value>The user&#39;s preferred interface language code.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "lng", EmitDefaultValue = true)]
        public string Lng { get; set; }

        /// <summary>
        /// The user&#39;s time zone identifier.
        /// </summary>
        /// <value>The user&#39;s time zone identifier.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public string VarTimeZone { get; set; }

        /// <summary>
        /// The Amazon Machine Image (AMI) identifier.
        /// </summary>
        /// <value>The Amazon Machine Image (AMI) identifier.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "amiId", EmitDefaultValue = true)]
        public string AmiId { get; set; }

        /// <summary>
        /// Specifies whether the user opted in for site communications.
        /// </summary>
        /// <value>Specifies whether the user opted in for site communications.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "subscribeFromSite", EmitDefaultValue = true)]
        public bool SubscribeFromSite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WizardRequestsDto {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PasswordHash: ").Append(PasswordHash).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  AmiId: ").Append(AmiId).Append("\n");
            sb.Append("  SubscribeFromSite: ").Append(SubscribeFromSite).Append("\n");
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
