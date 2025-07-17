/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
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
        /// <param name="id">The tariff ID..</param>
        /// <param name="state">state.</param>
        /// <param name="dueDate">The tariff due date..</param>
        /// <param name="delayDueDate">The tariff delay due date..</param>
        /// <param name="licenseDate">The tariff license date..</param>
        /// <param name="customerId">The tariff customer ID..</param>
        /// <param name="quotas">The list of tariff quotas..</param>
        /// <param name="overdueQuotas">The list of overdue tariff quotas..</param>
        public Tariff(int id = default, TariffState? state = default, DateTime dueDate = default, DateTime delayDueDate = default, DateTime licenseDate = default, string customerId = default, List<Quota> quotas = default, List<Quota> overdueQuotas = default)
        {
            this.Id = id;
            this.State = state;
            this.DueDate = dueDate;
            this.DelayDueDate = delayDueDate;
            this.LicenseDate = licenseDate;
            this.CustomerId = customerId;
            this.Quotas = quotas;
            this.OverdueQuotas = overdueQuotas;
        }

        /// <summary>
        /// The tariff ID.
        /// </summary>
        /// <value>The tariff ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The tariff due date.
        /// </summary>
        /// <value>The tariff due date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// The tariff delay due date.
        /// </summary>
        /// <value>The tariff delay due date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "delayDueDate", EmitDefaultValue = false)]
        public DateTime DelayDueDate { get; set; }

        /// <summary>
        /// The tariff license date.
        /// </summary>
        /// <value>The tariff license date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "licenseDate", EmitDefaultValue = false)]
        public DateTime LicenseDate { get; set; }

        /// <summary>
        /// The tariff customer ID.
        /// </summary>
        /// <value>The tariff customer ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "customerId", EmitDefaultValue = true)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The list of tariff quotas.
        /// </summary>
        /// <value>The list of tariff quotas.</value>
        [DataMember(Name = "quotas", EmitDefaultValue = true)]
        public List<Quota> Quotas { get; set; }

        /// <summary>
        /// The list of overdue tariff quotas.
        /// </summary>
        /// <value>The list of overdue tariff quotas.</value>
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
