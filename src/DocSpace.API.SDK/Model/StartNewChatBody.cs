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
    /// Parameters for starting a new AI chat session.
    /// </summary>
    [DataContract(Name = "StartNewChatBody")]
    public partial class StartNewChatBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StartNewChatBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StartNewChatBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartNewChatBody" /> class.
        /// </summary>
        /// <param name="message">The initial user message to send to the AI assistant. (required).</param>
        /// <param name="files">The optional collection of file identifiers to attach as context for the AI model..</param>
        public StartNewChatBody(string message = default, List<ContinueChatBodyFilesInner> files = default)
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for StartNewChatBody and cannot be null");
            }
            this.Message = message;
            this.Files = files;
        }

        /// <summary>
        /// The initial user message to send to the AI assistant.
        /// </summary>
        /// <value>The initial user message to send to the AI assistant.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// The optional collection of file identifiers to attach as context for the AI model.
        /// </summary>
        /// <value>The optional collection of file identifiers to attach as context for the AI model.</value>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<ContinueChatBodyFilesInner> Files { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartNewChatBody {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
