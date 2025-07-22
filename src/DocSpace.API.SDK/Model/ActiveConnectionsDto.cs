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
    /// The active connections parameters.
    /// </summary>
    [DataContract(Name = "ActiveConnectionsDto")]
    public partial class ActiveConnectionsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveConnectionsDto" /> class.
        /// </summary>
        /// <param name="loginEvent">The login event..</param>
        /// <param name="items">The list of active connection items..</param>
        public ActiveConnectionsDto(int loginEvent = default, List<ActiveConnectionsItemDto> items = default)
        {
            this.LoginEvent = loginEvent;
            this.Items = items;
        }

        /// <summary>
        /// The login event.
        /// </summary>
        /// <value>The login event.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "loginEvent", EmitDefaultValue = false)]
        public int LoginEvent { get; set; }

        /// <summary>
        /// The list of active connection items.
        /// </summary>
        /// <value>The list of active connection items.</value>
        [DataMember(Name = "items", EmitDefaultValue = true)]
        public List<ActiveConnectionsItemDto> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiveConnectionsDto {\n");
            sb.Append("  LoginEvent: ").Append(LoginEvent).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
