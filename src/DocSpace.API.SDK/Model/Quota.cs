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
    /// The quota parameters.  &lt;example&gt;  {    id: 1,    quantity: 50,    wallet: false,    additional: false,    dueDate: 2026-03-31T00:00:00Z,    nextQuantity: 100,    state: Active  }  &lt;/example&gt;
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
        /// <param name="additional">Indicates whether the quota is primary or additional..</param>
        /// <param name="state">state.</param>
        public Quota(int id = default, int quantity = default, bool wallet = default, DateTime? dueDate = default, int? nextQuantity = default, bool additional = default, QuotaState? state = default)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Wallet = wallet;
            this.DueDate = dueDate;
            this.NextQuantity = nextQuantity;
            this.Additional = additional;
            this.State = state;
        }

        /// <summary>
        /// The quota ID.
        /// </summary>
        /// <value>The quota ID.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The quota quantity.
        /// </summary>
        /// <value>The quota quantity.</value>
        /*
        <example>50</example>
        */
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The quota applies to the wallet or not
        /// </summary>
        /// <value>The quota applies to the wallet or not</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "wallet", EmitDefaultValue = true)]
        public bool Wallet { get; set; }

        /// <summary>
        /// The quota due date.
        /// </summary>
        /// <value>The quota due date.</value>
        /*
        <example>2026-03-31T00:00Z</example>
        */
        [DataMember(Name = "dueDate", EmitDefaultValue = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The quota next quantity.
        /// </summary>
        /// <value>The quota next quantity.</value>
        /*
        <example>100</example>
        */
        [DataMember(Name = "nextQuantity", EmitDefaultValue = true)]
        public int? NextQuantity { get; set; }

        /// <summary>
        /// Indicates whether the quota is primary or additional.
        /// </summary>
        /// <value>Indicates whether the quota is primary or additional.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "additional", EmitDefaultValue = true)]
        public bool Additional { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quota {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  NextQuantity: ").Append(NextQuantity).Append("\n");
            sb.Append("  Additional: ").Append(Additional).Append("\n");
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
