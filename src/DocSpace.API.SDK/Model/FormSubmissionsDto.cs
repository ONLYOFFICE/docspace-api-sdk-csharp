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
    /// All completed copies of a form, together with the description of the fields they were filled into.
    /// </summary>
    [DataContract(Name = "FormSubmissionsDto")]
    public partial class FormSubmissionsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormSubmissionsDto" /> class.
        /// </summary>
        /// <param name="metadata">Describes the fields of the form version that is being filled - the key each value is stored under, the type  and format of the field and, where the field offers a fixed set of answers, those answers - in the order the  fields are laid out, which is the order to build a results table in. It comes back empty when the portal holds  no indexed description of that version..</param>
        /// <param name="submissions">One entry per completed copy, ordered by the copy number that &#x60;formsData&#x60; carries. An empty list means nothing  has been completed for the version that is currently being filled; the copies of earlier versions of the form  are not reported here..</param>
        public FormSubmissionsDto(List<FormMetadata> metadata = default, List<FormResultsDto> submissions = default)
        {
            this.Metadata = metadata;
            this.Submissions = submissions;
        }

        /// <summary>
        /// Describes the fields of the form version that is being filled - the key each value is stored under, the type  and format of the field and, where the field offers a fixed set of answers, those answers - in the order the  fields are laid out, which is the order to build a results table in. It comes back empty when the portal holds  no indexed description of that version.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public List<FormMetadata> Metadata { get; set; }

        /// <summary>
        /// One entry per completed copy, ordered by the copy number that &#x60;formsData&#x60; carries. An empty list means nothing  has been completed for the version that is currently being filled; the copies of earlier versions of the form  are not reported here.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "submissions", EmitDefaultValue = true)]
        public List<FormResultsDto> Submissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormSubmissionsDto {\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Submissions: ").Append(Submissions).Append("\n");
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
