/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The plugins parameters.
    /// </summary>
    [DataContract(Name = "PluginsDto")]
    public partial class PluginsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginsDto" /> class.
        /// </summary>
        /// <param name="enabled">Specifies if the plugins are enabled or not..</param>
        /// <param name="upload">Specifies if the plugins can be uploaded or not..</param>
        /// <param name="delete">Specifies if the plugins can be deleted or not..</param>
        public PluginsDto(bool enabled = default, bool upload = default, bool delete = default)
        {
            this.Enabled = enabled;
            this.Upload = upload;
            this.Delete = delete;
        }

        /// <summary>
        /// Specifies if the plugins are enabled or not.
        /// </summary>
        /// <value>Specifies if the plugins are enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Specifies if the plugins can be uploaded or not.
        /// </summary>
        /// <value>Specifies if the plugins can be uploaded or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "upload", EmitDefaultValue = true)]
        public bool Upload { get; set; }

        /// <summary>
        /// Specifies if the plugins can be deleted or not.
        /// </summary>
        /// <value>Specifies if the plugins can be deleted or not.</value>
        /*
        <example>true</example>
        */
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
