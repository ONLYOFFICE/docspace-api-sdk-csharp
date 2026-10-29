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
    /// AiMetaGenerate402Response
    /// </summary>
    [DataContract(Name = "aiMetaGenerate_402_response")]
    public partial class AiMetaGenerate402Response : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaGenerate402Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiMetaGenerate402Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiMetaGenerate402Response" /> class.
        /// </summary>
        /// <param name="error">Short reason, ready to be shown to the caller. (required).</param>
        /// <param name="code">Stable classification of the failure: &#x60;rate_limit&#x60;, &#x60;insufficient_funds&#x60;, &#x60;auth&#x60;, &#x60;model_not_found&#x60;, &#x60;timeout&#x60;, &#x60;network&#x60;, &#x60;bad_request&#x60;, &#x60;server&#x60;, &#x60;unknown&#x60;, or a provider-specific code relayed as it came. (required).</param>
        /// <param name="providerMessage">The provider&#39;s own error message, cut to 500 characters. Absent when the failure never reached the provider, or was a timeout..</param>
        public AiMetaGenerate402Response(string error = default, string code = default, string providerMessage = default)
        {
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for AiMetaGenerate402Response and cannot be null");
            }
            this.Error = error;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for AiMetaGenerate402Response and cannot be null");
            }
            this.Code = code;
            this.ProviderMessage = providerMessage;
        }

        /// <summary>
        /// Short reason, ready to be shown to the caller.
        /// </summary>
        /// <example>The model provider refused the request for lack of credit</example>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Stable classification of the failure: &#x60;rate_limit&#x60;, &#x60;insufficient_funds&#x60;, &#x60;auth&#x60;, &#x60;model_not_found&#x60;, &#x60;timeout&#x60;, &#x60;network&#x60;, &#x60;bad_request&#x60;, &#x60;server&#x60;, &#x60;unknown&#x60;, or a provider-specific code relayed as it came.
        /// </summary>
        /// <example>insufficient_funds</example>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The provider&#39;s own error message, cut to 500 characters. Absent when the failure never reached the provider, or was a timeout.
        /// </summary>
        /// <example>402 Insufficient Balance</example>
        [DataMember(Name = "providerMessage", EmitDefaultValue = false)]
        public string ProviderMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiMetaGenerate402Response {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ProviderMessage: ").Append(ProviderMessage).Append("\n");
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
