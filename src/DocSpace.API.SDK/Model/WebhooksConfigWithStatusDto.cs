// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The webhook configuration with its status.
    /// </summary>
    [DataContract(Name = "WebhooksConfigWithStatusDto")]
    public partial class WebhooksConfigWithStatusDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksConfigWithStatusDto" /> class.
        /// </summary>
        /// <param name="configs">configs.</param>
        /// <param name="status">The webhook status..</param>
        public WebhooksConfigWithStatusDto(WebhooksConfigDto configs = default, int status = default)
        {
            this.Configs = configs;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Configs
        /// </summary>
        [DataMember(Name = "configs", EmitDefaultValue = false)]
        public WebhooksConfigDto Configs { get; set; }

        /// <summary>
        /// The webhook status.
        /// </summary>
        /// <value>The webhook status.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhooksConfigWithStatusDto {\n");
            sb.Append("  Configs: ").Append(Configs).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
