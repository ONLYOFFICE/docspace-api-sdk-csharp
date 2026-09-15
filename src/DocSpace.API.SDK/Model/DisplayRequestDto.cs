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
    /// The body of a file settings switch that turns something on or makes it visible.
    /// </summary>
    [DataContract(Name = "DisplayRequestDto")]
    public partial class DisplayRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayRequestDto" /> class.
        /// </summary>
        /// <param name="set">The state to store for the setting the operation addresses: true enables it or shows what it governs, false  disables or hides it. What exactly is affected, and whether the value belongs to the calling account or to the  whole portal, are stated by the operation that binds this body. The portal may store a different value than  the one sent when another setting overrides it, so read the answer rather than assuming..</param>
        public DisplayRequestDto(bool set = default)
        {
            this.Set = set;
        }

        /// <summary>
        /// The state to store for the setting the operation addresses: true enables it or shows what it governs, false  disables or hides it. What exactly is affected, and whether the value belongs to the calling account or to the  whole portal, are stated by the operation that binds this body. The portal may store a different value than  the one sent when another setting overrides it, so read the answer rather than assuming.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "set", EmitDefaultValue = true)]
        public bool Set { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisplayRequestDto {\n");
            sb.Append("  Set: ").Append(Set).Append("\n");
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
