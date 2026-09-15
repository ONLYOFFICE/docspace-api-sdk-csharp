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
    /// AiVectorizationStartTask200Response
    /// </summary>
    [DataContract(Name = "aiVectorizationStartTask_200_response")]
    public partial class AiVectorizationStartTask200Response : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiVectorizationStartTask200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiVectorizationStartTask200Response()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiVectorizationStartTask200Response" /> class.
        /// </summary>
        /// <param name="count">Envelope field from the internal service; 0 for this operation. (required).</param>
        /// <param name="status">Envelope status flag from the internal service. (required).</param>
        /// <param name="statusCode">HTTP status the internal service answered with. (required).</param>
        public AiVectorizationStartTask200Response(int count = default, int status = default, int statusCode = default)
        {
            this.Count = count;
            this.Status = status;
            this.StatusCode = statusCode;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Envelope field from the internal service; 0 for this operation.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = true)]
        public int Count { get; set; }

        /// <summary>
        /// Envelope status flag from the internal service.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public int Status { get; set; }

        /// <summary>
        /// HTTP status the internal service answered with.
        /// </summary>
        /// <example>200</example>
        [DataMember(Name = "statusCode", IsRequired = true, EmitDefaultValue = true)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [System.Text.Json.Serialization.JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiVectorizationStartTask200Response {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
