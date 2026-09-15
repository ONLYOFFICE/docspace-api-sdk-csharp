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
    /// The target a webhook subscription calls, the events it listens for, and the secret it signs with.
    /// </summary>
    [DataContract(Name = "CreateWebhooksConfigRequestsDto")]
    public partial class CreateWebhooksConfigRequestsDto : IValidatableObject
    {

        /// <summary>
        /// The events the subscription listens for, as a bitmask combining the flags; 0 subscribes to all of them. Take  the flags the caller role is allowed to use from &#x60;GET api/2.0/settings/webhook/triggers&#x60;, since a flag beyond  that set is refused with 400. A subscription still only fires for events its creator may see.
        /// </summary>
        [DataMember(Name = "triggers", EmitDefaultValue = false)]
        public WebhookTrigger? Triggers { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhooksConfigRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWebhooksConfigRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhooksConfigRequestsDto" /> class.
        /// </summary>
        /// <param name="name">The label the subscription is listed under. It is for the administrator reading the list and is never sent to  the target; it does not have to be unique. (required).</param>
        /// <param name="uri">The address the portal posts the event payload to. It has to be an absolute &#x60;http&#x60; or &#x60;https&#x60; address outside  the installation own network, and it is probed before anything is stored: it must answer a HEAD request with  a success code, and a redirect does not count as one. (required).</param>
        /// <param name="secretKey">The shared secret the payload signature is computed with, so the receiver can tell a genuine call from a  forged one. It has to satisfy the portal password rules published by  &#x60;GET api/2.0/settings/security/password&#x60;, and it is never echoed back by any operation. On an update an empty  value keeps the secret already stored..</param>
        /// <param name="enabled">Whether the subscription delivers at all. While it is off the matching events are dropped rather than queued,  so nothing from that period arrives once it is switched on again..</param>
        /// <param name="ssl">Whether the target certificate is verified. Setting it demands an &#x60;https&#x60; target with a valid certificate;  leaving it off delivers without checking the certificate at all..</param>
        /// <param name="triggers">The events the subscription listens for, as a bitmask combining the flags; 0 subscribes to all of them. Take  the flags the caller role is allowed to use from &#x60;GET api/2.0/settings/webhook/triggers&#x60;, since a flag beyond  that set is refused with 400. A subscription still only fires for events its creator may see..</param>
        /// <param name="targetId">The single entity the subscription is narrowed to, by its identifier - a room or a file, for instance.  Leaving it out delivers events about every entity the subscribed triggers cover..</param>
        public CreateWebhooksConfigRequestsDto(string name = default, string uri = default, string secretKey = default, bool enabled = default, bool ssl = default, WebhookTrigger? triggers = default, string targetId = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateWebhooksConfigRequestsDto and cannot be null");
            }
            this.Name = name;
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new ArgumentNullException("uri is a required property for CreateWebhooksConfigRequestsDto and cannot be null");
            }
            this.Uri = uri;
            this.SecretKey = secretKey;
            this.Enabled = enabled;
            this.Ssl = ssl;
            this.Triggers = triggers;
            this.TargetId = targetId;
        }

        /// <summary>
        /// The label the subscription is listed under. It is for the administrator reading the list and is never sent to  the target; it does not have to be unique.
        /// </summary>
        /// <example>Production Webhook</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The address the portal posts the event payload to. It has to be an absolute &#x60;http&#x60; or &#x60;https&#x60; address outside  the installation own network, and it is probed before anything is stored: it must answer a HEAD request with  a success code, and a redirect does not count as one.
        /// </summary>
        /// <example>https://example.com/webhook</example>
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// The shared secret the payload signature is computed with, so the receiver can tell a genuine call from a  forged one. It has to satisfy the portal password rules published by  &#x60;GET api/2.0/settings/security/password&#x60;, and it is never echoed back by any operation. On an update an empty  value keeps the secret already stored.
        /// </summary>
        /// <example>my-secret-key-123</example>
        [DataMember(Name = "secretKey", EmitDefaultValue = true)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Whether the subscription delivers at all. While it is off the matching events are dropped rather than queued,  so nothing from that period arrives once it is switched on again.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether the target certificate is verified. Setting it demands an &#x60;https&#x60; target with a valid certificate;  leaving it off delivers without checking the certificate at all.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "ssl", EmitDefaultValue = true)]
        public bool Ssl { get; set; }

        /// <summary>
        /// The single entity the subscription is narrowed to, by its identifier - a room or a file, for instance.  Leaving it out delivers events about every entity the subscribed triggers cover.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000001</example>
        [DataMember(Name = "targetId", EmitDefaultValue = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWebhooksConfigRequestsDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Ssl: ").Append(Ssl).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // Uri (string) minLength
            if (this.Uri != null && this.Uri.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Uri, length must be greater than 1.", new [] { "Uri" });
            }

            // SecretKey (string) maxLength
            if (this.SecretKey != null && this.SecretKey.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecretKey, length must be less than 50.", new [] { "SecretKey" });
            }

            // SecretKey (string) minLength
            if (this.SecretKey != null && this.SecretKey.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecretKey, length must be greater than 0.", new [] { "SecretKey" });
            }

            // TargetId (string) maxLength
            if (this.TargetId != null && this.TargetId.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TargetId, length must be less than 255.", new [] { "TargetId" });
            }

            // TargetId (string) minLength
            if (this.TargetId != null && this.TargetId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TargetId, length must be greater than 0.", new [] { "TargetId" });
            }

            yield break;
        }

    }


}
