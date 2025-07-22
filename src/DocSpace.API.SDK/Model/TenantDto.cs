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
    /// The tenant parameters.
    /// </summary>
    [DataContract(Name = "TenantDto")]
    public partial class TenantDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name = "industry", EmitDefaultValue = false)]
        public TenantIndustry? Industry { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public TenantStatus? Status { get; set; }

        /// <summary>
        /// Gets or Sets TrustedDomainsType
        /// </summary>
        [DataMember(Name = "trustedDomainsType", EmitDefaultValue = false)]
        public TenantTrustedDomainsType? TrustedDomainsType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantDto" /> class.
        /// </summary>
        /// <param name="affiliateId">The affiliate ID..</param>
        /// <param name="tenantAlias">The tenant alias..</param>
        /// <param name="calls">Specifies if the calls are available for this tenant or not..</param>
        /// <param name="campaign">The tenant campaign..</param>
        /// <param name="hostedRegion">The hosted region..</param>
        /// <param name="industry">industry.</param>
        /// <param name="language">The tenant language..</param>
        /// <param name="lastModified">The date and time when the tenant was last modified..</param>
        /// <param name="mappedDomain">The tenant mapped domain..</param>
        /// <param name="name">The tenant name..</param>
        /// <param name="ownerId">The tenant owner ID..</param>
        /// <param name="paymentId">The tenant payment ID..</param>
        /// <param name="spam">Specifies if the ONLYOFFICE newsletter is allowed or not..</param>
        /// <param name="status">status.</param>
        /// <param name="timeZone">The tenant time zone..</param>
        /// <param name="trustedDomains">The list of tenant trusted domains..</param>
        /// <param name="trustedDomainsRaw">The tenant trusted domains in the string format..</param>
        /// <param name="trustedDomainsType">trustedDomainsType.</param>
        /// <param name="version">The tenant version.</param>
        /// <param name="versionChanged">The date and time when the tenant version was changed..</param>
        /// <param name="region">The tenant AWS region..</param>
        public TenantDto(string affiliateId = default, string tenantAlias = default, bool calls = default, string campaign = default, string hostedRegion = default, TenantIndustry? industry = default, string language = default, DateTime lastModified = default, string mappedDomain = default, string name = default, Guid ownerId = default, string paymentId = default, bool spam = default, TenantStatus? status = default, string timeZone = default, List<string> trustedDomains = default, string trustedDomainsRaw = default, TenantTrustedDomainsType? trustedDomainsType = default, int version = default, DateTime versionChanged = default, string region = default)
        {
            this.AffiliateId = affiliateId;
            this.TenantAlias = tenantAlias;
            this.Calls = calls;
            this.Campaign = campaign;
            this.HostedRegion = hostedRegion;
            this.Industry = industry;
            this.Language = language;
            this.LastModified = lastModified;
            this.MappedDomain = mappedDomain;
            this.Name = name;
            this.OwnerId = ownerId;
            this.PaymentId = paymentId;
            this.Spam = spam;
            this.Status = status;
            this.@TimeZone = timeZone;
            this.TrustedDomains = trustedDomains;
            this.TrustedDomainsRaw = trustedDomainsRaw;
            this.TrustedDomainsType = trustedDomainsType;
            this.@Version = version;
            this.VersionChanged = versionChanged;
            this.Region = region;
        }

        /// <summary>
        /// The affiliate ID.
        /// </summary>
        /// <value>The affiliate ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "affiliateId", EmitDefaultValue = true)]
        public string AffiliateId { get; set; }

        /// <summary>
        /// The tenant alias.
        /// </summary>
        /// <value>The tenant alias.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "tenantAlias", EmitDefaultValue = true)]
        public string TenantAlias { get; set; }

        /// <summary>
        /// Specifies if the calls are available for this tenant or not.
        /// </summary>
        /// <value>Specifies if the calls are available for this tenant or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "calls", EmitDefaultValue = true)]
        public bool Calls { get; set; }

        /// <summary>
        /// The tenant campaign.
        /// </summary>
        /// <value>The tenant campaign.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "campaign", EmitDefaultValue = true)]
        public string Campaign { get; set; }

        /// <summary>
        /// The tenant creation date and time.
        /// </summary>
        /// <value>The tenant creation date and time.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "creationDateTime", EmitDefaultValue = false)]
        public DateTime CreationDateTime { get; private set; }

        /// <summary>
        /// Returns false as CreationDateTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreationDateTime()
        {
            return false;
        }
        /// <summary>
        /// The hosted region.
        /// </summary>
        /// <value>The hosted region.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "hostedRegion", EmitDefaultValue = true)]
        public string HostedRegion { get; set; }

        /// <summary>
        /// The tenant ID.
        /// </summary>
        /// <value>The tenant ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public int TenantId { get; private set; }

        /// <summary>
        /// Returns false as TenantId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTenantId()
        {
            return false;
        }
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
        /// The date and time when the tenant was last modified.
        /// </summary>
        /// <value>The date and time when the tenant was last modified.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// The tenant mapped domain.
        /// </summary>
        /// <value>The tenant mapped domain.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "mappedDomain", EmitDefaultValue = true)]
        public string MappedDomain { get; set; }

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
        /// The tenant owner ID.
        /// </summary>
        /// <value>The tenant owner ID.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public Guid OwnerId { get; set; }

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
        /// Specifies if the ONLYOFFICE newsletter is allowed or not.
        /// </summary>
        /// <value>Specifies if the ONLYOFFICE newsletter is allowed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "spam", EmitDefaultValue = true)]
        public bool Spam { get; set; }

        /// <summary>
        /// The date and time when the tenant status was changed.
        /// </summary>
        /// <value>The date and time when the tenant status was changed.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "statusChangeDate", EmitDefaultValue = false)]
        public DateTime StatusChangeDate { get; private set; }

        /// <summary>
        /// Returns false as StatusChangeDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatusChangeDate()
        {
            return false;
        }
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
        /// The list of tenant trusted domains.
        /// </summary>
        /// <value>The list of tenant trusted domains.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "trustedDomains", EmitDefaultValue = true)]
        public List<string> TrustedDomains { get; set; }

        /// <summary>
        /// The tenant trusted domains in the string format.
        /// </summary>
        /// <value>The tenant trusted domains in the string format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "trustedDomainsRaw", EmitDefaultValue = true)]
        public string TrustedDomainsRaw { get; set; }

        /// <summary>
        /// The tenant version
        /// </summary>
        /// <value>The tenant version</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// The date and time when the tenant version was changed.
        /// </summary>
        /// <value>The date and time when the tenant version was changed.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "versionChanged", EmitDefaultValue = false)]
        public DateTime VersionChanged { get; set; }

        /// <summary>
        /// The tenant AWS region.
        /// </summary>
        /// <value>The tenant AWS region.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "region", EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantDto {\n");
            sb.Append("  AffiliateId: ").Append(AffiliateId).Append("\n");
            sb.Append("  TenantAlias: ").Append(TenantAlias).Append("\n");
            sb.Append("  Calls: ").Append(Calls).Append("\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
            sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
            sb.Append("  HostedRegion: ").Append(HostedRegion).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  MappedDomain: ").Append(MappedDomain).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Spam: ").Append(Spam).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusChangeDate: ").Append(StatusChangeDate).Append("\n");
            sb.Append("  @TimeZone: ").Append(@TimeZone).Append("\n");
            sb.Append("  TrustedDomains: ").Append(TrustedDomains).Append("\n");
            sb.Append("  TrustedDomainsRaw: ").Append(TrustedDomainsRaw).Append("\n");
            sb.Append("  TrustedDomainsType: ").Append(TrustedDomainsType).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  VersionChanged: ").Append(VersionChanged).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
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
