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
    /// The login event parameters.
    /// </summary>
    [DataContract(Name = "LoginEventDto")]
    public partial class LoginEventDto : IValidatableObject
    {

        /// <summary>
        /// The login-related action to filter events by.
        /// </summary>
        [DataMember(Name = "actionId", EmitDefaultValue = false)]
        public MessageAction? ActionId { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginEventDto" /> class.
        /// </summary>
        /// <param name="id">The login event ID..</param>
        /// <param name="date">The login event date..</param>
        /// <param name="user">The user name of the login event..</param>
        /// <param name="userId">The user ID of the login event..</param>
        /// <param name="login">The user login of the login event..</param>
        /// <param name="action">The login event action..</param>
        /// <param name="actionId">The login-related action to filter events by..</param>
        /// <param name="ip">The login event IP..</param>
        /// <param name="country">The login event country..</param>
        /// <param name="city">The login event city..</param>
        /// <param name="browser">The login event browser..</param>
        /// <param name="platform">The login event platform..</param>
        /// <param name="page">The login event page..</param>
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
        /// The login event ID.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The login event date.
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// The user name of the login event.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// The user ID of the login event.
        /// </summary>
        /// <example>{}</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The user login of the login event.
        /// </summary>
        /// <example>user@example.com</example>
        [DataMember(Name = "login", EmitDefaultValue = true)]
        public string Login { get; set; }

        /// <summary>
        /// The login event action.
        /// </summary>
        /// <example>User logged in</example>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// The login event IP.
        /// </summary>
        /// <example>192.0.2.1</example>
        [DataMember(Name = "ip", EmitDefaultValue = true)]
        public string Ip { get; set; }

        /// <summary>
        /// The login event country.
        /// </summary>
        /// <example>United States</example>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// The login event city.
        /// </summary>
        /// <example>New York</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The login event browser.
        /// </summary>
        /// <example>Chrome 120.0</example>
        [DataMember(Name = "browser", EmitDefaultValue = true)]
        public string Browser { get; set; }

        /// <summary>
        /// The login event platform.
        /// </summary>
        /// <example>Windows</example>
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// The login event page.
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
