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
        /// <param name="id">The API key unique identifier. (required).</param>
        /// <param name="name">The API key name. (required).</param>
        /// <param name="key">The full API key value (only returned when creating a new key). (required).</param>
        /// <param name="keyPostfix">The API key postfix (used for identification)..</param>
        /// <param name="permissions">The list of permissions granted to the API key. (required).</param>
        /// <param name="lastUsed">The date and time when the API key was last used..</param>
        /// <param name="createOn">The date and time when the API key was created..</param>
        /// <param name="createBy">The identifier of the user who created the API key..</param>
        /// <param name="expiresAt">The date and time when the API key expires..</param>
        /// <param name="isActive">Indicates whether the API key is active or not. (required).</param>
        public ApiKeyResponseDto(Guid id = default, string name = default, string key = default, string keyPostfix = default, List<string> permissions = default, DateTime? lastUsed = default, DateTime? createOn = default, EmployeeDto createBy = default, DateTime? expiresAt = default, bool isActive = default)
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
        /// The API key unique identifier.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// The API key name.
        /// </summary>
        /// <example>My API Key</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The full API key value (only returned when creating a new key).
        /// </summary>
        /// <example>api_key_1234567890abcdef</example>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The API key postfix (used for identification).
        /// </summary>
        /// <example>...cdef</example>
        [DataMember(Name = "keyPostfix", EmitDefaultValue = true)]
        public string KeyPostfix { get; set; }

        /// <summary>
        /// The list of permissions granted to the API key.
        /// </summary>
        /// <example>["read","write","delete"]</example>
        [DataMember(Name = "permissions", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// The date and time when the API key was last used.
        /// </summary>
        /// <example>2025-06-15T10:30:00.0000000Z</example>
        [DataMember(Name = "lastUsed", EmitDefaultValue = true)]
        public DateTime? LastUsed { get; set; }

        /// <summary>
        /// The date and time when the API key was created.
        /// </summary>
        /// <example>2025-06-15T10:30:00.0000000Z</example>
        [DataMember(Name = "createOn", EmitDefaultValue = true)]
        public DateTime? CreateOn { get; set; }

        /// <summary>
        /// The identifier of the user who created the API key.
        /// </summary>
        [DataMember(Name = "createBy", EmitDefaultValue = false)]
        public EmployeeDto CreateBy { get; set; }

        /// <summary>
        /// The date and time when the API key expires.
        /// </summary>
        /// <example>2025-06-15T10:30:00.0000000Z</example>
        [DataMember(Name = "expiresAt", EmitDefaultValue = true)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Indicates whether the API key is active or not.
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
