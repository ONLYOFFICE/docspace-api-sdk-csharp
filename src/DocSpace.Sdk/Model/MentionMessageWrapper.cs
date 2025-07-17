/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
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
        /// <param name="actionLink">actionLink.</param>
        /// <param name="emails">A list of emails which will receive the mention message..</param>
        /// <param name="message">The comment message..</param>
        public MentionMessageWrapper(ActionLinkConfig actionLink = default, List<string> emails = default, string message = default)
        {
            this.ActionLink = actionLink;
            this.Emails = emails;
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets ActionLink
        /// </summary>
        [DataMember(Name = "actionLink", EmitDefaultValue = false)]
        public ActionLinkConfig ActionLink { get; set; }

        /// <summary>
        /// A list of emails which will receive the mention message.
        /// </summary>
        /// <value>A list of emails which will receive the mention message.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "emails", EmitDefaultValue = true)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// The comment message.
        /// </summary>
        /// <value>The comment message.</value>
        /*
        <example>some text</example>
        */
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
