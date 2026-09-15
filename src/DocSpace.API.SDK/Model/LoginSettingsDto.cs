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
    [DataContract(Name = "LoginSettingsDto")]
    public partial class LoginSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoginSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginSettingsDto" /> class.
        /// </summary>
        /// <param name="attemptCount">How many failed attempts inside one window are tolerated before the offender is blocked. Attempts are  counted per user name and client address together, so one member being blocked leaves the rest of the  portal signing in normally. (required).</param>
        /// <param name="blockTime">How long, in seconds, a blocked user name and address pair stays refused. While the block lasts the  sign-in is refused even once the password is correct. (required).</param>
        /// <param name="checkPeriod">The length, in seconds, of the rolling window the failures are counted over. It is not a request timeout: a  wider window makes the same &#x60;attemptCount&#x60; stricter, because failures further apart still add up. (required).</param>
        /// <param name="isDefault">Whether the three numbers above still match the ones the installation ships with. It turns &#x60;false&#x60; as soon  as any of them is saved differently, and &#x60;true&#x60; again after  &#x60;DELETE api/2.0/settings/security/loginsettings&#x60;. (required).</param>
        public LoginSettingsDto(int attemptCount = default, int blockTime = default, int checkPeriod = default, bool isDefault = default)
        {
            this.AttemptCount = attemptCount;
            this.BlockTime = blockTime;
            this.CheckPeriod = checkPeriod;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// How many failed attempts inside one window are tolerated before the offender is blocked. Attempts are  counted per user name and client address together, so one member being blocked leaves the rest of the  portal signing in normally.
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "attemptCount", IsRequired = true, EmitDefaultValue = true)]
        public int AttemptCount { get; set; }

        /// <summary>
        /// How long, in seconds, a blocked user name and address pair stays refused. While the block lasts the  sign-in is refused even once the password is correct.
        /// </summary>
        /// <example>15</example>
        [DataMember(Name = "blockTime", IsRequired = true, EmitDefaultValue = true)]
        public int BlockTime { get; set; }

        /// <summary>
        /// The length, in seconds, of the rolling window the failures are counted over. It is not a request timeout: a  wider window makes the same &#x60;attemptCount&#x60; stricter, because failures further apart still add up.
        /// </summary>
        /// <example>60</example>
        [DataMember(Name = "checkPeriod", IsRequired = true, EmitDefaultValue = true)]
        public int CheckPeriod { get; set; }

        /// <summary>
        /// Whether the three numbers above still match the ones the installation ships with. It turns &#x60;false&#x60; as soon  as any of them is saved differently, and &#x60;true&#x60; again after  &#x60;DELETE api/2.0/settings/security/loginsettings&#x60;.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isDefault", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginSettingsDto {\n");
            sb.Append("  AttemptCount: ").Append(AttemptCount).Append("\n");
            sb.Append("  BlockTime: ").Append(BlockTime).Append("\n");
            sb.Append("  CheckPeriod: ").Append(CheckPeriod).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
