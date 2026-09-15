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
    /// The filters that select which wallet movements are reported: the services, the period, the participant, the  direction and the outcome of the movement, and the ordering.
    /// </summary>
    [DataContract(Name = "CustomerOperationsReportRequestDto")]
    public partial class CustomerOperationsReportRequestDto : IValidatableObject
    {

        /// <summary>
        /// The kind of movement to keep, which says what caused the money to move rather than how it ended. Every kind  is reported when it is omitted.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public OperationType? Type { get; set; }

        /// <summary>
        /// The outcome to keep. A movement that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is reported when this is omitted.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public OperationStatus? Status { get; set; }

        /// <summary>
        /// The direction the field named in &#x60;orderBy&#x60; is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly.
        /// </summary>
        [DataMember(Name = "orderType", EmitDefaultValue = false)]
        public OperationOrderType? OrderType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerOperationsReportRequestDto" /> class.
        /// </summary>
        /// <param name="serviceName">The wallet services whose movements are kept, named the way the billing catalogue names them - &#x60;backup&#x60;,  &#x60;ai-tools&#x60;, &#x60;ai-search&#x60;, &#x60;disk-storage&#x60;, &#x60;docscloud&#x60;. Take the values from the &#x60;serviceName&#x60; field of  &#x60;GET api/2.0/portal/payment/walletservices&#x60;; the match ignores case, a name this installation does not sell  fails the call with 404, and an omitted list keeps every service. A bare string is accepted in place of an  array for backward compatibility..</param>
        /// <param name="startDate">The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, so a  movement at the edge of the period falls where the portal sees it; defaults to the portal creation date..</param>
        /// <param name="endDate">The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made..</param>
        /// <param name="participantName">The participant whose movements are kept - the account the accounting service records as the cause of a  movement. A movement caused by a portal user carries that user ID here, and one caused by the portal itself  carries the customer name; surrounding whitespace is trimmed, and an omitted value keeps every participant..</param>
        /// <param name="credit">Whether movements that add money to the wallet - top-ups, refunds and corrections in the portal&#39;s favour -  are kept. Both directions are reported when neither this nor &#x60;debit&#x60; is given..</param>
        /// <param name="debit">Whether movements that take money out of the wallet - the charges of the wallet services - are kept. Both  directions are reported when neither this nor &#x60;credit&#x60; is given..</param>
        /// <param name="type">The kind of movement to keep, which says what caused the money to move rather than how it ended. Every kind  is reported when it is omitted..</param>
        /// <param name="status">The outcome to keep. A movement that is still being settled is reported as pending and may change later,  while the other outcomes are final; every outcome is reported when this is omitted..</param>
        /// <param name="orderBy">The name of the field the movements are sorted by, spelled as the accounting service names it, such as  &#x60;StartDate&#x60; or &#x60;ServiceName&#x60;. Surrounding whitespace is trimmed, and the accounting service applies its own  ordering when this is omitted..</param>
        /// <param name="orderType">The direction the field named in &#x60;orderBy&#x60; is sorted in. Newest or largest first is what the accounting  service does by default, so leaving this out sorts the same way as asking for descending explicitly..</param>
        public CustomerOperationsReportRequestDto(List<string> serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string participantName = default, bool? credit = default, bool? debit = default, OperationType? type = default, OperationStatus? status = default, string orderBy = default, OperationOrderType? orderType = default)
        {
            this.ServiceName = serviceName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ParticipantName = participantName;
            this.Credit = credit;
            this.Debit = debit;
            this.Type = type;
            this.Status = status;
            this.OrderBy = orderBy;
            this.OrderType = orderType;
        }

        /// <summary>
        /// The wallet services whose movements are kept, named the way the billing catalogue names them - &#x60;backup&#x60;,  &#x60;ai-tools&#x60;, &#x60;ai-search&#x60;, &#x60;disk-storage&#x60;, &#x60;docscloud&#x60;. Take the values from the &#x60;serviceName&#x60; field of  &#x60;GET api/2.0/portal/payment/walletservices&#x60;; the match ignores case, a name this installation does not sell  fails the call with 404, and an omitted list keeps every service. A bare string is accepted in place of an  array for backward compatibility.
        /// </summary>
        /// <example>[backup]</example>
        [DataMember(Name = "serviceName", EmitDefaultValue = true)]
        public List<string> ServiceName { get; set; }

        /// <summary>
        /// The beginning of the reported period, inclusive. Read in the portal time zone rather than in UTC, so a  movement at the edge of the period falls where the portal sees it; defaults to the portal creation date.
        /// </summary>
        /// <example>2024-01-01T00:00:00Z</example>
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end of the reported period, inclusive. Read in the portal time zone rather than in UTC, and defaults to  the moment the call is made.
        /// </summary>
        /// <example>2024-01-31T23:59:59Z</example>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The participant whose movements are kept - the account the accounting service records as the cause of a  movement. A movement caused by a portal user carries that user ID here, and one caused by the portal itself  carries the customer name; surrounding whitespace is trimmed, and an omitted value keeps every participant.
        /// </summary>
        /// <example>My Own Corporation</example>
        [DataMember(Name = "participantName", EmitDefaultValue = true)]
        public string ParticipantName { get; set; }

        /// <summary>
        /// Whether movements that add money to the wallet - top-ups, refunds and corrections in the portal&#39;s favour -  are kept. Both directions are reported when neither this nor &#x60;debit&#x60; is given.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "credit", EmitDefaultValue = true)]
        public bool? Credit { get; set; }

        /// <summary>
        /// Whether movements that take money out of the wallet - the charges of the wallet services - are kept. Both  directions are reported when neither this nor &#x60;credit&#x60; is given.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "debit", EmitDefaultValue = true)]
        public bool? Debit { get; set; }

        /// <summary>
        /// The name of the field the movements are sorted by, spelled as the accounting service names it, such as  &#x60;StartDate&#x60; or &#x60;ServiceName&#x60;. Surrounding whitespace is trimmed, and the accounting service applies its own  ordering when this is omitted.
        /// </summary>
        /// <example>StartDate</example>
        [DataMember(Name = "orderBy", EmitDefaultValue = true)]
        public string OrderBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerOperationsReportRequestDto {\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Debit: ").Append(Debit).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
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
