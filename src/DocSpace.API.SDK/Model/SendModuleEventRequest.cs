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
    /// A socket event from an integration module: who receives it in the portal, its name and its payload.
    /// </summary>
    [DataContract(Name = "SendModuleEventRequest")]
    public partial class SendModuleEventRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SendModuleEventRequest" /> class.
        /// </summary>
        /// <param name="room">A room of the module in this portal: everyone subscribed to &#x60;plugin-{module}-{room}&#x60; receives the event. Latin  letters, digits and the characters &#x60;_ . : -&#x60;..</param>
        /// <param name="user">The e-mail of the portal user who receives the event; with single sign-on it is the same e-mail the module&#39;s own  application knows the person by. Only that user&#39;s open sessions receive it..</param>
        /// <param name="event">The event name. Browsers receive it as &#x60;plugin:{module}:{event}&#x60;. Latin letters, digits and the characters  &#x60;_ . : -&#x60;..</param>
        /// <param name="message">Passed to the browser as it is, as &#x60;{ message }&#x60;. Meant as a signal to re-read, such as an unread count; use  JSON text for structured data and keep personal content out of it..</param>
        public SendModuleEventRequest(string room = default, string user = default, string @event = default, string message = default)
        {
            this.Room = room;
            this.User = user;
            this.Event = @event;
            this.Message = message;
        }

        /// <summary>
        /// A room of the module in this portal: everyone subscribed to &#x60;plugin-{module}-{room}&#x60; receives the event. Latin  letters, digits and the characters &#x60;_ . : -&#x60;.
        /// </summary>
        /// <example>shared-inbox</example>
        [DataMember(Name = "room", EmitDefaultValue = true)]
        public string Room { get; set; }

        /// <summary>
        /// The e-mail of the portal user who receives the event; with single sign-on it is the same e-mail the module&#39;s own  application knows the person by. Only that user&#39;s open sessions receive it.
        /// </summary>
        /// <example>e.novikova@example.com</example>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// The event name. Browsers receive it as &#x60;plugin:{module}:{event}&#x60;. Latin letters, digits and the characters  &#x60;_ . : -&#x60;.
        /// </summary>
        /// <example>new-message</example>
        [DataMember(Name = "event", EmitDefaultValue = true)]
        public string Event { get; set; }

        /// <summary>
        /// Passed to the browser as it is, as &#x60;{ message }&#x60;. Meant as a signal to re-read, such as an unread count; use  JSON text for structured data and keep personal content out of it.
        /// </summary>
        /// <example>{"unread":3}</example>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendModuleEventRequest {\n");
            sb.Append("  Room: ").Append(Room).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
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
            yield break;
        }

    }


}
