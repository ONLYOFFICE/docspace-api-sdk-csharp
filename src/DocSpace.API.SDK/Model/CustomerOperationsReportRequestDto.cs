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
    /// The request parameters for generating a report on client operations.
    /// </summary>
    [DataContract(Name = "CustomerOperationsReportRequestDto")]
    public partial class CustomerOperationsReportRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name = "types", EmitDefaultValue = false)]
        public OperationType? Types { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public OperationStatus? Status { get; set; }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name = "orderType", EmitDefaultValue = false)]
        public OperationOrderType? OrderType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerOperationsReportRequestDto" /> class.
        /// </summary>
        /// <param name="serviceName">The service name..</param>
        /// <param name="startDate">The report start date..</param>
        /// <param name="endDate">The report end date..</param>
        /// <param name="participantName">The participant name..</param>
        /// <param name="credit">Specifies whether to include credit operations in the report..</param>
        /// <param name="debit">Specifies whether to include debit operations in the report..</param>
        /// <param name="types">types.</param>
        /// <param name="status">status.</param>
        /// <param name="orderBy">The field to order by..</param>
        /// <param name="orderType">orderType.</param>
        public CustomerOperationsReportRequestDto(string serviceName = default, DateTime? startDate = default, DateTime? endDate = default, string participantName = default, bool? credit = default, bool? debit = default, OperationType? types = default, OperationStatus? status = default, string orderBy = default, OperationOrderType? orderType = default)
        {
            this.ServiceName = serviceName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ParticipantName = participantName;
            this.Credit = credit;
            this.Debit = debit;
            this.Types = types;
            this.Status = status;
            this.OrderBy = orderBy;
            this.OrderType = orderType;
        }

        /// <summary>
        /// The service name.
        /// </summary>
        /// <value>The service name.</value>
        /*
        <example>aitools</example>
        */
        [DataMember(Name = "serviceName", EmitDefaultValue = true)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The report start date.
        /// </summary>
        /// <value>The report start date.</value>
        /*
        <example>2024-01-01T00:00Z</example>
        */
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The report end date.
        /// </summary>
        /// <value>The report end date.</value>
        /*
        <example>2024-01-31T23:59:59Z</example>
        */
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The participant name.
        /// </summary>
        /// <value>The participant name.</value>
        /*
        <example>ACME Corp</example>
        */
        [DataMember(Name = "participantName", EmitDefaultValue = true)]
        public string ParticipantName { get; set; }

        /// <summary>
        /// Specifies whether to include credit operations in the report.
        /// </summary>
        /// <value>Specifies whether to include credit operations in the report.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "credit", EmitDefaultValue = true)]
        public bool? Credit { get; set; }

        /// <summary>
        /// Specifies whether to include debit operations in the report.
        /// </summary>
        /// <value>Specifies whether to include debit operations in the report.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "debit", EmitDefaultValue = true)]
        public bool? Debit { get; set; }

        /// <summary>
        /// The field to order by.
        /// </summary>
        /// <value>The field to order by.</value>
        /*
        <example>StartDate</example>
        */
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
            sb.Append("  Types: ").Append(Types).Append("\n");
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
