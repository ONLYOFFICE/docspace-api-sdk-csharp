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
    /// IPRestriction
    /// </summary>
    [DataContract(Name = "IPRestriction")]
    public partial class IPRestriction : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IPRestriction" /> class.
        /// </summary>
        /// <param name="ip">ip.</param>
        /// <param name="forAdmin">forAdmin.</param>
        /// <param name="id">id.</param>
        /// <param name="tenantId">tenantId.</param>
        public IPRestriction(string ip = default, bool forAdmin = default, int id = default, int tenantId = default)
        {
            this.Ip = ip;
            this.ForAdmin = forAdmin;
            this.Id = id;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "ip", EmitDefaultValue = true)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets ForAdmin
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "forAdmin", EmitDefaultValue = true)]
        public bool ForAdmin { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public int TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IPRestriction {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  ForAdmin: ").Append(ForAdmin).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
