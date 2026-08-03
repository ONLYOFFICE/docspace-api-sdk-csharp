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
    /// Saved prompt template that users can quickly insert into the chat.
    /// </summary>
    [DataContract(Name = "AiPrompt")]
    public partial class AiPrompt : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiPrompt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiPrompt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiPrompt" /> class.
        /// </summary>
        /// <param name="id">Unique prompt identifier (UUID). (required).</param>
        /// <param name="name">Prompt display name shown in the prompt picker. (required).</param>
        /// <param name="text">Prompt template text. May contain placeholder tokens. (required).</param>
        /// <param name="folderId">Optional parent folder ID. &#x60;undefined&#x60; means the prompt is at the root level..</param>
        /// <param name="createdAt">Timestamp (ms since epoch) when the prompt was created. (required).</param>
        /// <param name="updatedAt">Timestamp (ms since epoch) of the last prompt modification. (required).</param>
        public AiPrompt(string id = default, string name = default, string text = default, string folderId = default, decimal createdAt = default, decimal updatedAt = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiPrompt and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AiPrompt and cannot be null");
            }
            this.Name = name;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for AiPrompt and cannot be null");
            }
            this.Text = text;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FolderId = folderId;
        }

        /// <summary>
        /// Unique prompt identifier (UUID).
        /// </summary>
        /// <value>Unique prompt identifier (UUID).</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Prompt display name shown in the prompt picker.
        /// </summary>
        /// <value>Prompt display name shown in the prompt picker.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Prompt template text. May contain placeholder tokens.
        /// </summary>
        /// <value>Prompt template text. May contain placeholder tokens.</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Optional parent folder ID. &#x60;undefined&#x60; means the prompt is at the root level.
        /// </summary>
        /// <value>Optional parent folder ID. &#x60;undefined&#x60; means the prompt is at the root level.</value>
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public string FolderId { get; set; }

        /// <summary>
        /// Timestamp (ms since epoch) when the prompt was created.
        /// </summary>
        /// <value>Timestamp (ms since epoch) when the prompt was created.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Timestamp (ms since epoch) of the last prompt modification.
        /// </summary>
        /// <value>Timestamp (ms since epoch) of the last prompt modification.</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public decimal UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiPrompt {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
