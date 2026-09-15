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
    /// The response data for the API key operations.
    /// </summary>
    [DataContract(Name = "ApiKeyResponseDto")]
    public partial class ApiKeyResponseDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiKeyResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponseDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the key. This is the value to pass to &#x60;PUT api/2.0/keys/{keyId}&#x60; and  &#x60;DELETE api/2.0/keys/{keyId}&#x60;. (required).</param>
        /// <param name="name">The label given to the key when it was created or last updated. (required).</param>
        /// <param name="key">The secret to send in the &#x60;Authorization&#x60; header as &#x60;Bearer sk-...&#x60;. It is filled in only by the answer of  &#x60;POST api/2.0/keys&#x60; and cannot be read again afterwards, so it has to be stored at that moment. (required).</param>
        /// <param name="keyPostfix">The last four characters of the secret. It is the only part of the secret that later reads expose, and it is  meant for telling keys apart in a list..</param>
        /// <param name="permissions">The scopes the key may use, as accepted by &#x60;GET api/2.0/keys/permissions&#x60;. An empty list means the key has no  scope restrictions. (required).</param>
        /// <param name="lastUsed">The UTC moment the key was last used to authenticate a request. It is empty for a key that has never been  used..</param>
        /// <param name="createOn">The UTC moment the key was created..</param>
        /// <param name="createBy">The portal member who created the key, and whose access the key acts with..</param>
        /// <param name="expiresAt">The UTC moment the key stops working. It is empty for a key created without &#x60;expiresInDays&#x60;, which never  expires..</param>
        /// <param name="isActive">Whether the key may authenticate requests. A key deactivated through &#x60;PUT api/2.0/keys/{keyId}&#x60; stays in the  list with this field set to false. (required).</param>
        public ApiKeyResponseDto(Guid id = default, string name = default, string key = default, string keyPostfix = default, List<string> permissions = default, ApiDateTime lastUsed = default, ApiDateTime createOn = default, EmployeeDto createBy = default, ApiDateTime expiresAt = default, bool isActive = default)
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ApiKeyResponseDto and cannot be null");
            }
            this.Name = name;
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for ApiKeyResponseDto and cannot be null");
            }
            this.Key = key;
            // to ensure "permissions" is required (not null)
            if (permissions == null)
            {
                throw new ArgumentNullException("permissions is a required property for ApiKeyResponseDto and cannot be null");
            }
            this.Permissions = permissions;
            this.IsActive = isActive;
            this.KeyPostfix = keyPostfix;
            this.LastUsed = lastUsed;
            this.CreateOn = createOn;
            this.CreateBy = createBy;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// The ID of the key. This is the value to pass to &#x60;PUT api/2.0/keys/{keyId}&#x60; and  &#x60;DELETE api/2.0/keys/{keyId}&#x60;.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// The label given to the key when it was created or last updated.
        /// </summary>
        /// <example>My API Key</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The secret to send in the &#x60;Authorization&#x60; header as &#x60;Bearer sk-...&#x60;. It is filled in only by the answer of  &#x60;POST api/2.0/keys&#x60; and cannot be read again afterwards, so it has to be stored at that moment.
        /// </summary>
        /// <example>sk-0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</example>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The last four characters of the secret. It is the only part of the secret that later reads expose, and it is  meant for telling keys apart in a list.
        /// </summary>
        /// <example>cdef</example>
        [DataMember(Name = "keyPostfix", EmitDefaultValue = true)]
        public string KeyPostfix { get; set; }

        /// <summary>
        /// The scopes the key may use, as accepted by &#x60;GET api/2.0/keys/permissions&#x60;. An empty list means the key has no  scope restrictions.
        /// </summary>
        /// <example>["rooms:read","files:write"]</example>
        [DataMember(Name = "permissions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// The UTC moment the key was last used to authenticate a request. It is empty for a key that has never been  used.
        /// </summary>
        [DataMember(Name = "lastUsed", EmitDefaultValue = false)]
        public ApiDateTime LastUsed { get; set; }

        /// <summary>
        /// The UTC moment the key was created.
        /// </summary>
        [DataMember(Name = "createOn", EmitDefaultValue = false)]
        public ApiDateTime CreateOn { get; set; }

        /// <summary>
        /// The portal member who created the key, and whose access the key acts with.
        /// </summary>
        [DataMember(Name = "createBy", EmitDefaultValue = false)]
        public EmployeeDto CreateBy { get; set; }

        /// <summary>
        /// The UTC moment the key stops working. It is empty for a key created without &#x60;expiresInDays&#x60;, which never  expires.
        /// </summary>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public ApiDateTime ExpiresAt { get; set; }

        /// <summary>
        /// Whether the key may authenticate requests. A key deactivated through &#x60;PUT api/2.0/keys/{keyId}&#x60; stays in the  list with this field set to false.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isActive", IsRequired = true, EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiKeyResponseDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  KeyPostfix: ").Append(KeyPostfix).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
            sb.Append("  CreateOn: ").Append(CreateOn).Append("\n");
            sb.Append("  CreateBy: ").Append(CreateBy).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
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
