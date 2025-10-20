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
    /// The cookie settings.
    /// </summary>
    [DataContract(Name = "CookieSettingsDto")]
    public partial class CookieSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CookieSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CookieSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CookieSettingsDto" /> class.
        /// </summary>
        /// <param name="lifeTime">The cookie lifetime value in minutes. (required).</param>
        /// <param name="enabled">Specifies if the cookie settings are enabled or not. (required).</param>
        public CookieSettingsDto(int lifeTime = default, bool enabled = default)
        {
            this.LifeTime = lifeTime;
            this.Enabled = enabled;
        }

        /// <summary>
        /// The cookie lifetime value in minutes.
        /// </summary>
        /// <value>The cookie lifetime value in minutes.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "lifeTime", IsRequired = true, EmitDefaultValue = true)]
        public int LifeTime { get; set; }

        /// <summary>
        /// Specifies if the cookie settings are enabled or not.
        /// </summary>
        /// <value>Specifies if the cookie settings are enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CookieSettingsDto {\n");
            sb.Append("  LifeTime: ").Append(LifeTime).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
