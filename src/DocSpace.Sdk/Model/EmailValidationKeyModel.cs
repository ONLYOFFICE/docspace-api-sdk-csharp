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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The confirmation email parameters.
    /// </summary>
    [DataContract(Name = "EmailValidationKeyModel")]
    public partial class EmailValidationKeyModel : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EmplType
        /// </summary>
        [DataMember(Name = "emplType", EmitDefaultValue = false)]
        public EmployeeType? EmplType { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ConfirmType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidationKeyModel" /> class.
        /// </summary>
        /// <param name="key">The email validation key..</param>
        /// <param name="emplType">emplType.</param>
        /// <param name="email">The email address..</param>
        /// <param name="uiD">The user ID..</param>
        /// <param name="type">type.</param>
        /// <param name="first">Specifies whether it is the first time account access or not..</param>
        /// <param name="roomId">The room ID..</param>
        public EmailValidationKeyModel(string key = default, EmployeeType? emplType = default, string email = default, Guid? uiD = default, ConfirmType? type = default, string first = default, string roomId = default)
        {
            this.Key = key;
            this.EmplType = emplType;
            this.Email = email;
            this.UiD = uiD;
            this.Type = type;
            this.First = first;
            this.RoomId = roomId;
        }

        /// <summary>
        /// The email validation key.
        /// </summary>
        /// <value>The email validation key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "uiD", EmitDefaultValue = true)]
        public Guid? UiD { get; set; }

        /// <summary>
        /// Specifies whether it is the first time account access or not.
        /// </summary>
        /// <value>Specifies whether it is the first time account access or not.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "first", EmitDefaultValue = true)]
        public string First { get; set; }

        /// <summary>
        /// The room ID.
        /// </summary>
        /// <value>The room ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "roomId", EmitDefaultValue = true)]
        public string RoomId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailValidationKeyModel {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  EmplType: ").Append(EmplType).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  UiD: ").Append(UiD).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
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
