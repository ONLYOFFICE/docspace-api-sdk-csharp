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
    /// The request parameters for inviting users to the room.
    /// </summary>
    [DataContract(Name = "RoomInvitationRequest")]
    public partial class RoomInvitationRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomInvitationRequest" /> class.
        /// </summary>
        /// <param name="invitations">The collection of invitation parameters..</param>
        /// <param name="notify">Specifies whether to notify users about the shared room or not..</param>
        /// <param name="message">The message to send when notifying about the shared room..</param>
        /// <param name="culture">The language of the room invitation..</param>
        /// <param name="force">Specifies whether to forcibly delete a user with form roles from the room..</param>
        public RoomInvitationRequest(List<RoomInvitation> invitations = default, bool notify = default, string message = default, string culture = default, bool force = default)
        {
            this.Invitations = invitations;
            this.Notify = notify;
            this.Message = message;
            this.Culture = culture;
            this.Force = force;
        }

        /// <summary>
        /// The collection of invitation parameters.
        /// </summary>
        /// <value>The collection of invitation parameters.</value>
        [DataMember(Name = "invitations", EmitDefaultValue = true)]
        public List<RoomInvitation> Invitations { get; set; }

        /// <summary>
        /// Specifies whether to notify users about the shared room or not.
        /// </summary>
        /// <value>Specifies whether to notify users about the shared room or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "notify", EmitDefaultValue = true)]
        public bool Notify { get; set; }

        /// <summary>
        /// The message to send when notifying about the shared room.
        /// </summary>
        /// <value>The message to send when notifying about the shared room.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// The language of the room invitation.
        /// </summary>
        /// <value>The language of the room invitation.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "culture", EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// Specifies whether to forcibly delete a user with form roles from the room.
        /// </summary>
        /// <value>Specifies whether to forcibly delete a user with form roles from the room.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "force", EmitDefaultValue = true)]
        public bool Force { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomInvitationRequest {\n");
            sb.Append("  Invitations: ").Append(Invitations).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
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
