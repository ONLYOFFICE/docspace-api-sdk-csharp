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
    /// The file history information.
    /// </summary>
    [DataContract(Name = "HistoryDto")]
    public partial class HistoryDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryDto" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="initiator">initiator.</param>
        /// <param name="date">date.</param>
        /// <param name="data">data.</param>
        /// <param name="related">The list of related history..</param>
        public HistoryDto(HistoryAction action = default, EmployeeDto initiator = default, ApiDateTime date = default, HistoryData data = default, List<HistoryDto> related = default)
        {
            this.Action = action;
            this.Initiator = initiator;
            this.Date = date;
            this.Data = data;
            this.Related = related;
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public HistoryAction Action { get; set; }

        /// <summary>
        /// Gets or Sets Initiator
        /// </summary>
        [DataMember(Name = "initiator", EmitDefaultValue = false)]
        public EmployeeDto Initiator { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public HistoryData Data { get; set; }

        /// <summary>
        /// The list of related history.
        /// </summary>
        /// <value>The list of related history.</value>
        [DataMember(Name = "related", EmitDefaultValue = true)]
        public List<HistoryDto> Related { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryDto {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Initiator: ").Append(Initiator).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
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
