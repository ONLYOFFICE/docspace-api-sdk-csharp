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
    /// The request parameters for creating a third-party account.
    /// </summary>
    [DataContract(Name = "SignupAccountRequestDto")]
    public partial class SignupAccountRequestDto : IValidatableObject
    {

        /// <summary>
        /// The type the invitation link is looked up as, defaulting to &#x60;RoomAdmin&#x60;. It does not decide the resulting  type: the link itself does, and this value only has to match the kind of link that was issued.
        /// </summary>
        [DataMember(Name = "employeeType", EmitDefaultValue = false)]
        public EmployeeType? EmployeeType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SignupAccountRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignupAccountRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignupAccountRequestDto" /> class.
        /// </summary>
        /// <param name="employeeType">The type the invitation link is looked up as, defaulting to &#x60;RoomAdmin&#x60;. It does not decide the resulting  type: the link itself does, and this value only has to match the kind of link that was issued..</param>
        /// <param name="key">The key of the invitation link being accepted, taken from the link the invitation email or the room  invitation contains. An expired or already used key is rejected with 403. (required).</param>
        /// <param name="culture">The culture to set on the new profile, as a culture code. It is applied only when the portal has that culture  enabled, and otherwise the portal default is kept..</param>
        /// <param name="serializedProfile">The profile a completed provider authorization produced, in the serialized form the login flow hands back.  Pass that value unchanged; the first name, the last name, the email and the avatar of the new profile are  taken from it. (required).</param>
        public SignupAccountRequestDto(EmployeeType? employeeType = default, string key = default, string culture = default, string serializedProfile = default)
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for SignupAccountRequestDto and cannot be null");
            }
            this.Key = key;
            // to ensure "serializedProfile" is required (not null)
            if (serializedProfile == null)
            {
                throw new ArgumentNullException("serializedProfile is a required property for SignupAccountRequestDto and cannot be null");
            }
            this.SerializedProfile = serializedProfile;
            this.EmployeeType = employeeType;
            this.Culture = culture;
        }

        /// <summary>
        /// The key of the invitation link being accepted, taken from the link the invitation email or the room  invitation contains. An expired or already used key is rejected with 403.
        /// </summary>
        /// <example>invite_key_123456</example>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The culture to set on the new profile, as a culture code. It is applied only when the portal has that culture  enabled, and otherwise the portal default is kept.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "culture", EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// The profile a completed provider authorization produced, in the serialized form the login flow hands back.  Pass that value unchanged; the first name, the last name, the email and the avatar of the new profile are  taken from it.
        /// </summary>
        /// <example>{"provider":"google","id":"123456"}</example>
        [DataMember(Name = "serializedProfile", IsRequired = true, EmitDefaultValue = true)]
        public string SerializedProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignupAccountRequestDto {\n");
            sb.Append("  EmployeeType: ").Append(EmployeeType).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  SerializedProfile: ").Append(SerializedProfile).Append("\n");
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
