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
    /// Response containing validation errors
    /// </summary>
    [DataContract(Name = "ValidationErrorResponse")]
    public partial class ValidationErrorResponse : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorResponse" /> class.
        /// </summary>
        /// <param name="error">Error type identifier.</param>
        /// <param name="message">General error message.</param>
        /// <param name="errors">List of field specific validation errors.</param>
        public ValidationErrorResponse(string error = default, string message = default, List<FieldError> errors = default)
        {
            this.Error = error;
            this.Message = message;
            this.Errors = errors;
        }

        /// <summary>
        /// Error type identifier
        /// </summary>
        /// <example>ValidationError</example>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// General error message
        /// </summary>
        /// <example>Validation failed</example>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// List of field specific validation errors
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
            sb.Append("class ValidationErrorResponse {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
