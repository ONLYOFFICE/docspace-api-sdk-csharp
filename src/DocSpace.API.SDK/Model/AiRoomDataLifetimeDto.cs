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
    /// The rule by which the files of a room are removed once they have been lying in it for too long.
    /// </summary>
    [DataContract(Name = "AiRoomDataLifetimeDto")]
    public partial class AiRoomDataLifetimeDto : IValidatableObject
    {

        /// <summary>
        /// The unit the age is counted in. Months and years are counted as calendar ones, so the same number of them  covers a different number of days depending on when the clean-up runs.
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public AiRoomDataLifetimePeriod? Period { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiRoomDataLifetimeDto" /> class.
        /// </summary>
        /// <param name="deletePermanently">Decides what happens to a file that has grown too old: it is erased outright, or it is moved to the trash of  the account that created the room, from where it can still be brought back..</param>
        /// <param name="period">The unit the age is counted in. Months and years are counted as calendar ones, so the same number of them  covers a different number of days depending on when the clean-up runs..</param>
        /// <param name="value">How many periods a file may stay in the room, counted from the moment it was last changed rather than from the  moment the rule was set. Files that are already older than this are removed by the next clean-up..</param>
        /// <param name="enabled">Switches the rule on and off. Switching it off erases the rule instead of keeping it aside, so afterwards the  room reports no rule at all and the other three values have to be sent again to bring it back..</param>
        public AiRoomDataLifetimeDto(bool deletePermanently = default, AiRoomDataLifetimePeriod? period = default, int? value = default, bool? enabled = default)
        {
            this.DeletePermanently = deletePermanently;
            this.Period = period;
            this.Value = value;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Decides what happens to a file that has grown too old: it is erased outright, or it is moved to the trash of  the account that created the room, from where it can still be brought back.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "deletePermanently", EmitDefaultValue = true)]
        public bool DeletePermanently { get; set; }

        /// <summary>
        /// How many periods a file may stay in the room, counted from the moment it was last changed rather than from the  moment the rule was set. Files that are already older than this are removed by the next clean-up.
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public int? Value { get; set; }

        /// <summary>
        /// Switches the rule on and off. Switching it off erases the rule instead of keeping it aside, so afterwards the  room reports no rule at all and the other three values have to be sent again to bring it back.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiRoomDataLifetimeDto {\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
