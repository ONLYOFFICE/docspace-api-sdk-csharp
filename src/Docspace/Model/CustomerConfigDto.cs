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
    /// The customer config parameters.
    /// </summary>
    [DataContract(Name = "CustomerConfigDto")]
    public partial class CustomerConfigDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerConfigDto" /> class.
        /// </summary>
        /// <param name="address">The address of the customer configuration..</param>
        /// <param name="logo">The logo of the customer configuration..</param>
        /// <param name="logoDark">The dark logo of the customer configuration..</param>
        /// <param name="mail">The mail address of the customer configuration..</param>
        /// <param name="name">The name of the customer configuration..</param>
        /// <param name="www">The site web address of the customer configuration..</param>
        public CustomerConfigDto(string address = default, string logo = default, string logoDark = default, string mail = default, string name = default, string www = default)
        {
            this.Address = address;
            this.Logo = logo;
            this.LogoDark = logoDark;
            this.Mail = mail;
            this.Name = name;
            this.Www = www;
        }

        /// <summary>
        /// The address of the customer configuration.
        /// </summary>
        /// <value>The address of the customer configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The logo of the customer configuration.
        /// </summary>
        /// <value>The logo of the customer configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "logo", EmitDefaultValue = true)]
        public string Logo { get; set; }

        /// <summary>
        /// The dark logo of the customer configuration.
        /// </summary>
        /// <value>The dark logo of the customer configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "logoDark", EmitDefaultValue = true)]
        public string LogoDark { get; set; }

        /// <summary>
        /// The mail address of the customer configuration.
        /// </summary>
        /// <value>The mail address of the customer configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "mail", EmitDefaultValue = true)]
        public string Mail { get; set; }

        /// <summary>
        /// The name of the customer configuration.
        /// </summary>
        /// <value>The name of the customer configuration.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The site web address of the customer configuration.
        /// </summary>
        /// <value>The site web address of the customer configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "www", EmitDefaultValue = true)]
        public string Www { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerConfigDto {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  LogoDark: ").Append(LogoDark).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Www: ").Append(Www).Append("\n");
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
