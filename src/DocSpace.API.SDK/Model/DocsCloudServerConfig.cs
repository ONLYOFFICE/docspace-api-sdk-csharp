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
    /// Represents the server configuration of a DocsCloud tenant.
    /// </summary>
    [DataContract(Name = "DocsCloudServerConfig")]
    public partial class DocsCloudServerConfig : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudServerConfig" /> class.
        /// </summary>
        /// <param name="isAnonymousSupport">Whether anonymous access is supported..</param>
        /// <param name="fileSizeLimit">The maximum file size in bytes..</param>
        public DocsCloudServerConfig(bool isAnonymousSupport = default, long fileSizeLimit = default)
        {
            this.IsAnonymousSupport = isAnonymousSupport;
            this.FileSizeLimit = fileSizeLimit;
        }

        /// <summary>
        /// Whether anonymous access is supported.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isAnonymousSupport", EmitDefaultValue = true)]
        public bool IsAnonymousSupport { get; set; }

        /// <summary>
        /// The maximum file size in bytes.
        /// </summary>
        /// <example>104857600</example>
        [DataMember(Name = "fileSizeLimit", EmitDefaultValue = false)]
        public long FileSizeLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudServerConfig {\n");
            sb.Append("  IsAnonymousSupport: ").Append(IsAnonymousSupport).Append("\n");
            sb.Append("  FileSizeLimit: ").Append(FileSizeLimit).Append("\n");
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
            // FileSizeLimit (long) maximum
            if (this.FileSizeLimit > (long)209715200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileSizeLimit, must be a value less than or equal to 209715200.", new [] { "FileSizeLimit" });
            }

            // FileSizeLimit (long) minimum
            if (this.FileSizeLimit < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileSizeLimit, must be a value greater than or equal to 0.", new [] { "FileSizeLimit" });
            }

            yield break;
        }

    }


}
