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
    /// An item in the ordering request with its entry type and ID.
    /// </summary>
    [DataContract(Name = "OrdersItemRequestDtoInteger")]
    public partial class OrdersItemRequestDtoInteger : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EntryType
        /// </summary>
        [DataMember(Name = "entryType", EmitDefaultValue = false)]
        public FileEntryType? EntryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersItemRequestDtoInteger" /> class.
        /// </summary>
        /// <param name="entryId">The entry unique identifier (file or folder)..</param>
        /// <param name="entryType">entryType.</param>
        /// <param name="order">The order value..</param>
        public OrdersItemRequestDtoInteger(int entryId = default, FileEntryType? entryType = default, int order = default)
        {
            this.EntryId = entryId;
            this.EntryType = entryType;
            this.Order = order;
        }

        /// <summary>
        /// The entry unique identifier (file or folder).
        /// </summary>
        /// <value>The entry unique identifier (file or folder).</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "entryId", EmitDefaultValue = false)]
        public int EntryId { get; set; }

        /// <summary>
        /// The order value.
        /// </summary>
        /// <value>The order value.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrdersItemRequestDtoInteger {\n");
            sb.Append("  EntryId: ").Append(EntryId).Append("\n");
            sb.Append("  EntryType: ").Append(EntryType).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            // Order (int) maximum
            if (this.Order > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Order, must be a value less than or equal to 2147483647.", new [] { "Order" });
            }

            // Order (int) minimum
            if (this.Order < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Order, must be a value greater than or equal to 1.", new [] { "Order" });
            }

            yield break;
        }
    }


}
