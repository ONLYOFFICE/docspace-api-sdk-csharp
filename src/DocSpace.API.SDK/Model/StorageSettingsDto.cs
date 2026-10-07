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
    /// The storage the portal keeps its data in, or serves its static content from.
    /// </summary>
    [DataContract(Name = "StorageSettingsDto")]
    public partial class StorageSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageSettingsDto" /> class.
        /// </summary>
        /// <param name="module">The storage module, or &#x60;null&#x60; when the built-in storage is used..</param>
        /// <param name="props">The connection properties stored for the module..</param>
        /// <param name="lastModified">When the settings were last stored..</param>
        public StorageSettingsDto(string module = default, Dictionary<string, string> props = default, DateTime lastModified = default)
        {
            this.Module = module;
            this.Props = props;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// The storage module, or &#x60;null&#x60; when the built-in storage is used.
        /// </summary>
        /// <example>S3</example>
        [DataMember(Name = "module", EmitDefaultValue = true)]
        public string Module { get; set; }

        /// <summary>
        /// The connection properties stored for the module.
        /// </summary>
        /// <example>{"region":"eu-central-1","bucket":"tenant-files"}</example>
        [DataMember(Name = "props", EmitDefaultValue = false)]
        public Dictionary<string, string> Props { get; set; }

        /// <summary>
        /// When the settings were last stored.
        /// </summary>
        /// <example>2025-01-01T12:00:00Z</example>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageSettingsDto {\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
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
