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
    /// A user the editor may offer: to be mentioned in a comment, or to be picked when protecting a document.
    /// </summary>
    [DataContract(Name = "MentionWrapper")]
    public partial class MentionWrapper : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MentionWrapper" /> class.
        /// </summary>
        /// <param name="user">The account itself, in the shape the people listings use..</param>
        public MentionWrapper(UserInfo user = default)
        {
            this.User = user;
        }

        /// <summary>
        /// The account itself, in the shape the people listings use.
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public UserInfo User { get; set; }

        /// <summary>
        /// Where a mention notification for this user is delivered.
        /// </summary>
        /// <example>user@example.com</example>
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
        /// The account id as text, the same value the account object carries; it is what identifies the user in a sharing  request built from this list.
        /// </summary>
        /// <example>user_0001</example>
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
        /// An absolute address of the medium-sized avatar. A generated default avatar is reported when the user never  uploaded one, so the field is never empty.
        /// </summary>
        /// <example>https://portal.example.com/avatar/user_0001.png</example>
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
        /// Not filled in by the operations that return this list: it always comes back false. Whether a user can already  open the document has to be read from the sharing settings of the file.
        /// </summary>
        /// <example>true</example>
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
        /// The name to display, assembled the way the portal is configured to show names.
        /// </summary>
        /// <example>John Doe</example>
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
