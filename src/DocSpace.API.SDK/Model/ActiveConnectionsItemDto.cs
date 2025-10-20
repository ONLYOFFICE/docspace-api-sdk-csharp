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
    /// The active connection item parameters.
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
        /// <param name="id">The active connection ID. (required).</param>
        /// <param name="tenantId">The tenant ID. (required).</param>
        /// <param name="userId">The user ID. (required).</param>
        /// <param name="mobile">Specifies if the active connection has a mobile phone or not..</param>
        /// <param name="ip">The IP address of the active connection..</param>
        /// <param name="country">The active connection country..</param>
        /// <param name="city">The active connection city..</param>
        /// <param name="browser">The active connection browser..</param>
        /// <param name="platform">The active connection platform..</param>
        /// <param name="date">date.</param>
        /// <param name="page">The active connection page..</param>
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
        /// The active connection ID.
        /// </summary>
        /// <value>The active connection ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The tenant ID.
        /// </summary>
        /// <value>The tenant ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public int TenantId { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Specifies if the active connection has a mobile phone or not.
        /// </summary>
        /// <value>Specifies if the active connection has a mobile phone or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "mobile", EmitDefaultValue = true)]
        public bool Mobile { get; set; }

        /// <summary>
        /// The IP address of the active connection.
        /// </summary>
        /// <value>The IP address of the active connection.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "ip", EmitDefaultValue = true)]
        public string Ip { get; set; }

        /// <summary>
        /// The active connection country.
        /// </summary>
        /// <value>The active connection country.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// The active connection city.
        /// </summary>
        /// <value>The active connection city.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The active connection browser.
        /// </summary>
        /// <value>The active connection browser.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "browser", EmitDefaultValue = true)]
        public string Browser { get; set; }

        /// <summary>
        /// The active connection platform.
        /// </summary>
        /// <value>The active connection platform.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "platform", EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// The active connection page.
        /// </summary>
        /// <value>The active connection page.</value>
        /*
        <example>some text</example>
        */
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
