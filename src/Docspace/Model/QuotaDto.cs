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
    /// The quota information.
    /// </summary>
    [DataContract(Name = "QuotaDto")]
    public partial class QuotaDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaDto" /> class.
        /// </summary>
        /// <param name="id">The quota ID..</param>
        /// <param name="title">The quota title..</param>
        /// <param name="price">price.</param>
        /// <param name="nonProfit">Specifies if the quota is nonprofit or not..</param>
        /// <param name="free">Specifies if the quota is free or not..</param>
        /// <param name="trial">Specifies if the quota is trial or not..</param>
        /// <param name="features">The list of tenant quota features..</param>
        /// <param name="usersQuota">usersQuota.</param>
        /// <param name="roomsQuota">roomsQuota.</param>
        /// <param name="tenantCustomQuota">tenantCustomQuota.</param>
        /// <param name="dueDate">The due date..</param>
        public QuotaDto(int id = default, string title = default, PriceDto price = default, bool nonProfit = default, bool free = default, bool trial = default, List<TenantQuotaFeatureDto> features = default, TenantEntityQuotaSettings usersQuota = default, TenantEntityQuotaSettings roomsQuota = default, TenantQuotaSettings tenantCustomQuota = default, DateTime? dueDate = default)
        {
            this.Id = id;
            this.Title = title;
            this.Price = price;
            this.NonProfit = nonProfit;
            this.Free = free;
            this.Trial = trial;
            this.Features = features;
            this.UsersQuota = usersQuota;
            this.RoomsQuota = roomsQuota;
            this.TenantCustomQuota = tenantCustomQuota;
            this.DueDate = dueDate;
        }

        /// <summary>
        /// The quota ID.
        /// </summary>
        /// <value>The quota ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The quota title.
        /// </summary>
        /// <value>The quota title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public PriceDto Price { get; set; }

        /// <summary>
        /// Specifies if the quota is nonprofit or not.
        /// </summary>
        /// <value>Specifies if the quota is nonprofit or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "nonProfit", EmitDefaultValue = true)]
        public bool NonProfit { get; set; }

        /// <summary>
        /// Specifies if the quota is free or not.
        /// </summary>
        /// <value>Specifies if the quota is free or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "free", EmitDefaultValue = true)]
        public bool Free { get; set; }

        /// <summary>
        /// Specifies if the quota is trial or not.
        /// </summary>
        /// <value>Specifies if the quota is trial or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "trial", EmitDefaultValue = true)]
        public bool Trial { get; set; }

        /// <summary>
        /// The list of tenant quota features.
        /// </summary>
        /// <value>The list of tenant quota features.</value>
        [DataMember(Name = "features", EmitDefaultValue = true)]
        public List<TenantQuotaFeatureDto> Features { get; set; }

        /// <summary>
        /// Gets or Sets UsersQuota
        /// </summary>
        [DataMember(Name = "usersQuota", EmitDefaultValue = false)]
        public TenantEntityQuotaSettings UsersQuota { get; set; }

        /// <summary>
        /// Gets or Sets RoomsQuota
        /// </summary>
        [DataMember(Name = "roomsQuota", EmitDefaultValue = false)]
        public TenantEntityQuotaSettings RoomsQuota { get; set; }

        /// <summary>
        /// Gets or Sets TenantCustomQuota
        /// </summary>
        [DataMember(Name = "tenantCustomQuota", EmitDefaultValue = false)]
        public TenantQuotaSettings TenantCustomQuota { get; set; }

        /// <summary>
        /// The due date.
        /// </summary>
        /// <value>The due date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "dueDate", EmitDefaultValue = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QuotaDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  NonProfit: ").Append(NonProfit).Append("\n");
            sb.Append("  Free: ").Append(Free).Append("\n");
            sb.Append("  Trial: ").Append(Trial).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  UsersQuota: ").Append(UsersQuota).Append("\n");
            sb.Append("  RoomsQuota: ").Append(RoomsQuota).Append("\n");
            sb.Append("  TenantCustomQuota: ").Append(TenantCustomQuota).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
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
