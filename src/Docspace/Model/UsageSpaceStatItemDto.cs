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
    /// The parameters of the usage space statistics item.
    /// </summary>
    [DataContract(Name = "UsageSpaceStatItemDto")]
    public partial class UsageSpaceStatItemDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSpaceStatItemDto" /> class.
        /// </summary>
        /// <param name="name">The item name..</param>
        /// <param name="icon">The item icon path..</param>
        /// <param name="disabled">Specifies if the item is disabled or not..</param>
        /// <param name="size">The item used space..</param>
        /// <param name="url">The item URL..</param>
        public UsageSpaceStatItemDto(string name = default, string icon = default, bool disabled = default, string size = default, string url = default)
        {
            this.Name = name;
            this.Icon = icon;
            this.Disabled = disabled;
            this.Size = size;
            this.Url = url;
        }

        /// <summary>
        /// The item name.
        /// </summary>
        /// <value>The item name.</value>
        /*
        <example>Item name</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The item icon path.
        /// </summary>
        /// <value>The item icon path.</value>
        /*
        <example>Item icon path</example>
        */
        [DataMember(Name = "icon", EmitDefaultValue = true)]
        public string Icon { get; set; }

        /// <summary>
        /// Specifies if the item is disabled or not.
        /// </summary>
        /// <value>Specifies if the item is disabled or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool Disabled { get; set; }

        /// <summary>
        /// The item used space.
        /// </summary>
        /// <value>The item used space.</value>
        /*
        <example>0 Byte</example>
        */
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public string Size { get; set; }

        /// <summary>
        /// The item URL.
        /// </summary>
        /// <value>The item URL.</value>
        /*
        <example>Item url</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UsageSpaceStatItemDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
