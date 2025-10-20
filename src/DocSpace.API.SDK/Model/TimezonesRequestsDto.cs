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
    /// The request parameters for managing the time zone configurations.
    /// </summary>
    [DataContract(Name = "TimezonesRequestsDto")]
    public partial class TimezonesRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezonesRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimezonesRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezonesRequestsDto" /> class.
        /// </summary>
        /// <param name="id">The IANA time zone identifier. (required).</param>
        /// <param name="displayName">The user-friendly name for the time zone. (required).</param>
        public TimezonesRequestsDto(string id = default, string displayName = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TimezonesRequestsDto and cannot be null");
            }
            this.Id = id;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for TimezonesRequestsDto and cannot be null");
            }
            this.DisplayName = displayName;
        }

        /// <summary>
        /// The IANA time zone identifier.
        /// </summary>
        /// <value>The IANA time zone identifier.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The user-friendly name for the time zone.
        /// </summary>
        /// <value>The user-friendly name for the time zone.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimezonesRequestsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
