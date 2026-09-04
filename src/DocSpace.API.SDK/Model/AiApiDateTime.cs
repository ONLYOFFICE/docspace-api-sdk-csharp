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
    /// The API date and time parameters.
    /// </summary>
    [DataContract(Name = "AiApiDateTime")]
    public partial class AiApiDateTime : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiApiDateTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AiApiDateTime()
        {
        }

        /// <summary>
        /// The time in UTC format.
        /// </summary>
        /// <example>2018-01-01T00:00:00.0000000Z</example>
        [DataMember(Name = "utcTime", EmitDefaultValue = false)]
        public DateTime UtcTime { get; private set; }

        /// <summary>
        /// Returns false as UtcTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUtcTime()
        {
            return false;
        }
        /// <summary>
        /// The time zone offset.
        /// </summary>
        /// <example>00:00:00</example>
        [DataMember(Name = "timeZoneOffset", EmitDefaultValue = false)]
        public string TimeZoneOffset { get; private set; }

        /// <summary>
        /// Returns false as TimeZoneOffset should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTimeZoneOffset()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiApiDateTime {\n");
            sb.Append("  UtcTime: ").Append(UtcTime).Append("\n");
            sb.Append("  TimeZoneOffset: ").Append(TimeZoneOffset).Append("\n");
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
