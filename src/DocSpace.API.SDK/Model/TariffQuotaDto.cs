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
    /// One quota the subscription is made of - the plan itself or an add-on - with its quantity and its own deadline.
    /// </summary>
    [DataContract(Name = "TariffQuotaDto")]
    public partial class TariffQuotaDto : IValidatableObject
    {

        /// <summary>
        /// Whether the quota is still running or its deadline has passed. It is empty for a quota that has no  deadline of its own, which means it lasts as long as the subscription does.
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public QuotaState? State { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TariffQuotaDto" /> class.
        /// </summary>
        /// <param name="id">The quota this entry stands for. &#x60;GET api/2.0/portal/payment/quotas&#x60; describes the quota behind the ID,  including what its &#x60;quantity&#x60; counts; a negative ID belongs to a built-in quota rather than a purchased  one..</param>
        /// <param name="quantity">How much of the quota the portal holds, in whatever the quota itself is measured in - seats for a plan,  gigabytes for storage. It is &#x60;1&#x60; for a quota that is simply on or off..</param>
        /// <param name="wallet">Whether the quota is paid for out of the portal wallet as it is consumed, rather than being part of the  subscription charged per period..</param>
        /// <param name="additional">Whether this is an add-on bought on top of the plan rather than the plan itself. Exactly one entry of  &#x60;quotas&#x60; is the plan, and the rest are add-ons..</param>
        /// <param name="dueDate">When this quota runs out, in the portal time zone. An add-on can end earlier or later than the  subscription; a quota with no deadline of its own reports the subscription&#39;s &#x60;dueDate&#x60; instead of an empty  value..</param>
        /// <param name="nextQuantity">The quantity the next period is going to be charged for, when a change has been scheduled. It is empty  while &#x60;quantity&#x60; simply carries over..</param>
        /// <param name="nextQuota">The quota this one is scheduled to be replaced by at the start of the next period, empty when no such  switch is planned. &#x60;GET api/2.0/portal/tariff/upcoming&#x60; already reports the charge for the replacement..</param>
        /// <param name="state">Whether the quota is still running or its deadline has passed. It is empty for a quota that has no  deadline of its own, which means it lasts as long as the subscription does..</param>
        public TariffQuotaDto(int id = default, int quantity = default, bool wallet = default, bool additional = default, ApiDateTime dueDate = default, int? nextQuantity = default, int? nextQuota = default, QuotaState? state = default)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Wallet = wallet;
            this.Additional = additional;
            this.DueDate = dueDate;
            this.NextQuantity = nextQuantity;
            this.NextQuota = nextQuota;
            this.State = state;
        }

        /// <summary>
        /// The quota this entry stands for. &#x60;GET api/2.0/portal/payment/quotas&#x60; describes the quota behind the ID,  including what its &#x60;quantity&#x60; counts; a negative ID belongs to a built-in quota rather than a purchased  one.
        /// </summary>
        /// <example>-11</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// How much of the quota the portal holds, in whatever the quota itself is measured in - seats for a plan,  gigabytes for storage. It is &#x60;1&#x60; for a quota that is simply on or off.
        /// </summary>
        /// <example>500</example>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Whether the quota is paid for out of the portal wallet as it is consumed, rather than being part of the  subscription charged per period.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "wallet", EmitDefaultValue = true)]
        public bool Wallet { get; set; }

        /// <summary>
        /// Whether this is an add-on bought on top of the plan rather than the plan itself. Exactly one entry of  &#x60;quotas&#x60; is the plan, and the rest are add-ons.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "additional", EmitDefaultValue = true)]
        public bool Additional { get; set; }

        /// <summary>
        /// When this quota runs out, in the portal time zone. An add-on can end earlier or later than the  subscription; a quota with no deadline of its own reports the subscription&#39;s &#x60;dueDate&#x60; instead of an empty  value.
        /// </summary>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        public ApiDateTime DueDate { get; set; }

        /// <summary>
        /// The quantity the next period is going to be charged for, when a change has been scheduled. It is empty  while &#x60;quantity&#x60; simply carries over.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "nextQuantity", EmitDefaultValue = true)]
        public int? NextQuantity { get; set; }

        /// <summary>
        /// The quota this one is scheduled to be replaced by at the start of the next period, empty when no such  switch is planned. &#x60;GET api/2.0/portal/tariff/upcoming&#x60; already reports the charge for the replacement.
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "nextQuota", EmitDefaultValue = true)]
        public int? NextQuota { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TariffQuotaDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  Additional: ").Append(Additional).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  NextQuantity: ").Append(NextQuantity).Append("\n");
            sb.Append("  NextQuota: ").Append(NextQuota).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
