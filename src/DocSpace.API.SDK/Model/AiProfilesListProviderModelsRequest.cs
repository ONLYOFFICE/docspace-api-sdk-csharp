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
    /// AiProfilesListProviderModelsRequest
    /// </summary>
    [DataContract(Name = "aiProfilesListProviderModels_request")]
    public partial class AiProfilesListProviderModelsRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiProfilesListProviderModelsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiProfilesListProviderModelsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiProfilesListProviderModelsRequest" /> class.
        /// </summary>
        /// <param name="providerType">providerType (required).</param>
        /// <param name="baseUrl">Provider API base URL. (required).</param>
        /// <param name="apiKey">Provider API key. (required).</param>
        public AiProfilesListProviderModelsRequest(AiProviderType providerType = default, string baseUrl = default, string apiKey = default)
        {
            // to ensure "providerType" is required (not null)
            if (providerType == null)
            {
                throw new ArgumentNullException("providerType is a required property for AiProfilesListProviderModelsRequest and cannot be null");
            }
            this.ProviderType = providerType;
            // to ensure "baseUrl" is required (not null)
            if (baseUrl == null)
            {
                throw new ArgumentNullException("baseUrl is a required property for AiProfilesListProviderModelsRequest and cannot be null");
            }
            this.BaseUrl = baseUrl;
            // to ensure "apiKey" is required (not null)
            if (apiKey == null)
            {
                throw new ArgumentNullException("apiKey is a required property for AiProfilesListProviderModelsRequest and cannot be null");
            }
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Gets or Sets ProviderType
        /// </summary>
        [DataMember(Name = "providerType", IsRequired = true, EmitDefaultValue = true)]
        public AiProviderType ProviderType { get; set; }

        /// <summary>
        /// Provider API base URL.
        /// </summary>
        /// <value>Provider API base URL.</value>
        [DataMember(Name = "baseUrl", IsRequired = true, EmitDefaultValue = true)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Provider API key.
        /// </summary>
        /// <value>Provider API key.</value>
        [DataMember(Name = "apiKey", IsRequired = true, EmitDefaultValue = true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiProfilesListProviderModelsRequest {\n");
            sb.Append("  ProviderType: ").Append(ProviderType).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
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
