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
    /// RFC 7807 problem details returned by the registration API for failed requests.
    /// </summary>
    [DataContract(Name = "ProblemDetail")]
    public partial class ProblemDetail : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemDetail" /> class.
        /// </summary>
        /// <param name="type">A URI reference that identifies the problem type. This service sets it to the DocSpace API getting-started page..</param>
        /// <param name="title">A short, human-readable summary of the problem type, typically the HTTP status reason phrase..</param>
        /// <param name="status">The HTTP status code for this occurrence of the problem..</param>
        /// <param name="detail">A human-readable explanation specific to this occurrence of the problem..</param>
        /// <param name="instance">A URI reference that identifies the specific occurrence, set to the request path..</param>
        /// <param name="properties">Extension members carried on the problem. Usually empty; validation failures also surface as the top-level errors array..</param>
        /// <param name="errors">Field-specific validation errors. Present when the request body or parameters failed validation, or when a named scope is not in the tenant catalogue..</param>
        public ProblemDetail(string type = default, string title = default, int status = default, string detail = default, string instance = default, Dictionary<string, Object> properties = default, List<FieldError> errors = default)
        {
            this.Type = type;
            this.Title = title;
            this.Status = status;
            this.Detail = detail;
            this.Instance = instance;
            this.Properties = properties;
            this.Errors = errors;
        }

        /// <summary>
        /// A URI reference that identifies the problem type. This service sets it to the DocSpace API getting-started page.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// A short, human-readable summary of the problem type, typically the HTTP status reason phrase.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The HTTP status code for this occurrence of the problem.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem.
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public string Detail { get; set; }

        /// <summary>
        /// A URI reference that identifies the specific occurrence, set to the request path.
        /// </summary>
        [DataMember(Name = "instance", EmitDefaultValue = false)]
        public string Instance { get; set; }

        /// <summary>
        /// Extension members carried on the problem. Usually empty; validation failures also surface as the top-level errors array.
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Dictionary<string, Object> Properties { get; set; }

        /// <summary>
        /// Field-specific validation errors. Present when the request body or parameters failed validation, or when a named scope is not in the tenant catalogue.
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<FieldError> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProblemDetail {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Instance: ").Append(Instance).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
