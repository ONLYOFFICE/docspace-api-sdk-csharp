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
    /// The webhook trigger with its availability for the current user.
    /// </summary>
    [DataContract(Name = "WebhookTriggerDto")]
    public partial class WebhookTriggerDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTriggerDto" /> class.
        /// </summary>
        /// <param name="name">The trigger name..</param>
        /// <param name="id">The trigger bit value..</param>
        /// <param name="available">Specifies whether this trigger is available for the current user's role..</param>
        public WebhookTriggerDto(string name = default, long id = default, bool available = default)
        {
            this.Name = name;
            this.Id = id;
            this.Available = available;
        }

        /// <summary>
        /// The trigger name.
        /// </summary>
        /// <value>The trigger name.</value>
        /*
        <example>file.created</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The trigger bit value.
        /// </summary>
        /// <value>The trigger bit value.</value>
        /*
        <example>128</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Specifies whether this trigger is available for the current user's role.
        /// </summary>
        /// <value>Specifies whether this trigger is available for the current user's role.</value>
        /*
        <example>true</example>
        */
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
