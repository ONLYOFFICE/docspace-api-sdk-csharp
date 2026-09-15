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
    /// What the initial setup wizard needs to finish a new portal: the owner credentials and the portal locale.
    /// </summary>
    [DataContract(Name = "WizardRequestsDto")]
    public partial class WizardRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WizardRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WizardRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WizardRequestsDto" /> class.
        /// </summary>
        /// <param name="email">The address the portal owner account is created with, which is also the address every administrative letter  goes to afterwards. It has to be a well-formed email address; a malformed one leaves the wizard unfinished. (required).</param>
        /// <param name="passwordHash">The owner password, already hashed in the client rather than sent in the clear. Hash it with the &#x60;salt&#x60;,  iteration count and hash size that &#x60;GET api/2.0/settings?withpassword&#x3D;true&#x60; publishes, so the portal can  recognise it later; an empty value leaves the wizard unfinished. (required).</param>
        /// <param name="lng">The portal interface language, as a culture name such as &#x60;en-US&#x60;. It has to be one of the cultures enabled  for the installation, and an unknown one leaves the shipped default in place instead of failing the wizard..</param>
        /// <param name="timeZone">The time zone every portal date is rendered in, as an IANA identifier such as &#x60;Europe/Riga&#x60;. A value that  matches nothing falls back to UTC rather than failing the wizard..</param>
        /// <param name="amiId">The identifier of the Amazon Machine Image the portal was launched from, for an installation started from an  AWS image. It is recorded for the installation record only and changes nothing about the portal; leave it out  anywhere else..</param>
        /// <param name="subscribeFromSite">Whether the owner agrees to receive product news at the address in &#x60;email&#x60;. It is a mailing consent and has  no bearing on the portal notifications, which are subscribed separately..</param>
        public WizardRequestsDto(string email = default, string passwordHash = default, string lng = default, string timeZone = default, string amiId = default, bool subscribeFromSite = default)
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for WizardRequestsDto and cannot be null");
            }
            this.Email = email;
            // to ensure "passwordHash" is required (not null)
            if (passwordHash == null)
            {
                throw new ArgumentNullException("passwordHash is a required property for WizardRequestsDto and cannot be null");
            }
            this.PasswordHash = passwordHash;
            this.Lng = lng;
            this.@TimeZone = timeZone;
            this.AmiId = amiId;
            this.SubscribeFromSite = subscribeFromSite;
        }

        /// <summary>
        /// The address the portal owner account is created with, which is also the address every administrative letter  goes to afterwards. It has to be a well-formed email address; a malformed one leaves the wizard unfinished.
        /// </summary>
        /// <example>user@example.com</example>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The owner password, already hashed in the client rather than sent in the clear. Hash it with the &#x60;salt&#x60;,  iteration count and hash size that &#x60;GET api/2.0/settings?withpassword&#x3D;true&#x60; publishes, so the portal can  recognise it later; an empty value leaves the wizard unfinished.
        /// </summary>
        /// <example>2DYmIoA/aYKEksFocEf6uw==</example>
        [DataMember(Name = "passwordHash", IsRequired = true, EmitDefaultValue = true)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// The portal interface language, as a culture name such as &#x60;en-US&#x60;. It has to be one of the cultures enabled  for the installation, and an unknown one leaves the shipped default in place instead of failing the wizard.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "lng", EmitDefaultValue = true)]
        public string Lng { get; set; }

        /// <summary>
        /// The time zone every portal date is rendered in, as an IANA identifier such as &#x60;Europe/Riga&#x60;. A value that  matches nothing falls back to UTC rather than failing the wizard.
        /// </summary>
        /// <example>UTC</example>
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public string @TimeZone { get; set; }

        /// <summary>
        /// The identifier of the Amazon Machine Image the portal was launched from, for an installation started from an  AWS image. It is recorded for the installation record only and changes nothing about the portal; leave it out  anywhere else.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000001</example>
        [DataMember(Name = "amiId", EmitDefaultValue = true)]
        public string AmiId { get; set; }

        /// <summary>
        /// Whether the owner agrees to receive product news at the address in &#x60;email&#x60;. It is a mailing consent and has  no bearing on the portal notifications, which are subscribed separately.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "subscribeFromSite", EmitDefaultValue = true)]
        public bool SubscribeFromSite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WizardRequestsDto {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PasswordHash: ").Append(PasswordHash).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
            sb.Append("  @TimeZone: ").Append(@TimeZone).Append("\n");
            sb.Append("  AmiId: ").Append(AmiId).Append("\n");
            sb.Append("  SubscribeFromSite: ").Append(SubscribeFromSite).Append("\n");
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
