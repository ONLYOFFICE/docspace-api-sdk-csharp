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
    /// The user request parameters.
    /// </summary>
    [DataContract(Name = "MemberRequestDto")]
    public partial class MemberRequestDto : IValidatableObject
    {

        /// <summary>
        /// The type of the new account: &#x60;User&#x60;, &#x60;RoomAdmin&#x60; or &#x60;DocSpaceAdmin&#x60;. &#x60;Guest&#x60; is not accepted here, and the  value is ignored entirely when &#x60;fromInviteLink&#x60; is set, because the invitation link decides the type. When no  paid seat is free, the account is created as &#x60;User&#x60; whatever was asked for.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public EmployeeType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberRequestDto" /> class.
        /// </summary>
        /// <param name="password">The password in plain text. It is checked against the portal password policy and rejected with 400 when it is  too weak. When neither this field nor &#x60;passwordHash&#x60; is sent, a random password is generated and nobody  learns it, so the account can only be used after a password recovery..</param>
        /// <param name="passwordHash">The password already hashed by the client, which is what the portal stores. It is a PBKDF2-HMACSHA256 hash of  the plain password, computed with the salt, the iteration count and the key size the portal settings publish,  and written as lowercase hexadecimal. When it is sent, &#x60;password&#x60; is ignored and the password policy is not  applied..</param>
        /// <param name="email">The email address of the new account, up to 255 characters. It is required in practice and has to be a real  address, and it becomes the sign-in name of the account..</param>
        /// <param name="type">The type of the new account: &#x60;User&#x60;, &#x60;RoomAdmin&#x60; or &#x60;DocSpaceAdmin&#x60;. &#x60;Guest&#x60; is not accepted here, and the  value is ignored entirely when &#x60;fromInviteLink&#x60; is set, because the invitation link decides the type. When no  paid seat is free, the account is created as &#x60;User&#x60; whatever was asked for..</param>
        /// <param name="isUser">Only chooses which entry the operation writes to the audit trail - the one for a guest or the one for a  member. It does not change the type of the account; &#x60;type&#x60; and the invitation link do that..</param>
        /// <param name="firstName">The first name, up to 255 characters. It is checked together with &#x60;lastName&#x60;, and a pair the portal does not  accept as a name answers 400..</param>
        /// <param name="lastName">The last name, up to 255 characters. It is checked together with &#x60;firstName&#x60;, and a pair the portal does not  accept as a name answers 400..</param>
        /// <param name="department">The groups to put the new account into, by group ID. Read the IDs from &#x60;GET api/2.0/group&#x60;; an ID that  matches no group is skipped without an error..</param>
        /// <param name="location">The free-text location shown on the profile. It is stored as it is given and is not validated..</param>
        /// <param name="comment">The free-text note kept with the profile, shown to administrators. It is stored as it is given..</param>
        /// <param name="contacts">The additional ways to reach the person, each as a type and a value pair. The type is a free-text label such  as &#x60;email&#x60;, &#x60;phone&#x60;, &#x60;skype&#x60; or &#x60;telegram&#x60;, and an entry with an empty value is dropped..</param>
        /// <param name="files">The address the portal downloads the avatar from. It has to use HTTPS unless the request itself came over  HTTP, an address the portal refuses to fetch is rejected, and passing the default avatar path means no  avatar is downloaded..</param>
        /// <param name="fromInviteLink">Set it to true when the account is created by somebody accepting an invitation, which makes &#x60;key&#x60; required  and lets the link decide the type. With the default false the caller has to hold the permission to add an  account of the requested type..</param>
        /// <param name="key">The key of the invitation link being accepted, taken from the link itself. It is read only when  &#x60;fromInviteLink&#x60; is true, and an expired or already used key answers 403..</param>
        /// <param name="cultureName">The interface language of the new account, as a culture code. It is applied whether or not the portal has  that culture enabled, so send a code the portal supports..</param>
        /// <param name="target">Not used. The handler reads nothing from this field, and it is kept only so that existing clients keep  working..</param>
        /// <param name="spam">Whether the account agrees to receive tips, updates and offers. It defaults to false, which means no such  mail is sent..</param>
        public MemberRequestDto(string password = default, string passwordHash = default, string email = default, EmployeeType? type = default, bool? isUser = default, string firstName = default, string lastName = default, List<Guid> department = default, string location = default, string comment = default, List<Contact> contacts = default, string files = default, bool fromInviteLink = default, string key = default, string cultureName = default, Guid target = default, bool? spam = default)
        {
            this.Password = password;
            this.PasswordHash = passwordHash;
            this.Email = email;
            this.Type = type;
            this.IsUser = isUser;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            this.Location = location;
            this.Comment = comment;
            this.Contacts = contacts;
            this.Files = files;
            this.FromInviteLink = fromInviteLink;
            this.Key = key;
            this.CultureName = cultureName;
            this.Target = target;
            this.Spam = spam;
        }

        /// <summary>
        /// The password in plain text. It is checked against the portal password policy and rejected with 400 when it is  too weak. When neither this field nor &#x60;passwordHash&#x60; is sent, a random password is generated and nobody  learns it, so the account can only be used after a password recovery.
        /// </summary>
        /// <example>P@ssw0rd</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The password already hashed by the client, which is what the portal stores. It is a PBKDF2-HMACSHA256 hash of  the plain password, computed with the salt, the iteration count and the key size the portal settings publish,  and written as lowercase hexadecimal. When it is sent, &#x60;password&#x60; is ignored and the password policy is not  applied.
        /// </summary>
        /// <example>c1ba1a0bcbe0f0f42b6c86e1b41a1b4a4a9b4b0e3f2b7d2c1a0e9f8d7c6b5a49</example>
        [DataMember(Name = "passwordHash", EmitDefaultValue = true)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// The email address of the new account, up to 255 characters. It is required in practice and has to be a real  address, and it becomes the sign-in name of the account.
        /// </summary>
        /// <example>john.doe@example.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Only chooses which entry the operation writes to the audit trail - the one for a guest or the one for a  member. It does not change the type of the account; &#x60;type&#x60; and the invitation link do that.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isUser", EmitDefaultValue = true)]
        public bool? IsUser { get; set; }

        /// <summary>
        /// The first name, up to 255 characters. It is checked together with &#x60;lastName&#x60;, and a pair the portal does not  accept as a name answers 400.
        /// </summary>
        /// <example>John</example>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name, up to 255 characters. It is checked together with &#x60;firstName&#x60;, and a pair the portal does not  accept as a name answers 400.
        /// </summary>
        /// <example>Doe</example>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The groups to put the new account into, by group ID. Read the IDs from &#x60;GET api/2.0/group&#x60;; an ID that  matches no group is skipped without an error.
        /// </summary>
        /// <example>["00000000-0000-0000-0000-000000000000"]</example>
        [DataMember(Name = "department", EmitDefaultValue = true)]
        public List<Guid> Department { get; set; }

        /// <summary>
        /// The free-text location shown on the profile. It is stored as it is given and is not validated.
        /// </summary>
        /// <example>New York</example>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// The free-text note kept with the profile, shown to administrators. It is stored as it is given.
        /// </summary>
        /// <example>User comment</example>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// The additional ways to reach the person, each as a type and a value pair. The type is a free-text label such  as &#x60;email&#x60;, &#x60;phone&#x60;, &#x60;skype&#x60; or &#x60;telegram&#x60;, and an entry with an empty value is dropped.
        /// </summary>
        /// <example>[{"type":"email","value":"john.doe@example.com"}]</example>
        [DataMember(Name = "contacts", EmitDefaultValue = true)]
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// The address the portal downloads the avatar from. It has to use HTTPS unless the request itself came over  HTTP, an address the portal refuses to fetch is rejected, and passing the default avatar path means no  avatar is downloaded.
        /// </summary>
        /// <example>https://example.com/avatar.jpg</example>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public string Files { get; set; }

        /// <summary>
        /// Set it to true when the account is created by somebody accepting an invitation, which makes &#x60;key&#x60; required  and lets the link decide the type. With the default false the caller has to hold the permission to add an  account of the requested type.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "fromInviteLink", EmitDefaultValue = true)]
        public bool FromInviteLink { get; set; }

        /// <summary>
        /// The key of the invitation link being accepted, taken from the link itself. It is read only when  &#x60;fromInviteLink&#x60; is true, and an expired or already used key answers 403.
        /// </summary>
        /// <example>user_key_string</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The interface language of the new account, as a culture code. It is applied whether or not the portal has  that culture enabled, so send a code the portal supports.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "cultureName", EmitDefaultValue = true)]
        public string CultureName { get; set; }

        /// <summary>
        /// Not used. The handler reads nothing from this field, and it is kept only so that existing clients keep  working.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public Guid Target { get; set; }

        /// <summary>
        /// Whether the account agrees to receive tips, updates and offers. It defaults to false, which means no such  mail is sent.
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
            sb.Append("class MemberRequestDto {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PasswordHash: ").Append(PasswordHash).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsUser: ").Append(IsUser).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  FromInviteLink: ").Append(FromInviteLink).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
