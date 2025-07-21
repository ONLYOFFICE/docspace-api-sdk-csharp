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
    /// The Firebase user parameters.
    /// </summary>
    [DataContract(Name = "FireBaseUser")]
    public partial class FireBaseUser : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FireBaseUser" /> class.
        /// </summary>
        /// <param name="id">The Firebase user ID..</param>
        /// <param name="userId">The user ID..</param>
        /// <param name="tenantId">The tenant ID..</param>
        /// <param name="firebaseDeviceToken">The Firebase device token..</param>
        /// <param name="application">The Firebase application..</param>
        /// <param name="isSubscribed">Specifies if the user is subscribed to the push notifications or not..</param>
        /// <param name="tenant">tenant.</param>
        public FireBaseUser(int id = default, Guid userId = default, int tenantId = default, string firebaseDeviceToken = default, string application = default, bool? isSubscribed = default, DbTenant tenant = default)
        {
            this.Id = id;
            this.UserId = userId;
            this.TenantId = tenantId;
            this.FirebaseDeviceToken = firebaseDeviceToken;
            this.Application = application;
            this.IsSubscribed = isSubscribed;
            this.Tenant = tenant;
        }

        /// <summary>
        /// The Firebase user ID.
        /// </summary>
        /// <value>The Firebase user ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

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
        /// The Firebase device token.
        /// </summary>
        /// <value>The Firebase device token.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "firebaseDeviceToken", EmitDefaultValue = true)]
        public string FirebaseDeviceToken { get; set; }

        /// <summary>
        /// The Firebase application.
        /// </summary>
        /// <value>The Firebase application.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "application", EmitDefaultValue = true)]
        public string Application { get; set; }

        /// <summary>
        /// Specifies if the user is subscribed to the push notifications or not.
        /// </summary>
        /// <value>Specifies if the user is subscribed to the push notifications or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isSubscribed", EmitDefaultValue = true)]
        public bool? IsSubscribed { get; set; }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name = "tenant", EmitDefaultValue = false)]
        public DbTenant Tenant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireBaseUser {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  FirebaseDeviceToken: ").Append(FirebaseDeviceToken).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  IsSubscribed: ").Append(IsSubscribed).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
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
            // FirebaseDeviceToken (string) maxLength
            if (this.FirebaseDeviceToken != null && this.FirebaseDeviceToken.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirebaseDeviceToken, length must be less than 255.", new [] { "FirebaseDeviceToken" });
            }

            // Application (string) maxLength
            if (this.Application != null && this.Application.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Application, length must be less than 20.", new [] { "Application" });
            }

            yield break;
        }
    }


}
