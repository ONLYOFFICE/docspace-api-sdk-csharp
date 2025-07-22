// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The configuration settings for the web plugin instance.
    /// </summary>
    [DataContract(Name = "WebPluginRequests")]
    public partial class WebPluginRequests : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebPluginRequests" /> class.
        /// </summary>
        /// <param name="enabled">Controls whether the web plugin is active and operational..</param>
        /// <param name="settings">The JSON-formatted configuration settings for the web plugin..</param>
        public WebPluginRequests(bool enabled = default, string settings = default)
        {
            this.Enabled = enabled;
            this.Settings = settings;
        }

        /// <summary>
        /// Controls whether the web plugin is active and operational.
        /// </summary>
        /// <value>Controls whether the web plugin is active and operational.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The JSON-formatted configuration settings for the web plugin.
        /// </summary>
        /// <value>The JSON-formatted configuration settings for the web plugin.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "settings", EmitDefaultValue = true)]
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
