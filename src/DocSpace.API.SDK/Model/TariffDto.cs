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
    /// The tariff parameters.
    /// </summary>
    [DataContract(Name = "TariffDto")]
    public partial class TariffDto : IValidatableObject
    {

        /// <summary>
        /// The tariff state.
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public TariffState? State { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TariffDto" /> class.
        /// </summary>
        /// <param name="openSource">Specifies whether the tariff is Community or not..</param>
        /// <param name="enterprise">Specifies whether the tariff is Enterprise or not..</param>
        /// <param name="developer">Specifies whether the tariff is Developer or not..</param>
        /// <param name="id">The tariff ID..</param>
        /// <param name="state">The tariff state..</param>
        /// <param name="dueDate">The tariff due date..</param>
        /// <param name="delayDueDate">The tariff delay due date..</param>
        /// <param name="licenseDate">The tariff license date..</param>
        /// <param name="customerId">The customer ID..</param>
        /// <param name="quotas">The list of quotas..</param>
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
        /// Specifies whether the tariff is Community or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "openSource", EmitDefaultValue = true)]
        public bool? OpenSource { get; set; }

        /// <summary>
        /// Specifies whether the tariff is Enterprise or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enterprise", EmitDefaultValue = true)]
        public bool? Enterprise { get; set; }

        /// <summary>
        /// Specifies whether the tariff is Developer or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "developer", EmitDefaultValue = true)]
        public bool? Developer { get; set; }

        /// <summary>
        /// The tariff ID.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The tariff due date.
        /// </summary>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        public ApiDateTime DueDate { get; set; }

        /// <summary>
        /// The tariff delay due date.
        /// </summary>
        [DataMember(Name = "delayDueDate", EmitDefaultValue = false)]
        public ApiDateTime DelayDueDate { get; set; }

        /// <summary>
        /// The tariff license date.
        /// </summary>
        [DataMember(Name = "licenseDate", EmitDefaultValue = false)]
        public ApiDateTime LicenseDate { get; set; }

        /// <summary>
        /// The customer ID.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000001</example>
        [DataMember(Name = "customerId", EmitDefaultValue = true)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The list of quotas.
        /// </summary>
        /// <example>[{"id":1,"title":"Basic Plan"}]</example>
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
