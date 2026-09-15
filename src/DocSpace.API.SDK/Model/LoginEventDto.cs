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
    /// One entry of the portal login history: a sign-in, a sign-out or a failed attempt, and where it came from.
    /// </summary>
    [DataContract(Name = "LoginEventDto")]
    public partial class LoginEventDto : IValidatableObject
    {

        /// <summary>
        /// What happened, as the &#x60;action&#x60; filter of this operation spells it: a successful sign-in, a failed one, a  sign-out. Use this rather than parsing &#x60;action&#x60;, which is prose and changes with the portal language.
        /// </summary>
        [DataMember(Name = "actionId", EmitDefaultValue = false)]
        public MessageAction? ActionId { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginEventDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the recorded sign-in. When the entry is a successful sign-in that is still open, this is also  the value &#x60;GET api/2.0/security/activeconnections&#x60; reports as the connection&#39;s &#x60;id&#x60;..</param>
        /// <param name="date">When the attempt was made, in the portal time zone. The &#x60;from&#x60; and &#x60;to&#x60; filters are read as UTC instants,  so the two do not line up on a portal that is not on UTC..</param>
        /// <param name="user">The display name of the account the attempt was made against, taken from the account as it stands now  rather than as it stood at the time. A localised placeholder stands in when there is no account to read,  which is the usual case for a failed attempt on an address nobody owns..</param>
        /// <param name="userId">The ID of that account, which is what the &#x60;userId&#x60; filter of this operation matches on. It is the empty  GUID when the attempt could not be tied to an account..</param>
        /// <param name="login">The login string as it was typed - normally the email address. It is the only field that survives a failed  attempt against an unknown account, which makes it the one to read when &#x60;user&#x60; is a placeholder..</param>
        /// <param name="action">The event as a readable sentence in the portal language. On &#x60;GET api/2.0/security/audit/login/last&#x60; each  substituted value is cut to 50 characters; the filtered operation substitutes them in full..</param>
        /// <param name="actionId">What happened, as the &#x60;action&#x60; filter of this operation spells it: a successful sign-in, a failed one, a  sign-out. Use this rather than parsing &#x60;action&#x60;, which is prose and changes with the portal language..</param>
        /// <param name="ip">The IP address the attempt came from, with the port stripped off..</param>
        /// <param name="country">The English name of the country the IP address is located in, empty when the address cannot be located -  the normal outcome for private and loopback addresses..</param>
        /// <param name="city">The city the IP address is located in, empty under the same conditions as &#x60;country&#x60;..</param>
        /// <param name="browser">The browser and its version as parsed from the user agent of the attempt, empty when the client sent none  that could be parsed..</param>
        /// <param name="platform">The operating system as parsed from the same user agent, empty under the same conditions as &#x60;browser&#x60;..</param>
        /// <param name="page">Where in the portal the attempt was made from: the referrer of the request, or that request&#39;s own path  when it carried no referrer. Long values are cut off at 512 characters..</param>
        public LoginEventDto(int id = default, ApiDateTime date = default, string user = default, Guid userId = default, string login = default, string action = default, MessageAction? actionId = default, string ip = default, string country = default, string city = default, string browser = default, string platform = default, string page = default)
        {
            this.Id = id;
            this.Date = date;
            this.User = user;
            this.UserId = userId;
            this.Login = login;
            this.Action = action;
            this.ActionId = actionId;
            this.Ip = ip;
            this.Country = country;
            this.City = city;
            this.Browser = browser;
            this.Platform = platform;
            this.Page = page;
        }

        /// <summary>
        /// The ID of the recorded sign-in. When the entry is a successful sign-in that is still open, this is also  the value &#x60;GET api/2.0/security/activeconnections&#x60; reports as the connection&#39;s &#x60;id&#x60;.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// When the attempt was made, in the portal time zone. The &#x60;from&#x60; and &#x60;to&#x60; filters are read as UTC instants,  so the two do not line up on a portal that is not on UTC.
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// The display name of the account the attempt was made against, taken from the account as it stands now  rather than as it stood at the time. A localised placeholder stands in when there is no account to read,  which is the usual case for a failed attempt on an address nobody owns.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// The ID of that account, which is what the &#x60;userId&#x60; filter of this operation matches on. It is the empty  GUID when the attempt could not be tied to an account.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000001</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The login string as it was typed - normally the email address. It is the only field that survives a failed  attempt against an unknown account, which makes it the one to read when &#x60;user&#x60; is a placeholder.
        /// </summary>
        /// <example>user@example.com</example>
        [DataMember(Name = "login", EmitDefaultValue = true)]
        public string Login { get; set; }

        /// <summary>
        /// The event as a readable sentence in the portal language. On &#x60;GET api/2.0/security/audit/login/last&#x60; each  substituted value is cut to 50 characters; the filtered operation substitutes them in full.
        /// </summary>
        /// <example>User logged in</example>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// The IP address the attempt came from, with the port stripped off.
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
        /// The browser and its version as parsed from the user agent of the attempt, empty when the client sent none  that could be parsed.
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
        /// Where in the portal the attempt was made from: the referrer of the request, or that request&#39;s own path  when it carried no referrer. Long values are cut off at 512 characters.
        /// </summary>
        /// <example>/login</example>
        [DataMember(Name = "page", EmitDefaultValue = true)]
        public string Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginEventDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionId: ").Append(ActionId).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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
