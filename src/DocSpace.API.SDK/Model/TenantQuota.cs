// (c) Copyright Ascensio System SIA 2025
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
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
        /// <param name="restore">Specifies if the restore is enabled or not..</param>
        /// <param name="oauth">Specifies if Oauth is available or not..</param>
        /// <param name="contentSearch">Specifies if the content search is available or not..</param>
        /// <param name="thirdParty">Specifies if the third-party accounts linking is available or not..</param>
        /// <param name="year">Specifies if the tenant quota is yearly subscription or not..</param>
        /// <param name="countFreeBackup">The number of free backups within a month..</param>
        /// <param name="backup">Specifies if the backup anabled as a wallet service or not..</param>
        public TenantQuota(int tenantId = default, string name = default, double price = default, string priceCurrencySymbol = default, string priceISOCurrencySymbol = default, string productId = default, bool visible = default, bool wallet = default, DateTime? dueDate = default, string features = default, long maxFileSize = default, long maxTotalSize = default, int countUser = default, int countRoomAdmin = default, int usersInRoom = default, int countRoom = default, bool nonProfit = default, bool trial = default, bool free = default, bool update = default, bool audit = default, bool docsEdition = default, bool ldap = default, bool sso = default, bool statistic = default, bool branding = default, bool customization = default, bool lifetime = default, bool custom = default, bool restore = default, bool oauth = default, bool contentSearch = default, bool thirdParty = default, bool year = default, int countFreeBackup = default, bool backup = default)
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
            this.Restore = restore;
            this.Oauth = oauth;
            this.ContentSearch = contentSearch;
            this.ThirdParty = thirdParty;
            this.Year = year;
            this.CountFreeBackup = countFreeBackup;
            this.Backup = backup;
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
        /// Specifies if the restore is enabled or not.
        /// </summary>
        /// <value>Specifies if the restore is enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "restore", EmitDefaultValue = true)]
        public bool Restore { get; set; }

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
        /// The number of free backups within a month.
        /// </summary>
        /// <value>The number of free backups within a month.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "countFreeBackup", EmitDefaultValue = false)]
        public int CountFreeBackup { get; set; }

        /// <summary>
        /// Specifies if the backup anabled as a wallet service or not.
        /// </summary>
        /// <value>Specifies if the backup anabled as a wallet service or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "backup", EmitDefaultValue = true)]
        public bool Backup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            sb.Append("  Restore: ").Append(Restore).Append("\n");
            sb.Append("  Oauth: ").Append(Oauth).Append("\n");
            sb.Append("  ContentSearch: ").Append(ContentSearch).Append("\n");
            sb.Append("  ThirdParty: ").Append(ThirdParty).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  CountFreeBackup: ").Append(CountFreeBackup).Append("\n");
            sb.Append("  Backup: ").Append(Backup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
