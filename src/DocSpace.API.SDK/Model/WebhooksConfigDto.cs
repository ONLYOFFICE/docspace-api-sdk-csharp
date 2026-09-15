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
    /// One webhook subscription of the portal: where deliveries go, which events they cover, and how they have fared.
    /// </summary>
    [DataContract(Name = "WebhooksConfigDto")]
    public partial class WebhooksConfigDto : IValidatableObject
    {

        /// <summary>
        /// The events the subscription covers, as the bits of &#x60;GET api/2.0/settings/webhook/triggers&#x60; added  together. &#x60;0&#x60; is the catch-all and means every event, not none.
        /// </summary>
        [DataMember(Name = "triggers", EmitDefaultValue = false)]
        public WebhookTrigger? Triggers { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksConfigDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhooksConfigDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksConfigDto" /> class.
        /// </summary>
        /// <param name="id">The identifier of the subscription, which is what &#x60;PUT api/2.0/settings/webhook&#x60;,  &#x60;DELETE api/2.0/settings/webhook/{id}&#x60; and the &#x60;configId&#x60; filter of the delivery log address it by. (required).</param>
        /// <param name="name">The label the subscription was given, free text with no meaning to the portal..</param>
        /// <param name="uri">The address every delivery is posted to. The signing secret that lets the receiver verify a delivery is  never part of this answer, so it has to be kept from the moment the subscription was created..</param>
        /// <param name="enabled">Whether the subscription is delivering. While it is &#x60;false&#x60; events are dropped rather than queued, so  nothing arrives late after it is switched back on..</param>
        /// <param name="ssl">Whether the certificate of &#x60;uri&#x60; is verified before a delivery. While it is &#x60;false&#x60; a self-signed  certificate is accepted as well..</param>
        /// <param name="triggers">The events the subscription covers, as the bits of &#x60;GET api/2.0/settings/webhook/triggers&#x60; added  together. &#x60;0&#x60; is the catch-all and means every event, not none..</param>
        /// <param name="targetId">The single room or file the subscription is narrowed to, empty for a subscription that covers the whole  portal. It is kept as an opaque value, so both a numeric and a third-party identifier can appear..</param>
        /// <param name="createdBy">The member who created the subscription, which is also who a non-administrator is limited to seeing. It is  empty for a subscription created by a portal background job..</param>
        /// <param name="createdOn">When the subscription was created, in the portal time zone..</param>
        /// <param name="modifiedBy">The member who last changed the subscription, empty while nobody has changed it since it was created..</param>
        /// <param name="modifiedOn">When it was last changed, in the portal time zone, and empty under the same condition as &#x60;modifiedBy&#x60;..</param>
        /// <param name="lastFailureOn">When a delivery last failed, in the portal time zone. It is empty for a subscription that has never  failed, and it is not cleared by a later success - compare it with &#x60;lastSuccessOn&#x60; to see which came last..</param>
        /// <param name="lastFailureContent">What the target answered on that failure, truncated, for diagnosing without opening the delivery log. It  is empty when the failure produced no body at all, a timeout for instance..</param>
        /// <param name="lastSuccessOn">When a delivery last succeeded, in the portal time zone, empty for a subscription that has never  delivered. Both this and &#x60;lastFailureOn&#x60; being empty means nothing has been attempted yet..</param>
        public WebhooksConfigDto(int id = default, string name = default, string uri = default, bool enabled = default, bool ssl = default, WebhookTrigger? triggers = default, string targetId = default, EmployeeDto createdBy = default, DateTime? createdOn = default, EmployeeDto modifiedBy = default, DateTime? modifiedOn = default, DateTime? lastFailureOn = default, string lastFailureContent = default, DateTime? lastSuccessOn = default)
        {
            this.Id = id;
            this.Name = name;
            this.Uri = uri;
            this.Enabled = enabled;
            this.Ssl = ssl;
            this.Triggers = triggers;
            this.TargetId = targetId;
            this.CreatedBy = createdBy;
            this.CreatedOn = createdOn;
            this.ModifiedBy = modifiedBy;
            this.ModifiedOn = modifiedOn;
            this.LastFailureOn = lastFailureOn;
            this.LastFailureContent = lastFailureContent;
            this.LastSuccessOn = lastSuccessOn;
        }

        /// <summary>
        /// The identifier of the subscription, which is what &#x60;PUT api/2.0/settings/webhook&#x60;,  &#x60;DELETE api/2.0/settings/webhook/{id}&#x60; and the &#x60;configId&#x60; filter of the delivery log address it by.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The label the subscription was given, free text with no meaning to the portal.
        /// </summary>
        /// <example>Room activity</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The address every delivery is posted to. The signing secret that lets the receiver verify a delivery is  never part of this answer, so it has to be kept from the moment the subscription was created.
        /// </summary>
        /// <example>https://example.com/hooks/docspace</example>
        [DataMember(Name = "uri", EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Whether the subscription is delivering. While it is &#x60;false&#x60; events are dropped rather than queued, so  nothing arrives late after it is switched back on.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether the certificate of &#x60;uri&#x60; is verified before a delivery. While it is &#x60;false&#x60; a self-signed  certificate is accepted as well.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "ssl", EmitDefaultValue = true)]
        public bool Ssl { get; set; }

        /// <summary>
        /// The single room or file the subscription is narrowed to, empty for a subscription that covers the whole  portal. It is kept as an opaque value, so both a numeric and a third-party identifier can appear.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000001</example>
        [DataMember(Name = "targetId", EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// The member who created the subscription, which is also who a non-administrator is limited to seeing. It is  empty for a subscription created by a portal background job.
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public EmployeeDto CreatedBy { get; set; }

        /// <summary>
        /// When the subscription was created, in the portal time zone.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "createdOn", EmitDefaultValue = true)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// The member who last changed the subscription, empty while nobody has changed it since it was created.
        /// </summary>
        [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
        public EmployeeDto ModifiedBy { get; set; }

        /// <summary>
        /// When it was last changed, in the portal time zone, and empty under the same condition as &#x60;modifiedBy&#x60;.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "modifiedOn", EmitDefaultValue = true)]
        public DateTime? ModifiedOn { get; set; }

        /// <summary>
        /// When a delivery last failed, in the portal time zone. It is empty for a subscription that has never  failed, and it is not cleared by a later success - compare it with &#x60;lastSuccessOn&#x60; to see which came last.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "lastFailureOn", EmitDefaultValue = true)]
        public DateTime? LastFailureOn { get; set; }

        /// <summary>
        /// What the target answered on that failure, truncated, for diagnosing without opening the delivery log. It  is empty when the failure produced no body at all, a timeout for instance.
        /// </summary>
        /// <example>502 Bad Gateway</example>
        [DataMember(Name = "lastFailureContent", EmitDefaultValue = true)]
        public string LastFailureContent { get; set; }

        /// <summary>
        /// When a delivery last succeeded, in the portal time zone, empty for a subscription that has never  delivered. Both this and &#x60;lastFailureOn&#x60; being empty means nothing has been attempted yet.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "lastSuccessOn", EmitDefaultValue = true)]
        public DateTime? LastSuccessOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhooksConfigDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Ssl: ").Append(Ssl).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  ModifiedOn: ").Append(ModifiedOn).Append("\n");
            sb.Append("  LastFailureOn: ").Append(LastFailureOn).Append("\n");
            sb.Append("  LastFailureContent: ").Append(LastFailureContent).Append("\n");
            sb.Append("  LastSuccessOn: ").Append(LastSuccessOn).Append("\n");
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
