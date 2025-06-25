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
    /// The quota parameters.
    /// </summary>
    [DataContract(Name = "Quota")]
    public partial class Quota : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public QuotaState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Quota" /> class.
        /// </summary>
        /// <param name="id">The quota ID..</param>
        /// <param name="quantity">The quota quantity..</param>
        /// <param name="wallet">The quota applies to the wallet or not.</param>
        /// <param name="dueDate">The quota due date..</param>
        /// <param name="nextQuantity">The quota next quantity..</param>
        /// <param name="state">state.</param>
        public Quota(int id = default, int quantity = default, bool wallet = default, DateTime? dueDate = default, int? nextQuantity = default, QuotaState? state = default)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Wallet = wallet;
            this.DueDate = dueDate;
            this.NextQuantity = nextQuantity;
            this.State = state;
        }

        /// <summary>
        /// The quota ID.
        /// </summary>
        /// <value>The quota ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The quota quantity.
        /// </summary>
        /// <value>The quota quantity.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The quota applies to the wallet or not
        /// </summary>
        /// <value>The quota applies to the wallet or not</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "wallet", EmitDefaultValue = true)]
        public bool Wallet { get; set; }

        /// <summary>
        /// The quota due date.
        /// </summary>
        /// <value>The quota due date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "dueDate", EmitDefaultValue = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The quota next quantity.
        /// </summary>
        /// <value>The quota next quantity.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "nextQuantity", EmitDefaultValue = true)]
        public int? NextQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Quota {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  NextQuantity: ").Append(NextQuantity).Append("\n");
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
