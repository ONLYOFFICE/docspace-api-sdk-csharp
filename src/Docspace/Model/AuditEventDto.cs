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
    /// The audit event parameters.
    /// </summary>
    [DataContract(Name = "AuditEventDto")]
    public partial class AuditEventDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ActionId
        /// </summary>
        [DataMember(Name = "actionId", EmitDefaultValue = false)]
        public MessageAction? ActionId { get; set; }

        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name = "actionType", EmitDefaultValue = false)]
        public ActionType? ActionType { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public ProductType? Product { get; set; }

        /// <summary>
        /// Gets or Sets Module
        /// </summary>
        [DataMember(Name = "module", EmitDefaultValue = false)]
        public ModuleType? Module { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEventDto" /> class.
        /// </summary>
        /// <param name="id">The audit event ID..</param>
        /// <param name="date">date.</param>
        /// <param name="user">The name of the user who triggered the audit event..</param>
        /// <param name="userId">The ID of the user who triggered the audit event..</param>
        /// <param name="action">The audit event action..</param>
        /// <param name="actionId">actionId.</param>
        /// <param name="ip">The audit event IP..</param>
        /// <param name="country">The audit event country..</param>
        /// <param name="city">The audit event city..</param>
        /// <param name="browser">The audit event browser..</param>
        /// <param name="platform">The audit event platform..</param>
        /// <param name="page">The audit event page..</param>
        /// <param name="actionType">actionType.</param>
        /// <param name="product">product.</param>
        /// <param name="module">module.</param>
        /// <param name="target">The list of target objects affected by the audit event (e.g., document ID, user account)..</param>
        /// <param name="entries">The list of audit entry types (e.g., Folder, User, File)..</param>
        /// <param name="context">The audit event context..</param>
        public AuditEventDto(int id = default, ApiDateTime date = default, string user = default, Guid userId = default, string action = default, MessageAction? actionId = default, string ip = default, string country = default, string city = default, string browser = default, string platform = default, string page = default, ActionType? actionType = default, ProductType? product = default, ModuleType? module = default, List<string> target = default, List<EntryType> entries = default, string context = default)
        {
            this.Id = id;
            this.Date = date;
            this.User = user;
            this.UserId = userId;
            this.Action = action;
            this.ActionId = actionId;
            this.Ip = ip;
            this.Country = country;
            this.City = city;
            this.Browser = browser;
            this.Platform = platform;
            this.Page = page;
            this.ActionType = actionType;
            this.Product = product;
            this.Module = module;
            this.Target = target;
            this.Entries = entries;
            this.Context = context;
        }

        /// <summary>
        /// The audit event ID.
        /// </summary>
        /// <value>The audit event ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// The name of the user who triggered the audit event.
        /// </summary>
        /// <value>The name of the user who triggered the audit event.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// The ID of the user who triggered the audit event.
        /// </summary>
        /// <value>The ID of the user who triggered the audit event.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The audit event action.
        /// </summary>
        /// <value>The audit event action.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// The audit event IP.
        /// </summary>
        /// <value>The audit event IP.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "ip", EmitDefaultValue = true)]
        public string Ip { get; set; }

        /// <summary>
        /// The audit event country.
        /// </summary>
        /// <value>The audit event country.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// The audit event city.
        /// </summary>
        /// <value>The audit event city.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The audit event browser.
        /// </summary>
        /// <value>The audit event browser.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "browser", EmitDefaultValue = true)]
        public string Browser { get; set; }

        /// <summary>
        /// The audit event platform.
        /// </summary>
        /// <value>The audit event platform.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// The audit event page.
        /// </summary>
        /// <value>The audit event page.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "page", EmitDefaultValue = true)]
        public string Page { get; set; }

        /// <summary>
        /// The list of target objects affected by the audit event (e.g., document ID, user account).
        /// </summary>
        /// <value>The list of target objects affected by the audit event (e.g., document ID, user account).</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "target", EmitDefaultValue = true)]
        public List<string> Target { get; set; }

        /// <summary>
        /// The list of audit entry types (e.g., Folder, User, File).
        /// </summary>
        /// <value>The list of audit entry types (e.g., Folder, User, File).</value>
        [DataMember(Name = "entries", EmitDefaultValue = true)]
        public List<EntryType> Entries { get; set; }

        /// <summary>
        /// The audit event context.
        /// </summary>
        /// <value>The audit event context.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "context", EmitDefaultValue = true)]
        public string Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuditEventDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Entries: ").Append(Entries).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
