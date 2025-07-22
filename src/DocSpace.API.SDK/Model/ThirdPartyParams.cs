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
    /// The third-party account parameters.
    /// </summary>
    [DataContract(Name = "ThirdPartyParams")]
    public partial class ThirdPartyParams : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyParams" /> class.
        /// </summary>
        /// <param name="authData">authData.</param>
        /// <param name="corporate">Specifies if this is a corporate account or not..</param>
        /// <param name="roomsStorage">Specifies if this is a room storage or not..</param>
        /// <param name="customerTitle">The customer title..</param>
        /// <param name="providerId">The provider ID..</param>
        /// <param name="providerKey">The provider key..</param>
        public ThirdPartyParams(AuthData authData = default, bool corporate = default, bool roomsStorage = default, string customerTitle = default, int? providerId = default, string providerKey = default)
        {
            this.AuthData = authData;
            this.Corporate = corporate;
            this.RoomsStorage = roomsStorage;
            this.CustomerTitle = customerTitle;
            this.ProviderId = providerId;
            this.ProviderKey = providerKey;
        }

        /// <summary>
        /// Gets or Sets AuthData
        /// </summary>
        [DataMember(Name = "auth_data", EmitDefaultValue = false)]
        public AuthData AuthData { get; set; }

        /// <summary>
        /// Specifies if this is a corporate account or not.
        /// </summary>
        /// <value>Specifies if this is a corporate account or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "corporate", EmitDefaultValue = true)]
        public bool Corporate { get; set; }

        /// <summary>
        /// Specifies if this is a room storage or not.
        /// </summary>
        /// <value>Specifies if this is a room storage or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "roomsStorage", EmitDefaultValue = true)]
        public bool RoomsStorage { get; set; }

        /// <summary>
        /// The customer title.
        /// </summary>
        /// <value>The customer title.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "customer_title", EmitDefaultValue = true)]
        public string CustomerTitle { get; set; }

        /// <summary>
        /// The provider ID.
        /// </summary>
        /// <value>The provider ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "provider_id", EmitDefaultValue = true)]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The provider key.
        /// </summary>
        /// <value>The provider key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "provider_key", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThirdPartyParams {\n");
            sb.Append("  AuthData: ").Append(AuthData).Append("\n");
            sb.Append("  Corporate: ").Append(Corporate).Append("\n");
            sb.Append("  RoomsStorage: ").Append(RoomsStorage).Append("\n");
            sb.Append("  CustomerTitle: ").Append(CustomerTitle).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProviderKey: ").Append(ProviderKey).Append("\n");
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
