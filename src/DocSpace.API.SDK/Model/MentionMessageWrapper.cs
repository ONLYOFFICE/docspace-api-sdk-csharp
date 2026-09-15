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
    /// The mention notification to send: what to say, whom to tell and where in the document the mention sits.
    /// </summary>
    [DataContract(Name = "MentionMessageWrapper")]
    public partial class MentionMessageWrapper : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MentionMessageWrapper" /> class.
        /// </summary>
        /// <param name="actionLink">The place in the document the notification link should open at, as the editor reports it when the mention is  made. Left out, the link opens the file at its beginning..</param>
        /// <param name="emails">The addresses to notify. Only an address that belongs to a portal account receives a mail; an unknown address  is skipped, and the answer then carries the access list of the file so that the client can invite its owner..</param>
        /// <param name="message">The note shown next to the link in the mail. Only its first 200 characters are sent, and a value longer than  the field allows is refused..</param>
        public MentionMessageWrapper(ActionLinkConfig actionLink = default, List<string> emails = default, string message = default)
        {
            this.ActionLink = actionLink;
            this.Emails = emails;
            this.Message = message;
        }

        /// <summary>
        /// The place in the document the notification link should open at, as the editor reports it when the mention is  made. Left out, the link opens the file at its beginning.
        /// </summary>
        [DataMember(Name = "actionLink", EmitDefaultValue = false)]
        public ActionLinkConfig ActionLink { get; set; }

        /// <summary>
        /// The addresses to notify. Only an address that belongs to a portal account receives a mail; an unknown address  is skipped, and the answer then carries the access list of the file so that the client can invite its owner.
        /// </summary>
        /// <example>["user1@example.com","user2@example.com"]</example>
        [DataMember(Name = "emails", EmitDefaultValue = true)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// The note shown next to the link in the mail. Only its first 200 characters are sent, and a value longer than  the field allows is refused.
        /// </summary>
        /// <example>Please take a look at the second paragraph</example>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MentionMessageWrapper {\n");
            sb.Append("  ActionLink: ").Append(ActionLink).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            // Message (string) maxLength
            if (this.Message != null && this.Message.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 255.", new [] { "Message" });
            }

            // Message (string) minLength
            if (this.Message != null && this.Message.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be greater than 0.", new [] { "Message" });
            }

            yield break;
        }

    }


}
