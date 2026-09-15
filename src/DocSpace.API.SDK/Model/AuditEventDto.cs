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
    /// One entry of the portal audit trail: who changed what, from where, and where it belongs in the product.
    /// </summary>
    [DataContract(Name = "AuditEventDto")]
    public partial class AuditEventDto : IValidatableObject
    {

        /// <summary>
        /// The action itself, as the &#x60;action&#x60; filter of this operation spells it and as  &#x60;GET api/2.0/security/audit/mappers&#x60; lists it under &#x60;messageAction&#x60;. Use this rather than parsing &#x60;action&#x60;,  which is prose and changes with the portal language.
        /// </summary>
        [DataMember(Name = "actionId", EmitDefaultValue = false)]
        public MessageAction? ActionId { get; set; }

        /// <summary>
        /// The kind of change the action stands for, as the &#x60;actionType&#x60; filter of this operation spells it. It is  derived from &#x60;actionId&#x60;, not stored per entry, so it is the same on every entry of one action.
        /// </summary>
        [DataMember(Name = "actionType", EmitDefaultValue = false)]
        public ActionType? ActionType { get; set; }

        /// <summary>
        /// The product the action belongs to. It cannot be filtered on here; the tree that groups actions by product  is &#x60;GET api/2.0/security/audit/mappers&#x60;.
        /// </summary>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public ProductType? Product { get; set; }

        /// <summary>
        /// The location inside that product, as the &#x60;moduleType&#x60; filter of this operation spells it. It is also  derived from &#x60;actionId&#x60; rather than stored per entry.
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public LocationType? Location { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEventDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the recorded entry. Nothing accepts it as an argument - no operation fetches a single audit event  - so it serves only to tell two otherwise identical entries apart..</param>
        /// <param name="date">When the action happened, in the portal time zone. The &#x60;from&#x60; and &#x60;to&#x60; filters are read as UTC instants, so  the two do not line up on a portal that is not on UTC..</param>
        /// <param name="user">The display name of the user who acted, taken from the account as it stands now rather than as it stood  when the entry was written. A localised placeholder stands in when there is no account to read: a portal  background job, an anonymous guest, or a user who has since been deleted..</param>
        /// <param name="userId">The ID of the user who acted, which is what the &#x60;userId&#x60; filter of this operation matches on. It stays  readable after the account is deleted, which is when &#x60;user&#x60; falls back to a placeholder..</param>
        /// <param name="action">The whole event as a readable sentence in the portal language, with the names of the objects involved  substituted into it. On the two &#x60;audit/.../last&#x60; operations each substituted value is cut to 50 characters;  the filtered operations substitute them in full. It is empty when the build has no wording for the action..</param>
        /// <param name="actionId">The action itself, as the &#x60;action&#x60; filter of this operation spells it and as  &#x60;GET api/2.0/security/audit/mappers&#x60; lists it under &#x60;messageAction&#x60;. Use this rather than parsing &#x60;action&#x60;,  which is prose and changes with the portal language..</param>
        /// <param name="ip">The IP address the request came from, with the port stripped off. It is empty for an action a portal  background job performed, which has no request behind it..</param>
        /// <param name="country">The English name of the country the IP address is located in, empty when the address cannot be located -  the normal outcome for private and loopback addresses..</param>
        /// <param name="city">The city the IP address is located in, empty under the same conditions as &#x60;country&#x60;..</param>
        /// <param name="browser">The browser and its version as parsed from the user agent of the request, empty when the client sent none  that could be parsed or when no request was involved..</param>
        /// <param name="platform">The operating system as parsed from the same user agent, empty under the same conditions as &#x60;browser&#x60;..</param>
        /// <param name="page">Where in the portal the action was made from: the referrer of the request, or that request&#39;s own path when  it carried no referrer. Long values are cut off at 512 characters..</param>
        /// <param name="actionType">The kind of change the action stands for, as the &#x60;actionType&#x60; filter of this operation spells it. It is  derived from &#x60;actionId&#x60;, not stored per entry, so it is the same on every entry of one action..</param>
        /// <param name="product">The product the action belongs to. It cannot be filtered on here; the tree that groups actions by product  is &#x60;GET api/2.0/security/audit/mappers&#x60;..</param>
        /// <param name="location">The location inside that product, as the &#x60;moduleType&#x60; filter of this operation spells it. It is also  derived from &#x60;actionId&#x60; rather than stored per entry..</param>
        /// <param name="target">The objects the action was applied to, as the trail recorded them - a title, an account, an ID - one string  each. It is empty for an action that targets nothing, such as a settings change, and the &#x60;target&#x60; filter of  this operation matches one of these values in full..</param>
        /// <param name="entries">The kinds of object the action applies to, holding at most two entries and none at all for an action that  targets nothing. Only the first of them can be filtered on, through &#x60;entryType&#x60;..</param>
        /// <param name="context">Where the action took place, spelled out in the portal language rather than as a code: for a Documents  event the room or the root folder it happened in, and for anything else the name of the module. Nothing  filters on it..</param>
        public AuditEventDto(int id = default, ApiDateTime date = default, string user = default, Guid userId = default, string action = default, MessageAction? actionId = default, string ip = default, string country = default, string city = default, string browser = default, string platform = default, string page = default, ActionType? actionType = default, ProductType? product = default, LocationType? location = default, List<string> target = default, List<EntryType> entries = default, string context = default)
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
        /// The ID of the recorded entry. Nothing accepts it as an argument - no operation fetches a single audit event  - so it serves only to tell two otherwise identical entries apart.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// When the action happened, in the portal time zone. The &#x60;from&#x60; and &#x60;to&#x60; filters are read as UTC instants, so  the two do not line up on a portal that is not on UTC.
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// The display name of the user who acted, taken from the account as it stands now rather than as it stood  when the entry was written. A localised placeholder stands in when there is no account to read: a portal  background job, an anonymous guest, or a user who has since been deleted.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// The ID of the user who acted, which is what the &#x60;userId&#x60; filter of this operation matches on. It stays  readable after the account is deleted, which is when &#x60;user&#x60; falls back to a placeholder.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000001</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The whole event as a readable sentence in the portal language, with the names of the objects involved  substituted into it. On the two &#x60;audit/.../last&#x60; operations each substituted value is cut to 50 characters;  the filtered operations substitute them in full. It is empty when the build has no wording for the action.
        /// </summary>
        /// <example>User logged in</example>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// The IP address the request came from, with the port stripped off. It is empty for an action a portal  background job performed, which has no request behind it.
        /// </summary>
        /// <example>192.0.2.1</example>
        [DataMember(Name = "ip", EmitDefaultValue = true)]
        public string Ip { get; set; }

        /// <summary>
        /// The English name of the country the IP address is located in, empty when the address cannot be located -  the normal outcome for private and loopback addresses.
        /// </summary>
        /// <example>United States</example>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// The city the IP address is located in, empty under the same conditions as &#x60;country&#x60;.
        /// </summary>
        /// <example>New York</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The browser and its version as parsed from the user agent of the request, empty when the client sent none  that could be parsed or when no request was involved.
        /// </summary>
        /// <example>Chrome 120.0</example>
        [DataMember(Name = "browser", EmitDefaultValue = true)]
        public string Browser { get; set; }

        /// <summary>
        /// The operating system as parsed from the same user agent, empty under the same conditions as &#x60;browser&#x60;.
        /// </summary>
        /// <example>Windows</example>
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Where in the portal the action was made from: the referrer of the request, or that request&#39;s own path when  it carried no referrer. Long values are cut off at 512 characters.
        /// </summary>
        /// <example>/rooms/shared</example>
        [DataMember(Name = "page", EmitDefaultValue = true)]
        public string Page { get; set; }

        /// <summary>
        /// The objects the action was applied to, as the trail recorded them - a title, an account, an ID - one string  each. It is empty for an action that targets nothing, such as a settings change, and the &#x60;target&#x60; filter of  this operation matches one of these values in full.
        /// </summary>
        /// <example>["item1","item2"]</example>
        [DataMember(Name = "target", EmitDefaultValue = true)]
        public List<string> Target { get; set; }

        /// <summary>
        /// The kinds of object the action applies to, holding at most two entries and none at all for an action that  targets nothing. Only the first of them can be filtered on, through &#x60;entryType&#x60;.
        /// </summary>
        /// <example>["File","Folder"]</example>
        [DataMember(Name = "entries", EmitDefaultValue = true)]
        public List<EntryType> Entries { get; set; }

        /// <summary>
        /// Where the action took place, spelled out in the portal language rather than as a code: for a Documents  event the room or the root folder it happened in, and for anything else the name of the module. Nothing  filters on it.
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
