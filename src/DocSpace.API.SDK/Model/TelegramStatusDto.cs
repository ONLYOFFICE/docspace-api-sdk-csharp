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
    /// TelegramStatusDto
    /// </summary>
    [DataContract(Name = "TelegramStatusDto")]
    public partial class TelegramStatusDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public RegStatus Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegramStatusDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TelegramStatusDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TelegramStatusDto" /> class.
        /// </summary>
        /// <param name="status">status (required).</param>
        /// <param name="username">username.</param>
        public TelegramStatusDto(RegStatus status = default, string username = default)
        {
            this.Status = status;
            this.Username = username;
        }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "username", EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TelegramStatusDto {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
