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
    /// Which kind of notification the calling user switches, and which way.
    /// </summary>
    [DataContract(Name = "NotificationSettingsRequestsDto")]
    public partial class NotificationSettingsRequestsDto : IValidatableObject
    {

        /// <summary>
        /// The kind of notification being switched. A value outside the defined set is echoed back while nothing is  stored, so confirm the result with &#x60;GET api/2.0/settings/notification/{type}&#x60; rather than trusting the  answer.
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public NotificationType Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="type">The kind of notification being switched. A value outside the defined set is echoed back while nothing is  stored, so confirm the result with &#x60;GET api/2.0/settings/notification/{type}&#x60; rather than trusting the  answer. (required).</param>
        /// <param name="isEnabled">Whether that kind reaches the calling account. It applies to the caller own account alone and to every room  at once; a single room is silenced with &#x60;POST api/2.0/settings/notification/rooms&#x60; instead..</param>
        public NotificationSettingsRequestsDto(NotificationType type = default, bool isEnabled = default)
        {
            this.Type = type;
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Whether that kind reaches the calling account. It applies to the caller own account alone and to every room  at once; a single room is silenced with &#x60;POST api/2.0/settings/notification/rooms&#x60; instead.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationSettingsRequestsDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
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
