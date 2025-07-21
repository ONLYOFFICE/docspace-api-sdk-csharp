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
    /// The login settings parameters.
    /// </summary>
    [DataContract(Name = "LoginSettingsDto")]
    public partial class LoginSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginSettingsDto" /> class.
        /// </summary>
        /// <param name="attemptCount">The maximum number of consecutive failed login attempts allowed before triggering account suspension..</param>
        /// <param name="blockTime">The duration (in minutes) for which an account remains suspended after exceeding maximum login attempts..</param>
        /// <param name="checkPeriod">The maximum time (in seconds) allowed for server to process and respond to login requests..</param>
        /// <param name="isDefault">Specifies if these settings are default or not.</param>
        public LoginSettingsDto(int attemptCount = default, int blockTime = default, int checkPeriod = default, bool isDefault = default)
        {
            this.AttemptCount = attemptCount;
            this.BlockTime = blockTime;
            this.CheckPeriod = checkPeriod;
            this.IsDefault = isDefault;
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
        /// Specifies if these settings are default or not
        /// </summary>
        /// <value>Specifies if these settings are default or not</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
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
