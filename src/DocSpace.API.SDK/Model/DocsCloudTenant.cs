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
    /// Represents a DocsCloud tenant of a portal.
    /// </summary>
    [DataContract(Name = "DocsCloudTenant")]
    public partial class DocsCloudTenant : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudTenant" /> class.
        /// </summary>
        /// <param name="dedicatedResourceExId">The external ID of the dedicated resource the tenant is hosted on..</param>
        /// <param name="alias">The tenant alias..</param>
        /// <param name="name">The tenant name..</param>
        /// <param name="modifiedDate">The date and time when the tenant was last modified..</param>
        /// <param name="customerId">The customer ID..</param>
        /// <param name="customerName">The customer name..</param>
        /// <param name="endDate">The date and time when the tenant subscription ends..</param>
        /// <param name="resourceType">The resource type..</param>
        /// <param name="isActive">Whether the tenant is active (the end date is in the future)..</param>
        /// <param name="address">The tenant address..</param>
        /// <param name="payment">The tenant payment information..</param>
        public DocsCloudTenant(int dedicatedResourceExId = default, string alias = default, string name = default, DateTime modifiedDate = default, string customerId = default, string customerName = default, DateTime endDate = default, int resourceType = default, bool isActive = default, string address = default, DocsCloudPayment payment = default)
        {
            this.DedicatedResourceExId = dedicatedResourceExId;
            this.Alias = alias;
            this.Name = name;
            this.ModifiedDate = modifiedDate;
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.EndDate = endDate;
            this.ResourceType = resourceType;
            this.IsActive = isActive;
            this.Address = address;
            this.Payment = payment;
        }

        /// <summary>
        /// The external ID of the dedicated resource the tenant is hosted on.
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "dedicatedResourceExId", EmitDefaultValue = false)]
        public int DedicatedResourceExId { get; set; }

        /// <summary>
        /// The tenant alias.
        /// </summary>
        /// <example>my-portal</example>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// The tenant name.
        /// </summary>
        /// <example>My Portal</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The date and time when the tenant was last modified.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// The customer ID.
        /// </summary>
        /// <example>CustomerId</example>
        [DataMember(Name = "customerId", EmitDefaultValue = true)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The customer name.
        /// </summary>
        /// <example>CustomerName</example>
        [DataMember(Name = "customerName", EmitDefaultValue = true)]
        public string CustomerName { get; set; }

        /// <summary>
        /// The date and time when the tenant subscription ends.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The resource type.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "resourceType", EmitDefaultValue = false)]
        public int ResourceType { get; set; }

        /// <summary>
        /// Whether the tenant is active (the end date is in the future).
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// The tenant address.
        /// </summary>
        /// <example>https://my-portal.onlyoffice.com</example>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The tenant payment information.
        /// </summary>
        [DataMember(Name = "payment", EmitDefaultValue = false)]
        public DocsCloudPayment Payment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudTenant {\n");
            sb.Append("  DedicatedResourceExId: ").Append(DedicatedResourceExId).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
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
