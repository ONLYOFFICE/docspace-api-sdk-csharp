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
    /// Represents an active wallet service (quota) of the current portal.
    /// </summary>
    [DataContract(Name = "ActiveServiceDto")]
    public partial class ActiveServiceDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveServiceDto" /> class.
        /// </summary>
        /// <param name="service">The name of the service..</param>
        /// <param name="serviceUnit">The unit of measurement for the service..</param>
        /// <param name="subscription">Indicates whether the service is subscription-based..</param>
        /// <param name="title">The title of the service..</param>
        /// <param name="limit">The service limit. Populated only for the subscription-based services..</param>
        /// <param name="used">The current service usage. Populated only for the subscription-based services..</param>
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
        /// The name of the service.
        /// </summary>
        /// <example>disk-storage</example>
        [DataMember(Name = "service", EmitDefaultValue = true)]
        public string Service { get; set; }

        /// <summary>
        /// The unit of measurement for the service.
        /// </summary>
        /// <example>GB</example>
        [DataMember(Name = "serviceUnit", EmitDefaultValue = true)]
        public string ServiceUnit { get; set; }

        /// <summary>
        /// Indicates whether the service is subscription-based.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "subscription", EmitDefaultValue = true)]
        public bool Subscription { get; set; }

        /// <summary>
        /// The title of the service.
        /// </summary>
        /// <example>Additional disk storage</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The service limit. Populated only for the subscription-based services.
        /// </summary>
        /// <example>500</example>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public int? Limit { get; set; }

        /// <summary>
        /// The current service usage. Populated only for the subscription-based services.
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
