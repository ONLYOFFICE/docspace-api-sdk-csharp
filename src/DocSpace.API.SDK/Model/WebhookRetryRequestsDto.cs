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
    /// Which past webhook deliveries are sent again.
    /// </summary>
    [DataContract(Name = "WebhookRetryRequestsDto")]
    public partial class WebhookRetryRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRetryRequestsDto" /> class.
        /// </summary>
        /// <param name="ids">The delivery records to send again, by the identifiers &#x60;GET api/2.0/settings/webhooks/log&#x60; reports. An  identifier that exists nowhere, and one belonging to another member subscription when the caller is not a  DocSpace administrator, is skipped in silence rather than failing the call, so compare the number of records  that come back against the number sent. An empty list is accepted and queues nothing..</param>
        public WebhookRetryRequestsDto(List<int> ids = default)
        {
            this.Ids = ids;
        }

        /// <summary>
        /// The delivery records to send again, by the identifiers &#x60;GET api/2.0/settings/webhooks/log&#x60; reports. An  identifier that exists nowhere, and one belonging to another member subscription when the caller is not a  DocSpace administrator, is skipped in silence rather than failing the call, so compare the number of records  that come back against the number sent. An empty list is accepted and queues nothing.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "ids", EmitDefaultValue = true)]
        public List<int> Ids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookRetryRequestsDto {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
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
