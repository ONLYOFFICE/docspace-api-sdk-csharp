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
    /// The API date and time parameters.
    /// </summary>
    [DataContract(Name = "ApiDateTime")]
    [System.Text.Json.Serialization.JsonConverter(typeof(ApiDateTimeConverter))]
    public partial class ApiDateTime : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiDateTime" /> class.
        /// </summary>
        /// <param name="utcTime">The time in UTC format..</param>
        /// <param name="timeZoneOffset">The time zone offset..</param>
        [JsonConstructorAttribute]
        public ApiDateTime(DateTime utcTime = default, string timeZoneOffset = default)
        {
        }

        /// <summary>
        /// The time in UTC format.
        /// </summary>
        /// <value>The time in UTC format.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "utcTime", EmitDefaultValue = false)]
        public DateTime UtcTime { get; set; }

        /// <summary>
        /// The time zone offset.
        /// </summary>
        /// <value>The time zone offset.</value>
        /*
        <example>00:00:00</example>
        */
        [DataMember(Name = "timeZoneOffset", EmitDefaultValue = false)]
        public string TimeZoneOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiDateTime {\n");
            sb.Append("  UtcTime: ").Append(UtcTime).Append("\n");
            sb.Append("  TimeZoneOffset: ").Append(TimeZoneOffset).Append("\n");
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

    public class ApiDateTimeConverter : JsonConverter<ApiDateTime>
    {
        public override ApiDateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonString = reader.GetString();

            if (DateTimeOffset.TryParse(jsonString, out var dateTimeOffset))
            {
                return new ApiDateTime
                {
                    UtcTime = dateTimeOffset.UtcDateTime,
                    TimeZoneOffset = dateTimeOffset.Offset.ToString()
                };
            }
            else
            {
                throw new JsonException($"Unable to parse datetime: {jsonString}");
            }
        }

        public override void Write(Utf8JsonWriter writer, ApiDateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.UtcTime.ToString("o"));
        }
    }

}
