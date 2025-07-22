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
    /// The database tenant parameters.
    /// </summary>
    [DataContract(Name = "DbTenant")]
    public partial class DbTenant : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TrustedDomainsEnabled
        /// </summary>
        [DataMember(Name = "trustedDomainsEnabled", EmitDefaultValue = false)]
        public TenantTrustedDomainsType? TrustedDomainsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public TenantStatus? Status { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name = "industry", EmitDefaultValue = false)]
        public TenantIndustry? Industry { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DbTenant" /> class.
        /// </summary>
        /// <param name="id">The tenant ID..</param>
        /// <param name="name">The tenant name..</param>
        /// <param name="alias">The tenant alias..</param>
        /// <param name="mappedDomain">Mapped domain.</param>
        /// <param name="version">The tenant version..</param>
        /// <param name="versionChangedField">The Version_changed field..</param>
        /// <param name="versionChanged">The date and time when the version was changed..</param>
        /// <param name="language">The tenant language..</param>
        /// <param name="timeZone">The tenant time zone..</param>
        /// <param name="trustedDomainsRaw">The tenant trusted domains raw..</param>
        /// <param name="trustedDomainsEnabled">trustedDomainsEnabled.</param>
        /// <param name="status">status.</param>
        /// <param name="statusChanged">The date and time when the tenant status was changed..</param>
        /// <param name="statusChangedHack">The hacked date and time when the tenant status was changed..</param>
        /// <param name="creationDateTime">The tenant creation date..</param>
        /// <param name="ownerId">The tenant owner ID..</param>
        /// <param name="paymentId">The tenant payment ID..</param>
        /// <param name="industry">industry.</param>
        /// <param name="lastModified">The date and time when the tenant was last modified..</param>
        /// <param name="calls">Specifies if the calls are available for the current tenant or not..</param>
        /// <param name="partner">partner.</param>
        public DbTenant(int id = default, string name = default, string alias = default, string mappedDomain = default, int version = default, DateTime? versionChangedField = default, DateTime versionChanged = default, string language = default, string timeZone = default, string trustedDomainsRaw = default, TenantTrustedDomainsType? trustedDomainsEnabled = default, TenantStatus? status = default, DateTime? statusChanged = default, DateTime statusChangedHack = default, DateTime creationDateTime = default, Guid? ownerId = default, string paymentId = default, TenantIndustry? industry = default, DateTime lastModified = default, bool calls = default, DbTenantPartner partner = default)
        {
            this.Id = id;
            this.Name = name;
            this.Alias = alias;
            this.MappedDomain = mappedDomain;
            this.@Version = version;
            this.VersionChangedField = versionChangedField;
            this.VersionChanged = versionChanged;
            this.Language = language;
            this.@TimeZone = timeZone;
            this.TrustedDomainsRaw = trustedDomainsRaw;
            this.TrustedDomainsEnabled = trustedDomainsEnabled;
            this.Status = status;
            this.StatusChanged = statusChanged;
            this.StatusChangedHack = statusChangedHack;
            this.CreationDateTime = creationDateTime;
            this.OwnerId = ownerId;
            this.PaymentId = paymentId;
            this.Industry = industry;
            this.LastModified = lastModified;
            this.Calls = calls;
            this.Partner = partner;
        }

        /// <summary>
        /// The tenant ID.
        /// </summary>
        /// <value>The tenant ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The tenant name.
        /// </summary>
        /// <value>The tenant name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The tenant alias.
        /// </summary>
        /// <value>The tenant alias.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Mapped domain
        /// </summary>
        /// <value>Mapped domain</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "mappedDomain", EmitDefaultValue = true)]
        public string MappedDomain { get; set; }

        /// <summary>
        /// The tenant version.
        /// </summary>
        /// <value>The tenant version.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// The Version_changed field.
        /// </summary>
        /// <value>The Version_changed field.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "versionChangedField", EmitDefaultValue = true)]
        public DateTime? VersionChangedField { get; set; }

        /// <summary>
        /// The date and time when the version was changed.
        /// </summary>
        /// <value>The date and time when the version was changed.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "versionChanged", EmitDefaultValue = false)]
        public DateTime VersionChanged { get; set; }

        /// <summary>
        /// The tenant language.
        /// </summary>
        /// <value>The tenant language.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// The tenant time zone.
        /// </summary>
        /// <value>The tenant time zone.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public string @TimeZone { get; set; }

        /// <summary>
        /// The tenant trusted domains raw.
        /// </summary>
        /// <value>The tenant trusted domains raw.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "trustedDomainsRaw", EmitDefaultValue = true)]
        public string TrustedDomainsRaw { get; set; }

        /// <summary>
        /// The date and time when the tenant status was changed.
        /// </summary>
        /// <value>The date and time when the tenant status was changed.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "statusChanged", EmitDefaultValue = true)]
        public DateTime? StatusChanged { get; set; }

        /// <summary>
        /// The hacked date and time when the tenant status was changed.
        /// </summary>
        /// <value>The hacked date and time when the tenant status was changed.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "statusChangedHack", EmitDefaultValue = false)]
        public DateTime StatusChangedHack { get; set; }

        /// <summary>
        /// The tenant creation date.
        /// </summary>
        /// <value>The tenant creation date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
        public DateTime CreationDateTime { get; set; }

        /// <summary>
        /// The tenant owner ID.
        /// </summary>
        /// <value>The tenant owner ID.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "ownerId", EmitDefaultValue = true)]
        public Guid? OwnerId { get; set; }

        /// <summary>
        /// The tenant payment ID.
        /// </summary>
        /// <value>The tenant payment ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "paymentId", EmitDefaultValue = true)]
        public string PaymentId { get; set; }

        /// <summary>
        /// The date and time when the tenant was last modified.
        /// </summary>
        /// <value>The date and time when the tenant was last modified.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Specifies if the calls are available for the current tenant or not.
        /// </summary>
        /// <value>Specifies if the calls are available for the current tenant or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "calls", EmitDefaultValue = true)]
        public bool Calls { get; set; }

        /// <summary>
        /// Gets or Sets Partner
        /// </summary>
        [DataMember(Name = "partner", EmitDefaultValue = false)]
        public DbTenantPartner Partner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbTenant {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  MappedDomain: ").Append(MappedDomain).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  VersionChangedField: ").Append(VersionChangedField).Append("\n");
            sb.Append("  VersionChanged: ").Append(VersionChanged).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  @TimeZone: ").Append(@TimeZone).Append("\n");
            sb.Append("  TrustedDomainsRaw: ").Append(TrustedDomainsRaw).Append("\n");
            sb.Append("  TrustedDomainsEnabled: ").Append(TrustedDomainsEnabled).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusChanged: ").Append(StatusChanged).Append("\n");
            sb.Append("  StatusChangedHack: ").Append(StatusChangedHack).Append("\n");
            sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Calls: ").Append(Calls).Append("\n");
            sb.Append("  Partner: ").Append(Partner).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Alias (string) maxLength
            if (this.Alias != null && this.Alias.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Alias, length must be less than 100.", new [] { "Alias" });
            }

            // MappedDomain (string) maxLength
            if (this.MappedDomain != null && this.MappedDomain.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MappedDomain, length must be less than 100.", new [] { "MappedDomain" });
            }

            // Language (string) maxLength
            if (this.Language != null && this.Language.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Language, length must be less than 10.", new [] { "Language" });
            }

            // @TimeZone (string) maxLength
            if (this.@TimeZone != null && this.@TimeZone.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for @TimeZone, length must be less than 50.", new [] { "@TimeZone" });
            }

            // TrustedDomainsRaw (string) maxLength
            if (this.TrustedDomainsRaw != null && this.TrustedDomainsRaw.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrustedDomainsRaw, length must be less than 1024.", new [] { "TrustedDomainsRaw" });
            }

            // PaymentId (string) maxLength
            if (this.PaymentId != null && this.PaymentId.Length > 38)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentId, length must be less than 38.", new [] { "PaymentId" });
            }

            yield break;
        }
    }


}
