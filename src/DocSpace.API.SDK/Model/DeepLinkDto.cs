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
    /// What a mobile client needs to hand a portal link to the installed application instead of the browser.
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
        /// <param name="androidPackageName">The package name to look for on Android, and to build a store link from when the application is missing.  All three fields are empty strings on an installation that ships no mobile application, which is the  signal to keep opening links in the browser. (required).</param>
        /// <param name="url">The address the client redirects a portal link through so that the application can claim it. It is the  installation&#39;s own deep-link host, not a link to any particular document. (required).</param>
        /// <param name="iosPackageId">The bundle identifier to look for on iOS, used the same way as &#x60;androidPackageName&#x60;. (required).</param>
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
        /// The package name to look for on Android, and to build a store link from when the application is missing.  All three fields are empty strings on an installation that ships no mobile application, which is the  signal to keep opening links in the browser.
        /// </summary>
        /// <example>com.example.docspace</example>
        [DataMember(Name = "androidPackageName", IsRequired = true, EmitDefaultValue = true)]
        public string AndroidPackageName { get; set; }

        /// <summary>
        /// The address the client redirects a portal link through so that the application can claim it. It is the  installation&#39;s own deep-link host, not a link to any particular document.
        /// </summary>
        /// <example>https://example.com/deeplink</example>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The bundle identifier to look for on iOS, used the same way as &#x60;androidPackageName&#x60;.
        /// </summary>
        /// <example>com.example.docspace</example>
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
