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
    /// The request parameters for updating the user information.
    /// </summary>
    [DataContract(Name = "UpdateMemberRequestDto")]
    public partial class UpdateMemberRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Sex
        /// </summary>
        [DataMember(Name = "sex", EmitDefaultValue = false)]
        public SexEnum? Sex { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMemberRequestDto" /> class.
        /// </summary>
        /// <param name="userId">The user ID..</param>
        /// <param name="disable">Specifies whether to disable a user or not..</param>
        /// <param name="email">The user email address..</param>
        /// <param name="isUser">Specifies if this is a guest or a user..</param>
        /// <param name="firstName">The user first name..</param>
        /// <param name="lastName">The user last name..</param>
        /// <param name="department">The list of the user departments..</param>
        /// <param name="title">The user title..</param>
        /// <param name="location">The user location..</param>
        /// <param name="sex">sex.</param>
        /// <param name="birthday">birthday.</param>
        /// <param name="worksfrom">worksfrom.</param>
        /// <param name="comment">The user comment..</param>
        /// <param name="contacts">The list of the user contacts..</param>
        /// <param name="files">The user avatar photo URL..</param>
        /// <param name="spam">Specifies if tips, updates and offers are allowed to be sent to the user or not..</param>
        public UpdateMemberRequestDto(string userId = default, bool? disable = default, string email = default, bool? isUser = default, string firstName = default, string lastName = default, List<Guid> department = default, string title = default, string location = default, SexEnum? sex = default, ApiDateTime birthday = default, ApiDateTime worksfrom = default, string comment = default, List<Contact> contacts = default, string files = default, bool? spam = default)
        {
            this.UserId = userId;
            this.Disable = disable;
            this.Email = email;
            this.IsUser = isUser;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Department = department;
            this.Title = title;
            this.Location = location;
            this.Sex = sex;
            this.Birthday = birthday;
            this.Worksfrom = worksfrom;
            this.Comment = comment;
            this.Contacts = contacts;
            this.Files = files;
            this.Spam = spam;
        }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Specifies whether to disable a user or not.
        /// </summary>
        /// <value>Specifies whether to disable a user or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "disable", EmitDefaultValue = true)]
        public bool? Disable { get; set; }

        /// <summary>
        /// The user email address.
        /// </summary>
        /// <value>The user email address.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Specifies if this is a guest or a user.
        /// </summary>
        /// <value>Specifies if this is a guest or a user.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isUser", EmitDefaultValue = true)]
        public bool? IsUser { get; set; }

        /// <summary>
        /// The user first name.
        /// </summary>
        /// <value>The user first name.</value>
        /*
        <example>Winfield</example>
        */
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user last name.
        /// </summary>
        /// <value>The user last name.</value>
        /*
        <example>Wyman</example>
        */
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The list of the user departments.
        /// </summary>
        /// <value>The list of the user departments.</value>
        /*
        <example>[&quot;75a5f745-f697-4418-b38d-0fe0d277e258&quot;]</example>
        */
        [DataMember(Name = "department", EmitDefaultValue = true)]
        public List<Guid> Department { get; set; }

        /// <summary>
        /// The user title.
        /// </summary>
        /// <value>The user title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The user location.
        /// </summary>
        /// <value>The user location.</value>
        /*
        <example>001 Schroeder Run, New Tabithaport, Colombia</example>
        */
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [DataMember(Name = "birthday", EmitDefaultValue = false)]
        public ApiDateTime Birthday { get; set; }

        /// <summary>
        /// Gets or Sets Worksfrom
        /// </summary>
        [DataMember(Name = "worksfrom", EmitDefaultValue = false)]
        public ApiDateTime Worksfrom { get; set; }

        /// <summary>
        /// The user comment.
        /// </summary>
        /// <value>The user comment.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// The list of the user contacts.
        /// </summary>
        /// <value>The list of the user contacts.</value>
        [DataMember(Name = "contacts", EmitDefaultValue = true)]
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// The user avatar photo URL.
        /// </summary>
        /// <value>The user avatar photo URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public string Files { get; set; }

        /// <summary>
        /// Specifies if tips, updates and offers are allowed to be sent to the user or not.
        /// </summary>
        /// <value>Specifies if tips, updates and offers are allowed to be sent to the user or not.</value>
        /*
        <example>true</example>
        */
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
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Sex: ").Append(Sex).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  Worksfrom: ").Append(Worksfrom).Append("\n");
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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

            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 255.", new [] { "Title" });
            }

            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 0.", new [] { "Title" });
            }

            yield break;
        }
    }


}
