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
    /// One event a webhook can listen to, with the bit that selects it and whether the caller may subscribe to it.
    /// </summary>
    [DataContract(Name = "WebhookTriggerDto")]
    public partial class WebhookTriggerDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTriggerDto" /> class.
        /// </summary>
        /// <param name="name">The event name exactly as it appears in a delivered payload, so a receiver can match on it. The entry  named &#x60;*&#x60; is not an event but the catch-all..</param>
        /// <param name="id">The bit that stands for this event in the &#x60;triggers&#x60; bitmask of a subscription. Add the bits of the wanted  events together; the catch-all entry has the value &#x60;0&#x60; and is used on its own rather than added to  anything..</param>
        /// <param name="available">Whether the caller&#39;s own role may subscribe to this event - a plain member cannot subscribe to user, group  or room creation, where a room administrator can. An unavailable event is listed all the same, and sending  its bit to &#x60;POST api/2.0/settings/webhook&#x60; is refused as an invalid request..</param>
        public WebhookTriggerDto(string name = default, long id = default, bool available = default)
        {
            this.Name = name;
            this.Id = id;
            this.Available = available;
        }

        /// <summary>
        /// The event name exactly as it appears in a delivered payload, so a receiver can match on it. The entry  named &#x60;*&#x60; is not an event but the catch-all.
        /// </summary>
        /// <example>file.created</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The bit that stands for this event in the &#x60;triggers&#x60; bitmask of a subscription. Add the bits of the wanted  events together; the catch-all entry has the value &#x60;0&#x60; and is used on its own rather than added to  anything.
        /// </summary>
        /// <example>128</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Whether the caller&#39;s own role may subscribe to this event - a plain member cannot subscribe to user, group  or room creation, where a room administrator can. An unavailable event is listed all the same, and sending  its bit to &#x60;POST api/2.0/settings/webhook&#x60; is refused as an invalid request.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "available", EmitDefaultValue = true)]
        public bool Available { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookTriggerDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
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
