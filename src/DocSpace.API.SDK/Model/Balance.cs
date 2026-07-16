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
    /// Represents a balance with an account number and a list of sub-accounts.
    /// </summary>
    [DataContract(Name = "Balance")]
    public partial class Balance : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Balance" /> class.
        /// </summary>
        /// <param name="accountNumber">The account number..</param>
        /// <param name="subAccountNumber">The sub-account number..</param>
        /// <param name="accountName">The account name..</param>
        /// <param name="accountCurrency">The account currency..</param>
        /// <param name="subAccounts">A list of sub-accounts..</param>
        /// <param name="lastCredit">lastCredit.</param>
        public Balance(int accountNumber = default, int subAccountNumber = default, string accountName = default, string accountCurrency = default, List<SubAccount> subAccounts = default, TransactionInfo lastCredit = default)
        {
            this.AccountNumber = accountNumber;
            this.SubAccountNumber = subAccountNumber;
            this.AccountName = accountName;
            this.AccountCurrency = accountCurrency;
            this.SubAccounts = subAccounts;
            this.LastCredit = lastCredit;
        }

        /// <summary>
        /// The account number.
        /// </summary>
        /// <value>The account number.</value>
        /*
        <example>12345</example>
        */
        [DataMember(Name = "accountNumber", EmitDefaultValue = false)]
        public int AccountNumber { get; set; }

        /// <summary>
        /// The sub-account number.
        /// </summary>
        /// <value>The sub-account number.</value>
        /*
        <example>12345</example>
        */
        [DataMember(Name = "subAccountNumber", EmitDefaultValue = false)]
        public int SubAccountNumber { get; set; }

        /// <summary>
        /// The account name.
        /// </summary>
        /// <value>The account name.</value>
        /*
        <example>account name</example>
        */
        [DataMember(Name = "accountName", EmitDefaultValue = true)]
        public string AccountName { get; set; }

        /// <summary>
        /// The account currency.
        /// </summary>
        /// <value>The account currency.</value>
        /*
        <example>USD</example>
        */
        [DataMember(Name = "accountCurrency", EmitDefaultValue = true)]
        public string AccountCurrency { get; set; }

        /// <summary>
        /// A list of sub-accounts.
        /// </summary>
        /// <value>A list of sub-accounts.</value>
        /*
        <example>[{"currency":"USD","amount":1500.75}]</example>
        */
        [DataMember(Name = "subAccounts", EmitDefaultValue = true)]
        public List<SubAccount> SubAccounts { get; set; }

        /// <summary>
        /// Gets or Sets LastCredit
        /// </summary>
        [DataMember(Name = "lastCredit", EmitDefaultValue = false)]
        public TransactionInfo LastCredit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Balance {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  SubAccountNumber: ").Append(SubAccountNumber).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountCurrency: ").Append(AccountCurrency).Append("\n");
            sb.Append("  SubAccounts: ").Append(SubAccounts).Append("\n");
            sb.Append("  LastCredit: ").Append(LastCredit).Append("\n");
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
