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
    /// AiThreadMessageLikeContentAnyOfInner
    /// </summary>
    [DataContract(Name = "AiThreadMessageLike_content_anyOf_inner")]
    public partial class AiThreadMessageLikeContentAnyOfInner : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadMessageLikeContentAnyOfInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiThreadMessageLikeContentAnyOfInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadMessageLikeContentAnyOfInner" /> class.
        /// </summary>
        /// <param name="type">Part kind: &#x60;text&#x60;, &#x60;reasoning&#x60;, &#x60;source&#x60;, &#x60;image&#x60;, &#x60;file&#x60;, &#x60;audio&#x60;, &#x60;data&#x60; or &#x60;tool-call&#x60;. (required).</param>
        /// <param name="text">The text of a &#x60;text&#x60; or &#x60;reasoning&#x60; part..</param>
        /// <param name="parentId">Id of the part this one belongs to, on &#x60;text&#x60;, &#x60;reasoning&#x60;, &#x60;source&#x60; and &#x60;tool-call&#x60; parts. On a &#x60;reasoning&#x60; part the chat library keeps the provider&#39;s thinking signature here..</param>
        /// <param name="sourceType">A &#x60;source&#x60; part&#39;s source kind; always &#x60;url&#x60;..</param>
        /// <param name="id">A &#x60;source&#x60; part&#39;s id..</param>
        /// <param name="url">A &#x60;source&#x60; part&#39;s URL..</param>
        /// <param name="title">A &#x60;source&#x60; part&#39;s title..</param>
        /// <param name="image">An &#x60;image&#x60; part&#39;s picture, as a URL (usually a &#x60;data:&#x60; URL). For an image the user attached, a JSON string &#x60;{ ref, title, kind: image }&#x60; naming the stored attachment instead..</param>
        /// <param name="mimeType">A &#x60;file&#x60; part&#39;s media type. For a file the user attached, a JSON string &#x60;{ ref, title, kind: file, path, type }&#x60; naming the stored attachment instead - the chat library carries the reference here..</param>
        /// <param name="data">A &#x60;file&#x60; part&#39;s content; empty when the part references an attachment. (A &#x60;data&#x60; part would carry its payload here too, as any JSON value; neither the chat library nor this service writes one.).</param>
        /// <param name="filename">The file name of a &#x60;file&#x60; or &#x60;image&#x60; part..</param>
        /// <param name="name">An &#x60;image&#x60; part&#39;s display name, or a &#x60;data&#x60; part&#39;s name..</param>
        /// <param name="audio">audio.</param>
        /// <param name="toolCallId">A &#x60;tool-call&#x60; part&#39;s call id..</param>
        /// <param name="toolName">A &#x60;tool-call&#x60; part&#39;s tool name..</param>
        /// <param name="args">A &#x60;tool-call&#x60; part&#39;s arguments..</param>
        /// <param name="argsText">A &#x60;tool-call&#x60; part&#39;s arguments as the model streamed them, JSON text..</param>
        /// <param name="result">result.</param>
        /// <param name="isError">Whether a &#x60;tool-call&#x60; part&#39;s result is an error..</param>
        /// <param name="artifact">artifact.</param>
        /// <param name="interrupt">interrupt.</param>
        /// <param name="messages">Messages of a sub-agent run inside a &#x60;tool-call&#x60; part..</param>
        /// <param name="metadata">Provider-specific data of a &#x60;tool-call&#x60; part - for a Gemini call, &#x60;{ thoughtSignature }&#x60;, which has to be sent back with the call..</param>
        public AiThreadMessageLikeContentAnyOfInner(string type = default, string text = default, string parentId = default, string sourceType = default, string id = default, string url = default, string title = default, string image = default, string mimeType = default, string data = default, string filename = default, string name = default, AiThreadMessageLikeContentAnyOfInnerAudio audio = default, string toolCallId = default, string toolName = default, Object args = default, string argsText = default, Object result = default, bool isError = default, Object artifact = default, AiThreadMessageLikeContentAnyOfInnerInterrupt interrupt = default, List<Object> messages = default, Object metadata = default)
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for AiThreadMessageLikeContentAnyOfInner and cannot be null");
            }
            this.Type = type;
            this.Text = text;
            this.ParentId = parentId;
            this.SourceType = sourceType;
            this.Id = id;
            this.Url = url;
            this.Title = title;
            this.Image = image;
            this.MimeType = mimeType;
            this.Data = data;
            this.Filename = filename;
            this.Name = name;
            this.Audio = audio;
            this.ToolCallId = toolCallId;
            this.ToolName = toolName;
            this.Args = args;
            this.ArgsText = argsText;
            this.Result = result;
            this.IsError = isError;
            this.Artifact = artifact;
            this.Interrupt = interrupt;
            this.Messages = messages;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Part kind: &#x60;text&#x60;, &#x60;reasoning&#x60;, &#x60;source&#x60;, &#x60;image&#x60;, &#x60;file&#x60;, &#x60;audio&#x60;, &#x60;data&#x60; or &#x60;tool-call&#x60;.
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The text of a &#x60;text&#x60; or &#x60;reasoning&#x60; part.
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Id of the part this one belongs to, on &#x60;text&#x60;, &#x60;reasoning&#x60;, &#x60;source&#x60; and &#x60;tool-call&#x60; parts. On a &#x60;reasoning&#x60; part the chat library keeps the provider&#39;s thinking signature here.
        /// </summary>
        [DataMember(Name = "parentId", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// A &#x60;source&#x60; part&#39;s source kind; always &#x60;url&#x60;.
        /// </summary>
        [DataMember(Name = "sourceType", EmitDefaultValue = false)]
        public string SourceType { get; set; }

        /// <summary>
        /// A &#x60;source&#x60; part&#39;s id.
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// A &#x60;source&#x60; part&#39;s URL.
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// A &#x60;source&#x60; part&#39;s title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// An &#x60;image&#x60; part&#39;s picture, as a URL (usually a &#x60;data:&#x60; URL). For an image the user attached, a JSON string &#x60;{ ref, title, kind: image }&#x60; naming the stored attachment instead.
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// A &#x60;file&#x60; part&#39;s media type. For a file the user attached, a JSON string &#x60;{ ref, title, kind: file, path, type }&#x60; naming the stored attachment instead - the chat library carries the reference here.
        /// </summary>
        [DataMember(Name = "mimeType", EmitDefaultValue = false)]
        public string MimeType { get; set; }

        /// <summary>
        /// A &#x60;file&#x60; part&#39;s content; empty when the part references an attachment. (A &#x60;data&#x60; part would carry its payload here too, as any JSON value; neither the chat library nor this service writes one.)
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// The file name of a &#x60;file&#x60; or &#x60;image&#x60; part.
        /// </summary>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        public string Filename { get; set; }

        /// <summary>
        /// An &#x60;image&#x60; part&#39;s display name, or a &#x60;data&#x60; part&#39;s name.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Audio
        /// </summary>
        [DataMember(Name = "audio", EmitDefaultValue = false)]
        public AiThreadMessageLikeContentAnyOfInnerAudio Audio { get; set; }

        /// <summary>
        /// A &#x60;tool-call&#x60; part&#39;s call id.
        /// </summary>
        [DataMember(Name = "toolCallId", EmitDefaultValue = false)]
        public string ToolCallId { get; set; }

        /// <summary>
        /// A &#x60;tool-call&#x60; part&#39;s tool name.
        /// </summary>
        [DataMember(Name = "toolName", EmitDefaultValue = false)]
        public string ToolName { get; set; }

        /// <summary>
        /// A &#x60;tool-call&#x60; part&#39;s arguments.
        /// </summary>
        [DataMember(Name = "args", EmitDefaultValue = false)]
        public Object Args { get; set; }

        /// <summary>
        /// A &#x60;tool-call&#x60; part&#39;s arguments as the model streamed them, JSON text.
        /// </summary>
        [DataMember(Name = "argsText", EmitDefaultValue = false)]
        public string ArgsText { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public Object Result { get; set; }

        /// <summary>
        /// Whether a &#x60;tool-call&#x60; part&#39;s result is an error.
        /// </summary>
        [DataMember(Name = "isError", EmitDefaultValue = true)]
        public bool IsError { get; set; }

        /// <summary>
        /// Gets or Sets Artifact
        /// </summary>
        [DataMember(Name = "artifact", EmitDefaultValue = true)]
        public Object Artifact { get; set; }

        /// <summary>
        /// Gets or Sets Interrupt
        /// </summary>
        [DataMember(Name = "interrupt", EmitDefaultValue = false)]
        public AiThreadMessageLikeContentAnyOfInnerInterrupt Interrupt { get; set; }

        /// <summary>
        /// Messages of a sub-agent run inside a &#x60;tool-call&#x60; part.
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<Object> Messages { get; set; }

        /// <summary>
        /// Provider-specific data of a &#x60;tool-call&#x60; part - for a Gemini call, &#x60;{ thoughtSignature }&#x60;, which has to be sent back with the call.
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiThreadMessageLikeContentAnyOfInner {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Audio: ").Append(Audio).Append("\n");
            sb.Append("  ToolCallId: ").Append(ToolCallId).Append("\n");
            sb.Append("  ToolName: ").Append(ToolName).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  ArgsText: ").Append(ArgsText).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  IsError: ").Append(IsError).Append("\n");
            sb.Append("  Artifact: ").Append(Artifact).Append("\n");
            sb.Append("  Interrupt: ").Append(Interrupt).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
