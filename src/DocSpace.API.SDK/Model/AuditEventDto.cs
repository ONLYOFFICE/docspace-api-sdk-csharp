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
    /// The audit event parameters.
    /// </summary>
    [DataContract(Name = "AuditEventDto")]
    public partial class AuditEventDto : IValidatableObject
    {

        /// <summary>
        /// The specific action that occurred within the audit event.
        /// </summary>
        [DataMember(Name = "actionId", EmitDefaultValue = false)]
        public MessageAction? ActionId { get; set; }

        /// <summary>
        /// The type of action performed in the audit event (e.g., Create, Update, Delete).
        /// </summary>
        [DataMember(Name = "actionType", EmitDefaultValue = false)]
        public ActionType? ActionType { get; set; }

        /// <summary>
        /// The type of product related to the audit event.
        /// </summary>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public ProductType? Product { get; set; }

        /// <summary>
        /// The location where the audit event occurred.
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public LocationType? Location { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEventDto" /> class.
        /// </summary>
        /// <param name="id">The audit event ID..</param>
        /// <param name="date">The audit event date..</param>
        /// <param name="user">The name of the user who triggered the audit event..</param>
        /// <param name="userId">The ID of the user who triggered the audit event..</param>
        /// <param name="action">The audit event action..</param>
        /// <param name="actionId">The specific action that occurred within the audit event..</param>
        /// <param name="ip">The audit event IP..</param>
        /// <param name="country">The audit event country..</param>
        /// <param name="city">The audit event city..</param>
        /// <param name="browser">The audit event browser..</param>
        /// <param name="platform">The audit event platform..</param>
        /// <param name="page">The audit event page..</param>
        /// <param name="actionType">The type of action performed in the audit event (e.g., Create, Update, Delete)..</param>
        /// <param name="product">The type of product related to the audit event..</param>
        /// <param name="location">The location where the audit event occurred..</param>
        /// <param name="target">The list of target objects affected by the audit event (e.g., document ID, user account)..</param>
        /// <param name="entries">The list of audit entry types (e.g., Folder, User, File)..</param>
        /// <param name="context">The audit event context..</param>
        public AuditEventDto(int id = default, DateTime? date = default, string user = default, Guid userId = default, string action = default, MessageAction? actionId = default, string ip = default, string country = default, string city = default, string browser = default, string platform = default, string page = default, ActionType? actionType = default, ProductType? product = default, LocationType? location = default, List<string> target = default, List<EntryType> entries = default, string context = default)
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
            this.Location = location;
            this.Target = target;
            this.Entries = entries;
            this.Context = context;
        }

        /// <summary>
        /// The audit event ID.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The audit event date.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "date", EmitDefaultValue = true)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The name of the user who triggered the audit event.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// The ID of the user who triggered the audit event.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000001</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The audit event action.
        /// </summary>
        /// <example>User logged in</example>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// The audit event IP.
        /// </summary>
        /// <example>192.0.2.1</example>
        [DataMember(Name = "ip", EmitDefaultValue = true)]
        public string Ip { get; set; }

        /// <summary>
        /// The audit event country.
        /// </summary>
        /// <example>United States</example>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// The audit event city.
        /// </summary>
        /// <example>New York</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The audit event browser.
        /// </summary>
        /// <example>Chrome 120.0</example>
        [DataMember(Name = "browser", EmitDefaultValue = true)]
        public string Browser { get; set; }

        /// <summary>
        /// The audit event platform.
        /// </summary>
        /// <example>Windows</example>
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// The audit event page.
        /// </summary>
        /// <example>/rooms/shared</example>
        [DataMember(Name = "page", EmitDefaultValue = true)]
        public string Page { get; set; }

        /// <summary>
        /// The list of target objects affected by the audit event (e.g., document ID, user account).
        /// </summary>
        /// <example>["item1","item2"]</example>
        [DataMember(Name = "target", EmitDefaultValue = true)]
        public List<string> Target { get; set; }

        /// <summary>
        /// The list of audit entry types (e.g., Folder, User, File).
        /// </summary>
        /// <example>["File","Folder"]</example>
        [DataMember(Name = "entries", EmitDefaultValue = true)]
        public List<EntryType> Entries { get; set; }

        /// <summary>
        /// The audit event context.
        /// </summary>
        /// <example>Security settings updated</example>
        [DataMember(Name = "context", EmitDefaultValue = true)]
        public string Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            sb.Append("  Location: ").Append(Location).Append("\n");
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
