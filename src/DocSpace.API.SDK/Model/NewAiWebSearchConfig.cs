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
    /// Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.
    /// </summary>
    [DataContract(Name = "NewAiWebSearchConfig")]
    public partial class NewAiWebSearchConfig : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiWebSearchConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiWebSearchConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiWebSearchConfig" /> class.
        /// </summary>
        /// <param name="provider">Provider identifier (e.g. &#x60;exa&#x60;). (required).</param>
        /// <param name="key">API key for the provider. Optional for self-hosted or keyless setups..</param>
        /// <param name="baseUrl">Optional override for the provider&#39;s base URL..</param>
        /// <param name="isCloudProvider">Whether this provider is cloud-hosted (vs. self-hosted)..</param>
        /// <param name="headers">Extra HTTP headers sent with each request to the ONLYOFFICE / cloud backend (e.g. &#x60;X-Tenant&#x60;). Merged after the derived &#x60;Authorization&#x60; header, so a custom header of the same name wins..</param>
        public NewAiWebSearchConfig(string provider = default, string key = default, string baseUrl = default, bool isCloudProvider = default, Dictionary<string, string> headers = default)
        {
            // to ensure "provider" is required (not null)
            if (provider == null)
            {
                throw new ArgumentNullException("provider is a required property for NewAiWebSearchConfig and cannot be null");
            }
            this.Provider = provider;
            this.Key = key;
            this.BaseUrl = baseUrl;
            this.IsCloudProvider = isCloudProvider;
            this.Headers = headers;
        }

        /// <summary>
        /// Provider identifier (e.g. &#x60;exa&#x60;).
        /// </summary>
        /// <value>Provider identifier (e.g. &#x60;exa&#x60;).</value>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// API key for the provider. Optional for self-hosted or keyless setups.
        /// </summary>
        /// <value>API key for the provider. Optional for self-hosted or keyless setups.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Optional override for the provider&#39;s base URL.
        /// </summary>
        /// <value>Optional override for the provider&#39;s base URL.</value>
        [DataMember(Name = "baseUrl", EmitDefaultValue = false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Whether this provider is cloud-hosted (vs. self-hosted).
        /// </summary>
        /// <value>Whether this provider is cloud-hosted (vs. self-hosted).</value>
        [DataMember(Name = "isCloudProvider", EmitDefaultValue = true)]
        public bool IsCloudProvider { get; set; }

        /// <summary>
        /// Extra HTTP headers sent with each request to the ONLYOFFICE / cloud backend (e.g. &#x60;X-Tenant&#x60;). Merged after the derived &#x60;Authorization&#x60; header, so a custom header of the same name wins.
        /// </summary>
        /// <value>Extra HTTP headers sent with each request to the ONLYOFFICE / cloud backend (e.g. &#x60;X-Tenant&#x60;). Merged after the derived &#x60;Authorization&#x60; header, so a custom header of the same name wins.</value>
        [DataMember(Name = "headers", EmitDefaultValue = false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiWebSearchConfig {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  IsCloudProvider: ").Append(IsCloudProvider).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
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
