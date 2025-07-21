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
    /// The request parameters for initial configuration of the setup wizard.
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
        /// <param name="email">The user&#39;s email address for authentication and communication. (required).</param>
        /// <param name="passwordHash">The hashed representation of the user&#39;s password. (required).</param>
        /// <param name="lng">The user&#39;s preferred interface language code..</param>
        /// <param name="timeZone">The user&#39;s time zone identifier..</param>
        /// <param name="amiId">The Amazon Machine Image (AMI) identifier..</param>
        /// <param name="subscribeFromSite">Specifies whether the user opted in for site communications..</param>
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
        /// The user&#39;s email address for authentication and communication.
        /// </summary>
        /// <value>The user&#39;s email address for authentication and communication.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The hashed representation of the user&#39;s password.
        /// </summary>
        /// <value>The hashed representation of the user&#39;s password.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "passwordHash", IsRequired = true, EmitDefaultValue = true)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// The user&#39;s preferred interface language code.
        /// </summary>
        /// <value>The user&#39;s preferred interface language code.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "lng", EmitDefaultValue = true)]
        public string Lng { get; set; }

        /// <summary>
        /// The user&#39;s time zone identifier.
        /// </summary>
        /// <value>The user&#39;s time zone identifier.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public string @TimeZone { get; set; }

        /// <summary>
        /// The Amazon Machine Image (AMI) identifier.
        /// </summary>
        /// <value>The Amazon Machine Image (AMI) identifier.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "amiId", EmitDefaultValue = true)]
        public string AmiId { get; set; }

        /// <summary>
        /// Specifies whether the user opted in for site communications.
        /// </summary>
        /// <value>Specifies whether the user opted in for site communications.</value>
        /*
        <example>true</example>
        */
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
