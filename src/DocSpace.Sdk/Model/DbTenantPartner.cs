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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The database tenant partner parameters.
    /// </summary>
    [DataContract(Name = "DbTenantPartner")]
    public partial class DbTenantPartner : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DbTenantPartner" /> class.
        /// </summary>
        /// <param name="tenantId">The tenant ID..</param>
        /// <param name="partnerId">The partner ID..</param>
        /// <param name="affiliateId">The affiliate ID..</param>
        /// <param name="campaign">The tenant partner campaign..</param>
        public DbTenantPartner(int tenantId = default, string partnerId = default, string affiliateId = default, string campaign = default)
        {
            this.TenantId = tenantId;
            this.PartnerId = partnerId;
            this.AffiliateId = affiliateId;
            this.Campaign = campaign;
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
        /// The partner ID.
        /// </summary>
        /// <value>The partner ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "partnerId", EmitDefaultValue = true)]
        public string PartnerId { get; set; }

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
        /// The tenant partner campaign.
        /// </summary>
        /// <value>The tenant partner campaign.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "campaign", EmitDefaultValue = true)]
        public string Campaign { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbTenantPartner {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  AffiliateId: ").Append(AffiliateId).Append("\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
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
            // PartnerId (string) maxLength
            if (this.PartnerId != null && this.PartnerId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PartnerId, length must be less than 36.", new [] { "PartnerId" });
            }

            // AffiliateId (string) maxLength
            if (this.AffiliateId != null && this.AffiliateId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AffiliateId, length must be less than 50.", new [] { "AffiliateId" });
            }

            // Campaign (string) maxLength
            if (this.Campaign != null && this.Campaign.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Campaign, length must be less than 50.", new [] { "Campaign" });
            }

            yield break;
        }
    }


}
