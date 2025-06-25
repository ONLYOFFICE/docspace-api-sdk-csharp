// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
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
            StringBuilder sb = new StringBuilder();
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
