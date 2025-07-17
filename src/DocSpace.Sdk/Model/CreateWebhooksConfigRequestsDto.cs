/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The request parameters for creating the webhook configuration.
    /// </summary>
    [DataContract(Name = "CreateWebhooksConfigRequestsDto")]
    public partial class CreateWebhooksConfigRequestsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Triggers
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
        /// <param name="name">The human-readable name of the webhook configuration. (required).</param>
        /// <param name="uri">The destination URL where the webhook events will be sent. (required).</param>
        /// <param name="secretKey">The webhook secret key used to sign the webhook payloads for the security verification..</param>
        /// <param name="enabled">Specifies whether the webhook configuration is active or not..</param>
        /// <param name="ssl">Specifies whether the SSL certificate verification is required or not..</param>
        /// <param name="triggers">triggers.</param>
        /// <param name="targetId">Target ID.</param>
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
        /// The human-readable name of the webhook configuration.
        /// </summary>
        /// <value>The human-readable name of the webhook configuration.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The destination URL where the webhook events will be sent.
        /// </summary>
        /// <value>The destination URL where the webhook events will be sent.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uri", IsRequired = true, EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// The webhook secret key used to sign the webhook payloads for the security verification.
        /// </summary>
        /// <value>The webhook secret key used to sign the webhook payloads for the security verification.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "secretKey", EmitDefaultValue = true)]
        public string SecretKey { get; set; }

        /// <summary>
        /// Specifies whether the webhook configuration is active or not.
        /// </summary>
        /// <value>Specifies whether the webhook configuration is active or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Specifies whether the SSL certificate verification is required or not.
        /// </summary>
        /// <value>Specifies whether the SSL certificate verification is required or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "ssl", EmitDefaultValue = true)]
        public bool Ssl { get; set; }

        /// <summary>
        /// Target ID
        /// </summary>
        /// <value>Target ID</value>
        /*
        <example>some text</example>
        */
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

            yield break;
        }
    }


}
