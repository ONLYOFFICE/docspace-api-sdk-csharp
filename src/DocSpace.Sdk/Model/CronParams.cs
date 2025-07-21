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
    /// CronParams
    /// </summary>
    [DataContract(Name = "CronParams")]
    public partial class CronParams : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public BackupPeriod? Period { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CronParams" /> class.
        /// </summary>
        /// <param name="period">period.</param>
        /// <param name="hour">hour.</param>
        /// <param name="day">day.</param>
        public CronParams(BackupPeriod? period = default, int hour = default, int day = default)
        {
            this.Period = period;
            this.Hour = hour;
            this.Day = day;
        }

        /// <summary>
        /// Gets or Sets Hour
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "hour", EmitDefaultValue = false)]
        public int Hour { get; set; }

        /// <summary>
        /// Gets or Sets Day
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "day", EmitDefaultValue = false)]
        public int Day { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CronParams {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  Day: ").Append(Day).Append("\n");
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
