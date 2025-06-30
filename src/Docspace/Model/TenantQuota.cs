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
    /// The current tenant quota.
    /// </summary>
    [DataContract(Name = "TenantQuota")]
    public partial class TenantQuota : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantQuota" /> class.
        /// </summary>
        /// <param name="tenantId">The tenant ID..</param>
        /// <param name="name">The tenant name..</param>
        /// <param name="price">The tenant price..</param>
        /// <param name="priceCurrencySymbol">The tenant price currency symbol..</param>
        /// <param name="priceISOCurrencySymbol">The tenant price three-character ISO 4217 currency symbol..</param>
        /// <param name="productId">The tenant product ID..</param>
        /// <param name="visible">Specifies if the tenant quota is visible or not..</param>
        /// <param name="wallet">Specifies if the tenant quota applies to the wallet or not.</param>
        /// <param name="dueDate">The quota due date..</param>
        /// <param name="features">The tenant quota features..</param>
        /// <param name="maxFileSize">The tenant maximum file size..</param>
        /// <param name="maxTotalSize">The tenant maximum total size..</param>
        /// <param name="countUser">The number of portal users..</param>
        /// <param name="countRoomAdmin">The number of portal room administrators..</param>
        /// <param name="usersInRoom">The number of room users..</param>
        /// <param name="countRoom">The number of rooms..</param>
        /// <param name="nonProfit">Specifies if the tenant quota is nonprofit or not..</param>
        /// <param name="trial">Specifies if the tenant quota is trial or not..</param>
        /// <param name="free">Specifies if the tenant quota is free or not..</param>
        /// <param name="update">Specifies if the tenant quota is updated or not..</param>
        /// <param name="audit">Specifies if the audit trail is available or not..</param>
        /// <param name="docsEdition">Specifies if ONLYOFFICE Docs is included in the tenant quota or not..</param>
        /// <param name="ldap">Specifies if the LDAP settings are available or not..</param>
        /// <param name="sso">Specifies if the SSO settings are available or not..</param>
        /// <param name="statistic">Specifies if the statistics settings are available or not..</param>
        /// <param name="branding">Specifies if the branding settings are available or not..</param>
        /// <param name="customization">Specifies if the customization settings are available or not..</param>
        /// <param name="lifetime">Specifies if the license has the lifetime settings or not..</param>
        /// <param name="custom">Specifies if the custom domain URL is available or not..</param>
        /// <param name="autoBackupRestore">Specifies if the automatic backup option is enabled or not..</param>
        /// <param name="oauth">Specifies if Oauth is available or not..</param>
        /// <param name="contentSearch">Specifies if the content search is available or not..</param>
        /// <param name="thirdParty">Specifies if the third-party accounts linking is available or not..</param>
        /// <param name="year">Specifies if the tenant quota is yearly subscription or not..</param>
        public TenantQuota(int tenantId = default, string name = default, double price = default, string priceCurrencySymbol = default, string priceISOCurrencySymbol = default, string productId = default, bool visible = default, bool wallet = default, DateTime? dueDate = default, string features = default, long maxFileSize = default, long maxTotalSize = default, int countUser = default, int countRoomAdmin = default, int usersInRoom = default, int countRoom = default, bool nonProfit = default, bool trial = default, bool free = default, bool update = default, bool audit = default, bool docsEdition = default, bool ldap = default, bool sso = default, bool statistic = default, bool branding = default, bool customization = default, bool lifetime = default, bool custom = default, bool autoBackupRestore = default, bool oauth = default, bool contentSearch = default, bool thirdParty = default, bool year = default)
        {
            this.TenantId = tenantId;
            this.Name = name;
            this.Price = price;
            this.PriceCurrencySymbol = priceCurrencySymbol;
            this.PriceISOCurrencySymbol = priceISOCurrencySymbol;
            this.ProductId = productId;
            this.Visible = visible;
            this.Wallet = wallet;
            this.DueDate = dueDate;
            this.Features = features;
            this.MaxFileSize = maxFileSize;
            this.MaxTotalSize = maxTotalSize;
            this.CountUser = countUser;
            this.CountRoomAdmin = countRoomAdmin;
            this.UsersInRoom = usersInRoom;
            this.CountRoom = countRoom;
            this.NonProfit = nonProfit;
            this.Trial = trial;
            this.Free = free;
            this.Update = update;
            this.Audit = audit;
            this.DocsEdition = docsEdition;
            this.Ldap = ldap;
            this.Sso = sso;
            this.Statistic = statistic;
            this.Branding = branding;
            this.Customization = customization;
            this.Lifetime = lifetime;
            this.Custom = custom;
            this.AutoBackupRestore = autoBackupRestore;
            this.Oauth = oauth;
            this.ContentSearch = contentSearch;
            this.ThirdParty = thirdParty;
            this.Year = year;
        }

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
        /// The tenant name.
        /// </summary>
        /// <value>The tenant name.</value>
        /*
        <example>Default</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The tenant price.
        /// </summary>
        /// <value>The tenant price.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public double Price { get; set; }

        /// <summary>
        /// The tenant price currency symbol.
        /// </summary>
        /// <value>The tenant price currency symbol.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "priceCurrencySymbol", EmitDefaultValue = true)]
        public string PriceCurrencySymbol { get; set; }

        /// <summary>
        /// The tenant price three-character ISO 4217 currency symbol.
        /// </summary>
        /// <value>The tenant price three-character ISO 4217 currency symbol.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "priceISOCurrencySymbol", EmitDefaultValue = true)]
        public string PriceISOCurrencySymbol { get; set; }

        /// <summary>
        /// The tenant product ID.
        /// </summary>
        /// <value>The tenant product ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "productId", EmitDefaultValue = true)]
        public string ProductId { get; set; }

        /// <summary>
        /// Specifies if the tenant quota is visible or not.
        /// </summary>
        /// <value>Specifies if the tenant quota is visible or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "visible", EmitDefaultValue = true)]
        public bool Visible { get; set; }

        /// <summary>
        /// Specifies if the tenant quota applies to the wallet or not
        /// </summary>
        /// <value>Specifies if the tenant quota applies to the wallet or not</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "wallet", EmitDefaultValue = true)]
        public bool Wallet { get; set; }

        /// <summary>
        /// The quota due date.
        /// </summary>
        /// <value>The quota due date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "dueDate", EmitDefaultValue = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// The tenant quota features.
        /// </summary>
        /// <value>The tenant quota features.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "features", EmitDefaultValue = true)]
        public string Features { get; set; }

        /// <summary>
        /// The tenant maximum file size.
        /// </summary>
        /// <value>The tenant maximum file size.</value>
        /*
        <example>26214400</example>
        */
        [DataMember(Name = "maxFileSize", EmitDefaultValue = false)]
        public long MaxFileSize { get; set; }

        /// <summary>
        /// The tenant maximum total size.
        /// </summary>
        /// <value>The tenant maximum total size.</value>
        [DataMember(Name = "maxTotalSize", EmitDefaultValue = false)]
        public long MaxTotalSize { get; set; }

        /// <summary>
        /// The number of portal users.
        /// </summary>
        /// <value>The number of portal users.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "countUser", EmitDefaultValue = false)]
        public int CountUser { get; set; }

        /// <summary>
        /// The number of portal room administrators.
        /// </summary>
        /// <value>The number of portal room administrators.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "countRoomAdmin", EmitDefaultValue = false)]
        public int CountRoomAdmin { get; set; }

        /// <summary>
        /// The number of room users.
        /// </summary>
        /// <value>The number of room users.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "usersInRoom", EmitDefaultValue = false)]
        public int UsersInRoom { get; set; }

        /// <summary>
        /// The number of rooms.
        /// </summary>
        /// <value>The number of rooms.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "countRoom", EmitDefaultValue = false)]
        public int CountRoom { get; set; }

        /// <summary>
        /// Specifies if the tenant quota is nonprofit or not.
        /// </summary>
        /// <value>Specifies if the tenant quota is nonprofit or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "nonProfit", EmitDefaultValue = true)]
        public bool NonProfit { get; set; }

        /// <summary>
        /// Specifies if the tenant quota is trial or not.
        /// </summary>
        /// <value>Specifies if the tenant quota is trial or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "trial", EmitDefaultValue = true)]
        public bool Trial { get; set; }

        /// <summary>
        /// Specifies if the tenant quota is free or not.
        /// </summary>
        /// <value>Specifies if the tenant quota is free or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "free", EmitDefaultValue = true)]
        public bool Free { get; set; }

        /// <summary>
        /// Specifies if the tenant quota is updated or not.
        /// </summary>
        /// <value>Specifies if the tenant quota is updated or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "update", EmitDefaultValue = true)]
        public bool Update { get; set; }

        /// <summary>
        /// Specifies if the audit trail is available or not.
        /// </summary>
        /// <value>Specifies if the audit trail is available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "audit", EmitDefaultValue = true)]
        public bool Audit { get; set; }

        /// <summary>
        /// Specifies if ONLYOFFICE Docs is included in the tenant quota or not.
        /// </summary>
        /// <value>Specifies if ONLYOFFICE Docs is included in the tenant quota or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "docsEdition", EmitDefaultValue = true)]
        public bool DocsEdition { get; set; }

        /// <summary>
        /// Specifies if the LDAP settings are available or not.
        /// </summary>
        /// <value>Specifies if the LDAP settings are available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "ldap", EmitDefaultValue = true)]
        public bool Ldap { get; set; }

        /// <summary>
        /// Specifies if the SSO settings are available or not.
        /// </summary>
        /// <value>Specifies if the SSO settings are available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "sso", EmitDefaultValue = true)]
        public bool Sso { get; set; }

        /// <summary>
        /// Specifies if the statistics settings are available or not.
        /// </summary>
        /// <value>Specifies if the statistics settings are available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "statistic", EmitDefaultValue = true)]
        public bool Statistic { get; set; }

        /// <summary>
        /// Specifies if the branding settings are available or not.
        /// </summary>
        /// <value>Specifies if the branding settings are available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "branding", EmitDefaultValue = true)]
        public bool Branding { get; set; }

        /// <summary>
        /// Specifies if the customization settings are available or not.
        /// </summary>
        /// <value>Specifies if the customization settings are available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "customization", EmitDefaultValue = true)]
        public bool Customization { get; set; }

        /// <summary>
        /// Specifies if the license has the lifetime settings or not.
        /// </summary>
        /// <value>Specifies if the license has the lifetime settings or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "lifetime", EmitDefaultValue = true)]
        public bool Lifetime { get; set; }

        /// <summary>
        /// Specifies if the custom domain URL is available or not.
        /// </summary>
        /// <value>Specifies if the custom domain URL is available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "custom", EmitDefaultValue = true)]
        public bool Custom { get; set; }

        /// <summary>
        /// Specifies if the automatic backup option is enabled or not.
        /// </summary>
        /// <value>Specifies if the automatic backup option is enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "autoBackupRestore", EmitDefaultValue = true)]
        public bool AutoBackupRestore { get; set; }

        /// <summary>
        /// Specifies if Oauth is available or not.
        /// </summary>
        /// <value>Specifies if Oauth is available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "oauth", EmitDefaultValue = true)]
        public bool Oauth { get; set; }

        /// <summary>
        /// Specifies if the content search is available or not.
        /// </summary>
        /// <value>Specifies if the content search is available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "contentSearch", EmitDefaultValue = true)]
        public bool ContentSearch { get; set; }

        /// <summary>
        /// Specifies if the third-party accounts linking is available or not.
        /// </summary>
        /// <value>Specifies if the third-party accounts linking is available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "thirdParty", EmitDefaultValue = true)]
        public bool ThirdParty { get; set; }

        /// <summary>
        /// Specifies if the tenant quota is yearly subscription or not.
        /// </summary>
        /// <value>Specifies if the tenant quota is yearly subscription or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "year", EmitDefaultValue = true)]
        public bool Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantQuota {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceCurrencySymbol: ").Append(PriceCurrencySymbol).Append("\n");
            sb.Append("  PriceISOCurrencySymbol: ").Append(PriceISOCurrencySymbol).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  MaxFileSize: ").Append(MaxFileSize).Append("\n");
            sb.Append("  MaxTotalSize: ").Append(MaxTotalSize).Append("\n");
            sb.Append("  CountUser: ").Append(CountUser).Append("\n");
            sb.Append("  CountRoomAdmin: ").Append(CountRoomAdmin).Append("\n");
            sb.Append("  UsersInRoom: ").Append(UsersInRoom).Append("\n");
            sb.Append("  CountRoom: ").Append(CountRoom).Append("\n");
            sb.Append("  NonProfit: ").Append(NonProfit).Append("\n");
            sb.Append("  Trial: ").Append(Trial).Append("\n");
            sb.Append("  Free: ").Append(Free).Append("\n");
            sb.Append("  Update: ").Append(Update).Append("\n");
            sb.Append("  Audit: ").Append(Audit).Append("\n");
            sb.Append("  DocsEdition: ").Append(DocsEdition).Append("\n");
            sb.Append("  Ldap: ").Append(Ldap).Append("\n");
            sb.Append("  Sso: ").Append(Sso).Append("\n");
            sb.Append("  Statistic: ").Append(Statistic).Append("\n");
            sb.Append("  Branding: ").Append(Branding).Append("\n");
            sb.Append("  Customization: ").Append(Customization).Append("\n");
            sb.Append("  Lifetime: ").Append(Lifetime).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
            sb.Append("  AutoBackupRestore: ").Append(AutoBackupRestore).Append("\n");
            sb.Append("  Oauth: ").Append(Oauth).Append("\n");
            sb.Append("  ContentSearch: ").Append(ContentSearch).Append("\n");
            sb.Append("  ThirdParty: ").Append(ThirdParty).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
