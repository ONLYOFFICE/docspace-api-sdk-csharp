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
    /// The active connection item parameters.
    /// </summary>
    [DataContract(Name = "ActiveConnectionsItemDto")]
    public partial class ActiveConnectionsItemDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveConnectionsItemDto" /> class.
        /// </summary>
        /// <param name="id">The active connection ID..</param>
        /// <param name="tenantId">The tenant ID..</param>
        /// <param name="userId">The user ID..</param>
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
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

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
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "userId", EmitDefaultValue = false)]
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
            StringBuilder sb = new StringBuilder();
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
