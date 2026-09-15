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
    /// Whether a confirmation link may still be used, and what it leads to when it invites into a room.
    /// </summary>
    [DataContract(Name = "ConfirmDto")]
    public partial class ConfirmDto : IValidatableObject
    {

        /// <summary>
        /// The outcome of the check. Only &#x60;Ok&#x60; means the action behind the link may be carried out: &#x60;Invalid&#x60; and  &#x60;Expired&#x60; fault the key itself, while &#x60;UserExisted&#x60;, &#x60;UserExcluded&#x60;, &#x60;TariffLimit&#x60; and &#x60;QuotaFailed&#x60; mean  the key is sound but the invitation behind it cannot be accepted as it stands.
        /// </summary>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = true)]
        public ValidationResult Result { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfirmDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmDto" /> class.
        /// </summary>
        /// <param name="result">The outcome of the check. Only &#x60;Ok&#x60; means the action behind the link may be carried out: &#x60;Invalid&#x60; and  &#x60;Expired&#x60; fault the key itself, while &#x60;UserExisted&#x60;, &#x60;UserExcluded&#x60;, &#x60;TariffLimit&#x60; and &#x60;QuotaFailed&#x60; mean  the key is sound but the invitation behind it cannot be accepted as it stands. (required).</param>
        /// <param name="roomId">The room the invitation leads into - a numeric folder ID for a room of the portal, a provider-specific  string for a third-party one. It is empty for an invitation to the portal as a whole, for a room that has  been removed or that the invited account may not see, and whenever &#x60;result&#x60; is neither &#x60;Ok&#x60; nor  &#x60;UserExisted&#x60;..</param>
        /// <param name="title">The title of that room, present exactly when &#x60;roomId&#x60; is and meant to be shown on the confirmation page..</param>
        /// <param name="email">The address the link was issued for, echoed back only when &#x60;result&#x60; is &#x60;Ok&#x60; so that a sign-up form can be  prefilled with it. Every other outcome leaves it empty, &#x60;UserExisted&#x60; included..</param>
        /// <param name="isAgent">Whether the room behind the link is an AI room rather than an ordinary one, which decides where the invited  person is taken. It is &#x60;false&#x60; whenever &#x60;roomId&#x60; is empty..</param>
        public ConfirmDto(ValidationResult result = default, string roomId = default, string title = default, string email = default, bool isAgent = default)
        {
            this.Result = result;
            this.RoomId = roomId;
            this.Title = title;
            this.Email = email;
            this.IsAgent = isAgent;
        }

        /// <summary>
        /// The room the invitation leads into - a numeric folder ID for a room of the portal, a provider-specific  string for a third-party one. It is empty for an invitation to the portal as a whole, for a room that has  been removed or that the invited account may not see, and whenever &#x60;result&#x60; is neither &#x60;Ok&#x60; nor  &#x60;UserExisted&#x60;.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "roomId", EmitDefaultValue = true)]
        public string RoomId { get; set; }

        /// <summary>
        /// The title of that room, present exactly when &#x60;roomId&#x60; is and meant to be shown on the confirmation page.
        /// </summary>
        /// <example>Conference Room</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The address the link was issued for, echoed back only when &#x60;result&#x60; is &#x60;Ok&#x60; so that a sign-up form can be  prefilled with it. Every other outcome leaves it empty, &#x60;UserExisted&#x60; included.
        /// </summary>
        /// <example>user@example.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Whether the room behind the link is an AI room rather than an ordinary one, which decides where the invited  person is taken. It is &#x60;false&#x60; whenever &#x60;roomId&#x60; is empty.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isAgent", EmitDefaultValue = true)]
        public bool IsAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmDto {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IsAgent: ").Append(IsAgent).Append("\n");
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
