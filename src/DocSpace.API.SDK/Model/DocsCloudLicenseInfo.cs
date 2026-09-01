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
    /// Represents the license information of a DocsCloud tenant.
    /// </summary>
    [DataContract(Name = "DocsCloudLicenseInfo")]
    public partial class DocsCloudLicenseInfo : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudLicenseInfo" /> class.
        /// </summary>
        /// <param name="valid">The date and time until which the license is valid..</param>
        /// <param name="trial">Whether the license is a trial..</param>
        /// <param name="buildDate">The license build date..</param>
        public DocsCloudLicenseInfo(DateTime valid = default, bool trial = default, DateTime buildDate = default)
        {
            this.Valid = valid;
            this.Trial = trial;
            this.BuildDate = buildDate;
        }

        /// <summary>
        /// The date and time until which the license is valid.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "valid", EmitDefaultValue = false)]
        public DateTime Valid { get; set; }

        /// <summary>
        /// Whether the license is a trial.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "trial", EmitDefaultValue = true)]
        public bool Trial { get; set; }

        /// <summary>
        /// The license build date.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "buildDate", EmitDefaultValue = false)]
        public DateTime BuildDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudLicenseInfo {\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Trial: ").Append(Trial).Append("\n");
            sb.Append("  BuildDate: ").Append(BuildDate).Append("\n");
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
