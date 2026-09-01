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
    /// Minimal provider connection configuration. Used to connect to a provider API.
    /// </summary>
    [DataContract(Name = "AiTProvider")]
    public partial class AiTProvider : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiTProvider" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiTProvider() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiTProvider" /> class.
        /// </summary>
        /// <param name="type">Provider type identifier. (required).</param>
        /// <param name="name">User-defined display name for this provider connection. (required).</param>
        /// <param name="key">API key or token. Optional for local providers (Ollama, LM Studio)..</param>
        /// <param name="baseUrl">Base URL of the provider API. (required).</param>
        public AiTProvider(AiProviderType type = default, string name = default, string key = default, string baseUrl = default)
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for AiTProvider and cannot be null");
            }
            this.Type = type;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AiTProvider and cannot be null");
            }
            this.Name = name;
            // to ensure "baseUrl" is required (not null)
            if (baseUrl == null)
            {
                throw new ArgumentNullException("baseUrl is a required property for AiTProvider and cannot be null");
            }
            this.BaseUrl = baseUrl;
            this.Key = key;
        }

        /// <summary>
        /// Provider type identifier.
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public AiProviderType Type { get; set; }

        /// <summary>
        /// User-defined display name for this provider connection.
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// API key or token. Optional for local providers (Ollama, LM Studio).
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Base URL of the provider API.
        /// </summary>
        [DataMember(Name = "baseUrl", IsRequired = true, EmitDefaultValue = true)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiTProvider {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
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
