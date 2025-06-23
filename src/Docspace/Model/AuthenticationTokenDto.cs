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
    /// The authentication token parameters.
    /// </summary>
    [DataContract(Name = "AuthenticationTokenDto")]
    public partial class AuthenticationTokenDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationTokenDto" /> class.
        /// </summary>
        /// <param name="token">The authentication token..</param>
        /// <param name="expires">The token expiration time..</param>
        /// <param name="sms">Specifies if the authentication code is sent by SMS or not..</param>
        /// <param name="phoneNoise">The phone number..</param>
        /// <param name="tfa">Specifies if the two-factor application is used or not..</param>
        /// <param name="tfaKey">The two-factor authentication key..</param>
        /// <param name="confirmUrl">The confirmation email URL..</param>
        public AuthenticationTokenDto(string token = default, DateTime expires = default, bool sms = default, string phoneNoise = default, bool tfa = default, string tfaKey = default, string confirmUrl = default)
        {
            this.Token = token;
            this.Expires = expires;
            this.Sms = sms;
            this.PhoneNoise = phoneNoise;
            this.Tfa = tfa;
            this.TfaKey = tfaKey;
            this.ConfirmUrl = confirmUrl;
        }

        /// <summary>
        /// The authentication token.
        /// </summary>
        /// <value>The authentication token.</value>
        /*
        <example>abcde12345</example>
        */
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// The token expiration time.
        /// </summary>
        /// <value>The token expiration time.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public DateTime Expires { get; set; }

        /// <summary>
        /// Specifies if the authentication code is sent by SMS or not.
        /// </summary>
        /// <value>Specifies if the authentication code is sent by SMS or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "sms", EmitDefaultValue = true)]
        public bool Sms { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        /// <value>The phone number.</value>
        [DataMember(Name = "phoneNoise", EmitDefaultValue = true)]
        public string PhoneNoise { get; set; }

        /// <summary>
        /// Specifies if the two-factor application is used or not.
        /// </summary>
        /// <value>Specifies if the two-factor application is used or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "tfa", EmitDefaultValue = true)]
        public bool Tfa { get; set; }

        /// <summary>
        /// The two-factor authentication key.
        /// </summary>
        /// <value>The two-factor authentication key.</value>
        [DataMember(Name = "tfaKey", EmitDefaultValue = true)]
        public string TfaKey { get; set; }

        /// <summary>
        /// The confirmation email URL.
        /// </summary>
        /// <value>The confirmation email URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "confirmUrl", EmitDefaultValue = true)]
        public string ConfirmUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthenticationTokenDto {\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  PhoneNoise: ").Append(PhoneNoise).Append("\n");
            sb.Append("  Tfa: ").Append(Tfa).Append("\n");
            sb.Append("  TfaKey: ").Append(TfaKey).Append("\n");
            sb.Append("  ConfirmUrl: ").Append(ConfirmUrl).Append("\n");
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
