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
    /// One storage service this portal can connect, with the values a connection form needs.
    /// </summary>
    [DataContract(Name = "ProviderDto")]
    public partial class ProviderDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderDto" /> class.
        /// </summary>
        /// <param name="name">The display name of the service, and the only thing that tells the WebDAV presets apart: &#x60;kDrive&#x60;, &#x60;Yandex&#x60;,  &#x60;WebDav&#x60;, &#x60;Nextcloud&#x60; and &#x60;ownCloud&#x60; all report the same key..</param>
        /// <param name="key">The value to send as &#x60;providerKey&#x60; when an account of this service is connected..</param>
        /// <param name="connected">Whether the service can be used on this portal: it is enabled in the configuration and, for an OAuth service,  its application is registered. It says nothing about whether an account of it is connected..</param>
        /// <param name="oauth">Whether an account of this service is connected with an OAuth 2.0 authorization code in &#x60;token&#x60;; when false,  it is connected with &#x60;login&#x60; and &#x60;password&#x60;..</param>
        /// <param name="redirectUrl">The redirect URL this portal is registered with at the service, to build the consent screen URL from. It comes  back as null for the services that do not use OAuth..</param>
        /// <param name="requiredConnectionUrl">Whether an account of this service cannot be connected without &#x60;url&#x60;, which is the case for the WebDAV servers  whose address is not known in advance. The presets with a fixed address and the OAuth services do not need it..</param>
        /// <param name="clientId">The OAuth 2.0 client ID this portal is registered with at the service, to build the consent screen URL from.  It comes back as null for the services that do not use OAuth..</param>
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
        /// The display name of the service, and the only thing that tells the WebDAV presets apart: &#x60;kDrive&#x60;, &#x60;Yandex&#x60;,  &#x60;WebDav&#x60;, &#x60;Nextcloud&#x60; and &#x60;ownCloud&#x60; all report the same key.
        /// </summary>
        /// <example>Nextcloud</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The value to send as &#x60;providerKey&#x60; when an account of this service is connected.
        /// </summary>
        /// <example>WebDav</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Whether the service can be used on this portal: it is enabled in the configuration and, for an OAuth service,  its application is registered. It says nothing about whether an account of it is connected.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "connected", EmitDefaultValue = true)]
        public bool Connected { get; set; }

        /// <summary>
        /// Whether an account of this service is connected with an OAuth 2.0 authorization code in &#x60;token&#x60;; when false,  it is connected with &#x60;login&#x60; and &#x60;password&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "oauth", EmitDefaultValue = true)]
        public bool Oauth { get; set; }

        /// <summary>
        /// The redirect URL this portal is registered with at the service, to build the consent screen URL from. It comes  back as null for the services that do not use OAuth.
        /// </summary>
        /// <example>https://example.com/thirdparty</example>
        [DataMember(Name = "redirectUrl", EmitDefaultValue = true)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Whether an account of this service cannot be connected without &#x60;url&#x60;, which is the case for the WebDAV servers  whose address is not known in advance. The presets with a fixed address and the OAuth services do not need it.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "requiredConnectionUrl", EmitDefaultValue = true)]
        public bool RequiredConnectionUrl { get; set; }

        /// <summary>
        /// The OAuth 2.0 client ID this portal is registered with at the service, to build the consent screen URL from.  It comes back as null for the services that do not use OAuth.
        /// </summary>
        /// <example>l1s2h3d4f5g6h7j8k9l0</example>
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
