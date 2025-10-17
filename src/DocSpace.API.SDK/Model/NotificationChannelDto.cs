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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The notification channel information.
    /// </summary>
    [DataContract(Name = "NotificationChannelDto")]
    public partial class NotificationChannelDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationChannelDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationChannelDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationChannelDto" /> class.
        /// </summary>
        /// <param name="name">The notification channel name. (required).</param>
        /// <param name="isEnabled">Specifies whether the notification channel is enabled. (required).</param>
        public NotificationChannelDto(string name = default, bool isEnabled = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for NotificationChannelDto and cannot be null");
            }
            this.Name = name;
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// The notification channel name.
        /// </summary>
        /// <value>The notification channel name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether the notification channel is enabled.
        /// </summary>
        /// <value>Specifies whether the notification channel is enabled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationChannelDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
