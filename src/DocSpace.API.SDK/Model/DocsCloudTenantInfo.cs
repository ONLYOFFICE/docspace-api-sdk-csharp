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
    /// Represents the license and server information of a DocsCloud tenant, with usage statistics for the current period.
    /// </summary>
    [DataContract(Name = "DocsCloudTenantInfo")]
    public partial class DocsCloudTenantInfo : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudTenantInfo" /> class.
        /// </summary>
        /// <param name="license">The license information..</param>
        /// <param name="server">The DocsCloud server information..</param>
        /// <param name="usersLimit">The user limits of the license..</param>
        /// <param name="stats">The usage statistics for the current period..</param>
        public DocsCloudTenantInfo(DocsCloudLicenseInfo license = default, DocsCloudServerInfo server = default, DocsCloudUsersLimit usersLimit = default, DocsCloudStats stats = default)
        {
            this.License = license;
            this.Server = server;
            this.UsersLimit = usersLimit;
            this.Stats = stats;
        }

        /// <summary>
        /// The license information.
        /// </summary>
        [DataMember(Name = "license", EmitDefaultValue = false)]
        public DocsCloudLicenseInfo License { get; set; }

        /// <summary>
        /// The DocsCloud server information.
        /// </summary>
        [DataMember(Name = "server", EmitDefaultValue = false)]
        public DocsCloudServerInfo Server { get; set; }

        /// <summary>
        /// The user limits of the license.
        /// </summary>
        [DataMember(Name = "usersLimit", EmitDefaultValue = false)]
        public DocsCloudUsersLimit UsersLimit { get; set; }

        /// <summary>
        /// The usage statistics for the current period.
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        public DocsCloudStats Stats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudTenantInfo {\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  UsersLimit: ").Append(UsersLimit).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
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
