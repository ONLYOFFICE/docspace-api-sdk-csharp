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
    /// Persistent record for a single attachment (file or image) referenced from a user message. Files carry extracted text in &#x60;content&#x60;; images carry base64 data in &#x60;base64&#x60;. Metadata (&#x60;title&#x60;, &#x60;path&#x60;, &#x60;type&#x60;) is always present for display purposes regardless of whether the heavy payload is loaded.
    /// </summary>
    [DataContract(Name = "AiAttachment")]
    public partial class AiAttachment : IValidatableObject
    {
        /// <summary>
        /// file | image.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KindEnum
        {
            /// <summary>
            /// Enum File for value: file
            /// </summary>
            [EnumMember(Value = "file")]
            File,

            /// <summary>
            /// Enum Image for value: image
            /// </summary>
            [EnumMember(Value = "image")]
            Image
        }

        /// <summary>
        /// file | image.
        /// </summary>
        [DataMember(Name = "kind", IsRequired = true, EmitDefaultValue = true)]
        public KindEnum Kind { get; set; }
        /// <summary>
        /// Origin of the attachment. &#x60;user&#x60; — uploaded by the user in the composer (the default when unset, for backward compatibility). &#x60;tool&#x60; — produced by a tool call (e.g. &#x60;generate_image&#x60;). Lets the integrator&#39;s adapter route or apply policies (separate bucket, quotas, TTL, CDN) per source.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User,

            /// <summary>
            /// Enum Tool for value: tool
            /// </summary>
            [EnumMember(Value = "tool")]
            Tool
        }

        /// <summary>
        /// Origin of the attachment. &#x60;user&#x60; — uploaded by the user in the composer (the default when unset, for backward compatibility). &#x60;tool&#x60; — produced by a tool call (e.g. &#x60;generate_image&#x60;). Lets the integrator&#39;s adapter route or apply policies (separate bucket, quotas, TTL, CDN) per source.
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public SourceEnum? Source { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAttachment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiAttachment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAttachment" /> class.
        /// </summary>
        /// <param name="id">Storage-assigned UUID. (required).</param>
        /// <param name="kind">file | image. (required).</param>
        /// <param name="source">Origin of the attachment. &#x60;user&#x60; — uploaded by the user in the composer (the default when unset, for backward compatibility). &#x60;tool&#x60; — produced by a tool call (e.g. &#x60;generate_image&#x60;). Lets the integrator&#39;s adapter route or apply policies (separate bucket, quotas, TTL, CDN) per source..</param>
        /// <param name="title">Display label (filename or user-visible title). (required).</param>
        /// <param name="content">Extracted text for files..</param>
        /// <param name="base64">Base64 data URL for images..</param>
        /// <param name="path">Original host file path (for files)..</param>
        /// <param name="type">ONLYOFFICE file type code (for files)..</param>
        /// <param name="messageId">Owning message id once linked. Unset while the attachment is a draft..</param>
        /// <param name="threadId">Owning thread id once linked. Unset while the attachment is a draft..</param>
        /// <param name="entityId">Opaque scope token (entity / room) the attachment was created in. Drafts carry it so an entity switch keeps in-flight composer state isolated; once linked to a message the field is redundant with the thread&#39;s own entity binding..</param>
        /// <param name="createdAt">Storage-assigned creation timestamp. (required).</param>
        /// <param name="canAnalyze">Whether the attached form can be analyzed..</param>
        /// <param name="formKeys">Keys of the fields inside the form. &#x60;key&#x60; is the field identifier, &#x60;text&#x60; its human-readable label..</param>
        public AiAttachment(string id = default, KindEnum kind = default, SourceEnum? source = default, string title = default, string content = default, string base64 = default, string path = default, decimal type = default, string messageId = default, string threadId = default, string entityId = default, decimal createdAt = default, bool canAnalyze = default, List<AiAttachmentFormKeysInner> formKeys = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiAttachment and cannot be null");
            }
            this.Id = id;
            this.Kind = kind;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for AiAttachment and cannot be null");
            }
            this.Title = title;
            this.CreatedAt = createdAt;
            this.Source = source;
            this.Content = content;
            this.Base64 = base64;
            this.Path = path;
            this.Type = type;
            this.MessageId = messageId;
            this.ThreadId = threadId;
            this.EntityId = entityId;
            this.CanAnalyze = canAnalyze;
            this.FormKeys = formKeys;
        }

        /// <summary>
        /// Storage-assigned UUID.
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Display label (filename or user-visible title).
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Extracted text for files.
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// Base64 data URL for images.
        /// </summary>
        [DataMember(Name = "base64", EmitDefaultValue = false)]
        public string Base64 { get; set; }

        /// <summary>
        /// Original host file path (for files).
        /// </summary>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// ONLYOFFICE file type code (for files).
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public decimal Type { get; set; }

        /// <summary>
        /// Owning message id once linked. Unset while the attachment is a draft.
        /// </summary>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Owning thread id once linked. Unset while the attachment is a draft.
        /// </summary>
        [DataMember(Name = "threadId", EmitDefaultValue = false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Opaque scope token (entity / room) the attachment was created in. Drafts carry it so an entity switch keeps in-flight composer state isolated; once linked to a message the field is redundant with the thread&#39;s own entity binding.
        /// </summary>
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Storage-assigned creation timestamp.
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Whether the attached form can be analyzed.
        /// </summary>
        [DataMember(Name = "canAnalyze", EmitDefaultValue = true)]
        public bool CanAnalyze { get; set; }

        /// <summary>
        /// Keys of the fields inside the form. &#x60;key&#x60; is the field identifier, &#x60;text&#x60; its human-readable label.
        /// </summary>
        [DataMember(Name = "formKeys", EmitDefaultValue = false)]
        public List<AiAttachmentFormKeysInner> FormKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiAttachment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Base64: ").Append(Base64).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CanAnalyze: ").Append(CanAnalyze).Append("\n");
            sb.Append("  FormKeys: ").Append(FormKeys).Append("\n");
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
