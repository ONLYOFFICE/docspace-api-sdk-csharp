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
    /// The brute-force protection of the sign-in form: how many failures, over how long, cost how long a block.
    /// </summary>
    [DataContract(Name = "LoginSettingsRequestDto")]
    public partial class LoginSettingsRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginSettingsRequestDto" /> class.
        /// </summary>
        /// <param name="attemptCount">How many failed sign-in attempts inside one window are tolerated before the offender is blocked. Attempts are  counted per user name and client address together, so one member being blocked leaves the rest of the portal  signing in normally..</param>
        /// <param name="blockTime">How long, in seconds, a blocked user name and address pair stays refused. While the block lasts the sign-in  is refused even when the password is finally correct..</param>
        /// <param name="checkPeriod">The length, in seconds, of the rolling window the failed attempts are counted over. A wider window makes the  same &#x60;attemptCount&#x60; stricter, because failures further apart still add up..</param>
        public LoginSettingsRequestDto(int attemptCount = default, int blockTime = default, int checkPeriod = default)
        {
            this.AttemptCount = attemptCount;
            this.BlockTime = blockTime;
            this.CheckPeriod = checkPeriod;
        }

        /// <summary>
        /// How many failed sign-in attempts inside one window are tolerated before the offender is blocked. Attempts are  counted per user name and client address together, so one member being blocked leaves the rest of the portal  signing in normally.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "attemptCount", EmitDefaultValue = false)]
        public int AttemptCount { get; set; }

        /// <summary>
        /// How long, in seconds, a blocked user name and address pair stays refused. While the block lasts the sign-in  is refused even when the password is finally correct.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "blockTime", EmitDefaultValue = false)]
        public int BlockTime { get; set; }

        /// <summary>
        /// The length, in seconds, of the rolling window the failed attempts are counted over. A wider window makes the  same &#x60;attemptCount&#x60; stricter, because failures further apart still add up.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "checkPeriod", EmitDefaultValue = false)]
        public int CheckPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
