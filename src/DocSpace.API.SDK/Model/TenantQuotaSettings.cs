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
    /// The tenant quota settings.
    /// </summary>
    [DataContract(Name = "TenantQuotaSettings")]
    public partial class TenantQuotaSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantQuotaSettings" /> class.
        /// </summary>
        /// <param name="enableQuota">Specifies if the tenant quota is enabled or not..</param>
        /// <param name="quota">The tenant quota..</param>
        /// <param name="lastRecalculateDate">The date of the last tenant quota recalculation..</param>
        /// <param name="lastModified">The timestamp indicating when the settings were last modified..</param>
        public TenantQuotaSettings(bool enableQuota = default, long quota = default, DateTime? lastRecalculateDate = default, DateTime lastModified = default)
        {
            this.EnableQuota = enableQuota;
            this.Quota = quota;
            this.LastRecalculateDate = lastRecalculateDate;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Specifies if the tenant quota is enabled or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enableQuota", EmitDefaultValue = true)]
        public bool EnableQuota { get; set; }

        /// <summary>
        /// The tenant quota.
        /// </summary>
        /// <example>10737418240</example>
        [DataMember(Name = "quota", EmitDefaultValue = false)]
        public long Quota { get; set; }

        /// <summary>
        /// The date of the last tenant quota recalculation.
        /// </summary>
        /// <example>1990-01-01T00:00:00Z</example>
        [DataMember(Name = "lastRecalculateDate", EmitDefaultValue = true)]
        public DateTime? LastRecalculateDate { get; set; }

        /// <summary>
        /// The timestamp indicating when the settings were last modified.
        /// </summary>
        /// <example>1990-01-01T00:00:00Z</example>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantQuotaSettings {\n");
            sb.Append("  EnableQuota: ").Append(EnableQuota).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
            sb.Append("  LastRecalculateDate: ").Append(LastRecalculateDate).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
