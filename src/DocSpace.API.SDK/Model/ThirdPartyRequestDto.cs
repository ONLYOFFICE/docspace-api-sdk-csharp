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
    /// The credentials and the title of a third-party storage account to connect or to re-authenticate.
    /// </summary>
    [DataContract(Name = "ThirdPartyRequestDto")]
    public partial class ThirdPartyRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ThirdPartyRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyRequestDto" /> class.
        /// </summary>
        /// <param name="url">The address of the storage server to connect to. It is needed by the WebDAV presets whose server is not known  in advance (&#x60;WebDav&#x60;, &#x60;Nextcloud&#x60;, &#x60;ownCloud&#x60;), where it points at the WebDAV endpoint of that server, and by  &#x60;SharePoint&#x60;; the presets with a fixed address and the OAuth services ignore it..</param>
        /// <param name="login">The account name at the storage service, used by the services that authenticate by login and password. A login  sent without a password is rejected as an invalid request..</param>
        /// <param name="password">The password, or the application password, for &#x60;login&#x60; at the storage service. Either this or &#x60;token&#x60; has to  be sent, and the credentials are verified against the service before the account is saved..</param>
        /// <param name="token">The OAuth 2.0 authorization code from the consent screen of &#x60;Box&#x60;, &#x60;DropboxV2&#x60;, &#x60;GoogleDrive&#x60; or &#x60;OneDrive&#x60; -  not an access token: the portal exchanges the code for its own token and keeps that. The client ID and  redirect URL the consent screen URL is built from come from &#x60;GET api/2.0/files/thirdparty/capabilities&#x60;..</param>
        /// <param name="customerTitle">The name the connected account is shown under in the portal. Characters that a folder title cannot hold are  replaced and the value is truncated, and a title that comes out of that empty is refused. (required).</param>
        /// <param name="providerKey">The storage service to connect, as the &#x60;key&#x60; of &#x60;GET api/2.0/files/thirdparty/providers&#x60;; the value is matched  case-insensitively. &#x60;Nextcloud&#x60; and &#x60;ownCloud&#x60; are presets over WebDAV and are stored and reported back as  &#x60;WebDav&#x60;. (required).</param>
        /// <param name="providerId">The account to re-authenticate instead of connecting a new one, as &#x60;providerId&#x60; of  &#x60;GET api/2.0/files/thirdparty&#x60;; both a number and its decimal string form are accepted. For an account  attached to the Rooms section only the credentials are applied, and its title and server address are kept..</param>
        public ThirdPartyRequestDto(string url = default, string login = default, string password = default, string token = default, string customerTitle = default, string providerKey = default, int? providerId = default)
        {
            // to ensure "customerTitle" is required (not null)
            if (customerTitle == null)
            {
                throw new ArgumentNullException("customerTitle is a required property for ThirdPartyRequestDto and cannot be null");
            }
            this.CustomerTitle = customerTitle;
            // to ensure "providerKey" is required (not null)
            if (providerKey == null)
            {
                throw new ArgumentNullException("providerKey is a required property for ThirdPartyRequestDto and cannot be null");
            }
            this.ProviderKey = providerKey;
            this.Url = url;
            this.Login = login;
            this.Password = password;
            this.Token = token;
            this.ProviderId = providerId;
        }

        /// <summary>
        /// The address of the storage server to connect to. It is needed by the WebDAV presets whose server is not known  in advance (&#x60;WebDav&#x60;, &#x60;Nextcloud&#x60;, &#x60;ownCloud&#x60;), where it points at the WebDAV endpoint of that server, and by  &#x60;SharePoint&#x60;; the presets with a fixed address and the OAuth services ignore it.
        /// </summary>
        /// <example>https://cloud.example.com/remote.php/dav/files/admin/</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The account name at the storage service, used by the services that authenticate by login and password. A login  sent without a password is rejected as an invalid request.
        /// </summary>
        /// <example>admin</example>
        [DataMember(Name = "login", EmitDefaultValue = true)]
        public string Login { get; set; }

        /// <summary>
        /// The password, or the application password, for &#x60;login&#x60; at the storage service. Either this or &#x60;token&#x60; has to  be sent, and the credentials are verified against the service before the account is saved.
        /// </summary>
        /// <example>p@ssw0rd!</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The OAuth 2.0 authorization code from the consent screen of &#x60;Box&#x60;, &#x60;DropboxV2&#x60;, &#x60;GoogleDrive&#x60; or &#x60;OneDrive&#x60; -  not an access token: the portal exchanges the code for its own token and keeps that. The client ID and  redirect URL the consent screen URL is built from come from &#x60;GET api/2.0/files/thirdparty/capabilities&#x60;.
        /// </summary>
        /// <example>4/0AY0e-g5Tn8vQrM2kZs7xB1pLd9</example>
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// The name the connected account is shown under in the portal. Characters that a folder title cannot hold are  replaced and the value is truncated, and a title that comes out of that empty is refused.
        /// </summary>
        /// <example>Nextcloud storage</example>
        [DataMember(Name = "customerTitle", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerTitle { get; set; }

        /// <summary>
        /// The storage service to connect, as the &#x60;key&#x60; of &#x60;GET api/2.0/files/thirdparty/providers&#x60;; the value is matched  case-insensitively. &#x60;Nextcloud&#x60; and &#x60;ownCloud&#x60; are presets over WebDAV and are stored and reported back as  &#x60;WebDav&#x60;.
        /// </summary>
        /// <example>Nextcloud</example>
        [DataMember(Name = "providerKey", IsRequired = true, EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// The account to re-authenticate instead of connecting a new one, as &#x60;providerId&#x60; of  &#x60;GET api/2.0/files/thirdparty&#x60;; both a number and its decimal string form are accepted. For an account  attached to the Rooms section only the credentials are applied, and its title and server address are kept.
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "providerId", EmitDefaultValue = true)]
        public int? ProviderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThirdPartyRequestDto {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  CustomerTitle: ").Append(CustomerTitle).Append("\n");
            sb.Append("  ProviderKey: ").Append(ProviderKey).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
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
