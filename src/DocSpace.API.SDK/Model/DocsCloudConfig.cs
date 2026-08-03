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
    /// Represents the configuration of a DocsCloud tenant.
    /// </summary>
    [DataContract(Name = "DocsCloudConfig")]
    public partial class DocsCloudConfig : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudConfig" /> class.
        /// </summary>
        /// <param name="tenantName">The tenant name..</param>
        /// <param name="security">security.</param>
        /// <param name="server">server.</param>
        /// <param name="wopi">wopi.</param>
        /// <param name="ipFilter">ipFilter.</param>
        public DocsCloudConfig(string tenantName = default, DocsCloudSecurityConfig security = default, DocsCloudServerConfig server = default, DocsCloudWopiConfig wopi = default, DocsCloudIpFilterConfig ipFilter = default)
        {
            this.TenantName = tenantName;
            this.Security = security;
            this.Server = server;
            this.Wopi = wopi;
            this.IpFilter = ipFilter;
        }

        /// <summary>
        /// The tenant name.
        /// </summary>
        /// <value>The tenant name.</value>
        /*
        <example>My Portal</example>
        */
        [DataMember(Name = "tenantName", EmitDefaultValue = true)]
        public string TenantName { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = false)]
        public DocsCloudSecurityConfig Security { get; set; }

        /// <summary>
        /// Gets or Sets Server
        /// </summary>
        [DataMember(Name = "server", EmitDefaultValue = false)]
        public DocsCloudServerConfig Server { get; set; }

        /// <summary>
        /// Gets or Sets Wopi
        /// </summary>
        [DataMember(Name = "wopi", EmitDefaultValue = false)]
        public DocsCloudWopiConfig Wopi { get; set; }

        /// <summary>
        /// Gets or Sets IpFilter
        /// </summary>
        [DataMember(Name = "ipFilter", EmitDefaultValue = false)]
        public DocsCloudIpFilterConfig IpFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudConfig {\n");
            sb.Append("  TenantName: ").Append(TenantName).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  Wopi: ").Append(Wopi).Append("\n");
            sb.Append("  IpFilter: ").Append(IpFilter).Append("\n");
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
