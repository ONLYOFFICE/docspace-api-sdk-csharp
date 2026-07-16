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
    /// The wallet services settings.
    /// </summary>
    [DataContract(Name = "TenantWalletServiceSettings")]
    public partial class TenantWalletServiceSettings : IValidatableObject
    {
        /// <summary>
        /// The list of the enabled wallet services.
        /// </summary>
        /// <value>The list of the enabled wallet services.</value>
        public enum EnabledServicesEnum
        {
            /// <summary>
            /// Enum AITools for value: -13
            /// </summary>
            AITools = -13,

            /// <summary>
            /// Enum Backup for value: -12
            /// </summary>
            Backup = -12,

            /// <summary>
            /// Enum Storage for value: -11
            /// </summary>
            Storage = -11
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantWalletServiceSettings" /> class.
        /// </summary>
        /// <param name="enabledServices">The list of the enabled wallet services..</param>
        /// <param name="lastModified">The date and time when the wallet services settings were last modified..</param>
        public TenantWalletServiceSettings(List<TenantWalletServiceSettings.EnabledServicesEnum> enabledServices = default, DateTime lastModified = default)
        {
            this.EnabledServices = enabledServices;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// The list of the enabled wallet services.
        /// </summary>
        /// <value>The list of the enabled wallet services.</value>
        /*
        <example>[-11,-12]</example>
        */
        [DataMember(Name = "enabledServices", EmitDefaultValue = true)]
        public List<TenantWalletServiceSettings.EnabledServicesEnum> EnabledServices { get; set; }

        /// <summary>
        /// The date and time when the wallet services settings were last modified.
        /// </summary>
        /// <value>The date and time when the wallet services settings were last modified.</value>
        /*
        <example>1990-01-01T00:00Z</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantWalletServiceSettings {\n");
            sb.Append("  EnabledServices: ").Append(EnabledServices).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
