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
    /// The information about the settings which allow to share the document with other users.
    /// </summary>
    [DataContract(Name = "AceShortWrapper")]
    public partial class AceShortWrapper : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AceShortWrapper" /> class.
        /// </summary>
        /// <param name="user">The name of the user the document will be shared with..</param>
        /// <param name="permissions">The access rights for the user with the name above.  Can be \&quot;Full Access\&quot;, \&quot;Read Only\&quot;, or \&quot;Deny Access\&quot;..</param>
        /// <param name="isLink">Specifies whether to change the user icon to the link icon..</param>
        public AceShortWrapper(string user = default, string permissions = default, bool isLink = default)
        {
            this.User = user;
            this.Permissions = permissions;
            this.IsLink = isLink;
        }

        /// <summary>
        /// The name of the user the document will be shared with.
        /// </summary>
        /// <value>The name of the user the document will be shared with.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// The access rights for the user with the name above.  Can be \&quot;Full Access\&quot;, \&quot;Read Only\&quot;, or \&quot;Deny Access\&quot;.
        /// </summary>
        /// <value>The access rights for the user with the name above.  Can be \&quot;Full Access\&quot;, \&quot;Read Only\&quot;, or \&quot;Deny Access\&quot;.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public string Permissions { get; set; }

        /// <summary>
        /// Specifies whether to change the user icon to the link icon.
        /// </summary>
        /// <value>Specifies whether to change the user icon to the link icon.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isLink", EmitDefaultValue = true)]
        public bool IsLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AceShortWrapper {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  IsLink: ").Append(IsLink).Append("\n");
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
