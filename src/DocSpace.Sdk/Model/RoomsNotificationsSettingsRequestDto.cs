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
    /// The request parameters for configuring notification settings for the chat or collaboration rooms.
    /// </summary>
    [DataContract(Name = "RoomsNotificationsSettingsRequestDto")]
    public partial class RoomsNotificationsSettingsRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsNotificationsSettingsRequestDto" /> class.
        /// </summary>
        /// <param name="roomsId">The target room identifier..</param>
        /// <param name="mute">Specifies whether the notifications will be delivered to the specified room or not..</param>
        public RoomsNotificationsSettingsRequestDto(Object roomsId = default, bool mute = default)
        {
            this.RoomsId = roomsId;
            this.Mute = mute;
        }

        /// <summary>
        /// The target room identifier.
        /// </summary>
        /// <value>The target room identifier.</value>
        /*
        <example>{&quot;int&quot;:1234,&quot;string&quot;:&quot;some text&quot;,&quot;boolean&quot;:true}</example>
        */
        [DataMember(Name = "roomsId", EmitDefaultValue = true)]
        public Object RoomsId { get; set; }

        /// <summary>
        /// Specifies whether the notifications will be delivered to the specified room or not.
        /// </summary>
        /// <value>Specifies whether the notifications will be delivered to the specified room or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "mute", EmitDefaultValue = true)]
        public bool Mute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomsNotificationsSettingsRequestDto {\n");
            sb.Append("  RoomsId: ").Append(RoomsId).Append("\n");
            sb.Append("  Mute: ").Append(Mute).Append("\n");
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
