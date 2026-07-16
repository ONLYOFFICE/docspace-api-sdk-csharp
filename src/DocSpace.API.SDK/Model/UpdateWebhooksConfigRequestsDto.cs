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
    /// The request parameters for updating the webhook configuration.
    /// </summary>
    [DataContract(Name = "UpdateWebhooksConfigRequestsDto")]
    public partial class UpdateWebhooksConfigRequestsDto : CreateWebhooksConfigRequestsDto, IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhooksConfigRequestsDto" /> class.
        /// </summary>
        [JsonConstructor]
        protected UpdateWebhooksConfigRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhooksConfigRequestsDto" /> class.
        /// </summary>
        /// <param name="id">The webhook configuration ID. (required).</param>
        public UpdateWebhooksConfigRequestsDto(int id = default)
        {
            this.Id = id;
        }

        /// <summary>
        /// The webhook configuration ID.
        /// </summary>
        /// <value>The webhook configuration ID.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWebhooksConfigRequestsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // Uri (string) minLength
            if (this.Uri != null && this.Uri.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Uri, length must be greater than 1.", new [] { "Uri" });
            }

            // SecretKey (string) maxLength
            if (this.SecretKey != null && this.SecretKey.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecretKey, length must be less than 50.", new [] { "SecretKey" });
            }

            // SecretKey (string) minLength
            if (this.SecretKey != null && this.SecretKey.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecretKey, length must be greater than 0.", new [] { "SecretKey" });
            }

            // TargetId (string) maxLength
            if (this.TargetId != null && this.TargetId.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TargetId, length must be less than 255.", new [] { "TargetId" });
            }

            // TargetId (string) minLength
            if (this.TargetId != null && this.TargetId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TargetId, length must be greater than 0.", new [] { "TargetId" });
            }

            yield break;
        }

    }
}
