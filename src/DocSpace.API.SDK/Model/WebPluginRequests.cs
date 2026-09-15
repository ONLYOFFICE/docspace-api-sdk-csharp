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
    /// The state the portal keeps for an installed web plugin: whether it runs, and its own settings blob.
    /// </summary>
    [DataContract(Name = "WebPluginRequests")]
    public partial class WebPluginRequests : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebPluginRequests" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebPluginRequests() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebPluginRequests" /> class.
        /// </summary>
        /// <param name="enabled">Whether the plugin runs in this portal. Switching it on adds the domains its manifest declares to the portal  Content Security Policy and switching it off takes them away again; connected clients are told of the new  state without a reload..</param>
        /// <param name="settings">The configuration the plugin reads at run time, as a JSON document serialised into a string. Its shape is  defined by the plugin and not by the portal, which stores it encrypted for this portal alone. It replaces  whatever was stored rather than merging into it, so send &#x60;{}&#x60; when there is nothing to keep. (required).</param>
        public WebPluginRequests(bool enabled = default, string settings = default)
        {
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for WebPluginRequests and cannot be null");
            }
            this.Settings = settings;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Whether the plugin runs in this portal. Switching it on adds the domains its manifest declares to the portal  Content Security Policy and switching it off takes them away again; connected clients are told of the new  state without a reload.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The configuration the plugin reads at run time, as a JSON document serialised into a string. Its shape is  defined by the plugin and not by the portal, which stores it encrypted for this portal alone. It replaces  whatever was stored rather than merging into it, so send &#x60;{}&#x60; when there is nothing to keep.
        /// </summary>
        /// <example>{"theme":"dark","autoSave":true}</example>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public string Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebPluginRequests {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            // Settings (string) maxLength
            if (this.Settings != null && this.Settings.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Settings, length must be less than 255.", new [] { "Settings" });
            }

            // Settings (string) minLength
            if (this.Settings != null && this.Settings.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Settings, length must be greater than 0.", new [] { "Settings" });
            }

            yield break;
        }

    }


}
