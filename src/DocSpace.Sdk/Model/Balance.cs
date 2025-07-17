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
    /// Represents a balance with an account number and a list of sub-accounts.
    /// </summary>
    [DataContract(Name = "Balance")]
    public partial class Balance : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Balance" /> class.
        /// </summary>
        /// <param name="accountNumber">The account number..</param>
        /// <param name="subAccounts">A list of sub-accounts..</param>
        public Balance(int accountNumber = default, List<SubAccount> subAccounts = default)
        {
            this.AccountNumber = accountNumber;
            this.SubAccounts = subAccounts;
        }

        /// <summary>
        /// The account number.
        /// </summary>
        /// <value>The account number.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "accountNumber", EmitDefaultValue = false)]
        public int AccountNumber { get; set; }

        /// <summary>
        /// A list of sub-accounts.
        /// </summary>
        /// <value>A list of sub-accounts.</value>
        [DataMember(Name = "subAccounts", EmitDefaultValue = true)]
        public List<SubAccount> SubAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Balance {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  SubAccounts: ").Append(SubAccounts).Append("\n");
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
