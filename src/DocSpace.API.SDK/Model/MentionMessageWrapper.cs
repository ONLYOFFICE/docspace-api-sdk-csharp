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
    /// The mention message parameters.
    /// </summary>
    [DataContract(Name = "MentionMessageWrapper")]
    public partial class MentionMessageWrapper : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MentionMessageWrapper" /> class.
        /// </summary>
        /// <param name="actionLink">The config parameter which contains the information about the action in the document that will be scrolled to..</param>
        /// <param name="emails">A list of emails that will receive the mention message..</param>
        /// <param name="message">The mention message..</param>
        public MentionMessageWrapper(ActionLinkConfig actionLink = default, List<string> emails = default, string message = default)
        {
            this.ActionLink = actionLink;
            this.Emails = emails;
            this.Message = message;
        }

        /// <summary>
        /// The config parameter which contains the information about the action in the document that will be scrolled to.
        /// </summary>
        [DataMember(Name = "actionLink", EmitDefaultValue = false)]
        public ActionLinkConfig ActionLink { get; set; }

        /// <summary>
        /// A list of emails that will receive the mention message.
        /// </summary>
        /// <example>["user1@example.com","user2@example.com"]</example>
        [DataMember(Name = "emails", EmitDefaultValue = true)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// The mention message.
        /// </summary>
        /// <example>Hello</example>
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
