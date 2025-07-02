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
    /// The room data lifetime information.
    /// </summary>
    [DataContract(Name = "RoomDataLifetimeDto")]
    public partial class RoomDataLifetimeDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public RoomDataLifetimePeriod? Period { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomDataLifetimeDto" /> class.
        /// </summary>
        /// <param name="deletePermanently">Specifies whether to permanently delete the room data or not..</param>
        /// <param name="period">period.</param>
        /// <param name="value">Specifies the time period value of the room data lifetime..</param>
        /// <param name="enabled">Specifies whether the room data lifetime setting is enabled or not..</param>
        public RoomDataLifetimeDto(bool deletePermanently = default, RoomDataLifetimePeriod? period = default, int? value = default, bool? enabled = default)
        {
            this.DeletePermanently = deletePermanently;
            this.Period = period;
            this.Value = value;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Specifies whether to permanently delete the room data or not.
        /// </summary>
        /// <value>Specifies whether to permanently delete the room data or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "deletePermanently", EmitDefaultValue = true)]
        public bool DeletePermanently { get; set; }

        /// <summary>
        /// Specifies the time period value of the room data lifetime.
        /// </summary>
        /// <value>Specifies the time period value of the room data lifetime.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public int? Value { get; set; }

        /// <summary>
        /// Specifies whether the room data lifetime setting is enabled or not.
        /// </summary>
        /// <value>Specifies whether the room data lifetime setting is enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoomDataLifetimeDto {\n");
            sb.Append("  DeletePermanently: ").Append(DeletePermanently).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            // Value (int?) maximum
            if (this.Value > (int?)999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must be a value less than or equal to 999.", new [] { "Value" });
            }

            // Value (int?) minimum
            if (this.Value < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must be a value greater than or equal to 1.", new [] { "Value" });
            }

            yield break;
        }
    }


}
