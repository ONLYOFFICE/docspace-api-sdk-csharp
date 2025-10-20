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
    /// The parameters of a user mentioned in a message.
    /// </summary>
    [DataContract(Name = "MentionWrapper")]
    public partial class MentionWrapper : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MentionWrapper" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        public MentionWrapper(UserInfo user = default)
        {
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public UserInfo User { get; set; }

        /// <summary>
        /// The user email address.
        /// </summary>
        /// <value>The user email address.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; private set; }

        /// <summary>
        /// Returns false as Email should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmail()
        {
            return false;
        }
        /// <summary>
        /// The user unique identification.
        /// </summary>
        /// <value>The user unique identification.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The path to the user&#39;s avatar.
        /// </summary>
        /// <value>The path to the user&#39;s avatar.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; private set; }

        /// <summary>
        /// Returns false as Image should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeImage()
        {
            return false;
        }
        /// <summary>
        /// Specifies whether the user has the access to the file where they are mentioned.
        /// </summary>
        /// <value>Specifies whether the user has the access to the file where they are mentioned.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "hasAccess", EmitDefaultValue = true)]
        public bool HasAccess { get; private set; }

        /// <summary>
        /// Returns false as HasAccess should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasAccess()
        {
            return false;
        }
        /// <summary>
        /// The user full name.
        /// </summary>
        /// <value>The user full name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MentionWrapper {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  HasAccess: ").Append(HasAccess).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
