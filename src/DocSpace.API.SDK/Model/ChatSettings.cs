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
    /// ChatSettings
    /// </summary>
    [DataContract(Name = "ChatSettings")]
    public partial class ChatSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSettings" /> class.
        /// </summary>
        /// <param name="providerId">providerId.</param>
        /// <param name="modelId">modelId.</param>
        /// <param name="prompt">prompt.</param>
        public ChatSettings(int providerId = default, string modelId = default, string prompt = default)
        {
            this.ProviderId = providerId;
            this.ModelId = modelId;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "providerId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets ModelId
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "modelId", EmitDefaultValue = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// Gets or Sets Prompt
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "prompt", EmitDefaultValue = true)]
        public string Prompt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatSettings {\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
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
