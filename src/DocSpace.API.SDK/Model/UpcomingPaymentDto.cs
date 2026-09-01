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
    /// The upcoming payment parameters.
    /// </summary>
    [DataContract(Name = "UpcomingPaymentDto")]
    public partial class UpcomingPaymentDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpcomingPaymentDto" /> class.
        /// </summary>
        /// <param name="id">The quota ID..</param>
        /// <param name="name">The quota name..</param>
        /// <param name="title">The quota title..</param>
        /// <param name="unitOfMeasure">The quota unit of measure..</param>
        /// <param name="quantity">The quantity that will be charged (the next quantity if set, otherwise the current quantity)..</param>
        /// <param name="wallet">The quota applies to the wallet or not..</param>
        /// <param name="dueDate">The due date of the upcoming payment in the portal time zone..</param>
        /// <param name="amount">The amount that will be charged (unit price multiplied by the quantity)..</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol of the amount..</param>
        public UpcomingPaymentDto(int id = default, string name = default, string title = default, string unitOfMeasure = default, int quantity = default, bool wallet = default, DateTime? dueDate = default, double amount = default, string currency = default)
        {
            this.Id = id;
            this.Name = name;
            this.Title = title;
            this.UnitOfMeasure = unitOfMeasure;
            this.Quantity = quantity;
            this.Wallet = wallet;
            this.DueDate = dueDate;
            this.Amount = amount;
            this.Currency = currency;
        }

        /// <summary>
        /// The quota ID.
        /// </summary>
        /// <example>-11</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The quota name.
        /// </summary>
        /// <example>storage</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The quota title.
        /// </summary>
        /// <example>Business plan</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The quota unit of measure.
        /// </summary>
        /// <example>admins</example>
        [DataMember(Name = "unitOfMeasure", EmitDefaultValue = true)]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// The quantity that will be charged (the next quantity if set, otherwise the current quantity).
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The quota applies to the wallet or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "wallet", EmitDefaultValue = true)]
        public bool Wallet { get; set; }

        /// <summary>
        /// The due date of the upcoming payment in the portal time zone.
        /// </summary>
        /// <example>2026-07-08T11:39:43.0000000+03:00</example>
        [DataMember(Name = "dueDate", EmitDefaultValue = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The amount that will be charged (unit price multiplied by the quantity).
        /// </summary>
        /// <example>14</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol of the amount.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpcomingPaymentDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
