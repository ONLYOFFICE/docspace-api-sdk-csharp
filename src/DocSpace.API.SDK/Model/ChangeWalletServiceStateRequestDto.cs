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
    /// The request parameters for changing the tenant wallet service state.
    /// </summary>
    [DataContract(Name = "ChangeWalletServiceStateRequestDto")]
    public partial class ChangeWalletServiceStateRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", EmitDefaultValue = false)]
        public TenantWalletService? Service { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeWalletServiceStateRequestDto" /> class.
        /// </summary>
        /// <param name="service">service.</param>
        /// <param name="enabled">Specifies whether the wallet service is enabled..</param>
        public ChangeWalletServiceStateRequestDto(TenantWalletService? service = default, bool enabled = default)
        {
            this.Service = service;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Specifies whether the wallet service is enabled.
        /// </summary>
        /// <value>Specifies whether the wallet service is enabled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeWalletServiceStateRequestDto {\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
