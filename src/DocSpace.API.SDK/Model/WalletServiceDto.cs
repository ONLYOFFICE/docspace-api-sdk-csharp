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
    /// One service the portal can pay for out of its wallet: a quota sold per unit rather than per period.
    /// </summary>
    [DataContract(Name = "WalletServiceDto")]
    public partial class WalletServiceDto : QuotaDto, IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletServiceDto" /> class.
        /// </summary>
        [JsonConstructor]
        protected WalletServiceDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletServiceDto" /> class.
        /// </summary>
        /// <param name="innerServices">The variants of this service that are folded into it, so a client renders one card per group instead of  one per variant. It is empty when the service has no variants, and always empty in the answer of  &#x60;GET api/2.0/portal/payment/walletservice&#x60;, which looks one service up on its own..</param>
        /// <param name="serviceName">The stable key of the service, which is what the wallet operations take as their &#x60;service&#x60; argument and  what the usage reports key their entries by..</param>
        public WalletServiceDto(List<WalletServiceDto> innerServices = default, string serviceName = default)
        {
            this.InnerServices = innerServices;
            this.ServiceName = serviceName;
        }

        /// <summary>
        /// The variants of this service that are folded into it, so a client renders one card per group instead of  one per variant. It is empty when the service has no variants, and always empty in the answer of  &#x60;GET api/2.0/portal/payment/walletservice&#x60;, which looks one service up on its own.
        /// </summary>
        /// <example>[{"serviceName":"docs-cloud-dev","title":"Developer pack"}]</example>
        [DataMember(Name = "innerServices", EmitDefaultValue = true)]
        public List<WalletServiceDto> InnerServices { get; set; }

        /// <summary>
        /// The stable key of the service, which is what the wallet operations take as their &#x60;service&#x60; argument and  what the usage reports key their entries by.
        /// </summary>
        /// <example>backup</example>
        [DataMember(Name = "serviceName", EmitDefaultValue = true)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WalletServiceDto {\n");
            sb.Append("  InnerServices: ").Append(InnerServices).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
