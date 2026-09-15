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
    /// What the installation allows to be done with web plugins.
    /// </summary>
    [DataContract(Name = "PluginsDto")]
    public partial class PluginsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsDto" /> class.
        /// </summary>
        /// <param name="enabled">Whether web plugins run on this portal at all. While it is &#x60;false&#x60; the operations under  &#x60;api/2.0/settings/webplugins&#x60; are of no use, whatever the other two flags say. All three are &#x60;false&#x60;  unless the installation switched plugins on in its configuration..</param>
        /// <param name="upload">Whether an administrator may add a plugin of their own through  &#x60;POST api/2.0/settings/webplugins&#x60;. While it is &#x60;false&#x60; only the plugins that ship with the installation  are available..</param>
        /// <param name="delete">Whether an added plugin may be removed again through &#x60;DELETE api/2.0/settings/webplugins/{name}&#x60;. The  plugins that ship with the installation cannot be removed regardless of this flag..</param>
        public PluginsDto(bool enabled = default, bool upload = default, bool delete = default)
        {
            this.Enabled = enabled;
            this.Upload = upload;
            this.Delete = delete;
        }

        /// <summary>
        /// Whether web plugins run on this portal at all. While it is &#x60;false&#x60; the operations under  &#x60;api/2.0/settings/webplugins&#x60; are of no use, whatever the other two flags say. All three are &#x60;false&#x60;  unless the installation switched plugins on in its configuration.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether an administrator may add a plugin of their own through  &#x60;POST api/2.0/settings/webplugins&#x60;. While it is &#x60;false&#x60; only the plugins that ship with the installation  are available.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "upload", EmitDefaultValue = true)]
        public bool Upload { get; set; }

        /// <summary>
        /// Whether an added plugin may be removed again through &#x60;DELETE api/2.0/settings/webplugins/{name}&#x60;. The  plugins that ship with the installation cannot be removed regardless of this flag.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "delete", EmitDefaultValue = true)]
        public bool Delete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginsDto {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Upload: ").Append(Upload).Append("\n");
            sb.Append("  Delete: ").Append(Delete).Append("\n");
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
