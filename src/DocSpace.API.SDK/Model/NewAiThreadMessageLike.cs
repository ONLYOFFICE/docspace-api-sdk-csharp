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
    /// NewAiThreadMessageLike
    /// </summary>
    [DataContract(Name = "NewAiThreadMessageLike")]
    public partial class NewAiThreadMessageLike : IValidatableObject
    {
        /// <summary>
        /// Message author role.
        /// </summary>
        /// <value>Message author role.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User,

            /// <summary>
            /// Enum Assistant for value: assistant
            /// </summary>
            [EnumMember(Value = "assistant")]
            Assistant,

            /// <summary>
            /// Enum System for value: system
            /// </summary>
            [EnumMember(Value = "system")]
            System
        }

        /// <summary>
        /// Message author role.
        /// </summary>
        /// <value>Message author role.</value>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public RoleEnum Role { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiThreadMessageLike" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiThreadMessageLike() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiThreadMessageLike" /> class.
        /// </summary>
        /// <param name="id">Storage-assigned message id (absent on inbound drafts)..</param>
        /// <param name="role">Message author role. (required).</param>
        /// <param name="content">content (required).</param>
        /// <param name="createdAt">Creation timestamp, ISO-8601 on the wire..</param>
        /// <param name="status">status.</param>
        /// <param name="metadata">Arbitrary per-message metadata..</param>
        /// <param name="attachments">Attachments linked to the message..</param>
        public NewAiThreadMessageLike(string id = default, RoleEnum role = default, NewAiThreadMessageLikeContent content = default, string createdAt = default, NewAiThreadMessageLikeStatus status = default, Object metadata = default, List<Object> attachments = default)
        {
            this.Role = role;
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for NewAiThreadMessageLike and cannot be null");
            }
            this.Content = content;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Metadata = metadata;
            this.Attachments = attachments;
        }

        /// <summary>
        /// Storage-assigned message id (absent on inbound drafts).
        /// </summary>
        /// <value>Storage-assigned message id (absent on inbound drafts).</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public NewAiThreadMessageLikeContent Content { get; set; }

        /// <summary>
        /// Creation timestamp, ISO-8601 on the wire.
        /// </summary>
        /// <value>Creation timestamp, ISO-8601 on the wire.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public NewAiThreadMessageLikeStatus Status { get; set; }

        /// <summary>
        /// Arbitrary per-message metadata.
        /// </summary>
        /// <value>Arbitrary per-message metadata.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Attachments linked to the message.
        /// </summary>
        /// <value>Attachments linked to the message.</value>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<Object> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiThreadMessageLike {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
