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
    /// The full list of user parameters.
    /// </summary>
    [DataContract(Name = "EmployeeFullDto")]
    public partial class EmployeeFullDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public EmployeeStatus? Status { get; set; }

        /// <summary>
        /// Gets or Sets ActivationStatus
        /// </summary>
        [DataMember(Name = "activationStatus", EmitDefaultValue = false)]
        public EmployeeActivationStatus? ActivationStatus { get; set; }

        /// <summary>
        /// Gets or Sets MobilePhoneActivationStatus
        /// </summary>
        [DataMember(Name = "mobilePhoneActivationStatus", EmitDefaultValue = false)]
        public MobilePhoneActivationStatus? MobilePhoneActivationStatus { get; set; }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false)]
        public DarkThemeSettingsType? Theme { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeFullDto" /> class.
        /// </summary>
        /// <param name="id">The user ID..</param>
        /// <param name="displayName">The user display name..</param>
        /// <param name="title">The user title..</param>
        /// <param name="avatar">The user avatar..</param>
        /// <param name="avatarOriginal">The user original size avatar..</param>
        /// <param name="avatarMax">The user maximum size avatar..</param>
        /// <param name="avatarMedium">The user medium size avatar..</param>
        /// <param name="avatarSmall">The user small size avatar..</param>
        /// <param name="profileUrl">The user profile URL..</param>
        /// <param name="hasAvatar">Specifies if the user has an avatar or not..</param>
        /// <param name="isAnonim">Specifies if the user is anonymous or not..</param>
        /// <param name="firstName">The user first name..</param>
        /// <param name="lastName">The user last name..</param>
        /// <param name="userName">The user username..</param>
        /// <param name="email">The user email..</param>
        /// <param name="contacts">The list of user contacts..</param>
        /// <param name="birthday">birthday.</param>
        /// <param name="sex">The user sex..</param>
        /// <param name="status">status.</param>
        /// <param name="activationStatus">activationStatus.</param>
        /// <param name="terminated">terminated.</param>
        /// <param name="department">The user department..</param>
        /// <param name="workFrom">workFrom.</param>
        /// <param name="groups">The list of user groups..</param>
        /// <param name="location">The user location..</param>
        /// <param name="notes">The user notes..</param>
        /// <param name="isAdmin">Specifies if the user is an administrator or not..</param>
        /// <param name="isRoomAdmin">Specifies if the user is a room administrator or not..</param>
        /// <param name="isLDAP">Specifies if the LDAP settings are enabled for the user or not..</param>
        /// <param name="listAdminModules">The list of the administrator modules..</param>
        /// <param name="isOwner">Specifies if the user is a portal owner or not..</param>
        /// <param name="isVisitor">Specifies if the user is a portal visitor or not..</param>
        /// <param name="isCollaborator">Specifies if the user is a portal collaborator or not..</param>
        /// <param name="cultureName">The user culture code..</param>
        /// <param name="mobilePhone">The user mobile phone number..</param>
        /// <param name="mobilePhoneActivationStatus">mobilePhoneActivationStatus.</param>
        /// <param name="isSSO">Specifies if the SSO settings are enabled for the user or not..</param>
        /// <param name="theme">theme.</param>
        /// <param name="quotaLimit">The user quota limit..</param>
        /// <param name="usedSpace">The portal used space of the user..</param>
        /// <param name="shared">Specifies if the user has access rights..</param>
        /// <param name="isCustomQuota">Specifies if the user has a custom quota or not..</param>
        /// <param name="loginEventId">The current login event ID..</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="registrationDate">registrationDate.</param>
        /// <param name="hasPersonalFolder">Specifies if the user has a personal folder or not..</param>
        /// <param name="tfaAppEnabled">Indicates whether the user has enabled two-factor authentication (TFA) using an authentication app..</param>
        public EmployeeFullDto(Guid id = default, string displayName = default, string title = default, string avatar = default, string avatarOriginal = default, string avatarMax = default, string avatarMedium = default, string avatarSmall = default, string profileUrl = default, bool hasAvatar = default, bool isAnonim = default, string firstName = default, string lastName = default, string userName = default, string email = default, List<Contact> contacts = default, ApiDateTime birthday = default, string sex = default, EmployeeStatus? status = default, EmployeeActivationStatus? activationStatus = default, ApiDateTime terminated = default, string department = default, ApiDateTime workFrom = default, List<GroupSummaryDto> groups = default, string location = default, string notes = default, bool isAdmin = default, bool isRoomAdmin = default, bool isLDAP = default, List<string> listAdminModules = default, bool isOwner = default, bool isVisitor = default, bool isCollaborator = default, string cultureName = default, string mobilePhone = default, MobilePhoneActivationStatus? mobilePhoneActivationStatus = default, bool isSSO = default, DarkThemeSettingsType? theme = default, long? quotaLimit = default, double? usedSpace = default, bool? shared = default, bool? isCustomQuota = default, int? loginEventId = default, EmployeeDto createdBy = default, ApiDateTime registrationDate = default, bool hasPersonalFolder = default, bool? tfaAppEnabled = default)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Title = title;
            this.Avatar = avatar;
            this.AvatarOriginal = avatarOriginal;
            this.AvatarMax = avatarMax;
            this.AvatarMedium = avatarMedium;
            this.AvatarSmall = avatarSmall;
            this.ProfileUrl = profileUrl;
            this.HasAvatar = hasAvatar;
            this.IsAnonim = isAnonim;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Email = email;
            this.Contacts = contacts;
            this.Birthday = birthday;
            this.Sex = sex;
            this.Status = status;
            this.ActivationStatus = activationStatus;
            this.Terminated = terminated;
            this.Department = department;
            this.WorkFrom = workFrom;
            this.Groups = groups;
            this.Location = location;
            this.Notes = notes;
            this.IsAdmin = isAdmin;
            this.IsRoomAdmin = isRoomAdmin;
            this.IsLDAP = isLDAP;
            this.ListAdminModules = listAdminModules;
            this.IsOwner = isOwner;
            this.IsVisitor = isVisitor;
            this.IsCollaborator = isCollaborator;
            this.CultureName = cultureName;
            this.MobilePhone = mobilePhone;
            this.MobilePhoneActivationStatus = mobilePhoneActivationStatus;
            this.IsSSO = isSSO;
            this.Theme = theme;
            this.QuotaLimit = quotaLimit;
            this.UsedSpace = usedSpace;
            this.Shared = shared;
            this.IsCustomQuota = isCustomQuota;
            this.LoginEventId = loginEventId;
            this.CreatedBy = createdBy;
            this.RegistrationDate = registrationDate;
            this.HasPersonalFolder = hasPersonalFolder;
            this.TfaAppEnabled = tfaAppEnabled;
        }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The user display name.
        /// </summary>
        /// <value>The user display name.</value>
        /*
        <example>Mike Zanyatski</example>
        */
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The user title.
        /// </summary>
        /// <value>The user title.</value>
        /*
        <example>Manager</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The user avatar.
        /// </summary>
        /// <value>The user avatar.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "avatar", EmitDefaultValue = true)]
        public string Avatar { get; set; }

        /// <summary>
        /// The user original size avatar.
        /// </summary>
        /// <value>The user original size avatar.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "avatarOriginal", EmitDefaultValue = true)]
        public string AvatarOriginal { get; set; }

        /// <summary>
        /// The user maximum size avatar.
        /// </summary>
        /// <value>The user maximum size avatar.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "avatarMax", EmitDefaultValue = true)]
        public string AvatarMax { get; set; }

        /// <summary>
        /// The user medium size avatar.
        /// </summary>
        /// <value>The user medium size avatar.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "avatarMedium", EmitDefaultValue = true)]
        public string AvatarMedium { get; set; }

        /// <summary>
        /// The user small size avatar.
        /// </summary>
        /// <value>The user small size avatar.</value>
        /*
        <example>url to small avatar</example>
        */
        [DataMember(Name = "avatarSmall", EmitDefaultValue = true)]
        public string AvatarSmall { get; set; }

        /// <summary>
        /// The user profile URL.
        /// </summary>
        /// <value>The user profile URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "profileUrl", EmitDefaultValue = true)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// Specifies if the user has an avatar or not.
        /// </summary>
        /// <value>Specifies if the user has an avatar or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "hasAvatar", EmitDefaultValue = true)]
        public bool HasAvatar { get; set; }

        /// <summary>
        /// Specifies if the user is anonymous or not.
        /// </summary>
        /// <value>Specifies if the user is anonymous or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isAnonim", EmitDefaultValue = true)]
        public bool IsAnonim { get; set; }

        /// <summary>
        /// The user first name.
        /// </summary>
        /// <value>The user first name.</value>
        /*
        <example>Mike</example>
        */
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user last name.
        /// </summary>
        /// <value>The user last name.</value>
        /*
        <example>Zanyatski</example>
        */
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The user username.
        /// </summary>
        /// <value>The user username.</value>
        /*
        <example>Mike.Zanyatski</example>
        */
        [DataMember(Name = "userName", EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// The user email.
        /// </summary>
        /// <value>The user email.</value>
        /*
        <example>my@gmail.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The list of user contacts.
        /// </summary>
        /// <value>The list of user contacts.</value>
        [DataMember(Name = "contacts", EmitDefaultValue = true)]
        public List<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [DataMember(Name = "birthday", EmitDefaultValue = false)]
        public ApiDateTime Birthday { get; set; }

        /// <summary>
        /// The user sex.
        /// </summary>
        /// <value>The user sex.</value>
        /*
        <example>male</example>
        */
        [DataMember(Name = "sex", EmitDefaultValue = true)]
        public string Sex { get; set; }

        /// <summary>
        /// Gets or Sets Terminated
        /// </summary>
        [DataMember(Name = "terminated", EmitDefaultValue = false)]
        public ApiDateTime Terminated { get; set; }

        /// <summary>
        /// The user department.
        /// </summary>
        /// <value>The user department.</value>
        /*
        <example>Marketing</example>
        */
        [DataMember(Name = "department", EmitDefaultValue = true)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets WorkFrom
        /// </summary>
        [DataMember(Name = "workFrom", EmitDefaultValue = false)]
        public ApiDateTime WorkFrom { get; set; }

        /// <summary>
        /// The list of user groups.
        /// </summary>
        /// <value>The list of user groups.</value>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<GroupSummaryDto> Groups { get; set; }

        /// <summary>
        /// The user location.
        /// </summary>
        /// <value>The user location.</value>
        /*
        <example>Palo Alto</example>
        */
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// The user notes.
        /// </summary>
        /// <value>The user notes.</value>
        /*
        <example>Notes to worker</example>
        */
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Specifies if the user is an administrator or not.
        /// </summary>
        /// <value>Specifies if the user is an administrator or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isAdmin", EmitDefaultValue = true)]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Specifies if the user is a room administrator or not.
        /// </summary>
        /// <value>Specifies if the user is a room administrator or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isRoomAdmin", EmitDefaultValue = true)]
        public bool IsRoomAdmin { get; set; }

        /// <summary>
        /// Specifies if the LDAP settings are enabled for the user or not.
        /// </summary>
        /// <value>Specifies if the LDAP settings are enabled for the user or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isLDAP", EmitDefaultValue = true)]
        public bool IsLDAP { get; set; }

        /// <summary>
        /// The list of the administrator modules.
        /// </summary>
        /// <value>The list of the administrator modules.</value>
        /*
        <example>[&quot;projects&quot;, &quot;crm&quot;]</example>
        */
        [DataMember(Name = "listAdminModules", EmitDefaultValue = true)]
        public List<string> ListAdminModules { get; set; }

        /// <summary>
        /// Specifies if the user is a portal owner or not.
        /// </summary>
        /// <value>Specifies if the user is a portal owner or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isOwner", EmitDefaultValue = true)]
        public bool IsOwner { get; set; }

        /// <summary>
        /// Specifies if the user is a portal visitor or not.
        /// </summary>
        /// <value>Specifies if the user is a portal visitor or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isVisitor", EmitDefaultValue = true)]
        public bool IsVisitor { get; set; }

        /// <summary>
        /// Specifies if the user is a portal collaborator or not.
        /// </summary>
        /// <value>Specifies if the user is a portal collaborator or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isCollaborator", EmitDefaultValue = true)]
        public bool IsCollaborator { get; set; }

        /// <summary>
        /// The user culture code.
        /// </summary>
        /// <value>The user culture code.</value>
        /*
        <example>en-EN</example>
        */
        [DataMember(Name = "cultureName", EmitDefaultValue = true)]
        public string CultureName { get; set; }

        /// <summary>
        /// The user mobile phone number.
        /// </summary>
        /// <value>The user mobile phone number.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "mobilePhone", EmitDefaultValue = true)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Specifies if the SSO settings are enabled for the user or not.
        /// </summary>
        /// <value>Specifies if the SSO settings are enabled for the user or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isSSO", EmitDefaultValue = true)]
        public bool IsSSO { get; set; }

        /// <summary>
        /// The user quota limit.
        /// </summary>
        /// <value>The user quota limit.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "quotaLimit", EmitDefaultValue = true)]
        public long? QuotaLimit { get; set; }

        /// <summary>
        /// The portal used space of the user.
        /// </summary>
        /// <value>The portal used space of the user.</value>
        /*
        <example>12345</example>
        */
        [DataMember(Name = "usedSpace", EmitDefaultValue = true)]
        public double? UsedSpace { get; set; }

        /// <summary>
        /// Specifies if the user has access rights.
        /// </summary>
        /// <value>Specifies if the user has access rights.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool? Shared { get; set; }

        /// <summary>
        /// Specifies if the user has a custom quota or not.
        /// </summary>
        /// <value>Specifies if the user has a custom quota or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isCustomQuota", EmitDefaultValue = true)]
        public bool? IsCustomQuota { get; set; }

        /// <summary>
        /// The current login event ID.
        /// </summary>
        /// <value>The current login event ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "loginEventId", EmitDefaultValue = true)]
        public int? LoginEventId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public EmployeeDto CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDate
        /// </summary>
        [DataMember(Name = "registrationDate", EmitDefaultValue = false)]
        public ApiDateTime RegistrationDate { get; set; }

        /// <summary>
        /// Specifies if the user has a personal folder or not.
        /// </summary>
        /// <value>Specifies if the user has a personal folder or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "hasPersonalFolder", EmitDefaultValue = true)]
        public bool HasPersonalFolder { get; set; }

        /// <summary>
        /// Indicates whether the user has enabled two-factor authentication (TFA) using an authentication app.
        /// </summary>
        /// <value>Indicates whether the user has enabled two-factor authentication (TFA) using an authentication app.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "tfaAppEnabled", EmitDefaultValue = true)]
        public bool? TfaAppEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeFullDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  AvatarOriginal: ").Append(AvatarOriginal).Append("\n");
            sb.Append("  AvatarMax: ").Append(AvatarMax).Append("\n");
            sb.Append("  AvatarMedium: ").Append(AvatarMedium).Append("\n");
            sb.Append("  AvatarSmall: ").Append(AvatarSmall).Append("\n");
            sb.Append("  ProfileUrl: ").Append(ProfileUrl).Append("\n");
            sb.Append("  HasAvatar: ").Append(HasAvatar).Append("\n");
            sb.Append("  IsAnonim: ").Append(IsAnonim).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  Sex: ").Append(Sex).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ActivationStatus: ").Append(ActivationStatus).Append("\n");
            sb.Append("  Terminated: ").Append(Terminated).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  WorkFrom: ").Append(WorkFrom).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  IsRoomAdmin: ").Append(IsRoomAdmin).Append("\n");
            sb.Append("  IsLDAP: ").Append(IsLDAP).Append("\n");
            sb.Append("  ListAdminModules: ").Append(ListAdminModules).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
            sb.Append("  IsVisitor: ").Append(IsVisitor).Append("\n");
            sb.Append("  IsCollaborator: ").Append(IsCollaborator).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  MobilePhoneActivationStatus: ").Append(MobilePhoneActivationStatus).Append("\n");
            sb.Append("  IsSSO: ").Append(IsSSO).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  QuotaLimit: ").Append(QuotaLimit).Append("\n");
            sb.Append("  UsedSpace: ").Append(UsedSpace).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  IsCustomQuota: ").Append(IsCustomQuota).Append("\n");
            sb.Append("  LoginEventId: ").Append(LoginEventId).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  HasPersonalFolder: ").Append(HasPersonalFolder).Append("\n");
            sb.Append("  TfaAppEnabled: ").Append(TfaAppEnabled).Append("\n");
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
