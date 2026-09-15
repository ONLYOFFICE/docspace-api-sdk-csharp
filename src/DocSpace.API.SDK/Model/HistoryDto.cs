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
    /// One record of the activity log of a file or a folder.
    /// </summary>
    [DataContract(Name = "HistoryDto")]
    public partial class HistoryDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HistoryDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryDto" /> class.
        /// </summary>
        /// <param name="id">The identifier of the record, which tells two records of the same action apart and stays stable as long as the  portal keeps the log. (required).</param>
        /// <param name="action">What happened - the kind of event the record stands for, such as a file being uploaded, renamed, moved or  shared - with the key a client can key its own wording off. (required).</param>
        /// <param name="initiator">Who caused the event. For an event caused by a visitor following an external link only the name they gave is  filled in, the account fields staying empty. (required).</param>
        /// <param name="date">When the event happened, written with the offset of the portal&#39;s time zone. (required).</param>
        /// <param name="data">The history data. Absent for actions that carry no payload of their own - changing a room&#39;s  logo, icon colour or cover, whose interpreter returns no data (see  &#x60;RoomLogoChangedInterpreter&#x60;). It used to be declared required, which put it in the  OpenAPI document&#39;s required list while the null-dropping serializer left it out of the  response, so a generated client threw on any history page holding one of those entries..</param>
        /// <param name="related">The records folded into this one because they belong to the same action, the separate files of one upload for  instance. It is empty when the record stands alone, and the records inside it carry no further nesting..</param>
        public HistoryDto(int id = default, HistoryAction action = default, EmployeeDto initiator = default, ApiDateTime date = default, HistoryData data = default, List<HistoryDto> related = default)
        {
            this.Id = id;
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new ArgumentNullException("action is a required property for HistoryDto and cannot be null");
            }
            this.Action = action;
            // to ensure "initiator" is required (not null)
            if (initiator == null)
            {
                throw new ArgumentNullException("initiator is a required property for HistoryDto and cannot be null");
            }
            this.Initiator = initiator;
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new ArgumentNullException("date is a required property for HistoryDto and cannot be null");
            }
            this.Date = date;
            this.Data = data;
            this.Related = related;
        }

        /// <summary>
        /// The identifier of the record, which tells two records of the same action apart and stays stable as long as the  portal keeps the log.
        /// </summary>
        /// <example>123</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// What happened - the kind of event the record stands for, such as a file being uploaded, renamed, moved or  shared - with the key a client can key its own wording off.
        /// </summary>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public HistoryAction Action { get; set; }

        /// <summary>
        /// Who caused the event. For an event caused by a visitor following an external link only the name they gave is  filled in, the account fields staying empty.
        /// </summary>
        [DataMember(Name = "initiator", IsRequired = true, EmitDefaultValue = true)]
        public EmployeeDto Initiator { get; set; }

        /// <summary>
        /// When the event happened, written with the offset of the portal&#39;s time zone.
        /// </summary>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// The history data. Absent for actions that carry no payload of their own - changing a room&#39;s  logo, icon colour or cover, whose interpreter returns no data (see  &#x60;RoomLogoChangedInterpreter&#x60;). It used to be declared required, which put it in the  OpenAPI document&#39;s required list while the null-dropping serializer left it out of the  response, so a generated client threw on any history page holding one of those entries.
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public HistoryData Data { get; set; }

        /// <summary>
        /// The records folded into this one because they belong to the same action, the separate files of one upload for  instance. It is empty when the record stands alone, and the records inside it carry no further nesting.
        /// </summary>
        /// <example>[{"id":124,"action":0}]</example>
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
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
