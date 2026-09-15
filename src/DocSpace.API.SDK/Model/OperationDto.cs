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
    /// One movement on the portal wallet: what it was for, who caused it, and how much money it moved.
    /// </summary>
    [DataContract(Name = "OperationDto")]
    public partial class OperationDto : IValidatableObject
    {

        /// <summary>
        /// What kind of movement this is - a payment, a charge, a refund, a correction. It is what the &#x60;type&#x60; filter  matches on, and &#x60;Unknown&#x60; covers a movement the billing service reported under a kind this build does not  recognise.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public OperationType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationDto" /> class.
        /// </summary>
        /// <param name="date">When the movement was booked, in the portal time zone - the same zone the &#x60;startDate&#x60; and &#x60;endDate&#x60;  filters are read in, so the two do line up here..</param>
        /// <param name="service">The wallet service the movement belongs to, by its stable key. It is what the &#x60;serviceName&#x60; filter  matches on, and it is empty for a movement that belongs to no service, such as a top-up..</param>
        /// <param name="description">A one-line summary of the movement in the portal language, already composed from the service and the  quantity - meant to be printed as it is rather than parsed..</param>
        /// <param name="details">The longer explanation of the same movement, where the service recorded one. It is empty for a movement  that has nothing to add to &#x60;description&#x60;..</param>
        /// <param name="serviceUnit">What &#x60;quantity&#x60; counts for this service, in the portal language. AI consumption is reported in tokens  here rather than in the AI credits the service is sold in..</param>
        /// <param name="quantity">How many units the movement covers, in the unit named by &#x60;serviceUnit&#x60;. It is &#x60;0&#x60; for a movement that  moves money without consuming a service..</param>
        /// <param name="currency">The currency &#x60;credit&#x60; and &#x60;debit&#x60; are expressed in, as a three-letter ISO 4217 code. It is the accounting  currency of the wallet, which need not be the currency the subscription is priced in..</param>
        /// <param name="credit">The amount that went into the wallet. It is &#x60;0&#x60; on a movement that only took money out, so the pair of  &#x60;credit&#x60; and &#x60;debit&#x60; is what shows which way the money went; the &#x60;credit&#x60; and &#x60;debit&#x60; filters of the  operation select the two directions by exactly this..</param>
        /// <param name="debit">The amount that was taken out of the wallet, &#x60;0&#x60; on a movement that put money in..</param>
        /// <param name="participantName">Who caused the movement, as the billing service records them - an internal name, which is what the  &#x60;participantName&#x60; filter matches on. Show &#x60;participantDisplayName&#x60; instead..</param>
        /// <param name="participantDisplayName">The same person as their portal display name. It falls back to &#x60;participantName&#x60; when the name belongs to  no portal account, so it is never empty while &#x60;participantName&#x60; is filled..</param>
        /// <param name="sourceType">What kind of thing an AI operation was run on - an agent, a file, a folder, a room or a form. It is empty  on any movement that is not an AI charge..</param>
        /// <param name="sourceTitle">The title that thing had when the operation ran, kept as recorded, so it does not follow a later rename.  Empty under the same conditions as &#x60;sourceType&#x60;..</param>
        /// <param name="sourceId">The identifier of that thing, to look it up in the module it belongs to. Empty under the same conditions  as &#x60;sourceType&#x60;..</param>
        /// <param name="type">What kind of movement this is - a payment, a charge, a refund, a correction. It is what the &#x60;type&#x60; filter  matches on, and &#x60;Unknown&#x60; covers a movement the billing service reported under a kind this build does not  recognise..</param>
        public OperationDto(ApiDateTime date = default, string service = default, string description = default, string details = default, string serviceUnit = default, int quantity = default, string currency = default, double credit = default, double debit = default, string participantName = default, string participantDisplayName = default, string sourceType = default, string sourceTitle = default, string sourceId = default, OperationType? type = default)
        {
            this.Date = date;
            this.Service = service;
            this.Description = description;
            this.Details = details;
            this.ServiceUnit = serviceUnit;
            this.Quantity = quantity;
            this.Currency = currency;
            this.Credit = credit;
            this.Debit = debit;
            this.ParticipantName = participantName;
            this.ParticipantDisplayName = participantDisplayName;
            this.SourceType = sourceType;
            this.SourceTitle = sourceTitle;
            this.SourceId = sourceId;
            this.Type = type;
        }

        /// <summary>
        /// When the movement was booked, in the portal time zone - the same zone the &#x60;startDate&#x60; and &#x60;endDate&#x60;  filters are read in, so the two do line up here.
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// The wallet service the movement belongs to, by its stable key. It is what the &#x60;serviceName&#x60; filter  matches on, and it is empty for a movement that belongs to no service, such as a top-up.
        /// </summary>
        /// <example>disk-storage</example>
        [DataMember(Name = "service", EmitDefaultValue = true)]
        public string Service { get; set; }

        /// <summary>
        /// A one-line summary of the movement in the portal language, already composed from the service and the  quantity - meant to be printed as it is rather than parsed.
        /// </summary>
        /// <example>Storage quota increase</example>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The longer explanation of the same movement, where the service recorded one. It is empty for a movement  that has nothing to add to &#x60;description&#x60;.
        /// </summary>
        /// <example>Increased storage from 50GB to 100GB</example>
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public string Details { get; set; }

        /// <summary>
        /// What &#x60;quantity&#x60; counts for this service, in the portal language. AI consumption is reported in tokens  here rather than in the AI credits the service is sold in.
        /// </summary>
        /// <example>GB</example>
        [DataMember(Name = "serviceUnit", EmitDefaultValue = true)]
        public string ServiceUnit { get; set; }

        /// <summary>
        /// How many units the movement covers, in the unit named by &#x60;serviceUnit&#x60;. It is &#x60;0&#x60; for a movement that  moves money without consuming a service.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The currency &#x60;credit&#x60; and &#x60;debit&#x60; are expressed in, as a three-letter ISO 4217 code. It is the accounting  currency of the wallet, which need not be the currency the subscription is priced in.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The amount that went into the wallet. It is &#x60;0&#x60; on a movement that only took money out, so the pair of  &#x60;credit&#x60; and &#x60;debit&#x60; is what shows which way the money went; the &#x60;credit&#x60; and &#x60;debit&#x60; filters of the  operation select the two directions by exactly this.
        /// </summary>
        /// <example>99.99</example>
        [DataMember(Name = "credit", EmitDefaultValue = false)]
        public double Credit { get; set; }

        /// <summary>
        /// The amount that was taken out of the wallet, &#x60;0&#x60; on a movement that put money in.
        /// </summary>
        /// <example>99.99</example>
        [DataMember(Name = "debit", EmitDefaultValue = false)]
        public double Debit { get; set; }

        /// <summary>
        /// Who caused the movement, as the billing service records them - an internal name, which is what the  &#x60;participantName&#x60; filter matches on. Show &#x60;participantDisplayName&#x60; instead.
        /// </summary>
        /// <example>john.doe@example.com</example>
        [DataMember(Name = "participantName", EmitDefaultValue = true)]
        public string ParticipantName { get; set; }

        /// <summary>
        /// The same person as their portal display name. It falls back to &#x60;participantName&#x60; when the name belongs to  no portal account, so it is never empty while &#x60;participantName&#x60; is filled.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "participantDisplayName", EmitDefaultValue = true)]
        public string ParticipantDisplayName { get; set; }

        /// <summary>
        /// What kind of thing an AI operation was run on - an agent, a file, a folder, a room or a form. It is empty  on any movement that is not an AI charge.
        /// </summary>
        /// <example>Agent</example>
        [DataMember(Name = "sourceType", EmitDefaultValue = true)]
        public string SourceType { get; set; }

        /// <summary>
        /// The title that thing had when the operation ran, kept as recorded, so it does not follow a later rename.  Empty under the same conditions as &#x60;sourceType&#x60;.
        /// </summary>
        /// <example>My AI Agent</example>
        [DataMember(Name = "sourceTitle", EmitDefaultValue = true)]
        public string SourceTitle { get; set; }

        /// <summary>
        /// The identifier of that thing, to look it up in the module it belongs to. Empty under the same conditions  as &#x60;sourceType&#x60;.
        /// </summary>
        /// <example>123</example>
        [DataMember(Name = "sourceId", EmitDefaultValue = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationDto {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  ServiceUnit: ").Append(ServiceUnit).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Debit: ").Append(Debit).Append("\n");
            sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
            sb.Append("  ParticipantDisplayName: ").Append(ParticipantDisplayName).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceTitle: ").Append(SourceTitle).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
