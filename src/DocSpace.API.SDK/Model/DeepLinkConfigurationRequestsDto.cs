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
    /// How the portal opens its links on a mobile device.
    /// </summary>
    [DataContract(Name = "DeepLinkConfigurationRequestsDto")]
    public partial class DeepLinkConfigurationRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeepLinkConfigurationRequestsDto" /> class.
        /// </summary>
        /// <param name="deepLinkSettings">The deep link configuration to store. Only its &#x60;handlingMode&#x60; is read - whether a link always opens in the  browser, always in the native application, or asks the user each time - and a mode outside the defined set is  refused with 400 before anything is stored..</param>
        public DeepLinkConfigurationRequestsDto(TenantDeepLinkSettings deepLinkSettings = default)
        {
            this.DeepLinkSettings = deepLinkSettings;
        }

        /// <summary>
        /// The deep link configuration to store. Only its &#x60;handlingMode&#x60; is read - whether a link always opens in the  browser, always in the native application, or asks the user each time - and a mode outside the defined set is  refused with 400 before anything is stored.
        /// </summary>
        [DataMember(Name = "deepLinkSettings", EmitDefaultValue = false)]
        public TenantDeepLinkSettings DeepLinkSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeepLinkConfigurationRequestsDto {\n");
            sb.Append("  DeepLinkSettings: ").Append(DeepLinkSettings).Append("\n");
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
