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
    /// The trash auto-clearing setting of an account.
    /// </summary>
    [DataContract(Name = "AutoCleanUpData")]
    public partial class AutoCleanUpData : IValidatableObject
    {

        /// <summary>
        /// How long an item may stay in the trash before it is removed for good. It is reported even while clearing is  off, and it is what the moment in the &#x60;autoDelete&#x60; field of a trashed entry is computed from.
        /// </summary>
        [DataMember(Name = "gap", EmitDefaultValue = false)]
        public DateToAutoCleanUp? Gap { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoCleanUpData" /> class.
        /// </summary>
        /// <param name="isAutoCleanUp">Whether the trash of the account is cleared automatically. While it is false nothing is removed by the portal  and the interval below is kept but unused..</param>
        /// <param name="gap">How long an item may stay in the trash before it is removed for good. It is reported even while clearing is  off, and it is what the moment in the &#x60;autoDelete&#x60; field of a trashed entry is computed from..</param>
        public AutoCleanUpData(bool isAutoCleanUp = default, DateToAutoCleanUp? gap = default)
        {
            this.IsAutoCleanUp = isAutoCleanUp;
            this.Gap = gap;
        }

        /// <summary>
        /// Whether the trash of the account is cleared automatically. While it is false nothing is removed by the portal  and the interval below is kept but unused.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isAutoCleanUp", EmitDefaultValue = true)]
        public bool IsAutoCleanUp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoCleanUpData {\n");
            sb.Append("  IsAutoCleanUp: ").Append(IsAutoCleanUp).Append("\n");
            sb.Append("  Gap: ").Append(Gap).Append("\n");
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
