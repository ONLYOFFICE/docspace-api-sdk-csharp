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
    /// The storage settings.
    /// </summary>
    [DataContract(Name = "StorageSettings")]
    public partial class StorageSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageSettings" /> class.
        /// </summary>
        /// <param name="module">The storage name..</param>
        /// <param name="props">The storage properties..</param>
        /// <param name="lastModified">The date and time when the storage settings were last modified..</param>
        public StorageSettings(string module = default, Dictionary<string, string> props = default, DateTime lastModified = default)
        {
            this.Module = module;
            this.Props = props;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// The storage name.
        /// </summary>
        /// <example>LocalStorage</example>
        [DataMember(Name = "module", EmitDefaultValue = true)]
        public string Module { get; set; }

        /// <summary>
        /// The storage properties.
        /// </summary>
        /// <example>{"region":"eu-central-1","bucket":"tenant-files"}</example>
        [DataMember(Name = "props", EmitDefaultValue = false)]
        public Dictionary<string, string> Props { get; set; }

        /// <summary>
        /// The date and time when the storage settings were last modified.
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
            sb.Append("class StorageSettings {\n");
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
