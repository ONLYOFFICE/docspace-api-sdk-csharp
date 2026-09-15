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
    /// A third-party storage account connected to the portal.
    /// </summary>
    [DataContract(Name = "ThirdPartyParams")]
    public partial class ThirdPartyParams : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyParams" /> class.
        /// </summary>
        /// <param name="authData">The stored credentials of the account. They are not filled in here: the portal does not give back credentials  once an account is saved..</param>
        /// <param name="corporate">Whether the account is attached to the legacy Common section, which is the case only for accounts inherited  from an older portal..</param>
        /// <param name="roomsStorage">Whether the account is attached to the Rooms section, room templates and the archive counted in. This is where  &#x60;POST api/2.0/files/thirdparty&#x60; puts every account it connects..</param>
        /// <param name="customerTitle">The name the account is shown under in the portal, as it was saved when the account was connected..</param>
        /// <param name="providerId">The account ID to send to &#x60;DELETE api/2.0/files/thirdparty/{providerId}&#x60;, or as &#x60;providerId&#x60; to  re-authenticate the account..</param>
        /// <param name="providerKey">The storage service behind the account. &#x60;WebDav&#x60; stands for every WebDAV preset, so it does not tell which of  them was chosen when the account was connected..</param>
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
        /// The stored credentials of the account. They are not filled in here: the portal does not give back credentials  once an account is saved.
        /// </summary>
        [DataMember(Name = "auth_data", EmitDefaultValue = false)]
        public AuthData AuthData { get; set; }

        /// <summary>
        /// Whether the account is attached to the legacy Common section, which is the case only for accounts inherited  from an older portal.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "corporate", EmitDefaultValue = true)]
        public bool Corporate { get; set; }

        /// <summary>
        /// Whether the account is attached to the Rooms section, room templates and the archive counted in. This is where  &#x60;POST api/2.0/files/thirdparty&#x60; puts every account it connects.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "roomsStorage", EmitDefaultValue = true)]
        public bool RoomsStorage { get; set; }

        /// <summary>
        /// The name the account is shown under in the portal, as it was saved when the account was connected.
        /// </summary>
        /// <example>Nextcloud storage</example>
        [DataMember(Name = "customer_title", EmitDefaultValue = true)]
        public string CustomerTitle { get; set; }

        /// <summary>
        /// The account ID to send to &#x60;DELETE api/2.0/files/thirdparty/{providerId}&#x60;, or as &#x60;providerId&#x60; to  re-authenticate the account.
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "provider_id", EmitDefaultValue = true)]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The storage service behind the account. &#x60;WebDav&#x60; stands for every WebDAV preset, so it does not tell which of  them was chosen when the account was connected.
        /// </summary>
        /// <example>WebDav</example>
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
