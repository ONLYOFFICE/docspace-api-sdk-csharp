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
    /// The backup cron parameters.
    /// </summary>
    [DataContract(Name = "Cron")]
    public partial class Cron : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public BackupPeriod? Period { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Cron" /> class.
        /// </summary>
        /// <param name="period">period.</param>
        /// <param name="hour">The time of the day to start the backup process..</param>
        /// <param name="day">The day of the week to start the backup process..</param>
        public Cron(BackupPeriod? period = default, int hour = default, int? day = default)
        {
            this.Period = period;
            this.Hour = hour;
            this.Day = day;
        }

        /// <summary>
        /// The time of the day to start the backup process.
        /// </summary>
        /// <value>The time of the day to start the backup process.</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "hour", EmitDefaultValue = false)]
        public int Hour { get; set; }

        /// <summary>
        /// The day of the week to start the backup process.
        /// </summary>
        /// <value>The day of the week to start the backup process.</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "day", EmitDefaultValue = true)]
        public int? Day { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cron {\n");
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
