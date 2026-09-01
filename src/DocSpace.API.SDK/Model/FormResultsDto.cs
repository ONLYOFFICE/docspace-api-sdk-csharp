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
    /// FormResultsDto
    /// </summary>
    [DataContract(Name = "FormResultsDto")]
    public partial class FormResultsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormResultsDto" /> class.
        /// </summary>
        /// <param name="createOn">The date and time when the form was created..</param>
        /// <param name="formsData">The list of forms data..</param>
        public FormResultsDto(DateTime createOn = default, List<FormsItemData> formsData = default)
        {
            this.CreateOn = createOn;
            this.FormsData = formsData;
        }

        /// <summary>
        /// The date and time when the form was created.
        /// </summary>
        /// <example>2025-01-01T00:00:00</example>
        [DataMember(Name = "createOn", EmitDefaultValue = false)]
        public DateTime CreateOn { get; set; }

        /// <summary>
        /// The list of forms data.
        /// </summary>
        /// <example>[{"key":"field1","value":"Answer"}]</example>
        [DataMember(Name = "formsData", EmitDefaultValue = true)]
        public List<FormsItemData> FormsData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormResultsDto {\n");
            sb.Append("  CreateOn: ").Append(CreateOn).Append("\n");
            sb.Append("  FormsData: ").Append(FormsData).Append("\n");
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
