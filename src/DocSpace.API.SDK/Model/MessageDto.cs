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
    /// The chat message information.
    /// </summary>
    [DataContract(Name = "MessageDto")]
    public partial class MessageDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public Role? Role { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDto" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the message..</param>
        /// <param name="role">role.</param>
        /// <param name="contents">The ordered collection of content blocks that make up the message body (text, tool calls, or attachments)..</param>
        /// <param name="createdOn">createdOn.</param>
        public MessageDto(long id = default, Role? role = default, List<MessageContentDto> contents = default, ApiDateTime createdOn = default)
        {
            this.Id = id;
            this.Role = role;
            this.Contents = contents;
            this.CreatedOn = createdOn;
        }

        /// <summary>
        /// The unique identifier of the message.
        /// </summary>
        /// <value>The unique identifier of the message.</value>
        /*
        <example>42</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// The ordered collection of content blocks that make up the message body (text, tool calls, or attachments).
        /// </summary>
        /// <value>The ordered collection of content blocks that make up the message body (text, tool calls, or attachments).</value>
        [DataMember(Name = "contents", EmitDefaultValue = true)]
        public List<MessageContentDto> Contents { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public ApiDateTime CreatedOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
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
