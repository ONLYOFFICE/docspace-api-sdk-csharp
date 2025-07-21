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
    /// The provider information.
    /// </summary>
    [DataContract(Name = "ProviderDto")]
    public partial class ProviderDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderDto" /> class.
        /// </summary>
        /// <param name="name">The provider name..</param>
        /// <param name="key">The provider key..</param>
        /// <param name="connected">Specifies whether the provider is connected..</param>
        /// <param name="oauth">Specifies if the provider is OAuth..</param>
        /// <param name="redirectUrl">The provider redirect URL..</param>
        /// <param name="requiredConnectionUrl">The required connection URL flag..</param>
        /// <param name="clientId">The provider OAuth client ID..</param>
        public ProviderDto(string name = default, string key = default, bool connected = default, bool oauth = default, string redirectUrl = default, bool requiredConnectionUrl = default, string clientId = default)
        {
            this.Name = name;
            this.Key = key;
            this.Connected = connected;
            this.Oauth = oauth;
            this.RedirectUrl = redirectUrl;
            this.RequiredConnectionUrl = requiredConnectionUrl;
            this.ClientId = clientId;
        }

        /// <summary>
        /// The provider name.
        /// </summary>
        /// <value>The provider name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The provider key.
        /// </summary>
        /// <value>The provider key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Specifies whether the provider is connected.
        /// </summary>
        /// <value>Specifies whether the provider is connected.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "connected", EmitDefaultValue = true)]
        public bool Connected { get; set; }

        /// <summary>
        /// Specifies if the provider is OAuth.
        /// </summary>
        /// <value>Specifies if the provider is OAuth.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "oauth", EmitDefaultValue = true)]
        public bool Oauth { get; set; }

        /// <summary>
        /// The provider redirect URL.
        /// </summary>
        /// <value>The provider redirect URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "redirectUrl", EmitDefaultValue = true)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// The required connection URL flag.
        /// </summary>
        /// <value>The required connection URL flag.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "requiredConnectionUrl", EmitDefaultValue = true)]
        public bool RequiredConnectionUrl { get; set; }

        /// <summary>
        /// The provider OAuth client ID.
        /// </summary>
        /// <value>The provider OAuth client ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "clientId", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProviderDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Connected: ").Append(Connected).Append("\n");
            sb.Append("  Oauth: ").Append(Oauth).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  RequiredConnectionUrl: ").Append(RequiredConnectionUrl).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
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
