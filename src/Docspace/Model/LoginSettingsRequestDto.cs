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
    /// The request parameters for configuring login security and performance settings.
    /// </summary>
    [DataContract(Name = "LoginSettingsRequestDto")]
    public partial class LoginSettingsRequestDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginSettingsRequestDto" /> class.
        /// </summary>
        /// <param name="attemptCount">The maximum number of consecutive failed login attempts allowed before triggering account suspension..</param>
        /// <param name="blockTime">The duration (in minutes) for which an account remains suspended after exceeding maximum login attempts..</param>
        /// <param name="checkPeriod">The maximum time (in seconds) allowed for server to process and respond to login requests..</param>
        public LoginSettingsRequestDto(int attemptCount = default, int blockTime = default, int checkPeriod = default)
        {
            this.AttemptCount = attemptCount;
            this.BlockTime = blockTime;
            this.CheckPeriod = checkPeriod;
        }

        /// <summary>
        /// The maximum number of consecutive failed login attempts allowed before triggering account suspension.
        /// </summary>
        /// <value>The maximum number of consecutive failed login attempts allowed before triggering account suspension.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "attemptCount", EmitDefaultValue = false)]
        public int AttemptCount { get; set; }

        /// <summary>
        /// The duration (in minutes) for which an account remains suspended after exceeding maximum login attempts.
        /// </summary>
        /// <value>The duration (in minutes) for which an account remains suspended after exceeding maximum login attempts.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "blockTime", EmitDefaultValue = false)]
        public int BlockTime { get; set; }

        /// <summary>
        /// The maximum time (in seconds) allowed for server to process and respond to login requests.
        /// </summary>
        /// <value>The maximum time (in seconds) allowed for server to process and respond to login requests.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "checkPeriod", EmitDefaultValue = false)]
        public int CheckPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoginSettingsRequestDto {\n");
            sb.Append("  AttemptCount: ").Append(AttemptCount).Append("\n");
            sb.Append("  BlockTime: ").Append(BlockTime).Append("\n");
            sb.Append("  CheckPeriod: ").Append(CheckPeriod).Append("\n");
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
            // AttemptCount (int) maximum
            if (this.AttemptCount > (int)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttemptCount, must be a value less than or equal to 9999.", new [] { "AttemptCount" });
            }

            // AttemptCount (int) minimum
            if (this.AttemptCount < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttemptCount, must be a value greater than or equal to 1.", new [] { "AttemptCount" });
            }

            // BlockTime (int) maximum
            if (this.BlockTime > (int)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BlockTime, must be a value less than or equal to 9999.", new [] { "BlockTime" });
            }

            // BlockTime (int) minimum
            if (this.BlockTime < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BlockTime, must be a value greater than or equal to 1.", new [] { "BlockTime" });
            }

            // CheckPeriod (int) maximum
            if (this.CheckPeriod > (int)9999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckPeriod, must be a value less than or equal to 9999.", new [] { "CheckPeriod" });
            }

            // CheckPeriod (int) minimum
            if (this.CheckPeriod < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckPeriod, must be a value greater than or equal to 1.", new [] { "CheckPeriod" });
            }

            yield break;
        }
    }


}
