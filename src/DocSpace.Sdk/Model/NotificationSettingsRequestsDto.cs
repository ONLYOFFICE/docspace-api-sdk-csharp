/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The request parameters for configuring notification settings.
    /// </summary>
    [DataContract(Name = "NotificationSettingsRequestsDto")]
    public partial class NotificationSettingsRequestsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
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
        /// <param name="type">type (required).</param>
        /// <param name="isEnabled">Specifies if the specified notification type is enabled or not..</param>
        public NotificationSettingsRequestsDto(NotificationType type = default, bool isEnabled = default)
        {
            this.Type = type;
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Specifies if the specified notification type is enabled or not.
        /// </summary>
        /// <value>Specifies if the specified notification type is enabled or not.</value>
        /*
        <example>true</example>
        */
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
