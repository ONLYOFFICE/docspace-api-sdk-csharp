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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// The request parameters for handling the authorization service.
    /// </summary>
    [DataContract(Name = "AuthServiceRequestsDto")]
    public partial class AuthServiceRequestsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthServiceRequestsDto" /> class.
        /// </summary>
        /// <param name="name">The name of the authentication service..</param>
        /// <param name="title">The user-friendly display title of the authentication service..</param>
        /// <param name="description">The brief description of the authentication service..</param>
        /// <param name="instruction">The detailed instructions for configuring or using the authentication service..</param>
        /// <param name="canSet">Specifies whether the authentication service can be configured by the user..</param>
        /// <param name="props">The collection of authorization keys associated with the authentication service..</param>
        public AuthServiceRequestsDto(string name = default, string title = default, string description = default, string instruction = default, bool canSet = default, List<AuthKey> props = default)
        {
            this.Name = name;
            this.Title = title;
            this.Description = description;
            this.Instruction = instruction;
            this.CanSet = canSet;
            this.Props = props;
        }

        /// <summary>
        /// The name of the authentication service.
        /// </summary>
        /// <value>The name of the authentication service.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The user-friendly display title of the authentication service.
        /// </summary>
        /// <value>The user-friendly display title of the authentication service.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The brief description of the authentication service.
        /// </summary>
        /// <value>The brief description of the authentication service.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The detailed instructions for configuring or using the authentication service.
        /// </summary>
        /// <value>The detailed instructions for configuring or using the authentication service.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "instruction", EmitDefaultValue = true)]
        public string Instruction { get; set; }

        /// <summary>
        /// Specifies whether the authentication service can be configured by the user.
        /// </summary>
        /// <value>Specifies whether the authentication service can be configured by the user.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canSet", EmitDefaultValue = true)]
        public bool CanSet { get; set; }

        /// <summary>
        /// The collection of authorization keys associated with the authentication service.
        /// </summary>
        /// <value>The collection of authorization keys associated with the authentication service.</value>
        [DataMember(Name = "props", EmitDefaultValue = true)]
        public List<AuthKey> Props { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthServiceRequestsDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
            sb.Append("  CanSet: ").Append(CanSet).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
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
