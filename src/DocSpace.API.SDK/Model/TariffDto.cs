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
    /// The subscription this portal runs on: its state, the end of the current period, and the quotas it is made of.
    /// </summary>
    [DataContract(Name = "TariffDto")]
    public partial class TariffDto : IValidatableObject
    {

        /// <summary>
        /// How the subscription stands: on trial, paid, inside the grace period that follows the due date, or unpaid.  It is the one field every caller gets, whatever their role, so a client can warn about payment without  needing administrator rights.
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public TariffState? State { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TariffDto" /> class.
        /// </summary>
        /// <param name="openSource">Whether the installation runs the open-source build, which has no paid plan at all. This flag and the two  below describe the build rather than the subscription, and all three are left empty for a caller without  the portal-settings right..</param>
        /// <param name="enterprise">Whether the installation runs on an Enterprise licence file, which is what makes the licence operations  under &#x60;api/2.0/settings/license&#x60; usable..</param>
        /// <param name="developer">Whether the installation runs on a Developer licence, an Enterprise licence meant for embedding rather  than for production use..</param>
        /// <param name="id">The identifier of the subscription record itself, for quoting when a charge has to be traced. It is filled  in for a caller with the portal-settings right only, and nothing accepts it as an argument..</param>
        /// <param name="state">How the subscription stands: on trial, paid, inside the grace period that follows the due date, or unpaid.  It is the one field every caller gets, whatever their role, so a client can warn about payment without  needing administrator rights..</param>
        /// <param name="dueDate">When the current period ends, in the portal time zone. It is filled in for a room or DocSpace  administrator only, and set to the largest value a date can hold for a subscription that never ends..</param>
        /// <param name="delayDueDate">When the grace period after &#x60;dueDate&#x60; runs out and the portal is cut off, in the portal time zone. Filled  in under the same conditions as &#x60;dueDate&#x60;, and equal to it when the plan grants no grace period..</param>
        /// <param name="licenseDate">When the licence file behind the subscription was issued, in the portal time zone. It is meaningful on a  server installation and filled in for a caller with the portal-settings right only..</param>
        /// <param name="customerId">The account in the billing system the subscription is charged to, empty for a portal that has never been  billed. Filled in for a caller with the portal-settings right only..</param>
        /// <param name="quotas">The quotas the subscription is made of - the plan itself and its add-ons - with the overdue ones listed  alongside the current ones, so an entry here is not proof that it is still being paid for; read each  entry&#39;s own &#x60;state&#x60; for that. Filled in for a caller with the portal-settings right only..</param>
        public TariffDto(bool? openSource = default, bool? enterprise = default, bool? developer = default, int id = default, TariffState? state = default, ApiDateTime dueDate = default, ApiDateTime delayDueDate = default, ApiDateTime licenseDate = default, string customerId = default, List<TariffQuotaDto> quotas = default)
        {
            this.OpenSource = openSource;
            this.Enterprise = enterprise;
            this.Developer = developer;
            this.Id = id;
            this.State = state;
            this.DueDate = dueDate;
            this.DelayDueDate = delayDueDate;
            this.LicenseDate = licenseDate;
            this.CustomerId = customerId;
            this.Quotas = quotas;
        }

        /// <summary>
        /// Whether the installation runs the open-source build, which has no paid plan at all. This flag and the two  below describe the build rather than the subscription, and all three are left empty for a caller without  the portal-settings right.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "openSource", EmitDefaultValue = true)]
        public bool? OpenSource { get; set; }

        /// <summary>
        /// Whether the installation runs on an Enterprise licence file, which is what makes the licence operations  under &#x60;api/2.0/settings/license&#x60; usable.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enterprise", EmitDefaultValue = true)]
        public bool? Enterprise { get; set; }

        /// <summary>
        /// Whether the installation runs on a Developer licence, an Enterprise licence meant for embedding rather  than for production use.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "developer", EmitDefaultValue = true)]
        public bool? Developer { get; set; }

        /// <summary>
        /// The identifier of the subscription record itself, for quoting when a charge has to be traced. It is filled  in for a caller with the portal-settings right only, and nothing accepts it as an argument.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// When the current period ends, in the portal time zone. It is filled in for a room or DocSpace  administrator only, and set to the largest value a date can hold for a subscription that never ends.
        /// </summary>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        public ApiDateTime DueDate { get; set; }

        /// <summary>
        /// When the grace period after &#x60;dueDate&#x60; runs out and the portal is cut off, in the portal time zone. Filled  in under the same conditions as &#x60;dueDate&#x60;, and equal to it when the plan grants no grace period.
        /// </summary>
        [DataMember(Name = "delayDueDate", EmitDefaultValue = false)]
        public ApiDateTime DelayDueDate { get; set; }

        /// <summary>
        /// When the licence file behind the subscription was issued, in the portal time zone. It is meaningful on a  server installation and filled in for a caller with the portal-settings right only.
        /// </summary>
        [DataMember(Name = "licenseDate", EmitDefaultValue = false)]
        public ApiDateTime LicenseDate { get; set; }

        /// <summary>
        /// The account in the billing system the subscription is charged to, empty for a portal that has never been  billed. Filled in for a caller with the portal-settings right only.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000001</example>
        [DataMember(Name = "customerId", EmitDefaultValue = true)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The quotas the subscription is made of - the plan itself and its add-ons - with the overdue ones listed  alongside the current ones, so an entry here is not proof that it is still being paid for; read each  entry&#39;s own &#x60;state&#x60; for that. Filled in for a caller with the portal-settings right only.
        /// </summary>
        /// <example>[{"id":1,"quantity":500}]</example>
        [DataMember(Name = "quotas", EmitDefaultValue = true)]
        public List<TariffQuotaDto> Quotas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TariffDto {\n");
            sb.Append("  OpenSource: ").Append(OpenSource).Append("\n");
            sb.Append("  Enterprise: ").Append(Enterprise).Append("\n");
            sb.Append("  Developer: ").Append(Developer).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  DelayDueDate: ").Append(DelayDueDate).Append("\n");
            sb.Append("  LicenseDate: ").Append(LicenseDate).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Quotas: ").Append(Quotas).Append("\n");
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
