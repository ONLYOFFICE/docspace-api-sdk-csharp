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
    /// What went wrong.
    /// </summary>
    [DataContract(Name = "ErrorApiResponse_error")]
    public partial class ErrorApiResponseError : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorApiResponseError" /> class.
        /// </summary>
        /// <param name="message">The human-readable error message..</param>
        /// <param name="type">The .NET type of the underlying exception. Only sent when stack traces are enabled..</param>
        /// <param name="stack">The stack trace of the underlying exception. Only sent when stack traces are enabled..</param>
        /// <param name="hresult">The HRESULT of the underlying exception. Only sent when stack traces are enabled..</param>
        public ErrorApiResponseError(string message = default, string type = default, string stack = default, int hresult = default)
        {
            this.Message = message;
            this.Type = type;
            this.Stack = stack;
            this.Hresult = hresult;
        }

        /// <summary>
        /// The human-readable error message.
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// The .NET type of the underlying exception. Only sent when stack traces are enabled.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The stack trace of the underlying exception. Only sent when stack traces are enabled.
        /// </summary>
        [DataMember(Name = "stack", EmitDefaultValue = false)]
        public string Stack { get; set; }

        /// <summary>
        /// The HRESULT of the underlying exception. Only sent when stack traces are enabled.
        /// </summary>
        [DataMember(Name = "hresult", EmitDefaultValue = false)]
        public int Hresult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorApiResponseError {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Stack: ").Append(Stack).Append("\n");
            sb.Append("  Hresult: ").Append(Hresult).Append("\n");
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
