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
    /// The auto-clearing setting parameters.
    /// </summary>
    [DataContract(Name = "AutoCleanUpData")]
    public partial class AutoCleanUpData : IValidatableObject
    {

        /// <summary>
        /// The period when the trash bin will be cleared.
        /// </summary>
        [DataMember(Name = "gap", EmitDefaultValue = false)]
        public DateToAutoCleanUp? Gap { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoCleanUpData" /> class.
        /// </summary>
        /// <param name="isAutoCleanUp">Specifies whether to permanently delete files in the Trash folder..</param>
        /// <param name="gap">The period when the trash bin will be cleared..</param>
        public AutoCleanUpData(bool isAutoCleanUp = default, DateToAutoCleanUp? gap = default)
        {
            this.IsAutoCleanUp = isAutoCleanUp;
            this.Gap = gap;
        }

        /// <summary>
        /// Specifies whether to permanently delete files in the Trash folder.
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
