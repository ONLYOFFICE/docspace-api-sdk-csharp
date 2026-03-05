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
    [DataContract(Name = "Tariff")]
    public partial class Tariff : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public TariffState? State { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Tariff" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tariff() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tariff" /> class.
        /// </summary>
        /// <param name="id">The tariff ID..</param>
        /// <param name="state">state.</param>
        /// <param name="dueDate">The tariff due date. (required).</param>
        /// <param name="delayDueDate">The tariff delay due date..</param>
        /// <param name="licenseDate">The tariff license date..</param>
        /// <param name="customerId">The tariff customer ID..</param>
        /// <param name="quotas">The list of tariff quotas. (required).</param>
        /// <param name="overdueQuotas">The list of overdue tariff quotas..</param>
        public Tariff(int id = default, TariffState? state = default, DateTime dueDate = default, DateTime delayDueDate = default, DateTime licenseDate = default, string customerId = default, List<Quota> quotas = default, List<Quota> overdueQuotas = default)
        {
            this.DueDate = dueDate;
            // to ensure "quotas" is required (not null)
            if (quotas == null)
            {
                throw new ArgumentNullException("quotas is a required property for Tariff and cannot be null");
            }
            this.Quotas = quotas;
            this.Id = id;
            this.State = state;
            this.DelayDueDate = delayDueDate;
            this.LicenseDate = licenseDate;
            this.CustomerId = customerId;
            this.OverdueQuotas = overdueQuotas;
        }

        /// <summary>
        /// The tariff ID.
        /// </summary>
        /// <value>The tariff ID.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The tariff due date.
        /// </summary>
        /// <value>The tariff due date.</value>
        /*
        <example>2026-03-31T00:00Z</example>
        */
        [DataMember(Name = "dueDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// The tariff delay due date.
        /// </summary>
        /// <value>The tariff delay due date.</value>
        /*
        <example>2026-04-07T00:00Z</example>
        */
        [DataMember(Name = "delayDueDate", EmitDefaultValue = false)]
        public DateTime DelayDueDate { get; set; }

        /// <summary>
        /// The tariff license date.
        /// </summary>
        /// <value>The tariff license date.</value>
        /*
        <example>2026-03-01T00:00Z</example>
        */
        [DataMember(Name = "licenseDate", EmitDefaultValue = false)]
        public DateTime LicenseDate { get; set; }

        /// <summary>
        /// The tariff customer ID.
        /// </summary>
        /// <value>The tariff customer ID.</value>
        /*
        <example>cus_123</example>
        */
        [DataMember(Name = "customerId", EmitDefaultValue = true)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The list of tariff quotas.
        /// </summary>
        /// <value>The list of tariff quotas.</value>
        /*
        <example>{&quot;quotas&quot;:[{&quot;id&quot;:1,&quot;quantity&quot;:50,&quot;wallet&quot;:false}]}</example>
        */
        [DataMember(Name = "quotas", IsRequired = true, EmitDefaultValue = true)]
        public List<Quota> Quotas { get; set; }

        /// <summary>
        /// The list of overdue tariff quotas.
        /// </summary>
        /// <value>The list of overdue tariff quotas.</value>
        /*
        <example>[]</example>
        */
        [DataMember(Name = "overdueQuotas", EmitDefaultValue = true)]
        public List<Quota> OverdueQuotas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tariff {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  DelayDueDate: ").Append(DelayDueDate).Append("\n");
            sb.Append("  LicenseDate: ").Append(LicenseDate).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Quotas: ").Append(Quotas).Append("\n");
            sb.Append("  OverdueQuotas: ").Append(OverdueQuotas).Append("\n");
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
