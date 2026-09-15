// (c) Copyright Ascensio System SIA 2026
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
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The record of one portal: its name, owner, language, time zone and lifecycle state.
    /// </summary>
    [DataContract(Name = "TenantDto")]
    public partial class TenantDto : IValidatableObject
    {

        /// <summary>
        /// The line of business chosen when the portal was created. It only steers what the vendor suggests and  restricts nothing.
        /// </summary>
        [DataMember(Name = "industry", EmitDefaultValue = false)]
        public TenantIndustry? Industry { get; set; }

        /// <summary>
        /// The lifecycle state of the portal. Anything other than active means most operations are refused for the  moment, because the portal is being transferred, restored, encrypted or removed.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public TenantStatus? Status { get; set; }

        /// <summary>
        /// How the mail domains are applied: no domain trusted, every domain trusted, or only the listed ones. Only  the last of the three makes &#x60;trustedDomains&#x60; meaningful.
        /// </summary>
        [DataMember(Name = "trustedDomainsType", EmitDefaultValue = false)]
        public TenantTrustedDomainsType? TrustedDomainsType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantDto" /> class.
        /// </summary>
        /// <param name="affiliateId">The partner the portal was signed up through, empty for a portal that came in directly. It is bookkeeping  for the vendor and has no bearing on what the portal may do..</param>
        /// <param name="tenantAlias">The portal&#39;s own name within the installation, which together with the installation&#39;s base domain forms  the address it is reached at. A caller without the portal-settings right gets &#x60;tenantId&#x60; alone, so an  empty value here is the sign that the rest of this object was withheld rather than unset..</param>
        /// <param name="calls">Whether telephony is switched on for the portal. It is carried over from portal registration and stays  &#x60;false&#x60; on a DocSpace portal, where the feature does not exist..</param>
        /// <param name="campaign">The marketing campaign the portal was signed up under, empty for a portal that came in outside one. Like  &#x60;affiliateId&#x60;, it is bookkeeping only..</param>
        /// <param name="hostedRegion">The data-centre region written on the portal record itself, as opposed to &#x60;region&#x60;, which is looked up  from the hosting service. It is empty on a server installation..</param>
        /// <param name="industry">The line of business chosen when the portal was created. It only steers what the vendor suggests and  restricts nothing..</param>
        /// <param name="language">The default language of the portal as a culture name, the same value &#x60;GET api/2.0/settings&#x60; reports as  &#x60;culture&#x60;. A member may have a language of their own, which this does not reflect..</param>
        /// <param name="lastModified">When any field of this record last changed, in UTC. It does not move when portal settings outside this  record are changed..</param>
        /// <param name="mappedDomain">The custom domain the portal answers on in addition to its own address, empty when none has been set up..</param>
        /// <param name="name">The portal title as shown to people, which is what &#x60;GET api/2.0/settings&#x60; returns as  &#x60;greetingSettings&#x60;. It is free text, unlike &#x60;tenantAlias&#x60;, and empty until someone sets it..</param>
        /// <param name="ownerId">The portal owner, the one account that cannot be removed or demoted.  &#x60;PUT api/2.0/settings/owner&#x60; hands the role over..</param>
        /// <param name="paymentId">The portal&#39;s identifier in the billing system, empty for a portal that has never been billed. The  subscription itself is read with &#x60;GET api/2.0/portal/tariff&#x60;..</param>
        /// <param name="spam">Whether the owner agreed to receive the vendor&#39;s newsletter. Despite the name it does not mark the portal  as a spammer and affects nothing but marketing mail..</param>
        /// <param name="status">The lifecycle state of the portal. Anything other than active means most operations are refused for the  moment, because the portal is being transferred, restored, encrypted or removed..</param>
        /// <param name="timeZone">The portal time zone, which is the zone the dates this API calls portal time are expressed in. It may be  stored as a Windows identifier here, while &#x60;GET api/2.0/settings&#x60; always reports the IANA form..</param>
        /// <param name="trustedDomains">The mail domains a new member may register or be invited from without confirming the address. It is empty  whenever &#x60;trustedDomainsType&#x60; is not &#x60;Custom&#x60;..</param>
        /// <param name="trustedDomainsRaw">The same domains as the single stored string they are kept in, separated by commas. Read  &#x60;trustedDomains&#x60; instead; this one exists because it is what the record holds..</param>
        /// <param name="trustedDomainsType">How the mail domains are applied: no domain trusted, every domain trusted, or only the listed ones. Only  the last of the three makes &#x60;trustedDomains&#x60; meaningful..</param>
        /// <param name="version">The identifier of the portal version the installation pins this portal to, which is an internal number  and not the product version string that &#x60;GET api/2.0/settings&#x60; reports as &#x60;version&#x60;..</param>
        /// <param name="versionChanged">When &#x60;version&#x60; last changed, in UTC. It stays at its zero value on a portal whose version has never been  switched..</param>
        /// <param name="region">The data-centre region the portal is actually served from, looked up from the hosting service. It is  empty on a server installation and also whenever the installation&#39;s portal cache is switched off, so an  empty value does not mean the portal has no region - &#x60;hostedRegion&#x60; is the value from the record itself..</param>
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
        /// The partner the portal was signed up through, empty for a portal that came in directly. It is bookkeeping  for the vendor and has no bearing on what the portal may do.
        /// </summary>
        /// <example>AFF12345</example>
        [DataMember(Name = "affiliateId", EmitDefaultValue = true)]
        public string AffiliateId { get; set; }

        /// <summary>
        /// The portal&#39;s own name within the installation, which together with the installation&#39;s base domain forms  the address it is reached at. A caller without the portal-settings right gets &#x60;tenantId&#x60; alone, so an  empty value here is the sign that the rest of this object was withheld rather than unset.
        /// </summary>
        /// <example>my-company</example>
        [DataMember(Name = "tenantAlias", EmitDefaultValue = true)]
        public string TenantAlias { get; set; }

        /// <summary>
        /// Whether telephony is switched on for the portal. It is carried over from portal registration and stays  &#x60;false&#x60; on a DocSpace portal, where the feature does not exist.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "calls", EmitDefaultValue = true)]
        public bool Calls { get; set; }

        /// <summary>
        /// The marketing campaign the portal was signed up under, empty for a portal that came in outside one. Like  &#x60;affiliateId&#x60;, it is bookkeeping only.
        /// </summary>
        /// <example>WINTER2024</example>
        [DataMember(Name = "campaign", EmitDefaultValue = true)]
        public string Campaign { get; set; }

        /// <summary>
        /// When the portal was created, in UTC rather than in the portal time zone.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
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
        /// The data-centre region written on the portal record itself, as opposed to &#x60;region&#x60;, which is looked up  from the hosting service. It is empty on a server installation.
        /// </summary>
        /// <example>EU</example>
        [DataMember(Name = "hostedRegion", EmitDefaultValue = true)]
        public string HostedRegion { get; set; }

        /// <summary>
        /// The numeric identifier of the portal inside the installation. It is the one field every caller gets,  whatever their rights.
        /// </summary>
        /// <example>1</example>
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
        /// The default language of the portal as a culture name, the same value &#x60;GET api/2.0/settings&#x60; reports as  &#x60;culture&#x60;. A member may have a language of their own, which this does not reflect.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// When any field of this record last changed, in UTC. It does not move when portal settings outside this  record are changed.
        /// </summary>
        /// <example>2024-02-10T14:20:00Z</example>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// The custom domain the portal answers on in addition to its own address, empty when none has been set up.
        /// </summary>
        /// <example>mycompany.example.com</example>
        [DataMember(Name = "mappedDomain", EmitDefaultValue = true)]
        public string MappedDomain { get; set; }

        /// <summary>
        /// The portal title as shown to people, which is what &#x60;GET api/2.0/settings&#x60; returns as  &#x60;greetingSettings&#x60;. It is free text, unlike &#x60;tenantAlias&#x60;, and empty until someone sets it.
        /// </summary>
        /// <example>My Company</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The portal owner, the one account that cannot be removed or demoted.  &#x60;PUT api/2.0/settings/owner&#x60; hands the role over.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000001</example>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public Guid OwnerId { get; set; }

        /// <summary>
        /// The portal&#39;s identifier in the billing system, empty for a portal that has never been billed. The  subscription itself is read with &#x60;GET api/2.0/portal/tariff&#x60;.
        /// </summary>
        /// <example>PAY123456789</example>
        [DataMember(Name = "paymentId", EmitDefaultValue = true)]
        public string PaymentId { get; set; }

        /// <summary>
        /// Whether the owner agreed to receive the vendor&#39;s newsletter. Despite the name it does not mark the portal  as a spammer and affects nothing but marketing mail.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "spam", EmitDefaultValue = true)]
        public bool Spam { get; set; }

        /// <summary>
        /// When &#x60;status&#x60; last changed, in UTC. For a portal pending removal it is the moment the countdown to  deletion started.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
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
        /// The portal time zone, which is the zone the dates this API calls portal time are expressed in. It may be  stored as a Windows identifier here, while &#x60;GET api/2.0/settings&#x60; always reports the IANA form.
        /// </summary>
        /// <example>America/New_York</example>
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public string @TimeZone { get; set; }

        /// <summary>
        /// The mail domains a new member may register or be invited from without confirming the address. It is empty  whenever &#x60;trustedDomainsType&#x60; is not &#x60;Custom&#x60;.
        /// </summary>
        /// <example>["example.com","trusted.com"]</example>
        [DataMember(Name = "trustedDomains", EmitDefaultValue = true)]
        public List<string> TrustedDomains { get; set; }

        /// <summary>
        /// The same domains as the single stored string they are kept in, separated by commas. Read  &#x60;trustedDomains&#x60; instead; this one exists because it is what the record holds.
        /// </summary>
        /// <example>example.com,trusted.com</example>
        [DataMember(Name = "trustedDomainsRaw", EmitDefaultValue = true)]
        public string TrustedDomainsRaw { get; set; }

        /// <summary>
        /// The identifier of the portal version the installation pins this portal to, which is an internal number  and not the product version string that &#x60;GET api/2.0/settings&#x60; reports as &#x60;version&#x60;.
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// When &#x60;version&#x60; last changed, in UTC. It stays at its zero value on a portal whose version has never been  switched.
        /// </summary>
        /// <example>2024-02-01T09:00:00Z</example>
        [DataMember(Name = "versionChanged", EmitDefaultValue = false)]
        public DateTime VersionChanged { get; set; }

        /// <summary>
        /// The data-centre region the portal is actually served from, looked up from the hosting service. It is  empty on a server installation and also whenever the installation&#39;s portal cache is switched off, so an  empty value does not mean the portal has no region - &#x60;hostedRegion&#x60; is the value from the record itself.
        /// </summary>
        /// <example>us-east-1</example>
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
