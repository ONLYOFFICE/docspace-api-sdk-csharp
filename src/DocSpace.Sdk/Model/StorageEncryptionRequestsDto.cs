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
    /// The request parameters for managing storage encryption operations and notifications.
    /// </summary>
    [DataContract(Name = "StorageEncryptionRequestsDto")]
    public partial class StorageEncryptionRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageEncryptionRequestsDto" /> class.
        /// </summary>
        /// <param name="notifyUsers">Specifies whether the users receive notifications about the storage encryption operations..</param>
        public StorageEncryptionRequestsDto(bool notifyUsers = default)
        {
            this.NotifyUsers = notifyUsers;
        }

        /// <summary>
        /// Specifies whether the users receive notifications about the storage encryption operations.
        /// </summary>
        /// <value>Specifies whether the users receive notifications about the storage encryption operations.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "notifyUsers", EmitDefaultValue = true)]
        public bool NotifyUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageEncryptionRequestsDto {\n");
            sb.Append("  NotifyUsers: ").Append(NotifyUsers).Append("\n");
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
