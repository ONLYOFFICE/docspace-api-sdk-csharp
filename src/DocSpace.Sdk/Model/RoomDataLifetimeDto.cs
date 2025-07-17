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
    /// The room data lifetime information.
    /// </summary>
    [DataContract(Name = "RoomDataLifetimeDto")]
    public partial class RoomDataLifetimeDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public RoomDataLifetimePeriod? Period { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomDataLifetimeDto" /> class.
        /// </summary>
        /// <param name="deletePermanently">Specifies whether to permanently delete the room data or not..</param>
        /// <param name="period">period.</param>
        /// <param name="value">Specifies the time period value of the room data lifetime..</param>
        /// <param name="enabled">Specifies whether the room data lifetime setting is enabled or not..</param>
        public RoomDataLifetimeDto(bool deletePermanently = default, RoomDataLifetimePeriod? period = default, int? value = default, bool? enabled = default)
        {
            this.DeletePermanently = deletePermanently;
            this.Period = period;
            this.Value = value;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Specifies whether to permanently delete the room data or not.
        /// </summary>
        /// <value>Specifies whether to permanently delete the room data or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "deletePermanently", EmitDefaultValue = true)]
        public bool DeletePermanently { get; set; }

        /// <summary>
        /// Specifies the time period value of the room data lifetime.
        /// </summary>
        /// <value>Specifies the time period value of the room data lifetime.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public int? Value { get; set; }

        /// <summary>
        /// Specifies whether the room data lifetime setting is enabled or not.
        /// </summary>
        /// <value>Specifies whether the room data lifetime setting is enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomDataLifetimeDto {\n");
            sb.Append("  DeletePermanently: ").Append(DeletePermanently).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            // Value (int?) maximum
            if (this.Value > (int?)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must be a value less than or equal to 999.", new [] { "Value" });
            }

            // Value (int?) minimum
            if (this.Value < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must be a value greater than or equal to 1.", new [] { "Value" });
            }

            yield break;
        }
    }


}
