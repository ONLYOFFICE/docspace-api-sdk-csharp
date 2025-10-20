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
    /// The deep link parameters.
    /// </summary>
    [DataContract(Name = "DeepLinkDto")]
    public partial class DeepLinkDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeepLinkDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeepLinkDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeepLinkDto" /> class.
        /// </summary>
        /// <param name="androidPackageName">The Android package name. (required).</param>
        /// <param name="url">The deep link URL. (required).</param>
        /// <param name="iosPackageId">The deep link IOS package ID. (required).</param>
        public DeepLinkDto(string androidPackageName = default, string url = default, string iosPackageId = default)
        {
            // to ensure "androidPackageName" is required (not null)
            if (androidPackageName == null)
            {
                throw new ArgumentNullException("androidPackageName is a required property for DeepLinkDto and cannot be null");
            }
            this.AndroidPackageName = androidPackageName;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for DeepLinkDto and cannot be null");
            }
            this.Url = url;
            // to ensure "iosPackageId" is required (not null)
            if (iosPackageId == null)
            {
                throw new ArgumentNullException("iosPackageId is a required property for DeepLinkDto and cannot be null");
            }
            this.IosPackageId = iosPackageId;
        }

        /// <summary>
        /// The Android package name.
        /// </summary>
        /// <value>The Android package name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "androidPackageName", IsRequired = true, EmitDefaultValue = true)]
        public string AndroidPackageName { get; set; }

        /// <summary>
        /// The deep link URL.
        /// </summary>
        /// <value>The deep link URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The deep link IOS package ID.
        /// </summary>
        /// <value>The deep link IOS package ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "iosPackageId", IsRequired = true, EmitDefaultValue = true)]
        public string IosPackageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeepLinkDto {\n");
            sb.Append("  AndroidPackageName: ").Append(AndroidPackageName).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IosPackageId: ").Append(IosPackageId).Append("\n");
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
