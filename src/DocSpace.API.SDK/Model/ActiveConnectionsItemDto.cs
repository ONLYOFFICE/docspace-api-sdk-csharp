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
    /// One open connection of a user: where the sign-in behind it came from, and the ID it can be closed by.
    /// </summary>
    [DataContract(Name = "ActiveConnectionsItemDto")]
    public partial class ActiveConnectionsItemDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveConnectionsItemDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActiveConnectionsItemDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveConnectionsItemDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the sign-in this connection was opened by. Pass it as &#x60;loginEventId&#x60; to  &#x60;PUT api/2.0/security/activeconnections/logout/{loginEventId}&#x60; to end this one connection; the item whose  value equals &#x60;loginEvent&#x60; is the connection the current request uses. (required).</param>
        /// <param name="tenantId">The portal the sign-in was made on. The operation never crosses portals, so it is the current one on every  item. (required).</param>
        /// <param name="userId">The user the connection belongs to, which is the calling user on every item - the operation cannot report  anyone else&#39;s connections. (required).</param>
        /// <param name="mobile">Whether the sign-in came from a mobile client. No mobile marker is stored with a connection, so the value  is &#x60;false&#x60; on every item and tells a caller nothing about the device..</param>
        /// <param name="ip">The IP address the sign-in came from, with the port stripped off. On the item that matches &#x60;loginEvent&#x60; it  is taken from the address the current request arrives from instead of the one stored at sign-in..</param>
        /// <param name="country">The English name of the country the IP address is located in. It is empty when the address cannot be  located, which is the normal outcome for private and loopback addresses..</param>
        /// <param name="city">The city the IP address is located in, empty under the same conditions as &#x60;country&#x60;..</param>
        /// <param name="browser">The browser and its version as parsed from the user agent of the sign-in, empty when the client sent no  recognisable one. It is refreshed from the current request on the item that matches &#x60;loginEvent&#x60;..</param>
        /// <param name="platform">The operating system as parsed from the user agent of the sign-in, refreshed and left empty under the same  conditions as &#x60;browser&#x60;..</param>
        /// <param name="date">When the sign-in happened, in the portal time zone rather than in UTC..</param>
        /// <param name="page">Where in the portal the sign-in was made from: the referrer of the request that created it, or that  request&#39;s own path when it carried no referrer. Long values are cut off at 512 characters..</param>
        public ActiveConnectionsItemDto(int id = default, int tenantId = default, Guid userId = default, bool mobile = default, string ip = default, string country = default, string city = default, string browser = default, string platform = default, ApiDateTime date = default, string page = default)
        {
            this.Id = id;
            this.TenantId = tenantId;
            this.UserId = userId;
            this.Mobile = mobile;
            this.Ip = ip;
            this.Country = country;
            this.City = city;
            this.Browser = browser;
            this.Platform = platform;
            this.Date = date;
            this.Page = page;
        }

        /// <summary>
        /// The ID of the sign-in this connection was opened by. Pass it as &#x60;loginEventId&#x60; to  &#x60;PUT api/2.0/security/activeconnections/logout/{loginEventId}&#x60; to end this one connection; the item whose  value equals &#x60;loginEvent&#x60; is the connection the current request uses.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The portal the sign-in was made on. The operation never crosses portals, so it is the current one on every  item.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public int TenantId { get; set; }

        /// <summary>
        /// The user the connection belongs to, which is the calling user on every item - the operation cannot report  anyone else&#39;s connections.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Whether the sign-in came from a mobile client. No mobile marker is stored with a connection, so the value  is &#x60;false&#x60; on every item and tells a caller nothing about the device.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "mobile", EmitDefaultValue = true)]
        public bool Mobile { get; set; }

        /// <summary>
        /// The IP address the sign-in came from, with the port stripped off. On the item that matches &#x60;loginEvent&#x60; it  is taken from the address the current request arrives from instead of the one stored at sign-in.
        /// </summary>
        /// <example>192.0.2.1</example>
        [DataMember(Name = "ip", EmitDefaultValue = true)]
        public string Ip { get; set; }

        /// <summary>
        /// The English name of the country the IP address is located in. It is empty when the address cannot be  located, which is the normal outcome for private and loopback addresses.
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
        /// The browser and its version as parsed from the user agent of the sign-in, empty when the client sent no  recognisable one. It is refreshed from the current request on the item that matches &#x60;loginEvent&#x60;.
        /// </summary>
        /// <example>Chrome 120.0</example>
        [DataMember(Name = "browser", EmitDefaultValue = true)]
        public string Browser { get; set; }

        /// <summary>
        /// The operating system as parsed from the user agent of the sign-in, refreshed and left empty under the same  conditions as &#x60;browser&#x60;.
        /// </summary>
        /// <example>Windows</example>
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// When the sign-in happened, in the portal time zone rather than in UTC.
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// Where in the portal the sign-in was made from: the referrer of the request that created it, or that  request&#39;s own path when it carried no referrer. Long values are cut off at 512 characters.
        /// </summary>
        /// <example>/rooms/shared</example>
        [DataMember(Name = "page", EmitDefaultValue = true)]
        public string Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiveConnectionsItemDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
