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
    /// Whether one branding slot still holds the built-in image or wordmark.
    /// </summary>
    [DataContract(Name = "IsDefaultWhiteLabelLogosDto")]
    public partial class IsDefaultWhiteLabelLogosDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IsDefaultWhiteLabelLogosDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IsDefaultWhiteLabelLogosDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IsDefaultWhiteLabelLogosDto" /> class.
        /// </summary>
        /// <param name="name">The stable name of the slot, matching the &#x60;name&#x60; of the same slot in  &#x60;GET api/2.0/settings/whitelabel/logos&#x60; - &#x60;LightSmall&#x60;, &#x60;LoginPage&#x60;, &#x60;Favicon&#x60;, &#x60;DocsEditor&#x60; and the rest,  plus &#x60;Notification&#x60;, which that list leaves out. The wordmark check reports the fixed name &#x60;logotext&#x60;  instead of a slot. (required).</param>
        /// <param name="default">Whether the slot has never been written for this portal, in which case the built-in image is what gets  rendered. It turns &#x60;false&#x60; once an image has been stored, for either the light or the dark theme, and back  to &#x60;true&#x60; after the matching restore operation. For &#x60;logotext&#x60; it stays &#x60;true&#x60; when the built-in wordmark  itself is saved, because saving that value counts as clearing the setting. (required).</param>
        public IsDefaultWhiteLabelLogosDto(string name = default, bool @default = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for IsDefaultWhiteLabelLogosDto and cannot be null");
            }
            this.Name = name;
            this.Default = @default;
        }

        /// <summary>
        /// The stable name of the slot, matching the &#x60;name&#x60; of the same slot in  &#x60;GET api/2.0/settings/whitelabel/logos&#x60; - &#x60;LightSmall&#x60;, &#x60;LoginPage&#x60;, &#x60;Favicon&#x60;, &#x60;DocsEditor&#x60; and the rest,  plus &#x60;Notification&#x60;, which that list leaves out. The wordmark check reports the fixed name &#x60;logotext&#x60;  instead of a slot.
        /// </summary>
        /// <example>LightSmall</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Whether the slot has never been written for this portal, in which case the built-in image is what gets  rendered. It turns &#x60;false&#x60; once an image has been stored, for either the light or the dark theme, and back  to &#x60;true&#x60; after the matching restore operation. For &#x60;logotext&#x60; it stays &#x60;true&#x60; when the built-in wordmark  itself is saved, because saving that value counts as clearing the setting.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "default", IsRequired = true, EmitDefaultValue = true)]
        public bool Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsDefaultWhiteLabelLogosDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
