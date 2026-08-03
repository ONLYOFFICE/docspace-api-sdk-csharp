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
    /// Represents the usage statistics of a DocsCloud tenant.
    /// </summary>
    [DataContract(Name = "DocsCloudUsage")]
    public partial class DocsCloudUsage : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudUsage" /> class.
        /// </summary>
        /// <param name="since">The date and time the usage statistics are counted from..</param>
        /// <param name="activeCount">The number of active users..</param>
        public DocsCloudUsage(DateTime since = default, int activeCount = default)
        {
            this.Since = since;
            this.ActiveCount = activeCount;
        }

        /// <summary>
        /// The date and time the usage statistics are counted from.
        /// </summary>
        /// <value>The date and time the usage statistics are counted from.</value>
        /*
        <example>2024-01-15T10:30Z</example>
        */
        [DataMember(Name = "since", EmitDefaultValue = false)]
        public DateTime Since { get; set; }

        /// <summary>
        /// The number of active users.
        /// </summary>
        /// <value>The number of active users.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "activeCount", EmitDefaultValue = false)]
        public int ActiveCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudUsage {\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  ActiveCount: ").Append(ActiveCount).Append("\n");
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
