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
    /// The download request item with conversion parameters and security settings.
    /// </summary>
    [DataContract(Name = "DownloadRequestItemDto")]
    public partial class DownloadRequestItemDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadRequestItemDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DownloadRequestItemDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadRequestItemDto" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        /// <param name="value">The target format or conversion type for the file download. (required).</param>
        /// <param name="password">The optional password for accessing protected files..</param>
        public DownloadRequestItemDto(DownloadRequestItemDtoKey key = default, string value = default, string password = default)
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for DownloadRequestItemDto and cannot be null");
            }
            this.Key = key;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for DownloadRequestItemDto and cannot be null");
            }
            this.Value = value;
            this.Password = password;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public DownloadRequestItemDtoKey Key { get; set; }

        /// <summary>
        /// The target format or conversion type for the file download.
        /// </summary>
        /// <value>The target format or conversion type for the file download.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// The optional password for accessing protected files.
        /// </summary>
        /// <value>The optional password for accessing protected files.</value>
        /*
        <example>vfmf2vO1Kp</example>
        */
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadRequestItemDto {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
