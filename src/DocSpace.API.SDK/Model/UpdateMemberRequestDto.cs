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
    /// The request parameters for updating the user information.
    /// </summary>
    [DataContract(Name = "UpdateMemberRequestDto")]
    public partial class UpdateMemberRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMemberRequestDto" /> class.
        /// </summary>
        /// <param name="userId">The account the change applies to. It is read from this body by &#x60;POST api/2.0/people/email&#x60;, while  &#x60;PUT api/2.0/people/{userid}&#x60; takes the account from the route and ignores this field..</param>
        /// <param name="disable">Set it to true to give the account the &#x60;Terminated&#x60; status and end every session it has, and to false to  bring it back. It is applied only when the caller edits somebody else, and omitting it keeps the current  status..</param>
        /// <param name="email">The new email address, up to 255 characters. It is read only by &#x60;POST api/2.0/people/email&#x60;, which either  mails a confirmation letter or, for an administrator acting on somebody else, applies the address at once;  &#x60;PUT api/2.0/people/{userid}&#x60; ignores it..</param>
        /// <param name="isUser">Set it to true to turn the account into a guest and to false to turn it back into a member. Either direction  takes a seat and can answer 402, it is applied only when the caller edits somebody else, and a request to  make the portal owner, a DocSpace administrator or a module administrator a guest is ignored..</param>
        /// <param name="firstName">The new first name, up to 255 characters. It is applied only to the caller&#39;s own profile, is left alone on an  LDAP or SSO account, and a pair the portal does not accept as a name answers 400..</param>
        /// <param name="lastName">The new last name, up to 255 characters. It is applied only to the caller&#39;s own profile, is left alone on an  LDAP or SSO account, and a pair the portal does not accept as a name answers 400..</param>
        /// <param name="department">The groups the profile should belong to, by group ID, replacing the current ones. It is applied only to the  caller&#39;s own profile..</param>
        /// <param name="location">The new free-text location shown on the profile. It is applied only to the caller&#39;s own profile and is left  alone on an LDAP or SSO account..</param>
        /// <param name="comment">The new free-text note kept with the profile. It is applied only to the caller&#39;s own profile..</param>
        /// <param name="contacts">The additional ways to reach the person, replacing the current ones. Each entry is a free-text type such as  &#x60;email&#x60;, &#x60;phone&#x60;, &#x60;skype&#x60; or &#x60;telegram&#x60; and its value, an entry with an empty value is dropped, and the field  is applied only to the caller&#39;s own profile..</param>
        /// <param name="files">The address the portal downloads the new avatar from. It is applied only to the caller&#39;s own profile, has to  use HTTPS unless the request itself came over HTTP, and passing the address the profile already uses  downloads nothing..</param>
        /// <param name="spam">Whether the account agrees to receive tips, updates and offers. It is applied only to the caller&#39;s own  profile, and omitting it on such a request stores false rather than keeping the current value..</param>
        public UpdateMemberRequestDto(string userId = default, bool? disable = default, string email = default, bool? isUser = default, string firstName = default, string lastName = default, List<Guid> department = default, string location = default, string comment = default, List<Contact> contacts = default, string files = default, bool? spam = default)
        {
            this.UserId = userId;
            this.Disable = disable;
            this.Email = email;
            this.IsUser = isUser;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            this.Location = location;
            this.Comment = comment;
            this.Contacts = contacts;
            this.Files = files;
            this.Spam = spam;
        }

        /// <summary>
        /// The account the change applies to. It is read from this body by &#x60;POST api/2.0/people/email&#x60;, while  &#x60;PUT api/2.0/people/{userid}&#x60; takes the account from the route and ignores this field.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Set it to true to give the account the &#x60;Terminated&#x60; status and end every session it has, and to false to  bring it back. It is applied only when the caller edits somebody else, and omitting it keeps the current  status.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "disable", EmitDefaultValue = true)]
        public bool? Disable { get; set; }

        /// <summary>
        /// The new email address, up to 255 characters. It is read only by &#x60;POST api/2.0/people/email&#x60;, which either  mails a confirmation letter or, for an administrator acting on somebody else, applies the address at once;  &#x60;PUT api/2.0/people/{userid}&#x60; ignores it.
        /// </summary>
        /// <example>john.doe@example.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Set it to true to turn the account into a guest and to false to turn it back into a member. Either direction  takes a seat and can answer 402, it is applied only when the caller edits somebody else, and a request to  make the portal owner, a DocSpace administrator or a module administrator a guest is ignored.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isUser", EmitDefaultValue = true)]
        public bool? IsUser { get; set; }

        /// <summary>
        /// The new first name, up to 255 characters. It is applied only to the caller&#39;s own profile, is left alone on an  LDAP or SSO account, and a pair the portal does not accept as a name answers 400.
        /// </summary>
        /// <example>John</example>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The new last name, up to 255 characters. It is applied only to the caller&#39;s own profile, is left alone on an  LDAP or SSO account, and a pair the portal does not accept as a name answers 400.
        /// </summary>
        /// <example>Doe</example>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The groups the profile should belong to, by group ID, replacing the current ones. It is applied only to the  caller&#39;s own profile.
        /// </summary>
        /// <example>["00000000-0000-0000-0000-000000000000"]</example>
        [DataMember(Name = "department", EmitDefaultValue = true)]
        public List<Guid> Department { get; set; }

        /// <summary>
        /// The new free-text location shown on the profile. It is applied only to the caller&#39;s own profile and is left  alone on an LDAP or SSO account.
        /// </summary>
        /// <example>New York</example>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// The new free-text note kept with the profile. It is applied only to the caller&#39;s own profile.
        /// </summary>
        /// <example>User comment</example>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// The additional ways to reach the person, replacing the current ones. Each entry is a free-text type such as  &#x60;email&#x60;, &#x60;phone&#x60;, &#x60;skype&#x60; or &#x60;telegram&#x60; and its value, an entry with an empty value is dropped, and the field  is applied only to the caller&#39;s own profile.
        /// </summary>
        /// <example>[{"type":"email","value":"john.doe@example.com"}]</example>
        [DataMember(Name = "contacts", EmitDefaultValue = true)]
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// The address the portal downloads the new avatar from. It is applied only to the caller&#39;s own profile, has to  use HTTPS unless the request itself came over HTTP, and passing the address the profile already uses  downloads nothing.
        /// </summary>
        /// <example>https://example.com/avatar.jpg</example>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public string Files { get; set; }

        /// <summary>
        /// Whether the account agrees to receive tips, updates and offers. It is applied only to the caller&#39;s own  profile, and omitting it on such a request stores false rather than keeping the current value.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "spam", EmitDefaultValue = true)]
        public bool? Spam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMemberRequestDto {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Disable: ").Append(Disable).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IsUser: ").Append(IsUser).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Spam: ").Append(Spam).Append("\n");
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
            // Email (string) maxLength
            if (this.Email != null && this.Email.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 255.", new [] { "Email" });
            }

            // Email (string) minLength
            if (this.Email != null && this.Email.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be greater than 0.", new [] { "Email" });
            }

            // FirstName (string) maxLength
            if (this.FirstName != null && this.FirstName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 255.", new [] { "FirstName" });
            }

            // FirstName (string) minLength
            if (this.FirstName != null && this.FirstName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be greater than 0.", new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if (this.LastName != null && this.LastName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 255.", new [] { "LastName" });
            }

            // LastName (string) minLength
            if (this.LastName != null && this.LastName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be greater than 0.", new [] { "LastName" });
            }

            yield break;
        }

    }


}
