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
    /// The tenant quota feature parameters.
    /// </summary>
    [DataContract(Name = "TenantQuotaFeatureDto")]
    public partial class TenantQuotaFeatureDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantQuotaFeatureDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the tenant quota feature..</param>
        /// <param name="title">The title of the tenant quota feature..</param>
        /// <param name="image">The image URL of the tenant quota feature..</param>
        /// <param name="value">The value of the tenant quota feature..</param>
        /// <param name="type">The type of the tenant quota feature..</param>
        /// <param name="used">used.</param>
        /// <param name="priceTitle">The price title of the tenant quota feature..</param>
        public TenantQuotaFeatureDto(string id = default, string title = default, string image = default, Object value = default, string type = default, FeatureUsedDto used = default, string priceTitle = default)
        {
            this.Id = id;
            this.Title = title;
            this.Image = image;
            this.Value = value;
            this.Type = type;
            this.Used = used;
            this.PriceTitle = priceTitle;
        }

        /// <summary>
        /// The ID of the tenant quota feature.
        /// </summary>
        /// <value>The ID of the tenant quota feature.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The title of the tenant quota feature.
        /// </summary>
        /// <value>The title of the tenant quota feature.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The image URL of the tenant quota feature.
        /// </summary>
        /// <value>The image URL of the tenant quota feature.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// The value of the tenant quota feature.
        /// </summary>
        /// <value>The value of the tenant quota feature.</value>
        /*
        <example>{&quot;int&quot;:1234,&quot;string&quot;:&quot;some text&quot;,&quot;boolean&quot;:true}</example>
        */
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public Object Value { get; set; }

        /// <summary>
        /// The type of the tenant quota feature.
        /// </summary>
        /// <value>The type of the tenant quota feature.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Used
        /// </summary>
        [DataMember(Name = "used", EmitDefaultValue = false)]
        public FeatureUsedDto Used { get; set; }

        /// <summary>
        /// The price title of the tenant quota feature.
        /// </summary>
        /// <value>The price title of the tenant quota feature.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "priceTitle", EmitDefaultValue = true)]
        public string PriceTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantQuotaFeatureDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
            sb.Append("  PriceTitle: ").Append(PriceTitle).Append("\n");
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
