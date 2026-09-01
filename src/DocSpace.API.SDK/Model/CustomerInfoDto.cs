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
    /// The customer information.
    /// </summary>
    [DataContract(Name = "CustomerInfoDto")]
    public partial class CustomerInfoDto : IValidatableObject
    {

        /// <summary>
        /// The customer&#39;s payment method.
        /// </summary>
        [DataMember(Name = "paymentMethodStatus", EmitDefaultValue = false)]
        public PaymentMethodStatus? PaymentMethodStatus { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInfoDto" /> class.
        /// </summary>
        /// <param name="paymentMethodStatus">The customer&#39;s payment method..</param>
        /// <param name="payer">The paying user..</param>
        public CustomerInfoDto(PaymentMethodStatus? paymentMethodStatus = default, EmployeeDto payer = default)
        {
            this.PaymentMethodStatus = paymentMethodStatus;
            this.Payer = payer;
        }

        /// <summary>
        /// The portal ID.
        /// </summary>
        /// <example>portal-001</example>
        [DataMember(Name = "portalId", EmitDefaultValue = true)]
        public string PortalId { get; private set; }

        /// <summary>
        /// Returns false as PortalId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePortalId()
        {
            return false;
        }
        /// <summary>
        /// The customer email address.
        /// </summary>
        /// <example>user@example.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; private set; }

        /// <summary>
        /// Returns false as Email should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmail()
        {
            return false;
        }
        /// <summary>
        /// The paying user.
        /// </summary>
        [DataMember(Name = "payer", EmitDefaultValue = false)]
        public EmployeeDto Payer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerInfoDto {\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
            sb.Append("  PaymentMethodStatus: ").Append(PaymentMethodStatus).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Payer: ").Append(Payer).Append("\n");
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
