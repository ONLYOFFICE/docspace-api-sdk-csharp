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
    /// Represents the current user quota of a DocsCloud tenant.
    /// </summary>
    [DataContract(Name = "DocsCloudQuota")]
    public partial class DocsCloudQuota : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudQuota" /> class.
        /// </summary>
        /// <param name="users">The editor users..</param>
        /// <param name="usersView">The viewer users..</param>
        public DocsCloudQuota(List<DocsCloudQuotaUser> users = default, List<DocsCloudQuotaUser> usersView = default)
        {
            this.Users = users;
            this.UsersView = usersView;
        }

        /// <summary>
        /// The editor users.
        /// </summary>
        /// <value>The editor users.</value>
        /*
        <example>[{"userid":"00000000-0000-0000-0000-000000000000","expire":"2024-01-15T10:30:00Z"}]</example>
        */
        [DataMember(Name = "users", EmitDefaultValue = true)]
        public List<DocsCloudQuotaUser> Users { get; set; }

        /// <summary>
        /// The viewer users.
        /// </summary>
        /// <value>The viewer users.</value>
        /*
        <example>[{"userid":"00000000-0000-0000-0000-000000000000","expire":"2024-01-15T10:30:00Z"}]</example>
        */
        [DataMember(Name = "usersView", EmitDefaultValue = true)]
        public List<DocsCloudQuotaUser> UsersView { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudQuota {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  UsersView: ").Append(UsersView).Append("\n");
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
