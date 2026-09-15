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
    /// One wallet service the portal is running right now, with the allowance it grants where that is counted.
    /// </summary>
    [DataContract(Name = "ActiveServiceDto")]
    public partial class ActiveServiceDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveServiceDto" /> class.
        /// </summary>
        /// <param name="service">The stable key of the service, which is what &#x60;POST api/2.0/portal/payment/servicestate&#x60; takes to switch  it off again..</param>
        /// <param name="serviceUnit">What &#x60;limit&#x60; and &#x60;used&#x60; count, in the portal language - gigabytes, editor seats, credits..</param>
        /// <param name="subscription">Whether the service is billed as a standing subscription rather than per unit consumed. Only a  subscription can carry &#x60;limit&#x60; and &#x60;used&#x60;..</param>
        /// <param name="title">The service name in the portal language, for printing rather than matching..</param>
        /// <param name="limit">How much of the service the portal is entitled to. It is empty for a service whose consumption is not  counted this way, which is not the same as a service without a limit..</param>
        /// <param name="used">How much of that allowance is in use - the editors currently active for the cloud editors, the units  already consumed for disk storage. Empty under the same conditions as &#x60;limit&#x60;..</param>
        public ActiveServiceDto(string service = default, string serviceUnit = default, bool subscription = default, string title = default, int? limit = default, int? used = default)
        {
            this.Service = service;
            this.ServiceUnit = serviceUnit;
            this.Subscription = subscription;
            this.Title = title;
            this.Limit = limit;
            this.Used = used;
        }

        /// <summary>
        /// The stable key of the service, which is what &#x60;POST api/2.0/portal/payment/servicestate&#x60; takes to switch  it off again.
        /// </summary>
        /// <example>disk-storage</example>
        [DataMember(Name = "service", EmitDefaultValue = true)]
        public string Service { get; set; }

        /// <summary>
        /// What &#x60;limit&#x60; and &#x60;used&#x60; count, in the portal language - gigabytes, editor seats, credits.
        /// </summary>
        /// <example>GB</example>
        [DataMember(Name = "serviceUnit", EmitDefaultValue = true)]
        public string ServiceUnit { get; set; }

        /// <summary>
        /// Whether the service is billed as a standing subscription rather than per unit consumed. Only a  subscription can carry &#x60;limit&#x60; and &#x60;used&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "subscription", EmitDefaultValue = true)]
        public bool Subscription { get; set; }

        /// <summary>
        /// The service name in the portal language, for printing rather than matching.
        /// </summary>
        /// <example>Additional disk storage</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// How much of the service the portal is entitled to. It is empty for a service whose consumption is not  counted this way, which is not the same as a service without a limit.
        /// </summary>
        /// <example>500</example>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public int? Limit { get; set; }

        /// <summary>
        /// How much of that allowance is in use - the editors currently active for the cloud editors, the units  already consumed for disk storage. Empty under the same conditions as &#x60;limit&#x60;.
        /// </summary>
        /// <example>320</example>
        [DataMember(Name = "used", EmitDefaultValue = true)]
        public int? Used { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiveServiceDto {\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  ServiceUnit: ").Append(ServiceUnit).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
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
