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
    /// Represents the DocsCloud server information.
    /// </summary>
    [DataContract(Name = "DocsCloudServerInfo")]
    public partial class DocsCloudServerInfo : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudServerInfo" /> class.
        /// </summary>
        /// <param name="version">The server version..</param>
        /// <param name="packageType">The server package type (Open Source, Enterprise Edition or Developer Edition)..</param>
        /// <param name="date">The server build date..</param>
        public DocsCloudServerInfo(string version = default, string packageType = default, DateTime date = default)
        {
            this.@Version = version;
            this.PackageType = packageType;
            this.Date = date;
        }

        /// <summary>
        /// The server version.
        /// </summary>
        /// <value>The server version.</value>
        /*
        <example>8.0.0</example>
        */
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string @Version { get; set; }

        /// <summary>
        /// The server package type (Open Source, Enterprise Edition or Developer Edition).
        /// </summary>
        /// <value>The server package type (Open Source, Enterprise Edition or Developer Edition).</value>
        /*
        <example>Enterprise Edition</example>
        */
        [DataMember(Name = "packageType", EmitDefaultValue = true)]
        public string PackageType { get; set; }

        /// <summary>
        /// The server build date.
        /// </summary>
        /// <value>The server build date.</value>
        /*
        <example>2024-01-15T10:30Z</example>
        */
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudServerInfo {\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  PackageType: ").Append(PackageType).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
