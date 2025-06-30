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
    /// The provider information.
    /// </summary>
    [DataContract(Name = "ProviderDto")]
    public partial class ProviderDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderDto" /> class.
        /// </summary>
        /// <param name="name">The provider name..</param>
        /// <param name="key">The provider key..</param>
        /// <param name="connected">Specifies whether the provider is connected..</param>
        /// <param name="oauth">Specifies if the provider is OAuth..</param>
        /// <param name="redirectUrl">The provider redirect URL..</param>
        /// <param name="requiredConnectionUrl">The required connection URL flag..</param>
        /// <param name="clientId">The provider OAuth client ID..</param>
        public ProviderDto(string name = default, string key = default, bool connected = default, bool oauth = default, string redirectUrl = default, bool requiredConnectionUrl = default, string clientId = default)
        {
            this.Name = name;
            this.Key = key;
            this.Connected = connected;
            this.Oauth = oauth;
            this.RedirectUrl = redirectUrl;
            this.RequiredConnectionUrl = requiredConnectionUrl;
            this.ClientId = clientId;
        }

        /// <summary>
        /// The provider name.
        /// </summary>
        /// <value>The provider name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The provider key.
        /// </summary>
        /// <value>The provider key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Specifies whether the provider is connected.
        /// </summary>
        /// <value>Specifies whether the provider is connected.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "connected", EmitDefaultValue = true)]
        public bool Connected { get; set; }

        /// <summary>
        /// Specifies if the provider is OAuth.
        /// </summary>
        /// <value>Specifies if the provider is OAuth.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "oauth", EmitDefaultValue = true)]
        public bool Oauth { get; set; }

        /// <summary>
        /// The provider redirect URL.
        /// </summary>
        /// <value>The provider redirect URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "redirectUrl", EmitDefaultValue = true)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// The required connection URL flag.
        /// </summary>
        /// <value>The required connection URL flag.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "requiredConnectionUrl", EmitDefaultValue = true)]
        public bool RequiredConnectionUrl { get; set; }

        /// <summary>
        /// The provider OAuth client ID.
        /// </summary>
        /// <value>The provider OAuth client ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "clientId", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProviderDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Connected: ").Append(Connected).Append("\n");
            sb.Append("  Oauth: ").Append(Oauth).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  RequiredConnectionUrl: ").Append(RequiredConnectionUrl).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
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
