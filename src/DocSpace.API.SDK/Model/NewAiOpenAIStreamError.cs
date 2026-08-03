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
    /// OpenAI streaming error envelope. When the upstream request fails mid-stream the OpenAI API emits a single &#x60;data:&#x60; line carrying an &#x60;error&#x60; object (no &#x60;choices&#x60;), then closes the stream — the official SDK turns this into a thrown &#x60;APIError&#x60;. Mirrors that shape so a host exposing an OpenAI-compatible endpoint stays wire-compatible.
    /// </summary>
    [DataContract(Name = "NewAiOpenAIStreamError")]
    public partial class NewAiOpenAIStreamError : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiOpenAIStreamError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiOpenAIStreamError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiOpenAIStreamError" /> class.
        /// </summary>
        /// <param name="error">error (required).</param>
        public NewAiOpenAIStreamError(NewAiOpenAIStreamErrorError error = default)
        {
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for NewAiOpenAIStreamError and cannot be null");
            }
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public NewAiOpenAIStreamErrorError Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiOpenAIStreamError {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
