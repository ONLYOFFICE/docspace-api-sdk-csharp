// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


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
using FileParameter = DocSpace.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Client.OpenAPIDateConverter;

namespace DocSpace.Model
{
    /// <summary>
    /// The user information.
    /// </summary>
    [DataContract(Name = "UserInfo")]
    public partial class UserInfo : IValidatableObject
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
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// </summary>
        /// <param name="id">The user ID..</param>
        /// <param name="firstName">The user first name..</param>
        /// <param name="lastName">The user last name..</param>
        /// <param name="userName">The user username..</param>
        /// <param name="birthDate">The user birthday..</param>
        /// <param name="sex">The user sex (male or female)..</param>
        /// <param name="status">status.</param>
        /// <param name="activationStatus">activationStatus.</param>
        /// <param name="terminatedDate">The date and time when the user account was terminated..</param>
        /// <param name="title">The user title..</param>
        /// <param name="workFromDate">The user registration date..</param>
        /// <param name="email">The user email address..</param>
        /// <param name="contacts">The list of user contacts in the string format..</param>
        /// <param name="contactsList">The list of user contacts..</param>
        /// <param name="location">The user location..</param>
        /// <param name="notes">The user notes..</param>
        /// <param name="removed">Specifies if the user account was removed or not..</param>
        /// <param name="lastModified">The date and time when the user account was last modified..</param>
        /// <param name="tenantId">The tenant ID..</param>
        /// <param name="cultureName">The user culture code..</param>
        /// <param name="mobilePhone">The user mobile phone..</param>
        /// <param name="mobilePhoneActivationStatus">mobilePhoneActivationStatus.</param>
        /// <param name="sid">The LDAP user identificator..</param>
        /// <param name="ldapQouta">The LDAP user quota attribute..</param>
        /// <param name="ssoNameId">The SSO SAML user identificator..</param>
        /// <param name="ssoSessionId">The SSO SAML user session identificator..</param>
        /// <param name="createDate">The date and time when the user account was created..</param>
        /// <param name="createdBy">The ID of the user who created the current user account..</param>
        /// <param name="spam">Specifies if tips, updates and offers are allowed to be sent to the user or not..</param>
        public UserInfo(Guid id = default, string firstName = default, string lastName = default, string userName = default, DateTime? birthDate = default, bool? sex = default, EmployeeStatus? status = default, EmployeeActivationStatus? activationStatus = default, DateTime? terminatedDate = default, string title = default, DateTime? workFromDate = default, string email = default, string contacts = default, List<string> contactsList = default, string location = default, string notes = default, bool removed = default, DateTime lastModified = default, int tenantId = default, string cultureName = default, string mobilePhone = default, MobilePhoneActivationStatus? mobilePhoneActivationStatus = default, string sid = default, long ldapQouta = default, string ssoNameId = default, string ssoSessionId = default, DateTime createDate = default, Guid? createdBy = default, bool? spam = default)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.BirthDate = birthDate;
            this.Sex = sex;
            this.Status = status;
            this.ActivationStatus = activationStatus;
            this.TerminatedDate = terminatedDate;
            this.Title = title;
            this.WorkFromDate = workFromDate;
            this.Email = email;
            this.Contacts = contacts;
            this.ContactsList = contactsList;
            this.Location = location;
            this.Notes = notes;
            this.Removed = removed;
            this.LastModified = lastModified;
            this.TenantId = tenantId;
            this.CultureName = cultureName;
            this.MobilePhone = mobilePhone;
            this.MobilePhoneActivationStatus = mobilePhoneActivationStatus;
            this.Sid = sid;
            this.LdapQouta = ldapQouta;
            this.SsoNameId = ssoNameId;
            this.SsoSessionId = ssoSessionId;
            this.CreateDate = createDate;
            this.CreatedBy = createdBy;
            this.Spam = spam;
        }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

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
        /// The user username.
        /// </summary>
        /// <value>The user username.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "userName", EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// The user birthday.
        /// </summary>
        /// <value>The user birthday.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "birthDate", EmitDefaultValue = true)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// The user sex (male or female).
        /// </summary>
        /// <value>The user sex (male or female).</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "sex", EmitDefaultValue = true)]
        public bool? Sex { get; set; }

        /// <summary>
        /// The date and time when the user account was terminated.
        /// </summary>
        /// <value>The date and time when the user account was terminated.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "terminatedDate", EmitDefaultValue = true)]
        public DateTime? TerminatedDate { get; set; }

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
        /// The user registration date.
        /// </summary>
        /// <value>The user registration date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "workFromDate", EmitDefaultValue = true)]
        public DateTime? WorkFromDate { get; set; }

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
        /// The list of user contacts in the string format.
        /// </summary>
        /// <value>The list of user contacts in the string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "contacts", EmitDefaultValue = true)]
        public string Contacts { get; set; }

        /// <summary>
        /// The list of user contacts.
        /// </summary>
        /// <value>The list of user contacts.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "contactsList", EmitDefaultValue = true)]
        public List<string> ContactsList { get; set; }

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
        /// The user notes.
        /// </summary>
        /// <value>The user notes.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Specifies if the user account was removed or not.
        /// </summary>
        /// <value>Specifies if the user account was removed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "removed", EmitDefaultValue = true)]
        public bool Removed { get; set; }

        /// <summary>
        /// The date and time when the user account was last modified.
        /// </summary>
        /// <value>The date and time when the user account was last modified.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// The tenant ID.
        /// </summary>
        /// <value>The tenant ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public int TenantId { get; set; }

        /// <summary>
        /// Specifies if the user is active or not.
        /// </summary>
        /// <value>Specifies if the user is active or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; private set; }

        /// <summary>
        /// Returns false as IsActive should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsActive()
        {
            return false;
        }
        /// <summary>
        /// The user culture code.
        /// </summary>
        /// <value>The user culture code.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "cultureName", EmitDefaultValue = true)]
        public string CultureName { get; set; }

        /// <summary>
        /// The user mobile phone.
        /// </summary>
        /// <value>The user mobile phone.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "mobilePhone", EmitDefaultValue = true)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// The LDAP user identificator.
        /// </summary>
        /// <value>The LDAP user identificator.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "sid", EmitDefaultValue = true)]
        public string Sid { get; set; }

        /// <summary>
        /// The LDAP user quota attribute.
        /// </summary>
        /// <value>The LDAP user quota attribute.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "ldapQouta", EmitDefaultValue = false)]
        public long LdapQouta { get; set; }

        /// <summary>
        /// The SSO SAML user identificator.
        /// </summary>
        /// <value>The SSO SAML user identificator.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "ssoNameId", EmitDefaultValue = true)]
        public string SsoNameId { get; set; }

        /// <summary>
        /// The SSO SAML user session identificator.
        /// </summary>
        /// <value>The SSO SAML user session identificator.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "ssoSessionId", EmitDefaultValue = true)]
        public string SsoSessionId { get; set; }

        /// <summary>
        /// The date and time when the user account was created.
        /// </summary>
        /// <value>The date and time when the user account was created.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "createDate", EmitDefaultValue = false)]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// The ID of the user who created the current user account.
        /// </summary>
        /// <value>The ID of the user who created the current user account.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public Guid? CreatedBy { get; set; }

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
        /// Gets or Sets CheckActivation
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "checkActivation", EmitDefaultValue = true)]
        public bool CheckActivation { get; private set; }

        /// <summary>
        /// Returns false as CheckActivation should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCheckActivation()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  Sex: ").Append(Sex).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ActivationStatus: ").Append(ActivationStatus).Append("\n");
            sb.Append("  TerminatedDate: ").Append(TerminatedDate).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  WorkFromDate: ").Append(WorkFromDate).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  ContactsList: ").Append(ContactsList).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Removed: ").Append(Removed).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  CultureName: ").Append(CultureName).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  MobilePhoneActivationStatus: ").Append(MobilePhoneActivationStatus).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("  LdapQouta: ").Append(LdapQouta).Append("\n");
            sb.Append("  SsoNameId: ").Append(SsoNameId).Append("\n");
            sb.Append("  SsoSessionId: ").Append(SsoSessionId).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Spam: ").Append(Spam).Append("\n");
            sb.Append("  CheckActivation: ").Append(CheckActivation).Append("\n");
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
