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
    /// AI model settings information.
    /// </summary>
    [DataContract(Name = "ModelSettingsDto")]
    public partial class ModelSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSettingsDto" /> class.
        /// </summary>
        /// <param name="id">The model identifier. (required).</param>
        /// <param name="alias">The display name for the model..</param>
        /// <param name="isEnabled">Whether the model is enabled for use in chat..</param>
        /// <param name="isRecommended">Whether the model is recommended (defined in configuration)..</param>
        /// <param name="capabilities">capabilities (required).</param>
        public ModelSettingsDto(string id = default, string alias = default, bool isEnabled = default, bool isRecommended = default, AiModelCapabilities capabilities = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ModelSettingsDto and cannot be null");
            }
            this.Id = id;
            // to ensure "capabilities" is required (not null)
            if (capabilities == null)
            {
                throw new ArgumentNullException("capabilities is a required property for ModelSettingsDto and cannot be null");
            }
            this.Capabilities = capabilities;
            this.Alias = alias;
            this.IsEnabled = isEnabled;
            this.IsRecommended = isRecommended;
        }

        /// <summary>
        /// The model identifier.
        /// </summary>
        /// <value>The model identifier.</value>
        /*
        <example>claude-sonnet-4-20250514</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The display name for the model.
        /// </summary>
        /// <value>The display name for the model.</value>
        /*
        <example>Claude Sonnet 4</example>
        */
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Whether the model is enabled for use in chat.
        /// </summary>
        /// <value>Whether the model is enabled for use in chat.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Whether the model is recommended (defined in configuration).
        /// </summary>
        /// <value>Whether the model is recommended (defined in configuration).</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isRecommended", EmitDefaultValue = true)]
        public bool IsRecommended { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", IsRequired = true, EmitDefaultValue = true)]
        public AiModelCapabilities Capabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelSettingsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsRecommended: ").Append(IsRecommended).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
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
