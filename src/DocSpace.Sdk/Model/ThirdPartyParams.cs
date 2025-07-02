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
using FileParameter = DocSpace.Sdk.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Sdk.Client.OpenAPIDateConverter;

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The third-party account parameters.
    /// </summary>
    [DataContract(Name = "ThirdPartyParams")]
    public partial class ThirdPartyParams : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyParams" /> class.
        /// </summary>
        /// <param name="authData">authData.</param>
        /// <param name="corporate">Specifies if this is a corporate account or not..</param>
        /// <param name="roomsStorage">Specifies if this is a room storage or not..</param>
        /// <param name="customerTitle">The customer title..</param>
        /// <param name="providerId">The provider ID..</param>
        /// <param name="providerKey">The provider key..</param>
        public ThirdPartyParams(AuthData authData = default, bool corporate = default, bool roomsStorage = default, string customerTitle = default, int? providerId = default, string providerKey = default)
        {
            this.AuthData = authData;
            this.Corporate = corporate;
            this.RoomsStorage = roomsStorage;
            this.CustomerTitle = customerTitle;
            this.ProviderId = providerId;
            this.ProviderKey = providerKey;
        }

        /// <summary>
        /// Gets or Sets AuthData
        /// </summary>
        [DataMember(Name = "auth_data", EmitDefaultValue = false)]
        public AuthData AuthData { get; set; }

        /// <summary>
        /// Specifies if this is a corporate account or not.
        /// </summary>
        /// <value>Specifies if this is a corporate account or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "corporate", EmitDefaultValue = true)]
        public bool Corporate { get; set; }

        /// <summary>
        /// Specifies if this is a room storage or not.
        /// </summary>
        /// <value>Specifies if this is a room storage or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "roomsStorage", EmitDefaultValue = true)]
        public bool RoomsStorage { get; set; }

        /// <summary>
        /// The customer title.
        /// </summary>
        /// <value>The customer title.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "customer_title", EmitDefaultValue = true)]
        public string CustomerTitle { get; set; }

        /// <summary>
        /// The provider ID.
        /// </summary>
        /// <value>The provider ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "provider_id", EmitDefaultValue = true)]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The provider key.
        /// </summary>
        /// <value>The provider key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "provider_key", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThirdPartyParams {\n");
            sb.Append("  AuthData: ").Append(AuthData).Append("\n");
            sb.Append("  Corporate: ").Append(Corporate).Append("\n");
            sb.Append("  RoomsStorage: ").Append(RoomsStorage).Append("\n");
            sb.Append("  CustomerTitle: ").Append(CustomerTitle).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProviderKey: ").Append(ProviderKey).Append("\n");
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
