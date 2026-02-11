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
    /// ContinueChatBody
    /// </summary>
    [DataContract(Name = "ContinueChatBody")]
    public partial class ContinueChatBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinueChatBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContinueChatBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContinueChatBody" /> class.
        /// </summary>
        /// <param name="message">message (required).</param>
        /// <param name="contextFolderId">contextFolderId.</param>
        /// <param name="files">files.</param>
        public ContinueChatBody(string message = default, int contextFolderId = default, List<DuplicateRequestDtoAllOfFileIds> files = default)
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for ContinueChatBody and cannot be null");
            }
            this.Message = message;
            this.ContextFolderId = contextFolderId;
            this.Files = files;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ContextFolderId
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "contextFolderId", EmitDefaultValue = false)]
        public int ContextFolderId { get; set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<DuplicateRequestDtoAllOfFileIds> Files { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContinueChatBody {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ContextFolderId: ").Append(ContextFolderId).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
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
